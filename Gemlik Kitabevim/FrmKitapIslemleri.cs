using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gemlik_Kitabevim
{
    public partial class FrmKitapIslemleri : Form
    {
        public FrmKitapIslemleri()
        {
            InitializeComponent();
        }

        public void guncelle()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_KITAPLAR", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            gridControl1.DataSource = tablo;
            gridControl2.DataSource = tablo;
            baglanti.Close();
        }

        public SqlConnection baglanti = new SqlConnection("Data Source=Melik-Laptop;Initial Catalog=DboGemlikKitabevim;Integrated Security=True;");

        private void MskDT_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MskTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            using (var baglanti = new SqlConnection("Data Source=Melik-Laptop;Initial Catalog=DboGemlikKitabevim;Integrated Security=True;"))
            {
                baglanti.Open();

                // KITAPID sütunu için bir değer sağlamaya gerek yok, çünkü auto-increment (IDENTITY) olabilir
                string sorgu_kaydet = "INSERT INTO TBL_KITAPLAR (KITAPAD, KONUSU, YAZARI, SAYFASI, YAYINEVI) VALUES (@KITAPAD, @KONUSU, @YAZARI, @SAYFASI, @YAYINEVI)";

                using (var komut = new SqlCommand(sorgu_kaydet, baglanti))
                {
                    komut.Parameters.AddWithValue("@KITAPAD", KitapAd.Text);
                    komut.Parameters.AddWithValue("@KONUSU", Konusu.Text);
                    komut.Parameters.AddWithValue("@YAZARI", Yazarı.Text);
                    komut.Parameters.AddWithValue("@SAYFASI", Sayfa.Text);
                    komut.Parameters.AddWithValue("@YAYINEVI", Yayınevi.Text);

                    komut.ExecuteNonQuery();
                }

                baglanti.Close();

                // UI'ı güncelle
                guncelle();

                // Başarı mesajı göster
                MessageBox.Show("Kitap başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void KitapIslemleri_Load(object sender, EventArgs e)
        {
            guncelle();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu_guncelle = "update TBL_KITAPLAR set KITAPAD = '" + KitapAdG.Text + "', KONUSU = '" + KonusuG.Text + "', YAZARI = '"+YazarıG.Text+"', SAYFASI = '"+SayfaG.Text +"', YAYINEVI = '"+YayıneviG.Text +"' where KITAPID = '" + IDG.Text + "'";
            SqlCommand komut = new SqlCommand(sorgu_guncelle, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            guncelle();

            MessageBox.Show("Kitap başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            string kitapID = IDS.Text;

            // Veritabanı bağlantısını oluşturun ve açın
            using (var baglanti = new SqlConnection("Data Source=Melik-Laptop;Initial Catalog=DboGemlikKitabevim;Integrated Security=True;"))
            {
                baglanti.Open();

                // Önce, referanslı kayıtları silin
                string deleteKayitlarQuery = "DELETE FROM TBL_KAYITLAR WHERE KITAPID = @KITAPID";
                using (var deleteKayitlarKomut = new SqlCommand(deleteKayitlarQuery, baglanti))
                {
                    deleteKayitlarKomut.Parameters.AddWithValue("@KITAPID", kitapID);
                    deleteKayitlarKomut.ExecuteNonQuery();
                }

                // Sonra, kitabı silin
                string deleteKitapQuery = "DELETE FROM TBL_KITAPLAR WHERE KITAPID = @KITAPID";
                using (var deleteKitapKomut = new SqlCommand(deleteKitapQuery, baglanti))
                {
                    deleteKitapKomut.Parameters.AddWithValue("@KITAPID", kitapID);
                    deleteKitapKomut.ExecuteNonQuery();
                }

                // Bağlantıyı kapatın
                baglanti.Close();

                // Veriyi güncelleyin (örneğin, grid kontrolünü yenileyin)
                guncelle();

                // Başarı mesajı gösterin
                MessageBox.Show("Kitap başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void gridControl3_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
