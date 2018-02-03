using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.Chard
{
	/// <summary>
	/// Chard is a card. Does something when played.
	/// </summary>
    public class Chard
    {
		private static int t;
		public Chard(string img)
		{
			this.Image = img;
			this.Id = t++;
		}

		public Chard()
		{
			this.Id = t++;
		}

		/// <summary>
		/// The Archetype to which the chard belongs.
		/// </summary>
		public string Class { get; set; }

		/// <summary>
		/// Title of the chard.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Identification number of the chard.
		/// </summary>
		private int Id { get; set; }

		/// <summary>
		/// Describes actions.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// URL or file location of the face of the chard.
		/// </summary>
		private string Image { get; set; }

		/// <summary>
		/// Defines the mana cost, the damage delt, the hp restored, the cards drawn when played.
		/// </summary>
		public Values Values { get; set; }

		/// <summary>
		/// For special events when this chard is played.
		/// </summary>
		public Event OnPlay { get; set; }

		/// <summary>
		/// For special events when this chard is discarded.
		/// </summary>
		public Event OnDiscard { get; set; }

		public void LoadImage()
		{
			
		}
	}
}
