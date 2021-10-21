namespace _20211021_13
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
            this.txt_szoveg = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_tor = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_ir = new System.Windows.Forms.Button();
            this.btn_kilep = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kérem a szöveget";
            // 
            // txt_szoveg
            // 
            this.txt_szoveg.Location = new System.Drawing.Point(12, 100);
            this.txt_szoveg.Name = "txt_szoveg";
            this.txt_szoveg.Size = new System.Drawing.Size(396, 20);
            this.txt_szoveg.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(471, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(317, 433);
            this.listBox1.TabIndex = 2;
            // 
            // btn_tor
            // 
            this.btn_tor.Location = new System.Drawing.Point(12, 166);
            this.btn_tor.Name = "btn_tor";
            this.btn_tor.Size = new System.Drawing.Size(396, 23);
            this.btn_tor.TabIndex = 3;
            this.btn_tor.Text = "Tördelés";
            this.btn_tor.UseVisualStyleBackColor = true;
            this.btn_tor.Click += new System.EventHandler(this.Btn_tor_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(12, 224);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(396, 23);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Törlés";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // btn_ir
            // 
            this.btn_ir.Location = new System.Drawing.Point(12, 195);
            this.btn_ir.Name = "btn_ir";
            this.btn_ir.Size = new System.Drawing.Size(396, 23);
            this.btn_ir.TabIndex = 6;
            this.btn_ir.Text = "Fájlba Irás ";
            this.btn_ir.UseVisualStyleBackColor = true;
            this.btn_ir.Click += new System.EventHandler(this.Btn_ir_Click);
            // 
            // btn_kilep
            // 
            this.btn_kilep.Location = new System.Drawing.Point(12, 415);
            this.btn_kilep.Name = "btn_kilep";
            this.btn_kilep.Size = new System.Drawing.Size(396, 23);
            this.btn_kilep.TabIndex = 7;
            this.btn_kilep.Text = "Kilépés";
            this.btn_kilep.UseVisualStyleBackColor = true;
            this.btn_kilep.Click += new System.EventHandler(this.btn_kilep_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_kilep);
            this.Controls.Add(this.btn_ir);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_tor);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_szoveg);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_szoveg;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_tor;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_ir;
        private System.Windows.Forms.Button btn_kilep;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

