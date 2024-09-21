using Mattodev.Lifetime;

namespace lifetime_studio
{
	public partial class AboutWin : Form
	{
		public AboutWin(Color txtC, Color bgC)
		{
			InitializeComponent();

			label2.Text = "version " + LSInfo.Version;
			label3.Text = "Lifetime version " + LTInfo.Version;
			label4.Text = "written by " + LSInfo.Author + " - " + LSInfo.Years;

			foreach (Control c in Controls)
			{
				c.BackColor = bgC;
				c.ForeColor = txtC;
			}
			BackColor = bgC;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void label4_Click(object sender, EventArgs e)
		{
			label4.Text = "✨ dancing through it all ✨";
		}
	}
}
