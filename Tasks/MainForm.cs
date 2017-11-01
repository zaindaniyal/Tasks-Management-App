using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;
using System.Collections.Generic;
using System.Windows.Input;


namespace Tasks
{
    public partial class MainForm : Form
    {
        #region State Definition

        public static OleDbConnection ObjectOleDbConnection = new OleDbConnection("Provider=Microsoft.JET.OlEDB.4.0;Data Source=TasksDatabase.mdb;");
        public static OleDbCommand ObjectOleDbCommand;
        public static OleDbDataAdapter ObjectOleDbDataAdapter;
        public static DataTable TasksDataTable = new DataTable();
        public static DataTable UsersDataTable = new DataTable();
        TimeSpan ObjectTimeSpan = new TimeSpan();
        TaskEditor ObjectTaskEditor;
        const int OptimalXViewingPosition = 12;
        const int UnOptimaXlViewingPosition = 1160;
        const int OptimalYViewingPosition = 27;
        const int UnOptimalYViewingPosition = 1160;
        int GBoxNumber;
        public static bool UserIdentifier;
        public static string UserID;
        public static ListBox LstTaskBox = new ListBox();
        public static FlowLayoutPanel FloLayTaskListContainer = new FlowLayoutPanel();
        DataGridViewColumn NewColumn = new DataGridViewColumn();
        DataGridViewCell cell = new DataGridViewTextBoxCell();
        GregorianCalendar gc = new GregorianCalendar();
        public static MainForm Instance = null;
        public MainForm()
        {
            InitializeComponent();
            Instance = this;
        }

        #endregion

        #region Behaviour Definition

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(761, 588);
            MainPanel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            MainPanel.BackColor = Color.Aquamarine;
            HabitsGBox.Left = UnOptimaXlViewingPosition;
            HabitsGBox.Top = UnOptimalYViewingPosition;
            RetrieveUserInformation();
            int c = 0;

            for (int f = 0; f <= UsersDataTable.Rows.Count - 1; f++)
            {
                c++;
            }
            if (c == 0)
            {
                GBoxNumber = 3;
                RefreshInterface(3);
            }
            else if (c == 1 & Convert.ToString(UsersDataTable.Rows[0][4]) == "True")
            {
                GBoxNumber = 4;
                RefreshInterface(4);
                label3.Visible = true;
                label3.Left = 310;
                label3.Text = Convert.ToString(UsersDataTable.Rows[0][0]);
                txtNameSingleUser.Visible = false;
                Label12.Text = "Passcode:";
                UserIdentifier = true;
            }
            else
            {
                GBoxNumber = 1;
                RefreshInterface(1);
            }
            FloLayTaskListContainer.Name = "FloLayTaskListContainer";
            FloLayTaskListContainer.Size = new System.Drawing.Size(709, 238);
            FloLayTaskListContainer.TabIndex = 805;
            FloLayTaskListContainer.WrapContents = false;
            FloLayTaskListContainer.AutoScroll = true;
            TasksFLPanel.Controls.Add(FloLayTaskListContainer);
            LstTaskBox.Location = new System.Drawing.Point(0, 0);
            LstTaskBox.Visible = false;
        }

        public void SignOutResembles()
        {
            foreach (object TaskList_loopVariable in FloLayTaskListContainer.Controls)
            {
                FloLayTaskListContainer.Controls.Clear();
            }
            LstTaskBox.Items.Clear();

        }

        public void RetrieveTasks()
        {
            try
            {
                ObjectOleDbConnection.Open();
                ObjectOleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM Task WHERE UserID = " + MainForm.UserID, ObjectOleDbConnection);
                TasksDataTable.Clear(); TasksDataTable.Rows.Clear(); TasksDataTable.Columns.Clear();
                ObjectOleDbDataAdapter.Fill(TasksDataTable);
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
                ObjectOleDbConnection.Close();
            }
        }

