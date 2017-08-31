namespace Singleton_Pattern
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
            this.entryBox = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newWindowButton = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // entryBox
            // 
            this.entryBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryBox.Location = new System.Drawing.Point(77, 9);
            this.entryBox.Name = "entryBox";
            this.entryBox.Size = new System.Drawing.Size(100, 29);
            this.entryBox.TabIndex = 0;
            this.entryBox.TextChanged += new System.EventHandler(this.entryBox_TextChanged);
            this.entryBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.entryBox_KeyPress);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.label);
            this.panel.Location = new System.Drawing.Point(17, 47);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(455, 252);
            this.panel.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.Window;
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 0;
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entry:";
            // 
            // newWindowButton
            // 
            this.newWindowButton.Location = new System.Drawing.Point(184, 9);
            this.newWindowButton.Name = "newWindowButton";
            this.newWindowButton.Size = new System.Drawing.Size(150, 29);
            this.newWindowButton.TabIndex = 3;
            this.newWindowButton.Text = "New Window";
            this.newWindowButton.UseVisualStyleBackColor = true;
            this.newWindowButton.Click += new System.EventHandler(this.newWindowButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.newWindowButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.entryBox);
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox entryBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newWindowButton;
    }
}

