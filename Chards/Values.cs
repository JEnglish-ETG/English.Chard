namespace English.Chard
{
	public class Values
	{
		/// <summary>
		/// Health to be removed from the target.
		/// </summary>
		public int Damage { get; set; }

		/// <summary>
		/// Mana to be removed from the user.
		/// </summary>
		public int Cost { get; set; }

		/// <summary>
		/// Health to be added to the user.
		/// </summary>
		public int Heal { get; set; }
		/// <summary>
		/// Cards to be added to the users hand.
		/// </summary>
		public int Draw { get; set; }

		/// <summary>
		/// Multiplier.
		/// </summary>
		public int Bonus { get; set; }
	}
}