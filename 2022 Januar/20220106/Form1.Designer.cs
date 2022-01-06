namespace _20220106
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
            this.btn_liski = new System.Windows.Forms.Button();
            this.btn_lsbe = new System.Windows.Forms.Button();
            this.btn_keres = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_olaj = new System.Windows.Forms.TextBox();
            this.txt_benzin = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.btn_Fel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btn_liski
            // 
            this.btn_liski.Location = new System.Drawing.Point(67, 246);
            this.btn_liski.Name = "btn_liski";
            this.btn_liski.Size = new System.Drawing.Size(191, 23);
            this.btn_liski.TabIndex = 0;
            this.btn_liski.Text = "Listboy kiirás és Törlés";
            this.btn_liski.UseVisualStyleBackColor = true;
            this.btn_liski.Click += new System.EventHandler(this.Btn_liski_Click);
            // 
            // btn_lsbe
            // 
            this.btn_lsbe.Location = new System.Drawing.Point(128, 217);
            this.btn_lsbe.Name = "btn_lsbe";
            this.btn_lsbe.Size = new System.Drawing.Size(75, 23);
            this.btn_lsbe.TabIndex = 1;
            this.btn_lsbe.Text = "ListBoxba";
            this.btn_lsbe.UseVisualStyleBackColor = true;
            this.btn_lsbe.Click += new System.EventHandler(this.Btn_lsbe_Click);
            // 
            // btn_keres
            // 
            this.btn_keres.Location = new System.Drawing.Point(12, 217);
            this.btn_keres.Name = "btn_keres";
            this.btn_keres.Size = new System.Drawing.Size(75, 23);
            this.btn_keres.TabIndex = 2;
            this.btn_keres.Text = "keresés";
            this.btn_keres.UseVisualStyleBackColor = true;
            this.btn_keres.Click += new System.EventHandler(this.Btn_keres_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(320, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(468, 290);
            this.listBox1.TabIndex = 3;
            // 
            // txt_olaj
            // 
            this.txt_olaj.Location = new System.Drawing.Point(158, 148);
            this.txt_olaj.Name = "txt_olaj";
            this.txt_olaj.Size = new System.Drawing.Size(100, 20);
            this.txt_olaj.TabIndex = 4;
            // 
            // txt_benzin
            // 
            this.txt_benzin.Location = new System.Drawing.Point(159, 81);
            this.txt_benzin.Name = "txt_benzin";
            this.txt_benzin.Size = new System.Drawing.Size(100, 20);
            this.txt_benzin.TabIndex = 5;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(158, 12);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(100, 20);
            this.txt_date.TabIndex = 6;
            // 
            // btn_Fel
            // 
            this.btn_Fel.Location = new System.Drawing.Point(239, 217);
            this.btn_Fel.Name = "btn_Fel";
            this.btn_Fel.Size = new System.Drawing.Size(75, 23);
            this.btn_Fel.TabIndex = 9;
            this.btn_Fel.Text = "Feltöltés";
            this.btn_Fel.UseVisualStyleBackColor = true;
            this.btn_Fel.Click += new System.EventHandler(this.Btn_Fel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dátum";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Gázolaj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Benzin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Fel);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_benzin);
            this.Controls.Add(this.txt_olaj);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_keres);
            this.Controls.Add(this.btn_lsbe);
            this.Controls.Add(this.btn_liski);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_liski;
        private System.Windows.Forms.Button btn_lsbe;
        private System.Windows.Forms.Button btn_keres;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_olaj;
        private System.Windows.Forms.TextBox txt_benzin;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Button btn_Fel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

