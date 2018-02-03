using System;
using System.Collections.Generic;

namespace English.Chard
{
	/// <summary>
	/// Visible, current, actionable objects.
	/// </summary>
	public class Hand : IResource<Chard>
	{
		/// <summary>
		/// Chards available.
		/// </summary>
		private List<Chard> Chards { get; set; }

		/// <summary>
		/// The current count of chards available.
		/// </summary>
		public int Current { get; set; }

		/// <summary>
		/// The maximum amount of chards to be held.
		/// </summary>
		public int Maximum { get; set; }

		/// <summary>
		/// Make a chard available.
		/// </summary>
		/// <param name="t"></param>
		public void Add(Chard t)
		{
			Chards.Add(t);
		}

		/// <summary>
		/// Make a chard unavailable.
		/// </summary>
		/// <param name="t"></param>
		public void Remove(Chard t)
		{
			throw new NotImplementedException();
		}
	}
}
