namespace Tasks
{
    partial class TaskViewer
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
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtTimer = new System.Windows.Forms.Label();
            this.txtPriority = new System.Windows.Forms.Label();
            this.txtTaskContainer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1;
            // 
            // txtTimer
            // 
            this.txtTimer.AutoSize = true;
            this.txtTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimer.Location = new System.Drawing.Point(143, 6);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(41, 15);
            this.txtTimer.TabIndex = 16;
            this.txtTimer.Text = "Label1";
            this.ToolTip1.SetToolTip(this.txtTimer, "Time left: Days Hours:Minutes:Seconds");
            // 
            // txtPriority
            // 
            this.txtPriority.AutoSize = true;
            this.txtPriority.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPriority.Location = new System.Drawing.Point(123, 6);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(17, 15);
            this.txtPriority.TabIndex = 15;
            this.txtPriority.Text = "D";
            this.ToolTip1.SetToolTip(this.txtPriority, "Priority Level");
            // 
            // txtTaskContainer
            // 
            this.txtTaskContainer.AutoSize = true;
            this.txtTaskContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaskContainer.Location = new System.Drawing.Point(7, 6);
            this.txtTaskContainer.Name = "txtTaskContainer";
            this.txtTaskContainer.Size = new System.Drawing.Size(21, 15);
            this.txtTaskContainer.TabIndex = 14;
            this.txtTaskContainer.Text = "he";
            this.ToolTip1.SetToolTip(this.txtTaskContainer, "Task Title");
            this.txtTaskContainer.Click += new System.EventHandler(this.txtTaskContainer_Click);
            // 
            // TaskViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.txtPriority);
            this.Controls.Add(this.txtTaskContainer);
            this.Name = "TaskViewer";
            this.Size = new System.Drawing.Size(213, 26);
            this.Load += new System.EventHandler(this.TaskViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.ToolTip ToolTip1;
        internal System.Windows.Forms.Label txtTimer;
        internal System.Windows.Forms.Label txtPriority;
        internal System.Windows.Forms.Label txtTaskContainer;

        public System.EventHandler Task_Load { get; set; }
    }
}
