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
    public partial class parabola : Form
    {

        Graphics polotno;
        bool razresh = false;
        FormColor colorWin;

        Pen myPen = new Pen(Color.Red, 3);
        Pen lienPen = new Pen(Color.Black, 1);

        Random rnd = new Random();

        public parabola()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void picPRBL_Paint(object sender, PaintEventArgs e)
        {
            if (razresh)
            {
                float num = (float)nudA.Value;
                float num2 = (float)nudB.Value;
                float num3 = (float)nudC.Value;
                polotno = e.Graphics;
                polotno.TranslateTransform(picPRBL.Width / 2, picPRBL.Height / 2);
                float num4 = picPRBL.Width / 10;
                float num5 = picPRBL.Height / 10;
                polotno.DrawLine(lienPen, -10f * num4, 0f, 10f * num4, 0f);
                polotno.DrawLine(lienPen, 0f, -10f * num5, 0f, 10f * num5);
                for (int i = -10; i <= 10; i++)
                {
                    polotno.DrawLine(lienPen, -7, picPRBL.Width / 20 * i, 7, picPRBL.Width / 20 * i);
                }
                for (int j = -10; j <= 10; j++)
                {
                    polotno.DrawLine(lienPen, picPRBL.Height / 20 * j, -7, picPRBL.Height / 20 * j, 7);
                }
                for (float num6 = -10f; num6 < 10f; num6 += 0.5f)
                {
                    float num7 = 0f - (num * num6 * num6 + num2 * num6 + num3);
                    float num8 = 0f - (float)(num * (num6 + 0.5) * (num6 + 0.5) + num2 * (num6 + 0.5) + num3);
                    float x = picPRBL.Width / 20 * num6;
                    float x2 = (float)(picPRBL.Width / 20 * (num6 + 0.5));
                    num7 = picPRBL.Width / 20 * num7;
                    num8 = picPRBL.Width / 20 * num8;
                    polotno.DrawLine(myPen, x, num7, x2, num8);
                }
            }
            }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            razresh = true;
            picPRBL.Invalidate();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (razresh)
            {
                colorWin = new FormColor();
                colorWin.picBackColor.BackColor = picPRBL.BackColor;
                colorWin.picLineColor.BackColor = myPen.Color;
               DialogResult otv =colorWin.ShowDialog();
                if (otv == DialogResult.OK) {
                picPRBL.BackColor = colorWin.picBackColor.BackColor;
                myPen.Color = colorWin.picLineColor.BackColor;
                }
                else
                {
                    picPRBL.BackColor = Color.Gray;
                    myPen.Color = Color.Red;
                }
                colorWin.Dispose();
                picPRBL.Invalidate();
            }
            else
            {
                MessageBox.Show("Сначала постройте график", "Ошибка");
            }
        }

        private void nudA_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int r1 = rnd.Next(-10, 10);
            int r2 = rnd.Next(-10, 10);
            int r3 = rnd.Next(-10, 10);

            nudA.Value = r1;
            nudB.Value = r2;
            nudC.Value = r3;

            razresh = true;
            picPRBL.Invalidate();
        }
    }
}
