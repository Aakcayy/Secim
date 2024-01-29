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
        public string ilce2;
        sqlbaglantisi baglan = new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            FrmSecim frs = new FrmSecim();
            
            frs.Show();
            this.Hide();
        }

        private void FrmSonuclar_Load(object sender, EventArgs e)
        {
          
            SqlCommand il = new SqlCommand("Select SUM(AParti),SUM(BParti),SUM(CParti),SUM(DParti),SUM(EParti) From TBLSECIM where IL=@p1 ",baglan.baglanti());
            il.Parameters.AddWithValue("@p1",il2);
            SqlDataReader dr = il.ExecuteReader();
           if (dr.Read())
            {
                chartIL.Series["İL Parti Oyları"].Points.AddXY("AParti", dr[0]);
                chartIL.Series["İL Parti Oyları"].Points.AddXY("BParti", dr[1]);
                chartIL.Series["İL Parti Oyları"].Points.AddXY("CParti", dr[2]);
                chartIL.Series["İL Parti Oyları"].Points.AddXY("DParti", dr[3]);
                chartIL.Series["İL Parti Oyları"].Points.AddXY("EParti", dr[4]);

                double s1 = int.Parse(dr[0].ToString());
                double s2 = int.Parse(dr[1].ToString());
                double s3 = int.Parse(dr[2].ToString());
                double s4 = int.Parse(dr[3].ToString());
                double s5 = int.Parse(dr[4].ToString());

                prbAil.Maximum = Convert.ToInt16(s1 + s2 + s3 + s4 + s5);
                prbBil.Maximum = Convert.ToInt16(s1 + s2 + s3 + s4 + s5);
                prbCil.Maximum = Convert.ToInt16(s1 + s2 + s3 + s4 + s5);
                prbDil.Maximum = Convert.ToInt16(s1 + s2 + s3 + s4 + s5);
                prbEil.Maximum = Convert.ToInt16(s1 + s2 + s3 + s4 + s5);

                prbAil.Value = int.Parse(dr[0].ToString());
                prbBil.Value = int.Parse(dr[1].ToString());
                prbCil.Value = int.Parse(dr[2].ToString());
                prbDil.Value = int.Parse(dr[3].ToString());
                prbEil.Value = int.Parse(dr[4].ToString());

                lblAOran.Text = ((s1 * 100) / (s1 + s2 + s3 + s4 + s5)).ToString();
                lblBOran.Text = ((s2 * 100) / (s1 + s2 + s3 + s4 + s5)).ToString();
                lblCOran.Text = ((s3 * 100) / (s1 + s2 + s3 + s4 + s5)).ToString();
                lblDOran.Text = ((s4 * 100) / (s1 + s2 + s3 + s4 + s5)).ToString();
                lblEOran.Text = ((s5 * 100) / (s1 + s2 + s3 + s4 + s5)).ToString();


            }
             SqlCommand ilce = new SqlCommand("Select SUM(AParti),SUM(BParti),SUM(CParti),SUM(DParti),SUM(EParti) From TBLSECIM Where ILCE=@p1", baglan.baglanti());
             ilce.Parameters.AddWithValue("@p1", ilce2);
             SqlDataReader dr2 = ilce.ExecuteReader();
             while (dr2.Read())
             {
                chartILCE.Series["İlçe Parti Oyları"].Points.AddXY("AParti", dr2[0]);
                chartILCE.Series["İlçe Parti Oyları"].Points.AddXY("BParti", dr2[1]);
                chartILCE.Series["İlçe Parti Oyları"].Points.AddXY("CParti", dr2[2]);
                chartILCE.Series["İlçe Parti Oyları"].Points.AddXY("DParti", dr2[3]);
                chartILCE.Series["İlçe Parti Oyları"].Points.AddXY("EParti", dr2[4]);

                double s1= int.Parse(dr2[0].ToString());
                double s2 = int.Parse(dr2[1].ToString());
                double s3 = int.Parse(dr2[2].ToString());
                double s4 = int.Parse(dr2[3].ToString());
                double s5 = int.Parse(dr2[4].ToString());

                prbAilce.Maximum= Convert.ToInt16(s1+s2+s3+s4+s5);
                prbBilce.Maximum = Convert.ToInt16(s1 + s2 + s3 + s4 + s5);
                prbCilce.Maximum = Convert.ToInt16(s1 + s2 + s3 + s4 + s5);
                prbDilce.Maximum = Convert.ToInt16(s1 + s2 + s3 + s4 + s5);
                prbEilce.Maximum = Convert.ToInt16(s1 + s2 + s3 + s4 + s5);

                prbAilce.Value = int.Parse(dr2[0].ToString());
                prbBilce.Value = int.Parse(dr2[1].ToString());
                prbCilce.Value = int.Parse(dr2[2].ToString());
                prbDilce.Value = int.Parse(dr2[3].ToString());
                prbEilce.Value = int.Parse(dr2[4].ToString());

                lblilceA.Text = ((s1*100)/ (s1 + s2 + s3 + s4 + s5)).ToString();
                lblilceB.Text = ((s2 * 100) / (s1 + s2 + s3 + s4 + s5)).ToString();
                lblilceC.Text = ((s3 * 100) / (s1 + s2 + s3 + s4 + s5)).ToString();
                lblilceD.Text = ((s4 * 100) / (s1 + s2 + s3 + s4 + s5)).ToString();
                lblilceE.Text = ((s5 * 100) / (s1 + s2 + s3 + s4 + s5)).ToString();

            }
             
           
        }
    }
}
