namespace English.Chard
{
	/// <summary>
	/// The storage of a doll's energy.
	/// </summary>
	public class ManaPool : IResource<int>
	{
		/// <summary>
		/// The current supply of Mana available.
		/// </summary>
		public int Current { get; set; }

		/// <summary>
		/// The maximum amount of mana to be held.
		/// </summary>
		public int Maximum { get; set; }

		/// <summary>
		/// Increase current mana by <paramref name="t"/>.
		/// </summary>
		/// <param name="t">Mana to be added.</param>
		public void Add(int t)
		{
			if(Current < Maximum - t)
				Current += t;
		}

		/// <summary>
		/// Decrease the current mana by <paramref name="t"/>
		/// </summary>
		/// <param name="t">Amount of mana expended.</param>
		public void Remove(int t)
		{
			if(Current > t)
				Current -= t;
		}
	}
}
