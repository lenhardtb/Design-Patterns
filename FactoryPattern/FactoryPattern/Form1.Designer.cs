namespace FactoryPattern
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
            this.previousDispenserPanel = new System.Windows.Forms.Panel();
            this.currentDispenserPanel = new System.Windows.Forms.Panel();
            this.leverButton = new System.Windows.Forms.Button();
            this.dispenseTimer = new System.Windows.Forms.Timer(this.components);
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.flavorProfileBox = new System.Windows.Forms.ListBox();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.amountLabel = new System.Windows.Forms.Label();
            this.nextDispenserPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // previousDispenserPanel
            // 
            this.previousDispenserPanel.Location = new System.Drawing.Point(12, 12);
            this.previousDispenserPanel.Name = "previousDispenserPanel";
            this.previousDispenserPanel.Size = new System.Drawing.Size(47, 100);
            this.previousDispenserPanel.TabIndex = 0;
            this.previousDispenserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.previousDispenserPanel_Paint);
            // 
            // currentDispenserPanel
            // 
            this.currentDispenserPanel.Location = new System.Drawing.Point(65, 12);
            this.currentDispenserPanel.Name = "currentDispenserPanel";
            this.currentDispenserPanel.Size = new System.Drawing.Size(155, 100);
            this.currentDispenserPanel.TabIndex = 2;
            this.currentDispenserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.currentDispenserPanel_Paint);
            // 
            // leverButton
            // 
            this.leverButton.Location = new System.Drawing.Point(108, 118);
            this.leverButton.Name = "leverButton";
            this.leverButton.Size = new System.Drawing.Size(75, 23);
            this.leverButton.TabIndex = 1;
            this.leverButton.Text = "Pull";
            this.leverButton.UseVisualStyleBackColor = true;
            this.leverButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.leverButton_MouseDown);
            this.leverButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.leverButton_MouseUp);
            // 
            // dispenseTimer
            // 
            this.dispenseTimer.Interval = 50;
            this.dispenseTimer.Tick += new System.EventHandler(this.FillCup);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(190, 118);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(30, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(65, 118);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(37, 23);
            this.previousButton.TabIndex = 3;
            this.previousButton.Text = "<";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // flavorProfileBox
            // 
            this.flavorProfileBox.Enabled = false;
            this.flavorProfileBox.FormattingEnabled = true;
            this.flavorProfileBox.Location = new System.Drawing.Point(194, 148);
            this.flavorProfileBox.Name = "flavorProfileBox";
            this.flavorProfileBox.Size = new System.Drawing.Size(82, 95);
            this.flavorProfileBox.TabIndex = 4;
            // 
            // colorPanel
            // 
            this.colorPanel.Location = new System.Drawing.Point(130, 194);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(54, 48);
            this.colorPanel.TabIndex = 5;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(133, 177);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(0, 13);
            this.amountLabel.TabIndex = 6;
            // 
            // nextDispenserPanel
            // 
            this.nextDispenserPanel.Location = new System.Drawing.Point(226, 12);
            this.nextDispenserPanel.Name = "nextDispenserPanel";
            this.nextDispenserPanel.Size = new System.Drawing.Size(52, 100);
            this.nextDispenserPanel.TabIndex = 1;
            this.nextDispenserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.nextDispenserPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 254);
            this.Controls.Add(this.nextDispenserPanel);
            this.Controls.Add(this.currentDispenserPanel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.previousDispenserPanel);
            this.Controls.Add(this.flavorProfileBox);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.leverButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel currentDispenserPanel;
        private System.Windows.Forms.Panel previousDispenserPanel;
        private System.Windows.Forms.Button leverButton;
        private System.Windows.Forms.Timer dispenseTimer;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.ListBox flavorProfileBox;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Panel nextDispenserPanel;
    }
}

