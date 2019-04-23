/*
 * Created by SharpDevelop.
 * User: kboronka
 * Date: 4/23/2019
 * Time: 3:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Collections;
using System.Collections.Generic;

namespace settings_dictionary
{
	/// <summary>
	/// Description of SettingDictionary.
	/// </summary>
	public class SettingDictionary : VirtualDictionary<string, ISetting>
	{
		private readonly IDatabaseConnection connection;
		
		public SettingDictionary(IDatabaseConnection connection)
		{
			this.connection = connection;
		}
		
		public ISetting this[string key]
		{
			get
			{
				if (ContainsKey(key))
				{
					return wrappedDictionary[key];
				}
				else
				{
					var newSetting = GetSetting(key);
					wrappedDictionary.Add(key, newSetting);
					return newSetting;
				}
			}
			set
			{
				wrappedDictionary[key] = value;
			}
		}
		
		private ISetting GetSetting(string key)
		{
			return new DatabaseSetting(connection, key);
		}
	}
}




