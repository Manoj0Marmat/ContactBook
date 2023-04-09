namespace ContactBook
{
    partial class AddContactForm
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
            this.personNameAddLabel = new System.Windows.Forms.Label();
            this.personNameAddTextBox = new System.Windows.Forms.TextBox();
            this.personNumberAddTextBox = new System.Windows.Forms.TextBox();
            this.personNumberAddLabel = new System.Windows.Forms.Label();
            this.personEmailAddTextBox = new System.Windows.Forms.TextBox();
            this.personEmailAddLabel = new System.Windows.Forms.Label();
            this.personAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personNameAddLabel
            // 
            this.personNameAddLabel.AutoSize = true;
            this.personNameAddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personNameAddLabel.Location = new System.Drawing.Point(96, 88);
            this.personNameAddLabel.Name = "personNameAddLabel";
            this.personNameAddLabel.Size = new System.Drawing.Size(101, 16);
            this.personNameAddLabel.TabIndex = 0;
            this.personNameAddLabel.Text = "Person Name";
            // 
            // personNameAddTextBox
            // 
            this.personNameAddTextBox.Location = new System.Drawing.Point(216, 85);
            this.personNameAddTextBox.Name = "personNameAddTextBox";
            this.personNameAddTextBox.Size = new System.Drawing.Size(238, 22);
            this.personNameAddTextBox.TabIndex = 1;
            // 
            // personNumberAddTextBox
            // 
            this.personNumberAddTextBox.Location = new System.Drawing.Point(216, 123);
            this.personNumberAddTextBox.Name = "personNumberAddTextBox";
            this.personNumberAddTextBox.Size = new System.Drawing.Size(238, 22);
            this.personNumberAddTextBox.TabIndex = 3;
            // 
            // personNumberAddLabel
            // 
            this.personNumberAddLabel.AutoSize = true;
            this.personNumberAddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personNumberAddLabel.Location = new System.Drawing.Point(96, 126);
            this.personNumberAddLabel.Name = "personNumberAddLabel";
            this.personNumberAddLabel.Size = new System.Drawing.Size(114, 16);
            this.personNumberAddLabel.TabIndex = 2;
            this.personNumberAddLabel.Text = "Person Number";
            // 
            // personEmailAddTextBox
            // 
            this.personEmailAddTextBox.Location = new System.Drawing.Point(216, 163);
            this.personEmailAddTextBox.Name = "personEmailAddTextBox";
            this.personEmailAddTextBox.Size = new System.Drawing.Size(238, 22);
            this.personEmailAddTextBox.TabIndex = 5;
            // 
            // personEmailAddLabel
            // 
            this.personEmailAddLabel.AutoSize = true;
            this.personEmailAddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personEmailAddLabel.Location = new System.Drawing.Point(96, 166);
            this.personEmailAddLabel.Name = "personEmailAddLabel";
            this.personEmailAddLabel.Size = new System.Drawing.Size(99, 16);
            this.personEmailAddLabel.TabIndex = 4;
            this.personEmailAddLabel.Text = "Person Email";
            // 
            // personAddButton
            // 
            this.personAddButton.Location = new System.Drawing.Point(216, 205);
            this.personAddButton.Name = "personAddButton";
            this.personAddButton.Size = new System.Drawing.Size(75, 23);
            this.personAddButton.TabIndex = 6;
            this.personAddButton.Text = "Add";
            this.personAddButton.UseVisualStyleBackColor = true;
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 283);
            this.Controls.Add(this.personAddButton);
            this.Controls.Add(this.personEmailAddTextBox);
            this.Controls.Add(this.personEmailAddLabel);
            this.Controls.Add(this.personNumberAddTextBox);
            this.Controls.Add(this.personNumberAddLabel);
            this.Controls.Add(this.personNameAddTextBox);
            this.Controls.Add(this.personNameAddLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddContactForm";
            this.Text = "AddContactForm";
            this.Load += new System.EventHandler(this.AddContactForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label personNameAddLabel;
        private System.Windows.Forms.TextBox personNameAddTextBox;
        private System.Windows.Forms.TextBox personNumberAddTextBox;
        private System.Windows.Forms.Label personNumberAddLabel;
        private System.Windows.Forms.TextBox personEmailAddTextBox;
        private System.Windows.Forms.Label personEmailAddLabel;
        private System.Windows.Forms.Button personAddButton;
    }
}