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

namespace _20211125_HotelLiftGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_kilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_felt_Click(object sender, EventArgs e)
        {
            var sr = new StreamReader("lift.txt");
            while (!sr.EndOfStream)
            {
                listBox1.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }

        private void Btn_Torol_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Btn_keres_Click(object sender, EventArgs e)
        {
            var datum = txt_date.Text;
            var lista = new List<string>();
            if (listBox1.Items.Count != 0)
            {
                foreach (var item in listBox1.Items)
                {
                    if (item.ToString().Contains(datum))
                    {
                        lista.Add(item.ToString());
                    }
                }
                listBox1.Items.Clear();
                foreach (var item in lista)
                {
                    listBox1.Items.Add(item);
                }
            }
            btn_keres.Enabled = false;
            }

        private void Btn_lbir_Click(object sender, EventArgs e)
        {
            string datum = txt_date.Text;
            string kartya = txt_kartya.Text;
            string start = txt_start.Text;
            string vege = txt_cel.Text;
            try
            {
                int szam_kartya = int.Parse(kartya);
                int szam_start = int.Parse(start);
                int szam_cel = int.Parse(vege);
                listBox1.Items.Add(datum + " " + kartya + " " + start + " " + vege + "\n");
                txt_cel.Text = "";
                txt_date.Text = "";
                txt_kartya.Text = "";
                txt_start.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Valahova nem megfelő adatot adott meg");
            }
        }

        private void Btn_kiir_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count!=0)
            {
                foreach (var item in listBox1.Items)
                {
                    File.AppendAllText("sanyi.txt",item+ "\n");
                 
                }
                MessageBox.Show("Sikeres file ba irás");
                
            }
            else
            {
                MessageBox.Show("Üres a lista");
            }
           
        }
    }
}
