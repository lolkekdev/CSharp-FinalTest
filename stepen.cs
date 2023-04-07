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
		// f около числа это число с float

        bool razresh = false;
		Graphics polotno;
		Pen myPen = new Pen(Color.Red, 3);

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
			if (!razresh)
			{
				return;
			}
			polotno = e.Graphics;
			polotno.TranslateTransform(picPole.Width / 2, picPole.Height / 2);
			int num = picPole.Width / 10;
			int num2 = picPole.Height / 10;
			Pen pen = new Pen(Color.Black, 1f);
			polotno.DrawLine(pen, -10 * num, 0, 10 * num, 0);
			polotno.DrawLine(pen, 0, -10 * num2, 0, 10 * num2);
			for (int i = -10; i <= 10; i++)
			{
				polotno.DrawLine(pen, -10, picPole.Width / 20 * i, 10, picPole.Width / 20 * i);
			}
			for (int j = -10; j <= 10; j++)
			{
				polotno.DrawLine(pen, picPole.Height / 20 * j, -10, picPole.Height / 20 * j, 10);
			}
			if (radio3.Checked)
			{
				for (float num3 = -10f; num3 <= 10f; num3 += 0.05f)
				{
					float num4 = 0f - num3 * num3 * num3;
					float num5 = 0f - (float)(((double)num3 + 0.05) * ((double)num3 + 0.05) * ((double)num3 + 0.05));
					float x = (float)(picPole.Width / 20) * num3;
					float x2 = (float)((double)(picPole.Width / 20) * ((double)num3 + 0.05));
					num4 = (float)(picPole.Height / 20) * num4;
					num5 = (float)(picPole.Height / 20) * num5;
					polotno.DrawLine(myPen, x, num4, x2, num5);
				}
			}
			else if (radio2.Checked)
			{
				for (float num6 = -10f; num6 <= 10f; num6 += 0.05f)
				{
					float num7 = 0f - num6 * num6;
					float num8 = 0f - (float)(((double)num6 + 0.05) * ((double)num6 + 0.05));
					float x3 = (float)(picPole.Width / 20) * num6;
					float x4 = (float)((double)(picPole.Width / 20) * ((double)num6 + 0.05));
					num7 = (float)(picPole.Height / 20) * num7;
					num8 = (float)(picPole.Height / 20) * num8;
					polotno.DrawLine(myPen, x3, num7, x4, num8);
				}
			}
			else if (radio1.Checked)
			{
				for (float num9 = -10f; num9 <= 10f; num9 += 0.05f)
				{
					float num10 = 0f - num9;
					float num11 = 0f - (float)((double)num9 + 0.05);
					float x5 = (float)(picPole.Width / 20) * num9;
					float x6 = (float)((double)(picPole.Width / 20) * ((double)num9 + 0.05));
					num10 = (float)(picPole.Height / 20) * num10;
					num11 = (float)(picPole.Height / 20) * num11;
					polotno.DrawLine(myPen, x5, num10, x6, num11);
				}
			}
			else if (radio4.Checked)
			{
				for (float num12 = -10f; num12 <= 10f; num12 += 0.05f)
				{
					float num13 = 0f - num12 * num12 * num12 * num12;
					float num14 = 0f - (float)(((double)num12 + 0.05) * ((double)num12 + 0.05) * ((double)num12 + 0.05) * ((double)num12 + 0.05));
					float x7 = (float)(picPole.Width / 20) * num12;
					float x8 = (float)((double)(picPole.Width / 20) * ((double)num12 + 0.05));
					num13 = (float)(picPole.Height / 20) * num13;
					num14 = (float)(picPole.Height / 20) * num14;
					polotno.DrawLine(myPen, x7, num13, x8, num14);
				}
			}
		}

        private void W(object sender, EventArgs e)
        {

        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
			razresh = true;
			picPole.Invalidate();
        }
    }
}
