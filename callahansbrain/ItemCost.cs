using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callahansbrain
{
	class ItemCost
	{
		public int Bmats { get; private set; }
		public int Emats { get; private set; }
		public int Rmats { get; private set; }
		public int Hmats { get; private set; }

		public ItemCost(int bmats, int emats = 0, int rmats = 0, int hmats = 0)
		{
			Bmats = bmats; Emats = emats; Rmats = rmats; Hmats = hmats;
		}
	}
}
