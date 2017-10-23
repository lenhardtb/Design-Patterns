namespace Observer_Pattern
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
            this.playAreaPanel = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.button = new System.Windows.Forms.Button();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.mapmakerButton = new System.Windows.Forms.Button();
            this.backgroundColorButton = new System.Windows.Forms.Button();
            this.foregroundColorButton = new System.Windows.Forms.Button();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.foregroundColorDialog = new System.Windows.Forms.ColorDialog();
            this.backgroundColorDialog = new System.Windows.Forms.ColorDialog();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // playAreaPanel
            // 
            this.playAreaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playAreaPanel.AutoScroll = true;
            this.playAreaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playAreaPanel.Location = new System.Drawing.Point(13, 13);
            this.playAreaPanel.Name = "playAreaPanel";
            this.playAreaPanel.Size = new System.Drawing.Size(252, 188);
            this.playAreaPanel.TabIndex = 0;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.controlPanel.Controls.Add(this.button);
            this.controlPanel.Controls.Add(this.pointsLabel);
            this.controlPanel.Controls.Add(this.loadButton);
            this.controlPanel.Controls.Add(this.mapmakerButton);
            this.controlPanel.Controls.Add(this.backgroundColorButton);
            this.controlPanel.Controls.Add(this.foregroundColorButton);
            this.controlPanel.Location = new System.Drawing.Point(13, 210);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(252, 71);
            this.controlPanel.TabIndex = 1;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(4, 38);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 5;
            this.button.Text = "Start";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            this.button.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Location = new System.Drawing.Point(4, 4);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(13, 13);
            this.pointsLabel.TabIndex = 4;
            this.pointsLabel.Text = "0";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(105, 4);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(104, 28);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // mapmakerButton
            // 
            this.mapmakerButton.Location = new System.Drawing.Point(105, 38);
            this.mapmakerButton.Name = "mapmakerButton";
            this.mapmakerButton.Size = new System.Drawing.Size(104, 30);
            this.mapmakerButton.TabIndex = 2;
            this.mapmakerButton.Text = "Make your own!";
            this.mapmakerButton.UseVisualStyleBackColor = true;
            this.mapmakerButton.Click += new System.EventHandler(this.mapMakerButton_Click);
            // 
            // backgroundColorButton
            // 
            this.backgroundColorButton.Location = new System.Drawing.Point(215, 38);
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.Size = new System.Drawing.Size(34, 30);
            this.backgroundColorButton.TabIndex = 1;
            this.backgroundColorButton.UseVisualStyleBackColor = true;
            this.backgroundColorButton.Click += new System.EventHandler(this.backgroundColorButton_Click);
            // 
            // foregroundColorButton
            // 
            this.foregroundColorButton.Location = new System.Drawing.Point(215, 4);
            this.foregroundColorButton.Name = "foregroundColorButton";
            this.foregroundColorButton.Size = new System.Drawing.Size(34, 30);
            this.foregroundColorButton.TabIndex = 0;
            this.foregroundColorButton.UseVisualStyleBackColor = true;
            this.foregroundColorButton.Click += new System.EventHandler(this.foregroundColorButton_Click);
            // 
            // updateTimer
            // 
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 293);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.playAreaPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playAreaPanel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Button backgroundColorButton;
        private System.Windows.Forms.Button foregroundColorButton;
        private System.Windows.Forms.ColorDialog foregroundColorDialog;
        private System.Windows.Forms.ColorDialog backgroundColorDialog;
        private System.Windows.Forms.Button mapmakerButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Button button;
    }
}

