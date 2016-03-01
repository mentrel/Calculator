namespace Perwij
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
            this.summ = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.delet = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // summ
            // 
            this.summ.Location = new System.Drawing.Point(162, 91);
            this.summ.Name = "summ";
            this.summ.Size = new System.Drawing.Size(44, 29);
            this.summ.TabIndex = 10;
            this.summ.Text = "+";
            this.summ.UseVisualStyleBackColor = true;
            this.summ.Click += new System.EventHandler(this.Calcued);
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(12, 91);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(44, 29);
            this.X.TabIndex = 13;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = true;
            this.X.Click += new System.EventHandler(this.Calcued);
            // 
            // delet
            // 
            this.delet.Location = new System.Drawing.Point(62, 91);
            this.delet.Name = "delet";
            this.delet.Size = new System.Drawing.Size(44, 29);
            this.delet.TabIndex = 14;
            this.delet.Text = "/";
            this.delet.UseVisualStyleBackColor = true;
            this.delet.Click += new System.EventHandler(this.Calcued);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(112, 91);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(44, 29);
            this.minus.TabIndex = 15;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Calcued);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 20);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(193, 20);
            this.textBox3.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.delet);
            this.Controls.Add(this.X);
            this.Controls.Add(this.summ);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button summ;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Button delet;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;

    }
}

