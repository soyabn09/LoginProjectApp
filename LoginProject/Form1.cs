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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form Loads

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

            if(!File.Exists(@"C:\TEST INC\login.txt")) // Check if the file exists
            {
                // Send to Register Form

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Register Button

        }
    }
}
