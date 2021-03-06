﻿using System.Drawing;
using System.Windows.Forms;

using BrightIdeasSoftware;

namespace SteamGames
{
	internal sealed class GameRenderer : AbstractRenderer
	{
		private readonly StringFormat sf;
		private Brush SelectionBrush = new SolidBrush(Color.FromKnownColor(KnownColor.Highlight));

		public GameRenderer()
		{
			sf = new StringFormat(StringFormat.GenericTypographic);
			sf.Alignment = StringAlignment.Center;
			sf.Trimming = StringTrimming.EllipsisWord;
		}

		public override bool RenderItem(DrawListViewItemEventArgs e, Graphics g, Rectangle itemBounds, object rowObject)
		{
			if (e.Item.ListView.SelectedItems.Contains(e.Item))
			{
				g.FillRectangle(SelectionBrush, itemBounds);
			}
			else
			{
				g.FillRectangle(Brushes.Black, itemBounds);
			}

			var game = (Game) rowObject;
			if (game.Logo != null)
			{
				g.DrawImage(game.Logo, new Rectangle(itemBounds.Location, new Size(184, 69)));
			}

			g.DrawString(game.Name, e.Item.Font, Brushes.White, new RectangleF(itemBounds.X, itemBounds.Y + 69, 184, 30), sf);
			return true;
		}
	}
}