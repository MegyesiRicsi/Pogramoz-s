namespace _20210930
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_szam = new System.Windows.Forms.TextBox();
            this.txt_gyök = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_szamit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szám";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Négyzetgyök";
            // 
            // txt_szam
            // 
            this.txt_szam.Location = new System.Drawing.Point(166, 29);
            this.txt_szam.Name = "txt_szam";
            this.txt_szam.Size = new System.Drawing.Size(100, 20);
            this.txt_szam.TabIndex = 2;
            // 
            // txt_gyök
            // 
            this.txt_gyök.Enabled = false;
            this.txt_gyök.Location = new System.Drawing.Point(166, 79);
            this.txt_gyök.Name = "txt_gyök";
            this.txt_gyök.Size = new System.Drawing.Size(100, 20);
            this.txt_gyök.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kilép";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_szamit
            // 
            this.btn_szamit.Location = new System.Drawing.Point(12, 133);
            this.btn_szamit.Name = "btn_szamit";
            this.btn_szamit.Size = new System.Drawing.Size(75, 23);
            this.btn_szamit.TabIndex = 5;
            this.btn_szamit.Text = "Számitás";
            this.btn_szamit.UseVisualStyleBackColor = true;
            this.btn_szamit.Click += new System.EventHandler(this.Btn_szamit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 191);
            this.Controls.Add(this.btn_szamit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_gyök);
            this.Controls.Add(this.txt_szam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_szam;
        private System.Windows.Forms.TextBox txt_gyök;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_szamit;
    }
}

