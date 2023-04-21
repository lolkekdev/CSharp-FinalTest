
namespace Graphics_Nesterovich_k0610
{
    partial class parabola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(parabola));
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.nudA = new System.Windows.Forms.NumericUpDown();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.nudC = new System.Windows.Forms.NumericUpDown();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.picPRBL = new System.Windows.Forms.PictureBox();
            this.btnRandom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPRBL)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 426);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Graphics_Nesterovich_k0610.Properties.Resources.parab;
            this.pictureBox1.Location = new System.Drawing.Point(201, 399);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblA.Location = new System.Drawing.Point(8, 12);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(27, 24);
            this.lblA.TabIndex = 6;
            this.lblA.Text = "a:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblB.Location = new System.Drawing.Point(8, 47);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(28, 24);
            this.lblB.TabIndex = 7;
            this.lblB.Text = "b:";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblC.Location = new System.Drawing.Point(8, 83);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(27, 24);
            this.lblC.TabIndex = 8;
            this.lblC.Text = "c:";
            // 
            // nudA
            // 
            this.nudA.DecimalPlaces = 2;
            this.nudA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudA.Location = new System.Drawing.Point(41, 18);
            this.nudA.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudA.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudA.Name = "nudA";
            this.nudA.Size = new System.Drawing.Size(93, 20);
            this.nudA.TabIndex = 10;
            this.nudA.ValueChanged += new System.EventHandler(this.nudA_ValueChanged);
            // 
            // nudB
            // 
            this.nudB.DecimalPlaces = 1;
            this.nudB.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudB.Location = new System.Drawing.Point(41, 51);
            this.nudB.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudB.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(92, 20);
            this.nudB.TabIndex = 11;
            // 
            // nudC
            // 
            this.nudC.DecimalPlaces = 1;
            this.nudC.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudC.Location = new System.Drawing.Point(41, 89);
            this.nudC.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudC.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudC.Name = "nudC";
            this.nudC.Size = new System.Drawing.Size(92, 20);
            this.nudC.TabIndex = 12;
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(12, 132);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(94, 23);
            this.btnBuild.TabIndex = 13;
            this.btnBuild.Text = "Построить";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(12, 161);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(94, 31);
            this.btnColor.TabIndex = 14;
            this.btnColor.Text = "Задать цвета";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // picPRBL
            // 
            this.picPRBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPRBL.Location = new System.Drawing.Point(176, 12);
            this.picPRBL.Name = "picPRBL";
            this.picPRBL.Size = new System.Drawing.Size(352, 369);
            this.picPRBL.TabIndex = 15;
            this.picPRBL.TabStop = false;
            this.picPRBL.Paint += new System.Windows.Forms.PaintEventHandler(this.picPRBL_Paint);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(12, 198);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(126, 23);
            this.btnRandom.TabIndex = 21;
            this.btnRandom.Text = "Случайный график";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // parabola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 461);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.picPRBL);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.nudC);
            this.Controls.Add(this.nudB);
            this.Controls.Add(this.nudA);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "parabola";
            this.Text = "Парабола";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPRBL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.NumericUpDown nudA;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.NumericUpDown nudC;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.PictureBox picPRBL;
        private System.Windows.Forms.Button btnRandom;
    }
}