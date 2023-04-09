namespace ContactBook
{
    partial class MainForm
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
            this.allContactLabel = new System.Windows.Forms.Label();
            this.allContactBox = new System.Windows.Forms.ListBox();
            this.addContactButton = new System.Windows.Forms.Button();
            this.updateContactButton = new System.Windows.Forms.Button();
            this.searchContactButton = new System.Windows.Forms.Button();
            this.deleteContactButton = new System.Windows.Forms.Button();
            this.clearAllContactButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allContactLabel
            // 
            this.allContactLabel.AutoSize = true;
            this.allContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allContactLabel.Location = new System.Drawing.Point(12, 9);
            this.allContactLabel.Name = "allContactLabel";
            this.allContactLabel.Size = new System.Drawing.Size(89, 16);
            this.allContactLabel.TabIndex = 0;
            this.allContactLabel.Text = "All Contacts";
            // 
            // allContactBox
            // 
            this.allContactBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allContactBox.FormattingEnabled = true;
            this.allContactBox.ItemHeight = 30;
            this.allContactBox.Location = new System.Drawing.Point(12, 40);
            this.allContactBox.Name = "allContactBox";
            this.allContactBox.Size = new System.Drawing.Size(595, 334);
            this.allContactBox.TabIndex = 1;
            // 
            // addContactButton
            // 
            this.addContactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addContactButton.Location = new System.Drawing.Point(613, 40);
            this.addContactButton.Name = "addContactButton";
            this.addContactButton.Size = new System.Drawing.Size(157, 62);
            this.addContactButton.TabIndex = 2;
            this.addContactButton.Text = "Add Contact";
            this.addContactButton.UseVisualStyleBackColor = true;
            this.addContactButton.Click += new System.EventHandler(this.addContactButton_Click);
            // 
            // updateContactButton
            // 
            this.updateContactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateContactButton.Location = new System.Drawing.Point(613, 108);
            this.updateContactButton.Name = "updateContactButton";
            this.updateContactButton.Size = new System.Drawing.Size(157, 62);
            this.updateContactButton.TabIndex = 3;
            this.updateContactButton.Text = "Update Contact";
            this.updateContactButton.UseVisualStyleBackColor = true;
            this.updateContactButton.Click += new System.EventHandler(this.updateContactButton_Click);
            // 
            // searchContactButton
            // 
            this.searchContactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchContactButton.Location = new System.Drawing.Point(613, 176);
            this.searchContactButton.Name = "searchContactButton";
            this.searchContactButton.Size = new System.Drawing.Size(157, 62);
            this.searchContactButton.TabIndex = 4;
            this.searchContactButton.Text = "Search Contact";
            this.searchContactButton.UseVisualStyleBackColor = true;
            // 
            // deleteContactButton
            // 
            this.deleteContactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteContactButton.Location = new System.Drawing.Point(613, 244);
            this.deleteContactButton.Name = "deleteContactButton";
            this.deleteContactButton.Size = new System.Drawing.Size(157, 62);
            this.deleteContactButton.TabIndex = 5;
            this.deleteContactButton.Text = "Delete Contact";
            this.deleteContactButton.UseVisualStyleBackColor = true;
            // 
            // clearAllContactButton
            // 
            this.clearAllContactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAllContactButton.Location = new System.Drawing.Point(613, 312);
            this.clearAllContactButton.Name = "clearAllContactButton";
            this.clearAllContactButton.Size = new System.Drawing.Size(157, 62);
            this.clearAllContactButton.TabIndex = 6;
            this.clearAllContactButton.Text = " Clear All";
            this.clearAllContactButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 384);
            this.Controls.Add(this.clearAllContactButton);
            this.Controls.Add(this.deleteContactButton);
            this.Controls.Add(this.searchContactButton);
            this.Controls.Add(this.updateContactButton);
            this.Controls.Add(this.addContactButton);
            this.Controls.Add(this.allContactBox);
            this.Controls.Add(this.allContactLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Contact Book App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label allContactLabel;
        private System.Windows.Forms.ListBox allContactBox;
        private System.Windows.Forms.Button addContactButton;
        private System.Windows.Forms.Button updateContactButton;
        private System.Windows.Forms.Button searchContactButton;
        private System.Windows.Forms.Button deleteContactButton;
        private System.Windows.Forms.Button clearAllContactButton;
    }
}

