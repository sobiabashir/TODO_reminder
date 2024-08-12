namespace WinFormsApp1
{
    internal class Task
    {
        private DateTime taskDate;

        private string description;
        private PeriorityType periority;

        public Task()
        {
            periority = PeriorityType.Normal;
        }

        /// <param name="TaskDate" > input is comming from caller .</param>
        public Task(DateTime taskDate) : this(taskDate, String.Empty, PeriorityType.Normal)
        {

        }

        public Task(DateTime taskDate, string description, PeriorityType periority)
        {
            this.taskDate = taskDate;
            this.description = description;
            this.periority = periority;
        }

        /// <summary>
        /// getter setter
        /// </summary>
        public string Description
        {
            get { return description; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    description = value;
            }
        }

        public PeriorityType Periority
        {
            get { return periority; }
            set { periority = value; }
        }

        public DateTime TaskDate
        {
            get { return taskDate; }
            set { taskDate = value; }
        }


        public string GetPeriorityString()
        {
            string txtOut = Enum.GetName(typeof(PeriorityType), periority);
            txtOut = txtOut.Replace("_", " ");
            return txtOut;
        }
        public override string ToString()
        {
            string textOut = $"{taskDate.ToLongDateString(),-20}{taskDate.ToString("hh:mm tt"),-10}{" ",20}," +
        $"{GetPeriorityString(),-50}{description,-15}";
            return textOut;


        }



    }
}
