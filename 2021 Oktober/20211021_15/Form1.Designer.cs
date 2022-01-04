namespace _20211021_15
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
            this.btn_jobbfent = new System.Windows.Forms.Button();
            this.btn_ballent = new System.Windows.Forms.Button();
            this.btn_jobblent = new System.Windows.Forms.Button();
            this.btn_balfent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_jobbfent
            // 
            this.btn_jobbfent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_jobbfent.Location = new System.Drawing.Point(260, 12);
            this.btn_jobbfent.Name = "btn_jobbfent";
            this.btn_jobbfent.Size = new System.Drawing.Size(237, 165);
            this.btn_jobbfent.TabIndex = 3;
            this.btn_jobbfent.Text = "Jobb fent";
            this.btn_jobbfent.UseVisualStyleBackColor = true;
            this.btn_jobbfent.Click += new System.EventHandler(this.Btn_jobbfent_Click);
            // 
            // btn_ballent
            // 
            this.btn_ballent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ballent.Location = new System.Drawing.Point(12, 183);
            this.btn_ballent.Name = "btn_ballent";
            this.btn_ballent.Size = new System.Drawing.Size(242, 134);
            this.btn_ballent.TabIndex = 4;
            this.btn_ballent.Text = "Bal lent";
            this.btn_ballent.UseVisualStyleBackColor = true;
            this.btn_ballent.Click += new System.EventHandler(this.Btn_ballent_Click);
            // 
            // btn_jobblent
            // 
            this.btn_jobblent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_jobblent.Location = new System.Drawing.Point(260, 183);
            this.btn_jobblent.Name = "btn_jobblent";
            this.btn_jobblent.Size = new System.Drawing.Size(237, 134);
            this.btn_jobblent.TabIndex = 5;
            this.btn_jobblent.Text = "Jobb lent";
            this.btn_jobblent.UseVisualStyleBackColor = true;
            this.btn_jobblent.Click += new System.EventHandler(this.Btn_jobblent_Click);
            // 
            // btn_balfent
            // 
            this.btn_balfent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_balfent.Location = new System.Drawing.Point(12, 12);
            this.btn_balfent.Name = "btn_balfent";
            this.btn_balfent.Size = new System.Drawing.Size(242, 165);
            this.btn_balfent.TabIndex = 6;
            this.btn_balfent.Text = "Bal fent";
            this.btn_balfent.UseVisualStyleBackColor = true;
            this.btn_balfent.Click += new System.EventHandler(this.Btn_balfent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 328);
            this.Controls.Add(this.btn_balfent);
            this.Controls.Add(this.btn_jobblent);
            this.Controls.Add(this.btn_ballent);
            this.Controls.Add(this.btn_jobbfent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_jobbfent;
        private System.Windows.Forms.Button btn_ballent;
        private System.Windows.Forms.Button btn_jobblent;
        private System.Windows.Forms.Button btn_balfent;
    }
}

