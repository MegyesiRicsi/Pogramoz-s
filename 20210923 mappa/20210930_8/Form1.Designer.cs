namespace _20210930_8
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
            this.lbl_szam = new System.Windows.Forms.Label();
            this.btn_szamit = new System.Windows.Forms.Button();
            this.btn_kilep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_szam
            // 
            this.lbl_szam.AutoSize = true;
            this.lbl_szam.Location = new System.Drawing.Point(22, 13);
            this.lbl_szam.Name = "lbl_szam";
            this.lbl_szam.Size = new System.Drawing.Size(13, 13);
            this.lbl_szam.TabIndex = 0;
            this.lbl_szam.Text = "0";
            // 
            // btn_szamit
            // 
            this.btn_szamit.Location = new System.Drawing.Point(82, 98);
            this.btn_szamit.Name = "btn_szamit";
            this.btn_szamit.Size = new System.Drawing.Size(75, 23);
            this.btn_szamit.TabIndex = 1;
            this.btn_szamit.Text = "Számitás";
            this.btn_szamit.UseVisualStyleBackColor = true;
            this.btn_szamit.Click += new System.EventHandler(this.Btn_szamit_Click);
            // 
            // btn_kilep
            // 
            this.btn_kilep.Location = new System.Drawing.Point(213, 98);
            this.btn_kilep.Name = "btn_kilep";
            this.btn_kilep.Size = new System.Drawing.Size(75, 23);
            this.btn_kilep.TabIndex = 2;
            this.btn_kilep.Text = "kilépés";
            this.btn_kilep.UseVisualStyleBackColor = true;
            this.btn_kilep.Click += new System.EventHandler(this.Btn_kilep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 174);
            this.Controls.Add(this.btn_kilep);
            this.Controls.Add(this.btn_szamit);
            this.Controls.Add(this.lbl_szam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_szam;
        private System.Windows.Forms.Button btn_szamit;
        private System.Windows.Forms.Button btn_kilep;
    }
}

