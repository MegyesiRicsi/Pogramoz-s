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

namespace _20220106
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

        private void Btn_Fel_Click(object sender, EventArgs e)
        {
            var sr = new StreamReader("uzemanyag.txt");
            while (!sr.EndOfStream)
            {
                listBox1.Items.Add(sr.ReadLine());
            }
            
        }

        private void Btn_lsbe_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = Convert.ToDateTime(txt_date.Text);
                double benzin = double.Parse(txt_benzin.Text);
                double olaj = double.Parse(txt_olaj.Text);
                if (date.Year>=2011 || date.Year<=2016)
                {
                    string s = date.ToString().Substring(0, 10) + ";" + benzin + ";" + olaj;
                    listBox1.Items.Add(s);
                    txt_benzin.Text = "";
                    txt_date.Text = "";
                    txt_olaj.Text = "";
                }
                else
                {
                    throw new Exception();
                }
                
               
            }
            catch (Exception)
            {

                MessageBox.Show("Hibás bemeneti karakter");
                txt_benzin.Text = "";
                txt_date.Text = "";
                txt_olaj.Text = "";
            }
           
        }

        private void Btn_keres_Click(object sender, EventArgs e)
        {
            //DateTime date = Convert.ToDateTime(txt_date.Text);
            string date =(txt_date.Text);
            var lista = new List<string>();
           
            foreach (var item in listBox1.Items)
            {
                if (item.ToString().Contains(date))
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

        private void Btn_liski_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count>0 && saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                
                foreach (var item in listBox1.Items)
                {
                    File.AppendAllText(saveFileDialog1.FileName, item.ToString()+"\n");
                }
            }
            listBox1.Items.Clear();
        }
    }
}
