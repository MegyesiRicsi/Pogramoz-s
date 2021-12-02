namespace TesztversenyGUI
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
            this.btn_kereses = new System.Windows.Forms.Button();
            this.btn_kilep = new System.Windows.Forms.Button();
            this.btn_fileba = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_beolvas = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_nev = new System.Windows.Forms.TextBox();
            this.txt_valasz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_kereses
            // 
            this.btn_kereses.Location = new System.Drawing.Point(12, 325);
            this.btn_kereses.Name = "btn_kereses";
            this.btn_kereses.Size = new System.Drawing.Size(107, 44);
            this.btn_kereses.TabIndex = 0;
            this.btn_kereses.Text = "Keresés";
            this.btn_kereses.UseVisualStyleBackColor = true;
            this.btn_kereses.Click += new System.EventHandler(this.Btn_kereses_Click);
            // 
            // btn_kilep
            // 
            this.btn_kilep.Location = new System.Drawing.Point(143, 394);
            this.btn_kilep.Name = "btn_kilep";
            this.btn_kilep.Size = new System.Drawing.Size(107, 44);
            this.btn_kilep.TabIndex = 1;
            this.btn_kilep.Text = "Kilépés";
            this.btn_kilep.UseVisualStyleBackColor = true;
            this.btn_kilep.Click += new System.EventHandler(this.Btn_kilep_Click);
            // 
            // btn_fileba
            // 
            this.btn_fileba.Location = new System.Drawing.Point(143, 325);
            this.btn_fileba.Name = "btn_fileba";
            this.btn_fileba.Size = new System.Drawing.Size(107, 44);
            this.btn_fileba.TabIndex = 2;
            this.btn_fileba.Text = "File-ba irás";
            this.btn_fileba.UseVisualStyleBackColor = true;
            this.btn_fileba.Click += new System.EventHandler(this.Btn_fileba_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(143, 255);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(107, 44);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "Törlés";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.Btn_del_Click);
            // 
            // btn_beolvas
            // 
            this.btn_beolvas.Location = new System.Drawing.Point(12, 255);
            this.btn_beolvas.Name = "btn_beolvas";
            this.btn_beolvas.Size = new System.Drawing.Size(107, 44);
            this.btn_beolvas.TabIndex = 4;
            this.btn_beolvas.Text = "File-ból olvasás";
            this.btn_beolvas.UseVisualStyleBackColor = true;
            this.btn_beolvas.Click += new System.EventHandler(this.Btn_beolvas_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 394);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(107, 44);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Hozzáadás";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // txt_nev
            // 
            this.txt_nev.Location = new System.Drawing.Point(150, 33);
            this.txt_nev.Name = "txt_nev";
            this.txt_nev.Size = new System.Drawing.Size(100, 20);
            this.txt_nev.TabIndex = 6;
            // 
            // txt_valasz
            // 
            this.txt_valasz.Location = new System.Drawing.Point(150, 125);
            this.txt_valasz.Name = "txt_valasz";
            this.txt_valasz.Size = new System.Drawing.Size(100, 20);
            this.txt_valasz.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Válasz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kód";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(368, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(408, 394);
            this.listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_valasz);
            this.Controls.Add(this.txt_nev);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_beolvas);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_fileba);
            this.Controls.Add(this.btn_kilep);
            this.Controls.Add(this.btn_kereses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kereses;
        private System.Windows.Forms.Button btn_kilep;
        private System.Windows.Forms.Button btn_fileba;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_beolvas;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_valasz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_nev;
    }
}

