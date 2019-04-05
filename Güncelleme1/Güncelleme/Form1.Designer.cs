namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.kaynakBox = new System.Windows.Forms.TextBox();
            this.hedefBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kaynakBox
            // 
            this.kaynakBox.Location = new System.Drawing.Point(31, 34);
            this.kaynakBox.Name = "kaynakBox";
            this.kaynakBox.Size = new System.Drawing.Size(179, 20);
            this.kaynakBox.TabIndex = 1;
            this.kaynakBox.Text = "c:\\deneme.txt";
            // 
            // hedefBox
            // 
            this.hedefBox.Location = new System.Drawing.Point(28, 79);
            this.hedefBox.Name = "hedefBox";
            this.hedefBox.Size = new System.Drawing.Size(181, 20);
            this.hedefBox.TabIndex = 2;
            this.hedefBox.Text = "c:\\2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.hedefBox);
            this.Controls.Add(this.kaynakBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox kaynakBox;
        private System.Windows.Forms.TextBox hedefBox;
    }
}

