using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace callahansbrain
{
	public class DataStorage
	{
		//baza danych wszystkich dostepnych itemow
		public List<FactoryItem> items = new List<FactoryItem>();
		//pobranie sciezki do folderu lokalnego
		private StorageFolder localFolder = ApplicationData.Current.LocalFolder;
		//asynchroniczna serializacja danych z pola items
		public async Task Serialize()
		{
			//asynchroniczna proba stworzenia pliku w folderze lokalnym aplikacji, jak istnieje to otwiera istniejacy
			StorageFile dataFile = await localFolder.CreateFileAsync("dataFile.json",
				CreationCollisionOption.OpenIfExists);
			//wykonaj serializacje z uzyciem strumienia danych z wczesniej otwartego pliku
			//OpenAsync() zwraca nam operacje z typem generycznym, ktory nas interesuje IAsyncOperation<IRandomAccessStream>
			//ale my potrzebujemy tylko tego typu IRandomAccessStream, dlatego GetResults()
			//ale my potrzebujemy strumienia Stream, dlatego AsStream(), ktore zamienia IRandomAccessStream na Stream
			//zeby wyczaic jak to dziala siedzialem 3 godziny w dokumentacji, sam w zyciu bym nie wpadl jak to napisac
			//prawdopodobnie da sie prosciej, jak na cos wpadne kiedys to poprawie, albo ty popraw
			using (Stream stream = (await dataFile.OpenAsync(FileAccessMode.ReadWrite)).AsStream())
			{
				//wykonanie serializacji i wyslanie tego do strumienia, tez asynchronicznie
				//dodatkowa opcja WriteIndented zapisuje w czytelnej postaci, bez tego byloby wszystko w jednej linii
				await JsonSerializer.SerializeAsync(stream, items, new JsonSerializerOptions() { WriteIndented = true });
			}
		}
		public async Task Deserialize()
		{
			//asynchroniczne otwieranie jsona z assetow
			StorageFile dataFile = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Assets/dataFile.json"));
			using (Stream stream = (await dataFile.OpenAsync(FileAccessMode.Read)).AsStream())
			{
				items = (await JsonSerializer.DeserializeAsync<List<FactoryItem>>(stream));
			}
		}
	}
}
