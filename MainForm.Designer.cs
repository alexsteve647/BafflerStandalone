namespace BafflerStandalone
{
	public partial class MainForm : global::System.Windows.Forms.Form, global::System.Windows.Forms.IMessageFilter
	{
		private global::System.ComponentModel.IContainer components;
		private global::System.Windows.Forms.TextBox tbAutoJoin;
		private global::System.Windows.Forms.Label label1;
		private global::System.Windows.Forms.Panel panel1;
		private global::System.Windows.Forms.Button button1;
		private global::System.Windows.Forms.MenuStrip menuStrip1;
		private global::System.Windows.Forms.Label lbScreenShot;
		private global::System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private global::System.Windows.Forms.Timer timer_ScreenshotLabel;
		private global::System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private global::System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private global::System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private global::System.Windows.Forms.ToolStripMenuItem english1ToolStripMenuItem;
		private global::System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
		private global::System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private global::System.Windows.Forms.ToolStripMenuItem qualityToolStripMenuItem;
		private global::System.Windows.Forms.ToolStripMenuItem lowToolStripMenuItem;
		private global::System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
		private global::System.Windows.Forms.ToolStripMenuItem highToolStripMenuItem;
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private global::System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private global::System.Windows.Forms.ToolStripMenuItem fullscreenToolStripMenuItem;
		private global::System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private global::System.Windows.Forms.ToolStrip toolStrip1;
		private global::System.Windows.Forms.Timer timer1;
		private global::System.Windows.Forms.Button button2;
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private global::System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem1;
		private global::System.Windows.Forms.ToolStripMenuItem english1ToolStripMenuItem2;
		private global::System.Windows.Forms.ToolStripMenuItem english2ToolStripMenuItem2;
		private global::System.Windows.Forms.ToolStripMenuItem kongToolStripMenuItem2;
		private global::System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem2;
		private global::System.Windows.Forms.ToolStripMenuItem russianToolStripMenuItem2;
		private global::System.Windows.Forms.ToolStripMenuItem turkishToolStripMenuItem2;
		private global::System.Windows.Forms.ToolStripMenuItem brazil1ToolStripMenuItem2;
		private global::System.Windows.Forms.ToolStripMenuItem brazil2ToolStripMenuItem2;
		private global::System.Windows.Forms.ToolStripMenuItem brazil3ToolStripMenuItem2;
		private global::System.Windows.Forms.ToolStripMenuItem brazil4ToolStripMenuItem2;
		private global::System.Windows.Forms.ToolStripMenuItem chineseToolStripMenuItem2;
		private global::System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem2;
		private global::System.Windows.Forms.ToolStripMenuItem thisTabToolStripMenuItem1;
		private global::System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
		private global::System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem1;
		private global::System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
		private global::System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem1;
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
		private global::System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
		private global::System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem1;
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
		private global::System.Windows.Forms.ToolStripMenuItem qualityToolStripMenuItem1;
		private global::System.Windows.Forms.ToolStripMenuItem lowToolStripMenuItem1;
		private global::System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem1;
		private global::System.Windows.Forms.ToolStripMenuItem highToolStripMenuItem1;
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
		private global::System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
		private global::System.Windows.Forms.ToolStripMenuItem fullscreenToolStripMenuItem1;
		private global::System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
		private global::System.Windows.Forms.ToolStripMenuItem english1ToolStripMenuItem3;
		private global::System.Windows.Forms.ToolStripMenuItem english2ToolStripMenuItem3;
		private global::System.Windows.Forms.ToolStripMenuItem kongToolStripMenuItem3;
		private global::System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem3;
		private global::System.Windows.Forms.ToolStripMenuItem russianToolStripMenuItem3;
		private global::System.Windows.Forms.ToolStripMenuItem turkishToolStripMenuItem3;
		private global::System.Windows.Forms.ToolStripMenuItem brazil1ToolStripMenuItem3;
		private global::System.Windows.Forms.ToolStripMenuItem brazil2ToolStripMenuItem3;
		private global::System.Windows.Forms.ToolStripMenuItem brazil3ToolStripMenuItem3;
		private global::System.Windows.Forms.ToolStripMenuItem brazil4ToolStripMenuItem3;
		private global::System.Windows.Forms.ToolStripMenuItem chineseToolStripMenuItem3;
		private global::System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem3;
		private global::System.Windows.Forms.Button button4;
		private global::System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem2;
		private global::System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem2;
		private global::System.Windows.Forms.ToolStripMenuItem closeTabToolStripMenuItem;
		private global::System.Windows.Forms.ToolStripMenuItem hideMenuToolStripMenuItem;
		private global::System.Windows.Forms.ToolStripMenuItem alignmentToolStripMenuItem;
		private global::System.Windows.Forms.WebBrowser webBrowser1;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.tbAutoJoin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.english1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alignmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.qualityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.hideMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbScreenShot = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer_ScreenshotLabel = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newTabToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.english1ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.english2ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.kongToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.turkishToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.brazil1ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.brazil2ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.brazil3ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.brazil4ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.chineseToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.thisTabToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.serverToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.english1ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.english2ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.kongToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.turkishToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.brazil1ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.brazil2ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.brazil3ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.brazil4ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.chineseToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.qualityToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.highToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fullscreenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAutoJoin
            // 
            this.tbAutoJoin.Location = new System.Drawing.Point(340, 27);
            this.tbAutoJoin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAutoJoin.Name = "tbAutoJoin";
            this.tbAutoJoin.Size = new System.Drawing.Size(279, 22);
            this.tbAutoJoin.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(336, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Automatically join this room on connect: ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbAutoJoin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 689);
            this.panel1.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowNavigation = false;
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(11, 60);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1023, 613);
            this.webBrowser1.TabIndex = 16;
            this.webBrowser1.TabStop = false;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(11, 12);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 41);
            this.button4.TabIndex = 1;
            this.button4.Text = "Play Now";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(771, 21);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Connect Other";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(933, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Options";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(70, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabToolStripMenuItem,
            this.toolStripMenuItem2,
            this.viewToolStripMenuItem,
            this.refreshToolStripMenuItem2,
            this.renameToolStripMenuItem2,
            this.closeTabToolStripMenuItem,
            this.toolStripMenuItem5,
            this.hideMenuToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.fullscreenToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.english1ToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.newTabToolStripMenuItem.Text = "New Tab";
            // 
            // english1ToolStripMenuItem
            // 
            this.english1ToolStripMenuItem.Name = "english1ToolStripMenuItem";
            this.english1ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.english1ToolStripMenuItem.Text = "Transformice";
            this.english1ToolStripMenuItem.Click += new System.EventHandler(this.English1ToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.otherToolStripMenuItem.Text = "Other";
            this.otherToolStripMenuItem.Click += new System.EventHandler(this.OtherToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(161, 6);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.showAllToolStripMenuItem,
            this.alignmentToolStripMenuItem,
            this.toolStripMenuItem3,
            this.qualityToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(160, 26);
            this.toolStripMenuItem4.Text = "100%";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.ToolStripMenuItem4_Click);
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.showAllToolStripMenuItem.Text = "Show All";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.ShowAllToolStripMenuItem_Click);
            // 
            // alignmentToolStripMenuItem
            // 
            this.alignmentToolStripMenuItem.Name = "alignmentToolStripMenuItem";
            this.alignmentToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.alignmentToolStripMenuItem.Text = "Alignment";
            this.alignmentToolStripMenuItem.Click += new System.EventHandler(this.AlignmentToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(157, 6);
            // 
            // qualityToolStripMenuItem
            // 
            this.qualityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.highToolStripMenuItem});
            this.qualityToolStripMenuItem.Name = "qualityToolStripMenuItem";
            this.qualityToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.qualityToolStripMenuItem.Text = "Quality";
            // 
            // lowToolStripMenuItem
            // 
            this.lowToolStripMenuItem.Name = "lowToolStripMenuItem";
            this.lowToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.lowToolStripMenuItem.Text = "Low";
            this.lowToolStripMenuItem.Click += new System.EventHandler(this.LowToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.MediumToolStripMenuItem_Click);
            // 
            // highToolStripMenuItem
            // 
            this.highToolStripMenuItem.Name = "highToolStripMenuItem";
            this.highToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.highToolStripMenuItem.Text = "High";
            this.highToolStripMenuItem.Click += new System.EventHandler(this.HighToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem2
            // 
            this.refreshToolStripMenuItem2.Name = "refreshToolStripMenuItem2";
            this.refreshToolStripMenuItem2.Size = new System.Drawing.Size(164, 26);
            this.refreshToolStripMenuItem2.Text = "Refresh";
            this.refreshToolStripMenuItem2.Click += new System.EventHandler(this.RefreshToolStripMenuItem2_Click);
            // 
            // renameToolStripMenuItem2
            // 
            this.renameToolStripMenuItem2.Name = "renameToolStripMenuItem2";
            this.renameToolStripMenuItem2.Size = new System.Drawing.Size(164, 26);
            this.renameToolStripMenuItem2.Text = "Rename";
            this.renameToolStripMenuItem2.Click += new System.EventHandler(this.RenameToolStripMenuItem2_Click);
            // 
            // closeTabToolStripMenuItem
            // 
            this.closeTabToolStripMenuItem.Name = "closeTabToolStripMenuItem";
            this.closeTabToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.closeTabToolStripMenuItem.Text = "Close Tab";
            this.closeTabToolStripMenuItem.Click += new System.EventHandler(this.CloseTabToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(161, 6);
            // 
            // hideMenuToolStripMenuItem
            // 
            this.hideMenuToolStripMenuItem.Name = "hideMenuToolStripMenuItem";
            this.hideMenuToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.hideMenuToolStripMenuItem.Text = "Hide Menu";
            this.hideMenuToolStripMenuItem.Click += new System.EventHandler(this.HideMenuToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItem_Click);
            // 
            // fullscreenToolStripMenuItem
            // 
            this.fullscreenToolStripMenuItem.Name = "fullscreenToolStripMenuItem";
            this.fullscreenToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.fullscreenToolStripMenuItem.Text = "Fullscreen";
            this.fullscreenToolStripMenuItem.Click += new System.EventHandler(this.FullscreenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // lbScreenShot
            // 
            this.lbScreenShot.AutoSize = true;
            this.lbScreenShot.ForeColor = System.Drawing.Color.White;
            this.lbScreenShot.Location = new System.Drawing.Point(17, 34);
            this.lbScreenShot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbScreenShot.Name = "lbScreenShot";
            this.lbScreenShot.Size = new System.Drawing.Size(73, 16);
            this.lbScreenShot.TabIndex = 11;
            this.lbScreenShot.Text = "screenshot";
            this.lbScreenShot.Visible = false;
            // 
            // timer_ScreenshotLabel
            // 
            this.timer_ScreenshotLabel.Interval = 1000;
            this.timer_ScreenshotLabel.Tick += new System.EventHandler(this.Timer_ScreenshotLabel_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.toolStrip1.Location = new System.Drawing.Point(216, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(112, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 15000;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabToolStripMenuItem1,
            this.thisTabToolStripMenuItem1,
            this.toolStripMenuItem6,
            this.viewToolStripMenuItem1,
            this.toolStripMenuItem7,
            this.optionsToolStripMenuItem1,
            this.fullscreenToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 160);
            // 
            // newTabToolStripMenuItem1
            // 
            this.newTabToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.english1ToolStripMenuItem2,
            this.english2ToolStripMenuItem2,
            this.kongToolStripMenuItem2,
            this.frenchToolStripMenuItem2,
            this.russianToolStripMenuItem2,
            this.turkishToolStripMenuItem2,
            this.brazil1ToolStripMenuItem2,
            this.brazil2ToolStripMenuItem2,
            this.brazil3ToolStripMenuItem2,
            this.brazil4ToolStripMenuItem2,
            this.chineseToolStripMenuItem2,
            this.otherToolStripMenuItem2});
            this.newTabToolStripMenuItem1.Name = "newTabToolStripMenuItem1";
            this.newTabToolStripMenuItem1.Size = new System.Drawing.Size(143, 24);
            this.newTabToolStripMenuItem1.Text = "New Tab";
            // 
            // english1ToolStripMenuItem2
            // 
            this.english1ToolStripMenuItem2.Name = "english1ToolStripMenuItem2";
            this.english1ToolStripMenuItem2.Size = new System.Drawing.Size(160, 26);
            this.english1ToolStripMenuItem2.Text = "English (1)";
            this.english1ToolStripMenuItem2.Click += new System.EventHandler(this.English1ToolStripMenuItem_Click);
            // 
            // english2ToolStripMenuItem2
            // 
            this.english2ToolStripMenuItem2.Name = "english2ToolStripMenuItem2";
            this.english2ToolStripMenuItem2.Size = new System.Drawing.Size(160, 26);
            this.english2ToolStripMenuItem2.Text = "English (2)";
            this.english2ToolStripMenuItem2.Click += new System.EventHandler(this.English2ToolStripMenuItem_Click);
            // 
            // kongToolStripMenuItem2
            // 
            this.kongToolStripMenuItem2.Name = "kongToolStripMenuItem2";
            this.kongToolStripMenuItem2.Size = new System.Drawing.Size(160, 26);
            this.kongToolStripMenuItem2.Text = "Kong";
            this.kongToolStripMenuItem2.Click += new System.EventHandler(this.KongToolStripMenuItem_Click);
            // 
            // frenchToolStripMenuItem2
            // 
            this.frenchToolStripMenuItem2.Name = "frenchToolStripMenuItem2";
            this.frenchToolStripMenuItem2.Size = new System.Drawing.Size(160, 26);
            this.frenchToolStripMenuItem2.Text = "French";
            this.frenchToolStripMenuItem2.Click += new System.EventHandler(this.FrenchToolStripMenuItem_Click);
            // 
            // russianToolStripMenuItem2
            // 
            this.russianToolStripMenuItem2.Name = "russianToolStripMenuItem2";
            this.russianToolStripMenuItem2.Size = new System.Drawing.Size(160, 26);
            this.russianToolStripMenuItem2.Text = "Russian";
            this.russianToolStripMenuItem2.Click += new System.EventHandler(this.RussianToolStripMenuItem_Click);
            // 
            // turkishToolStripMenuItem2
            // 
            this.turkishToolStripMenuItem2.Name = "turkishToolStripMenuItem2";
            this.turkishToolStripMenuItem2.Size = new System.Drawing.Size(160, 26);
            this.turkishToolStripMenuItem2.Text = "Turkish";
            this.turkishToolStripMenuItem2.Click += new System.EventHandler(this.TurkishToolStripMenuItem_Click);
            // 
            // brazil1ToolStripMenuItem2
            // 
            this.brazil1ToolStripMenuItem2.Name = "brazil1ToolStripMenuItem2";
            this.brazil1ToolStripMenuItem2.Size = new System.Drawing.Size(160, 26);
            this.brazil1ToolStripMenuItem2.Text = "Brazil (1)";
            this.brazil1ToolStripMenuItem2.Click += new System.EventHandler(this.Brazil1ToolStripMenuItem_Click);
            // 
            // brazil2ToolStripMenuItem2
            // 
            this.brazil2ToolStripMenuItem2.Name = "brazil2ToolStripMenuItem2";
            this.brazil2ToolStripMenuItem2.Size = new System.Drawing.Size(160, 26);
            this.brazil2ToolStripMenuItem2.Text = "Brazil (2)";
            this.brazil2ToolStripMenuItem2.Click += new System.EventHandler(this.Brazil2ToolStripMenuItem_Click);
            // 
            // brazil3ToolStripMenuItem2
            // 
            this.brazil3ToolStripMenuItem2.Name = "brazil3ToolStripMenuItem2";
            this.brazil3ToolStripMenuItem2.Size = new System.Drawing.Size(160, 26);
            this.brazil3ToolStripMenuItem2.Text = "Brazil (3)";
            this.brazil3ToolStripMenuItem2.Click += new System.EventHandler(this.Brazil3ToolStripMenuItem_Click);
            // 
            // brazil4ToolStripMenuItem2
            // 
            this.brazil4ToolStripMenuItem2.Name = "brazil4ToolStripMenuItem2";
            this.brazil4ToolStripMenuItem2.Size = new System.Drawing.Size(160, 26);
            this.brazil4ToolStripMenuItem2.Text = "Brazil (4)";
            this.brazil4ToolStripMenuItem2.Click += new System.EventHandler(this.Brazil4ToolStripMenuItem_Click);
            // 
            // chineseToolStripMenuItem2
            // 
            this.chineseToolStripMenuItem2.Name = "chineseToolStripMenuItem2";
            this.chineseToolStripMenuItem2.Size = new System.Drawing.Size(160, 26);
            this.chineseToolStripMenuItem2.Text = "Chinese";
            this.chineseToolStripMenuItem2.Click += new System.EventHandler(this.ChineseToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem2
            // 
            this.otherToolStripMenuItem2.Name = "otherToolStripMenuItem2";
            this.otherToolStripMenuItem2.Size = new System.Drawing.Size(160, 26);
            this.otherToolStripMenuItem2.Text = "Other";
            this.otherToolStripMenuItem2.Click += new System.EventHandler(this.OtherToolStripMenuItem_Click);
            // 
            // thisTabToolStripMenuItem1
            // 
            this.thisTabToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem1,
            this.renameToolStripMenuItem1,
            this.closeToolStripMenuItem1,
            this.toolStripMenuItem8,
            this.serverToolStripMenuItem1});
            this.thisTabToolStripMenuItem1.Name = "thisTabToolStripMenuItem1";
            this.thisTabToolStripMenuItem1.Size = new System.Drawing.Size(143, 24);
            this.thisTabToolStripMenuItem1.Text = "This Tab";
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(145, 26);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            // 
            // renameToolStripMenuItem1
            // 
            this.renameToolStripMenuItem1.Name = "renameToolStripMenuItem1";
            this.renameToolStripMenuItem1.Size = new System.Drawing.Size(145, 26);
            this.renameToolStripMenuItem1.Text = "Rename";
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(145, 26);
            this.closeToolStripMenuItem1.Text = "Close";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(142, 6);
            // 
            // serverToolStripMenuItem1
            // 
            this.serverToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.english1ToolStripMenuItem3,
            this.english2ToolStripMenuItem3,
            this.kongToolStripMenuItem3,
            this.frenchToolStripMenuItem3,
            this.russianToolStripMenuItem3,
            this.turkishToolStripMenuItem3,
            this.brazil1ToolStripMenuItem3,
            this.brazil2ToolStripMenuItem3,
            this.brazil3ToolStripMenuItem3,
            this.brazil4ToolStripMenuItem3,
            this.chineseToolStripMenuItem3,
            this.otherToolStripMenuItem3});
            this.serverToolStripMenuItem1.Name = "serverToolStripMenuItem1";
            this.serverToolStripMenuItem1.Size = new System.Drawing.Size(145, 26);
            this.serverToolStripMenuItem1.Text = "Server";
            // 
            // english1ToolStripMenuItem3
            // 
            this.english1ToolStripMenuItem3.Name = "english1ToolStripMenuItem3";
            this.english1ToolStripMenuItem3.Size = new System.Drawing.Size(160, 26);
            this.english1ToolStripMenuItem3.Text = "English (1)";
            this.english1ToolStripMenuItem3.Click += new System.EventHandler(this.English1ToolStripMenuItem1_Click);
            // 
            // english2ToolStripMenuItem3
            // 
            this.english2ToolStripMenuItem3.Name = "english2ToolStripMenuItem3";
            this.english2ToolStripMenuItem3.Size = new System.Drawing.Size(160, 26);
            this.english2ToolStripMenuItem3.Text = "English (2)";
            this.english2ToolStripMenuItem3.Click += new System.EventHandler(this.English2ToolStripMenuItem1_Click);
            // 
            // kongToolStripMenuItem3
            // 
            this.kongToolStripMenuItem3.Name = "kongToolStripMenuItem3";
            this.kongToolStripMenuItem3.Size = new System.Drawing.Size(160, 26);
            this.kongToolStripMenuItem3.Text = "Kong";
            this.kongToolStripMenuItem3.Click += new System.EventHandler(this.KongToolStripMenuItem1_Click);
            // 
            // frenchToolStripMenuItem3
            // 
            this.frenchToolStripMenuItem3.Name = "frenchToolStripMenuItem3";
            this.frenchToolStripMenuItem3.Size = new System.Drawing.Size(160, 26);
            this.frenchToolStripMenuItem3.Text = "French";
            this.frenchToolStripMenuItem3.Click += new System.EventHandler(this.FrenchToolStripMenuItem1_Click);
            // 
            // russianToolStripMenuItem3
            // 
            this.russianToolStripMenuItem3.Name = "russianToolStripMenuItem3";
            this.russianToolStripMenuItem3.Size = new System.Drawing.Size(160, 26);
            this.russianToolStripMenuItem3.Text = "Russian";
            this.russianToolStripMenuItem3.Click += new System.EventHandler(this.RussianToolStripMenuItem1_Click);
            // 
            // turkishToolStripMenuItem3
            // 
            this.turkishToolStripMenuItem3.Name = "turkishToolStripMenuItem3";
            this.turkishToolStripMenuItem3.Size = new System.Drawing.Size(160, 26);
            this.turkishToolStripMenuItem3.Text = "Turkish";
            this.turkishToolStripMenuItem3.Click += new System.EventHandler(this.TurkishToolStripMenuItem1_Click);
            // 
            // brazil1ToolStripMenuItem3
            // 
            this.brazil1ToolStripMenuItem3.Name = "brazil1ToolStripMenuItem3";
            this.brazil1ToolStripMenuItem3.Size = new System.Drawing.Size(160, 26);
            this.brazil1ToolStripMenuItem3.Text = "Brazil (1)";
            this.brazil1ToolStripMenuItem3.Click += new System.EventHandler(this.Brazil1ToolStripMenuItem1_Click);
            // 
            // brazil2ToolStripMenuItem3
            // 
            this.brazil2ToolStripMenuItem3.Name = "brazil2ToolStripMenuItem3";
            this.brazil2ToolStripMenuItem3.Size = new System.Drawing.Size(160, 26);
            this.brazil2ToolStripMenuItem3.Text = "Brazil (2)";
            this.brazil2ToolStripMenuItem3.Click += new System.EventHandler(this.Brazil2ToolStripMenuItem1_Click);
            // 
            // brazil3ToolStripMenuItem3
            // 
            this.brazil3ToolStripMenuItem3.Name = "brazil3ToolStripMenuItem3";
            this.brazil3ToolStripMenuItem3.Size = new System.Drawing.Size(160, 26);
            this.brazil3ToolStripMenuItem3.Text = "Brazil (3)";
            this.brazil3ToolStripMenuItem3.Click += new System.EventHandler(this.Brazil3ToolStripMenuItem1_Click);
            // 
            // brazil4ToolStripMenuItem3
            // 
            this.brazil4ToolStripMenuItem3.Name = "brazil4ToolStripMenuItem3";
            this.brazil4ToolStripMenuItem3.Size = new System.Drawing.Size(160, 26);
            this.brazil4ToolStripMenuItem3.Text = "Brazil (4)";
            this.brazil4ToolStripMenuItem3.Click += new System.EventHandler(this.Brazil4ToolStripMenuItem1_Click);
            // 
            // chineseToolStripMenuItem3
            // 
            this.chineseToolStripMenuItem3.Name = "chineseToolStripMenuItem3";
            this.chineseToolStripMenuItem3.Size = new System.Drawing.Size(160, 26);
            this.chineseToolStripMenuItem3.Text = "Chinese";
            this.chineseToolStripMenuItem3.Click += new System.EventHandler(this.ChineseToolStripMenuItem1_Click);
            // 
            // otherToolStripMenuItem3
            // 
            this.otherToolStripMenuItem3.Name = "otherToolStripMenuItem3";
            this.otherToolStripMenuItem3.Size = new System.Drawing.Size(160, 26);
            this.otherToolStripMenuItem3.Text = "Other";
            this.otherToolStripMenuItem3.Click += new System.EventHandler(this.OtherToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(140, 6);
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem10,
            this.showAllToolStripMenuItem1,
            this.toolStripMenuItem9,
            this.qualityToolStripMenuItem1});
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(143, 24);
            this.viewToolStripMenuItem1.Text = "View";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(149, 26);
            this.toolStripMenuItem10.Text = "100%";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.ToolStripMenuItem4_Click);
            // 
            // showAllToolStripMenuItem1
            // 
            this.showAllToolStripMenuItem1.Name = "showAllToolStripMenuItem1";
            this.showAllToolStripMenuItem1.Size = new System.Drawing.Size(149, 26);
            this.showAllToolStripMenuItem1.Text = "Show All";
            this.showAllToolStripMenuItem1.Click += new System.EventHandler(this.ShowAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(146, 6);
            // 
            // qualityToolStripMenuItem1
            // 
            this.qualityToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowToolStripMenuItem1,
            this.mediumToolStripMenuItem1,
            this.highToolStripMenuItem1});
            this.qualityToolStripMenuItem1.Name = "qualityToolStripMenuItem1";
            this.qualityToolStripMenuItem1.Size = new System.Drawing.Size(149, 26);
            this.qualityToolStripMenuItem1.Text = "Quality";
            // 
            // lowToolStripMenuItem1
            // 
            this.lowToolStripMenuItem1.Name = "lowToolStripMenuItem1";
            this.lowToolStripMenuItem1.Size = new System.Drawing.Size(146, 26);
            this.lowToolStripMenuItem1.Text = "Low";
            this.lowToolStripMenuItem1.Click += new System.EventHandler(this.LowToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem1
            // 
            this.mediumToolStripMenuItem1.Name = "mediumToolStripMenuItem1";
            this.mediumToolStripMenuItem1.Size = new System.Drawing.Size(146, 26);
            this.mediumToolStripMenuItem1.Text = "Medium";
            this.mediumToolStripMenuItem1.Click += new System.EventHandler(this.MediumToolStripMenuItem_Click);
            // 
            // highToolStripMenuItem1
            // 
            this.highToolStripMenuItem1.Name = "highToolStripMenuItem1";
            this.highToolStripMenuItem1.Size = new System.Drawing.Size(146, 26);
            this.highToolStripMenuItem1.Text = "High";
            this.highToolStripMenuItem1.Click += new System.EventHandler(this.HighToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(140, 6);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(143, 24);
            this.optionsToolStripMenuItem1.Text = "Options";
            this.optionsToolStripMenuItem1.Click += new System.EventHandler(this.OptionsToolStripMenuItem_Click);
            // 
            // fullscreenToolStripMenuItem1
            // 
            this.fullscreenToolStripMenuItem1.Name = "fullscreenToolStripMenuItem1";
            this.fullscreenToolStripMenuItem1.Size = new System.Drawing.Size(143, 24);
            this.fullscreenToolStripMenuItem1.Text = "Fullscreen";
            this.fullscreenToolStripMenuItem1.Click += new System.EventHandler(this.FullscreenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(143, 24);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(116)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(1067, 738);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbScreenShot);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Baffler\'s Standalone";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
