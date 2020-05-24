//*******************************************************************
// Programmer: Tenzin Dendup
// Date: 25 April 2019
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64bit Version 1803
// Purpose: Performing calculation using the bypass references
//*******************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment1a
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {

            int firstNumber = Int32.Parse(txtFirstNo.Text); // getting the values from users and storing to the variable 
            int SecondNumber = Int32.Parse(txtSecondNumber.Text);

            
            int total = subtract(ref firstNumber, ref SecondNumber);
            txtResult.Text = "YOur result is "+total.ToString();

        }
        public int subtract(ref int x, ref int y) // function to pass by reference
        {
            int total; // to hold the total value of the arthemtic 
            total = x - y; // first values - second value
            return total; // returning the values back to the click event 
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int firstNumber = Int32.Parse(txtFirstNo.Text); // getting the values from users and storing to the variable 
            int SecondNumber = Int32.Parse(txtSecondNumber.Text);


            int total = firstNumber +SecondNumber;
            txtResult.Text = "YOur result is " + total.ToString();
        }
    }
}
