using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTS_Data
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btband_Click(object sender, EventArgs e)
        {
            FormBand f1 = new FormBand();
            f1.ShowDialog();

        }

        private void btmember_Click(object sender, EventArgs e)
        {
            FormMember f2 = new FormMember();
            f2.ShowDialog();
        }
    }
}
