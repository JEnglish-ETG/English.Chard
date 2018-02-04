using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.Chard
{
	interface IResource<T>
	{
		int Current { get; set; }
		int Maximum { get; set; }

		void Add(T t);
		void Spend(T t);
	}
}
