using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _20211021_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_tor_Click(object sender, EventArgs e)
        {
            if (txt_szoveg.Text=="" || txt_szoveg.Text==" ")
            {
                MessageBox.Show("Nem adtál meg semmit");
            }
            else 
            {
                var darabok = (txt_szoveg.Text.Trim().Split(' '));
                foreach (var item in darabok)
                {
                    listBox1.Items.Add(item);
                }
            }
            


        }

        private void btn_kilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            txt_szoveg.Text = "";
            listBox1.Items.Clear();
        }

        private void Btn_ir_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count!=0)
            {
                foreach (var item in listBox1.Items)
                {

                    File.AppendAllText("darab.txt", item + "\n");
                }
            }
        }

        private void Btn_olvas_Click(object sender, EventArgs e)
        {

        }
    }
}
