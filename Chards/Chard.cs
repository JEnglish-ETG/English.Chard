using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.Chard
{
    public class Chard
    {
		public string Class { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
		public Values Values { get; set; }
		public Event OnPlay { get; set; }
		public Event OnDiscard { get; set; }

		public void Play()
		{
			this.Event.Attack();
			
		}
	}
}
