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
            List<int> oszto = new List<int>();
            if (nagy < kicsi)
            {
                MessageBox.Show("Hibás bemeneti adat!");
                txt_nagy.Text = "";
                txt_kicsi.Text = "";
            }
            else
            {
                try
                {

                    for (int i = 1; i <= kicsi; i++)
                    {
                        if (kicsi % i == 0 && nagy % i == 0)
                        {
                            oszto.Add(i);
                        }
                    }
                    int kozos = oszto.Max();
                    txt_kozos.Text = Convert.ToString(kozos);
                

            }
                catch (InvalidOperationException)
            {
                
                throw;
            }

        }
            
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
