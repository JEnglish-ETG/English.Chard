using System;

namespace English.Chard
{
	/// <summary>
	/// The life points of a doll. At 0, the doll dies.
	/// </summary>
	public class Health : IResource<int>
	{
		/// <summary>
		/// The number of life points available.
		/// </summary>
		public int Current { get; set; }

		/// <summary>
		/// The maximum life to be held.
		/// </summary>
		public int Maximum { get; set; }

		/// <summary>
		/// Increase the number of life points available. 
		/// </summary>
		/// <see cref="Values.SelfHealAmount"/>
		/// <param name="t">Health to be added.</param>
		public void Add(int t)
		{
			Current += t;
		}

		/// <summary>
		/// Decrease the number of life points available.
		/// </summary>
		/// <see cref="Values.DamageOut"/>
		/// <param name="t">Health to be removed.</param>
		public void Spend(int t)
		{
			Current -= t;
		}
	}
}
