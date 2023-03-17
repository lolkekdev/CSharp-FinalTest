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
    public partial class ChoosingForm : Form
    {

		parabola prbl;
		sincos sincos;
		giperbola gpbl;
		stepen step;

        public ChoosingForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
			if (radioPRBL.Checked)
			{
				prbl = new parabola();
				prbl.ShowDialog();
				prbl.Dispose();
			}
			else if (radioSinCos.Checked)
			{
				sincos = new sincos();
				sincos.ShowDialog();
				sincos.Dispose();
			}
			else if (radioGPBL.Checked)
			{
				gpbl = new giperbola();
				gpbl.ShowDialog();
				gpbl.Dispose();
			}
			else if (radioStep.Checked)
			{
				step = new stepen();
				step.ShowDialog();
				step.Dispose();
			}
			else
			{
				MessageBox.Show("Выбор функции", "Произошла ошибка!");
			}
		}
    }
}
