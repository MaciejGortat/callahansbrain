using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace callahansbrain
{
	[Serializable]
	public class FactoryItem
	{
		[JsonInclude]
		public ItemType itemIdentifier;
		[JsonInclude]
		public int time;
		[JsonInclude]
		public ItemCost cost;		
		public FactoryItem(ItemType itemIdentifier, ItemCost cost)
		{
			this.itemIdentifier = itemIdentifier;
			this.cost = cost;
		}
	}
}
