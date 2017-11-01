using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;

namespace Tasks
{
    public partial class TaskEditor : Form
    {
        #region State Definition
        bool IsThisANewRecord;
        DateTime ObjectDateTime = new DateTime();
        TimeSpan ObjectTimeSpan = new TimeSpan();
        public string TaskID;                   
        public TaskEditor(bool isThisANewRecord)
        {
            Load += TaskEditor_Load;
            InitializeComponent();
            IsThisANewRecord = isThisANewRecord;
        }

        #endregion

        #region Behaviour Definition

        private void TaskEditor_Load(object sender, System.EventArgs e) 
        {
            DTPDeadlineInBrother.CustomFormat = "dd/MM/yyyy";
            DTPSetDateInBrother.CustomFormat = "dd/MM/yyyy";
            DTPSetTimeInBrother.CustomFormat = "HH:mm";
            DTPEndTimeInBrother.CustomFormat = "HH:mm";
            txtPriorityInBrother.Text = "1";
            DTPSetDateInBrother.Text = Convert.ToString(DateTime.Now.Date);
            DTPSetTimeInBrother.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute;
        }

        private void MakeTextboxesEditable()
        {
            DTPDeadlineInBrother.Enabled = true;
            DTPSetDateInBrother.Enabled = true;
            DTPSetTimeInBrother.Enabled = true;
            DTPEndTimeInBrother.Enabled = true;
            txtTaskInBrother.ReadOnly = false;
            txtTaskListInBrother2.ReadOnly = false;
            txtTitleInBrother.ReadOnly = false;
            ComboBoxAssignedTo.Enabled = true;
        }

        private void EmptyTextBoxes()
        {
            ComboBoxAssignedTo.Text = "";
            ComboBoxTaskListInBrother.Text = "";
            sliderPriority.Value = 0;
            txtTaskListInBrother2.Clear();
            lblPriorityInBrother.Text = "";
            txtTaskInBrother.Clear();
            txtTitleInBrother.Clear();
            lblTimeLeft.Text = "";
            txtTaskListInBrother.Clear();
        }

        private void UpdateTasks()
        {
            try
            {
                string sqlString = "UPDATE Task SET Priority = " + txtPriorityInBrother.Text +
                    ", SetDate = '" + DTPSetDateInBrother.Text +
                    "', DeadLine = '" + DTPDeadlineInBrother.Text +
                    "', Subject = '" + txtTitleInBrother.Text +
                    "', Task = '" + txtTaskInBrother.Text +
                    "', ToDoList = '" + txtTaskListInBrother.Text +
                    "', SetTime = '" + DTPSetTimeInBrother.Text +
                    "', EndTime = '" + DTPEndTimeInBrother.Text +
                    "' WHERE TaskID = " + TaskID + "AND UserID = " + MainForm.UserID;
                MessageBox.Show(sqlString);
                OleDbCommand ObjectOleDbCommand = MainForm.ObjectOleDbConnection.CreateCommand();
                ObjectOleDbCommand.CommandText = sqlString;
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
        }

        private void sliderPriority_Scroll(object sender, EventArgs e)
        {
            txtPriorityInBrother.Text = Convert.ToString(sliderPriority.Value);
            lblPriorityInBrother.Text = Convert.ToString(sliderPriority.Value);
            if (Convert.ToInt32(lblPriorityInBrother.Text) >= 80)
            {
                lblPriorityInBrother.Text = "A";
            }
            else if (Convert.ToInt32(lblPriorityInBrother.Text) >= 60)
            {
                lblPriorityInBrother.Text = "B";
            }
            else if (Convert.ToInt32(lblPriorityInBrother.Text) >= 40)
            {
                lblPriorityInBrother.Text = "C";
            }
            else if (Convert.ToInt32(lblPriorityInBrother.Text) >= 20)
            {
                lblPriorityInBrother.Text = "D";
            }
            else
            {
                lblPriorityInBrother.Text = "E";
            }
        }

        private void ComboBoxTaskListInBrother_TextChanged(object sender, EventArgs e)
        {            
            if (ComboBoxTaskListInBrother.Text != "")
            {
                if (ComboBoxTaskListInBrother.Text == "New...")
                {
                    txtTaskListInBrother.Text = txtTaskListInBrother2.Text;
                    txtTaskListInBrother2.Enabled = true;
                    ComboBoxTaskListInBrother.Width = 127;
                }
                else
                {
                    txtTaskListInBrother2.Enabled = false;
                    ComboBoxTaskListInBrother.Width = 279;
                }
            }
            txtTaskListInBrother.Text = ComboBoxTaskListInBrother.Text;
        }

        private void txtTaskListInBrother2_TextChanged(object sender, EventArgs e)
        {
            txtTaskListInBrother.Text = txtTaskListInBrother2.Text;
        }

        private void DTPSetDateInBrother_TextChanged(object sender, System.EventArgs e)
        {
            if (IsThisANewRecord == true)
            {
                DTPDeadlineInBrother.MinDate = Convert.ToDateTime(DTPSetDateInBrother.Text);
            }
        }

        private void ComboBoxAssignedTo_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            CalculateDateDifference();
        }

