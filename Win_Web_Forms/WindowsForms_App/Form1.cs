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

namespace WindowsForms_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (CheckValid() == true)
            {
                string[] Vals = new string[3];

                Vals[0] = label1.Text + " " + textBox1.Text;
                Vals[1] = label2.Text + " " + textBox2.Text;
                Vals[2] = label3.Text + " " + textBox3.Text;

                using (StreamWriter writer = new StreamWriter("DataBase.txt",true))
                {
                    for (int i = 0; i < Vals.Length; i++)
                    {
                        writer.Write(Vals[i] + " | ");
                    }
                    writer.WriteLine();
                }
                ClearBoxes();
                ReadText();

                
            }
        }

        private void ReadText()
        {
            using (StreamReader reader = new StreamReader("DataBase.txt"))
            {
                var line = reader.ReadLine();
                listBox1.Items.Clear();

                while (line != null && line != string.Empty)
                {
                    listBox1.Items.Add(line);
                    line = reader.ReadLine();
                }
            }
        }

        private void ClearBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        public bool CheckValid()
        {
            int j = 0;

            if (textBox1.Text != null && textBox1.Text != string.Empty)
            {
                j++;
            }

            if (textBox2.Text != null && textBox2.Text != string.Empty)
            {
                j++;
            }

            if (textBox3.Text != null && textBox3.Text != string.Empty)
            {
                if (textBox3.Text.Length > 5 || textBox3.Text.Contains("@") == true || textBox3.Text.Contains(".") == true)
                {
                    j++;
                }
            }

            if (j==3)
            {
                return true;
            }
            else
            {
                return false;    
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }


    }
}
