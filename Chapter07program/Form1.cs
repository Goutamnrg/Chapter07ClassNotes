using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter07program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool flag;
            int i;
            int start;
            int end;
            string buff;
            int j;
            int square;
            int nextOddInteger;

            // ==============Gather Input==============

            // Convert start from text to int

            flag = int.TryParse(txtstart.Text, out start);
            if (flag == false)
            {
                MessageBox.Show("Numeric data only", "Input Error");
                txtstart.Focus();
                return;

            }
            // convert end from text to int
            flag = int.TryParse(txtEnd.Text, out end);
            if (flag == false)
            {
                MessageBox.Show("Numeric data only", "Input Error");
                txtEnd.Focus();
                return;
            }
            if (start >= end)
            {
                MessageBox.Show("Start gather than end.", "Input Error");
                txtstart.Focus();
                return;
            }
            //==========Process and Display=========
            for (i = start; i <= end; i++)
            {
                   //buff = string.Format("{0, 5}{1, 20}", i, i * i);
                   // lstOutput.Items.Add(buff);

                nextOddInteger = 1;  // set first odd integer
                square = 0;          // always start with square = 0

                for (j = 0; j < i; j++)
                {
                    square += nextOddInteger;
                    nextOddInteger += 2;

                }
                buff = string.Format("{0, 5}{1, 20}", i, square);
                lstOutput.Items.Add(buff);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtstart.Clear();
            txtEnd.Clear();
            lstOutput.Items.Clear();
        }
    }
}
