using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callahansbrain
{
	public class FactoryOrder
	{
		private static int counter;
		private List<FactoryItem> items;
		public List<FactoryItem> Items
		{
			get { return items; }
			private set { items = value; }
		}
		public int UniqueIndentifier { get; private set; }
		public FactoryOrder(List<FactoryItem> items)
		{
			Items = items;
			UniqueIndentifier = counter++;
		}
	}
}
