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
    public partial class stepen : Form
    {

        Graphics polotno;
        bool razresh = false;

        public stepen()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void picStep_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Red, 3);
            Brush myBrush = Brushes.Aquamarine;
            Font myFont = new Font("Arial", 18, FontStyle.Italic);
            polotno = e.Graphics;
            polotno.TranslateTransform(picStep.Width / 2, picStep.Height / 2);
        }
    }
}