        private void RetrieveUserInformation()
        {
            try
            {
                ObjectOleDbConnection.Open();
                ObjectOleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM Users ORDER BY ID", ObjectOleDbConnection);
                UsersDataTable.Clear();
                UsersDataTable.Rows.Clear();
                UsersDataTable.Columns.Clear();
                ObjectOleDbDataAdapter.Fill(UsersDataTable);
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
                ObjectOleDbConnection.Close();
            }
            int max = 0;
            for (int x = 1; x <= UsersDataTable.Rows.Count; x++)
            {
                if (Convert.ToInt32(UsersDataTable.Rows[x - 1][3]) > max)
                {
                    max = Convert.ToInt32(UsersDataTable.Rows[x - 1][3]);
                }
            }
            UserID = max.ToString();
        }

        public void TakeTasksFromDataBaseAndPutThemInTaskViewerAndContainerOfTaskViewer()
        {
            for (int x = 0; x <= TasksDataTable.Rows.Count - 1; x++)
            {
                if (!LstTaskBox.Items.Contains(TasksDataTable.Rows[x][7]))
                {
                    LstTaskBox.Items.Add(TasksDataTable.Rows[x][7]);
                }
            }
            for (int x = 0; x <= LstTaskBox.Items.Count - 1; x++)
            {
                ContainerOfTaskViewer ObjectContainerOfTaskViewer = new ContainerOfTaskViewer();
                ObjectContainerOfTaskViewer.Name = Convert.ToString(LstTaskBox.Items[x]);
                ObjectContainerOfTaskViewer.Label1.Text = Convert.ToString(LstTaskBox.Items[x]);
                FloLayTaskListContainer.Controls.Add(ObjectContainerOfTaskViewer);
            }
            foreach (ContainerOfTaskViewer obj in FloLayTaskListContainer.Controls)
            {
                for (int f = 0; f <= TasksDataTable.Rows.Count - 1; f++)
                {
                    if (obj.Label1.Text == (string)TasksDataTable.Rows[f][7] && (!object.ReferenceEquals(TasksDataTable.Rows[f][2], DBNull.Value)))
                    {
                        TaskViewer ObjectTaskViewer = new TaskViewer();
                        if (Convert.ToInt32(TasksDataTable.Rows[f][2]) >= 80)
                        {
                            ObjectTaskViewer.txtPriority.Text = "A";
                        }
                        else if (Convert.ToInt32(TasksDataTable.Rows[f][2]) >= 60)
                        {
                            ObjectTaskViewer.txtPriority.Text = "B";
                        }
                        else if (Convert.ToInt32(TasksDataTable.Rows[f][2]) >= 40)
                        {
                            ObjectTaskViewer.txtPriority.Text = "C";
                        }
                        else if (Convert.ToInt32(TasksDataTable.Rows[f][2]) >= 20)
                        {
                            ObjectTaskViewer.txtPriority.Text = "D";
                        }
                        else
                        {
                            ObjectTaskViewer.txtPriority.Text = "E";
                        }
                        ObjectTaskViewer.txtTaskContainer.Text = Convert.ToString(TasksDataTable.Rows[f][5]);
                        ObjectTaskViewer.ActualTask = Convert.ToString(TasksDataTable.Rows[f][6]);
                        ObjectTaskViewer.SetDate = Convert.ToString(TasksDataTable.Rows[f][3]);
                        ObjectTaskViewer.DeadLine = Convert.ToString(TasksDataTable.Rows[f][4]);
                        ObjectTaskViewer.TaskList = Convert.ToString(TasksDataTable.Rows[f][7]);
                        ObjectTaskViewer.TaskID = Convert.ToString(TasksDataTable.Rows[f][0]);
                        ObjectTaskViewer.Priority = Convert.ToString(TasksDataTable.Rows[f][2]);
                        ObjectTaskViewer.SetTime = Convert.ToString(TasksDataTable.Rows[f][8]);
                        ObjectTaskViewer.EndTime = Convert.ToString(TasksDataTable.Rows[f][9]);
                        DateTime ObjectDateTime = Convert.ToDateTime(TasksDataTable.Rows[f][4] + " " + TasksDataTable.Rows[f][9]);
                        int isNumberofDays = 0;
                        ObjectTimeSpan = ObjectDateTime.Subtract(DateTime.Now);
                        isNumberofDays = ObjectTimeSpan.Days;
                        if (ObjectTimeSpan.Days <= 0)
                        {
                            ObjectTaskViewer.BackColor = Color.Red;
                        }
                        ObjectTaskViewer.txtTimer.Text = Convert.ToString(isNumberofDays);
                        obj.FlowLayoutPanel1.Controls.Add(ObjectTaskViewer);
                        //addTask(ObjectTaskViewer, obj.FlowLayoutPanel1);
                    }
                }

            }
        }
        
