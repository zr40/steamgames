using System;
using System.Threading;
using System.Windows.Forms;

namespace SteamGames
{
	internal sealed partial class LoadingForm : Form
	{
		internal LoadingForm()
		{
			InitializeComponent();
			var loader = new Loader();
			loader.Done = (state, games) => BeginInvoke(new Action(() =>
			{
				var f = new GamesForm(state, games);
				f.Show();
				Close();
			}));
			loader.Status = (status) => BeginInvoke(new Action(() => label1.Text = status));
			new Thread(loader.Load).Start();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void LoadingForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Program.Context.FormClosed();
		}

		private void LoadingForm_Load(object sender, EventArgs e)
		{
			Program.Context.FormOpened();
		}

	}
}