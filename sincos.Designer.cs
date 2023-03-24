
namespace Graphics_Nesterovich_k0610
{
    partial class sincos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sincos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbFuncChoose = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioSin = new System.Windows.Forms.RadioButton();
            this.btnBuild = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nudA = new System.Windows.Forms.NumericUpDown();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.nudC = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbFuncChoose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 269);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Graphics_Nesterovich_k0610.Properties.Resources.sin;
            this.pictureBox1.Location = new System.Drawing.Point(148, 390);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 119);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 426);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblA.Location = new System.Drawing.Point(14, 342);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(27, 24);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "a:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblB.Location = new System.Drawing.Point(14, 366);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(28, 24);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "b:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "c:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gbFuncChoose
            // 
            this.gbFuncChoose.Controls.Add(this.radioButton1);
            this.gbFuncChoose.Controls.Add(this.radioSin);
            this.gbFuncChoose.Location = new System.Drawing.Point(148, 283);
            this.gbFuncChoose.Name = "gbFuncChoose";
            this.gbFuncChoose.Size = new System.Drawing.Size(166, 77);
            this.gbFuncChoose.TabIndex = 6;
            this.gbFuncChoose.TabStop = false;
            this.gbFuncChoose.Text = "Выберите функцию";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Косинусоида";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioSin
            // 
            this.radioSin.AutoSize = true;
            this.radioSin.Location = new System.Drawing.Point(7, 20);
            this.radioSin.Name = "radioSin";
            this.radioSin.Size = new System.Drawing.Size(79, 17);
            this.radioSin.TabIndex = 0;
            this.radioSin.TabStop = true;
            this.radioSin.Text = "Синусоида";
            this.radioSin.UseVisualStyleBackColor = true;
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(364, 283);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(94, 23);
            this.btnBuild.TabIndex = 7;
            this.btnBuild.Text = "Построить";
            this.btnBuild.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Задать цвета";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // nudA
            // 
            this.nudA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudA.Location = new System.Drawing.Point(45, 348);
            this.nudA.Name = "nudA";
            this.nudA.Size = new System.Drawing.Size(93, 20);
            this.nudA.TabIndex = 9;
            // 
            // nudB
            // 
            this.nudB.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudB.Location = new System.Drawing.Point(46, 372);
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(92, 20);
            this.nudB.TabIndex = 10;
            // 
            // nudC
            // 
            this.nudC.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudC.Location = new System.Drawing.Point(46, 396);
            this.nudC.Name = "nudC";
            this.nudC.Size = new System.Drawing.Size(93, 20);
            this.nudC.TabIndex = 11;
            // 
            // sincos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.nudC);
            this.Controls.Add(this.nudB);
            this.Controls.Add(this.nudA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.gbFuncChoose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sincos";
            this.Text = "Синусоида и Косинусоида";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbFuncChoose.ResumeLayout(false);
            this.gbFuncChoose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbFuncChoose;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioSin;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nudA;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.NumericUpDown nudC;
    }
}