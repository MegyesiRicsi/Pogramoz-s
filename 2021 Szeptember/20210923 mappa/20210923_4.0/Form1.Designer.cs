namespace _20210923_4._0
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
            this.btn_rendez = new System.Windows.Forms.Button();
            this.btn_bezar = new System.Windows.Forms.Button();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.txt_3 = new System.Windows.Forms.TextBox();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Első szám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Harmadik szám:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Második szám:";
            // 
            // btn_rendez
            // 
            this.btn_rendez.Location = new System.Drawing.Point(20, 203);
            this.btn_rendez.Name = "btn_rendez";
            this.btn_rendez.Size = new System.Drawing.Size(75, 23);
            this.btn_rendez.TabIndex = 3;
            this.btn_rendez.Text = "Rendez";
            this.btn_rendez.UseVisualStyleBackColor = true;
            this.btn_rendez.Click += new System.EventHandler(this.Btn_rendez_Click);
            // 
            // btn_bezar
            // 
            this.btn_bezar.Location = new System.Drawing.Point(151, 203);
            this.btn_bezar.Name = "btn_bezar";
            this.btn_bezar.Size = new System.Drawing.Size(75, 23);
            this.btn_bezar.TabIndex = 4;
            this.btn_bezar.Text = "Bezár";
            this.btn_bezar.UseVisualStyleBackColor = true;
            this.btn_bezar.Click += new System.EventHandler(this.Btn_bezar_Click);
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(113, 10);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(100, 20);
            this.txt_1.TabIndex = 5;
            this.txt_1.Text = "Edit1";
            // 
            // txt_3
            // 
            this.txt_3.Location = new System.Drawing.Point(113, 114);
            this.txt_3.Name = "txt_3";
            this.txt_3.Size = new System.Drawing.Size(100, 20);
            this.txt_3.TabIndex = 6;
            this.txt_3.Text = "Edit3";
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(113, 56);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(100, 20);
            this.txt_2.TabIndex = 7;
            this.txt_2.Text = "Edit2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 267);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_3);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.btn_bezar);
            this.Controls.Add(this.btn_rendez);
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
        private System.Windows.Forms.Button btn_rendez;
        private System.Windows.Forms.Button btn_bezar;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.TextBox txt_3;
        private System.Windows.Forms.TextBox txt_2;
    }
}

