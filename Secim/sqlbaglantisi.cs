using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secim
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=KARTALPC\SQLEXPRESS03;Initial Catalog=Secim;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
