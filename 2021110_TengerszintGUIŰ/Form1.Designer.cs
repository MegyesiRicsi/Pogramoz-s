namespace _2021110_TengerszintGUIŰ
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
            this.txtMag = new System.Windows.Forms.TextBox();
            this.txtCucs = new System.Windows.Forms.TextBox();
            this.txtOrszag = new System.Windows.Forms.TextBox();
            this.btnMent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFel = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnKilep = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMag
            // 
            this.txtMag.Location = new System.Drawing.Point(80, 157);
            this.txtMag.Name = "txtMag";
            this.txtMag.Size = new System.Drawing.Size(100, 20);
            this.txtMag.TabIndex = 0;
            // 
            // txtCucs
            // 
            this.txtCucs.Location = new System.Drawing.Point(80, 114);
            this.txtCucs.Name = "txtCucs";
            this.txtCucs.Size = new System.Drawing.Size(100, 20);
            this.txtCucs.TabIndex = 1;
            // 
            // txtOrszag
            // 
            this.txtOrszag.Location = new System.Drawing.Point(80, 67);
            this.txtOrszag.Name = "txtOrszag";
            this.txtOrszag.Size = new System.Drawing.Size(100, 20);
            this.txtOrszag.TabIndex = 2;
            // 
            // btnMent
            // 
            this.btnMent.Location = new System.Drawing.Point(105, 336);
            this.btnMent.Name = "btnMent";
            this.btnMent.Size = new System.Drawing.Size(75, 23);
            this.btnMent.TabIndex = 3;
            this.btnMent.Text = "Mentés";
            this.btnMent.UseVisualStyleBackColor = true;
            this.btnMent.Click += new System.EventHandler(this.BtnMent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Magasság";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ország";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 121);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Csucs";
            // 
            // btnFel
            // 
            this.btnFel.Location = new System.Drawing.Point(267, 336);
            this.btnFel.Name = "btnFel";
            this.btnFel.Size = new System.Drawing.Size(75, 23);
            this.btnFel.TabIndex = 7;
            this.btnFel.Text = "Feltöltés";
            this.btnFel.UseVisualStyleBackColor = true;
            this.btnFel.Click += new System.EventHandler(this.BtnFel_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(186, 336);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(75, 23);
            this.btnTorol.TabIndex = 8;
            this.btnTorol.Text = "Törlés";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.BtnTorol_Click);
            // 
            // btnKilep
            // 
            this.btnKilep.Location = new System.Drawing.Point(24, 336);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(75, 23);
            this.btnKilep.TabIndex = 9;
            this.btnKilep.Text = "Kilépés";
            this.btnKilep.UseVisualStyleBackColor = true;
            this.btnKilep.Click += new System.EventHandler(this.BtnKilep_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(463, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(325, 303);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(267, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnFel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMent);
            this.Controls.Add(this.txtOrszag);
            this.Controls.Add(this.txtCucs);
            this.Controls.Add(this.txtMag);
            this.Name = "Form1";
            this.Text = "TengerszintGUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMag;
        private System.Windows.Forms.TextBox txtCucs;
        private System.Windows.Forms.TextBox txtOrszag;
        private System.Windows.Forms.Button btnMent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFel;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnKilep;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

