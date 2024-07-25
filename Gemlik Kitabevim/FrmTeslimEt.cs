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

        

        public void guncelle()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_OGRENCILER", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            gridControl1.DataSource = tablo;
            baglanti.Close();
        }

        public void guncelle1()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_KITAPLAR", baglanti);
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
                OgrenciTc.Text = reader["TCNO"].ToString();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // TextBox'a girilen text
            string kitapAdi = KitapID.Text;

            // SQL sorgusu
            string sorgu = "SELECT * FROM TBL_KITAPLAR";

            // SqlCommand nesnesi oluştur
            using (SqlCommand command = new SqlCommand(sorgu, baglanti))
            {
                // Bağlantıyı aç
                baglanti.Open();

                // Sorguyu çalıştır
                SqlDataReader reader = command.ExecuteReader();

                // DataTable oluştur
                DataTable dt = new DataTable();
                dt.Load(reader);

                // Bağlantıyı kapat
                baglanti.Close();

                // Filter the data using Contains
                dt.DefaultView.RowFilter = "KITAPAD LIKE '%" + kitapAdi + "%'";

                // GridControl'ü temizle
                gridControl2.DataSource = null;

                // Filtered data to GridControl
                gridControl2.DataSource = dt.DefaultView.ToTable();
            }
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
