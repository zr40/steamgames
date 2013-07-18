﻿using System;
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
	internal sealed partial class GamesForm : Form
	{
		private readonly List<Game> allGames = new List<Game>();
		private readonly TypedObjectListView<Game> listView;
		private readonly State state;
		private int cbTop;

		private List<Game> filterGames;

		public GamesForm()
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

			listView = new TypedObjectListView<Game>(GameListView);
			GameListView.ItemRenderer = new GameRenderer();
			LoadData();

			ImageCache.RedrawNotification = GameListView.Invalidate;
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
			UpdateFilters();
			if (state.Filters.Count != 0)
			{
				FilterList.SelectedItem = state.Filters[state.SelectedFilter];
			}
		}

		private void UpdateDetails(Game game)
		{
			if (game == null)
			{
				GameDetailsPanel.Enabled = false;
				GameNameLabel.Text = "";
				UninstallGameButton.Visible = false;
			}
			else
			{
				GameDetailsPanel.Enabled = true;
				GameNameLabel.Text = game.Name;
				TagListBox.Items.Clear();
				UninstallGameButton.Visible = HasTag("installed", game);

				foreach (var tag in state.Tags.Keys.OrderBy(k => k))
				{
					if (state.Tags[tag].Contains(game.Id))
					{
						TagListBox.Items.Add(tag);
					}
				}
			}
		}

		private bool HasTag(string tag, Game game)
		{
			if (!state.Tags.ContainsKey(tag))
				return false;

			return state.Tags[tag].Contains(game.Id);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var tag = (string) TagListBox.SelectedItem;
			if (tag == null)
				return;

			RemoveTag(tag, listView.SelectedObject);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			AddTag(TagTextBox.Text, listView.SelectedObject);
		}

		private void AddTag(string tag, Game game)
		{
			if (!state.Tags.ContainsKey(tag))
			{
				state.Tags[tag] = new List<int>();
				CreateTagCheckbox(tag, CheckState.Indeterminate);
			}

			if (!state.Tags[tag].Contains(game.Id))
			{
				state.Tags[tag].Add(game.Id);
				UpdateDetails(game);
			}
		}

		private void RemoveTag(string tag, Game game)
		{
			state.Tags[tag].Remove(game.Id);
			UpdateDetails(game);
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
			cb.ContextMenuStrip = TagContextMenuStrip;
			TagContainer.Controls.Add(cb);
			cbTop += cb.Height;

			cb.CheckStateChanged += Filter;
		}

		private void Filter(object sender = null, EventArgs e = null)
		{
			if (FilterList.SelectedItem == null)
			{
				filterGames = allGames;
			}
			else
			{
				filterGames = allGames.Where(((Filter) FilterList.SelectedItem).Evaluate).ToList();
			}

			foreach (CheckBox cb in TagContainer.Controls)
			{
				cb.Text = string.Format("{0} ({1})", cb.Tag, FilterGames(filterGames, cb).Count());

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

			GameListView.SetObjects(FilterGames(filterGames));
			objectListView1_ItemSelectionChanged(null, null);
		}

		private IEnumerable<Game> FilterGames(IEnumerable<Game> games, CheckBox force = null)
		{
			foreach (CheckBox cb in TagContainer.Controls)
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
			foreach (CheckBox cb in TagContainer.Controls)
			{
				state.TagState[(string) cb.Tag] = cb.CheckState;
			}

			if (state.Filters.Count != 0)
			{
				state.SelectedFilter = ((Filter) FilterList.SelectedItem).Name;
			}
			else
			{
				state.SelectedFilter = null;
			}

			state.Save();
		}

		private void RunGameButton_Click(object sender, EventArgs e)
		{
			if (!HasTag("installed", listView.SelectedObject))
			{
				// steam://run/ doesn't always focus the install dialog, but steam://install/ does.
				Process.Start("steam://install/" + listView.SelectedObject.Id);
				AddTag("installed", listView.SelectedObject);

				// still call steam://run/ in case the game was already installed.
			}
			Process.Start("steam://run/" + listView.SelectedObject.Id);
		}

		private void objectListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			UpdateDetails(listView.SelectedObject);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Process.Start(string.Format("http://steamcommunity.com/app/{0}", listView.SelectedObject.Id));
		}

		private void button5_Click(object sender, EventArgs e)
		{
			var filterForm = new FilterEditor(state);
			if (filterForm.ShowDialog() != DialogResult.OK)
				return;

			state.Filters[filterForm.Result.Name] = filterForm.Result;

			UpdateFilters();
			FilterList.SelectedItem = filterForm.Result;
			Filter();
		}

		private void UpdateFilters()
		{
			FilterList.Items.Clear();
			FilterList.Items.AddRange(state.Filters.Values.OrderBy(f => f.Name).ToArray());
			FilterList.SelectedIndex = 0;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			var filterForm = new FilterEditor(state, (Filter)FilterList.SelectedItem);
			if (filterForm.ShowDialog() != DialogResult.OK)
				return;

			state.Filters.Remove(((Filter)FilterList.SelectedItem).Name);

			state.Filters[filterForm.Result.Name] = filterForm.Result;

			UpdateFilters();
			FilterList.SelectedItem = filterForm.Result;

			EditFilterButton.Enabled = state.Filters.Count != 0;
			DeleteFilterButton.Enabled = state.Filters.Count != 0;
		}

		private void FilterList_SelectedIndexChanged(object sender, EventArgs e)
		{
			Filter();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			state.Filters.Remove(((Filter)FilterList.SelectedItem).Name);
			UpdateFilters();

			EditFilterButton.Enabled = state.Filters.Count != 0;
			DeleteFilterButton.Enabled = state.Filters.Count != 0;
		}

		private void renameTagToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var cb = (CheckBox) TagContextMenuStrip.SourceControl;
			if (new RenameTagForm(cb, state).ShowDialog() == DialogResult.OK)
			{
				Filter();
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			Process.Start("steam://uninstall/" + listView.SelectedObject.Id);
			RemoveTag("installed", listView.SelectedObject);
		}
	}
}