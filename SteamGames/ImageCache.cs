using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace SteamGames
{
	internal interface IImageReceiver
	{
		void ReceiveImage(Stream stream);
	}

	internal static class ImageCache
	{
		internal static readonly string cachePath = Path.Combine(State.BasePath, "cache");
		internal static Action RedrawNotification;

		internal static void Get(int app, string part, IImageReceiver receiver)
		{
			if (part == "")
				return;

			Task.Run(() =>
			{
				string file = Path.Combine(cachePath, string.Format("{0}_{1}", app, part));
				if (!File.Exists(file))
				{
					string url = string.Format("http://media.steampowered.com/steamcommunity/public/images/apps/{0}/{1}.jpg", app, part);

					try
					{
						WebRequest r = WebRequest.Create(url);
						using (WebResponse response = r.GetResponse())
						using (Stream s = response.GetResponseStream())
						{
							using (FileStream f = File.OpenWrite(file))
							{
								s.CopyTo(f);
							}
						}
					}
					catch (WebException)
					{
						return;
					}
				}

				using (FileStream stream = File.OpenRead(file))
				{
					receiver.ReceiveImage(stream);
				}

				if (RedrawNotification != null)
				{
					Console.WriteLine("Notification");
					RedrawNotification();
				}
			});
		}
	}
}