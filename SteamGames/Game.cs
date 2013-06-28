using System.Drawing;
using System.IO;

namespace SteamGames
{
	internal class Game
	{
		internal readonly int Id;
		internal readonly Image Logo;
		internal readonly dynamic game;

		public Game(dynamic game)
		{
			this.game = game;
			Name = game.name;
			Id = (int) game.appid;

			Stream img = ImageCache.Get(Id, (string) game.img_logo_url);
			if (img != null)
				Logo = Image.FromStream(img);
		}

		public string Name { get; private set; }
	}
}