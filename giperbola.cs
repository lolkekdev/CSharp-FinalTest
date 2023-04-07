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
            float num = (float)nudA.Value;
            float num2 = (float)nudB.Value;
            polotno.TranslateTransform(picGPBL.Width / 2, picGPBL.Height / 2);
            int num3 = picGPBL.Width / 10;
            int num4 = picGPBL.Height / 10;
            Pen pen = new Pen(Color.Black, 1f);
            polotno.DrawLine(pen, -10 * num3, 0, 10 * num3, 0);
            polotno.DrawLine(pen, 0, -10 * num4, 0, 10 * num4);
            for (int i = -10; i <= 10; i++)
            {
                polotno.DrawLine(pen, -7, picGPBL.Width / 20 * i, 7, picGPBL.Width / 20 * i);
            }
            for (int j = -10; j <= 10; j++)
            {
                polotno.DrawLine(pen, picGPBL.Height / 20 * j, -7, picGPBL.Height / 20 * j, 7);
            }
            for (float num5 = -10f; (double)num5 <= (double)(0f - num2) - 0.05; num5 += 0.05f)
            {
                float num6 = 0f - num / (num5 + num2);
                float num7 = 0f - (float)((double)num / ((double)num5 + 0.05 + (double)num2));
                float x = (float)(picGPBL.Width / 20) * num5;
                float x2 = (float)((double)(picGPBL.Width / 20) * ((double)num5 + 0.05));
                num6 = (float)(picGPBL.Height / 20) * num6;
                num7 = (float)(picGPBL.Height / 20) * num7;
                polotno.DrawLine(myPen, x, num6, x2, num7);
            }
            for (float num8 = 0f - num2 + 0.05f; num8 <= 10f; num8 += 0.05f)
            {
                float num9 = 0f - num / (num8 + num2);
                float num10 = 0f - (float)((double)num / ((double)num8 + 0.05 + (double)num2));
                float x3 = (float)(picGPBL.Width / 20) * num8;
                float x4 = (float)((double)(picGPBL.Width / 20) * ((double)num8 + 0.05));
                num9 = (float)(picGPBL.Height / 20) * num9;
                num10 = (float)(picGPBL.Height / 20) * num10;
                polotno.DrawLine(myPen, x3, num9, x4, num10);
            }
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
            razresh = true;
            picGPBL.Invalidate();
        }

        private void picGPBL_Click(object sender, EventArgs e)
        {

        }
    }
}
