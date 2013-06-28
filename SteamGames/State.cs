using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using ProtoBuf;

namespace SteamGames
{
	[Serializable, ProtoContract]
	internal sealed class State
	{
		private static readonly string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "steamgames.dat");

		[ProtoMember(2)]
		internal ulong SteamId;

		[ProtoMember(4)]
		internal Dictionary<string, CheckState> TagState;

		[ProtoMember(3)]
		internal Dictionary<string, List<int>> Tags;

		[ProtoMember(1)]
		internal string WebApiKey;

		internal static State Load()
		{
			if (File.Exists(savePath))
			{
				using (FileStream s = File.OpenRead(savePath))
				{
					return Serializer.Deserialize<State>(s);
				}
			}
			return new State {Tags = new Dictionary<string, List<int>>(), TagState = new Dictionary<string, CheckState>()};
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

			using (FileStream s = File.Open(savePath, FileMode.Truncate, FileAccess.Write))
			{
				Serializer.Serialize(s, this);
			}
		}
	}
}