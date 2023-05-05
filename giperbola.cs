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
        // Глобальные переменные
        Pen myPen = new Pen(Color.Red, 3f);
        Graphics polotno;
        FormColor colorWin;
        bool razresh = false;
        Random rnd = new Random();

        public giperbola()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) // Избавление от окна
        {
            Dispose();
        }

        private void picGPBL_Paint(object sender, PaintEventArgs e) // Код для построения
        {
            // Проверка разрешения
            if (!razresh)
            {
                return;
            }
            // Основные переменные
            polotno = e.Graphics;
            float num = (float)nudA.Value;
            float num2 = (float)nudB.Value;
            polotno.TranslateTransform(picGPBL.Width / 2, picGPBL.Height / 2);
            int num3 = picGPBL.Width / 10;
            int num4 = picGPBL.Height / 10;
            Pen pen = new Pen(Color.Black, 1f);

            // Отрисовка линий графика
            polotno.DrawLine(pen, -10 * num3, 0, 10 * num3, 0);
            polotno.DrawLine(pen, 0, -10 * num4, 0, 10 * num4);

            // Рисовка линии (f - принудительно к float)
            for (int i = -10; i <= 10; i++)
            {
                polotno.DrawLine(pen, -10, picGPBL.Width / 20 * i, 10, picGPBL.Width / 20 * i);
            }
            for (int j = -10; j <= 10; j++)
            {
                polotno.DrawLine(pen, picGPBL.Height / 20 * j, -10, picGPBL.Height / 20 * j, 10);
            }
            for (float num5 = -10f; num5 <= 0f - num2 - 0.05; num5 += 0.05f)
            {
                float num6 = 0f - num / (num5 + num2);
                float num7 = 0f - (float)(num / num5 + 0.05 + num2);
                float x = picGPBL.Width / 20 * num5;
                float x2 = (float)(picGPBL.Width / 20 * (num5 + 0.05));
                num6 = picGPBL.Height / 20 * num6;
                num7 = picGPBL.Height / 20 * num7;
                polotno.DrawLine(myPen, x, num6, x2, num7);
            }
            for (float num8 = 0f - num2 + 0.05f; num8 <= 10f; num8 += 0.05f)
            {
                float num9 = 0f - num / (num8 + num2);
                float num10 = 0f - (float)(num / (num8 + 0.05 + num2));
                float x3 = picGPBL.Width / 20 * num8;
                float x4 = (float)(picGPBL.Width / 20 * (num8 + 0.05));
                num9 = picGPBL.Height / 20 * num9;
                num10 = picGPBL.Height / 20 * num10;
                polotno.DrawLine(myPen, x3, num9, x4, num10);
            }
        }

        private void button1_Click(object sender, EventArgs e) // Открытие окна выбора цвета и применение выбранных цветов
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

        private void btnBuild_Click(object sender, EventArgs e) // Построить график
        {
            razresh = true;
            picGPBL.Invalidate();
        }

        private void picGPBL_Click(object sender, EventArgs e)
        {

        }

        private void giperbola_Load(object sender, EventArgs e)
        {

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int r1 = rnd.Next(-10, 10);
            int r2 = rnd.Next(-10, 10);

            nudA.Value = r1;
            nudB.Value = r2;

            razresh = true;
            picGPBL.Invalidate();
        }
    }
}
