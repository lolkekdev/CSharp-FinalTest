using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Nesterovich_k0610
{
    public partial class FormColor : Form
    {
        public FormColor()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void picBackColor_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            picBackColor.BackColor = cd.Color;
        }

        private void picLineColor_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            picLineColor.BackColor = cd.Color;
        }
    }
}