        private void CreateNewTask()
        {
            ObjectTaskEditor = new TaskEditor(true);
            ObjectTaskEditor.Show();
            if (UserIdentifier == true)
            {
                ObjectTaskEditor.ComboBoxAssignedTo.Visible = false;
                ObjectTaskEditor.Label8.Visible = false;
            }
            RetrieveTasks();
            int max = 0;
            for (int x = 1; x <= TasksDataTable.Rows.Count; x++)
            {
                if (Convert.ToInt32(TasksDataTable.Rows[x - 1][0]) > max)
                {
                    max = Convert.ToInt32(TasksDataTable.Rows[x - 1][0]);
                }
            }
            max++;
            ObjectTaskEditor.TaskID = max.ToString();
            ObjectTaskEditor.lblPriorityInBrother.Text = "E";
            ObjectTaskEditor.sliderPriority.Value = 1;
            for (int b = 0; b <= LstTaskBox.Items.Count - 1; b++)
            {
                ObjectTaskEditor.ComboBoxTaskListInBrother.Items.Add(LstTaskBox.Items[b]);
            }
            ObjectTaskEditor.ComboBoxTaskListInBrother.Items.Add("New...");
            RetrieveUserInformation();
            for (int n = 0; n <= UsersDataTable.Rows.Count - 1; n++)
            {
                ObjectTaskEditor.ComboBoxAssignedTo.Items.Add(UsersDataTable.Rows[n][0]);
            }
            ObjectTaskEditor.ComboBoxAssignedTo.Items.Add("Myself...");
        }

        private void PutUserIntoDataBase()
        {
            try
            {
                string sqlStringAddingTasks = "Insert into Users values('" + txtNameInRegistration.Text +
                     ",'" + txtPasswordInRegistration.Text +
                    "','" + txtEmailAddressInRegistration.Text +
                    "'," + UserID +
                    ",'" + Convert.ToString(UserIdentifier) + "')";
                OleDbCommand ObjectOleDbCommand = ObjectOleDbConnection.CreateCommand();
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
                ObjectOleDbConnection.Close();
            }
        }

        private object ask()
        {
            for (int j = 0; j <= UsersDataTable.Rows.Count - 1; j++)
            {
                foreach (object datarow_loopVariable in UsersDataTable.Rows)
                {
                    if (txtEmailAddress.Text == Convert.ToString(UsersDataTable.Rows[j][2]) & txtPassword.Text == Convert.ToString(UsersDataTable.Rows[j][1]))
                    {
                        Label9.Text = Convert.ToString(UsersDataTable.Rows[j][0]);
                        UserID = Convert.ToString(UsersDataTable.Rows[j][3]);
                        Label9.Visible = true;
                        return true;
                    }
                }
            }
            return false;
        }

