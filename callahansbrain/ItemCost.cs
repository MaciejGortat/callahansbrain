using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace callahansbrain
{
	public class ItemCost
	{
		[JsonInclude]
		public int Bmats { get; set; }
		[JsonInclude]
		public int Emats { get; set; }
		[JsonInclude]
		public int Rmats { get; set; }
		[JsonInclude]
		public int Hmats { get; set; }

		public ItemCost(int bmats, int emats = 0, int rmats = 0, int hmats = 0)
		{
			Bmats = bmats; Emats = emats; Rmats = rmats; Hmats = hmats;
		}
	}
}
