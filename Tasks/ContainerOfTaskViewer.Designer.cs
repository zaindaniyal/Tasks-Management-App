namespace Tasks
{
    partial class ContainerOfTaskViewer
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
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdDeleteTaskList = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // cmdDeleteTaskList
            // 
            this.cmdDeleteTaskList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdDeleteTaskList.FlatAppearance.BorderSize = 0;
            this.cmdDeleteTaskList.Location = new System.Drawing.Point(184, 9);
            this.cmdDeleteTaskList.Name = "cmdDeleteTaskList";
            this.cmdDeleteTaskList.Size = new System.Drawing.Size(27, 23);
            this.cmdDeleteTaskList.TabIndex = 5;
            this.cmdDeleteTaskList.Tag = "";
            this.cmdDeleteTaskList.Text = "x";
            this.ToolTip1.SetToolTip(this.cmdDeleteTaskList, "Click here to delete the task list");
            this.cmdDeleteTaskList.UseVisualStyleBackColor = false;
            this.cmdDeleteTaskList.Click += new System.EventHandler(this.cmdDeleteTaskList_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(3, -1);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(144, 36);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Business";
            this.ToolTip1.SetToolTip(this.Label1, "Name of Tasklist");
            // 
            // FlowLayoutPanel1
            // 
            this.FlowLayoutPanel1.AutoScroll = true;
            this.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(-1, 38);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(220, 161);
            this.FlowLayoutPanel1.TabIndex = 3;
            this.FlowLayoutPanel1.WrapContents = false;
            // 
            // ContainerOfTaskViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.cmdDeleteTaskList);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.FlowLayoutPanel1);
            this.Name = "ContainerOfTaskViewer";
            this.Size = new System.Drawing.Size(218, 198);
            this.Load += new System.EventHandler(this.ContainerOfTaskViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolTip ToolTip1;
        internal System.Windows.Forms.Button cmdDeleteTaskList;
        internal System.Windows.Forms.Label Label1;
        public System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel1;

        public System.EventHandler Tasklist_Load { get; set; }
    }
}
