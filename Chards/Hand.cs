using System;
using System.Collections.Generic;

namespace English.Chard
{
	public class Hand : IResource<Chard>
	{
		public List<Chard> Chards { get; set; }
		public int Current { get; set; }
		public int Maximum { get; set; }

		public void Add(Chard t)
		{
			Chards.Add(t);
		}

		public void Remove(Chard t)
		{
			throw new NotImplementedException();
		}
	}
}
