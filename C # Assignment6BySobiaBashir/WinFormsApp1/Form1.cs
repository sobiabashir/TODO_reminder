namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private const string fileVersionToken = "ToDoIn_24";
        private const double fileVersionNumber = 1.0;

        TaskManager taskManager;
        private List<Task> tasks;
        private List<string> loadedTasks;
        public Form1()
        {
            InitializeComponent();


            this.MaximizeBox = false;
            this.Text = "ToDO Remainder by SobiaBashir";
            CenterToScreen();
            InitialzeGUI();



        }
        private void InitialzeGUI()
        {

            btnUpdateOk.Enabled = false;
            timer1.Start();
            InitializeComboBox();
            cmbPeriority.SelectedIndex = 2;
            taskManager = new TaskManager();
            lstBoxDisplayToDo.Items.Clear();

        }
        private void InitializeComboBox()
        {
            cmbPeriority.Items.AddRange(Enum.GetNames(typeof(PeriorityType)));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDisplayCurrenttime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnUpdateOk.Enabled = false;
            Task task = ReadInput();
            if (taskManager.AddNewTask(task))
            {
                UpdateGUI();
            }
        }


        private Task ReadInput()
        {
            Task task = new Task();
            if (string.IsNullOrEmpty(txtboxToDo.Text))
            {
                MessageBox.Show("hello please write somthing", "Error");
                return null;
            }
            task.Description = txtboxToDo.Text;
            task.TaskDate = dateTimeOfTODO.Value;
            task.Periority = (PeriorityType)cmbPeriority.SelectedIndex;
            return task;

        }



        private void UpdateGUI()
        {

            lstBoxDisplayToDo.Items.Clear();
            string[] infoStrings = taskManager.GetInfoStrinList();
            if (infoStrings != null)
            {
                lstBoxDisplayToDo.Items.AddRange(infoStrings);
            }
            txtboxToDo.Text = "";
        }

        private void toolStripMenuExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // Exit the application
                Application.Exit();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstBoxDisplayToDo.SelectedIndex != -1)
            {
                taskManager.DeleteTaskAt(lstBoxDisplayToDo.SelectedIndex);
                UpdateGUI();
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "Information");
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            // Check if any item is selected in the ListBox
            if (lstBoxDisplayToDo.SelectedIndex != -1)
            {
                btnUpdateOk.Enabled = true;
                btnAdd.Enabled = false;

                int selectedIndex = lstBoxDisplayToDo.SelectedIndex;


                Task selectedTask = taskManager.GetTask(selectedIndex);


                if (selectedTask != null)
                {
                    dateTimeOfTODO.Value = selectedTask.TaskDate;

                    txtboxToDo.Text = selectedTask.Description.ToString();
                    cmbPeriority.SelectedIndex = (int)selectedTask.Periority;
                }
            }
            else
            {
                MessageBox.Show("Please select a task to update.", "Information");
            }
            btnChange.Enabled = false;
        }

        private void btnUpdateOk_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstBoxDisplayToDo.SelectedIndex;
            Task task = ReadInput();
            if (taskManager.ChangeTaskAt(task, selectedIndex))
            {
                UpdateGUI();
            }


            btnAdd.Enabled = true;
            btnUpdateOk.Enabled = false;
            btnChange.Enabled = true;
        }

        private void toolStripMenuAbout_Click(object sender, EventArgs e)
        {
            AboutBoxForm aboutBoxForm = new AboutBoxForm();
            aboutBoxForm.ShowDialog();
        }

        private void toolStripMenuNew_Click(object sender, EventArgs e)
        {
            InitialzeGUI();
        }
        /// <summary>
        /// 
        private void toolStripMenuSaveDataFile_Click(object sender, EventArgs e)
        {
            if (lstBoxDisplayToDo.Items.Count > 0)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = saveFileDialog.FileName;

                        try
                        {
                            using (StreamWriter writer = new StreamWriter(fileName))
                            {
                                // Write file version information
                                writer.WriteLine(fileVersionToken);
                                writer.WriteLine(fileVersionNumber);

                                // Write total number of tasks
                                writer.WriteLine($"Total number of tasks: {lstBoxDisplayToDo.Items.Count}");

                                // Write each task
                                foreach (var item in lstBoxDisplayToDo.Items)
                                {
                                    writer.WriteLine(item.ToString());
                                }
                            }

                            MessageBox.Show("Tasks saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error saving tasks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No tasks to save.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// /////////////////////////////////////////////////////
        /// 
        private void OpenFileAndDisplayTasks()
        {


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;

                    try
                    {
                        loadedTasks = new List<string>(); // Initialize the list to store loaded tasks

                        using (StreamReader reader = new StreamReader(fileName))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                loadedTasks.Add(line); // Add each line from the file to the temporary list
                            }
                        }

                        // Clear existing items before loading from file
                        lstBoxDisplayToDo.Items.Clear();

                        // Add loaded tasks to the list box
                        foreach (string task in loadedTasks)
                        {
                            lstBoxDisplayToDo.Items.Add(task);
                        }

                        MessageBox.Show("Tasks loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading tasks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void toolStripMenuItemOpenDataFile_Click(object sender, EventArgs e)
        {
            OpenFileAndDisplayTasks();
        }
    }
}
