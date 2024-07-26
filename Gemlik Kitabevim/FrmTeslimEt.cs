using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gemlik_Kitabevim
{
    public partial class FrmTeslimEt : Form
    {
        public FrmTeslimEt()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        public SqlConnection baglanti = new SqlConnection("Data Source=Melik-Laptop;Initial Catalog=DboGemlikKitabevim;Integrated Security=True;");

        DboGemlikKitabevimEntities db = new DboGemlikKitabevimEntities();

        public void guncelle()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_KITAPLAR", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            gridControl1.DataSource = tablo;
            baglanti.Close();
        }

        public void guncelle1()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_KAYITLAR", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            gridControl2.DataSource = tablo;
            baglanti.Close();
        }

        private void FrmTeslimEt_Load(object sender, EventArgs e)
        {
            guncelle();
            guncelle1();

        }



        public void ÖğrenciBul()
        {
            // Öğrenci ID'sini al.
            string ogrenciKimlikNo = TcBul.Text;

            // Veritabanına bağlantı kur.

            // SQL sorgusu oluştur.
            string sql = "SELECT * FROM TBL_OGRENCILER WHERE TCNO = @TCNO";

            // SQL komutu oluştur.
            SqlCommand cmd = new SqlCommand(sql, baglanti);

            // Parametreyi ekle.
            cmd.Parameters.AddWithValue("@TCNO", ogrenciKimlikNo);

            // Bağlantıyı aç.
            baglanti.Open();

            // Sorguyu çalıştır.
            SqlDataReader reader = cmd.ExecuteReader();

            // Eğer öğrenci bulunursa, bilgileri al.
            if (reader.Read())
            {
                // Öğrenci ID'sini göster.
                OgrenciID.Text = reader["ID"].ToString();

                // Öğrenci adını göster.
                OgrenciAd.Text = reader["ADSOYAD"].ToString();

                // Öğrenci soyadını göster.
                TC.Text = reader["TCNO"].ToString();
            }
            else
            {
                // Öğrenci bulunamadıysa, hata mesajı göster.
                MessageBox.Show("Öğrenci bulunamadı.");
            }

            // Bağlantıyı kapat.
            baglanti.Close();
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ÖğrenciBul();
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }




        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Girdi değerlerini alın.
            string ogrenciTC = OgrenciTC.Text;
            string kitapID = KitapID.Text;

            // Veritabanına bağlanın.
            using (var baglanti = new SqlConnection("Data Source=Melik-Laptop;Initial Catalog=DboGemlikKitabevim;Integrated Security=True;"))
            {
                // Kitap ID'ye göre kitabı arayın.
                string kitapSorgu = "SELECT * FROM TBL_KITAPLAR WHERE KITAPID = @KITAPID";
                using (var kitapKomut = new SqlCommand(kitapSorgu, baglanti))
                {
                    kitapKomut.Parameters.AddWithValue("@KITAPID", kitapID);
                    baglanti.Open();
                    using (var kitapReader = kitapKomut.ExecuteReader())
                    {
                        if (kitapReader.Read())
                        {
                            // Kitap bulundu.
                            kitapReader.Close(); // Reader'ı kapatıyoruz.

                            // Öğrenci TC'ye göre öğrenciyi arayın.
                            string ogrenciSorgu = "SELECT * FROM TBL_OGRENCILER WHERE TCNO = @TCNO";
                            using (var ogrenciKomut = new SqlCommand(ogrenciSorgu, baglanti))
                            {
                                ogrenciKomut.Parameters.AddWithValue("@TCNO", ogrenciTC);
                                using (var ogrenciReader = ogrenciKomut.ExecuteReader())
                                {
                                    if (ogrenciReader.Read())
                                    {
                                        // Öğrenci bulundu.
                                        string ogrenciID = ogrenciReader["ID"].ToString();
                                        ogrenciReader.Close(); // Reader'ı kapatıyoruz.

                                        // Kitap teslimi işlemini yapın.
                                        string teslimSorgu = "INSERT INTO TBL_KAYITLAR (KULLANICI, KITAPID, ALISTARIH, SONTARIH, DURUM) VALUES (@KULLANICI, @KITAPID, @ALISTARIH, @SONTARIH, @DURUM)";
                                        using (var teslimKomut = new SqlCommand(teslimSorgu, baglanti))
                                        {
                                            // Parametreleri ekliyoruz.
                                            teslimKomut.Parameters.AddWithValue("@KULLANICI", ogrenciID);
                                            teslimKomut.Parameters.AddWithValue("@KITAPID", kitapID);
                                            teslimKomut.Parameters.AddWithValue("@ALISTARIH", DateTime.Now);
                                            teslimKomut.Parameters.AddWithValue("@SONTARIH", DateTime.Now.AddDays(30));
                                            teslimKomut.Parameters.AddWithValue("@DURUM", false); // true aktif anlamında olabilir

                                            teslimKomut.ExecuteNonQuery();

                                            // GridControl2'ye veriyi yükleyin.
                                            gridControl2.DataSource = GetTeslimler();
                                            GridView gridView = gridControl2.MainView as GridView;
                                            gridView.PopulateColumns();
                                        }
                                        XtraMessageBox.Show("Kitap teslim edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        XtraMessageBox.Show("Öğrenci bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Kitap bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        // Teslimler tablosundan verileri çeken metod.
        private DataTable GetTeslimler()
        {
            DataTable teslimler = new DataTable();
            using (var connection = new SqlConnection("Data Source=Melik-Laptop;Initial Catalog=DboGemlikKitabevim;Integrated Security=True;"))
            {
                string teslimSorgu = "SELECT * FROM TBL_KAYITLAR";
                using (var teslimKomut = new SqlCommand(teslimSorgu, connection))
                {
                    connection.Open();
                    using (var teslimReader = teslimKomut.ExecuteReader())
                    {
                        teslimler.Load(teslimReader);
                    }
                }
            }
            return teslimler;
        }

        






















        /*private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // TextBox'a girilen text
            string kitapAdi = KitapID.Text;

            // SQL sorgusu
            string sorgu = "SELECT * FROM TBL_KITAPLAR WHERE KITAPAD LIKE '%" + kitapAdi + "%'";

            // SqlCommand nesnesi oluştur
            using (SqlCommand command = new SqlCommand(sorgu, baglanti))
            {
                // Bağlantıyı aç
                baglanti.Open();

                // Sorguyu çalıştır
                SqlDataReader reader = command.ExecuteReader();

                // Eğer veri varsa
                if (reader.HasRows)
                {
                    // GridControl'ü temizle
                    gridControl2.DataSource = null;

                    // DataTable oluştur
                    DataTable dt = new DataTable();

                    // Sütunları ekle
                    dt.Columns.Add("KitapID");
                    dt.Columns.Add("KITAPAD");

                    // Her satırı DataTable'a ekle
                    while (reader.Read())
                    {
                        dt.Rows.Add(reader["ID"], reader["KITAPAD"]);
                    }

                    // GridControl'e DataSource ata
                    gridControl2.DataSource = dt;
                }
                else
                {
                    // Veri yoksa uyarı mesajı göster
                    MessageBox.Show("Eşleşen kitap bulunamadı.");
                }

                // Bağlantıyı kapat
                baglanti.Close();
            }
        }*/
    }
}


