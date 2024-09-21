namespace lifetime_studio
{
	partial class PreferencesWin
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
			label1 = new Label();
			themeBox = new ComboBox();
			label2 = new Label();
			button1 = new Button();
			label3 = new Label();
			button2 = new Button();
			label4 = new Label();
			lightCheck = new RadioButton();
			darkCheck = new RadioButton();
			button3 = new Button();
			button4 = new Button();
			label5 = new Label();
			label6 = new Label();
			fontDialog1 = new FontDialog();
			fontDialog2 = new FontDialog();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 15);
			label1.Name = "label1";
			label1.Size = new Size(43, 15);
			label1.TabIndex = 0;
			label1.Text = "Theme";
			// 
			// themeBox
			// 
			themeBox.FlatStyle = FlatStyle.Flat;
			themeBox.FormattingEnabled = true;
			themeBox.Location = new Point(81, 12);
			themeBox.Name = "themeBox";
			themeBox.Size = new Size(128, 23);
			themeBox.TabIndex = 1;
			// 
			// label1
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 70);
			label2.Name = "label1";
			label2.Size = new Size(51, 15);
			label2.TabIndex = 2;
			label2.Text = "GUI font";
			// 
			// button1
			// 
			button1.FlatStyle = FlatStyle.Flat;
			button1.Location = new Point(81, 66);
			button1.Name = "button1";
			button1.Size = new Size(64, 24);
			button1.TabIndex = 3;
			button1.Text = "Pick...";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 101);
			label3.Name = "label3";
			label3.Size = new Size(63, 15);
			label3.TabIndex = 4;
			label3.Text = "Editor font";
			// 
			// button2
			// 
			button2.FlatStyle = FlatStyle.Flat;
			button2.Location = new Point(81, 96);
			button2.Name = "button2";
			button2.Size = new Size(64, 24);
			button2.TabIndex = 5;
			button2.Text = "Pick...";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 43);
			label4.Name = "label4";
			label4.Size = new Size(38, 15);
			label4.TabIndex = 6;
			label4.Text = "Mode";
			// 
			// lightCheck
			// 
			lightCheck.AutoSize = true;
			lightCheck.Location = new Point(81, 41);
			lightCheck.Name = "lightCheck";
			lightCheck.Size = new Size(52, 19);
			lightCheck.TabIndex = 7;
			lightCheck.TabStop = true;
			lightCheck.Text = "Light";
			lightCheck.UseVisualStyleBackColor = true;
			lightCheck.CheckedChanged += lightCheck_CheckedChanged;
			// 
			// darkCheck
			// 
			darkCheck.AutoSize = true;
			darkCheck.Checked = true;
			darkCheck.Location = new Point(139, 41);
			darkCheck.Name = "darkCheck";
			darkCheck.Size = new Size(49, 19);
			darkCheck.TabIndex = 8;
			darkCheck.TabStop = true;
			darkCheck.Text = "Dark";
			darkCheck.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.FlatStyle = FlatStyle.Flat;
			button3.Location = new Point(217, 245);
			button3.Name = "button3";
			button3.Size = new Size(75, 24);
			button3.TabIndex = 9;
			button3.Text = "OK";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.FlatStyle = FlatStyle.Flat;
			button4.Location = new Point(139, 245);
			button4.Name = "button4";
			button4.Size = new Size(75, 24);
			button4.TabIndex = 10;
			button4.Text = "Cancel";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(151, 71);
			label5.Name = "label5";
			label5.Size = new Size(70, 15);
			label5.TabIndex = 11;
			label5.Text = "Segoe UI (9)";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(151, 101);
			label6.Name = "label6";
			label6.Size = new Size(78, 15);
			label6.TabIndex = 12;
			label6.Text = "Consolas (12)";
			// 
			// PreferencesWin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(304, 281);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(darkCheck);
			Controls.Add(lightCheck);
			Controls.Add(label4);
			Controls.Add(button2);
			Controls.Add(label3);
			Controls.Add(button1);
			Controls.Add(label2);
			Controls.Add(themeBox);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "PreferencesWin";
			ShowIcon = false;
			Text = "Lifetime Studio preferences";
			FormClosing += PreferencesWin_FormClosing;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private ComboBox themeBox;
		private Label label2;
		private Button button1;
		private Label label3;
		private Button button2;
		private Label label4;
		private RadioButton lightCheck;
		private RadioButton darkCheck;
		private Button button3;
		private Button button4;
		private Label label5;
		private Label label6;
		private FontDialog fontDialog1;
		private FontDialog fontDialog2;
	}
}