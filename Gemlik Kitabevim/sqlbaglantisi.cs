using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Gemlik_Kitabevim
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=Melik-Laptop;Initial Catalog=DboGemlikKitabevim;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
