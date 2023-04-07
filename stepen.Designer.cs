
namespace Graphics_Nesterovich_k0610
{
    partial class stepen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stepen));
            this.btnBack = new System.Windows.Forms.Button();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio4 = new System.Windows.Forms.RadioButton();
            this.btnBuild = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.picPole = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPole)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 426);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Location = new System.Drawing.Point(13, 13);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(121, 17);
            this.radio1.TabIndex = 18;
            this.radio1.TabStop = true;
            this.radio1.Text = "Первая степень (х)";
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.CheckedChanged += new System.EventHandler(this.W);
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(13, 36);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(87, 17);
            this.radio2.TabIndex = 19;
            this.radio2.TabStop = true;
            this.radio2.Text = "Квадрат (х2)";
            this.radio2.UseVisualStyleBackColor = true;
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(13, 59);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(63, 17);
            this.radio3.TabIndex = 20;
            this.radio3.TabStop = true;
            this.radio3.Text = "Куб (х3)";
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // radio4
            // 
            this.radio4.AutoSize = true;
            this.radio4.Location = new System.Drawing.Point(13, 82);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(146, 17);
            this.radio4.TabIndex = 21;
            this.radio4.TabStop = true;
            this.radio4.Text = " Четвертая степень (х4)";
            this.radio4.UseVisualStyleBackColor = true;
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(13, 123);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(94, 23);
            this.btnBuild.TabIndex = 22;
            this.btnBuild.Text = "Построить";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 31);
            this.button1.TabIndex = 23;
            this.button1.Text = "Задать цвета";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pic
            // 
            this.picPole.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPole.Location = new System.Drawing.Point(203, 13);
            this.picPole.Name = "pic";
            this.picPole.Size = new System.Drawing.Size(355, 384);
            this.picPole.TabIndex = 24;
            this.picPole.TabStop = false;
            this.picPole.Paint += new System.Windows.Forms.PaintEventHandler(this.picStep_Paint);
            // 
            // stepen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 461);
            this.Controls.Add(this.picPole);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.radio4);
            this.Controls.Add(this.radio3);
            this.Controls.Add(this.radio2);
            this.Controls.Add(this.radio1);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "stepen";
            this.Text = "Степень";
            ((System.ComponentModel.ISupportInitialize)(this.picPole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio4;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picPole;
    }
}