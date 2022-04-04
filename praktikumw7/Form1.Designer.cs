namespace praktikumw7
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
            this.labelInput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHasil = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxHuruf1 = new System.Windows.Forms.TextBox();
            this.textBoxHuruf2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(95, 90);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(185, 25);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Masukkan kalimat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan Huruf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Menjadi";
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Location = new System.Drawing.Point(95, 336);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(66, 25);
            this.labelHasil.TabIndex = 0;
            this.labelHasil.Text = "Hasil:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(297, 87);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(411, 31);
            this.textBoxInput.TabIndex = 1;
            // 
            // textBoxHuruf1
            // 
            this.textBoxHuruf1.Location = new System.Drawing.Point(280, 191);
            this.textBoxHuruf1.Name = "textBoxHuruf1";
            this.textBoxHuruf1.Size = new System.Drawing.Size(176, 31);
            this.textBoxHuruf1.TabIndex = 2;
            // 
            // textBoxHuruf2
            // 
            this.textBoxHuruf2.Location = new System.Drawing.Point(556, 191);
            this.textBoxHuruf2.Name = "textBoxHuruf2";
            this.textBoxHuruf2.Size = new System.Drawing.Size(176, 31);
            this.textBoxHuruf2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(394, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Konversi!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(230, 336);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(0, 25);
            this.labelOutput.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 633);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxHuruf2);
            this.Controls.Add(this.textBoxHuruf1);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxHuruf1;
        private System.Windows.Forms.TextBox textBoxHuruf2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelOutput;
    }
}

