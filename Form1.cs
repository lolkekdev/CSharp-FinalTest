﻿using System;
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
        public ChoosingForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
			if (radioPRBL.Checked)
			{

			}
			else if (radioSinCos.Checked)
			{

			}
			else if (radioGPBL.Checked)
			{

			}
			else if (radioStep.Checked)
			{

			}
			else
			{
				MessageBox.Show("Выбор функции", "Произошла ошибка!");
			}
		}
    }
}
