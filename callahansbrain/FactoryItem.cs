using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callahansbrain
{
	class FactoryItem
	{
		private static int counter;

		public Items ItemIdentifier { get; private set; }
		public int UniqueIndentifier { get; private set; }

		public ItemCost Cost { get; private set; }

		public FactoryItem(Items itemIdentifier, ItemCost cost)
		{
			UniqueIndentifier = counter++;
			ItemIdentifier = itemIdentifier;
			Cost = cost;
		}
	}
}
