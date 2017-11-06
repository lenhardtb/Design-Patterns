namespace Composite_Pattern
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
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.snapshotPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.timeBar = new System.Windows.Forms.TrackBar();
            this.sideContainer = new System.Windows.Forms.SplitContainer();
            this.editPanel = new System.Windows.Forms.Panel();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.addItemsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filmLengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.framerateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.snapshotPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideContainer)).BeginInit();
            this.sideContainer.Panel1.SuspendLayout();
            this.sideContainer.Panel2.SuspendLayout();
            this.sideContainer.SuspendLayout();
            this.toolPanel.SuspendLayout();
            this.addItemsContextMenuStrip.SuspendLayout();
            this.settingsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmLengthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.framerateNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.viewPanel);
            this.mainContainer.Panel1.Controls.Add(this.snapshotPanel);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.sideContainer);
            this.mainContainer.Size = new System.Drawing.Size(672, 537);
            this.mainContainer.SplitterDistance = 481;
            this.mainContainer.TabIndex = 0;
            // 
            // viewPanel
            // 
            this.viewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewPanel.AutoScroll = true;
            this.viewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viewPanel.Location = new System.Drawing.Point(4, 4);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(474, 474);
            this.viewPanel.TabIndex = 1;
            this.viewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.viewPanel_Paint);
            // 
            // snapshotPanel
            // 
            this.snapshotPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.snapshotPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.snapshotPanel.Controls.Add(this.button1);
            this.snapshotPanel.Controls.Add(this.timeBar);
            this.snapshotPanel.Location = new System.Drawing.Point(4, 484);
            this.snapshotPanel.Name = "snapshotPanel";
            this.snapshotPanel.Size = new System.Drawing.Size(475, 50);
            this.snapshotPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timeBar
            // 
            this.timeBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeBar.Location = new System.Drawing.Point(121, 4);
            this.timeBar.Maximum = 3000;
            this.timeBar.Name = "timeBar";
            this.timeBar.Size = new System.Drawing.Size(349, 45);
            this.timeBar.TabIndex = 0;
            this.timeBar.TickFrequency = 300;
            this.timeBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.timeBar.ValueChanged += new System.EventHandler(this.timeBar_ValueChanged);
            // 
            // sideContainer
            // 
            this.sideContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideContainer.Location = new System.Drawing.Point(0, 0);
            this.sideContainer.Name = "sideContainer";
            this.sideContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sideContainer.Panel1
            // 
            this.sideContainer.Panel1.AllowDrop = true;
            this.sideContainer.Panel1.Controls.Add(this.editPanel);
            // 
            // sideContainer.Panel2
            // 
            this.sideContainer.Panel2.Controls.Add(this.toolPanel);
            this.sideContainer.Size = new System.Drawing.Size(187, 537);
            this.sideContainer.SplitterDistance = 395;
            this.sideContainer.TabIndex = 0;
            // 
            // editPanel
            // 
            this.editPanel.AutoScroll = true;
            this.editPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editPanel.Location = new System.Drawing.Point(0, 0);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(187, 395);
            this.editPanel.TabIndex = 0;
            this.editPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.editPanel_ControlAddedOrRemoved);
            this.editPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.editPanel_ControlAddedOrRemoved);
            // 
            // toolPanel
            // 
            this.toolPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolPanel.Controls.Add(this.settingsBox);
            this.toolPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolPanel.Location = new System.Drawing.Point(0, 0);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(187, 138);
            this.toolPanel.TabIndex = 0;
            // 
            // addItemsContextMenuStrip
            // 
            this.addItemsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem,
            this.addGroupToolStripMenuItem});
            this.addItemsContextMenuStrip.Name = "addItemsContextMenuStrip";
            this.addItemsContextMenuStrip.Size = new System.Drawing.Size(142, 48);
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.addItemToolStripMenuItem.Text = "Add Item...";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // addGroupToolStripMenuItem
            // 
            this.addGroupToolStripMenuItem.Name = "addGroupToolStripMenuItem";
            this.addGroupToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.addGroupToolStripMenuItem.Text = "Add Group...";
            this.addGroupToolStripMenuItem.Click += new System.EventHandler(this.addGroupToolStripMenuItem_Click);
            // 
            // settingsBox
            // 
            this.settingsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBox.Controls.Add(this.label4);
            this.settingsBox.Controls.Add(this.framerateNumericUpDown);
            this.settingsBox.Controls.Add(this.label3);
            this.settingsBox.Controls.Add(this.label2);
            this.settingsBox.Controls.Add(this.filmLengthNumericUpDown);
            this.settingsBox.Controls.Add(this.label1);
            this.settingsBox.Location = new System.Drawing.Point(4, 4);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(178, 126);
            this.settingsBox.TabIndex = 0;
            this.settingsBox.TabStop = false;
            this.settingsBox.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length";
            // 
            // filmLengthNumericUpDown
            // 
            this.filmLengthNumericUpDown.DecimalPlaces = 3;
            this.filmLengthNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.filmLengthNumericUpDown.Location = new System.Drawing.Point(10, 37);
            this.filmLengthNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.filmLengthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.filmLengthNumericUpDown.Name = "filmLengthNumericUpDown";
            this.filmLengthNumericUpDown.Size = new System.Drawing.Size(98, 20);
            this.filmLengthNumericUpDown.TabIndex = 1;
            this.filmLengthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.filmLengthNumericUpDown.ValueChanged += new System.EventHandler(this.filmLengthNumericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "s";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Framerate";
            // 
            // framerateNumericUpDown
            // 
            this.framerateNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.framerateNumericUpDown.Location = new System.Drawing.Point(10, 92);
            this.framerateNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.framerateNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.framerateNumericUpDown.Name = "framerateNumericUpDown";
            this.framerateNumericUpDown.Size = new System.Drawing.Size(98, 20);
            this.framerateNumericUpDown.TabIndex = 4;
            this.framerateNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.framerateNumericUpDown.ValueChanged += new System.EventHandler(this.framerateNumericUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "fps";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 537);
            this.Controls.Add(this.mainContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.snapshotPanel.ResumeLayout(false);
            this.snapshotPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeBar)).EndInit();
            this.sideContainer.Panel1.ResumeLayout(false);
            this.sideContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sideContainer)).EndInit();
            this.sideContainer.ResumeLayout(false);
            this.toolPanel.ResumeLayout(false);
            this.addItemsContextMenuStrip.ResumeLayout(false);
            this.settingsBox.ResumeLayout(false);
            this.settingsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmLengthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.framerateNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.Panel snapshotPanel;
        private System.Windows.Forms.SplitContainer sideContainer;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar timeBar;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.ContextMenuStrip addItemsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGroupToolStripMenuItem;
        private System.Windows.Forms.GroupBox settingsBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown framerateNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown filmLengthNumericUpDown;
        private System.Windows.Forms.Label label1;
    }
}

