namespace Iterator_Pattern
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addNameButton = new System.Windows.Forms.Button();
            this.removeNameButton = new System.Windows.Forms.Button();
            this.addNameBox = new System.Windows.Forms.TextBox();
            this.removeNameBox = new System.Windows.Forms.TextBox();
            this.refreshBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(118, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 160);
            this.listBox1.TabIndex = 0;
            // 
            // addNameButton
            // 
            this.addNameButton.Location = new System.Drawing.Point(12, 38);
            this.addNameButton.Name = "addNameButton";
            this.addNameButton.Size = new System.Drawing.Size(100, 23);
            this.addNameButton.TabIndex = 1;
            this.addNameButton.Text = "Add";
            this.addNameButton.UseVisualStyleBackColor = true;
            this.addNameButton.Click += new System.EventHandler(this.addNameButton_Click);
            // 
            // removeNameButton
            // 
            this.removeNameButton.Location = new System.Drawing.Point(12, 94);
            this.removeNameButton.Name = "removeNameButton";
            this.removeNameButton.Size = new System.Drawing.Size(100, 23);
            this.removeNameButton.TabIndex = 2;
            this.removeNameButton.Text = "Remove";
            this.removeNameButton.UseVisualStyleBackColor = true;
            this.removeNameButton.Click += new System.EventHandler(this.removeNameButton_Click);
            // 
            // addNameBox
            // 
            this.addNameBox.Location = new System.Drawing.Point(12, 12);
            this.addNameBox.Name = "addNameBox";
            this.addNameBox.Size = new System.Drawing.Size(100, 20);
            this.addNameBox.TabIndex = 3;
            // 
            // removeNameBox
            // 
            this.removeNameBox.Location = new System.Drawing.Point(13, 68);
            this.removeNameBox.Name = "removeNameBox";
            this.removeNameBox.Size = new System.Drawing.Size(99, 20);
            this.removeNameBox.TabIndex = 4;
            // 
            // refreshBox
            // 
            this.refreshBox.Location = new System.Drawing.Point(118, 170);
            this.refreshBox.Name = "refreshBox";
            this.refreshBox.Size = new System.Drawing.Size(120, 23);
            this.refreshBox.TabIndex = 5;
            this.refreshBox.Text = "Refresh";
            this.refreshBox.UseVisualStyleBackColor = true;
            this.refreshBox.Click += new System.EventHandler(this.refreshBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 215);
            this.Controls.Add(this.refreshBox);
            this.Controls.Add(this.removeNameBox);
            this.Controls.Add(this.addNameBox);
            this.Controls.Add(this.removeNameButton);
            this.Controls.Add(this.addNameButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addNameButton;
        private System.Windows.Forms.Button removeNameButton;
        private System.Windows.Forms.TextBox addNameBox;
        private System.Windows.Forms.TextBox removeNameBox;
        private System.Windows.Forms.Button refreshBox;
    }
}

