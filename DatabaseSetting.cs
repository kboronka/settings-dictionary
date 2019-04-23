/*
 * Created by SharpDevelop.
 * User: kboronka
 * Date: 4/23/2019
 * Time: 3:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace settings_dictionary
{
	/// <summary>
	/// Description of ExampleSetting.
	/// </summary>
	public class DatabaseSetting : ISetting
	{
		public DatabaseSetting(IDatabaseConnection connection, string value)
		{
			Value = "!" + value + "!";
		}
		
		public object Value { get; private set; }
		
		public override string ToString()
		{
			return Value.ToString();
		}
	}
}