        private void RealRefreshInterface(int PageNumber)
        {
            switch (PageNumber)
            {
                case 1:
                    TasksGBox.Left = UnOptimaXlViewingPosition;
                    TasksGBox.Top = UnOptimalYViewingPosition;
                    FirstScreenGBox.Left = UnOptimaXlViewingPosition;
                    FirstScreenGBox.Top = UnOptimalYViewingPosition;
                    SingleUserSignInGBox.Left = UnOptimaXlViewingPosition;
                    SingleUserSignInGBox.Top = UnOptimalYViewingPosition;
                    CalendarGBox.Left = UnOptimaXlViewingPosition;
                    CalendarGBox.Top = UnOptimalYViewingPosition;
                    TasksHabitsChooserGBox.Left = UnOptimaXlViewingPosition;
                    TasksHabitsChooserGBox.Top = UnOptimalYViewingPosition;
                    break;
                case 2:
                    MultiUserSignInGBox.Left = UnOptimaXlViewingPosition;
                    MultiUserSignInGBox.Top = UnOptimalYViewingPosition;
                    FirstScreenGBox.Left = UnOptimaXlViewingPosition;
                    FirstScreenGBox.Top = UnOptimalYViewingPosition;
                    SingleUserSignInGBox.Left = UnOptimaXlViewingPosition;
                    SingleUserSignInGBox.Top = UnOptimalYViewingPosition;
                    CalendarGBox.Left = UnOptimaXlViewingPosition;
                    CalendarGBox.Top = UnOptimalYViewingPosition;
                    TasksHabitsChooserGBox.Left = UnOptimaXlViewingPosition;
                    TasksHabitsChooserGBox.Top = UnOptimalYViewingPosition;
                    break;
                case 3:
                    SingleUserSignInGBox.Left = UnOptimaXlViewingPosition;
                    SingleUserSignInGBox.Top = UnOptimalYViewingPosition;
                    MultiUserSignInGBox.Left = UnOptimaXlViewingPosition;
                    MultiUserSignInGBox.Top = UnOptimalYViewingPosition;
                    TasksGBox.Left = UnOptimaXlViewingPosition;
                    TasksGBox.Top = UnOptimalYViewingPosition;
                    CalendarGBox.Left = UnOptimaXlViewingPosition;
                    CalendarGBox.Top = UnOptimalYViewingPosition;
                    TasksHabitsChooserGBox.Left = UnOptimaXlViewingPosition;
                    TasksHabitsChooserGBox.Top = UnOptimalYViewingPosition;
                    break;
                case 4:
                    MultiUserSignInGBox.Left = UnOptimaXlViewingPosition;
                    MultiUserSignInGBox.Top = UnOptimalYViewingPosition;
                    TasksGBox.Left = UnOptimaXlViewingPosition;
                    TasksGBox.Top = UnOptimalYViewingPosition;
                    FirstScreenGBox.Left = UnOptimaXlViewingPosition;
                    FirstScreenGBox.Top = UnOptimalYViewingPosition;
                    CalendarGBox.Left = UnOptimaXlViewingPosition;
                    CalendarGBox.Top = UnOptimalYViewingPosition;
                    TasksHabitsChooserGBox.Left = UnOptimaXlViewingPosition;
                    TasksHabitsChooserGBox.Top = UnOptimalYViewingPosition;
                    break;
                case 5:
                    SingleUserSignInGBox.Left = UnOptimaXlViewingPosition;
                    SingleUserSignInGBox.Top = UnOptimalYViewingPosition;
                    MultiUserSignInGBox.Left = UnOptimaXlViewingPosition;
                    MultiUserSignInGBox.Top = UnOptimalYViewingPosition;
                    FirstScreenGBox.Left = UnOptimaXlViewingPosition;
                    FirstScreenGBox.Top = UnOptimalYViewingPosition;
                    CalendarGBox.Left = UnOptimaXlViewingPosition;
                    CalendarGBox.Top = UnOptimalYViewingPosition;
                    TasksGBox.Left = UnOptimaXlViewingPosition;
                    TasksGBox.Top = UnOptimalYViewingPosition;
                    break;
                case 6:
                    SingleUserSignInGBox.Left = UnOptimaXlViewingPosition;
                    SingleUserSignInGBox.Top = UnOptimalYViewingPosition;
                    MultiUserSignInGBox.Left = UnOptimaXlViewingPosition;
                    MultiUserSignInGBox.Top = UnOptimalYViewingPosition;
                    FirstScreenGBox.Left = UnOptimaXlViewingPosition;
                    FirstScreenGBox.Top = UnOptimalYViewingPosition;
                    TasksHabitsChooserGBox.Left = UnOptimaXlViewingPosition;
                    TasksHabitsChooserGBox.Top = UnOptimalYViewingPosition;
                    TasksGBox.Left = UnOptimaXlViewingPosition;
                    TasksGBox.Top = UnOptimalYViewingPosition;
                    break;
            }
        }

