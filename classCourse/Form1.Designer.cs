namespace classCourse
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.majorLabel = new System.Windows.Forms.Label();
            this.immersionLabel = new System.Windows.Forms.Label();
            this.majorClassLabel = new System.Windows.Forms.Label();
            this.numberCredit = new System.Windows.Forms.Label();
            this.majorComboBox = new System.Windows.Forms.ComboBox();
            this.majorTextBox = new System.Windows.Forms.TextBox();
            this.immersionTextBox = new System.Windows.Forms.TextBox();
            this.minorClassLabel = new System.Windows.Forms.Label();
            this.classesLabel = new System.Windows.Forms.Label();
            this.minorComboBox = new System.Windows.Forms.ComboBox();
            this.creditTextBox = new System.Windows.Forms.TextBox();
            this.minorCheckBox = new System.Windows.Forms.CheckBox();
            this.minorLabel = new System.Windows.Forms.Label();
            this.minorTextBox = new System.Windows.Forms.TextBox();
            this.addClassLabel = new System.Windows.Forms.Label();
            this.newClassTextBox = new System.Windows.Forms.TextBox();
            this.newClassNameLabel = new System.Windows.Forms.Label();
            this.newClassCreditLabel = new System.Windows.Forms.Label();
            this.newClassCreditComboBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.newClassTypeComboBox = new System.Windows.Forms.ComboBox();
            this.extraClassLabel = new System.Windows.Forms.Label();
            this.extraClassComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.okButton);
            this.tabPage1.Controls.Add(this.extraClassComboBox);
            this.tabPage1.Controls.Add(this.extraClassLabel);
            this.tabPage1.Controls.Add(this.newClassTypeComboBox);
            this.tabPage1.Controls.Add(this.typeLabel);
            this.tabPage1.Controls.Add(this.newClassCreditComboBox);
            this.tabPage1.Controls.Add(this.newClassCreditLabel);
            this.tabPage1.Controls.Add(this.newClassNameLabel);
            this.tabPage1.Controls.Add(this.newClassTextBox);
            this.tabPage1.Controls.Add(this.addClassLabel);
            this.tabPage1.Controls.Add(this.minorTextBox);
            this.tabPage1.Controls.Add(this.minorLabel);
            this.tabPage1.Controls.Add(this.minorCheckBox);
            this.tabPage1.Controls.Add(this.creditTextBox);
            this.tabPage1.Controls.Add(this.minorComboBox);
            this.tabPage1.Controls.Add(this.classesLabel);
            this.tabPage1.Controls.Add(this.minorClassLabel);
            this.tabPage1.Controls.Add(this.immersionTextBox);
            this.tabPage1.Controls.Add(this.majorTextBox);
            this.tabPage1.Controls.Add(this.majorComboBox);
            this.tabPage1.Controls.Add(this.numberCredit);
            this.tabPage1.Controls.Add(this.majorClassLabel);
            this.tabPage1.Controls.Add(this.immersionLabel);
            this.tabPage1.Controls.Add(this.majorLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "classAdding";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "classPlan";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Location = new System.Drawing.Point(12, 7);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(33, 13);
            this.majorLabel.TabIndex = 0;
            this.majorLabel.Text = "Major";
            // 
            // immersionLabel
            // 
            this.immersionLabel.AutoSize = true;
            this.immersionLabel.Location = new System.Drawing.Point(12, 37);
            this.immersionLabel.Name = "immersionLabel";
            this.immersionLabel.Size = new System.Drawing.Size(54, 13);
            this.immersionLabel.TabIndex = 1;
            this.immersionLabel.Text = "Immersion";
            // 
            // majorClassLabel
            // 
            this.majorClassLabel.AutoSize = true;
            this.majorClassLabel.Location = new System.Drawing.Point(12, 250);
            this.majorClassLabel.Name = "majorClassLabel";
            this.majorClassLabel.Size = new System.Drawing.Size(132, 13);
            this.majorClassLabel.TabIndex = 2;
            this.majorClassLabel.Text = "Classes Required by Major";
            // 
            // numberCredit
            // 
            this.numberCredit.AutoSize = true;
            this.numberCredit.Location = new System.Drawing.Point(12, 65);
            this.numberCredit.Name = "numberCredit";
            this.numberCredit.Size = new System.Drawing.Size(91, 13);
            this.numberCredit.TabIndex = 3;
            this.numberCredit.Text = "Number of Credits";
            // 
            // majorComboBox
            // 
            this.majorComboBox.FormattingEnabled = true;
            this.majorComboBox.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22"});
            this.majorComboBox.Location = new System.Drawing.Point(149, 250);
            this.majorComboBox.Name = "majorComboBox";
            this.majorComboBox.Size = new System.Drawing.Size(121, 21);
            this.majorComboBox.TabIndex = 4;
            // 
            // majorTextBox
            // 
            this.majorTextBox.Location = new System.Drawing.Point(149, 7);
            this.majorTextBox.Name = "majorTextBox";
            this.majorTextBox.Size = new System.Drawing.Size(100, 20);
            this.majorTextBox.TabIndex = 6;
            // 
            // immersionTextBox
            // 
            this.immersionTextBox.Location = new System.Drawing.Point(149, 37);
            this.immersionTextBox.Name = "immersionTextBox";
            this.immersionTextBox.Size = new System.Drawing.Size(100, 20);
            this.immersionTextBox.TabIndex = 7;
            // 
            // minorClassLabel
            // 
            this.minorClassLabel.AutoSize = true;
            this.minorClassLabel.Location = new System.Drawing.Point(12, 287);
            this.minorClassLabel.Name = "minorClassLabel";
            this.minorClassLabel.Size = new System.Drawing.Size(72, 13);
            this.minorClassLabel.TabIndex = 12;
            this.minorClassLabel.Text = "Minor Classes";
            // 
            // classesLabel
            // 
            this.classesLabel.AutoSize = true;
            this.classesLabel.Location = new System.Drawing.Point(12, 208);
            this.classesLabel.Name = "classesLabel";
            this.classesLabel.Size = new System.Drawing.Size(179, 13);
            this.classesLabel.TabIndex = 13;
            this.classesLabel.Text = "Number of Classes for each Section:";
            // 
            // minorComboBox
            // 
            this.minorComboBox.FormattingEnabled = true;
            this.minorComboBox.Items.AddRange(new object[] {
            "5",
            "6"});
            this.minorComboBox.Location = new System.Drawing.Point(149, 287);
            this.minorComboBox.Name = "minorComboBox";
            this.minorComboBox.Size = new System.Drawing.Size(121, 21);
            this.minorComboBox.TabIndex = 14;
            // 
            // creditTextBox
            // 
            this.creditTextBox.Location = new System.Drawing.Point(149, 65);
            this.creditTextBox.Name = "creditTextBox";
            this.creditTextBox.Size = new System.Drawing.Size(100, 20);
            this.creditTextBox.TabIndex = 15;
            // 
            // minorCheckBox
            // 
            this.minorCheckBox.AutoSize = true;
            this.minorCheckBox.Location = new System.Drawing.Point(15, 105);
            this.minorCheckBox.Name = "minorCheckBox";
            this.minorCheckBox.Size = new System.Drawing.Size(96, 17);
            this.minorCheckBox.TabIndex = 17;
            this.minorCheckBox.Text = "Have a Minor?";
            this.minorCheckBox.UseVisualStyleBackColor = true;
            // 
            // minorLabel
            // 
            this.minorLabel.AutoSize = true;
            this.minorLabel.Location = new System.Drawing.Point(12, 145);
            this.minorLabel.Name = "minorLabel";
            this.minorLabel.Size = new System.Drawing.Size(33, 13);
            this.minorLabel.TabIndex = 18;
            this.minorLabel.Text = "Minor";
            // 
            // minorTextBox
            // 
            this.minorTextBox.Location = new System.Drawing.Point(149, 145);
            this.minorTextBox.Name = "minorTextBox";
            this.minorTextBox.Size = new System.Drawing.Size(100, 20);
            this.minorTextBox.TabIndex = 19;
            // 
            // addClassLabel
            // 
            this.addClassLabel.AutoSize = true;
            this.addClassLabel.Location = new System.Drawing.Point(451, 14);
            this.addClassLabel.Name = "addClassLabel";
            this.addClassLabel.Size = new System.Drawing.Size(105, 13);
            this.addClassLabel.TabIndex = 20;
            this.addClassLabel.Text = "Adding a New Class:";
            // 
            // newClassTextBox
            // 
            this.newClassTextBox.Location = new System.Drawing.Point(552, 57);
            this.newClassTextBox.Name = "newClassTextBox";
            this.newClassTextBox.Size = new System.Drawing.Size(100, 20);
            this.newClassTextBox.TabIndex = 21;
            // 
            // newClassNameLabel
            // 
            this.newClassNameLabel.AutoSize = true;
            this.newClassNameLabel.Location = new System.Drawing.Point(451, 57);
            this.newClassNameLabel.Name = "newClassNameLabel";
            this.newClassNameLabel.Size = new System.Drawing.Size(63, 13);
            this.newClassNameLabel.TabIndex = 22;
            this.newClassNameLabel.Text = "Class Name";
            // 
            // newClassCreditLabel
            // 
            this.newClassCreditLabel.AutoSize = true;
            this.newClassCreditLabel.Location = new System.Drawing.Point(451, 90);
            this.newClassCreditLabel.Name = "newClassCreditLabel";
            this.newClassCreditLabel.Size = new System.Drawing.Size(91, 13);
            this.newClassCreditLabel.TabIndex = 23;
            this.newClassCreditLabel.Text = "Number of Credits";
            // 
            // newClassCreditComboBox
            // 
            this.newClassCreditComboBox.FormattingEnabled = true;
            this.newClassCreditComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "3",
            "4"});
            this.newClassCreditComboBox.Location = new System.Drawing.Point(552, 90);
            this.newClassCreditComboBox.Name = "newClassCreditComboBox";
            this.newClassCreditComboBox.Size = new System.Drawing.Size(121, 21);
            this.newClassCreditComboBox.TabIndex = 24;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(451, 124);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(59, 13);
            this.typeLabel.TabIndex = 25;
            this.typeLabel.Text = "Class Type";
            // 
            // newClassTypeComboBox
            // 
            this.newClassTypeComboBox.FormattingEnabled = true;
            this.newClassTypeComboBox.Items.AddRange(new object[] {
            "Major",
            "Immersion",
            "Minor",
            "Gen Ed Elective",
            "Gen Ed Perspective",
            "Free Elective",
            "Advance Elective",
            "Wellness",
            "Co-op",
            "Other"});
            this.newClassTypeComboBox.Location = new System.Drawing.Point(552, 121);
            this.newClassTypeComboBox.Name = "newClassTypeComboBox";
            this.newClassTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.newClassTypeComboBox.TabIndex = 26;
            // 
            // extraClassLabel
            // 
            this.extraClassLabel.AutoSize = true;
            this.extraClassLabel.Location = new System.Drawing.Point(15, 325);
            this.extraClassLabel.Name = "extraClassLabel";
            this.extraClassLabel.Size = new System.Drawing.Size(101, 13);
            this.extraClassLabel.TabIndex = 27;
            this.extraClassLabel.Text = "Extra Free Electives";
            // 
            // extraClassComboBox
            // 
            this.extraClassComboBox.FormattingEnabled = true;
            this.extraClassComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.extraClassComboBox.Location = new System.Drawing.Point(149, 325);
            this.extraClassComboBox.Name = "extraClassComboBox";
            this.extraClassComboBox.Size = new System.Drawing.Size(121, 21);
            this.extraClassComboBox.TabIndex = 28;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(454, 380);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 29;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox minorComboBox;
        private System.Windows.Forms.Label classesLabel;
        private System.Windows.Forms.Label minorClassLabel;
        private System.Windows.Forms.TextBox immersionTextBox;
        private System.Windows.Forms.TextBox majorTextBox;
        private System.Windows.Forms.ComboBox majorComboBox;
        private System.Windows.Forms.Label numberCredit;
        private System.Windows.Forms.Label majorClassLabel;
        private System.Windows.Forms.Label immersionLabel;
        private System.Windows.Forms.Label majorLabel;
        private System.Windows.Forms.TextBox creditTextBox;
        private System.Windows.Forms.TextBox minorTextBox;
        private System.Windows.Forms.Label minorLabel;
        private System.Windows.Forms.CheckBox minorCheckBox;
        private System.Windows.Forms.ComboBox newClassTypeComboBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox newClassCreditComboBox;
        private System.Windows.Forms.Label newClassCreditLabel;
        private System.Windows.Forms.Label newClassNameLabel;
        private System.Windows.Forms.TextBox newClassTextBox;
        private System.Windows.Forms.Label addClassLabel;
        private System.Windows.Forms.ComboBox extraClassComboBox;
        private System.Windows.Forms.Label extraClassLabel;
        private System.Windows.Forms.Button okButton;
    }
}

