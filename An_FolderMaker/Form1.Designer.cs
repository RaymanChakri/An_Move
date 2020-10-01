namespace An_FolderMaker
{
	partial class Form1
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.Exit_But = new System.Windows.Forms.Button();
			this.CreatFolders = new System.Windows.Forms.Button();
			this.FoldDerictory = new System.Windows.Forms.TextBox();
			this.lable1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.FoldName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.FoldNume = new System.Windows.Forms.TextBox();
			this.BG = new System.Windows.Forms.CheckBox();
			this.RF = new System.Windows.Forms.CheckBox();
			this.RT = new System.Windows.Forms.CheckBox();
			this.AD = new System.Windows.Forms.CheckBox();
			this.button4 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.AudioName = new System.Windows.Forms.TextBox();
			this.FolList = new System.Windows.Forms.RichTextBox();
			this.FolNumPath = new System.Windows.Forms.Label();
			this.AudNumPath = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.FolNum = new System.Windows.Forms.Label();
			this.CMBar = new System.Windows.Forms.ProgressBar();
			this.OneFolderCheck = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.EmptyFolder = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.showEmptyFoldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.clrearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.FolderNumError = new System.Windows.Forms.Label();
			this.FolderNameError = new System.Windows.Forms.Label();
			this.PathNameError = new System.Windows.Forms.Label();
			this.HideShowList = new System.Windows.Forms.Button();
			this.AudioSubCheck = new System.Windows.Forms.CheckBox();
			this.AudioSubFolder = new System.Windows.Forms.TextBox();
			this.AudioNameError = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(275, 66);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Browse";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Exit_But
			// 
			this.Exit_But.Location = new System.Drawing.Point(257, 603);
			this.Exit_But.Name = "Exit_But";
			this.Exit_But.Size = new System.Drawing.Size(92, 43);
			this.Exit_But.TabIndex = 1;
			this.Exit_But.Text = "Exit";
			this.Exit_But.UseVisualStyleBackColor = true;
			this.Exit_But.Click += new System.EventHandler(this.button2_Click);
			// 
			// CreatFolders
			// 
			this.CreatFolders.Location = new System.Drawing.Point(275, 95);
			this.CreatFolders.Name = "CreatFolders";
			this.CreatFolders.Size = new System.Drawing.Size(75, 76);
			this.CreatFolders.TabIndex = 9;
			this.CreatFolders.Text = "Creat";
			this.CreatFolders.UseVisualStyleBackColor = true;
			this.CreatFolders.Click += new System.EventHandler(this.button3_Click);
			// 
			// FoldDerictory
			// 
			this.FoldDerictory.Location = new System.Drawing.Point(94, 30);
			this.FoldDerictory.Name = "FoldDerictory";
			this.FoldDerictory.Size = new System.Drawing.Size(255, 20);
			this.FoldDerictory.TabIndex = 0;
			this.FoldDerictory.Leave += new System.EventHandler(this.FoldDerictory_Leave);
			// 
			// lable1
			// 
			this.lable1.AutoSize = true;
			this.lable1.Location = new System.Drawing.Point(12, 33);
			this.lable1.Name = "lable1";
			this.lable1.Size = new System.Drawing.Size(49, 13);
			this.lable1.TabIndex = 4;
			this.lable1.Text = "Derictory";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Folder Name";
			// 
			// FoldName
			// 
			this.FoldName.BackColor = System.Drawing.SystemColors.Window;
			this.FoldName.Location = new System.Drawing.Point(94, 69);
			this.FoldName.Name = "FoldName";
			this.FoldName.Size = new System.Drawing.Size(157, 20);
			this.FoldName.TabIndex = 1;
			this.FoldName.Enter += new System.EventHandler(this.FoldName_Enter);
			this.FoldName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FoldName_KeyPress);
			this.FoldName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FoldName_KeyUp);
			this.FoldName.Leave += new System.EventHandler(this.FoldName_Leave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 154);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Folder Number";
			// 
			// FoldNume
			// 
			this.FoldNume.BackColor = System.Drawing.Color.White;
			this.FoldNume.Location = new System.Drawing.Point(94, 151);
			this.FoldNume.Name = "FoldNume";
			this.FoldNume.Size = new System.Drawing.Size(93, 20);
			this.FoldNume.TabIndex = 2;
			this.FoldNume.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FoldNume_KeyDown);
			this.FoldNume.Leave += new System.EventHandler(this.FoldNume_Leave);
			// 
			// BG
			// 
			this.BG.AutoSize = true;
			this.BG.Location = new System.Drawing.Point(34, 131);
			this.BG.Name = "BG";
			this.BG.Size = new System.Drawing.Size(86, 17);
			this.BG.TabIndex = 7;
			this.BG.Text = "BackGround";
			this.BG.UseVisualStyleBackColor = true;
			// 
			// RF
			// 
			this.RF.AutoSize = true;
			this.RF.Location = new System.Drawing.Point(129, 108);
			this.RF.Name = "RF";
			this.RF.Size = new System.Drawing.Size(60, 17);
			this.RF.TabIndex = 6;
			this.RF.Text = "Frames";
			this.RF.UseVisualStyleBackColor = true;
			// 
			// RT
			// 
			this.RT.AutoSize = true;
			this.RT.Location = new System.Drawing.Point(129, 131);
			this.RT.Name = "RT";
			this.RT.Size = new System.Drawing.Size(49, 17);
			this.RT.TabIndex = 8;
			this.RT.Text = "Roth";
			this.RT.UseVisualStyleBackColor = true;
			// 
			// AD
			// 
			this.AD.AutoSize = true;
			this.AD.Location = new System.Drawing.Point(34, 108);
			this.AD.Name = "AD";
			this.AD.Size = new System.Drawing.Size(53, 17);
			this.AD.TabIndex = 5;
			this.AD.Text = "Audio";
			this.AD.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(274, 203);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 36);
			this.button4.TabIndex = 10;
			this.button4.Text = "Move_Audio";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 206);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 13);
			this.label4.TabIndex = 18;
			this.label4.Text = "Audio Name";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// AudioName
			// 
			this.AudioName.BackColor = System.Drawing.SystemColors.Window;
			this.AudioName.Location = new System.Drawing.Point(93, 203);
			this.AudioName.Name = "AudioName";
			this.AudioName.Size = new System.Drawing.Size(155, 20);
			this.AudioName.TabIndex = 4;
			this.AudioName.TextChanged += new System.EventHandler(this.AudioName_TextChanged);
			this.AudioName.Enter += new System.EventHandler(this.AudioName_Enter);
			this.AudioName.Leave += new System.EventHandler(this.AudioName_Leave);
			// 
			// FolList
			// 
			this.FolList.Location = new System.Drawing.Point(14, 321);
			this.FolList.Name = "FolList";
			this.FolList.Size = new System.Drawing.Size(337, 266);
			this.FolList.TabIndex = 19;
			this.FolList.Text = "";
			this.FolList.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// FolNumPath
			// 
			this.FolNumPath.AutoSize = true;
			this.FolNumPath.Location = new System.Drawing.Point(83, 633);
			this.FolNumPath.Name = "FolNumPath";
			this.FolNumPath.Size = new System.Drawing.Size(35, 13);
			this.FolNumPath.TabIndex = 21;
			this.FolNumPath.Text = "label6";
			this.FolNumPath.Click += new System.EventHandler(this.FolNumPath_Click);
			// 
			// AudNumPath
			// 
			this.AudNumPath.AutoSize = true;
			this.AudNumPath.Location = new System.Drawing.Point(84, 603);
			this.AudNumPath.Name = "AudNumPath";
			this.AudNumPath.Size = new System.Drawing.Size(35, 13);
			this.AudNumPath.TabIndex = 22;
			this.AudNumPath.Text = "label7";
			this.AudNumPath.Click += new System.EventHandler(this.AudNumPath_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(118, 603);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(9, 13);
			this.label8.TabIndex = 23;
			this.label8.Text = "|";
			// 
			// FolNum
			// 
			this.FolNum.AutoSize = true;
			this.FolNum.Location = new System.Drawing.Point(216, 603);
			this.FolNum.Name = "FolNum";
			this.FolNum.Size = new System.Drawing.Size(35, 13);
			this.FolNum.TabIndex = 24;
			this.FolNum.Text = "label9";
			this.FolNum.Click += new System.EventHandler(this.FolNum_Click);
			// 
			// CMBar
			// 
			this.CMBar.Location = new System.Drawing.Point(14, 262);
			this.CMBar.Name = "CMBar";
			this.CMBar.Size = new System.Drawing.Size(335, 22);
			this.CMBar.TabIndex = 25;
			this.CMBar.Click += new System.EventHandler(this.progressBar1_Click);
			// 
			// OneFolderCheck
			// 
			this.OneFolderCheck.AutoSize = true;
			this.OneFolderCheck.Location = new System.Drawing.Point(193, 151);
			this.OneFolderCheck.Name = "OneFolderCheck";
			this.OneFolderCheck.Size = new System.Drawing.Size(78, 17);
			this.OneFolderCheck.TabIndex = 26;
			this.OneFolderCheck.Text = "One Folder";
			this.OneFolderCheck.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(14, 246);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(340, 13);
			this.label5.TabIndex = 27;
			this.label5.Text = "---------------------------------------------------------------------------------" +
    "------------------------------";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 187);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(340, 13);
			this.label1.TabIndex = 28;
			this.label1.Text = "---------------------------------------------------------------------------------" +
    "------------------------------";
			// 
			// EmptyFolder
			// 
			this.EmptyFolder.AutoSize = true;
			this.EmptyFolder.Location = new System.Drawing.Point(216, 633);
			this.EmptyFolder.Name = "EmptyFolder";
			this.EmptyFolder.Size = new System.Drawing.Size(35, 13);
			this.EmptyFolder.TabIndex = 30;
			this.EmptyFolder.Text = "label9";
			this.EmptyFolder.Click += new System.EventHandler(this.EmptyFolder_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 603);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 13);
			this.label6.TabIndex = 32;
			this.label6.Text = "Audio Rep :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 633);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 13);
			this.label7.TabIndex = 33;
			this.label7.Text = "Folder Rep :";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(361, 24);
			this.menuStrip1.TabIndex = 34;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.loadToolStripMenuItem.Text = "Load";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator2,
            this.showEmptyFoldersToolStripMenuItem,
            this.deToolStripMenuItem,
            this.toolStripSeparator3,
            this.clrearToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// undoToolStripMenuItem
			// 
			this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
			this.undoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.undoToolStripMenuItem.Text = "Undo";
			// 
			// redoToolStripMenuItem
			// 
			this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
			this.redoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.redoToolStripMenuItem.Text = "Redo";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
			// 
			// showEmptyFoldersToolStripMenuItem
			// 
			this.showEmptyFoldersToolStripMenuItem.Name = "showEmptyFoldersToolStripMenuItem";
			this.showEmptyFoldersToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.showEmptyFoldersToolStripMenuItem.Text = "Show Empty Folders";
			// 
			// deToolStripMenuItem
			// 
			this.deToolStripMenuItem.Name = "deToolStripMenuItem";
			this.deToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.deToolStripMenuItem.Text = "Delet Empty Folders";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
			// 
			// clrearToolStripMenuItem
			// 
			this.clrearToolStripMenuItem.Name = "clrearToolStripMenuItem";
			this.clrearToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.clrearToolStripMenuItem.Text = "Clrear";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(131, 603);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(42, 13);
			this.label9.TabIndex = 35;
			this.label9.Text = "Folder :";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(131, 633);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(74, 13);
			this.label10.TabIndex = 36;
			this.label10.Text = "Empty Folder :";
			// 
			// FolderNumError
			// 
			this.FolderNumError.AutoSize = true;
			this.FolderNumError.Location = new System.Drawing.Point(91, 174);
			this.FolderNumError.Name = "FolderNumError";
			this.FolderNumError.Size = new System.Drawing.Size(131, 13);
			this.FolderNumError.TabIndex = 38;
			this.FolderNumError.Text = "Folder number  not correct";
			// 
			// FolderNameError
			// 
			this.FolderNameError.AutoSize = true;
			this.FolderNameError.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FolderNameError.Location = new System.Drawing.Point(91, 92);
			this.FolderNameError.Name = "FolderNameError";
			this.FolderNameError.Size = new System.Drawing.Size(119, 13);
			this.FolderNameError.TabIndex = 39;
			this.FolderNameError.Text = "Folder name not correct";
			// 
			// PathNameError
			// 
			this.PathNameError.AutoSize = true;
			this.PathNameError.Location = new System.Drawing.Point(91, 53);
			this.PathNameError.Name = "PathNameError";
			this.PathNameError.Size = new System.Drawing.Size(86, 13);
			this.PathNameError.TabIndex = 40;
			this.PathNameError.Text = "Path Not Correct";
			this.PathNameError.Click += new System.EventHandler(this.label14_Click);
			// 
			// HideShowList
			// 
			this.HideShowList.Location = new System.Drawing.Point(14, 290);
			this.HideShowList.Name = "HideShowList";
			this.HideShowList.Size = new System.Drawing.Size(75, 25);
			this.HideShowList.TabIndex = 41;
			this.HideShowList.Text = "Haid";
			this.HideShowList.UseVisualStyleBackColor = true;
			this.HideShowList.Click += new System.EventHandler(this.button3_Click_1);
			// 
			// AudioSubCheck
			// 
			this.AudioSubCheck.AutoSize = true;
			this.AudioSubCheck.Location = new System.Drawing.Point(108, 229);
			this.AudioSubCheck.Name = "AudioSubCheck";
			this.AudioSubCheck.Size = new System.Drawing.Size(15, 14);
			this.AudioSubCheck.TabIndex = 42;
			this.AudioSubCheck.UseVisualStyleBackColor = true;
			this.AudioSubCheck.CheckedChanged += new System.EventHandler(this.AudioSubCheck_CheckedChanged);
			// 
			// AudioSubFolder
			// 
			this.AudioSubFolder.Location = new System.Drawing.Point(129, 226);
			this.AudioSubFolder.Name = "AudioSubFolder";
			this.AudioSubFolder.Size = new System.Drawing.Size(119, 20);
			this.AudioSubFolder.TabIndex = 43;
			this.AudioSubFolder.Enter += new System.EventHandler(this.AudioSubFolder_Enter);
			this.AudioSubFolder.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AudioSubFolder_KeyUp);
			this.AudioSubFolder.Leave += new System.EventHandler(this.AudioSubFolder_Leave);
			// 
			// AudioNameError
			// 
			this.AudioNameError.AutoSize = true;
			this.AudioNameError.Location = new System.Drawing.Point(93, 246);
			this.AudioNameError.Name = "AudioNameError";
			this.AudioNameError.Size = new System.Drawing.Size(117, 13);
			this.AudioNameError.TabIndex = 44;
			this.AudioNameError.Text = "Audio name not correct";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(361, 658);
			this.Controls.Add(this.AudioNameError);
			this.Controls.Add(this.AudioSubFolder);
			this.Controls.Add(this.AudioSubCheck);
			this.Controls.Add(this.HideShowList);
			this.Controls.Add(this.PathNameError);
			this.Controls.Add(this.FolderNameError);
			this.Controls.Add(this.FolderNumError);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.EmptyFolder);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.OneFolderCheck);
			this.Controls.Add(this.CMBar);
			this.Controls.Add(this.FolNum);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.AudNumPath);
			this.Controls.Add(this.FolNumPath);
			this.Controls.Add(this.FolList);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.AudioName);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.AD);
			this.Controls.Add(this.RT);
			this.Controls.Add(this.RF);
			this.Controls.Add(this.BG);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.FoldNume);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.FoldName);
			this.Controls.Add(this.lable1);
			this.Controls.Add(this.FoldDerictory);
			this.Controls.Add(this.CreatFolders);
			this.Controls.Add(this.Exit_But);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.HelpButton = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "An Folder Maker";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button Exit_But;
		private System.Windows.Forms.Button CreatFolders;
		private System.Windows.Forms.TextBox FoldDerictory;
		private System.Windows.Forms.Label lable1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox FoldName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox FoldNume;
		private System.Windows.Forms.CheckBox BG;
		private System.Windows.Forms.CheckBox RF;
		private System.Windows.Forms.CheckBox RT;
		private System.Windows.Forms.CheckBox AD;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox AudioName;
		private System.Windows.Forms.RichTextBox FolList;
		private System.Windows.Forms.Label FolNumPath;
		private System.Windows.Forms.Label AudNumPath;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label FolNum;
		private System.Windows.Forms.ProgressBar CMBar;
		private System.Windows.Forms.CheckBox OneFolderCheck;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label EmptyFolder;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clrearToolStripMenuItem;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label FolderNumError;
		private System.Windows.Forms.Label FolderNameError;
		private System.Windows.Forms.Label PathNameError;
		private System.Windows.Forms.Button HideShowList;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.CheckBox AudioSubCheck;
		private System.Windows.Forms.TextBox AudioSubFolder;
		private System.Windows.Forms.Label AudioNameError;
		private System.Windows.Forms.ToolStripMenuItem showEmptyFoldersToolStripMenuItem;
	}
}

