using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Drawing;
//using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tasks
{
    public partial class TaskViewer : UserControl
    {
        #region State Definition
        TaskEditor ObjectTaskEditorCallingFromTaskViewer;
        //a datetime control is declared.
        DateTime ObjectDateTime;
        //a timespan control is declared.
        TimeSpan ObjectTimeSpan;

        public string ActualTask;
        public string SetDate;
        public string DeadLine;
        public string TaskList;
        public string SetTime;
        public string EndTime;
        public string Priority;
        public string TaskID;
        
        public TaskViewer()
        {
            Load += TaskViewer_Load;
            InitializeComponent();
        }

        // This is a constructor
        public TaskViewer (TaskEditor caller)
        {
	        Click += task_Click;
	        InitializeComponent();
            ObjectTaskEditorCallingFromTaskViewer = caller;
        }

        //This is another constructor
        public TaskViewer(MainForm caller)
        {
            Click += task_Click;
            InitializeComponent();
            Parent = caller;
        }
        #endregion
        
        #region Behaviour Definition

        private void task_Click(object sender, System.EventArgs e)
        {
	        OpenTask();
        }

        private void txtTaskContainer_Click(object sender, EventArgs e)
        {
	        OpenTask();
        }

        private void txtPriority_Click(object sender, EventArgs e)
        {
	        OpenTask();
        }

        private void txtTimer_Click(object sender, EventArgs e)
        {
	        OpenTask();
        }

        private void OpenTask()
        {
            ObjectTaskEditorCallingFromTaskViewer = new TaskEditor(false);
            if (MainForm.UserIdentifier == true)
            {
                ObjectTaskEditorCallingFromTaskViewer.ComboBoxAssignedTo.Visible = false;
                ObjectTaskEditorCallingFromTaskViewer.Label8.Visible = false;
            }
            ObjectTaskEditorCallingFromTaskViewer.Show();
            ObjectTaskEditorCallingFromTaskViewer.txtTaskInBrother.Text = ActualTask;
            ObjectTaskEditorCallingFromTaskViewer.txtTaskListInBrother2.Text = TaskList;
            ObjectTaskEditorCallingFromTaskViewer.txtTitleInBrother.Text = txtTaskContainer.Text;
            ObjectTaskEditorCallingFromTaskViewer.DTPDeadlineInBrother.Text = DeadLine;
            ObjectTaskEditorCallingFromTaskViewer.lblPriorityInBrother.Text = Priority;
            ObjectTaskEditorCallingFromTaskViewer.DTPSetDateInBrother.Text = SetDate;
            ObjectTaskEditorCallingFromTaskViewer.DTPSetTimeInBrother.Text = SetTime;
            ObjectTaskEditorCallingFromTaskViewer.DTPEndTimeInBrother.Text = EndTime;
            ObjectTaskEditorCallingFromTaskViewer.TaskID = TaskID;
            ObjectTaskEditorCallingFromTaskViewer.sliderPriority.Value = Convert.ToInt32(Priority);
            ObjectTaskEditorCallingFromTaskViewer.sliderPriority.Visible = false;
            ObjectTaskEditorCallingFromTaskViewer.lblPriorityInBrother.Left = 87;
            ObjectTaskEditorCallingFromTaskViewer.ComboBoxTaskListInBrother.DropDownStyle = ComboBoxStyle.DropDown;
            ObjectTaskEditorCallingFromTaskViewer.ComboBoxTaskListInBrother.Text = TaskList;
            ObjectTaskEditorCallingFromTaskViewer.ComboBoxAssignedTo.DropDownStyle = ComboBoxStyle.DropDown;
            ObjectTaskEditorCallingFromTaskViewer.ComboBoxAssignedTo.Text = "Myself...";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ObjectDateTime = Convert.ToDateTime(DeadLine + " " + EndTime);
            ObjectTimeSpan = ObjectDateTime.Subtract(DateTime.Now);
            txtTimer.Text = ObjectTimeSpan.Days + " " + ObjectTimeSpan.Hours + ":" + ObjectTimeSpan.Minutes + ":" + ObjectTimeSpan.Seconds;
        }

        private void TaskViewer_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
