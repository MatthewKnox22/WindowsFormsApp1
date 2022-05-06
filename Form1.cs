using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnWordResult_Click(object sender, EventArgs e)
        {
            string words = txtString.Text.Trim();
            MessageBox.Show("Number of words: " + CountWords(words));
        }
        private int CountWords(string words)
        {
            string[] allWords = words.Split(' ');
            return allWords.Length;
        }
    }
}
