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
            this.Dispose(); // Удаление окна
        }

        private void picBackColor_Click(object sender, EventArgs e)
        {
            cd.ShowDialog(); // Выбор цвета фона и его применение
            picBackColor.BackColor = cd.Color;
        }

        private void picLineColor_Click(object sender, EventArgs e)
        {
            cd.ShowDialog(); // Выбор цвета линии и его применение
            cd.ShowDialog(); // Выбор цвета линии и его применение
            picLineColor.BackColor = cd.Color;
        }
    }
}
