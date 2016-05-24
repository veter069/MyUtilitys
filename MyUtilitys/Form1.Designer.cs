namespace MyUtilitys
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutoSave = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnCopyPassword = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnCreatePassword = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPasswordLenght = new System.Windows.Forms.NumericUpDown();
            this.clbPasswordType = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtbNotepad = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbRepetition = new System.Windows.Forms.CheckBox();
            this.btnRandomCopy = new System.Windows.Forms.Button();
            this.btnRandomClear = new System.Windows.Forms.Button();
            this.tbRandom = new System.Windows.Forms.TextBox();
            this.lblRandom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudBefore = new System.Windows.Forms.NumericUpDown();
            this.nudFrom = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnConvert = new System.Windows.Forms.Button();
            this.cbConvertFrom = new System.Windows.Forms.ComboBox();
            this.cbConvertTo = new System.Windows.Forms.ComboBox();
            this.tbConvertFrom = new System.Windows.Forms.TextBox();
            this.tbConvertTo = new System.Windows.Forms.TextBox();
            this.btnSwap = new System.Windows.Forms.Button();
            this.cbMetric = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasswordLenght)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrom)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.notepadToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(92, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInsertDate,
            this.tsmiInsertTime,
            this.toolStripMenuItem1,
            this.tsmiSave,
            this.tsmiLoad,
            this.tsmiAutoSave});
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.notepadToolStripMenuItem.Text = "Notepad";
            // 
            // tsmiInsertDate
            // 
            this.tsmiInsertDate.Name = "tsmiInsertDate";
            this.tsmiInsertDate.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.tsmiInsertDate.Size = new System.Drawing.Size(203, 22);
            this.tsmiInsertDate.Text = "Insert date";
            this.tsmiInsertDate.Click += new System.EventHandler(this.tsmiInsertDate_Click);
            // 
            // tsmiInsertTime
            // 
            this.tsmiInsertTime.Name = "tsmiInsertTime";
            this.tsmiInsertTime.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.tsmiInsertTime.Size = new System.Drawing.Size(203, 22);
            this.tsmiInsertTime.Text = "Insert time";
            this.tsmiInsertTime.Click += new System.EventHandler(this.tsmiInsertTime_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(200, 6);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(203, 22);
            this.tsmiSave.Text = "Save";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiLoad
            // 
            this.tsmiLoad.Name = "tsmiLoad";
            this.tsmiLoad.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.tsmiLoad.Size = new System.Drawing.Size(203, 22);
            this.tsmiLoad.Text = "Load";
            this.tsmiLoad.Click += new System.EventHandler(this.tsmiLoad_Click);
            // 
            // tsmiAutoSave
            // 
            this.tsmiAutoSave.CheckOnClick = true;
            this.tsmiAutoSave.Name = "tsmiAutoSave";
            this.tsmiAutoSave.Size = new System.Drawing.Size(203, 22);
            this.tsmiAutoSave.Text = "AutoSave every 1 min";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(108, 22);
            this.tsmiAbout.Text = "Obout";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(284, 237);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnCopyPassword);
            this.tabPage4.Controls.Add(this.tbPassword);
            this.tabPage4.Controls.Add(this.btnCreatePassword);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.nudPasswordLenght);
            this.tabPage4.Controls.Add(this.clbPasswordType);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(276, 211);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Password";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.Location = new System.Drawing.Point(112, 128);
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.Size = new System.Drawing.Size(75, 23);
            this.btnCopyPassword.TabIndex = 5;
            this.btnCopyPassword.Text = "Copy pass";
            this.btnCopyPassword.UseVisualStyleBackColor = true;
            this.btnCopyPassword.Click += new System.EventHandler(this.btnCopyPassword_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(8, 102);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(260, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // btnCreatePassword
            // 
            this.btnCreatePassword.Location = new System.Drawing.Point(193, 128);
            this.btnCreatePassword.Name = "btnCreatePassword";
            this.btnCreatePassword.Size = new System.Drawing.Size(75, 23);
            this.btnCreatePassword.TabIndex = 3;
            this.btnCreatePassword.Text = "Create pass";
            this.btnCreatePassword.UseVisualStyleBackColor = true;
            this.btnCreatePassword.Click += new System.EventHandler(this.btnCreatePassword_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password lenght";
            // 
            // nudPasswordLenght
            // 
            this.nudPasswordLenght.Location = new System.Drawing.Point(8, 76);
            this.nudPasswordLenght.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nudPasswordLenght.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudPasswordLenght.Name = "nudPasswordLenght";
            this.nudPasswordLenght.Size = new System.Drawing.Size(120, 20);
            this.nudPasswordLenght.TabIndex = 1;
            this.nudPasswordLenght.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // clbPasswordType
            // 
            this.clbPasswordType.CheckOnClick = true;
            this.clbPasswordType.FormattingEnabled = true;
            this.clbPasswordType.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы",
            "Спец. символы %, *, ), ?, #, !, ^, &"});
            this.clbPasswordType.Location = new System.Drawing.Point(6, 6);
            this.clbPasswordType.Name = "clbPasswordType";
            this.clbPasswordType.Size = new System.Drawing.Size(197, 64);
            this.clbPasswordType.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtbNotepad);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(276, 211);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Notepad";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtbNotepad
            // 
            this.rtbNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNotepad.Location = new System.Drawing.Point(3, 3);
            this.rtbNotepad.Name = "rtbNotepad";
            this.rtbNotepad.Size = new System.Drawing.Size(270, 205);
            this.rtbNotepad.TabIndex = 0;
            this.rtbNotepad.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbRepetition);
            this.tabPage2.Controls.Add(this.btnRandomCopy);
            this.tabPage2.Controls.Add(this.btnRandomClear);
            this.tabPage2.Controls.Add(this.tbRandom);
            this.tabPage2.Controls.Add(this.lblRandom);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.nudBefore);
            this.tabPage2.Controls.Add(this.nudFrom);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnRandom);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(276, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Генератор";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbRepetition
            // 
            this.cbRepetition.AutoSize = true;
            this.cbRepetition.Location = new System.Drawing.Point(70, 66);
            this.cbRepetition.Name = "cbRepetition";
            this.cbRepetition.Size = new System.Drawing.Size(86, 17);
            this.cbRepetition.TabIndex = 9;
            this.cbRepetition.Text = "No repetition";
            this.cbRepetition.UseVisualStyleBackColor = true;
            // 
            // btnRandomCopy
            // 
            this.btnRandomCopy.Location = new System.Drawing.Point(75, 118);
            this.btnRandomCopy.Name = "btnRandomCopy";
            this.btnRandomCopy.Size = new System.Drawing.Size(75, 23);
            this.btnRandomCopy.TabIndex = 8;
            this.btnRandomCopy.Text = "Copy";
            this.btnRandomCopy.UseVisualStyleBackColor = true;
            this.btnRandomCopy.Click += new System.EventHandler(this.btnRandomCopy_Click);
            // 
            // btnRandomClear
            // 
            this.btnRandomClear.Location = new System.Drawing.Point(75, 89);
            this.btnRandomClear.Name = "btnRandomClear";
            this.btnRandomClear.Size = new System.Drawing.Size(75, 23);
            this.btnRandomClear.TabIndex = 7;
            this.btnRandomClear.Text = "Clear";
            this.btnRandomClear.UseVisualStyleBackColor = true;
            this.btnRandomClear.Click += new System.EventHandler(this.btnRandomClear_Click);
            // 
            // tbRandom
            // 
            this.tbRandom.Location = new System.Drawing.Point(180, 58);
            this.tbRandom.Multiline = true;
            this.tbRandom.Name = "tbRandom";
            this.tbRandom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRandom.Size = new System.Drawing.Size(75, 145);
            this.tbRandom.TabIndex = 6;
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Location = new System.Drawing.Point(177, 39);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(84, 13);
            this.lblRandom.TabIndex = 5;
            this.lblRandom.Text = "RandomNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Before";
            // 
            // nudBefore
            // 
            this.nudBefore.Location = new System.Drawing.Point(50, 32);
            this.nudBefore.Name = "nudBefore";
            this.nudBefore.Size = new System.Drawing.Size(120, 20);
            this.nudBefore.TabIndex = 3;
            this.nudBefore.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudFrom
            // 
            this.nudFrom.Location = new System.Drawing.Point(50, 6);
            this.nudFrom.Name = "nudFrom";
            this.nudFrom.Size = new System.Drawing.Size(120, 20);
            this.nudFrom.TabIndex = 2;
            this.nudFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(180, 6);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Rand";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblCount);
            this.tabPage1.Controls.Add(this.btnMinus);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.btnPlus);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(276, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Счетчик";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(108, 83);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "0";
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(77, 126);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 23);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(149, 78);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(77, 34);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.cbMetric);
            this.tabPage5.Controls.Add(this.btnSwap);
            this.tabPage5.Controls.Add(this.tbConvertTo);
            this.tabPage5.Controls.Add(this.tbConvertFrom);
            this.tabPage5.Controls.Add(this.cbConvertTo);
            this.tabPage5.Controls.Add(this.cbConvertFrom);
            this.tabPage5.Controls.Add(this.btnConvert);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(276, 211);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Converter";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(98, 73);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // cbConvertFrom
            // 
            this.cbConvertFrom.DisplayMember = "mm";
            this.cbConvertFrom.FormattingEnabled = true;
            this.cbConvertFrom.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cbConvertFrom.Location = new System.Drawing.Point(10, 48);
            this.cbConvertFrom.Name = "cbConvertFrom";
            this.cbConvertFrom.Size = new System.Drawing.Size(82, 21);
            this.cbConvertFrom.TabIndex = 1;
            this.cbConvertFrom.Text = "mm";
            // 
            // cbConvertTo
            // 
            this.cbConvertTo.FormattingEnabled = true;
            this.cbConvertTo.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cbConvertTo.Location = new System.Drawing.Point(179, 48);
            this.cbConvertTo.Name = "cbConvertTo";
            this.cbConvertTo.Size = new System.Drawing.Size(91, 21);
            this.cbConvertTo.TabIndex = 2;
            this.cbConvertTo.Text = "mm";
            // 
            // tbConvertFrom
            // 
            this.tbConvertFrom.Location = new System.Drawing.Point(10, 75);
            this.tbConvertFrom.Name = "tbConvertFrom";
            this.tbConvertFrom.ReadOnly = true;
            this.tbConvertFrom.Size = new System.Drawing.Size(82, 20);
            this.tbConvertFrom.TabIndex = 3;
            this.tbConvertFrom.Text = "1";
            // 
            // tbConvertTo
            // 
            this.tbConvertTo.Location = new System.Drawing.Point(179, 75);
            this.tbConvertTo.Name = "tbConvertTo";
            this.tbConvertTo.ReadOnly = true;
            this.tbConvertTo.Size = new System.Drawing.Size(91, 20);
            this.tbConvertTo.TabIndex = 4;
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(98, 48);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(75, 23);
            this.btnSwap.TabIndex = 5;
            this.btnSwap.Text = "<<-Swap->>";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // cbMetric
            // 
            this.cbMetric.FormattingEnabled = true;
            this.cbMetric.Items.AddRange(new object[] {
            "Length",
            "Weight"});
            this.cbMetric.Location = new System.Drawing.Point(98, 21);
            this.cbMetric.Name = "cbMetric";
            this.cbMetric.Size = new System.Drawing.Size(75, 21);
            this.cbMetric.TabIndex = 6;
            this.cbMetric.Text = "Lenght";
            this.cbMetric.SelectedIndexChanged += new System.EventHandler(this.cbMetric_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "My utilitys";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasswordLenght)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrom)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudBefore;
        private System.Windows.Forms.NumericUpDown nudFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TextBox tbRandom;
        private System.Windows.Forms.Button btnRandomClear;
        private System.Windows.Forms.Button btnRandomCopy;
        private System.Windows.Forms.CheckBox cbRepetition;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertTime;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox rtbNotepad;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoad;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoSave;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckedListBox clbPasswordType;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnCreatePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPasswordLenght;
        private System.Windows.Forms.Button btnCopyPassword;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox tbConvertTo;
        private System.Windows.Forms.TextBox tbConvertFrom;
        private System.Windows.Forms.ComboBox cbConvertTo;
        private System.Windows.Forms.ComboBox cbConvertFrom;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.ComboBox cbMetric;
    }
}

