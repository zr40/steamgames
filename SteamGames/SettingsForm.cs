using System.Diagnostics;
using System.Json;
using System.Net;
using System.Windows.Forms;

namespace SteamGames
{
	internal sealed partial class SettingsForm : Form
	{
		private readonly State state;

		public SettingsForm(State state)
		{
			this.state = state;
			InitializeComponent();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://steamcommunity.com/dev");
			WebAPIKeyTextBox.Focus();
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://steamcommunity.com/my/?xml=1");
			SteamID64TextBox.Focus();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			// Validate API key
			WebRequest r = WebRequest.Create("https://api.steampowered.com/ISteamWebAPIUtil/GetSupportedAPIList/v1?key=" + WebAPIKeyTextBox.Text);
			try
			{
				r.GetResponse();
			}
			catch (WebException ex)
			{
				if (((HttpWebResponse) ex.Response).StatusCode == HttpStatusCode.Forbidden)
				{
					MessageBox.Show("This Web API key is invalid.", "Invalid API key", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					WebAPIKeyTextBox.Focus();
					return;
				}
				throw;
			}

			// Validate profile
			r = WebRequest.Create("https://api.steampowered.com/ISteamUser/GetPlayerSummaries/v2?key=" + WebAPIKeyTextBox.Text + "&steamids=" + SteamID64TextBox.Text);
			dynamic o = JsonValue.Load(r.GetResponse().GetResponseStream());
			if (o.response.players.Count != 1)
			{
				MessageBox.Show("There is no profile with this steamID64. A steamID64 always starts with '7656'.", "Invalid steamID64", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				SteamID64TextBox.Focus();
				return;
			}

			if (o.response.players[0].communityvisibilitystate.Value != 3)
			{
				MessageBox.Show("Your profile is not public. Unfortunately, your profile does need to be public, otherwise the Web API won't return any data.", "Private profile", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			state.WebApiKey = WebAPIKeyTextBox.Text;
			state.SteamId = ulong.Parse(SteamID64TextBox.Text);
			Close();
		}
	}
}