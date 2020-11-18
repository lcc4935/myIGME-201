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
        public Form1()
        {
            InitializeComponent();

            this.readyCheckBox.CheckedChanged += new EventHandler(ReadyCheckBox__CheckedChanged);
            this.numberTextBox.TextChanged += new EventHandler(NumberTextBox__TextChanged);
            this.niceButton.Click += new EventHandler(NiceButton__Click);
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
            try
            {
                Int32.Parse(this.numberTextBox.Text);

            }
            catch
            {
                this.errorProvider.
            }
        }

        private void NiceButton__Click(object sender, EventArgs e)
        {

        }
    }
}
