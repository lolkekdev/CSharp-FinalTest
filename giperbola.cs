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
    public partial class giperbola : Form
    {

        Pen myPen = new Pen(Color.Red, 3);
        Brush myBrush = Brushes.Aquamarine;
        Font myFont = new Font("Arial", 18, FontStyle.Italic);

        Graphics polotno;
        FormColor colorWin;
        bool razresh = false;

        public giperbola()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void picGPBL_Paint(object sender, PaintEventArgs e)
        {

            polotno = e.Graphics;
            polotno.TranslateTransform(picGPBL.Width / 2, picGPBL.Height / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (razresh)
            {
                colorWin = new FormColor();
                colorWin.picBackColor.BackColor = picGPBL.BackColor;
                colorWin.picLineColor.BackColor = myPen.Color;
                colorWin.ShowDialog();
                picGPBL.BackColor = colorWin.picBackColor.BackColor;
                myPen.Color = colorWin.picLineColor.BackColor;
                colorWin.Dispose();
                picGPBL.Invalidate();
            }
            else
            {
                MessageBox.Show("Сначала постройте график", "Ошибка");
            }
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {

        }
    }
}
