namespace _2021._12._09_cbradioGUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nev = new System.Windows.Forms.TextBox();
            this.txt_hsz = new System.Windows.Forms.TextBox();
            this.txt_perc = new System.Windows.Forms.TextBox();
            this.txt_ora = new System.Windows.Forms.TextBox();
            this.btn_file = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_ki = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Óra";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Perc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hivásszám";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Név";
            // 
            // txt_nev
            // 
            this.txt_nev.Location = new System.Drawing.Point(80, 193);
            this.txt_nev.Name = "txt_nev";
            this.txt_nev.Size = new System.Drawing.Size(100, 20);
            this.txt_nev.TabIndex = 4;
            // 
            // txt_hsz
            // 
            this.txt_hsz.Location = new System.Drawing.Point(80, 139);
            this.txt_hsz.Name = "txt_hsz";
            this.txt_hsz.Size = new System.Drawing.Size(100, 20);
            this.txt_hsz.TabIndex = 5;
            this.txt_hsz.Text = "0 - 10";
            this.txt_hsz.Click += new System.EventHandler(this.Txt_hsz_Click);
            // 
            // txt_perc
            // 
            this.txt_perc.Location = new System.Drawing.Point(80, 88);
            this.txt_perc.Name = "txt_perc";
            this.txt_perc.Size = new System.Drawing.Size(100, 20);
            this.txt_perc.TabIndex = 6;
            this.txt_perc.Text = "0 - 59";
            this.txt_perc.Click += new System.EventHandler(this.Txt_perc_Click);
            // 
            // txt_ora
            // 
            this.txt_ora.Location = new System.Drawing.Point(80, 34);
            this.txt_ora.Name = "txt_ora";
            this.txt_ora.Size = new System.Drawing.Size(100, 20);
            this.txt_ora.TabIndex = 7;
            this.txt_ora.Text = "6 - 13";
            this.txt_ora.Click += new System.EventHandler(this.Txt_ora_Click);
            // 
            // btn_file
            // 
            this.btn_file.Location = new System.Drawing.Point(105, 245);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(115, 23);
            this.btn_file.TabIndex = 8;
            this.btn_file.Text = "Fájlba és Listába";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.Btn_file_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(19, 245);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 9;
            this.btn_del.Text = "Törlés";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.Btn_del_Click);
            // 
            // btn_ki
            // 
            this.btn_ki.Location = new System.Drawing.Point(19, 294);
            this.btn_ki.Name = "btn_ki";
            this.btn_ki.Size = new System.Drawing.Size(75, 23);
            this.btn_ki.TabIndex = 10;
            this.btn_ki.Text = "Kilépés";
            this.btn_ki.UseVisualStyleBackColor = true;
            this.btn_ki.Click += new System.EventHandler(this.Btn_ki_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(242, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(364, 303);
            this.listBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_ki);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_file);
            this.Controls.Add(this.txt_ora);
            this.Controls.Add(this.txt_perc);
            this.Controls.Add(this.txt_hsz);
            this.Controls.Add(this.txt_nev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CB rádió";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nev;
        private System.Windows.Forms.TextBox txt_hsz;
        private System.Windows.Forms.TextBox txt_perc;
        private System.Windows.Forms.TextBox txt_ora;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_ki;
        private System.Windows.Forms.ListBox listBox1;
    }
}

