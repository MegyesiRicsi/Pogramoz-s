namespace _20210923_3
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
            this.lbl_ker = new System.Windows.Forms.Label();
            this.lbl_ter = new System.Windows.Forms.Label();
            this.txt_adat = new System.Windows.Forms.TextBox();
            this.txt_ker = new System.Windows.Forms.TextBox();
            this.txt_ter = new System.Windows.Forms.TextBox();
            this.btn_gomb = new System.Windows.Forms.Button();
            this.btn_kor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sugár";
            // 
            // lbl_ker
            // 
            this.lbl_ker.AutoSize = true;
            this.lbl_ker.Location = new System.Drawing.Point(286, 61);
            this.lbl_ker.Name = "lbl_ker";
            this.lbl_ker.Size = new System.Drawing.Size(55, 13);
            this.lbl_ker.TabIndex = 2;
            this.lbl_ker.Text = "Kör terület";
            // 
            // lbl_ter
            // 
            this.lbl_ter.AutoSize = true;
            this.lbl_ter.Location = new System.Drawing.Point(84, 61);
            this.lbl_ter.Name = "lbl_ter";
            this.lbl_ter.Size = new System.Drawing.Size(58, 13);
            this.lbl_ter.TabIndex = 3;
            this.lbl_ter.Text = "Kör kerület";
            // 
            // txt_adat
            // 
            this.txt_adat.Location = new System.Drawing.Point(61, 12);
            this.txt_adat.Name = "txt_adat";
            this.txt_adat.Size = new System.Drawing.Size(61, 20);
            this.txt_adat.TabIndex = 4;
            // 
            // txt_ker
            // 
            this.txt_ker.Location = new System.Drawing.Point(61, 90);
            this.txt_ker.Name = "txt_ker";
            this.txt_ker.Size = new System.Drawing.Size(100, 20);
            this.txt_ker.TabIndex = 5;
            // 
            // txt_ter
            // 
            this.txt_ter.Location = new System.Drawing.Point(246, 90);
            this.txt_ter.Name = "txt_ter";
            this.txt_ter.Size = new System.Drawing.Size(100, 20);
            this.txt_ter.TabIndex = 6;
            // 
            // btn_gomb
            // 
            this.btn_gomb.Location = new System.Drawing.Point(271, 155);
            this.btn_gomb.Name = "btn_gomb";
            this.btn_gomb.Size = new System.Drawing.Size(75, 23);
            this.btn_gomb.TabIndex = 7;
            this.btn_gomb.Text = "Gömb";
            this.btn_gomb.UseVisualStyleBackColor = true;
            this.btn_gomb.Click += new System.EventHandler(this.Btn_gomb_Click);
            // 
            // btn_kor
            // 
            this.btn_kor.Location = new System.Drawing.Point(61, 155);
            this.btn_kor.Name = "btn_kor";
            this.btn_kor.Size = new System.Drawing.Size(75, 23);
            this.btn_kor.TabIndex = 8;
            this.btn_kor.Text = "Kör";
            this.btn_kor.UseVisualStyleBackColor = true;
            this.btn_kor.Click += new System.EventHandler(this.Btn_kor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 263);
            this.Controls.Add(this.btn_kor);
            this.Controls.Add(this.btn_gomb);
            this.Controls.Add(this.txt_ter);
            this.Controls.Add(this.txt_ker);
            this.Controls.Add(this.txt_adat);
            this.Controls.Add(this.lbl_ter);
            this.Controls.Add(this.lbl_ker);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ker;
        private System.Windows.Forms.Label lbl_ter;
        private System.Windows.Forms.TextBox txt_adat;
        private System.Windows.Forms.TextBox txt_ker;
        private System.Windows.Forms.TextBox txt_ter;
        private System.Windows.Forms.Button btn_gomb;
        private System.Windows.Forms.Button btn_kor;
    }
}

