using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using ProtoBuf;

namespace SteamGames
{
	[ProtoContract]
	internal sealed class State
	{
		internal static readonly string BasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SteamGames");
		private static readonly string statePath = Path.Combine(BasePath, "state.dat");
		private static readonly string savePath = Path.Combine(BasePath, "state new.dat");

		[ProtoMember(1)]
		internal string WebApiKey;

		[ProtoMember(2)]
		internal ulong SteamId;

		[ProtoMember(3)]
		internal readonly Dictionary<string, List<int>> Tags = new Dictionary<string, List<int>>();

		[ProtoMember(4)]
		internal Dictionary<string, CheckState> TagState = new Dictionary<string, CheckState>();

		[ProtoMember(5)]
		internal readonly Dictionary<string, Filter> Filters;

		[ProtoMember(6)]
		internal string SelectedFilter = "All games";

		private State()
		{
			Filters = new Dictionary<string, Filter>();
		}

		internal static State Load()
		{
			if (!Directory.Exists(BasePath))
			{
				Directory.CreateDirectory(BasePath);
			}
			if (!Directory.Exists(ImageCache.cachePath))
			{
				Directory.CreateDirectory(ImageCache.cachePath);
			}

			if (File.Exists(statePath))
			{
				using (FileStream s = File.OpenRead(statePath))
				{
					return Serializer.Deserialize<State>(s);
				}
			}
			return new State();
		}

		internal void Save()
		{
			foreach (string key in Tags.Keys.ToList())
			{
				if (Tags[key].Count == 0)
				{
					Tags.Remove(key);
				}
			}
			foreach (string key in TagState.Keys.ToList())
			{
				if (!Tags.ContainsKey(key))
				{
					TagState.Remove(key);
				}
			}

			if (File.Exists(savePath))
				File.Delete(savePath);

			using (FileStream s = File.Open(savePath, FileMode.CreateNew, FileAccess.Write))
			{
				Serializer.Serialize(s, this);
			}

			if (File.Exists(statePath))
				File.Delete(statePath);

			File.Move(savePath, statePath);
		}

		[ProtoBeforeSerialization]
		private void Sort()
		{
			foreach (var tag in Tags)
			{
				tag.Value.Sort();
			}
		}

		[ProtoAfterDeserialization]
		private void AfterDeserialization()
		{
			CreatePredicates();
			CreateAllGamesIfNoFilterExists();
		}

		private void CreatePredicates()
		{
			foreach (var filter in Filters)
			{
				filter.Value.CreatePredicate(this);
			}
		}

		private void CreateAllGamesIfNoFilterExists()
		{
			if (Filters.Count == 0)
				Filters.Add("All games", new Filter("All games", "true", this));
		}
	}
}