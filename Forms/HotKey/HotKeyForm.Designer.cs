﻿namespace BafflerStandalone.Forms.HotKey
{
	public partial class HotKeyForm : global::System.Windows.Forms.Form
	{
#pragma warning disable 0649
		private global::System.ComponentModel.IContainer components = null;
		private global::System.Windows.Forms.Button btnSaveHotkey;
		private global::System.Windows.Forms.Button button2;
		private global::System.Windows.Forms.Button button3;
		private global::System.Windows.Forms.ComboBox comboBox3;
		private global::System.Windows.Forms.Button btMoveUp;
		private global::System.Windows.Forms.ComboBox comboBox1;
		private global::System.Windows.Forms.Button btMoveDown;
		private global::System.Windows.Forms.TextBox textBox1;
		private global::System.Windows.Forms.Button btnDelete;
		private global::System.Windows.Forms.ListBox listBox1;
		private global::System.Windows.Forms.Panel panel1;
		private global::System.Windows.Forms.TextBox tbParm2;
		private global::System.Windows.Forms.TextBox tbParm1;
		private global::System.Windows.Forms.Label label1;
		private global::System.Windows.Forms.Label label5;
		private global::System.Windows.Forms.Label label4;
		private global::System.Windows.Forms.Label label3;
		private global::System.Windows.Forms.Label label2;
		private global::System.Windows.Forms.Button button7;
		private global::System.Windows.Forms.ComboBox comboBox2;
		private global::System.Windows.Forms.ComboBox comboBox4;
		
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
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::BafflerStandalone.Forms.HotKey.HotKeyForm));
			this.btnSaveHotkey = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.comboBox3 = new global::System.Windows.Forms.ComboBox();
			this.btMoveUp = new global::System.Windows.Forms.Button();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.btMoveDown = new global::System.Windows.Forms.Button();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.btnDelete = new global::System.Windows.Forms.Button();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.comboBox4 = new global::System.Windows.Forms.ComboBox();
			this.comboBox2 = new global::System.Windows.Forms.ComboBox();
			this.button7 = new global::System.Windows.Forms.Button();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.tbParm2 = new global::System.Windows.Forms.TextBox();
			this.tbParm1 = new global::System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.btnSaveHotkey.Location = new global::System.Drawing.Point(251, 237);
			this.btnSaveHotkey.Name = "btnSaveHotkey";
			this.btnSaveHotkey.Size = new global::System.Drawing.Size(75, 23);
			this.btnSaveHotkey.TabIndex = 0;
			this.btnSaveHotkey.Text = "Save";
			this.btnSaveHotkey.UseVisualStyleBackColor = true;
			this.btnSaveHotkey.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new global::System.Drawing.Point(332, 237);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button3.Location = new global::System.Drawing.Point(33, 182);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(76, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "Add";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.comboBox3.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Items.AddRange(new object[] {"None","Ctrl","Alt","Shift"});
			this.comboBox3.Location = new global::System.Drawing.Point(79, 14);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new global::System.Drawing.Size(100, 21);
			this.comboBox3.TabIndex = 7;
			this.comboBox3.SelectedIndexChanged += new global::System.EventHandler(this.comboBox3_SelectedIndexChanged);
			this.btMoveUp.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btMoveUp.Image");
			this.btMoveUp.Location = new global::System.Drawing.Point(228, 182);
			this.btMoveUp.Name = "btMoveUp";
			this.btMoveUp.Size = new global::System.Drawing.Size(32, 32);
			this.btMoveUp.TabIndex = 8;
			this.btMoveUp.UseVisualStyleBackColor = true;
			this.btMoveUp.Click += new global::System.EventHandler(this.btMoveUp_Click);
			this.comboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {"None","ShowHelp","ShowOptions","ToggleFullscreen","GoFullScreen","ExitFullScreen","SetSizeAbsolute","SetSizeRelative","ShowQuickAlign","Screenshot","ChatCommand","GoToNextTab","GoToPreviousTab","ChangeAlign","ChangeScale"});
			this.comboBox1.Location = new global::System.Drawing.Point(79, 94);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 4;
			this.comboBox1.SelectedIndexChanged += new global::System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.btMoveDown.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btMoveDown.Image");
			this.btMoveDown.Location = new global::System.Drawing.Point(264, 182);
			this.btMoveDown.Name = "btMoveDown";
			this.btMoveDown.Size = new global::System.Drawing.Size(32, 32);
			this.btMoveDown.TabIndex = 9;
			this.btMoveDown.UseVisualStyleBackColor = true;
			this.btMoveDown.Click += new global::System.EventHandler(this.btMoveDown_Click);
			this.textBox1.Location = new global::System.Drawing.Point(79, 41);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 3;
			this.textBox1.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
			this.btnDelete.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnDelete.Image");
			this.btnDelete.Location = new global::System.Drawing.Point(362, 182);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new global::System.Drawing.Size(32, 32);
			this.btnDelete.TabIndex = 10;
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new global::System.EventHandler(this.button6_Click);
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new global::System.Drawing.Point(228, 7);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(166, 173);
			this.listBox1.TabIndex = 2;
			this.listBox1.SelectedIndexChanged += new global::System.EventHandler(this.listBox1_SelectedIndexChanged);
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.comboBox4);
			this.panel1.Controls.Add(this.comboBox2);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.tbParm2);
			this.panel1.Controls.Add(this.tbParm1);
			this.panel1.Controls.Add(this.listBox1);
			this.panel1.Controls.Add(this.btnDelete);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.btMoveDown);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.btMoveUp);
			this.panel1.Controls.Add(this.comboBox3);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Location = new global::System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(403, 219);
			this.panel1.TabIndex = 11;
			this.comboBox4.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Items.AddRange(new object[] {"No Scale (100%)","Show All"});
			this.comboBox4.Location = new global::System.Drawing.Point(79, 120);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new global::System.Drawing.Size(121, 21);
			this.comboBox4.TabIndex = 20;
			this.comboBox4.Visible = false;
			this.comboBox4.SelectedIndexChanged += new global::System.EventHandler(this.comboBox4_SelectedIndexChanged);
			this.comboBox2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {"Center","Left","Right","Top","TopLeft","TopRight","Bottom","BottomLeft","BottomRight"});
			this.comboBox2.Location = new global::System.Drawing.Point(79, 120);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new global::System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 19;
			this.comboBox2.Visible = false;
			this.comboBox2.SelectedIndexChanged += new global::System.EventHandler(this.comboBox2_SelectedIndexChanged);
			this.button7.Enabled = false;
			this.button7.Location = new global::System.Drawing.Point(115, 182);
			this.button7.Name = "button7";
			this.button7.Size = new global::System.Drawing.Size(85, 23);
			this.button7.TabIndex = 18;
			this.button7.Text = "Replace";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new global::System.EventHandler(this.button7_Click);
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(9, 150);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(64, 13);
			this.label5.TabIndex = 17;
			this.label5.Text = "Parameter 2";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(9, 124);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(64, 13);
			this.label4.TabIndex = 16;
			this.label4.Text = "Parameter 1";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(9, 97);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(37, 13);
			this.label3.TabIndex = 15;
			this.label3.Text = "Action";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(9, 44);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(45, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Hot Key";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(9, 17);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(44, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "Modifier";
			this.tbParm2.Location = new global::System.Drawing.Point(79, 147);
			this.tbParm2.Name = "tbParm2";
			this.tbParm2.Size = new global::System.Drawing.Size(100, 20);
			this.tbParm2.TabIndex = 12;
			this.tbParm1.Location = new global::System.Drawing.Point(79, 121);
			this.tbParm1.Name = "tbParm1";
			this.tbParm1.Size = new global::System.Drawing.Size(100, 20);
			this.tbParm1.TabIndex = 11;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(428, 268);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.btnSaveHotkey);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "HotKeyForm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "HotKey Editor - Baffler's Standalone";
			base.Load += new global::System.EventHandler(this.HotKeyForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}
	}
}