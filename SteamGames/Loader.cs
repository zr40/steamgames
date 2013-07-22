using System;
using System.Collections.Generic;
using System.Json;
using System.Net;

namespace SteamGames
{
	internal sealed class Loader
	{
		internal Action<State, List<Game>> Done;
		internal Action<string> Status;

		internal void Load()
		{
			var state = LoadState();
			Status("Requesting games...");
			var games = LoadGames(state);

			Done(state, games);
		}

		private static List<Game> LoadGames(State state)
		{
			WebRequest r = WebRequest.Create(string.Format("http://api.steampowered.com/IPlayerService/GetOwnedGames/v1?key={0}&steamid={1}&include_appinfo=1&include_played_free_games=1", state.WebApiKey, state.SteamId));
			dynamic o = JsonValue.Load(r.GetResponse().GetResponseStream());

			dynamic games = o.response.games;

			var allGames = new List<Game>();

			foreach (dynamic game in games)
			{
				allGames.Add(new Game(game));
			}
			allGames.Sort((left, right) => left.Name.CompareTo(right.Name));
			return allGames;
		}

		private static State LoadState()
		{
			var state = State.Load();

			if (state.WebApiKey == null)
			{
				new SettingsForm(state).ShowDialog();
				if (state.WebApiKey == null)
				{
					Environment.Exit(0);
				}
			}
			return state;
		}
	}
}