using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classCourse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.majorComboBox.SelectedIndexChanged += new EventHandler(MajorComboBox__SelectedIndexChanged);
            this.minorComboBox.SelectedIndexChanged += new EventHandler(MinorComboBox__SelectedIndexChanged);
            this.extraClassComboBox.SelectedIndexChanged += new EventHandler(ExtraClassComboBox__SelectedIndexChanged);
            this.newClassCreditComboBox.SelectedIndexChanged += new EventHandler(NewClassCreditComboBox__SelectedIndexChanged);
            this.newClassTypeComboBox.SelectedIndexChanged += new EventHandler(NewClassTypeComboBox__SelectedIndexChanged);

            this.minorCheckBox.CheckedChanged += new EventHandler(this.minorCheckBox__CheckedChanged);

            this.majorTextBox.TextChanged += new EventHandler(MajorTextBox__TextChanged);
            this.immersionTextBox.TextChanged += new EventHandler(ImmersionTextBox__TextChanged);
            this.minorTextBox.TextChanged += new EventHandler(MinorTextBox__TextChanged);
            this.creditTextBox.TextChanged += new EventHandler(CreditTextBox__TextChanged);
            this.newClassTextBox.TextChanged += new EventHandler(NewClassTextBox__TextChanged);

            this.okButton.Enabled = false;
            this.okButton.Click += new EventHandler(OkButton__Click);

            this.minorClassLabel.Visible = false;
            this.minorComboBox.Visible = false;
            this.minorLabel.Visible = false;
            this.minorTextBox.Visible = false;
        }

        //ComboBoxes
        private void MajorComboBox__SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
        }

        private void MinorComboBox__SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
        }

        private void ExtraClassComboBox__SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
        }

        private void NewClassCreditComboBox__SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
        }

        private void NewClassTypeComboBox__SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
        }

        //Checkboxes
        private void minorCheckBox__CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (cb.Checked)
            {
                this.minorClassLabel.Visible = true;
                this.minorComboBox.Visible = true;
                this.minorLabel.Visible = true;
                this.minorTextBox.Visible = true;
            }
            else
            {
                this.minorClassLabel.Visible = false;
                this.minorComboBox.Visible = false;
                this.minorLabel.Visible = false;
                this.minorTextBox.Visible = false;
            }

        }

        //Text Boxes
        private void MajorTextBox__TextChanged(object sender, EventArgs e) // add error provider
        {
            TextBox tb = (TextBox)sender;

            //if empty
            if (tb.Text.Length == 0)
            {
                // show error
                //this.errorProvider.SetError(tb, "This field cannot be empty.");

                // invalidate the control
                tb.Tag = false;
            }
            else
            {
                // else there is data in the field
                // clear the error
                //this.errorProvider.SetError(tb, null);

                // set the control to being valid
                tb.Tag = true;
            }
        }

        private void ImmersionTextBox__TextChanged(object sender, EventArgs e) // add error provider
        {
            TextBox tb = (TextBox)sender;

            //if empty
            if (tb.Text.Length == 0)
            {
                // show error
                //this.errorProvider.SetError(tb, "This field cannot be empty.");

                // invalidate the control
                tb.Tag = false;
            }
            else
            {
                // else there is data in the field
                // clear the error
                //this.errorProvider.SetError(tb, null);

                // set the control to being valid
                tb.Tag = true;
            }
        }

        private void MinorTextBox__TextChanged(object sender, EventArgs e) // add error provider
        {
            TextBox tb = (TextBox)sender;

            //if empty
            if (tb.Text.Length == 0)
            {
                // show error
                //this.errorProvider.SetError(tb, "This field cannot be empty.");

                // invalidate the control
                tb.Tag = false;
            }
            else
            {
                // else there is data in the field
                // clear the error
                //this.errorProvider.SetError(tb, null);

                // set the control to being valid
                tb.Tag = true;
            }
        }

        private void CreditTextBox__TextChanged(object sender, EventArgs e) // add error provider
        {
            TextBox tb = (TextBox)sender;

            //convert to number
            int tbNum = Int32.Parse(tb.Text);

            //if empty or less than 123
            if (tb.Text.Length == 0 || tbNum < 123)
            {
                // show error
                //this.errorProvider.SetError(tb, "This field cannot be empty.");

                // invalidate the control
                tb.Tag = false;
            }
            else
            {
                // else there is data in the field
                // clear the error
                //this.errorProvider.SetError(tb, null);

                // set the control to being valid
                tb.Tag = true;
            }
        }

        private void NewClassTextBox__TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
        }

        //Buttons
        private void OkButton__Click(object sender, EventArgs e) //come back to this
        {
            
        }
    }
}
