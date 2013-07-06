using System;

using DynamicExpresso;

using ProtoBuf;

namespace SteamGames
{
	[ProtoContract(SkipConstructor = true)]
	internal sealed class Filter
	{
		[ProtoMember(1)]
		internal readonly string Name;

		[ProtoMember(2)]
		internal readonly string Source;

		private Func<string, int, bool> predicate;
		private int appid;

		internal Filter(string filterName, string source, State state)
		{
			Name = filterName;
			Source = source;
			CreatePredicate(state);
		}

		internal bool Evaluate(Game game)
		{
			appid = game.Id;
			return predicate(game.Name, game.Id);
		}

		public override string ToString()
		{
			return Name;
		}

		internal void CreatePredicate(State state)
		{
			var interpreter = new Interpreter();
			interpreter.SetFunction("tag", new Func<string, bool>(tagName => state.Tags.ContainsKey(tagName) && state.Tags[tagName].Contains(appid)));
			predicate = interpreter.Parse<Func<string, int, bool>>(Source, "name", "appid");
		}
	}
}