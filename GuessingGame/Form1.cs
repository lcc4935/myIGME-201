using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class ParameterForm : Form
    {
        public ParameterForm()
        {
            InitializeComponent();

            this.startButton.Click += new EventHandler(StartButton_Click);

            //this.lowTextBox.TextChanged += new EventHandler(LowTextBox__TextChanged);
            //this.highTextBox.TextChanged += new EventHandler(HighTextBox__TextChanged);


        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            bool bConv;
            int lowNumber = 1;
            int highNumber = 100;

            // convert the strings entered in lowTextBox and highTextBox
            // to lowNumber and highNumber Int32.Parse

            lowNumber = Int32.Parse(lowTextBox.Text); ;
            highNumber = Int32.Parse(highTextBox.Text);

            // if not a valid range
            if (lowNumber > highNumber || highNumber < lowNumber)
            {
                // show a dialog that the numbers are not valid
                MessageBox.Show("The numbers are invalid.");
            }
            else
            {
                // otherwise we're good
                // create a form object of the second form 
                // passing in the number range
                GameForm gameForm = new GameForm(lowNumber, highNumber);

                // display the form as a modal dialog, 
                // which makes the first form inactive
                gameForm.ShowDialog();
            }
        }

        /*
        private void LowTextBox__TextChanged(object sender, EventArgs e)
        {

        }

        private void HighTextBox__TextChanged(object sender, EventArgs e)
        {

        }
        */


    }
}
