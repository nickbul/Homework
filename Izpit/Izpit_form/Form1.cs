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

namespace Izpit_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static string filePath = "Counties.txt";
        int SearchOption = 0;

        private void Add_Click(object sender, EventArgs e)
        {
            var database = Database.GetAllItems();
            int cond = TestCond();
            bool fLag = false;

            for (int i = 0; i < database.Count(); i++)
            {
                if (textCountry.Text == database[i].Countr)
                {
                    MessageBox.Show("Already have " + textCountry.Text + " in countries list!");
                    fLag = true;
                    break;
                }
            }

            if (fLag == false)
            {
                if (cond != 3)
                {
                    MessageBox.Show("Please fill all categories!");
                }
                else
                {
                    var countryToAdd = new Country()
                    {
                        Countr = this.textCountry.Text,
                        Capital = this.textCapital.Text,
                        Population = Convert.ToInt64(this.numericPopulation.Value),
                    };

                    this.AddCountry(countryToAdd);

                    this.textCountry.Text = "";
                    this.textCapital.Text = "";
                    this.numericPopulation.Value = 0;
                }
            }
        }

        private int TestCond()
        {
            int x = 0;

            if (textCountry.Text != null && textCountry.Text != string.Empty)
            {
                x++;
            }

            if (textCapital.Text != null && textCapital.Text != string.Empty)
            {
                x++;
            }

            if (numericPopulation.Value != 0 && numericPopulation.Value > 0)
            {
                x++;
            }

            return x;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            var database = Database.GetAllItems();
            var listOfmatches = new List<Country>();

            try
            {
                switch (SearchOption)
                {
                    case 1:
                        string sCountry = SearchCount.Text;

                        for (int i = 0; i < database.Count(); i++)
                        {
                            if (database[i].Countr.Contains(sCountry))
                            {
                                listOfmatches.Add(database[i]);
                            }
                        }

                        SearchCount.Text = "";
                        break;

                    case 2:
                        string sCap = SearchCap.Text;

                        for (int i = 0; i < database.Count; i++)
                        {
                            if (database[i].Capital.Contains(sCap))
                            {
                                listOfmatches.Add(database[i]);
                            }
                        }

                        SearchCap.Text = "";
                        break;

                    case 3:
                        long sVal_1 = Convert.ToInt64(numericMin.Value);
                        long sVal_2 = Convert.ToInt64(numericMax.Value);

                        for (int i = 0; i < database.Count; i++)
                        {
                            if (database[i].Population >= sVal_1 && database[i].Population <= sVal_2)
                            {
                                listOfmatches.Add(database[i]);
                            }
                        }

                        numericMin.Value = 0;
                        numericMax.Value = 0;
                        dataGridView1.DataSource = listOfmatches;
                        break;

                    default:

                        break;
                }

                dataGridView1.DataSource = listOfmatches;
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error, please try again!");
            }
        }

        private void AddCountry(Country countryToAdd)
        {
            using (var writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(countryToAdd.CastToDataBaseRow());
            }
        }

        private void radioCountry_CheckedChanged(object sender, EventArgs e)
        {
            SearchCount.Enabled = true;
            Search.Enabled = true;
            SearchCap.Enabled = false;
            numericMin.Enabled = false;
            numericMax.Enabled = false;
            SearchOption = 1;
        }

        private void radioCapital_CheckedChanged(object sender, EventArgs e)
        {
            SearchCap.Enabled = true;
            Search.Enabled = true;
            SearchCount.Enabled = false;
            numericMin.Enabled = false;
            numericMax.Enabled = false;
            SearchOption = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            numericMin.Enabled = true;
            numericMax.Enabled = true;
            Search.Enabled = true;
            SearchCap.Enabled = false;
            SearchCount.Enabled = false;
            SearchOption = 3;
        }

        private void ListAllbutton_Click(object sender, EventArgs e)
        {
            try
            {
                var database = Database.GetAllItems();
                dataGridView1.DataSource = database;
            }
            catch (Exception)
            {
                MessageBox.Show("There are no countries to show!");
            }
        }
    }
}
