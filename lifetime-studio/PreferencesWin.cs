namespace lifetime_studio
{
	public partial class PreferencesWin : Form
	{
		bool discardChanges = false;
		string guifontName = "", editfontName = "";
		float guifontSize, editfontSize;
		public PreferencesWin(Color txtC, Color bgC, Font guifont)
		{
			InitializeComponent();
			var prefs = PreferencesLoader.Load();
			if (prefs == null)
			{
				MessageBox.Show("Could not load preferences!", "Lifetime Studio", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			var light = prefs["mode"] == "light";
			themeBox.Items.AddRange(
				[.. (light
				? PreferencesLoader.GetLightThemes()
				: PreferencesLoader.GetDarkThemes())]);
			themeBox.SelectedItem = prefs["theme"];
			lightCheck.Checked = light;
			darkCheck.Checked = !light;

			var guifont2 = prefs["guifont"].Split(';');
			updateGuifont(guifont2[0], float.Parse(guifont2[1]));
			var editfont = prefs["editfont"].Split(';');
			updateEditfont(editfont[0], float.Parse(editfont[1]));

			foreach (Control c in Controls)
			{
				c.BackColor = bgC;
				c.ForeColor = txtC;
				c.Font = guifont;
			}
			BackColor = bgC;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			discardChanges = true;
			Close();
		}

		private void PreferencesWin_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (discardChanges) return;
			//Debug.WriteLine(themeBox.Text);
			PreferencesLoader.Store(new()
			{
				{ "mode", lightCheck.Checked ? "light" : "dark" },
				{ "theme", themeBox.Text ?? "purple" },
				{ "guifont", guifontName + ";" + guifontSize },
				{ "editfont", editfontName + ";" + editfontSize },
			});
		}

		private void updateGuifont(string name, float size)
		{
			guifontName = name;
			guifontSize = size;
			label5.Text = $"{guifontName} ({guifontSize})";
		}
		private void updateEditfont(string name, float size)
		{
			editfontName = name;
			editfontSize = size;
			label6.Text = $"{editfontName} ({editfontSize})";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			fontDialog1.Font = new(guifontName, guifontSize);
			if (fontDialog1.ShowDialog() != DialogResult.OK) return;
			updateGuifont(fontDialog1.Font.Name, fontDialog1.Font.Size);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			fontDialog2.Font = new(editfontName, editfontSize);
			if (fontDialog2.ShowDialog() != DialogResult.OK) return;
			updateEditfont(fontDialog2.Font.Name, fontDialog2.Font.Size);
		}

		private void lightCheck_CheckedChanged(object sender, EventArgs e)
		{
			themeBox.Items.Clear();
			themeBox.Items.AddRange(
				[.. (lightCheck.Checked
				? PreferencesLoader.GetLightThemes()
				: PreferencesLoader.GetDarkThemes())]);
		}
	}
}
