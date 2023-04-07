
namespace Graphics_Nesterovich_k0610
{
    partial class FormColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormColor));
            this.cd = new System.Windows.Forms.ColorDialog();
            this.lblFon = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.picBackColor = new System.Windows.Forms.PictureBox();
            this.picLineColor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLineColor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFon
            // 
            this.lblFon.AutoSize = true;
            this.lblFon.Location = new System.Drawing.Point(12, 45);
            this.lblFon.Name = "lblFon";
            this.lblFon.Size = new System.Drawing.Size(115, 13);
            this.lblFon.TabIndex = 0;
            this.lblFon.Text = "Выберите цвет фона:";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(12, 85);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(119, 13);
            this.lblLine.TabIndex = 1;
            this.lblLine.Text = "Выберите цвет линии:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(111, 146);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Задать";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picBackColor
            // 
            this.picBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBackColor.Location = new System.Drawing.Point(133, 35);
            this.picBackColor.Name = "picBackColor";
            this.picBackColor.Size = new System.Drawing.Size(37, 32);
            this.picBackColor.TabIndex = 3;
            this.picBackColor.TabStop = false;
            this.picBackColor.Click += new System.EventHandler(this.picBackColor_Click);
            // 
            // picLineColor
            // 
            this.picLineColor.BackColor = System.Drawing.Color.Red;
            this.picLineColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picLineColor.Location = new System.Drawing.Point(134, 74);
            this.picLineColor.Name = "picLineColor";
            this.picLineColor.Size = new System.Drawing.Size(37, 32);
            this.picLineColor.TabIndex = 4;
            this.picLineColor.TabStop = false;
            this.picLineColor.Click += new System.EventHandler(this.picLineColor_Click);
            // 
            // FormColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 181);
            this.Controls.Add(this.picLineColor);
            this.Controls.Add(this.picBackColor);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblFon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormColor";
            this.Text = "Выбор цвета";
            ((System.ComponentModel.ISupportInitialize)(this.picBackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLineColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog cd;
        private System.Windows.Forms.Label lblFon;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.PictureBox picBackColor;
        public System.Windows.Forms.PictureBox picLineColor;
    }
}