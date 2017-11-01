using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Tasks
{    
    public partial class ContainerOfTaskViewer : UserControl
    {
        #region State Definition

        public string TaskListID;

        public ContainerOfTaskViewer()
        {          
            Load += ContainerOfTaskViewer_Load;
            InitializeComponent();
        }
        
        #endregion

        #region Behaviour Definition

        private void cmdDeleteTaskList_Click(object sender, EventArgs e)
        {
            DialogResult ObjectDialogResult = MessageBox.Show("Are you sure you want to delete this task list?",
                "Important Question", MessageBoxButtons.YesNo);
            if (ObjectDialogResult == DialogResult.Yes)
            {
                try
                {
                    string DeletingTaskString = "Delete from Task where ToDoList = '" + Label1.Text + "'";
                    OleDbCommand ObjectOleDbCommand = MainForm.ObjectOleDbConnection.CreateCommand();
                    ObjectOleDbCommand.CommandText = DeletingTaskString;
                    MainForm.ObjectOleDbConnection.Open();
                    ObjectOleDbCommand.ExecuteNonQuery();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    MainForm.ObjectOleDbConnection.Close();
                }
                MainForm.Instance.SignOutResembles();
                MainForm.Instance.RetrieveTasks();
                MainForm.Instance.TakeTasksFromDataBaseAndPutThemInTaskViewerAndContainerOfTaskViewer();
            }
        }

        private void ContainerOfTaskViewer_Load(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
