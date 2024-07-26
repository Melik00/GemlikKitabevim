using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gemlik_Kitabevim
{
    public partial class FrmIletisim : Form
    {
        public FrmIletisim()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Mail adresini belirleyin.
            string mailToAddress = "gemlikkitabevim@gmail.com";

            // Gmail'in mail yazma sayfasına yönlendiren URL
            string gmailUrl = $"https://mail.google.com/mail/?view=cm&fs=1&to={mailToAddress}";

            // Tarayıcıda URL'yi açın
            System.Diagnostics.Process.Start(gmailUrl);
        }

    }
}
