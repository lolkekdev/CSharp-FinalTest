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
    public partial class sincos : Form
    {
        // Основные переменные
        Graphics polotno;
        bool razresh = false;
        Pen myPen = new Pen(Color.Red, 3);
        FormColor colorWin;

        public sincos()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) // Избавление от окна
        {
            Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void picSin_Paint(object sender, PaintEventArgs e)
        {
            // Проверка разрешения
            if (!razresh)
            {
                return;
            }

            // Основные переменные
            float num = (float)nudA.Value;
            float num2 = (float)nudB.Value;
            float num3 = (float)nudC.Value;
            polotno = e.Graphics;
            polotno.TranslateTransform(picSin.Width / 2, picSin.Height / 2);
            int num4 = picSin.Width / 10;
            int num5 = picSin.Height / 10;
            Pen pen = new Pen(Color.Black, 1f);
            Pen penline = new Pen(Color.Red, 1f);

            // Линии графика
            polotno.DrawLine(pen, -5 * num4, 0, 5 * num4, 0);
            polotno.DrawLine(pen, 0, -5 * num5, 0, 5 * num5);

            // Отрисовка графика
            for (int i = -10; i <= 10; i++)
            {
                polotno.DrawLine(pen, -5, picSin.Width / 20 * i, 5, picSin.Width / 20 * i);
            }
            for (int j = -10; j <= 10; j++)
            {
                polotno.DrawLine(pen, picSin.Height / 10 * j, -5, picSin.Height / 10 * j, 5);
            }
            if (rdbsin.Checked)
            {
                for (float num6 = -10f; num6 < 10f; num6 += 0.1f)
                {
                    float num7 = 0f - (float)(num * Math.Sin(num3 * num6 + num2));
                    float num8 = 0f - (float)(num * Math.Sin(num3 * (num6 + 0.1) + num2));
                    float x = picSin.Width / 20 * num6;
                    float x2 = (float)(picSin.Width / 20 * (num6 + 0.1));
                    num7 = picSin.Width / 40 * num7;
                    num8 = picSin.Width / 40 * num8;
                    polotno.DrawLine(penline, x, num7, x2, num8);
                }
            }
            if (rdbcos.Checked)
            {
                for (float num9 = -10f; num9 < 10f; num9 += 0.1f)
                {
                    float num10 = 0f - (float)(num * Math.Cos(num3 * num9 + num2));
                    float num11 = 0f - (float)(num * Math.Cos(num3 * (num9 + 0.1) + num2));
                    float x3 = picSin.Width / 20 * num9;
                    float x4 = (float)(picSin.Width / 20 * (num9 + 0.1));
                    num10 = picSin.Width / 40 * num10;
                    num11 = picSin.Width / 40 * num11;
                    polotno.DrawLine(penline, x3, num10, x4, num11);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) // Открытие диалога выбора окон и применение цвета
        {
            if (razresh)
            {
                colorWin = new FormColor();
                colorWin.picBackColor.BackColor = picSin.BackColor;
                colorWin.picLineColor.BackColor = myPen.Color;
                colorWin.ShowDialog();
                DialogResult otv = colorWin.ShowDialog();
                if (otv == DialogResult.OK)
                {
                    picSin.BackColor = colorWin.picBackColor.BackColor;
                    myPen.Color = colorWin.picLineColor.BackColor;
                }
                else
                {
                    picSin.BackColor = Color.Gray;
                    myPen.Color = Color.Red;
                }
                colorWin.Dispose();
                picSin.Invalidate();
            }
            else
            {
                MessageBox.Show("Сначала постройте график", "Ошибка");
            }
        }

        private void btnBuild_Click(object sender, EventArgs e) // Отрисовка графика и линий
        {
            razresh = true;
            picSin.Invalidate();
        }
    }
}
