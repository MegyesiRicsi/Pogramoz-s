namespace _20210923_2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_eredmeny = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_change = new System.Windows.Forms.Label();
            this.btn_kivon = new System.Windows.Forms.Button();
            this.bnt_szor = new System.Windows.Forms.Button();
            this.btn_ossz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adat1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adat2\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // txt_eredmeny
            // 
            this.txt_eredmeny.Location = new System.Drawing.Point(206, 147);
            this.txt_eredmeny.Name = "txt_eredmeny";
            this.txt_eredmeny.Size = new System.Drawing.Size(152, 20);
            this.txt_eredmeny.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Eredmény";
            // 
            // lbl_change
            // 
            this.lbl_change.AutoSize = true;
            this.lbl_change.Location = new System.Drawing.Point(227, 119);
            this.lbl_change.Name = "lbl_change";
            this.lbl_change.Size = new System.Drawing.Size(109, 13);
            this.lbl_change.TabIndex = 6;
            this.lbl_change.Text = "Müvelet: Összeadása";
            // 
            // btn_kivon
            // 
            this.btn_kivon.Location = new System.Drawing.Point(41, 145);
            this.btn_kivon.Name = "btn_kivon";
            this.btn_kivon.Size = new System.Drawing.Size(75, 23);
            this.btn_kivon.TabIndex = 7;
            this.btn_kivon.Text = "Kivonás";
            this.btn_kivon.UseVisualStyleBackColor = true;
            this.btn_kivon.Click += new System.EventHandler(this.Btn_kivon_Click);
            // 
            // bnt_szor
            // 
            this.bnt_szor.Location = new System.Drawing.Point(41, 205);
            this.bnt_szor.Name = "bnt_szor";
            this.bnt_szor.Size = new System.Drawing.Size(75, 23);
            this.bnt_szor.TabIndex = 8;
            this.bnt_szor.Text = "Szorzás";
            this.bnt_szor.UseVisualStyleBackColor = true;
            this.bnt_szor.Click += new System.EventHandler(this.Bnt_szor_Click);
            // 
            // btn_ossz
            // 
            this.btn_ossz.Location = new System.Drawing.Point(41, 90);
            this.btn_ossz.Name = "btn_ossz";
            this.btn_ossz.Size = new System.Drawing.Size(75, 23);
            this.btn_ossz.TabIndex = 9;
            this.btn_ossz.Text = "Összeadás";
            this.btn_ossz.UseVisualStyleBackColor = true;
            this.btn_ossz.Click += new System.EventHandler(this.Btn_ossz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 293);
            this.Controls.Add(this.btn_ossz);
            this.Controls.Add(this.bnt_szor);
            this.Controls.Add(this.btn_kivon);
            this.Controls.Add(this.lbl_change);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_eredmeny);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_eredmeny;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_change;
        private System.Windows.Forms.Button btn_kivon;
        private System.Windows.Forms.Button bnt_szor;
        private System.Windows.Forms.Button btn_ossz;
    }
}

