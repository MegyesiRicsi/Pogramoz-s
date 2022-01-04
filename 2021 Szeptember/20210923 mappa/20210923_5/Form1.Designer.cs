namespace _20210923_4
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
            this.btn_evszak = new System.Windows.Forms.Button();
            this.btn_kilep = new System.Windows.Forms.Button();
            this.lbl_honap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sorszam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_evszak
            // 
            this.btn_evszak.Location = new System.Drawing.Point(15, 366);
            this.btn_evszak.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_evszak.Name = "btn_evszak";
            this.btn_evszak.Size = new System.Drawing.Size(178, 64);
            this.btn_evszak.TabIndex = 0;
            this.btn_evszak.Text = "Évszak";
            this.btn_evszak.UseVisualStyleBackColor = true;
            this.btn_evszak.Click += new System.EventHandler(this.btn_evszak_Click);
            // 
            // btn_kilep
            // 
            this.btn_kilep.Location = new System.Drawing.Point(477, 366);
            this.btn_kilep.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_kilep.Name = "btn_kilep";
            this.btn_kilep.Size = new System.Drawing.Size(174, 64);
            this.btn_kilep.TabIndex = 1;
            this.btn_kilep.Text = "Kilpés";
            this.btn_kilep.UseVisualStyleBackColor = true;
            this.btn_kilep.Click += new System.EventHandler(this.btn_kilep_Click);
            // 
            // lbl_honap
            // 
            this.lbl_honap.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_honap.Location = new System.Drawing.Point(15, 201);
            this.lbl_honap.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_honap.Name = "lbl_honap";
            this.lbl_honap.Size = new System.Drawing.Size(636, 38);
            this.lbl_honap.TabIndex = 2;
            this.lbl_honap.Text = "Tavasz";
            this.lbl_honap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(5, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hónap sorszáma:";
            // 
            // txt_sorszam
            // 
            this.txt_sorszam.Location = new System.Drawing.Point(273, 64);
            this.txt_sorszam.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_sorszam.Name = "txt_sorszam";
            this.txt_sorszam.Size = new System.Drawing.Size(196, 31);
            this.txt_sorszam.TabIndex = 4;
            this.txt_sorszam.Text = "4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 445);
            this.Controls.Add(this.txt_sorszam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_honap);
            this.Controls.Add(this.btn_kilep);
            this.Controls.Add(this.btn_evszak);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_evszak;
        private System.Windows.Forms.Button btn_kilep;
        private System.Windows.Forms.Label lbl_honap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sorszam;
    }
}

