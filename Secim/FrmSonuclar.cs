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

namespace Secim
{
    public partial class FrmSonuclar : Form
    {
        public FrmSonuclar()
        {
            InitializeComponent();
        }
        public string il2;
        SqlConnection baglan = new SqlConnection(@"Data Source=KARTALPC\SQLEXPRESS03;Initial Catalog=Secim;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            FrmSecim frs = new FrmSecim();
            
            frs.Show();
            this.Hide();
        }

        private void FrmSonuclar_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand il = new SqlCommand("Select SUM(AParti),SUM(BParti),SUM(CParti),SUM(DParti),SUM(EParti) From TBLSECIM where IL=@p1 ",baglan);
            il.Parameters.AddWithValue("@p1",il2);
            SqlDataReader dr = il.ExecuteReader();
            while (dr.Read())
            {
                chart1.Series["İL Parti Oyları"].Points.AddXY("AParti", dr[0]);
                chart1.Series["İL Parti Oyları"].Points.AddXY("BParti", dr[1]);
                chart1.Series["İL Parti Oyları"].Points.AddXY("CParti", dr[2]);
                chart1.Series["İL Parti Oyları"].Points.AddXY("DParti", dr[3]);
                chart1.Series["İL Parti Oyları"].Points.AddXY("EParti", dr[4]);
            }
            dr.Close();

            
            SqlCommand ilce = new SqlCommand("Select ILCE From TBLSECIM Where IL=@p1", baglan);
            ilce.Parameters.AddWithValue("@p1", il2);
            SqlDataReader dr2 = ilce.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["İlçe Parti Oyları"].Points.AddXY("AParti", dr[0]);
                chart2.Series["İlçe Parti Oyları"].Points.AddXY("BParti", dr[1]);
            
            }
            dr2.Close();
            baglan.Close();
        }
    }
}
