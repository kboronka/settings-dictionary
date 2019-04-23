/*
 * Created by SharpDevelop.
 * User: kboronka
 * Date: 4/23/2019
 * Time: 3:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace settings_dictionary
{
	class Program
	{
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
	}
}