using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpInClassWeek8
{
    public partial class Form1 : Form
    {
        int[] rNumbers = new int[10];
        Random rand = new Random();
        string[] names = new string[10];
        int namesIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using the program");
            Application.Exit();
        }

        private void populateListBox()
        {
            for(int i = 0; i < rNumbers.Length; i++)
            {
                rNumbers[i] = rand.Next();
            }

            foreach(int number in rNumbers)
            {
                lbNumberList.Items.Add(number);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbNumberList.Items.Clear();
            MessageBox.Show("Cleared!");
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            lbNumberList.Items.Clear();
            populateListBox();
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            names[namesIndex] = tbEnterName.Text;
            lbNameList.Items.Add(names[namesIndex]);
            namesIndex++;
        }
    }
}