        private void CalculateDateDifference()
        {
            ObjectDateTime = DateTime.Parse(DTPDeadlineInBrother.Text + " " + DTPEndTimeInBrother.Text);
            ObjectTimeSpan = ObjectDateTime.Subtract(DateTime.Now);
            lblTimeLeft.Text = ObjectTimeSpan.Days + " Days " + ObjectTimeSpan.Hours + " Hours " + ObjectTimeSpan.Minutes + " Minutes ";
            if (ObjectTimeSpan.Days <= 0)
            {
                lblTimeLeft.BackColor = Color.Red;
            }
            else
            {
                lblTimeLeft.BackColor = Color.WhiteSmoke;
            }
        }

        private void DTPEndTimeInBrother_TextChanged(object sender, EventArgs e)
        {
            CalculateDateDifference();
        }
        
        private void DTPDeadlineInBrother_TextChanged(object sender, EventArgs e)
        {
            CalculateDateDifference();
        }

        public void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtTaskListInBrother.Text == string.Empty |
                    txtTaskInBrother.Text == string.Empty |
                    txtTitleInBrother.Text == string.Empty |
                    txtTaskListInBrother.Text == "New...")
            {
                MessageBox.Show("Please fill all the textboxes.");
            }
            else
            {
                if (IsThisANewRecord == true)
                {
                    string str1 = null;

                    if (MainForm.UserIdentifier == true)
                    {
                        ComboBoxAssignedTo.Text = "Myself...";
                    }

                    if (ComboBoxAssignedTo.Text == "Myself...")
                    {
                        str1 = MainForm.UserID;
                    }
                    else
                    {
                        for (int d = 0; d <= MainForm.UsersDataTable.Rows.Count - 1; d++)
                        {
                            if ((string)MainForm.UsersDataTable.Rows[d][0] == ComboBoxAssignedTo.Text)
                            {
                                str1 = Convert.ToString(MainForm.UsersDataTable.Rows[d][3]);
                            }
                        }
                    }
                    try
                    {
                        string sqlStringAddingTasks = "Insert into Task values(" + TaskID + "," +
                            MainForm.UserID + "," +
                            txtPriorityInBrother.Text + ",'" +
                            DTPSetDateInBrother.Text + "','" +
                            DTPDeadlineInBrother.Text + "','" +
                            txtTitleInBrother.Text + "','" +
                            txtTaskInBrother.Text + "','" +
                            txtTaskListInBrother.Text + "','" +
                            DTPSetTimeInBrother.Text + "','" +
                            DTPEndTimeInBrother.Text + "')";                        
                        OleDbCommand ObjectOleDbCommand = MainForm.ObjectOleDbConnection.CreateCommand();
                        ObjectOleDbCommand.CommandText = sqlStringAddingTasks;
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
                    this.Close();
                    MainForm.Instance.SignOutResembles();
                    MainForm.Instance.RetrieveTasks();
                    MainForm.Instance.TakeTasksFromDataBaseAndPutThemInTaskViewerAndContainerOfTaskViewer();
                }
                else
                {
                    UpdateTasks();
                    this.Close();
                    MainForm.Instance.SignOutResembles();
                    MainForm.Instance.RetrieveTasks();
                    MainForm.Instance.TakeTasksFromDataBaseAndPutThemInTaskViewerAndContainerOfTaskViewer();
                }
            }
        }

        private void txtTitleInBrother_Validating(object sender, CancelEventArgs e)
        {
            txtTitleInBrother.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtTitleInBrother.Text);
        }

        private void txtTaskListInBrother2_Validating(object sender, CancelEventArgs e)
        {
            txtTaskListInBrother2.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtTaskListInBrother2.Text);
        }

        #endregion

    }
}

