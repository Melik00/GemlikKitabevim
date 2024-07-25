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
    public partial class FrmOgrenciIslemleri : Form
    {
        public FrmOgrenciIslemleri()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection("Data Source=Melik-Laptop;Initial Catalog=DboGemlikKitabevim;Integrated Security=True;");

        public void guncelle()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_OGRENCILER", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            gridControl1.DataSource = tablo;
            gridControl2.DataSource = tablo;
            baglanti.Close();
        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MskKaydetG_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string ogrenci_guncelle = "update TBL_OGRENCILER set ADSOYAD = '" + MskAdG.Text + "', DOGUMTARIHI = '" + MskDTG.Text + "', TELEFON= '" + MskTelefonG.Text + "', MAIL= '" + MskMailG.Text + "', UYELIKTARIHI= '" + MskUTG.Text + "', CINSIYET= '" + MskCinsiyetG.Text + "', TCNO= '" + MskTcG.Text + "', ADRES= '" + MskAdresG.Text + "' where ID = '" + MskIDG.Text + "'";
            SqlCommand komut = new SqlCommand(ogrenci_guncelle, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            guncelle();
        }

        private void FrmOgrenciIslemleri_Load(object sender, EventArgs e)
        {
            guncelle();
        }

        private void MskKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string ogrenci_kaydet = "insert into TBL_OGRENCILER (ADSOYAD, DOGUMTARIHI, TELEFON, MAIL, UYELIKTARIHI, CINSIYET, TCNO, ADRES) values (@ADSOYAD, @DOGUMTARIHI, @TELEFON, @MAIL, @UYELIKTARIHI, @CINSIYET, @TCNO, @ADRES)";
            SqlCommand komut = new SqlCommand(ogrenci_kaydet, baglanti);
            komut.Parameters.AddWithValue("@ADSOYAD", MskAd.Text);
            komut.Parameters.AddWithValue("@DOGUMTARIHI", MskDT.Text);
            komut.Parameters.AddWithValue("@TELEFON", MskTelefon.Text);
            komut.Parameters.AddWithValue("@MAIL", MskMail.Text);
            komut.Parameters.AddWithValue("@UYELIKTARIHI", MskUT.Text);
            komut.Parameters.AddWithValue("@CINSIYET", MskCinsiyet.Text);
            komut.Parameters.AddWithValue("@TCNO", MskTc.Text);
            komut.Parameters.AddWithValue("@ADRES", MskAdres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            guncelle();
        }

        private void MskSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string ogrenci_sil = "delete from TBL_OGRENCILER where ID = '" + MskIDS.Text + "'";
            SqlCommand komut = new SqlCommand(ogrenci_sil, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            guncelle();
        }
    }
}
