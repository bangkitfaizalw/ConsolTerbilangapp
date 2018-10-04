namespace Terbilang1
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
            this.Nominal = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.TextBox();
            this.Hasil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nominal
            // 
            this.Nominal.AutoSize = true;
            this.Nominal.Location = new System.Drawing.Point(28, 41);
            this.Nominal.Name = "Nominal";
            this.Nominal.Size = new System.Drawing.Size(45, 13);
            this.Nominal.TabIndex = 0;
            this.Nominal.Text = "Nominal";
            this.Nominal.Click += new System.EventHandler(this.label1_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(92, 41);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(100, 20);
            this.Input.TabIndex = 1;
            // 
            // Hasil
            // 
            this.Hasil.Location = new System.Drawing.Point(92, 109);
            this.Hasil.Multiline = true;
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(366, 187);
            this.Hasil.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Terbilang";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Hasil);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Nominal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nominal;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Hasil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

