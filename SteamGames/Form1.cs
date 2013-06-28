using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Json;
using System.Linq;
using System.Net;
using System.Windows.Forms;

using BrightIdeasSoftware;

namespace SteamGames
{
	internal sealed partial class Form1 : Form
	{
		private readonly List<Game> allGames = new List<Game>();
		private readonly TypedObjectListView<Game> listView;
		private readonly State state;
		private int cbTop;

		public Form1()
		{
			state = State.Load();
			if (state.WebApiKey == null)
			{
				new SettingsForm(state).ShowDialog();
				if (state.WebApiKey == null)
				{
					Environment.Exit(0);
				}
			}

			InitializeComponent();

			listView = new TypedObjectListView<Game>(objectListView1);
			objectListView1.ItemRenderer = new GameRenderer();
			LoadData();
		}

		private void LoadData()
		{
			WebRequest r = WebRequest.Create(string.Format("http://api.steampowered.com/IPlayerService/GetOwnedGames/v1?key={0}&steamid={1}&include_appinfo=1&include_played_free_games=1", state.WebApiKey, state.SteamId));
			dynamic o = JsonValue.Load(r.GetResponse().GetResponseStream());

			dynamic games = o.response.games;

			foreach (dynamic game in games)
			{
				allGames.Add(new Game(game));
			}
			allGames.Sort((left, right) => left.Name.CompareTo(right.Name));

			foreach (string tag in state.Tags.Keys.OrderBy(t => t))
			{
				CheckState cs;
				if (!state.TagState.TryGetValue(tag, out cs))
				{
					cs = CheckState.Indeterminate;
				}
				CreateTagCheckbox(tag, cs);
			}
			Filter();
		}

		private void UpdateDetails(Game game)
		{
			if (game == null)
			{
				flowLayoutPanel2.Enabled = false;
				label1.Text = "";
			}
			else
			{
				flowLayoutPanel2.Enabled = true;
				label1.Text = game.Name;
				listBox1.Items.Clear();
				foreach (var tag in state.Tags)
				{
					if (tag.Value.Contains(game.Id))
					{
						listBox1.Items.Add(tag.Key);
					}
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var tag = (string) listBox1.SelectedItem;
			if (tag == null)
				return;

			state.Tags[tag].Remove(listView.SelectedObject.Id);
			listBox1.Items.RemoveAt(listBox1.SelectedIndex);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string tag = textBox1.Text;
			listBox1.Items.Add(tag);
			if (!state.Tags.ContainsKey(tag))
			{
				state.Tags[tag] = new List<int>();
				CreateTagCheckbox(tag, CheckState.Indeterminate);
			}

			state.Tags[tag].Add(listView.SelectedObject.Id);
		}

		private void CreateTagCheckbox(string tag, CheckState cs)
		{
			var cb = new CheckBox();
			cb.Text = tag;
			cb.AutoSize = true;
			cb.ThreeState = true;
			cb.CheckState = cs;
			cb.Top = cbTop;
			cb.UseMnemonic = false;
			cb.Tag = tag;
			panel1.Controls.Add(cb);
			cbTop += cb.Height;

			cb.CheckStateChanged += Filter;
		}

		private void Filter(object sender = null, EventArgs e = null)
		{
			foreach (CheckBox cb in panel1.Controls)
			{
				cb.Text = string.Format("{0} ({1})", cb.Tag, FilterGames(allGames, cb).Count());

				switch (cb.CheckState)
				{
					case CheckState.Checked:
						cb.ForeColor = Color.FromArgb(192, 255, 192);
						break;

					case CheckState.Unchecked:
						cb.ForeColor = Color.FromArgb(255, 192, 192);
						break;

					case CheckState.Indeterminate:
						cb.ForeColor = Color.White;
						break;
				}
			}

			objectListView1.SetObjects(FilterGames(allGames));
		}

		private IEnumerable<Game> FilterGames(IEnumerable<Game> games, CheckBox force = null)
		{
			foreach (CheckBox cb in panel1.Controls)
			{
				if (cb == force)
				{
					games = games.Where(g => state.Tags[(string) cb.Tag].Contains(g.Id));
				}
				else
					switch (cb.CheckState)
					{
						case CheckState.Checked:
							games = games.Where(g => state.Tags[(string) cb.Tag].Contains(g.Id));
							break;
						case CheckState.Unchecked:
							games = games.Where(g => !state.Tags[(string) cb.Tag].Contains(g.Id));
							break;
					}
			}
			return games;
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			state.TagState = new Dictionary<string, CheckState>();
			foreach (CheckBox cb in panel1.Controls)
			{
				state.TagState[(string) cb.Tag] = cb.CheckState;
			}
			state.Save();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("steam://run/" + listView.SelectedObject.Id);
		}

		private void objectListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			var game = objectListView1.SelectedObject as Game;

			UpdateDetails(game);
		}
	}
}