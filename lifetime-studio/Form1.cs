
namespace lifetime_studio
{
	public partial class Form1 : Form
	{
		public bool existing => File.Exists(filename);
		public string filename = "newfile.lt";
		int txtR, txtG, txtB;
		int bg1R, bg1G, bg1B;
		int bg2R, bg2G, bg2B;
		Font? guifont;
		public Form1()
		{
			InitializeComponent();
			reloadPrefs();
		}

		private void reloadPrefs()
		{
			var preferences = PreferencesLoader.Load();
			if (preferences == null)
			{
				PreferencesLoader.CreateDefault();
				preferences = PreferencesLoader.Load();
			}
			var theme = PreferencesLoader.LoadTheme(preferences!["theme"], preferences["mode"] == "light");
			if (theme == null)
			{
				MessageBox.Show("Could not load theme " + preferences["theme"] + "!", "Lifetime Studio", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
				return;
			}
			(txtR, txtG, txtB) = theme["txtcolor"];
			(bg1R, bg1G, bg1B) = theme["bgcolor"];
			(bg2R, bg2G, bg2B) = theme["bgcolortxtbox"];

			guifont = PreferencesLoader.LoadFont(preferences["guifont"]);
			foreach (Control c in Controls)
			{
				c.ForeColor = Color.FromArgb(txtR, txtG, txtB);
				c.Font = guifont;
			}

			BackColor = Color.FromArgb(bg1R, bg1G, bg1B);
			editBox.BackColor = Color.FromArgb(bg2R, bg2G, bg2B);
			editBox.Font = PreferencesLoader.LoadFont(preferences["editfont"]);

			menuStrip1.BackColor = Color.FromArgb(bg2R, bg2G, bg2B);
			foreach (ToolStripMenuItem i in menuStrip1.Items)
			{
				i.BackColor = Color.FromArgb(bg2R, bg2G, bg2B);
				i.ForeColor = Color.FromArgb(txtR, txtG, txtB);
				foreach (ToolStripMenuItem i2 in i.DropDownItems)
				{
					i2.BackColor = Color.FromArgb(bg2R, bg2G, bg2B);
					i2.ForeColor = Color.FromArgb(txtR, txtG, txtB);
				}
			}
		}

		private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var txtC = Color.FromArgb(txtR, txtG, txtB);
			var bg2C = Color.FromArgb(bg2R, bg2G, bg2B);
			new PreferencesWin(txtC, bg2C, guifont!).ShowDialog();
			reloadPrefs();
		}

		private void aboutLifetimeStudioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var txtC = Color.FromArgb(txtR, txtG, txtB);
			var bg2C = Color.FromArgb(bg2R, bg2G, bg2B);
			new AboutWin(txtC, bg2C).ShowDialog();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void runToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!saveFile()) return;
			var txtC = Color.FromArgb(txtR, txtG, txtB);
			var bg1C = Color.FromArgb(bg1R, bg1G, bg1B);
			var bg2C = Color.FromArgb(bg2R, bg2G, bg2B);
			new Executor(filename, txtC, bg1C, bg2C, guifont!, editBox.Font).Show();
		}

		private void editBox_TextChanged(object sender, EventArgs e)
		{
			label1.Text = filename + "*";
		}
		private bool saveFile(bool savesAs = false)
		{
			if (!existing || savesAs)
			{
				saveFileDialog1.Title = "Save file as...";
				saveFileDialog1.Filter = "Lifetime scripts|*.lt";
				saveFileDialog1.FileName = filename;

				if (saveFileDialog1.ShowDialog() != DialogResult.OK)
					return false;
				filename = saveFileDialog1.FileName;
			}
			label1.Text = filename;
			File.WriteAllLines(filename, editBox.Lines);
			return true;
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveFile();
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveFile(true);
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			openFileDialog1.FileName = filename;
			if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
			editBox.Lines = File.ReadAllLines(openFileDialog1.FileName);
			filename = openFileDialog1.FileName;
			label1.Text = filename;
		}
	}
}
