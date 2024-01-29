using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secim
{
    public partial class FrmSecim : Form
    {
        public FrmSecim()
        {
            InitializeComponent();
        }

        private void lnklblYazilim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Aakcayy");
        }

        private void btnSonuclar_Click(object sender, EventArgs e)
        {
            FrmSonuclar frs=new FrmSonuclar();
            frs.Show();
            this.Hide();
        }
    }
}
