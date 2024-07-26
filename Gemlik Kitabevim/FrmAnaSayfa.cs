using DevExpress.XtraExport.Xls;
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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void öğrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciler ogrenciler = new FrmOgrenciler();
            ogrenciler.Show(); 
        }

        private void öğrenciİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciIslemleri ogrenciler = new FrmOgrenciIslemleri();
            ogrenciler.Show();
        }

        private void öğrencilerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kütüphanemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKitapIslemleri kitapislemleri = new FrmKitapIslemleri();
            kitapislemleri.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void teslimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTeslimAl teslimal = new FrmTeslimAl();
            teslimal.Show();
                }

        private void teslimEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTeslimEt teslimet = new FrmTeslimEt();
            teslimet.Show();
        }

        private void kütüphanemToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void kitaplarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmKitaplarim kitaplarim = new FrmKitaplarim();
            kitaplarim.Show();
        }

        private void girişYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kayıtlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKayitlar kayitlar = new FrmKayitlar();
            kayitlar.Show();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHakkinda hakkinda = new FrmHakkinda();
            hakkinda.Show();
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIletisim iletisim = new FrmIletisim();
            iletisim.Show();
        }
    }
}

/*﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Sosyal_Kitaplık
{
    class Baglanti
    {
        public MySqlConnection baglan = new MySqlConnection("Server='" + Properties.Settings.Default.server.ToString() + "';Database='" + Properties.Settings.Default.dbname.ToString() + "';Uid=root;Pwd='';Charset=utf8;");
        public void Baslat()
        {
            try
            {
                baglan.Open();
                if (baglan.State != ConnectionState.Closed)
                { }
                else
                    MessageBox.Show("Bağlantı Yapılamadı !");
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message, "Hata Oluştu !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Bitir()
        {
            try
            {
                baglan.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message, "Hata Oluştu !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //İşlemler
        public bool IsAdmin = false;
        public bool Login(string kAdi, string sifre)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("select UserName,Password,Admin from user where UserName='" + kAdi + "' and Password='" + sifre + "'", baglan);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("Bilgileriniz yanlış veya böyle bir hesap mevcut değil !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (dt.Rows[0][2].ToString() == "1")
                {
                    IsAdmin = true;
                }
                MessageBox.Show("Giriş Yapıldı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            dt.Clear();
            dt.Dispose();
        }

        public bool AddBook(string ad, string tur, string yazar, string basimyili, string sayfasayisi, string yayinevi, string ozet)
        {
            MySqlCommand insert = new MySqlCommand("insert into books(ID,KITAPADI,KITAPTURU,KITAPYAZARI,BASIMYILI,SAYFASAYISI,YAYINEVI,KITAPOZETI) values('',@name,@type,@author,@year,@pagecount,@publisher,@summary)", baglan);
            insert.Parameters.AddWithValue("@name", ad);
            insert.Parameters.AddWithValue("@type", tur);
            insert.Parameters.AddWithValue("@author", yazar);
            insert.Parameters.AddWithValue("@year", basimyili);
            insert.Parameters.AddWithValue("@pagecount", sayfasayisi);
            insert.Parameters.AddWithValue("@publisher", yayinevi);
            insert.Parameters.AddWithValue("@summary", ozet);
            Baslat();
            insert.Prepare();
            if (insert.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
            Bitir();
            insert.Dispose();
            GC.Collect();
        }

        //Kullanıcı Kayıt İşlemi
        public bool Register(string userName, string password, string email)
        {
            MySqlCommand insert = new MySqlCommand("insert into user(ID,UserName,Password,Mail,Admin) values('',@username,@pass,@mail,'')", baglan);
            insert.Parameters.AddWithValue("@username", userName);
            insert.Parameters.AddWithValue("@pass", password);
            insert.Parameters.AddWithValue("@mail", email);
            Baslat();
            insert.Prepare();
            if (insert.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
            Bitir();
            insert.Dispose();
            GC.Collect();
        }

        //İstatistikler
        public string TotalAccountCount()
        {
            MySqlCommand getCount = new MySqlCommand("select count(ID) from user", baglan);
            Baslat();
            string count = getCount.ExecuteScalar().ToString();
            Bitir();
            return count;
            getCount.Dispose();
            GC.Collect();
        }
        public string TotalBookCount()
        {
            MySqlCommand getCount = new MySqlCommand("select count(ID) from books", baglan);
            Baslat();
            string count = getCount.ExecuteScalar().ToString();
            Bitir();
            return count;
            getCount.Dispose();
            GC.Collect();
        }

        //Bağlantı Kontrolü
        public bool Kontrol()
        {
            try
            {
                baglan.Open();
                if (baglan.State != ConnectionState.Closed)
                    return true;
                else
                    return false;
            }
            catch (Exception err)
            {
                return false;
            }
        }
    }
}
*/