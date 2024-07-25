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
    public partial class FrmTeslimAl : Form
    {
        public FrmTeslimAl()
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
        private void FrmTeslimAl_Load(object sender, EventArgs e)
        {
            guncelle();
            guncelle1();
        }
    }
}
