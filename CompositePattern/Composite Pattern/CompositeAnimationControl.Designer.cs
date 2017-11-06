namespace Composite_Pattern
{
    partial class CompositeAnimationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addItemsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toLocationTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fromLocationTextBox = new System.Windows.Forms.MaskedTextBox();
            this.translationBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.startNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.endNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.angleChangeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.initialAngleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rotationBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.subAnimationBox = new System.Windows.Forms.GroupBox();
            this.subAnimationPanel = new System.Windows.Forms.Panel();
            this.addItemsContextMenuStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleChangeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialAngleNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.subAnimationBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addItemsContextMenuStrip
            // 
            this.addItemsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem,
            this.addGroupToolStripMenuItem});
            this.addItemsContextMenuStrip.Name = "contextMenuStrip1";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(163, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Start                             End";
            // 
            // toLocationTextBox
            // 
            this.toLocationTextBox.Location = new System.Drawing.Point(121, 123);
            this.toLocationTextBox.Mask = "(9990, 9990)";
            this.toLocationTextBox.Name = "toLocationTextBox";
            this.toLocationTextBox.Size = new System.Drawing.Size(71, 20);
            this.toLocationTextBox.TabIndex = 9;
            this.toLocationTextBox.TextChanged += new System.EventHandler(this.toLocationTextBox_TextChanged);
            // 
            // fromLocationTextBox
            // 
            this.fromLocationTextBox.Location = new System.Drawing.Point(7, 123);
            this.fromLocationTextBox.Mask = "(9990, 9990)";
            this.fromLocationTextBox.Name = "fromLocationTextBox";
            this.fromLocationTextBox.Size = new System.Drawing.Size(71, 20);
            this.fromLocationTextBox.TabIndex = 8;
            this.fromLocationTextBox.TextChanged += new System.EventHandler(this.fromLocationTextBox_TextChanged);
            // 
            // translationBox
            // 
            this.translationBox.FormattingEnabled = true;
            this.translationBox.Items.AddRange(new object[] {
            "(none)",
            "Linear"});
            this.translationBox.Location = new System.Drawing.Point(6, 76);
            this.translationBox.Name = "translationBox";
            this.translationBox.Size = new System.Drawing.Size(74, 21);
            this.translationBox.TabIndex = 7;
            this.translationBox.SelectedIndexChanged += new System.EventHandler(this.translationBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Translation";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.startNumericUpDown);
            this.groupBox2.Controls.Add(this.endNumericUpDown);
            this.groupBox2.Location = new System.Drawing.Point(3, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 47);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Start/End";
            // 
            // startNumericUpDown
            // 
            this.startNumericUpDown.DecimalPlaces = 3;
            this.startNumericUpDown.Enabled = false;
            this.startNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.startNumericUpDown.Location = new System.Drawing.Point(6, 18);
            this.startNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.startNumericUpDown.Name = "startNumericUpDown";
            this.startNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.startNumericUpDown.TabIndex = 4;
            // 
            // endNumericUpDown
            // 
            this.endNumericUpDown.DecimalPlaces = 3;
            this.endNumericUpDown.Enabled = false;
            this.endNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.endNumericUpDown.Location = new System.Drawing.Point(95, 17);
            this.endNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.endNumericUpDown.Name = "endNumericUpDown";
            this.endNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.endNumericUpDown.TabIndex = 5;
            // 
            // angleChangeNumericUpDown
            // 
            this.angleChangeNumericUpDown.Location = new System.Drawing.Point(139, 31);
            this.angleChangeNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.angleChangeNumericUpDown.Name = "angleChangeNumericUpDown";
            this.angleChangeNumericUpDown.Size = new System.Drawing.Size(57, 20);
            this.angleChangeNumericUpDown.TabIndex = 5;
            this.angleChangeNumericUpDown.ValueChanged += new System.EventHandler(this.angleChangeNumericUpDown_ValueChanged);
            // 
            // initialAngleNumericUpDown
            // 
            this.initialAngleNumericUpDown.Location = new System.Drawing.Point(87, 32);
            this.initialAngleNumericUpDown.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.initialAngleNumericUpDown.Name = "initialAngleNumericUpDown";
            this.initialAngleNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.initialAngleNumericUpDown.TabIndex = 4;
            this.initialAngleNumericUpDown.ValueChanged += new System.EventHandler(this.initialAngleNumericUpDown_ValueChanged);
            // 
            // rotationBox
            // 
            this.rotationBox.FormattingEnabled = true;
            this.rotationBox.Items.AddRange(new object[] {
            "(none)",
            "Linear"});
            this.rotationBox.Location = new System.Drawing.Point(6, 32);
            this.rotationBox.Name = "rotationBox";
            this.rotationBox.Size = new System.Drawing.Size(74, 21);
            this.rotationBox.TabIndex = 3;
            this.rotationBox.SelectedIndexChanged += new System.EventHandler(this.rotationBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.toLocationTextBox);
            this.groupBox1.Controls.Add(this.fromLocationTextBox);
            this.groupBox1.Controls.Add(this.translationBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.angleChangeNumericUpDown);
            this.groupBox1.Controls.Add(this.initialAngleNumericUpDown);
            this.groupBox1.Controls.Add(this.rotationBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 151);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transformations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rotation             Start          Change";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Location = new System.Drawing.Point(25, -1);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(199, 20);
            this.nameBox.TabIndex = 10;
            this.nameBox.Visible = false;
            this.nameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameBox_KeyDown);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_LeaveFocus);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.Location = new System.Drawing.Point(25, 3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(205, 16);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Group";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.visibleBox_Click);
            // 
            // subAnimationBox
            // 
            this.subAnimationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subAnimationBox.Controls.Add(this.subAnimationPanel);
            this.subAnimationBox.Location = new System.Drawing.Point(9, 236);
            this.subAnimationBox.Name = "subAnimationBox";
            this.subAnimationBox.Size = new System.Drawing.Size(221, 210);
            this.subAnimationBox.TabIndex = 13;
            this.subAnimationBox.TabStop = false;
            this.subAnimationBox.Text = "Animations";
            // 
            // subAnimationPanel
            // 
            this.subAnimationPanel.AutoScroll = true;
            this.subAnimationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subAnimationPanel.Location = new System.Drawing.Point(3, 16);
            this.subAnimationPanel.Name = "subAnimationPanel";
            this.subAnimationPanel.Size = new System.Drawing.Size(215, 191);
            this.subAnimationPanel.TabIndex = 0;
            this.subAnimationPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.subAnimationPanel_ControlAddedOrRemoved);
            this.subAnimationPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.subAnimationPanel_ControlAddedOrRemoved);
            this.subAnimationPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.subAnimationPanel_MouseDown);
            // 
            // CompositeAnimationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.subAnimationBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.checkBox1);
            this.Name = "CompositeAnimationControl";
            this.Size = new System.Drawing.Size(233, 449);
            this.addItemsContextMenuStrip.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleChangeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialAngleNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.subAnimationBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip addItemsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGroupToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox toLocationTextBox;
        private System.Windows.Forms.MaskedTextBox fromLocationTextBox;
        private System.Windows.Forms.ComboBox translationBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown startNumericUpDown;
        private System.Windows.Forms.NumericUpDown endNumericUpDown;
        private System.Windows.Forms.NumericUpDown angleChangeNumericUpDown;
        private System.Windows.Forms.NumericUpDown initialAngleNumericUpDown;
        private System.Windows.Forms.ComboBox rotationBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox subAnimationBox;
        private System.Windows.Forms.Panel subAnimationPanel;
    }
}
