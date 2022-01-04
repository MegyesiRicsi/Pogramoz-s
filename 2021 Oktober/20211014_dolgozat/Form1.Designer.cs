namespace _20211014_dolgozat
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
            this.txt_m = new System.Windows.Forms.TextBox();
            this.txt_r = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_terf = new System.Windows.Forms.TextBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_szamol = new System.Windows.Forms.Button();
            this.btn_kilep = new System.Windows.Forms.Button();
            this.txt_felsz = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_m
            // 
            this.txt_m.Location = new System.Drawing.Point(50, 143);
            this.txt_m.Name = "txt_m";
            this.txt_m.Size = new System.Drawing.Size(100, 20);
            this.txt_m.TabIndex = 0;
            // 
            // txt_r
            // 
            this.txt_r.Location = new System.Drawing.Point(50, 67);
            this.txt_r.Name = "txt_r";
            this.txt_r.Size = new System.Drawing.Size(100, 20);
            this.txt_r.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "henger magassága";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Henger sugara";
            // 
            // txt_terf
            // 
            this.txt_terf.Enabled = false;
            this.txt_terf.Location = new System.Drawing.Point(253, 143);
            this.txt_terf.Name = "txt_terf";
            this.txt_terf.Size = new System.Drawing.Size(160, 20);
            this.txt_terf.TabIndex = 4;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(281, 194);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 5;
            this.btn_del.Text = "Törlés";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.Btn_del_Click);
            // 
            // btn_szamol
            // 
            this.btn_szamol.Location = new System.Drawing.Point(176, 194);
            this.btn_szamol.Name = "btn_szamol";
            this.btn_szamol.Size = new System.Drawing.Size(75, 23);
            this.btn_szamol.TabIndex = 6;
            this.btn_szamol.Text = "Számol";
            this.btn_szamol.UseVisualStyleBackColor = true;
            this.btn_szamol.Click += new System.EventHandler(this.Btn_szamol_Click);
            // 
            // btn_kilep
            // 
            this.btn_kilep.Location = new System.Drawing.Point(49, 194);
            this.btn_kilep.Name = "btn_kilep";
            this.btn_kilep.Size = new System.Drawing.Size(75, 23);
            this.btn_kilep.TabIndex = 7;
            this.btn_kilep.Text = "Kilépés";
            this.btn_kilep.UseVisualStyleBackColor = true;
            this.btn_kilep.Click += new System.EventHandler(this.Btn_kilep_Click);
            // 
            // txt_felsz
            // 
            this.txt_felsz.Enabled = false;
            this.txt_felsz.Location = new System.Drawing.Point(253, 67);
            this.txt_felsz.Name = "txt_felsz";
            this.txt_felsz.Size = new System.Drawing.Size(160, 20);
            this.txt_felsz.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "A henger Térfogata";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "A henger Felszine";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_felsz);
            this.Controls.Add(this.btn_kilep);
            this.Controls.Add(this.btn_szamol);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.txt_terf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_r);
            this.Controls.Add(this.txt_m);
            this.Name = "Form1";
            this.Text = "Henger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_m;
        private System.Windows.Forms.TextBox txt_r;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_terf;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_szamol;
        private System.Windows.Forms.Button btn_kilep;
        private System.Windows.Forms.TextBox txt_felsz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