        private void RefreshInterface(int InterfaceNumber)
        {
            switch (InterfaceNumber)
            {
                case 1:
                    MainPanel.Controls.Clear();
                    MainPanel.Controls.Add(MultiUserSignInGBox);
                    MultiUserSignInGBox.Left = 0;
                    MultiUserSignInGBox.Top = 0;
                    InterfaceCorrection(GBoxNumber);
                    RealRefreshInterface(GBoxNumber);
                    break;
                case 2:
                    MainPanel.Controls.Clear();
                    MainPanel.Controls.Add(TasksGBox);
                    TasksGBox.Left = 0;
                    TasksGBox.Top = 0;
                    InterfaceCorrection(GBoxNumber);
                    RealRefreshInterface(GBoxNumber);
                    break;
                case 3:
                    MainPanel.Controls.Clear();
                    MainPanel.Controls.Add(FirstScreenGBox);
                    FirstScreenGBox.Left = 0;
                    FirstScreenGBox.Top = 0;
                    InterfaceCorrection(GBoxNumber);
                    RealRefreshInterface(GBoxNumber);
                    break;
                case 4:
                    MainPanel.Controls.Clear();
                    MainPanel.Controls.Add(SingleUserSignInGBox);
                    SingleUserSignInGBox.Left = 0;
                    SingleUserSignInGBox.Top = 0;
                    InterfaceCorrection(GBoxNumber);
                    RealRefreshInterface(GBoxNumber);
                    break;
                case 5:
                    MainPanel.Controls.Clear();
                    MainPanel.Controls.Add(TasksHabitsChooserGBox);
                    TasksHabitsChooserGBox.Left = 0;
                    TasksHabitsChooserGBox.Top = 0;
                    InterfaceCorrection(GBoxNumber);
                    RealRefreshInterface(GBoxNumber);
                    break;
                case 6:
                    MainPanel.Controls.Clear();
                    MainPanel.Controls.Add(CalendarGBox);
                    CalendarGBox.Left = 0;
                    CalendarGBox.Top = 0;
                    InterfaceCorrection(GBoxNumber);
                    RealRefreshInterface(GBoxNumber);
                    break;
            }

        }

        private void InterfaceCorrection(int GBoxNumber)
        {
            switch (GBoxNumber)
            {
                case 1:
                    MultiUserSignInGBox.Left = (MainPanel.ClientSize.Width - MultiUserSignInGBox.Width) / 2;
                    MultiUserSignInGBox.Top = (MainPanel.ClientSize.Height - MultiUserSignInGBox.Height) / 2;
                    MultiUserSignInGBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
                    break;
                case 2:
                    TasksGBox.Left = (MainPanel.ClientSize.Width - TasksGBox.Width) / 2;
                    TasksGBox.Top = (MainPanel.ClientSize.Height - TasksGBox.Height) / 2;
                    TasksGBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right);
                    TasksGBox.Dock = DockStyle.Fill;
                    break;
                case 3:
                    FirstScreenGBox.Left = (MainPanel.ClientSize.Width - FirstScreenGBox.Width) / 2;
                    FirstScreenGBox.Top = (MainPanel.ClientSize.Height - FirstScreenGBox.Height) / 2;
                    FirstScreenGBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
                    break;
                case 4:
                    SingleUserSignInGBox.Left = (MainPanel.ClientSize.Width - SingleUserSignInGBox.Width) / 2;
                    SingleUserSignInGBox.Top = (MainPanel.ClientSize.Height - SingleUserSignInGBox.Height) / 2;
                    SingleUserSignInGBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
                    break;
                case 5:
                    TasksHabitsChooserGBox.Left = (MainPanel.ClientSize.Width - TasksHabitsChooserGBox.Width) / 2;
                    TasksHabitsChooserGBox.Top = (MainPanel.ClientSize.Height - TasksHabitsChooserGBox.Height) / 2;
                    TasksHabitsChooserGBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
                    TasksHabitsChooserGBox.Dock = DockStyle.Fill;
                    break;
                case 6:
                    CalendarGBox.Left = (MainPanel.ClientSize.Width - CalendarGBox.Width) / 2;
                    CalendarGBox.Top = (MainPanel.ClientSize.Height - CalendarGBox.Height) / 2;
                    CalendarGBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
                    break;
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            InterfaceCorrection(GBoxNumber);
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            GBoxNumber = 5;
            InterfaceCorrection(GBoxNumber);
            RefreshInterface(5);
            SignOutResembles();
        }

