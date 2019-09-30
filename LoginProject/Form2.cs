using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace LoginProject
{
    public partial class Form2 : Form
    {
        Thread th1;
        string error;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Form Loads

            if (!Directory.Exists("C:\\LOGIN"))
            {
                Directory.CreateDirectory("C:\\LOGIN");
            }
        }

        private void LOGIN(object obj)
        {
            Application.Run(new Form1());
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            // Username Label

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            // Username Textbox

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            // Password Label

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            // Password Textbox

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            // Confirm Label

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            // Confirm Textbox

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Register Confirm Button
            if (textBox2.Text == "")
            {
                error = "Username is empty";
                MessageBox.Show("ERROR: " + error);
            }
            else if (textBox1.Text == "")
            {
                error = "Password is empty";
                MessageBox.Show("ERROR: " + error);
            }
            else if (textBox3.Text == "")
            {
                error = "Confirm Passowrd is empty";
                MessageBox.Show("ERROR: " + error);
            }
            else if (textBox1.Text != textBox3.Text)
            {
                error = "Password do not match";
                MessageBox.Show("ERROR: " + error);
            }
            else
            {

                if (!File.Exists(@"C:\LOGIN\login.txt"))
                {
                    string log = textBox2.Text+","+textBox1.Text;
                    File.AppendAllText(@"C:\LOGIN\login.txt", log);
                }
                else
                {
                    string log = textBox2.Text + "," + textBox1.Text;
                    File.AppendAllText(@"C:\LOGIN\login.txt", log);
                }

                this.Close();
                th1 = new Thread(LOGIN);
                th1.SetApartmentState(ApartmentState.STA);
                th1.Start();
            }
        }
    }
}
