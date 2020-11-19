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
    public partial class Form1 : Form
    {
        public int numberForTimer;
        public Form1()
        {
            InitializeComponent();

            this.readyCheckBox.CheckedChanged += new EventHandler(ReadyCheckBox__CheckedChanged);
            this.numberTextBox.TextChanged += new EventHandler(NumberTextBox__TextChanged);
            this.niceButton.Click += new EventHandler(NiceButton__Click);

            this.numberTextBox.Visible = false;
            this.niceButton.Visible = false;
            this.label.Visible = false;

            this.niceButton.Enabled = false;

            this.button1.Click += new EventHandler(Button1__Click);
        }

        private void ReadyCheckBox__CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (cb.Checked)
            {
                this.numberTextBox.Visible = true;
                this.niceButton.Visible = true;
                this.label.Visible = true;
            }
            else
            {
                this.numberTextBox.Visible = false;
                this.niceButton.Visible = false;
                this.label.Visible = false;
            }
        }

        private void NumberTextBox__TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int reply = Int32.Parse(tb.Text);

            if (reply == 1 || reply == 2 || reply == 3)
            {
                tb.Tag = true;
                this.niceButton.Enabled = true;

                numberForTimer = reply;
            }
            else
            {
                this.errorProvider.SetError(tb, "Not a valid Number");
                tb.Tag = false;
            }
        }

        private void NiceButton__Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(numberForTimer);
            form3.ShowDialog();
        }

        private void Button1__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
