using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.Chard
{
	/// <summary>
	/// The platform to hold all resources and perform actions. Can be AI or USER controlled.
	/// </summary>
	public class Doll
	{
		/// <summary>
		/// Unique key to identify this doll.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// The display name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The health resource of this doll.
		/// </summary>
		public Health Health { get; set; }

		/// <summary>
		/// The mana resource of this doll.
		/// </summary>
		public ManaPool Mana { get; set; }

		/// <summary>
		/// The hand resource of this doll.
		/// </summary>
		public Hand Hand { get; set; }

		/// The sum of all cards in possession.
		/// </summary>
		public List<Chard> Deck { get; set; }

		/// <summary>
		/// Chards to be added to hand.
		/// </summary>
		public Pile DrawPile { get; set; }

		/// <summary>
		/// Chards removed.
		/// </summary>
		public Pile DiscardPile { get; set; }

		/// <summary>
		/// To draw one card.
		/// </summary>
		public void Draw()
		{
			DrawPile.PickUp();
		}

		/// <summary>
		/// To draw <paramref name="i"/> cards.
		/// </summary>
		/// <param name="i"></param>
		public void Draw(int i)
		{
			DrawPile.PickUp(i);
		}

		/// <summary>
		/// Remove <see cref="Chard"/> <paramref name="c"/> from <see cref="Doll.Hand"/>.
		/// </summary>
		/// <param name="c"></param>
		public void Discard(Chard c)
		{
			c.OnDiscard.Action();

			DiscardPile.PlaceDown(this.Hand, c);
		}

	}
}
