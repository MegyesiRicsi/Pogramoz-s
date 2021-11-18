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

namespace _20211118_Form1GUI
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

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_del_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MessageBox.Show("ListBox törölve");
        }

        private void Btn_fel_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txt_datum.Text = "";
            txt_hely.Text = "";
            txt_helyezes.Text = "";
            txt_pont.Text = "";
            var sr = new StreamReader("Prost.csv", Encoding.Default);
            var elso = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                listBox1.Items.Add(sr.ReadLine());
            }
            sr.Close();
            MessageBox.Show("ListBox sikeresen feltöltve és a txtBoxok kitörölve");

        }

        private void Btn_fileba_Click(object sender, EventArgs e)
        {
            var datum = txt_datum.Text;
            var hely = txt_hely.Text;
            var helyezes =int.Parse( txt_helyezes.Text);
            var pont = int.Parse(txt_pont.Text);
            if (pont>=0 && helyezes>0)
            {
                if (File.Exists("adatok.txt"))
                {
                    File.AppendAllText("adatok.txt", datum + "\t" + hely + "\t" + helyezes + "\t" + pont + "\n");
                }
                else
                {
                    File.Create("adatok.txt");
                    File.AppendAllText("adatok.txt", datum + "\t" + hely + "\t" + helyezes + "\t" + pont + "\n");
                }
            }
            else
            {
                MessageBox.Show("Hibás Pont vagy helyezés! <=0");
            }
           
           
           
        }

        private void Btn_kereses_Click(object sender, EventArgs e)
        {
            
           
            var datum = txt_datum.Text;
            var helyszin = txt_hely.Text;
            var lista = new List<string>();
            if (listBox1.Items.Count!=0)
            {
                foreach (var item in listBox1.Items)
                {
                    if (item.ToString().Contains(datum) && item.ToString().Contains(helyszin))
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
        }

        private void Btn_listaba_Click(object sender, EventArgs e)
        {
            var datum = txt_datum.Text;
            var hely = txt_hely.Text;
            var helyezes = int.Parse(txt_helyezes.Text);
            var pont = int.Parse(txt_pont.Text);

            if (pont >= 0 && helyezes > 0)
            {
                listBox1.Items.Add(datum + "\t" + hely + "\t" + helyezes + "\t" + pont + "\n");
            }
            else
            {
                MessageBox.Show("Hibás adatok");
            }
        }

        private void Btn_filedel_Click(object sender, EventArgs e)
        {
            File.Delete("adatok.txt");
        }
    }
}
