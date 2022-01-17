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
using Microsoft.VisualBasic;

namespace _20220112_tarsalgoGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            checkedListBox1.Items.Add("Feltöltés");
            checkedListBox1.Items.Add("Kiir");
            checkedListBox1.Items.Add("Törlés");
            checkedListBox1.Items.Add("Keres");
            checkedListBox1.Items.Add("Kilép");            
            checkedListBox1.Items.Add("Function");

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedItem.ToString()=="Kilép")
            {
                this.Close();
            }
            else if (checkedListBox1.SelectedItem.ToString() == "Feltöltés")
            {
                var sr = new StreamReader("ajto.txt");
                while (!sr.EndOfStream)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }
            }
            else if (checkedListBox1.SelectedItem.ToString() == "Keres")
            {
                var lista = new List<string>();
                var sr = new StreamReader("ajto.txt");
                while (!sr.EndOfStream)
                {
                    lista.Add(sr.ReadLine());
                }
                
               
                string keres = Interaction.InputBox("Üres Tééér", "Keresés", "id");
            }
            else if (checkedListBox1.SelectedItem.ToString() == "Törlés")
            {
                listBox1.Items.Clear();
            }
            else if (checkedListBox1.SelectedItem.ToString() == "szinezés")
            {
                
            }


        }
    }
}
