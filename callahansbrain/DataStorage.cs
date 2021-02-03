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
		public async void Serialize()
		{
			//asynchroniczna proba stworzenia pliku w folderze lokalnym aplikacji, jak istnieje to otwiera istniejacy
			StorageFile dataFile = await localFolder.CreateFileAsync("dataFile.json",
				CreationCollisionOption.OpenIfExists);
			//wykonaj serializacje z uzyciem strumienia danych z wczesniej otwartego pliku
			//OpenAsync() zwraca nam operacje z typem generycznym, ktory nas interesuje IAsyncOperation<IRandomAccessStream>
			//await obsluguje IAsyncOperation<IRandomAccessStream>, czeka az operacja zostanie wykonana i zwraca IRandomAccessStream
			//ale my potrzebujemy strumienia Stream, dlatego AsStream(), ktore zamienia IRandomAccessStream na Stream
			//zeby wyczaic jak to dziala siedzialem 2 godziny w dokumentacji, sam w zyciu bym nie wpadl jak to napisac
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
			try
			{
				StorageFile sampleFile = await localFolder.GetFileAsync("dataFile.json");
				using (FileStream stream = (FileStream)sampleFile.OpenAsync(FileAccessMode.Read))
				{
					items = JsonSerializer.DeserializeAsync<List<FactoryItem>>(stream).Result;
				}
			}
			catch (FileNotFoundException e)
			{
				Debug.WriteLine("[Error] FileNotFoundException source: {0}", e.Source);
			}
			catch (IOException e)
			{
				Debug.WriteLine("[Error] IOException source: {0}", e.Source);
			}
		}
	}
}
