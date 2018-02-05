using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.Chard
{
	/// <summary>
	/// For chard generation.
	/// </summary>
	public static class Generator
	{
		/// <summary>
		/// Generates a random chard with random values.
		/// </summary>
		/// <returns>Random chard.</returns>
		public static Chard GenerateChard()
		{
			Chard rc = new English.Chard.Chard() { };
			rc.Values = GenerateValues();
			rc.Class = GenerateClass();
			rc.Description = GenerateDescription();
			rc.Name = GenerateName();
			return rc;
		}

		/// <summary>
		/// Generate random values for a chard.
		/// </summary>
		/// <returns><see cref="Values"/>.</returns>
		public static Values GenerateValues()
		{
			// TODO
			Values v = new Values() { };
			v.Bonus = 0;
			v.DamageOut = 0;
			v.DrawAmount = 0;
			v.ManaCost = 0;
			v.SelfHealAmount = 0;
			return v;
		}

		private static string GenerateName()
		{
			throw new NotImplementedException();
		}

		private static string GenerateDescription()
		{
			throw new NotImplementedException();
		}

		private static string GenerateClass()
		{
			throw new NotImplementedException();

		}
	}
}
