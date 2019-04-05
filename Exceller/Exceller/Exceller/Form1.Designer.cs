namespace Exceller
{
    partial class Form1
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
            this.t_dosyaadi = new System.Windows.Forms.TextBox();
            this.t_veri = new System.Windows.Forms.TextBox();
            this.b_kaydet = new System.Windows.Forms.Button();
            this.t_column = new System.Windows.Forms.NumericUpDown();
            this.t_row = new System.Windows.Forms.NumericUpDown();
            this.b_yaz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.t_column)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_row)).BeginInit();
            this.SuspendLayout();
            // 
            // t_dosyaadi
            // 
            this.t_dosyaadi.Location = new System.Drawing.Point(94, 12);
            this.t_dosyaadi.Name = "t_dosyaadi";
            this.t_dosyaadi.Size = new System.Drawing.Size(177, 20);
            this.t_dosyaadi.TabIndex = 0;
            // 
            // t_veri
            // 
            this.t_veri.Location = new System.Drawing.Point(94, 50);
            this.t_veri.Name = "t_veri";
            this.t_veri.Size = new System.Drawing.Size(177, 20);
            this.t_veri.TabIndex = 1;
            // 
            // b_kaydet
            // 
            this.b_kaydet.Location = new System.Drawing.Point(196, 147);
            this.b_kaydet.Name = "b_kaydet";
            this.b_kaydet.Size = new System.Drawing.Size(75, 23);
            this.b_kaydet.TabIndex = 2;
            this.b_kaydet.Text = "Kaydet";
            this.b_kaydet.UseVisualStyleBackColor = true;
            this.b_kaydet.Click += new System.EventHandler(this.b_kaydet_Click);
            // 
            // t_column
            // 
            this.t_column.Location = new System.Drawing.Point(151, 103);
            this.t_column.Name = "t_column";
            this.t_column.ReadOnly = true;
            this.t_column.Size = new System.Drawing.Size(120, 20);
            this.t_column.TabIndex = 3;
            this.t_column.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // t_row
            // 
            this.t_row.Location = new System.Drawing.Point(151, 77);
            this.t_row.Name = "t_row";
            this.t_row.ReadOnly = true;
            this.t_row.Size = new System.Drawing.Size(120, 20);
            this.t_row.TabIndex = 4;
            this.t_row.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // b_yaz
            // 
            this.b_yaz.Location = new System.Drawing.Point(115, 147);
            this.b_yaz.Name = "b_yaz";
            this.b_yaz.Size = new System.Drawing.Size(75, 23);
            this.b_yaz.TabIndex = 5;
            this.b_yaz.Text = "Yaz";
            this.b_yaz.UseVisualStyleBackColor = true;
            this.b_yaz.Click += new System.EventHandler(this.b_yaz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dosya Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Veri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Satır";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sütun";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 182);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_yaz);
            this.Controls.Add(this.t_row);
            this.Controls.Add(this.t_column);
            this.Controls.Add(this.b_kaydet);
            this.Controls.Add(this.t_veri);
            this.Controls.Add(this.t_dosyaadi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t_column)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_row)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_dosyaadi;
        private System.Windows.Forms.TextBox t_veri;
        private System.Windows.Forms.Button b_kaydet;
        private System.Windows.Forms.NumericUpDown t_column;
        private System.Windows.Forms.NumericUpDown t_row;
        private System.Windows.Forms.Button b_yaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

