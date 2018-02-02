using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.Chard
{
	public class Doll
	{
		public string Name { get; set; }
		public Health Health { get; set; }
		public ManaPool Mana { get; set; }
		public Hand Hand { get; set; }
		public List<Chard> Deck { get; set; }
		public Pile DrawPile { get; set; }
		public Pile DiscardPile { get; set; }

		public void DrawCard()
		{
			Chard chardDrawn = DrawPile.Chards.First();
			DrawPile.Remove(chardDrawn);
		}

	}
}
