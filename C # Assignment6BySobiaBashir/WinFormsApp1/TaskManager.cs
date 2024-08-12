namespace WinFormsApp1
{
    class TaskManager
    {
        List<Task> taskList;

        public TaskManager()
        {
            taskList = new List<Task>();
        }

        public Task GetTask(int index)
        {
            if (CheckIndex(index))
            {
                return taskList[index];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool CheckIndex(int index)
        {
            bool ok = false;
            if ((index >= 0) && (index <= taskList.Count))
            {
                ok = true;
            }
            return ok;
        }

        /// <summary>
        /// add a new object at the end of task list
        /// </summary>
        /// <param name="newTask">the object of task which to be added</param>
        /// <returns>true if task added succesfully, false otherwise
        /// </returns>

        public bool AddNewTask(Task newTask)
        {
            bool ok = true;
            if (newTask != null)
            {
                taskList.Add(newTask);
            }
            else
            {
                ok = false;
            }
            return ok;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newTime"></param>
        /// <param name="description"></param>
        /// <param name="periority"></param>
        /// <returns>true if task added succesfully, false otherwise</returns>
        /// 

        public bool AddNewTask(DateTime newTime, string description, PeriorityType periority)
        {
            bool ok = true;
            Task newTask = new Task(newTime, description, periority);

            if (newTask != null)
            {
                taskList.Add(newTask);
            }
            else
            {
                ok = false;
            }
            return ok;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="task"></param>
        /// <returns>true if task added succesfully, false otherwise</returns>
        /// 
        public bool ChangeTaskAt(Task task, int index)
        {
            bool ok = true;
            if ((task != null) && CheckIndex(index))
            {
                taskList[index] = task;
            }
            else
            {
                ok = false;
            }
            return ok;
        }

        public bool DeleteTaskAt(int index)
        {
            bool ok = false;
            if ((index >= 0) && (index <= taskList.Count))
            {
                taskList.RemoveAt(index);
                ok = true;
            }
            return ok;

        }
        //////////////////////////////////////




        /// <summary>
        /// ///////////////////////////////////////
        /// </summary>
        /// <returns></returns>

        public string[] GetInfoStrinList()
        {
            string[] infoStrings = new string[taskList.Count];
            for (int i = 0; i < infoStrings.Length; i++)
            {
                infoStrings[i] = taskList[i].ToString();
            }
            return infoStrings;

        }

    }
}