        private void MainForm_MaximizedBoundsChanged(object sender, EventArgs e)
        {
            InterfaceCorrection(GBoxNumber);
        }

        #region Event Handling Methods

        private void cmdRegsiter_Click(System.Object sender, System.EventArgs e)
        {
            PutUserIntoDataBase();
            txtNameInRegistration.Clear();
            txtEmailAddress.Text = txtEmailAddressInRegistration.Text;
            txtPassword.Text = txtPasswordInRegistration.Text;
            txtEmailAddressInRegistration.Clear();
            txtPasswordInRegistration.Clear();
            cmdRegsiter.Enabled = false;
            RetrieveUserInformation();
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            txtNameInRegistration.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNameInRegistration.Text);
        }

        private void txtNameSingleUser_Validating(object sender, CancelEventArgs e)
        {
            txtNameSingleUser.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNameSingleUser.Text);
        }

        private void cmdLogIn_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(ask()) == true)
            {
                GBoxNumber = 5;
                RefreshInterface(5);
                txtEmailAddress.Clear();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Sign-in Unsuccessful. Your Email Address or Password or both are invalid. Please register if you haven't.");
            }
        }

        private void passcodeTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNameSingleUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            if (e.KeyChar.Equals("-"))
            {
                e.Handled = true;
            }
        }

        private void cmdFamilyUse_Click(object sender, EventArgs e)
        {
            GBoxNumber = 1;
            UserIdentifier = false;
            RefreshInterface(1);
        }

        private void cmdSingleUser_Click(object sender, EventArgs e)
        {
            GBoxNumber = 4;
            UserIdentifier = true;
            RefreshInterface(4);
        }

        private void cmdNewTask_Click(object sender, EventArgs e)
        {
            CreateNewTask();
        }

        private void cmdLaunchBoxNewTaskList_Click(object sender, EventArgs e)
        {
            BoxCreateNewTaskList.Visible = true;
        }

        private void cmdCancelInCreateNewTasListBox_Click(object sender, EventArgs e)
        {
            txtNewTaskListName.Clear();
            BoxCreateNewTaskList.Visible = false;
        }

        private void cmdCreateNewTaskList_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNewTaskListName.Text))
            {
                RetrieveTasks();
                int max = 0;
                for (int x = 1; x <= TasksDataTable.Rows.Count; x++)
                {
                    if (Convert.ToInt32(TasksDataTable.Rows[x - 1][0]) > max)
                    {
                        max = Convert.ToInt32(TasksDataTable.Rows[x - 1][0]);
                    }
                }
                max++;
                ContainerOfTaskViewer TaskList = new ContainerOfTaskViewer();
                FloLayTaskListContainer.Controls.Add(TaskList);
                TaskList.Name = txtNewTaskListName.Text;
                TaskList.Label1.Text = txtNewTaskListName.Text;
                TaskList.TaskListID = Convert.ToString(max);
                BoxCreateNewTaskList.Visible = false;
                try
                {
                    string sqlStringForTaskLists = "Insert into Task(TaskID, UserID, ToDoList) values(" + TaskList.TaskListID +
                        "," + UserID + ",'" + txtNewTaskListName.Text + "')";
                    OleDbCommand ObjectOleDbCommand = ObjectOleDbConnection.CreateCommand();
                    ObjectOleDbCommand.CommandText = sqlStringForTaskLists;
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
                    ObjectOleDbConnection.Close();
                    txtNewTaskListName.Clear();
                }
                SignOutResembles();
                RetrieveTasks();
                TakeTasksFromDataBaseAndPutThemInTaskViewerAndContainerOfTaskViewer();
            }
            else
            {
                MessageBox.Show("You cannot create a tasklist with no name.");
            }
        }

        private void txtEmailAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar("\"") || e.KeyChar == Convert.ToChar("'"))
            {
                e.Handled = true;
            }
        }

        private void cmdSingleUserRegistration_Click(object sender, EventArgs e)
        {
            int c = 0;
            for (int f = 0; f <= UsersDataTable.Rows.Count - 1; f++)
            {
                c++;
            }
            if (c == 0)
            {
                string str3 = passcodeTextbox1.Text;
                if (passcodeTextbox1.Text == "")
                {
                    str3 = "NotRequired";
                }

                if (txtNameSingleUser.Text != "Name")
                {

                    try
                    {
                        string sqlStringAddingTasks = "Insert into Users values('" + txtNameSingleUser.Text +
                             "','" + str3 +
                            "','" + "NotRequired" +
                            "'," + UserID +
                            ",'" + Convert.ToString(UserIdentifier) + "')";
                        OleDbCommand ObjectOleDbCommand = ObjectOleDbConnection.CreateCommand();
                        ObjectOleDbCommand.CommandText = sqlStringAddingTasks;
                        MainForm.ObjectOleDbConnection.Open();
                        ObjectOleDbCommand.ExecuteNonQuery();
                        Label9.Text = Convert.ToString(txtNameSingleUser.Text);
                        UserID = Convert.ToString(UserID);
                        Label9.Visible = true;
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
                        ObjectOleDbConnection.Close();
                    }
                    label3.Text = txtNameSingleUser.Text;
                    label3.Visible = true;
                    label3.Left = 340;
                    txtNameSingleUser.Clear();
                    passcodeTextbox1.Clear();
                    txtNameSingleUser.Visible = false;
                    GBoxNumber = 5;
                    RefreshInterface(5);

                }
                else
                {
                    MessageBox.Show("Please write a name.");
                }
            }
            else if (c == 1 & Convert.ToString(UsersDataTable.Rows[0][4]) == "True")
            {
                if (passcodeTextbox1.Text == Convert.ToString(UsersDataTable.Rows[0][1]))
                {
                    Label9.Text = Convert.ToString(UsersDataTable.Rows[0][0]);
                    UserID = Convert.ToString(UsersDataTable.Rows[0][3]);
                    Label9.Visible = true;
                    GBoxNumber = 5;
                    RefreshInterface(5);
                }
                else
                {
                    MessageBox.Show("Your Passcode is incorrect. Have another go.");
                }
            }
        }

        private void CmdTakesToTasks_Click(object sender, EventArgs e)
        {
            RetrieveTasks();
            TakeTasksFromDataBaseAndPutThemInTaskViewerAndContainerOfTaskViewer();
            GBoxNumber = 2;
            RefreshInterface(2);
        }

        private void txtNewTaskListName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNewTaskListName_Validating(object sender, CancelEventArgs e)
        {
            txtNewTaskListName.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNewTaskListName.Text);
        }

        private void newTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewTask();
        }

        private void newTaskListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BoxCreateNewTaskList.Visible = true;
        }

        #endregion

        #endregion

        #region Calendar code

        int CurrentCalendarYear;

        private void makeCalender(int year)
        {
            NewColumn.Name = "Month";
            NewColumn.Width = 65;
            NewColumn.DefaultCellStyle.Font = new Font(CalendarDGV.DefaultCellStyle.Font, FontStyle.Regular);
            NewColumn.ReadOnly = true;
            cell.Style.BackColor = Color.Olive;
            NewColumn.CellTemplate = cell;
            CalendarDGV.Columns.Clear();
            CalendarDGV.Rows.Clear();
            CalendarDGV.Columns.Add(NewColumn);
            for (int w = 1; w <= 6; w++)
            {
                for (int dow = 0; dow < 7; dow++)
                {
                    string weekday = string.Format("{0:3}", ((DayOfWeek)dow).ToString().Substring(0, 3));
                    NewColumn = new DataGridViewColumn();
                    NewColumn.Name = weekday;
                    NewColumn.Width = 33;
                    NewColumn.DefaultCellStyle.Font = new Font(CalendarDGV.DefaultCellStyle.Font, FontStyle.Regular);
                    NewColumn.ReadOnly = true;
                    cell = new DataGridViewTextBoxCell();
                    cell.Style.BackColor = Color.Tan;
                    NewColumn.CellTemplate = cell;
                    CalendarDGV.Columns.Add(NewColumn);
                }
            }
            for (int month = 1; month <= 12; month++)
            {
                int RowNumber = CalendarDGV.Rows.Add();
                DataGridViewRow NewRow = CalendarDGV.Rows[RowNumber];
                NewRow.Height = 70;
                NewRow.Cells[0].Value = string.Format("{0,3}", DateTimeFormatInfo.CurrentInfo.MonthNames[month - 1]);
                int day = 1;
                DayOfWeek dow = gc.GetDayOfWeek(new DateTime(year, month, day));
                int colNumber = (int)dow + 1;
                while (day <= gc.GetDaysInMonth(year, month))
                {
                    NewRow.Cells[colNumber].Value = string.Format("{0,3}", day);
                    day++;
                    colNumber++;
                }
            }
        }

        private void FindToday()
        {
            DateTime g = DateTime.Now.Date;
            int dayy = g.Day;
            int month = g.Month - 1;
            int yeaar = g.Year;
            if (CurrentCalendarYear == yeaar)
            {

                for (int i = 1; i < CalendarDGV.ColumnCount - 2; i++)
                {
                    if (CalendarDGV.Rows[month].Cells[i].Value != null)
                    {
                        if (dayy == Convert.ToInt32(CalendarDGV.Rows[month].Cells[i].Value.ToString().Trim()))
                        {
                            DataGridViewCell cl = CalendarDGV.Rows[month].Cells[i];
                            cl.ToolTipText = "Today's Date " + g.ToShortDateString().ToString();
                            cl.Style.BackColor = Color.Green;
                        }
                    }
                }
            }
        }

        private void cmdTakesToCalendar_Click(object sender, EventArgs e)
        {
            GBoxNumber = 6;
            RefreshInterface(6);
            CalendarFLP.Dock = DockStyle.Fill;
            CurrentCalendarYear = DateTime.Now.Year;
            textBox1.Text = CurrentCalendarYear.ToString();
            makeCalender(CurrentCalendarYear);
            CurrentCalendarYear = DateTime.Now.Year;
            CalendarDGV.Size = new Size(1000, 500);
            CalendarDGV.MaximumSize = new Size(1300, 1100);
            CalendarDGV.Top = 20;
            CalendarDGV.Height = 940;
            CalendarDGV.Width = 1300;
            CalendarDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.Gold;
            CalendarDGV.EnableHeadersVisualStyles = false;
            CalendarDGV.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            CalendarDGV.ColumnHeadersDefaultCellStyle.Font = new Font(CalendarDGV.Font, FontStyle.Regular);
            CalendarDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            CalendarDGV.AllowUserToResizeColumns = false;
            CalendarDGV.AllowUserToResizeRows = false;
            CalendarDGV.RowHeadersVisible = false;
        }

        private void CalendarDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CalendarDGV.Rows.Clear();
            CalendarDGV.Columns.Clear();
            int cc = Convert.ToInt32(CurrentCalendarYear);
            cc++;
            makeCalender(cc);
            CurrentCalendarYear = cc;
            textBox1.Text = cc.ToString();
            FindToday();
        }

        private void cmdPrevious_Click(object sender, EventArgs e)
        {
            CalendarDGV.Rows.Clear();
            CalendarDGV.Columns.Clear();
            int c = Convert.ToInt32(CurrentCalendarYear);
            c--;
            makeCalender(c);
            CurrentCalendarYear = c;
            textBox1.Text = c.ToString();
            FindToday();
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            CalendarDGV.Rows.Clear();
            CalendarDGV.Columns.Clear();
            int cc = Convert.ToInt32(CurrentCalendarYear);
            cc++;
            makeCalender(cc);
            CurrentCalendarYear = cc;
            textBox1.Text = cc.ToString();
            FindToday();
        }

        #endregion

    }
}
