using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.Chard
{
	/// <summary>
	/// A container to hold chards.
	/// </summary>
	public class Pile
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		public Pile()
		{
		}

		/// <summary>
		/// The chards in the pile.
		/// </summary>
		private List<Chard> Chards { get; set; }

		/// <summary>
		/// Add a chard to the pile.
		/// </summary>
		/// <param name="chard"></param>
		private void Add(Chard chard)
		{
			Chards.Add(chard);
		}

		/// <summary>
		/// Remove a chard from the pile.
		/// </summary>
		/// <param name="t"></param>
		private void Remove(Chard t)
		{
			Chards.Remove(t);
		}

		/// <summary>
		/// Take a number of <seealso cref="Chard"/>s from the pile and return to <see cref="Doll.Hand"/>.
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
		public List<Chard> PickUp(int i)
		{
			List<Chard> chardDrawn = Chards.Take(i).ToList();
			foreach(Chard ch in chardDrawn)
				this.Chards.Remove(ch);

			return chardDrawn;
		}

		/// <summary>
		/// Take a chard from the pile and add it to hand.
		/// </summary>
		/// <returns>Chard</returns>
		public Chard PickUp()
		{
			Chard chardDrawn = Chards.First();
			this.Chards.Remove(chardDrawn);
			return chardDrawn;
		}

		/// <summary>
		/// Remove from <see cref="Doll.Hand"/>; place on this <see cref="Pile"/>.
		/// </summary>
		/// <param name="hand">The <see cref="Doll.Hand"/> which owns <paramref name="c"/>.</param>
		/// <param name="c">The <see cref="Chard"/> placed on this pile.</param>
		public void PlaceDown(Hand hand,Chard c)
		{
			hand.Spend(c);
			this.Chards.Add(c);
		}
	}
}
