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
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form Loads
            if (!Directory.Exists("C:\\LOGIN"))
            {
                Directory.CreateDirectory("C:\\LOGIN");
            }

        }

        private void REGISTER(object obj)
        {
            Application.Run(new Form2());
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            // Username Label

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            // Username Texbox

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            // Passowrd Label

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            // Password Textbox

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Login Button

            if(!File.Exists(@"C:\LOGIN\login.txt")) // Check if the file exists
            {
                this.Close();
                th = new Thread(REGISTER);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Register Button

        }
    }
}
