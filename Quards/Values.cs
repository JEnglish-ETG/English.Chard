namespace English.Chard
{
	/// <summary>
	/// Contains the numeric information for a <see cref="Chard.OnPlay"/> or <see cref="Chard.OnDiscard"/>.
	/// </summary>
	public class Values
	{
		/// <summary>
		/// Health to be removed from the target.
		/// </summary>
		public int DamageOut { get; set; }

		/// <summary>
		/// Mana to be removed from the user.
		/// </summary>
		public int ManaCost { get; set; }

		/// <summary>
		/// Health to be added to the user.
		/// </summary>
		public int SelfHealAmount { get; set; }

		/// <summary>
		/// Cards to be added to the users hand.
		/// </summary>
		public int DrawAmount { get; set; }

		/// <summary>
		/// Multiplier.
		/// </summary>
		public int Bonus { get; set; }
	}
}