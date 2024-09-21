using Mattodev.Lifetime;

namespace lifetime_studio
{
	public partial class Executor : Form
	{
		string filename;
		public Executor(string filename, Color txtC, Color bg1C, Color bg2C, Font guifont, Font editfont)
		{
			InitializeComponent();
			this.filename = filename;

			foreach (Control c in Controls)
			{
				c.ForeColor = txtC;
				c.Font = guifont;
				if (c.GetType() != typeof(Label))
					c.BackColor = bg2C;
			}
			BackColor = bg1C;
			textBox1.Font = editfont;
		}

		private async void Executor_Load(object sender, EventArgs e)
		=> await Task.Run(() => {
			if (!File.Exists(filename))
			{
				MessageBox.Show("File '" + filename + "' does not exist!", "Lifetime Studio", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string[] code = File.ReadAllLines(filename);
			LTRuntimeContainer container = LTInterpreter.DefaultContainer();
			container.OutputHandler = msg => textBox1.Invoke(() => textBox1.Text += msg.ReplaceLineEndings());
			container.ErrOutputHandler = msg => textBox1.Invoke(() =>
			{
				textBox1.Text += msg.ReplaceLineEndings();
				MessageBox.Show(msg, "Lifetime error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			});
			container.InputHandler = q => textBox1.Invoke(() =>
			{
				textBox1.Text += q.ReplaceLineEndings();
				ExecutorInput i = new(q);
				i.ShowDialog();
				textBox1.Text += i.answer.ReplaceLineEndings() + "\r\n";
				return i.answer;
			});

			LTInterpreter.DebugMode = true;
			LTInterpreter.Exec(code, filename, ref container);
		});
	}
}
