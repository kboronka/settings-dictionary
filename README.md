# settings-dictionary
Automatically read settings from the database if the dictionary cache object does not contain it.


### Example
```C#
public static void Main(string[] args)
{
	var db = new MockDatabase();
	var settings = new SettingDictionary(db);
	
	foreach (var key in new string[] {"a", "b", "c"})
	{
		Console.WriteLine(string.Format("{0}: {1}", key, settings[key]));
	}
	
	Console.Write("Press any key to continue . . . ");
	Console.ReadKey(true);
}
```
