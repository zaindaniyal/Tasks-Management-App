namespace Tasks
{
    partial class TaskEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskEditor));
            this.DTPEndTimeInBrother = new System.Windows.Forms.DateTimePicker();
            this.DTPSetTimeInBrother = new System.Windows.Forms.DateTimePicker();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.DTPDeadlineInBrother = new System.Windows.Forms.DateTimePicker();
            this.DTPSetDateInBrother = new System.Windows.Forms.DateTimePicker();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.ComboBoxAssignedTo = new System.Windows.Forms.ComboBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtTaskListInBrother = new System.Windows.Forms.TextBox();
            this.ComboBoxTaskListInBrother = new System.Windows.Forms.ComboBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPriorityInBrother = new System.Windows.Forms.TextBox();
            this.lblPriorityInBrother = new System.Windows.Forms.Label();
            this.sliderPriority = new System.Windows.Forms.TrackBar();
            this.txtTaskListInBrother2 = new System.Windows.Forms.TextBox();
            this.txtTitleInBrother = new System.Windows.Forms.TextBox();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.txtTaskInBrother = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderPriority)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTPEndTimeInBrother
            // 
            this.DTPEndTimeInBrother.CustomFormat = "HH:mm";
            this.DTPEndTimeInBrother.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPEndTimeInBrother.Location = new System.Drawing.Point(236, 181);
            this.DTPEndTimeInBrother.Name = "DTPEndTimeInBrother";
            this.DTPEndTimeInBrother.ShowUpDown = true;
            this.DTPEndTimeInBrother.Size = new System.Drawing.Size(97, 20);
            this.DTPEndTimeInBrother.TabIndex = 36;
            // 
            // DTPSetTimeInBrother
            // 
            this.DTPSetTimeInBrother.CustomFormat = "HH:mm";
            this.DTPSetTimeInBrother.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPSetTimeInBrother.Location = new System.Drawing.Point(67, 181);
            this.DTPSetTimeInBrother.MaxDate = new System.DateTime(2020, 4, 19, 0, 0, 0, 0);
            this.DTPSetTimeInBrother.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DTPSetTimeInBrother.Name = "DTPSetTimeInBrother";
            this.DTPSetTimeInBrother.ShowUpDown = true;
            this.DTPSetTimeInBrother.Size = new System.Drawing.Size(96, 20);
            this.DTPSetTimeInBrother.TabIndex = 35;
            this.DTPSetTimeInBrother.Value = new System.DateTime(2012, 4, 19, 0, 0, 0, 0);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(169, 184);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(63, 15);
            this.Label9.TabIndex = 34;
            this.Label9.Text = "End Time:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(4, 183);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(59, 15);
            this.Label10.TabIndex = 33;
            this.Label10.Text = "Set Time:";
            // 
            // DTPDeadlineInBrother
            // 
            this.DTPDeadlineInBrother.CustomFormat = "dd/MM/yyyy";
            this.DTPDeadlineInBrother.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPDeadlineInBrother.Location = new System.Drawing.Point(236, 148);
            this.DTPDeadlineInBrother.Name = "DTPDeadlineInBrother";
            this.DTPDeadlineInBrother.Size = new System.Drawing.Size(97, 20);
            this.DTPDeadlineInBrother.TabIndex = 31;
            // 
            // DTPSetDateInBrother
            // 
            this.DTPSetDateInBrother.CustomFormat = "dd/MM/yyyy";
            this.DTPSetDateInBrother.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPSetDateInBrother.Location = new System.Drawing.Point(67, 148);
            this.DTPSetDateInBrother.MaxDate = new System.DateTime(2020, 4, 19, 0, 0, 0, 0);
            this.DTPSetDateInBrother.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DTPSetDateInBrother.Name = "DTPSetDateInBrother";
            this.DTPSetDateInBrother.Size = new System.Drawing.Size(96, 20);
            this.DTPSetDateInBrother.TabIndex = 30;
            this.DTPSetDateInBrother.Value = new System.DateTime(2012, 4, 19, 0, 0, 0, 0);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // ComboBoxAssignedTo
            // 
            this.ComboBoxAssignedTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAssignedTo.FormattingEnabled = true;
            this.ComboBoxAssignedTo.Location = new System.Drawing.Point(87, 22);
            this.ComboBoxAssignedTo.Name = "ComboBoxAssignedTo";
            this.ComboBoxAssignedTo.Size = new System.Drawing.Size(279, 21);
            this.ComboBoxAssignedTo.TabIndex = 26;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(4, 25);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(77, 15);
            this.Label8.TabIndex = 25;
            this.Label8.Text = "Assigned To:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(4, 213);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(36, 15);
            this.Label7.TabIndex = 24;
            this.Label7.Text = "Task:";
            // 
            // txtTaskListInBrother
            // 
            this.txtTaskListInBrother.Enabled = false;
            this.txtTaskListInBrother.Location = new System.Drawing.Point(570, 18);
            this.txtTaskListInBrother.MaxLength = 20;
            this.txtTaskListInBrother.Name = "txtTaskListInBrother";
            this.txtTaskListInBrother.Size = new System.Drawing.Size(39, 20);
            this.txtTaskListInBrother.TabIndex = 23;
            this.txtTaskListInBrother.Visible = false;
            // 
            // ComboBoxTaskListInBrother
            // 
            this.ComboBoxTaskListInBrother.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTaskListInBrother.FormattingEnabled = true;
            this.ComboBoxTaskListInBrother.Location = new System.Drawing.Point(87, 80);
            this.ComboBoxTaskListInBrother.Name = "ComboBoxTaskListInBrother";
            this.ComboBoxTaskListInBrother.Size = new System.Drawing.Size(279, 21);
            this.ComboBoxTaskListInBrother.TabIndex = 28;
            this.ComboBoxTaskListInBrother.TextChanged += new System.EventHandler(this.ComboBoxTaskListInBrother_TextChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.DTPEndTimeInBrother);
            this.GroupBox1.Controls.Add(this.txtPriorityInBrother);
            this.GroupBox1.Controls.Add(this.DTPSetTimeInBrother);
            this.GroupBox1.Controls.Add(this.txtTaskListInBrother);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.DTPDeadlineInBrother);
            this.GroupBox1.Controls.Add(this.DTPSetDateInBrother);
            this.GroupBox1.Controls.Add(this.ComboBoxAssignedTo);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.ComboBoxTaskListInBrother);
            this.GroupBox1.Controls.Add(this.lblPriorityInBrother);
            this.GroupBox1.Controls.Add(this.sliderPriority);
            this.GroupBox1.Controls.Add(this.txtTaskListInBrother2);
            this.GroupBox1.Controls.Add(this.txtTitleInBrother);
            this.GroupBox1.Controls.Add(this.lblTimeLeft);
            this.GroupBox1.Controls.Add(this.txtTaskInBrother);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(5, 27);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(639, 447);
            this.GroupBox1.TabIndex = 37;
            this.GroupBox1.TabStop = false;
            // 
            // txtPriorityInBrother
            // 
            this.txtPriorityInBrother.Location = new System.Drawing.Point(518, 19);
            this.txtPriorityInBrother.Name = "txtPriorityInBrother";
            this.txtPriorityInBrother.Size = new System.Drawing.Size(32, 20);
            this.txtPriorityInBrother.TabIndex = 21;
            this.txtPriorityInBrother.Visible = false;
            // 
            // lblPriorityInBrother
            // 
            this.lblPriorityInBrother.AutoSize = true;
            this.lblPriorityInBrother.BackColor = System.Drawing.Color.White;
            this.lblPriorityInBrother.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPriorityInBrother.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorityInBrother.Location = new System.Drawing.Point(344, 109);
            this.lblPriorityInBrother.Name = "lblPriorityInBrother";
            this.lblPriorityInBrother.Size = new System.Drawing.Size(22, 22);
            this.lblPriorityInBrother.TabIndex = 20;
            this.lblPriorityInBrother.Text = "E";
            // 
            // sliderPriority
            // 
            this.sliderPriority.Location = new System.Drawing.Point(78, 105);
            this.sliderPriority.Maximum = 100;
            this.sliderPriority.Name = "sliderPriority";
            this.sliderPriority.Size = new System.Drawing.Size(266, 45);
            this.sliderPriority.TabIndex = 29;
            this.sliderPriority.Scroll += new System.EventHandler(this.sliderPriority_Scroll);
            // 
            // txtTaskListInBrother2
            // 
            this.txtTaskListInBrother2.Enabled = false;
            this.txtTaskListInBrother2.Location = new System.Drawing.Point(222, 80);
            this.txtTaskListInBrother2.MaxLength = 20;
            this.txtTaskListInBrother2.Name = "txtTaskListInBrother2";
            this.txtTaskListInBrother2.Size = new System.Drawing.Size(144, 20);
            this.txtTaskListInBrother2.TabIndex = 7;
            this.txtTaskListInBrother2.TextChanged += new System.EventHandler(this.txtTaskListInBrother2_TextChanged);
            this.txtTaskListInBrother2.Validating += new System.ComponentModel.CancelEventHandler(this.txtTaskListInBrother2_Validating);
            // 
            // txtTitleInBrother
            // 
            this.txtTitleInBrother.Location = new System.Drawing.Point(87, 49);
            this.txtTitleInBrother.MaxLength = 255;
            this.txtTitleInBrother.Name = "txtTitleInBrother";
            this.txtTitleInBrother.Size = new System.Drawing.Size(279, 20);
            this.txtTitleInBrother.TabIndex = 27;
            this.txtTitleInBrother.Text = "I\'m a Title";
            this.txtTitleInBrother.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitleInBrother_Validating);
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.BackColor = System.Drawing.Color.White;
            this.lblTimeLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(406, 149);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(191, 17);
            this.lblTimeLeft.TabIndex = 12;
            this.lblTimeLeft.Text = "00 Hours 00 Minutes 00 Seconds";
            // 
            // txtTaskInBrother
            // 
            this.txtTaskInBrother.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskInBrother.Location = new System.Drawing.Point(7, 231);
            this.txtTaskInBrother.Multiline = true;
            this.txtTaskInBrother.Name = "txtTaskInBrother";
            this.txtTaskInBrother.Size = new System.Drawing.Size(627, 210);
            this.txtTaskInBrother.TabIndex = 32;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(341, 150);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(58, 15);
            this.Label6.TabIndex = 5;
            this.Label6.Text = "Time-left:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(169, 152);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(60, 15);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "Deadline:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(4, 150);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(57, 15);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Set Date:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(3, 112);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(47, 15);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Priority:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(4, 81);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(58, 15);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Task List:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(4, 50);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(33, 15);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Title:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // TaskEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(650, 491);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TaskEditor";
            this.Text = "New Task";
            this.Load += new System.EventHandler(this.TaskEditor_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderPriority)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DateTimePicker DTPEndTimeInBrother;
        internal System.Windows.Forms.DateTimePicker DTPSetTimeInBrother;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.DateTimePicker DTPDeadlineInBrother;
        internal System.Windows.Forms.DateTimePicker DTPSetDateInBrother;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.ComboBox ComboBoxAssignedTo;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtTaskListInBrother;
        internal System.Windows.Forms.ComboBox ComboBoxTaskListInBrother;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtPriorityInBrother;
        internal System.Windows.Forms.Label lblPriorityInBrother;
        internal System.Windows.Forms.TrackBar sliderPriority;
        internal System.Windows.Forms.TextBox txtTaskListInBrother2;
        internal System.Windows.Forms.TextBox txtTitleInBrother;
        internal System.Windows.Forms.Label lblTimeLeft;
        internal System.Windows.Forms.TextBox txtTaskInBrother;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}