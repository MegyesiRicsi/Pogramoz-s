using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210923_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_kilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_evszak_Click(object sender, EventArgs e)
        {
            switch (int.Parse(txt_sorszam.Text))
            {
                case >= 3 and <= 5:
                    lbl_honap.Text = "Tavasz";
                    break;
                case >= 6 and <= 8:
                    lbl_honap.Text = "Nyár";
                    break;
                case >=9  and <=11 :
                    lbl_honap.Text = "Ősz";
                    break;
                case 12 or 1 or  2:
                    lbl_honap.Text = "Tél";
                    break;
                case >=12 :
                    lbl_honap.Text = "Kivül esik a Hónapok számán!";
                    MessageBox.Show("Hibás karakter vagy túl nagy szám!");
                    break;
            }
        }
    }
}
