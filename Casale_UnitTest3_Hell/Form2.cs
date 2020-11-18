using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casale_UnitTest3_Hell
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            this.Show();
            Form1 form1 = new Form1(this, numberForTimer);
            form1.ShowDialog();
            this.numberForTimer = form1.numForTimer;

            this.button.Click += new EventHandler(Button__Click);


            if (this.numberForTimer == 1)
            {
                timer.Interval = 1000;
            }
            else if (this.numberForTimer == 2)
            {
                timer.Interval = 1000;
            }
            else
            {
                timer.Interval = 1000;
            }

            this.timer.Tick += new EventHandler(Timer__Tick);

            this.label.Visible = false;

            this.button1.Click += new EventHandler(Button1__Click);
        }

        private void Button__Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.label.Visible = true;
        }

        private void Button1__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
