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

namespace _2021._12._09_cbradioGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ki_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_del_Click(object sender, EventArgs e)
        {
            txt_hsz.Text = "";
            txt_nev.Text = "";
            txt_ora.Text = "";
            txt_perc.Text = "";
        }

        private void Txt_ora_Click(object sender, EventArgs e)
        {
            txt_ora.Text = "";
        }

        private void Txt_perc_Click(object sender, EventArgs e)
        {
            txt_perc.Text = "";
        }

        private void Txt_hsz_Click(object sender, EventArgs e)
        {
            txt_hsz.Text = "";
        }

        private void Btn_file_Click(object sender, EventArgs e)
        {
            if (File.Exists("adatok2.txt"))
            {

            }
            else
            {
                File.Create("adatok2.txt");
            }
            
            try
            {
                int ora = int.Parse(txt_ora.Text);
                int perc = int.Parse(txt_perc.Text);
                int hsz = int.Parse(txt_hsz.Text);
                string nev = txt_nev.Text;
                

                if (ora >= 6 && ora <= 13 && perc >= 0 && ora <= 59 && hsz >= 0 && ora <= 10)
                {
                    listBox1.Items.Add(ora+";"+perc+";"+hsz+";"+nev);
                    string sor = ora + ";" + perc + ";" + hsz + ";" + nev;
                    
                   File.AppendAllText("adatok2.txt", sor+"\n");

                }
                else
                {
                    MessageBox.Show("rossz");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("hibás bemeneti karakterlánc");
                txt_hsz.Text = "";               
                txt_ora.Text = "";
                txt_perc.Text = "";
            }
            
        }
    }
}
