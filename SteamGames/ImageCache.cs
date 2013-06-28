using System.IO;
using System.Net;

namespace SteamGames
{
	internal static class ImageCache
	{
		internal static Stream Get(int app, string part)
		{
			if (part == "")
				return null;

			var file = string.Format(@"C:\cache\{0}_{1}", app, part);
			if (!File.Exists(file))
			{
				var url = string.Format("http://media.steampowered.com/steamcommunity/public/images/apps/{0}/{1}.jpg", app, part);

				try
				{
					var r = WebRequest.Create(url);
					using (var s = r.GetResponse().GetResponseStream())
					{
						using (var f = File.OpenWrite(file))
						{
							s.CopyTo(f);
						}

					}
				}
				catch (WebException)
				{
					return null;
				}
			}

			return File.OpenRead(file);
		}
	}
}