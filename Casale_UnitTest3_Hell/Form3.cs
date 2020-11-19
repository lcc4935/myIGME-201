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
    public partial class Form3 : Form
    {
        int numForTimer;
        public Form3(int numberForTimer)
        {
            InitializeComponent();

            this.numForTimer = numberForTimer;

            this.radioButton1.CheckedChanged += new EventHandler(RadioButton1__CheckedChanged);
            this.radioButton2.CheckedChanged += new EventHandler(RadioButton2__CheckedChanged);
            this.radioButton3.CheckedChanged += new EventHandler(RadioButton3__CheckedChanged);

            this.label.Visible = false;

            this.button1.Click += new EventHandler(Button1__Click);
        }

        private void RadioButton1__CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                this.label.Visible = true;
            }
        }
        private void RadioButton2__CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                this.label.Visible = false;

                Form2 form2 = new Form2(this.numForTimer);
                form2.ShowDialog();
            }
        }
        private void RadioButton3__CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                this.label.Visible = false;
            }
        }

        private void Button1__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
