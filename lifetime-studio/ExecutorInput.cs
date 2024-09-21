namespace lifetime_studio
{
	public partial class ExecutorInput : Form
	{
		public string answer = "";
		public ExecutorInput(string question)
		{
			InitializeComponent();
			label1.Text = question;
			FormClosing += (_, _) => answer = textBox2.Text;
		}
	}
}
