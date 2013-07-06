using System;
using System.ComponentModel;
using System.Windows.Forms;

using DynamicExpresso;

namespace SteamGames
{
	internal sealed partial class FilterEditor : Form
	{
		private readonly State state;
		internal Filter Result;

		internal FilterEditor(State state)
		{
			this.state = state;
			InitializeComponent();
		}

		internal FilterEditor(State state, Filter filter) : this(state)
		{
			textBox1.Text = filter.Name;
			textBox2.Text = filter.Source;
		}

		private void FilterEditor_HelpButtonClicked(object sender, CancelEventArgs e)
		{
			e.Cancel = true;

			MessageBox.Show("You can define a filter by entering a C# expression that determines whether to include a game.\n\nAvailable functions:\n-  tag(name)\n\tReturns whether the game has a tag with this name.\n\nAvailable parameters:\n-  name\tThe name of the game\n-  appid\tThe game's app ID\n\nExample:\n\t(tag(\"multiplayer\") || tag(\"unfinished\")) && !tag(\"beta\")", "Filter editor help");
		}

		private void button1_Click(object sender, EventArgs x)
		{
			Filter filter;
			try
			{
				filter = new Filter(textBox1.Text, textBox2.Text, state);
			}
			catch (ParseException e)
			{
				MessageBox.Show(string.Format("Parse error.\n\nDetails:\n{0}", e.Message), "Filter error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

				// TODO: improve error highlighting. It's currently a quick hack, selecting up to a space character.
				textBox2.Select(e.Position, (textBox2.Text + ' ').IndexOf(' ', e.Position) - e.Position);
				return;
			}
			catch (ArgumentException e)
			{
				if (e.Message.Contains("System.Boolean"))
				{
					MessageBox.Show(string.Format("The filter must return a boolean value.\n\nDetails:\n{0}", e.Message), "Filter error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				throw;
			}

			try
			{
				filter.Evaluate(new Game(new {name = "Test", appid = 0}));
			}
			catch (Exception e)
			{
				MessageBox.Show(string.Format("The filter caused an exception.\n\nDetails:\n{0}", e.Message), "Filter error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			Result = filter;
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}