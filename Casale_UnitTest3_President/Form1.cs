using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 Errors:
the timer/progress bar doesn't work
checkbox in the groupbox - unsure what this does
exit button works, even without all answers being correct
formatting of webbrowser looks really weird
 */

namespace Casale_UnitTest3_President
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //radio buttons
            this.bHRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.fDRRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.wJCRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.jBRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.fPRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.gWBRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.bORadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.jFKRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.wMRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.rRRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.dDERadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.mVRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.gWRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.jARadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.tRRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.tJRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);


            this.allRadioButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckedChanged);
            this.demRadioButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckedChanged);
            this.repRadioButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckedChanged);
            this.dRRadioButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckedChanged);
            this.fedRadioButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckedChanged);


            //textboxes
            this.bHTextBox.TextChanged += new EventHandler(TextBox__TextChanged);
            this.fDRTextBox.TextChanged += new EventHandler(TextBox__TextChanged);
            this.wJCTextBox.TextChanged += new EventHandler(TextBox__TextChanged);
            this.jBTextBox.TextChanged += new EventHandler(TextBox__TextChanged);
            this.fPTextBox.TextChanged += new EventHandler(TextBox__TextChanged);
            this.gWBTextBox.TextChanged += new EventHandler(TextBox__TextChanged);
            this.bOTextBox.TextChanged += new EventHandler(TextBox__TextChanged);
            this.jFKTextBox.TextChanged += new EventHandler(TextBox__TextChanged);
            this.wMTextBox.TextChanged += new EventHandler(TextBox__TextChanged);
            this.rRTextBox.TextChanged += new EventHandler(TextBox__TextChanged);
            this.dDETextBox.TextChanged += new EventHandler(TextBox__TextChanged);
            this.mVTextBox.TextChanged += new EventHandler(TextBox__TextChanged);
            this.gWTextBox.TextChanged += new EventHandler(TextBox__TextChanged);
            this.jATextBox.TextChanged += new EventHandler(TextBox__TextChanged);
            this.tRTextBox.TextChanged += new EventHandler(TextBox__TextChanged);
            this.tJTextBox.TextChanged += new EventHandler(TextBox__TextChanged);

            this.bHTextBox.MouseHover += new EventHandler(BHTextBox__MouseHover);
            this.fDRTextBox.MouseHover += new EventHandler(FDRTextBox__MouseHover);
            this.wJCTextBox.MouseHover += new EventHandler(WJCTextBox__MouseHover);
            this.jBTextBox.MouseHover += new EventHandler(JBTextBox__MouseHover);
            this.fPTextBox.MouseHover += new EventHandler(FPTextBox__MouseHover);
            this.gWBTextBox.MouseHover += new EventHandler(GWBTextBox__MouseHover);
            this.bOTextBox.MouseHover += new EventHandler(BOTextBox__MouseHover);
            this.jFKTextBox.MouseHover += new EventHandler(JFKTextBox__MouseHover);
            this.wMTextBox.MouseHover += new EventHandler(WMTextBox__MouseHover);
            this.rRTextBox.MouseHover += new EventHandler(RRTextBox__MouseHover);
            this.dDETextBox.MouseHover += new EventHandler(DDETextBox__MouseHover);
            this.mVTextBox.MouseHover += new EventHandler(MVTextBox__MouseHover);
            this.gWTextBox.MouseHover += new EventHandler(GWTextBox__MouseHover);
            this.jATextBox.MouseHover += new EventHandler(JATextBox__MouseHover);
            this.tRTextBox.MouseHover += new EventHandler(TRTextBox__MouseHover);
            this.tJTextBox.MouseHover += new EventHandler(TJTextBox__MouseHover);

            //picture
            this.pictureBox.MouseEnter += new EventHandler(PictureBox__MouseEnter);
            this.pictureBox.MouseLeave += new EventHandler(PictureBox__MouseLeave);


            //timer & button
            this.timer.Tick += new EventHandler(Timer__Tick);
            this.exitButton.Click += new EventHandler(ExitButton__Click);
        }

        private void BHTextBox__MouseHover(object sender, EventArgs e)
        {
            this.toolTip.Show("What # President?", this.bHTextBox);               
        }
        private void FDRTextBox__MouseHover(object sender, EventArgs e)
        {
            this.toolTip.Show("What # President?", this.fDRTextBox);
        }
        private void WJCTextBox__MouseHover(object sender, EventArgs e)
        {
            this.toolTip.Show("What # President?", this.wJCTextBox);
        }
        private void JBTextBox__MouseHover(object sender, EventArgs e)
        {
            this.toolTip.Show("What # President?", this.jBTextBox);
        }
        private void FPTextBox__MouseHover(object sender, EventArgs e)
        {
            this.toolTip.Show("What # President?", this.fPTextBox);
        }
        private void GWBTextBox__MouseHover(object sender, EventArgs e)
        {
            this.toolTip.Show("What # President?", this.gWBTextBox);
        }
        private void BOTextBox__MouseHover(object sender, EventArgs e)
        {
            this.toolTip.Show("What # President?", this.bOTextBox);
        }
        private void JFKTextBox__MouseHover(object sender, EventArgs e)
        {
            this.toolTip.Show("What # President?", this.jFKTextBox);
        }
        private void WMTextBox__MouseHover(object sender, EventArgs e)
        {
            this.toolTip.Show("What # President?", this.wMTextBox);
        }
        private void RRTextBox__MouseHover(object sender, EventArgs e)
        {
            this.toolTip.Show("What # President?", this.rRTextBox);
        }
        private void DDETextBox__MouseHover(object sender, EventArgs e)
        {
            this.toolTip.Show("What # President?", this.dDETextBox);
        }
        private void MVTextBox__MouseHover(object sender, EventArgs e)
        {
            this.toolTip.Show("What # President?", this.mVTextBox);
        }
        private void GWTextBox__MouseHover(object sender, EventArgs e)
        {
            this.toolTip.Show("What # President?", this.gWTextBox);
        }
        private void JATextBox__MouseHover(object sender, EventArgs e)
        {
            this.toolTip.Show("What # President?", this.jATextBox);
        }
        private void TRTextBox__MouseHover(object sender, EventArgs e)
        {
            this.toolTip.Show("What # President?", this.tRTextBox);
        }
        private void TJTextBox__MouseHover(object sender, EventArgs e)
        {
            this.toolTip.Show("What # President?", this.tJTextBox);
        }



        private void PictureBox__MouseEnter(object sender, EventArgs e)
        {
            pictureBox.Size = new System.Drawing.Size(300, 400);
        }
        private void PictureBox__MouseLeave(object sender, EventArgs e)
        {
            pictureBox.Size = new System.Drawing.Size(150, 200);
        }

        private void ExitButton__Click(object sender, EventArgs e) //come back to this
        {
            //this.exitButton.Enabled = this.tbText.Tag;
            Application.Exit();
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            --this.progressBar.Value;

            if (this.progressBar.Value == 0)
            {
                timer.Stop();
            }
        }

        private void TextBox__TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text != "0" && timer.Enabled == false)
            {
                this.timer.Interval = 120000;
                this.progressBar.Value = 120;

                timer.Start();
            }

            if (tb.Name == "bHTextBox")
            {
                if (tb.Text != "23")
                {
                    this.errorProvider.SetError(tb, "That is the wrong number.");
                    tb.Tag = false;
                }
                else
                {
                    this.errorProvider.SetError(tb, null);
                    tb.Tag = true;
                }
            }
            if (tb.Name == "fDRTextBox")
            {
                if (tb.Text != "32")
                {
                    this.errorProvider.SetError(tb, "That is the wrong number.");
                    tb.Tag = false;
                }
                else
                {
                    this.errorProvider.SetError(tb, null);
                    tb.Tag = true;
                }
            }
            if (tb.Name == "wJCTextBox")
            {
                if (tb.Text != "42")
                {
                    this.errorProvider.SetError(tb, "That is the wrong number.");
                    tb.Tag = false;
                }
                else
                {
                    this.errorProvider.SetError(tb, null);
                    tb.Tag = true;
                }
            }
            if (tb.Name == "jBTextBox")
            {
                if (tb.Text != "15")
                {
                    this.errorProvider.SetError(tb, "That is the wrong number.");
                    tb.Tag = false;
                }
                else
                {
                    this.errorProvider.SetError(tb, null);
                    tb.Tag = true;
                }
            }
            if (tb.Name == "fPTextBox")
            {
                if (tb.Text != "14")
                {
                    this.errorProvider.SetError(tb, "That is the wrong number.");
                    tb.Tag = false;
                }
                else
                {
                    this.errorProvider.SetError(tb, null);
                    tb.Tag = true;
                }
            }
            if (tb.Name == "gWBTextBox")
            {
                if (tb.Text != "43")
                {
                    this.errorProvider.SetError(tb, "That is the wrong number.");
                    tb.Tag = false;
                }
                else
                {
                    this.errorProvider.SetError(tb, null);
                    tb.Tag = true;
                }
            }
            if (tb.Name == "bOTextBox")
            {
                if (tb.Text != "44")
                {
                    this.errorProvider.SetError(tb, "That is the wrong number.");
                    tb.Tag = false;
                }
                else
                {
                    this.errorProvider.SetError(tb, null);
                    tb.Tag = true;
                }
            }
            if (tb.Name == "jFKTextBox")
            {
                if (tb.Text != "35")
                {
                    this.errorProvider.SetError(tb, "That is the wrong number.");
                    tb.Tag = false;
                }
                else
                {
                    this.errorProvider.SetError(tb, null);
                    tb.Tag = true;
                }
            }
            if (tb.Name == "wMTextBox")
            {
                if (tb.Text != "25")
                {
                    this.errorProvider.SetError(tb, "That is the wrong number.");
                    tb.Tag = false;
                }
                else
                {
                    this.errorProvider.SetError(tb, null);
                    tb.Tag = true;
                }
            }
            if (tb.Name == "rRTextBox")
            {
                if (tb.Text != "40")
                {
                    this.errorProvider.SetError(tb, "That is the wrong number.");
                    tb.Tag = false;
                }
                else
                {
                    this.errorProvider.SetError(tb, null);
                    tb.Tag = true;
                }
            }
            if (tb.Name == "dDETextBox")
            {
                if (tb.Text != "34")
                {
                    this.errorProvider.SetError(tb, "That is the wrong number.");
                    tb.Tag = false;
                }
                else
                {
                    this.errorProvider.SetError(tb, null);
                    tb.Tag = true;
                }
            }
            if (tb.Name == "mVTextBox")
            {
                if (tb.Text != "8")
                {
                    this.errorProvider.SetError(tb, "That is the wrong number.");
                    tb.Tag = false;
                }
                else
                {
                    this.errorProvider.SetError(tb, null);
                    tb.Tag = true;
                }
            }
            if (tb.Name == "gWTextBox")
            {
                if (tb.Text != "1")
                {
                    this.errorProvider.SetError(tb, "That is the wrong number.");
                    tb.Tag = false;
                }
                else
                {
                    this.errorProvider.SetError(tb, null);
                    tb.Tag = true;
                }
            }
            if (tb.Name == "jATextBox")
            {
                if (tb.Text != "2")
                {
                    this.errorProvider.SetError(tb, "That is the wrong number.");
                    tb.Tag = false;
                }
                else
                {
                    this.errorProvider.SetError(tb, null);
                    tb.Tag = true;
                }
            }
            if (tb.Name == "tRTextBox")
            {
                if (tb.Text != "26")
                {
                    this.errorProvider.SetError(tb, "That is the wrong number.");
                    tb.Tag = false;
                }
                else
                {
                    this.errorProvider.SetError(tb, null);
                    tb.Tag = true;
                }
            }
            if (tb.Name == "tJTextBox")
            {
                if (tb.Text != "3")
                {
                    this.errorProvider.SetError(tb, "That is the wrong number.");
                    tb.Tag = false;
                }
                else
                {
                    this.errorProvider.SetError(tb, null);
                    tb.Tag = true;
                }
            }

        }

        private void PresRadioButton__CheckedChanged(object sender, EventArgs e)
        {

            string url = null;
            string place = null;

            if (this.bHRadioButton.Checked == true)
            {
                url = "https://en.wikipedia.org/wiki/Benjamin_Harrison";
                place = "https://people.rit.edu/dxsigm/BenjaminHarrison.jpeg";
            }
            else if (this.fDRRadioButton.Checked == true)
            {
                url = "https://en.wikipedia.org/wiki/Franklin_D._Roosevelt";
                place = "https://people.rit.edu/dxsigm/FranklinDRoosevelt.jpeg";
            }
            else if (this.wJCRadioButton.Checked == true)
            {
                url = "https://en.wikipedia.org/wiki/Bill_Clinton";
                place = "https://people.rit.edu/dxsigm/WilliamJClinton.jpeg";
            }
            else if (this.jBRadioButton.Checked == true)
            {
                url = "https://en.wikipedia.org/wiki/James_Buchanan";
                place = "https://people.rit.edu/dxsigm/JamesBuchanan.jpeg";
            }
            else if (this.fPRadioButton.Checked == true)
            {
                url = "https://en.wikipedia.org/wiki/Franklin_Pierce";
                place = "https://people.rit.edu/dxsigm/FranklinPierce.jpeg";
            }
            else if (this.gWBRadioButton.Checked == true)
            {
                url = "https://en.wikipedia.org/wiki/George_W._Bush";
                place = "https://people.rit.edu/dxsigm/GeorgeWBush.jpeg";
            }
            else if (this.bORadioButton.Checked == true)
            {
                url = "https://en.wikipedia.org/wiki/Barack_Obama";
                place = "https://people.rit.edu/dxsigm/BarackObama.png";
            }
            else if (this.jFKRadioButton.Checked == true)
            {
                url = "https://en.wikipedia.org/wiki/John_F._Kennedy";
                place = "https://people.rit.edu/dxsigm/JohnFKennedy.jpeg";
            }
            else if (this.wMRadioButton.Checked == true)
            {
                url = "https://en.wikipedia.org/wiki/William_McKinley";
                place = "https://people.rit.edu/dxsigm/WilliamMcKinley.jpeg";
            }
            else if (this.rRRadioButton.Checked == true)
            {
                url = "https://en.wikipedia.org/wiki/Ronald_Reagan";
                place = "https://people.rit.edu/dxsigm/RonaldReagan.jpeg";
            }
            else if (this.dDERadioButton.Checked == true)
            {
                url = "https://en.wikipedia.org/wiki/Dwight_D._Eisenhower";
                place = "https://people.rit.edu/dxsigm/DwightDEisenhower.jpeg";
            }
            else if (this.mVRadioButton.Checked == true)
            {
                url = "https://en.wikipedia.org/wiki/Martin_Van_Buren";
                place = "https://people.rit.edu/dxsigm/MartinVanBuren.jpeg";
            }
            else if (this.gWRadioButton.Checked == true)
            {
                url = "https://en.wikipedia.org/wiki/George_Washington";
                place = "https://people.rit.edu/dxsigm/GeorgeWashington.jpeg";
            }
            else if (this.jARadioButton.Checked == true)
            {
                url = "https://en.wikipedia.org/wiki/John_Adams";
                place = "https://people.rit.edu/dxsigm/JohnAdams.jpeg";
            }
            else if (this.tRRadioButton.Checked == true)
            {
                url = "https://en.wikipedia.org/wiki/Theodore_Roosevelt";
                place = "https://people.rit.edu/dxsigm/TheodoreRoosevelt.jpeg";
            }
            else if (this.tJRadioButton.Checked == true)
            {
                url = "https://en.wikipedia.org/wiki/Thomas_Jefferson";
                place = "https://people.rit.edu/dxsigm/ThomasJefferson.jpeg";
            }

            this.webBrowser.Navigate(url);
            this.groupBox.Text = url;
            this.pictureBox.ImageLocation = place;

        }

        private void FilterRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (this.allRadioButton.Checked == true)
            {
                this.bHRadioButton.Checked = true;

                this.bHRadioButton.Visible = true;
                this.fDRRadioButton.Visible = true;
                this.wJCRadioButton.Visible = true;
                this.jBRadioButton.Visible = true;
                this.fPRadioButton.Visible = true;
                this.gWBRadioButton.Visible = true;
                this.bORadioButton.Visible = true;
                this.jFKRadioButton.Visible = true;

                this.wMRadioButton.Visible = true;
                this.rRRadioButton.Visible = true;
                this.dDERadioButton.Visible = true;
                this.mVRadioButton.Visible = true;
                this.gWRadioButton.Visible = true;
                this.jARadioButton.Visible = true;
                this.tRRadioButton.Visible = true;
                this.tJRadioButton.Visible = true;

            }
            else if (this.demRadioButton.Checked == true)
            {
                this.fDRRadioButton.Checked = true;

                this.bHRadioButton.Visible = false;
                this.fDRRadioButton.Visible = true;
                this.wJCRadioButton.Visible = true;
                this.jBRadioButton.Visible = true;
                this.fPRadioButton.Visible = true;
                this.gWBRadioButton.Visible = false;
                this.bORadioButton.Visible = true;
                this.jFKRadioButton.Visible = true;

                this.wMRadioButton.Visible = false;
                this.rRRadioButton.Visible = false;
                this.dDERadioButton.Visible = false;
                this.mVRadioButton.Visible = true;
                this.gWRadioButton.Visible = false;
                this.jARadioButton.Visible = false;
                this.tRRadioButton.Visible = false;
                this.tJRadioButton.Visible = false;
            }
            else if (this.repRadioButton.Checked == true)
            {
                this.bHRadioButton.Checked = true;

                this.bHRadioButton.Visible = true;
                this.fDRRadioButton.Visible = false;
                this.wJCRadioButton.Visible = false;
                this.jBRadioButton.Visible = false;
                this.fPRadioButton.Visible = false;
                this.gWBRadioButton.Visible = true;
                this.bORadioButton.Visible = false;
                this.jFKRadioButton.Visible = false;

                this.wMRadioButton.Visible = true;
                this.rRRadioButton.Visible = true;
                this.dDERadioButton.Visible = true;
                this.mVRadioButton.Visible = false;
                this.gWRadioButton.Visible = false;
                this.jARadioButton.Visible = false;
                this.tRRadioButton.Visible = true;
                this.tJRadioButton.Visible = false;
            }
            else if (this.dRRadioButton.Checked == true)
            {
                this.tJRadioButton.Checked = true;

                this.bHRadioButton.Visible = false;
                this.fDRRadioButton.Visible = false;
                this.wJCRadioButton.Visible = false;
                this.jBRadioButton.Visible = false;
                this.fPRadioButton.Visible = false;
                this.gWBRadioButton.Visible = false;
                this.bORadioButton.Visible = false;
                this.jFKRadioButton.Visible = false;

                this.wMRadioButton.Visible = false;
                this.rRRadioButton.Visible = false;
                this.dDERadioButton.Visible = false;
                this.mVRadioButton.Visible = false;
                this.gWRadioButton.Visible = false;
                this.jARadioButton.Visible = false;
                this.tRRadioButton.Visible = false;
                this.tJRadioButton.Visible = true;
            }
            else if (this.fedRadioButton.Checked == true)
            {
                this.gWRadioButton.Checked = true;

                this.bHRadioButton.Visible = false;
                this.fDRRadioButton.Visible = false;
                this.wJCRadioButton.Visible = false;
                this.jBRadioButton.Visible = false;
                this.fPRadioButton.Visible = false;
                this.gWBRadioButton.Visible = false;
                this.bORadioButton.Visible = false;
                this.jFKRadioButton.Visible = false;

                this.wMRadioButton.Visible = false;
                this.rRRadioButton.Visible = false;
                this.dDERadioButton.Visible = false;
                this.mVRadioButton.Visible = false;
                this.gWRadioButton.Visible = true;
                this.jARadioButton.Visible = true;
                this.tRRadioButton.Visible = false;
                this.tJRadioButton.Visible = false;
            }
        }

    }
}