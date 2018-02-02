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
	public class Pile : IResource<Chard>
	{
		/// <summary>
		/// The chards in the pile.
		/// </summary>
		public List<Chard> Chards { get; set; }

		/// <summary>
		/// The current number of chards in the pile.
		/// </summary>
		public int Current { get; set; }

		/// <summary>
		/// The maximum number of chards allowed in the pile.
		/// </summary>
		public int Maximum { get; set; }

		/// <summary>
		/// Add a chard to the pile.
		/// </summary>
		/// <param name="chard"></param>
		public void Add(Chard chard)
		{
			Chards.Add(chard);
			Current = Chards.Count;
		}

		/// <summary>
		/// Remove a chard from the pile.
		/// </summary>
		/// <param name="t"></param>
		public void Remove(Chard t)
		{
			Chards.Remove(t);
			Current = Chards.Count;
		}

		public Chard Take(int i)
		{
			Chard chardDrawn = Chards.First();
			this.Chards.Remove(chardDrawn);
			return chardDrawn;
		}
	}
}
