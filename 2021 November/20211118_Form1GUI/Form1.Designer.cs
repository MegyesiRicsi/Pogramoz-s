namespace _20211118_Form1GUI
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
            this.txt_helyezes = new System.Windows.Forms.TextBox();
            this.txt_pont = new System.Windows.Forms.TextBox();
            this.txt_hely = new System.Windows.Forms.TextBox();
            this.txt_datum = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_fel = new System.Windows.Forms.Button();
            this.btn_fileba = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_kereses = new System.Windows.Forms.Button();
            this.btn_listaba = new System.Windows.Forms.Button();
            this.btn_filedel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dátum";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Helyszín";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Helyezés";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pontszám";
            // 
            // txt_helyezes
            // 
            this.txt_helyezes.Location = new System.Drawing.Point(141, 112);
            this.txt_helyezes.Name = "txt_helyezes";
            this.txt_helyezes.Size = new System.Drawing.Size(100, 20);
            this.txt_helyezes.TabIndex = 5;
            // 
            // txt_pont
            // 
            this.txt_pont.Location = new System.Drawing.Point(141, 148);
            this.txt_pont.Name = "txt_pont";
            this.txt_pont.Size = new System.Drawing.Size(100, 20);
            this.txt_pont.TabIndex = 7;
            // 
            // txt_hely
            // 
            this.txt_hely.Location = new System.Drawing.Point(141, 81);
            this.txt_hely.Name = "txt_hely";
            this.txt_hely.Size = new System.Drawing.Size(100, 20);
            this.txt_hely.TabIndex = 8;
            // 
            // txt_datum
            // 
            this.txt_datum.Location = new System.Drawing.Point(141, 36);
            this.txt_datum.Name = "txt_datum";
            this.txt_datum.Size = new System.Drawing.Size(100, 20);
            this.txt_datum.TabIndex = 9;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(166, 258);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "Kilépés";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // btn_fel
            // 
            this.btn_fel.Location = new System.Drawing.Point(270, 204);
            this.btn_fel.Name = "btn_fel";
            this.btn_fel.Size = new System.Drawing.Size(75, 23);
            this.btn_fel.TabIndex = 11;
            this.btn_fel.Text = "Feltöltés";
            this.btn_fel.UseVisualStyleBackColor = true;
            this.btn_fel.Click += new System.EventHandler(this.Btn_fel_Click);
            // 
            // btn_fileba
            // 
            this.btn_fileba.Location = new System.Drawing.Point(166, 204);
            this.btn_fileba.Name = "btn_fileba";
            this.btn_fileba.Size = new System.Drawing.Size(75, 23);
            this.btn_fileba.TabIndex = 12;
            this.btn_fileba.Text = "Fileba írás";
            this.btn_fileba.UseVisualStyleBackColor = true;
            this.btn_fileba.Click += new System.EventHandler(this.Btn_fileba_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(56, 204);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 13;
            this.btn_del.Text = "Törlés";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.Btn_del_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(395, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(365, 394);
            this.listBox1.TabIndex = 14;
            // 
            // btn_kereses
            // 
            this.btn_kereses.Location = new System.Drawing.Point(56, 258);
            this.btn_kereses.Name = "btn_kereses";
            this.btn_kereses.Size = new System.Drawing.Size(75, 23);
            this.btn_kereses.TabIndex = 15;
            this.btn_kereses.Text = "Keresés";
            this.btn_kereses.UseVisualStyleBackColor = true;
            this.btn_kereses.Click += new System.EventHandler(this.Btn_kereses_Click);
            // 
            // btn_listaba
            // 
            this.btn_listaba.Location = new System.Drawing.Point(270, 258);
            this.btn_listaba.Name = "btn_listaba";
            this.btn_listaba.Size = new System.Drawing.Size(75, 23);
            this.btn_listaba.TabIndex = 16;
            this.btn_listaba.Text = "ListBoxba Ir";
            this.btn_listaba.UseVisualStyleBackColor = true;
            this.btn_listaba.Click += new System.EventHandler(this.Btn_listaba_Click);
            // 
            // btn_filedel
            // 
            this.btn_filedel.Location = new System.Drawing.Point(166, 318);
            this.btn_filedel.Name = "btn_filedel";
            this.btn_filedel.Size = new System.Drawing.Size(75, 23);
            this.btn_filedel.TabIndex = 17;
            this.btn_filedel.Text = "File törlése";
            this.btn_filedel.UseVisualStyleBackColor = true;
            this.btn_filedel.Click += new System.EventHandler(this.Btn_filedel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_filedel);
            this.Controls.Add(this.btn_listaba);
            this.Controls.Add(this.btn_kereses);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_fileba);
            this.Controls.Add(this.btn_fel);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txt_datum);
            this.Controls.Add(this.txt_hely);
            this.Controls.Add(this.txt_pont);
            this.Controls.Add(this.txt_helyezes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_helyezes;
        private System.Windows.Forms.TextBox txt_pont;
        private System.Windows.Forms.TextBox txt_hely;
        private System.Windows.Forms.TextBox txt_datum;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_fel;
        private System.Windows.Forms.Button btn_fileba;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_kereses;
        private System.Windows.Forms.Button btn_listaba;
        private System.Windows.Forms.Button btn_filedel;
    }
}

