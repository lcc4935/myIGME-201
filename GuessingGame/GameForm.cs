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
    public partial class GameForm : Form
    {
        int answer;
        int nGuesses = 0;
        public GameForm(int lowNumber, int highNumber)
        {
            InitializeComponent();

            Random rand = new Random();
            answer = rand.Next(lowNumber, highNumber);

            this.progressBar.Value = 90;
            this.timer.Interval = 500;
            this.timer.Tick += new EventHandler(Timer_Tick);
            this.timer.Start();
            this.guessButton.Click += new EventHandler(GuessButton__Click);
        }

        private void GuessButton__Click(object sender, EventArgs e)
        {
            int userInput;
            if(Int32.TryParse(guessTextBox.Text, out userInput))
            {
                ++nGuesses;
                if (userInput == answer)
                {
                    this.timer.Stop();
                    valueLabel.Text = "Correct!";
                    DialogResult result = MessageBox.Show("You guessed it in " + nGuesses + "guesses!");
                }
                else
                {
                    if(userInput < answer)
                    {
                        valueLabel.Text = userInput + " is too low.";
                    }
                    else
                    {
                        valueLabel.Text = userInput + " is too high.";
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }

            guessTextBox.Text = "";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            --this.progressBar.Value;

            if(this.progressBar.Value == 0)
            {

            }

        }
    }
}
