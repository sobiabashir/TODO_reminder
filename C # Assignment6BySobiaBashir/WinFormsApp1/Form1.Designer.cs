namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuFile = new MenuStrip();
            toolStripMainFile = new ToolStripMenuItem();
            toolStripMenuNew = new ToolStripMenuItem();
            toolStripMenuItemOpenDataFile = new ToolStripMenuItem();
            toolStripMenuSaveDataFile = new ToolStripMenuItem();
            toolStripMenuExit = new ToolStripMenuItem();
            toolStripMenuHelp = new ToolStripMenuItem();
            toolStripMenuAbout = new ToolStripMenuItem();
            lblDateTime = new Label();
            dateTimeOfTODO = new DateTimePicker();
            lblPeriority = new Label();
            cmbPeriority = new ComboBox();
            lblToDO = new Label();
            txtboxToDo = new TextBox();
            btnAdd = new Button();
            grpTodo = new GroupBox();
            lblDisplayCurrenttime = new Label();
            btnDelete = new Button();
            btnChange = new Button();
            lstBoxDisplayToDo = new ListBox();
            lblPerio = new Label();
            lblDescription = new Label();
            lblHours = new Label();
            lblDate = new Label();
            toolTipDate = new ToolTip(components);
            timer1 = new System.Windows.Forms.Timer(components);
            btnUpdateOk = new Button();
            menuFile.SuspendLayout();
            grpTodo.SuspendLayout();
            SuspendLayout();
            // 
            // menuFile
            // 
            menuFile.BackColor = SystemColors.InactiveCaption;
            menuFile.ImageScalingSize = new Size(20, 20);
            menuFile.Items.AddRange(new ToolStripItem[] { toolStripMainFile, toolStripMenuHelp });
            menuFile.Location = new Point(0, 0);
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(800, 28);
            menuFile.TabIndex = 0;
            menuFile.Text = "File";
            // 
            // toolStripMainFile
            // 
            toolStripMainFile.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuNew, toolStripMenuItemOpenDataFile, toolStripMenuSaveDataFile, toolStripMenuExit });
            toolStripMainFile.Name = "toolStripMainFile";
            toolStripMainFile.Size = new Size(46, 24);
            toolStripMainFile.Text = "File";
            // 
            // toolStripMenuNew
            // 
            toolStripMenuNew.Name = "toolStripMenuNew";
            toolStripMenuNew.Size = new Size(224, 26);
            toolStripMenuNew.Text = "New   Ctrl+N";
            toolStripMenuNew.Click += toolStripMenuNew_Click;
            // 
            // toolStripMenuItemOpenDataFile
            // 
            toolStripMenuItemOpenDataFile.Name = "toolStripMenuItemOpenDataFile";
            toolStripMenuItemOpenDataFile.Size = new Size(224, 26);
            toolStripMenuItemOpenDataFile.Text = "Open Data File";
            toolStripMenuItemOpenDataFile.Click += toolStripMenuItemOpenDataFile_Click;
            // 
            // toolStripMenuSaveDataFile
            // 
            toolStripMenuSaveDataFile.Name = "toolStripMenuSaveDataFile";
            toolStripMenuSaveDataFile.Size = new Size(224, 26);
            toolStripMenuSaveDataFile.Text = "Save Data File";
            toolStripMenuSaveDataFile.Click += toolStripMenuSaveDataFile_Click;
            // 
            // toolStripMenuExit
            // 
            toolStripMenuExit.Name = "toolStripMenuExit";
            toolStripMenuExit.Size = new Size(224, 26);
            toolStripMenuExit.Text = "Exit";
            toolStripMenuExit.Click += toolStripMenuExit_Click;
            // 
            // toolStripMenuHelp
            // 
            toolStripMenuHelp.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuAbout });
            toolStripMenuHelp.Name = "toolStripMenuHelp";
            toolStripMenuHelp.Size = new Size(55, 24);
            toolStripMenuHelp.Text = "Help";
            // 
            // toolStripMenuAbout
            // 
            toolStripMenuAbout.Name = "toolStripMenuAbout";
            toolStripMenuAbout.Size = new Size(133, 26);
            toolStripMenuAbout.Text = "About";
            toolStripMenuAbout.Click += toolStripMenuAbout_Click;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new Point(11, 37);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(78, 20);
            lblDateTime.TabIndex = 1;
            lblDateTime.Text = "Date Time";
            // 
            // dateTimeOfTODO
            // 
            dateTimeOfTODO.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimeOfTODO.Location = new Point(95, 36);
            dateTimeOfTODO.Name = "dateTimeOfTODO";
            dateTimeOfTODO.Size = new Size(368, 27);
            dateTimeOfTODO.TabIndex = 2;
            toolTipDate.SetToolTip(dateTimeOfTODO, "Click to open calender to select date and time");
            // 
            // lblPeriority
            // 
            lblPeriority.AutoSize = true;
            lblPeriority.Location = new Point(494, 40);
            lblPeriority.Name = "lblPeriority";
            lblPeriority.Size = new Size(63, 20);
            lblPeriority.TabIndex = 3;
            lblPeriority.Text = "Periority";
            // 
            // cmbPeriority
            // 
            cmbPeriority.FormattingEnabled = true;
            cmbPeriority.Location = new Point(592, 37);
            cmbPeriority.Name = "cmbPeriority";
            cmbPeriority.Size = new Size(196, 28);
            cmbPeriority.TabIndex = 4;
            // 
            // lblToDO
            // 
            lblToDO.AutoSize = true;
            lblToDO.Location = new Point(13, 73);
            lblToDO.Name = "lblToDO";
            lblToDO.Size = new Size(49, 20);
            lblToDO.TabIndex = 5;
            lblToDO.Text = "To Do";
            // 
            // txtboxToDo
            // 
            txtboxToDo.Location = new Point(95, 72);
            txtboxToDo.Name = "txtboxToDo";
            txtboxToDo.Size = new Size(693, 27);
            txtboxToDo.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImageLayout = ImageLayout.Center;
            btnAdd.Location = new Point(150, 107);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(199, 26);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // grpTodo
            // 
            grpTodo.Controls.Add(lblDisplayCurrenttime);
            grpTodo.Controls.Add(btnDelete);
            grpTodo.Controls.Add(btnChange);
            grpTodo.Controls.Add(lstBoxDisplayToDo);
            grpTodo.Controls.Add(lblPerio);
            grpTodo.Controls.Add(lblDescription);
            grpTodo.Controls.Add(lblHours);
            grpTodo.Controls.Add(lblDate);
            grpTodo.Location = new Point(11, 135);
            grpTodo.Name = "grpTodo";
            grpTodo.Size = new Size(777, 306);
            grpTodo.TabIndex = 8;
            grpTodo.TabStop = false;
            grpTodo.Text = "ToDO List";
            // 
            // lblDisplayCurrenttime
            // 
            lblDisplayCurrenttime.BorderStyle = BorderStyle.FixedSingle;
            lblDisplayCurrenttime.Location = new Point(649, 270);
            lblDisplayCurrenttime.Name = "lblDisplayCurrenttime";
            lblDisplayCurrenttime.Size = new Size(119, 26);
            lblDisplayCurrenttime.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(327, 265);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(165, 31);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(94, 265);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(173, 32);
            btnChange.TabIndex = 5;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // lstBoxDisplayToDo
            // 
            lstBoxDisplayToDo.FormattingEnabled = true;
            lstBoxDisplayToDo.Location = new Point(12, 55);
            lstBoxDisplayToDo.Name = "lstBoxDisplayToDo";
            lstBoxDisplayToDo.Size = new Size(754, 204);
            lstBoxDisplayToDo.TabIndex = 4;
            // 
            // lblPerio
            // 
            lblPerio.AutoSize = true;
            lblPerio.Location = new Point(275, 26);
            lblPerio.Name = "lblPerio";
            lblPerio.Size = new Size(63, 20);
            lblPerio.TabIndex = 3;
            lblPerio.Text = "Periority";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(483, 24);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description";
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Location = new Point(147, 26);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(48, 20);
            lblHours.TabIndex = 1;
            lblHours.Text = "Hours";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(20, 28);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(41, 20);
            lblDate.TabIndex = 0;
            lblDate.Text = "Date";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // btnUpdateOk
            // 
            btnUpdateOk.Location = new Point(390, 107);
            btnUpdateOk.Name = "btnUpdateOk";
            btnUpdateOk.Size = new Size(200, 28);
            btnUpdateOk.TabIndex = 9;
            btnUpdateOk.Text = "Update_Ok";
            btnUpdateOk.UseVisualStyleBackColor = true;
            btnUpdateOk.Click += btnUpdateOk_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdateOk);
            Controls.Add(grpTodo);
            Controls.Add(btnAdd);
            Controls.Add(txtboxToDo);
            Controls.Add(lblToDO);
            Controls.Add(cmbPeriority);
            Controls.Add(lblPeriority);
            Controls.Add(dateTimeOfTODO);
            Controls.Add(lblDateTime);
            Controls.Add(menuFile);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            menuFile.ResumeLayout(false);
            menuFile.PerformLayout();
            grpTodo.ResumeLayout(false);
            grpTodo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuFile;
        private ToolStripMenuItem toolStripMainFile;
        private ToolStripMenuItem toolStripMenuNew;
        private ToolStripMenuItem toolStripMenuItemOpenDataFile;
        private ToolStripMenuItem toolStripMenuSaveDataFile;
        private ToolStripMenuItem toolStripMenuExit;
        private ToolStripMenuItem toolStripMenuHelp;
        private ToolStripMenuItem toolStripMenuAbout;
        private Label lblDateTime;
        private DateTimePicker dateTimeOfTODO;
        private Label lblPeriority;
        private ComboBox cmbPeriority;
        private Label lblToDO;
        private TextBox txtboxToDo;
        private Button btnAdd;
        private GroupBox grpTodo;
        private Label lblPerio;
        private Label lblDescription;
        private Label lblHours;
        private Label lblDate;
        private Button btnDelete;
        private Button btnChange;
        private ListBox lstBoxDisplayToDo;
        private Label lblDisplayCurrenttime;
        private ToolTip toolTipDate;
        private System.Windows.Forms.Timer timer1;
        private Button btnUpdateOk;
    }
}
