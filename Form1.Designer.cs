
namespace Graphics_Nesterovich_k0610
{
    partial class ChoosingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoosingForm));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.radioPRBL = new System.Windows.Forms.RadioButton();
            this.radioSinCos = new System.Windows.Forms.RadioButton();
            this.radioGPBL = new System.Windows.Forms.RadioButton();
            this.radioStep = new System.Windows.Forms.RadioButton();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioStep);
            this.groupBox.Controls.Add(this.radioGPBL);
            this.groupBox.Controls.Add(this.radioSinCos);
            this.groupBox.Controls.Add(this.radioPRBL);
            this.groupBox.Location = new System.Drawing.Point(13, 13);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(215, 131);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Выберите функцию";
            // 
            // btnStart
            // 
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStart.Location = new System.Drawing.Point(12, 161);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(216, 33);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "СТАРТ";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // radioPRBL
            // 
            this.radioPRBL.AutoSize = true;
            this.radioPRBL.Location = new System.Drawing.Point(7, 20);
            this.radioPRBL.Name = "radioPRBL";
            this.radioPRBL.Size = new System.Drawing.Size(75, 17);
            this.radioPRBL.TabIndex = 0;
            this.radioPRBL.Text = "Парабола";
            this.radioPRBL.UseVisualStyleBackColor = true;
            // 
            // radioSinCos
            // 
            this.radioSinCos.AutoSize = true;
            this.radioSinCos.Location = new System.Drawing.Point(7, 43);
            this.radioSinCos.Name = "radioSinCos";
            this.radioSinCos.Size = new System.Drawing.Size(150, 17);
            this.radioSinCos.TabIndex = 1;
            this.radioSinCos.Text = "Синусоида/Косинусоида";
            this.radioSinCos.UseVisualStyleBackColor = true;
            // 
            // radioGPBL
            // 
            this.radioGPBL.AutoSize = true;
            this.radioGPBL.Location = new System.Drawing.Point(7, 66);
            this.radioGPBL.Name = "radioGPBL";
            this.radioGPBL.Size = new System.Drawing.Size(79, 17);
            this.radioGPBL.TabIndex = 2;
            this.radioGPBL.Text = "Гипербола";
            this.radioGPBL.UseVisualStyleBackColor = true;
            // 
            // radioStep
            // 
            this.radioStep.AutoSize = true;
            this.radioStep.Location = new System.Drawing.Point(7, 89);
            this.radioStep.Name = "radioStep";
            this.radioStep.Size = new System.Drawing.Size(79, 17);
            this.radioStep.TabIndex = 3;
            this.radioStep.Text = "Степенная";
            this.radioStep.UseVisualStyleBackColor = true;
            // 
            // ChoosingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 216);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoosingForm";
            this.Text = "Графики Функций";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioStep;
        private System.Windows.Forms.RadioButton radioGPBL;
        private System.Windows.Forms.RadioButton radioSinCos;
        private System.Windows.Forms.RadioButton radioPRBL;
        private System.Windows.Forms.Button btnStart;
    }
}

