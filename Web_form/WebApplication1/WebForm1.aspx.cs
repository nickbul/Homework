using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        string Path = "C:/DataBase.txt";

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (SubmitValidation() == true)
            {
                this.ErrMsg1.Text = "";
                this.ErrMsg1.Enabled = false;

                string[] Vals = new string[4];

                Vals[0] = this.Label1.Text + " " + this.UsrName.Text;
                Vals[1] = this.Label2.Text + " " + this.Pass.Text;
                Vals[2] = this.Label4.Text + " " + this.Age.Text;
                Vals[3] = this.Label5.Text + " " + this.Email.Text;

                using (StreamWriter writer = new StreamWriter(Path, true))
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
            using (StreamReader reader = new StreamReader(Path))
            {
                var line = reader.ReadLine();
                this.ListBox1.Items.Clear();

                while (line != null && line != string.Empty)
                {
                    this.ListBox1.Items.Add(line);
                    line = reader.ReadLine();
                }
            }
        }

        private void ClearBoxes()
        {
            this.UsrName.Text = "";
            this.Age.Text = "";
            this.Pass.Text = "";
            this.Rpass.Text = "";
            this.Email.Text = "";
        }

        private bool SubmitValidation()
        {
            int x = 0;
            if (this.UsrName.Text != null && this.UsrName.Text != string.Empty)
            {
                x++;
            }
            else
            {
                this.ErrMsg1.Enabled = true;
                this.ErrMsg1.Text = "No User name!";
                this.ErrMsg1.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            if (this.Pass.Text != null && this.Pass.Text != string.Empty)
            {
                x++;
            }
            else
            {
                this.ErrMsg1.Enabled = true;
                this.ErrMsg1.Text = "Please enter password!";
                this.ErrMsg1.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            if (this.Rpass.Text != null && this.Rpass.Text != string.Empty)
            {
                x++;
            }
            else
            {
                this.ErrMsg1.Enabled = true;
                this.ErrMsg1.Text = "Re-enter password!";
                this.ErrMsg1.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            if (this.Pass.Text == this.Rpass.Text)
            {
                x++;
            }
            else
            {
                this.ErrMsg1.Enabled = true;
                this.ErrMsg1.Text = "Passwords don't match!";
                this.ErrMsg1.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            try
            {
                int age = int.Parse(this.Age.Text);
                if (age > 8 && age < 100)
                {
                    x++;
                }
                else
                {
                    this.ErrMsg1.Enabled = true;
                    this.ErrMsg1.Text = "Please enter your age!";
                    this.ErrMsg1.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
            }
            catch (Exception)
            {

                this.Age.Text = "";
                this.ErrMsg1.Enabled = true;
                this.ErrMsg1.Text = "Please enter your age using the scroll!";
                this.ErrMsg1.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            
            

            if (this.Email.Text != null && this.Email.Text != string.Empty)
            {
                x++;
            }
            else
            {
                
                this.ErrMsg1.Enabled = true;
                this.ErrMsg1.Text = "Please enter your e-mail!";
                this.ErrMsg1.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            if (x==6)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}