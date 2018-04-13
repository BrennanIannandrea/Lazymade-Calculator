namespace Test
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
            this.Calculator_I_guess = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Calculator_I_guess
            // 
            this.Calculator_I_guess.AutoSize = true;
            this.Calculator_I_guess.Location = new System.Drawing.Point(12, 9);
            this.Calculator_I_guess.Name = "Calculator_I_guess";
            this.Calculator_I_guess.Size = new System.Drawing.Size(91, 13);
            this.Calculator_I_guess.TabIndex = 0;
            this.Calculator_I_guess.Text = "Calculator I guess";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Click += new System.EventHandler(this.calculate);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.DoubleClick += new System.EventHandler(this.calculate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 66);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Calculator_I_guess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Calculator_I_guess;
        private System.Windows.Forms.TextBox textBox1;
    }
}

