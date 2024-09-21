namespace lifetime_studio
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			editBox = new TextBox();
			label1 = new Label();
			menuStrip1 = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			newToolStripMenuItem = new ToolStripMenuItem();
			openToolStripMenuItem = new ToolStripMenuItem();
			saveToolStripMenuItem = new ToolStripMenuItem();
			saveAsToolStripMenuItem = new ToolStripMenuItem();
			exitToolStripMenuItem = new ToolStripMenuItem();
			editToolStripMenuItem = new ToolStripMenuItem();
			findToolStripMenuItem = new ToolStripMenuItem();
			findReplaceToolStripMenuItem = new ToolStripMenuItem();
			preferencesToolStripMenuItem = new ToolStripMenuItem();
			buildToolStripMenuItem = new ToolStripMenuItem();
			runToolStripMenuItem = new ToolStripMenuItem();
			validateToolStripMenuItem = new ToolStripMenuItem();
			helpToolStripMenuItem = new ToolStripMenuItem();
			aboutLifetimeStudioToolStripMenuItem = new ToolStripMenuItem();
			saveFileDialog1 = new SaveFileDialog();
			openFileDialog1 = new OpenFileDialog();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// editBox
			// 
			editBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			editBox.BackColor = Color.FromArgb(31, 23, 47);
			editBox.BorderStyle = BorderStyle.FixedSingle;
			editBox.ForeColor = Color.White;
			editBox.Location = new Point(12, 48);
			editBox.MaxLength = 65535;
			editBox.Multiline = true;
			editBox.Name = "editBox";
			editBox.Size = new Size(776, 390);
			editBox.TabIndex = 2;
			editBox.TextChanged += editBox_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 27);
			label1.Margin = new Padding(3);
			label1.Name = "label1";
			label1.Size = new Size(55, 15);
			label1.TabIndex = 3;
			label1.Text = "newfile.lt";
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, buildToolStripMenuItem, helpToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 24);
			menuStrip1.TabIndex = 4;
			menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, exitToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(37, 20);
			fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			newToolStripMenuItem.Name = "newToolStripMenuItem";
			newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
			newToolStripMenuItem.Size = new Size(184, 22);
			newToolStripMenuItem.Text = "New";
			// 
			// openToolStripMenuItem
			// 
			openToolStripMenuItem.Name = "openToolStripMenuItem";
			openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
			openToolStripMenuItem.Size = new Size(184, 22);
			openToolStripMenuItem.Text = "Open";
			openToolStripMenuItem.Click += openToolStripMenuItem_Click;
			// 
			// saveToolStripMenuItem
			// 
			saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
			saveToolStripMenuItem.Size = new Size(184, 22);
			saveToolStripMenuItem.Text = "Save";
			saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
			// 
			// saveAsToolStripMenuItem
			// 
			saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
			saveAsToolStripMenuItem.Size = new Size(184, 22);
			saveAsToolStripMenuItem.Text = "Save as";
			saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.Size = new Size(184, 22);
			exitToolStripMenuItem.Text = "Exit";
			exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
			// 
			// editToolStripMenuItem
			// 
			editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { findToolStripMenuItem, findReplaceToolStripMenuItem, preferencesToolStripMenuItem });
			editToolStripMenuItem.Name = "editToolStripMenuItem";
			editToolStripMenuItem.Size = new Size(39, 20);
			editToolStripMenuItem.Text = "Edit";
			// 
			// findToolStripMenuItem
			// 
			findToolStripMenuItem.Name = "findToolStripMenuItem";
			findToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
			findToolStripMenuItem.Size = new Size(204, 22);
			findToolStripMenuItem.Text = "Find";
			// 
			// findReplaceToolStripMenuItem
			// 
			findReplaceToolStripMenuItem.Name = "findReplaceToolStripMenuItem";
			findReplaceToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
			findReplaceToolStripMenuItem.Size = new Size(204, 22);
			findReplaceToolStripMenuItem.Text = "Find and replace";
			// 
			// preferencesToolStripMenuItem
			// 
			preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
			preferencesToolStripMenuItem.Size = new Size(204, 22);
			preferencesToolStripMenuItem.Text = "Preferences";
			preferencesToolStripMenuItem.Click += preferencesToolStripMenuItem_Click;
			// 
			// buildToolStripMenuItem
			// 
			buildToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { runToolStripMenuItem, validateToolStripMenuItem });
			buildToolStripMenuItem.Name = "buildToolStripMenuItem";
			buildToolStripMenuItem.Size = new Size(46, 20);
			buildToolStripMenuItem.Text = "Build";
			// 
			// runToolStripMenuItem
			// 
			runToolStripMenuItem.Name = "runToolStripMenuItem";
			runToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
			runToolStripMenuItem.Size = new Size(188, 22);
			runToolStripMenuItem.Text = "Run";
			runToolStripMenuItem.Click += runToolStripMenuItem_Click;
			// 
			// validateToolStripMenuItem
			// 
			validateToolStripMenuItem.Name = "validateToolStripMenuItem";
			validateToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.R;
			validateToolStripMenuItem.Size = new Size(188, 22);
			validateToolStripMenuItem.Text = "Validate";
			// 
			// helpToolStripMenuItem
			// 
			helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutLifetimeStudioToolStripMenuItem });
			helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			helpToolStripMenuItem.Size = new Size(44, 20);
			helpToolStripMenuItem.Text = "Help";
			// 
			// aboutLifetimeStudioToolStripMenuItem
			// 
			aboutLifetimeStudioToolStripMenuItem.Name = "aboutLifetimeStudioToolStripMenuItem";
			aboutLifetimeStudioToolStripMenuItem.Size = new Size(190, 22);
			aboutLifetimeStudioToolStripMenuItem.Text = "About Lifetime Studio";
			aboutLifetimeStudioToolStripMenuItem.Click += aboutLifetimeStudioToolStripMenuItem_Click;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			openFileDialog1.Filter = "Lifetime scripts|*.lt";
			openFileDialog1.Title = "Open file";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(23, 15, 31);
			ClientSize = new Size(800, 450);
			Controls.Add(label1);
			Controls.Add(editBox);
			Controls.Add(menuStrip1);
			ForeColor = Color.White;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip1;
			MinimumSize = new Size(500, 300);
			Name = "Form1";
			Text = "Lifetime Studio";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TextBox editBox;
		private Label label1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem newToolStripMenuItem;
		private ToolStripMenuItem openToolStripMenuItem;
		private ToolStripMenuItem saveToolStripMenuItem;
		private ToolStripMenuItem saveAsToolStripMenuItem;
		private ToolStripMenuItem editToolStripMenuItem;
		private ToolStripMenuItem findToolStripMenuItem;
		private ToolStripMenuItem findReplaceToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ToolStripMenuItem buildToolStripMenuItem;
		private ToolStripMenuItem runToolStripMenuItem;
		private ToolStripMenuItem validateToolStripMenuItem;
		private ToolStripMenuItem aboutLifetimeStudioToolStripMenuItem;
		private ToolStripMenuItem preferencesToolStripMenuItem;
		private ToolStripMenuItem exitToolStripMenuItem;
		private SaveFileDialog saveFileDialog1;
		private OpenFileDialog openFileDialog1;
	}
}
