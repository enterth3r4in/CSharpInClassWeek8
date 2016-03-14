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

namespace CSharpInClassWeek8
{
    public partial class Form1 : Form
    {
        int[] randomNumbers = new int[10];
        Random rand = new Random();
        string[] namesArray = new string[10];
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
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rand.Next(25);
            }

            sortNumbers(randomNumbers);

            foreach (int number in randomNumbers)
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
            namesArray[namesIndex] = tbEnterName.Text;
            lbNameList.Items.Add(namesArray[namesIndex]);
            namesIndex++;
            tbEnterName.Clear();
        }

        private void btnWriteNumbers_Click(object sender, EventArgs e)
        {
            StreamWriter OutputFile;

            OutputFile = File.AppendText("RandomNumbers.txt");

            for (int j = 0; j < randomNumbers.Length; j++)
            {
                OutputFile.WriteLine(randomNumbers[j]);
            }

            OutputFile.Close();
        }

        private void btnReadNumbers_Click(object sender, EventArgs e)
        {
            int index = 0;
            StreamReader inputFile;
            lbNumberList.Items.Clear();
            inputFile = File.OpenText("RandomNumbers.txt");

            while (index < randomNumbers.Length || !inputFile.EndOfStream)
            {
                lbNumberList.Items.Add(inputFile.ReadLine());
                index++;
            }

            inputFile.Close();
        }

        private void sortNumbers(int[] numbersToSort)
        {
            int holdVal = 0;

            for (int j = 0; j < numbersToSort.Length; j++)
            {
                for (int i = 0; i < numbersToSort.Length - 1; i++)
                {
                    if (numbersToSort[i] > numbersToSort[i + 1])
                    {
                        holdVal = numbersToSort[i + 1];
                        numbersToSort[i + 1] = numbersToSort[i];
                        numbersToSort[i] = holdVal;
                    }
                }
            }
         }

        private void btnCheckName_Click(object sender, EventArgs e)
        {
            if(checkNames(namesArray))
            {
                MessageBox.Show(tbCheckName.Text + " is in the list.");
            }
            else
            {
                MessageBox.Show(tbCheckName.Text + " is not in the list.");
            }
        }

        private bool checkNames(string[] names)
        {
            bool checker = false;
            foreach(string name in namesArray)
            {
                if (name == tbCheckName.Text)
                    checker = true;
            }
            return checker;
        }
    }
}