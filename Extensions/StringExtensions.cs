using System;

namespace Utilities
{
	public static class StringExtensions
	{
		#region IsDate Extension
		/// <summary>
		/// Determines whether the specified string is a Date.
		/// </summary>
		/// <returns>
		/// <c>true</c> the specified string is a date; otherwise, <c>false</c>.
		/// </returns>
		/// <param name='str'>
		/// The string object we are testing.
		/// </param>
		public static bool IsDate(this string str)
		{
			DateTime val;
			return str.IsDate(out val);	
		}
		
		/// <summary>
		/// Determines whether the specified string is a Date.
		/// </summary>
		/// <returns>
		/// <c>true</c> the specified string is a date; otherwise, <c>false</c>.
		/// </returns>
		/// <param name='str'>
		/// The string object we are testing.
		/// </param>
		/// <param name='val'>
		/// The variable that the parsed value will be placed in.
		/// </param>
		public static bool IsDate(this string str, out DateTime val)
		{
			return DateTime.TryParse(str, out val);
		}
		#endregion
		
		#region IsBool Extension
		/// <summary>
		/// Determines whether the specified string is a boolean.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the specified string is a boolean; otherwise, <c>false</c>.
		/// </returns>
		/// <param name='str'>
		/// The string object we are testing.
		/// </param>
		public static bool IsBool(this string str)
		{
			bool val;
			return str.IsBool(out val);
		}
		
		/// <summary>
		/// Determines whether the specified string is a boolean.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the specified string is a boolean; otherwise, <c>false</c>.
		/// </returns>
		/// <param name='str'>
		/// The string object we are testing.
		/// </param>
		/// <param name='val'>
		/// The variable that the parsed value will be placed in.
		/// </param>
		public static bool IsBool(this string str, out bool val)
		{
			return bool.TryParse(str, out val);
		}
		#endregion
		
		#region IsInt Extension
		/// <summary>
		/// Determines whether the specified string is an integer.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the specified string is an integer; otherwise, <c>false</c>.
		/// </returns>
		/// <param name='str'>
		/// The string object we are testing.
		/// </param>
		public static bool IsInt(this string str)
		{
			int val;
			return str.IsInt(out val);
		}
		
		/// <summary>
		/// Determines whether the specified string is an integer.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the specified string is an integer; otherwise, <c>false</c>.
		/// </returns>
		/// <param name='str'>
		/// The string object we are testing.
		/// </param>
		/// <param name='val'>
		/// The variable that the parsed value will be placed in.
		/// </param>
		public static bool IsInt(this string str, out int val)
		{
			return int.TryParse(str, out val);
		}
		#endregion
		
		#region IsFloat Extension
		/// <summary>
		/// Determines whether the specified string is a float.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the specified string is a float; otherwise, <c>false</c>.
		/// </returns>
		/// <param name='str'>
		/// The string object we are testing.
		/// </param>
		public static bool IsFloat(this string str)
		{
			float val;
			return str.IsFloat(out val);
		}
		
		/// <summary>
		/// Determines whether the specified string is a float.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the specified string is a float; otherwise, <c>false</c>.
		/// </returns>
		/// <param name='str'>
		/// The string object we are testing.
		/// </param>
		/// <param name='val'>
		/// The variable that the parsed value will be placed in.
		/// </param>
		public static bool IsFloat(this string str, out float val)
		{
			return float.TryParse(str, out val);
		}
		#endregion
		
		#region IsChar Extension
		/// <summary>
		/// Determines whether the specified string is a char.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the specified string is a char; otherwise, <c>false</c>.
		/// </returns>
		/// <param name='str'>
		/// The string object that we are testing.
		/// </param>
		public static bool IsChar(this string str)
		{
			char val;
			return str.IsChar(out val);
		}
		
		/// <summary>
		/// Determines whether the specified string is a char.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the specified string is a char; otherwise, <c>false</c>.
		/// </returns>
		/// <param name='str'>
		/// The string object that we are testing.
		/// </param>
		/// <param name='val'>
		/// The variable that the parsed value will be placed in.
		/// </param>
		public static bool IsChar(this string str, out char val)
		{
			return char.TryParse(str, out val);
		}
		#endregion
		
		#region IsDouble Extension
		/// <summary>
		/// Determines whether the specified string is a double.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the specified string is a double; otherwise, <c>false</c>.
		/// </returns>
		/// <param name='str'>
		/// The string object we are testing.
		/// </param>
		public static bool IsDouble(this string str)
		{
			double val;
			return str.IsDouble(out val);
		}
		
		/// <summary>
		/// Determines whether the specified string is a double.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the specified string is a double; otherwise, <c>false</c>.
		/// </returns>
		/// <param name='str'>
		/// The string object that we are testing.
		/// </param>
		/// <param name='val'>
		/// The variable that the parsed value will be placed in.
		/// </param>
		public static bool IsDouble(this string str, out double val)
		{
			return double.TryParse(str, out val);
		}
		#endregion
		
		#region IsLong Extension
		/// <summary>
		/// Determines whether the specified string is a long.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the specified string is a long; otherwise, <c>false</c>.
		/// </returns>
		/// <param name='str'>
		/// The string object that we are testing.
		/// </param>
		public static bool IsLong(this string str)
		{
			long val;
			return str.IsLong(out val);
		}
		
		/// <summary>
		/// Determines whether the specified string is a long.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the specified string is a long; otherwise, <c>false</c>.
		/// </returns>
		/// <param name='str'>
		/// The string object that we are testing.
		/// </param>
		/// <param name='val'>
		/// The variable that the parsed value will be placed in.
		/// </param>
		public static bool IsLong(this string str, out long val)
		{
			return long.TryParse(str, out val);
		}
		#endregion
	}
}

