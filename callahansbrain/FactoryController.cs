using System;
using System.Diagnostics;
using System.Threading.Tasks;
namespace callahansbrain
{
	class FactoryController
	{
		//pole z instancja klasy, to jest jedyna instancja tej klasy
		private static FactoryController instance = null;
		//wlasciwosc posiada tylko geta, nie moze byc zmienianie z zewnatrz klasy
		public static FactoryController Instance
		{
			get
			{
				//jesli instancja nie istnieje to tworzy nowa, a jesli istnieje to zwraca pole instance
				if (instance == null)
				{
					instance = new FactoryController();
				}
				return instance;
			}
		}
		private DataStorage dataStorage = new DataStorage();
		//jedyny konstruktor klasy jest zablokowany z zewnatrz, to oznacza ze poza klasa nie mozna utworzyc jej obiektu
		private FactoryController()
		{
		}
		public async Task LoadData()
		{
			await dataStorage.Deserialize();
			foreach (FactoryItem item in dataStorage.items)
			{
				Debug.WriteLine(item.itemIdentifier.ToString());
			}
		}
	}
}
