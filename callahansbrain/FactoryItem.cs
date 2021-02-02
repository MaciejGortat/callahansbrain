using System;

namespace callahansbrain
{
	[Serializable]
	public class FactoryItem
	{
		private static int counter;
		public ItemType ItemIdentifier { get; private set; }
		public int UniqueIndentifier { get; private set; }

		public ItemCost Cost { get; private set; }

		public FactoryItem(ItemType itemIdentifier, ItemCost cost)
		{
			UniqueIndentifier = counter++;
			ItemIdentifier = itemIdentifier;
			Cost = cost;
		}
	}
}
