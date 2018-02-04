using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.Chard
{
	/// <summary>
	/// Invokes an attack, heal, card draw, or other moment.
	/// </summary>
	public static class Action
    {
		/// <summary>
		/// Remove <paramref name="c"/>'s damage value from <paramref name="target"/>'s health.
		/// </summary>
		/// <param name="c"></param>
		/// <param name="target"></param>
		public static void Attack(this Chard c,Doll target)
		{
			target.Health.Spend(c.Values.DamageOut);
		}
		/// <summary>
		/// Adds <paramref name="c"/>'s heal value to <paramref name="target"/>'s health.
		/// </summary>
		/// <param name="c">Chard being played.</param>
		/// <param name="target">Self, friend, or opponent.</param>
		public static void Heal(this Chard c,Doll target)
		{
			target.Health.Add(c.Values.SelfHealAmount);
		}
		/// <summary>
		/// Add <paramref name="c"/>'s draw value amount of chards to <paramref name="hand"/> from <paramref name="pile"/>.
		/// </summary>
		/// <param name="c"></param>
		/// <param name="pile"></param>
		/// <param name="hand"></param>
		public static void Draw(this Chard c,Pile pile,Hand hand)
		{
			int drawCount = c.Values.DrawAmount;
			if(drawCount > 1)
			{
				List<Chard> drawn = pile.PickUp(drawCount);
				foreach(Chard ch in drawn)
				{
					hand.Add(ch);
				}
			}
			else
			{
				Chard drawn = pile.PickUp();
				hand.Add(drawn);
			}

		}
	}
}
