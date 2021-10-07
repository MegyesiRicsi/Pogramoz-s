namespace _20211007_2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_kilep = new System.Windows.Forms.Button();
            this.btn_iras = new System.Windows.Forms.Button();
            this.btn_fel = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_kilep
            // 
            this.btn_kilep.Location = new System.Drawing.Point(24, 190);
            this.btn_kilep.Name = "btn_kilep";
            this.btn_kilep.Size = new System.Drawing.Size(75, 23);
            this.btn_kilep.TabIndex = 2;
            this.btn_kilep.Text = "kilép";
            this.btn_kilep.UseVisualStyleBackColor = true;
            // 
            // btn_iras
            // 
            this.btn_iras.Location = new System.Drawing.Point(24, 136);
            this.btn_iras.Name = "btn_iras";
            this.btn_iras.Size = new System.Drawing.Size(75, 23);
            this.btn_iras.TabIndex = 3;
            this.btn_iras.Text = "Fájlba irás";
            this.btn_iras.UseVisualStyleBackColor = true;
            // 
            // btn_fel
            // 
            this.btn_fel.Location = new System.Drawing.Point(24, 81);
            this.btn_fel.Name = "btn_fel";
            this.btn_fel.Size = new System.Drawing.Size(75, 23);
            this.btn_fel.TabIndex = 4;
            this.btn_fel.Text = "Feltölt";
            this.btn_fel.UseVisualStyleBackColor = true;
            this.btn_fel.Click += new System.EventHandler(this.Btn_fel_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(397, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 303);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_fel);
            this.Controls.Add(this.btn_iras);
            this.Controls.Add(this.btn_kilep);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_kilep;
        private System.Windows.Forms.Button btn_iras;
        private System.Windows.Forms.Button btn_fel;
        private System.Windows.Forms.ListBox listBox1;
    }
}

