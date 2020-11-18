namespace Casale_UnitTest3_Hell
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
            this.components = new System.ComponentModel.Container();
            this.readyCheckBox = new System.Windows.Forms.CheckBox();
            this.niceButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // readyCheckBox
            // 
            this.readyCheckBox.AutoSize = true;
            this.readyCheckBox.Location = new System.Drawing.Point(106, 35);
            this.readyCheckBox.Name = "readyCheckBox";
            this.readyCheckBox.Size = new System.Drawing.Size(63, 17);
            this.readyCheckBox.TabIndex = 0;
            this.readyCheckBox.Text = "Ready?";
            this.readyCheckBox.UseVisualStyleBackColor = true;
            // 
            // niceButton
            // 
            this.niceButton.Location = new System.Drawing.Point(94, 133);
            this.niceButton.Name = "niceButton";
            this.niceButton.Size = new System.Drawing.Size(75, 23);
            this.niceButton.TabIndex = 1;
            this.niceButton.Text = "Nice";
            this.niceButton.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(40, 83);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(84, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Enter a Number:";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(147, 83);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 3;
            this.numberTextBox.Text = "0";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 237);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.niceButton);
            this.Controls.Add(this.readyCheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox readyCheckBox;
        private System.Windows.Forms.Button niceButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

