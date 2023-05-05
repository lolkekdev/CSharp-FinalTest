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
		// Основные переменные

        bool razresh = false;
		Graphics polotno;
		Pen myPen = new Pen(Color.Red, 3);
		FormColor colorWin;

		public stepen()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) // Удаление окна
        {
            Dispose();
        }

        private void picStep_Paint(object sender, PaintEventArgs e)
        {
			// Проверка разрешения
			if (!razresh)
			{
				return;
			}
			
			// Основные переменные
			polotno = e.Graphics;
			polotno.TranslateTransform(picPole.Width / 2, picPole.Height / 2);
			int num = picPole.Width / 10;
			int num2 = picPole.Height / 10;
			Pen pen = new Pen(Color.Black, 1f);
			
			// Отрисовка линий
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
			
			if (radio3.Checked) // x3
			{
				for (float num3 = -10f; num3 <= 10f; num3 += 0.05f)
				{
					float num4 = 0f - num3 * num3 * num3;
					float num5 = 0f - (float)((num3 + 0.05) * (num3 + 0.05) * (num3 + 0.05));
					float x = picPole.Width / 20 * num3;
					float x2 = (float)(picPole.Width / 20 * (num3 + 0.05));
					num4 = picPole.Height / 20 * num4;
					num5 = picPole.Height / 20 * num5;
					polotno.DrawLine(myPen, x, num4, x2, num5);
				}
			}
			else if (radio2.Checked) // x2
			{
				for (float num6 = -10f; num6 <= 10f; num6 += 0.05f)
				{
					float num7 = 0f - num6 * num6;
					float num8 = 0f - (float)((num6 + 0.05) * (num6 + 0.05));
					float x3 = picPole.Width / 20 * num6;
					float x4 = (float)(picPole.Width / 20 * (num6 + 0.05));
					num7 = picPole.Height / 20 * num7;
					num8 = picPole.Height / 20 * num8;
					polotno.DrawLine(myPen, x3, num7, x4, num8);
				}
			}
			else if (radio1.Checked) // x1
			{
				for (float num9 = -10f; num9 <= 10f; num9 += 0.05f)
				{
					float num10 = 0f - num9;
					float num11 = 0f - (float)(num9 + 0.05);
					float x5 = picPole.Width / 20 * num9;
					float x6 = (float)(picPole.Width / 20 * (num9 + 0.05));
					num10 = picPole.Height / 20 * num10;
					num11 = picPole.Height / 20 * num11;
					polotno.DrawLine(myPen, x5, num10, x6, num11);
				}
			}
			else if (radio4.Checked) //x4
			{
				for (float num12 = -10f; num12 <= 10f; num12 += 0.05f)
				{
					float num13 = 0f - num12 * num12 * num12 * num12;
					float num14 = 0f - (float)((num12 + 0.05) * (num12 + 0.05) * (num12 + 0.05) * (num12 + 0.05));
					float x7 = picPole.Width / 20 * num12;
					float x8 = (float)(picPole.Width / 20 * (num12 + 0.05));
					num13 = picPole.Height / 20 * num13;
					num14 = picPole.Height / 20 * num14;
					polotno.DrawLine(myPen, x7, num13, x8, num14);
				}
			}
		}

        private void W(object sender, EventArgs e)
        {

        }

        private void btnBuild_Click(object sender, EventArgs e) // Отрисовка графика
        {
			razresh = true;
			picPole.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e) // Задание цветов
        {
			if (razresh)
			{
				colorWin = new FormColor();
				colorWin.picBackColor.BackColor = picPole.BackColor;
				colorWin.picLineColor.BackColor = myPen.Color;
				colorWin.ShowDialog();
				picPole.BackColor = colorWin.picBackColor.BackColor;
				myPen.Color = colorWin.picLineColor.BackColor;
				colorWin.Dispose();
				picPole.Invalidate();
			}
			else
			{
				MessageBox.Show("Сначала постройте график", "Ошибка");
			}
		}
    }
}
