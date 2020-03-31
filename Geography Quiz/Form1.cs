using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geography_Quiz
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        // "Check" button method, takes the string input from txbAnswer and runs it through a Regular Expression to validate the answer.
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txbAnswer.Text, @"(Pacific Ocean?|Pacific)", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Correct!", "Result");
            } else
            {
                MessageBox.Show("Incorrect, the correct answer was the Pacific Ocean.", "Result");
            }
        }
    }
}
