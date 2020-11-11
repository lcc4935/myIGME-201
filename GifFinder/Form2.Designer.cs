namespace GifFinder
{
    partial class SearchForm
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
            this.searchTermTextBox = new System.Windows.Forms.TextBox();
            this.maxItemsTextBox = new System.Windows.Forms.TextBox();
            this.searchTermLabel = new System.Windows.Forms.Label();
            this.maxItemsLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchTermTextBox
            // 
            this.searchTermTextBox.Location = new System.Drawing.Point(100, 18);
            this.searchTermTextBox.Name = "searchTermTextBox";
            this.searchTermTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTermTextBox.TabIndex = 0;
            // 
            // maxItemsTextBox
            // 
            this.maxItemsTextBox.Location = new System.Drawing.Point(100, 44);
            this.maxItemsTextBox.Name = "maxItemsTextBox";
            this.maxItemsTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxItemsTextBox.TabIndex = 1;
            // 
            // searchTermLabel
            // 
            this.searchTermLabel.AutoSize = true;
            this.searchTermLabel.Location = new System.Drawing.Point(23, 25);
            this.searchTermLabel.Name = "searchTermLabel";
            this.searchTermLabel.Size = new System.Drawing.Size(67, 13);
            this.searchTermLabel.TabIndex = 2;
            this.searchTermLabel.Text = "Search Item:";
            // 
            // maxItemsLabel
            // 
            this.maxItemsLabel.AutoSize = true;
            this.maxItemsLabel.Location = new System.Drawing.Point(23, 51);
            this.maxItemsLabel.Name = "maxItemsLabel";
            this.maxItemsLabel.Size = new System.Drawing.Size(58, 13);
            this.maxItemsLabel.TabIndex = 3;
            this.maxItemsLabel.Text = "Max Items:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(19, 88);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(100, 88);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(225, 139);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.maxItemsLabel);
            this.Controls.Add(this.searchTermLabel);
            this.Controls.Add(this.maxItemsTextBox);
            this.Controls.Add(this.searchTermTextBox);
            this.Name = "SearchForm";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTermTextBox;
        private System.Windows.Forms.TextBox maxItemsTextBox;
        private System.Windows.Forms.Label searchTermLabel;
        private System.Windows.Forms.Label maxItemsLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}