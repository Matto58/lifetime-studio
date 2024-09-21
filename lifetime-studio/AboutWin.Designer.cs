namespace lifetime_studio
{
	partial class AboutWin
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
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			button1 = new Button();
			label4 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImage = Properties.Resources.lsbanner;
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(344, 80);
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.BackgroundImage = Properties.Resources.lslogo;
			pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
			pictureBox2.Location = new Point(12, 86);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(45, 45);
			pictureBox2.TabIndex = 3;
			pictureBox2.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label1.Location = new Point(63, 86);
			label1.Name = "label1";
			label1.Size = new Size(93, 15);
			label1.TabIndex = 4;
			label1.Text = "Lifetime Studio";
			// 
			// label1
			// 
			label2.AutoSize = true;
			label2.ForeColor = SystemColors.ControlText;
			label2.Location = new Point(63, 101);
			label2.Name = "label1";
			label2.Size = new Size(72, 15);
			label2.TabIndex = 5;
			label2.Text = "version 1.0.0";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.ForeColor = SystemColors.ControlText;
			label3.Location = new Point(63, 116);
			label3.Name = "label3";
			label3.Size = new Size(118, 15);
			label3.TabIndex = 6;
			label3.Text = "Lifetime version 0.5.3";
			// 
			// button1
			// 
			button1.FlatStyle = FlatStyle.Flat;
			button1.Location = new Point(257, 165);
			button1.Name = "button1";
			button1.Size = new Size(75, 24);
			button1.TabIndex = 7;
			button1.Text = "OK";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 7F);
			label4.ForeColor = SystemColors.ControlDark;
			label4.Location = new Point(12, 180);
			label4.Name = "label4";
			label4.Size = new Size(117, 12);
			label4.TabIndex = 8;
			label4.Text = "written by Matto58 - 2024";
			label4.Click += label4_Click;
			// 
			// AboutWin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(344, 201);
			Controls.Add(label4);
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "AboutWin";
			ShowIcon = false;
			Text = "About Lifetime Studio";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private Label label1;
		private Label label2;
		private Label label3;
		private Button button1;
		private Label label4;
	}
}