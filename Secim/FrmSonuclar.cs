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
    public partial class FrmSonuclar : Form
    {
        public FrmSonuclar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSecim frs = new FrmSecim();
            frs.Show();
            this.Hide();
        }
    }
}
