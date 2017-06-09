using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinformApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Input
            string fullName = fullnameTxtbox.Text;

            //Process
            string greet = "Hello, " + fullName+"!";

            //Output
            label2.Text = greet;
            //MessageBox.Show(greet);
        }
    }
}
