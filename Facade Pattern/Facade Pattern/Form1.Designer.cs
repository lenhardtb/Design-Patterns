namespace Facade_Pattern
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
            this.tubFillPanel = new System.Windows.Forms.Panel();
            this.faucetBar = new System.Windows.Forms.TrackBar();
            this.lightsPanel = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roomLightsBar = new System.Windows.Forms.TrackBar();
            this.internalLightsBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.surfaceFrontJetButton = new System.Windows.Forms.Button();
            this.jetsPanel = new System.Windows.Forms.GroupBox();
            this.allJetsOffButton = new System.Windows.Forms.Button();
            this.surfaceBackJetButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bottomBackJetButton = new System.Windows.Forms.Button();
            this.bottomFrontJetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.JetsLabel1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.drainBar = new System.Windows.Forms.TrackBar();
            this.autoFillButton = new System.Windows.Forms.Button();
            this.autoDrainButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.faucetBar)).BeginInit();
            this.lightsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomLightsBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internalLightsBar)).BeginInit();
            this.jetsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drainBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tubFillPanel
            // 
            this.tubFillPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tubFillPanel.Location = new System.Drawing.Point(13, 13);
            this.tubFillPanel.Name = "tubFillPanel";
            this.tubFillPanel.Size = new System.Drawing.Size(259, 100);
            this.tubFillPanel.TabIndex = 0;
            this.tubFillPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tubFillPanel_Paint);
            // 
            // faucetBar
            // 
            this.faucetBar.Location = new System.Drawing.Point(278, 29);
            this.faucetBar.Maximum = 500;
            this.faucetBar.Name = "faucetBar";
            this.faucetBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.faucetBar.Size = new System.Drawing.Size(45, 84);
            this.faucetBar.SmallChange = 5;
            this.faucetBar.TabIndex = 3;
            this.faucetBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.faucetBar.Scroll += new System.EventHandler(this.faucetBar_Scroll);
            // 
            // lightsPanel
            // 
            this.lightsPanel.Controls.Add(this.label3);
            this.lightsPanel.Controls.Add(this.label2);
            this.lightsPanel.Controls.Add(this.roomLightsBar);
            this.lightsPanel.Controls.Add(this.internalLightsBar);
            this.lightsPanel.Location = new System.Drawing.Point(13, 120);
            this.lightsPanel.Name = "lightsPanel";
            this.lightsPanel.Size = new System.Drawing.Size(145, 178);
            this.lightsPanel.TabIndex = 4;
            this.lightsPanel.TabStop = false;
            this.lightsPanel.Text = "Lights";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Underwater";
            // 
            // roomLightsBar
            // 
            this.roomLightsBar.Location = new System.Drawing.Point(87, 32);
            this.roomLightsBar.Maximum = 100;
            this.roomLightsBar.Name = "roomLightsBar";
            this.roomLightsBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.roomLightsBar.Size = new System.Drawing.Size(45, 104);
            this.roomLightsBar.TabIndex = 3;
            this.roomLightsBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.roomLightsBar.Scroll += new System.EventHandler(this.roomLightsBar_Scroll);
            // 
            // internalLightsBar
            // 
            this.internalLightsBar.Location = new System.Drawing.Point(19, 32);
            this.internalLightsBar.Maximum = 100;
            this.internalLightsBar.Name = "internalLightsBar";
            this.internalLightsBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.internalLightsBar.Size = new System.Drawing.Size(45, 104);
            this.internalLightsBar.TabIndex = 0;
            this.internalLightsBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.internalLightsBar.Scroll += new System.EventHandler(this.internalLightsBar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Faucet";
            // 
            // surfaceFrontJetButton
            // 
            this.surfaceFrontJetButton.Location = new System.Drawing.Point(69, 57);
            this.surfaceFrontJetButton.Name = "surfaceFrontJetButton";
            this.surfaceFrontJetButton.Size = new System.Drawing.Size(37, 37);
            this.surfaceFrontJetButton.TabIndex = 6;
            this.surfaceFrontJetButton.Text = "On";
            this.surfaceFrontJetButton.UseVisualStyleBackColor = true;
            this.surfaceFrontJetButton.Click += new System.EventHandler(this.surfaceFrontJetButton_Click);
            // 
            // jetsPanel
            // 
            this.jetsPanel.Controls.Add(this.allJetsOffButton);
            this.jetsPanel.Controls.Add(this.surfaceBackJetButton);
            this.jetsPanel.Controls.Add(this.button3);
            this.jetsPanel.Controls.Add(this.bottomBackJetButton);
            this.jetsPanel.Controls.Add(this.bottomFrontJetButton);
            this.jetsPanel.Controls.Add(this.label1);
            this.jetsPanel.Controls.Add(this.surfaceFrontJetButton);
            this.jetsPanel.Controls.Add(this.JetsLabel1);
            this.jetsPanel.Location = new System.Drawing.Point(164, 120);
            this.jetsPanel.Name = "jetsPanel";
            this.jetsPanel.Size = new System.Drawing.Size(236, 178);
            this.jetsPanel.TabIndex = 7;
            this.jetsPanel.TabStop = false;
            this.jetsPanel.Text = "Jets";
            // 
            // allJetsOffButton
            // 
            this.allJetsOffButton.Location = new System.Drawing.Point(172, 100);
            this.allJetsOffButton.Name = "allJetsOffButton";
            this.allJetsOffButton.Size = new System.Drawing.Size(58, 37);
            this.allJetsOffButton.TabIndex = 13;
            this.allJetsOffButton.Text = "All Off";
            this.allJetsOffButton.UseVisualStyleBackColor = true;
            this.allJetsOffButton.Click += new System.EventHandler(this.allJetsOffButton_Click);
            // 
            // surfaceBackJetButton
            // 
            this.surfaceBackJetButton.Location = new System.Drawing.Point(112, 57);
            this.surfaceBackJetButton.Name = "surfaceBackJetButton";
            this.surfaceBackJetButton.Size = new System.Drawing.Size(37, 37);
            this.surfaceBackJetButton.TabIndex = 9;
            this.surfaceBackJetButton.Text = "On";
            this.surfaceBackJetButton.UseVisualStyleBackColor = true;
            this.surfaceBackJetButton.Click += new System.EventHandler(this.surfaceBackJetButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(172, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 37);
            this.button3.TabIndex = 12;
            this.button3.Text = "All On";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.allJetOnButton_Click);
            // 
            // bottomBackJetButton
            // 
            this.bottomBackJetButton.Location = new System.Drawing.Point(112, 100);
            this.bottomBackJetButton.Name = "bottomBackJetButton";
            this.bottomBackJetButton.Size = new System.Drawing.Size(37, 37);
            this.bottomBackJetButton.TabIndex = 8;
            this.bottomBackJetButton.Text = "On";
            this.bottomBackJetButton.UseVisualStyleBackColor = true;
            this.bottomBackJetButton.Click += new System.EventHandler(this.bottomBackJetButton_Click);
            // 
            // bottomFrontJetButton
            // 
            this.bottomFrontJetButton.Location = new System.Drawing.Point(69, 100);
            this.bottomFrontJetButton.Name = "bottomFrontJetButton";
            this.bottomFrontJetButton.Size = new System.Drawing.Size(37, 37);
            this.bottomFrontJetButton.TabIndex = 7;
            this.bottomFrontJetButton.Text = "On";
            this.bottomFrontJetButton.UseVisualStyleBackColor = true;
            this.bottomFrontJetButton.Click += new System.EventHandler(this.bottomFrontJetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Surface\r\n\r\n\r\nBottom";
            // 
            // JetsLabel1
            // 
            this.JetsLabel1.AutoSize = true;
            this.JetsLabel1.Location = new System.Drawing.Point(71, 19);
            this.JetsLabel1.Name = "JetsLabel1";
            this.JetsLabel1.Size = new System.Drawing.Size(77, 13);
            this.JetsLabel1.TabIndex = 0;
            this.JetsLabel1.Text = "Front       Back";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Drain";
            // 
            // drainBar
            // 
            this.drainBar.Location = new System.Drawing.Point(325, 29);
            this.drainBar.Maximum = 800;
            this.drainBar.Name = "drainBar";
            this.drainBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.drainBar.Size = new System.Drawing.Size(45, 84);
            this.drainBar.SmallChange = 5;
            this.drainBar.TabIndex = 9;
            this.drainBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.drainBar.Scroll += new System.EventHandler(this.drainBar_Scroll);
            // 
            // autoFillButton
            // 
            this.autoFillButton.Location = new System.Drawing.Point(377, 13);
            this.autoFillButton.Name = "autoFillButton";
            this.autoFillButton.Size = new System.Drawing.Size(75, 23);
            this.autoFillButton.TabIndex = 10;
            this.autoFillButton.Text = "Auto Fill";
            this.autoFillButton.UseVisualStyleBackColor = true;
            this.autoFillButton.Click += new System.EventHandler(this.autoFillButton_Click);
            // 
            // autoDrainButton
            // 
            this.autoDrainButton.Location = new System.Drawing.Point(377, 42);
            this.autoDrainButton.Name = "autoDrainButton";
            this.autoDrainButton.Size = new System.Drawing.Size(75, 23);
            this.autoDrainButton.TabIndex = 11;
            this.autoDrainButton.Text = "Auto Drain";
            this.autoDrainButton.UseVisualStyleBackColor = true;
            this.autoDrainButton.Click += new System.EventHandler(this.autoDrainButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(406, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 212);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Presets";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Basic";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(7, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Morning";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(7, 84);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Relax";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(88, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Full";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(88, 55);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Night";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 310);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.autoDrainButton);
            this.Controls.Add(this.autoFillButton);
            this.Controls.Add(this.drainBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.jetsPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lightsPanel);
            this.Controls.Add(this.faucetBar);
            this.Controls.Add(this.tubFillPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.faucetBar)).EndInit();
            this.lightsPanel.ResumeLayout(false);
            this.lightsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomLightsBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internalLightsBar)).EndInit();
            this.jetsPanel.ResumeLayout(false);
            this.jetsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drainBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel tubFillPanel;
        private System.Windows.Forms.TrackBar faucetBar;
        private System.Windows.Forms.GroupBox lightsPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar roomLightsBar;
        private System.Windows.Forms.TrackBar internalLightsBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button surfaceFrontJetButton;
        private System.Windows.Forms.GroupBox jetsPanel;
        private System.Windows.Forms.Label JetsLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button surfaceBackJetButton;
        private System.Windows.Forms.Button bottomBackJetButton;
        private System.Windows.Forms.Button bottomFrontJetButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar drainBar;
        private System.Windows.Forms.Button allJetsOffButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button autoFillButton;
        private System.Windows.Forms.Button autoDrainButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}

