using System.Drawing;
using System.IO;

namespace SteamGames
{
	internal class Game : IImageReceiver
	{
		internal readonly int Id;
		internal readonly dynamic game;

		public Game(dynamic game)
		{
			this.game = game;
			Name = game.name;
			Id = (int) game.appid;

		}

		public string Name { get; private set; }

		private Image logo;
		private bool requested;
		internal Image Logo
		{
			get
			{
				if (logo == null && !requested)
				{
					requested = true;
					ImageCache.Get(Id, (string)game.img_logo_url, this);
				}
				return logo;
			}
		}

		public void ReceiveImage(Stream stream)
		{
			logo = Image.FromStream(stream);
		}
	}
}