using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace callahansbrain
{
	[Serializable]
	public class FactoryItem
	{
		private static int counter;
		[JsonInclude]
		public ItemType itemIdentifier;
		[JsonInclude]
		public int uniqueIndentifier;
		[JsonInclude]
		public ItemCost cost;
		public FactoryItem(ItemType itemIdentifier, ItemCost cost)
		{
			uniqueIndentifier = counter++;
			this.itemIdentifier = itemIdentifier;
			this.cost = cost;
		}
	}
}
