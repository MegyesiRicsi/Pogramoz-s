using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210930_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int kicsi = int.Parse(txt_kicsi.Text);
            int nagy = int.Parse(txt_nagy.Text);
            // List<int> oszto = new List<int>();
            int r = 0;
            if (nagy < kicsi)
            {
                MessageBox.Show("Hibás bemeneti adat!");
                txt_nagy.Text = "";
                txt_kicsi.Text = "";
            }
            else
            {
                

                    while (nagy%kicsi!=0)
                    {
                        r = nagy % kicsi;
                        nagy = kicsi;
                        kicsi = r;
                    }
                    txt_kozos.Text = Convert.ToString(kicsi);
                

            }
                

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
}
