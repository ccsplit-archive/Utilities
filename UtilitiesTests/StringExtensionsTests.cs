using System;
using Utilities;
using NUnit.Framework;

namespace UtilitiesTest
{
	[TestFixture]
	public class StringExtensionTests
	{
		#region Variables
		private string _string;
		#endregion

		#region Setup
		[SetUp]
		public void Initialize()
		{
			_string = string.Empty;
		}
		#endregion

		#region Tests
		#region IsDate Tests
		[Test]
		public void TestValidDateNoOutParam ()
		{
			_string = "January 12, 2012";
			Assert.IsTrue (_string.IsDate ());
		}
		
		[Test]
		public void TestInvalidDateNoOutParam ()
		{
			_string = "Not a date string.";
			Assert.IsFalse (_string.IsDate ());
		}
		
		[Test]
		public void TestValidDateOutParam ()
		{
			var expected = DateTime.Now;
			_string = expected.ToString ();
			DateTime actual;
			Assert.IsTrue (_string.IsDate (out actual));
			Assert.AreEqual (expected, actual);
		}
		
		[Test]
		public void TestInvalidDateOutParam ()
		{
			_string = "This is not a date string.";
			DateTime actual;
			Assert.IsFalse (_string.IsDate (out actual));
			Assert.AreEqual (DateTime.MinValue, actual);
		}
		#endregion
		
		#region IsBool Tests
		[Test]
		public void TestValidBoolNoOutParam ()
		{
			_string = "true";
			Assert.IsTrue (_string.IsBool ());
		}
		
		[Test]
		public void TestInvalidBoolNoOutParam ()
		{
			_string = "This is not a boolean.";
			Assert.IsFalse (_string.IsBool ());
		}
		
		[Test]
		public void TestValidBoolOutParam ()
		{
			_string = "TrUe";
			bool actual;
			Assert.IsTrue (_string.IsBool (out actual));
			Assert.IsTrue (actual);
		}
		
		[Test]
		public void TestInvalidBoolOutParam ()
		{
			_string = "This is not a boolean.";
			bool actual;
			Assert.IsFalse (_string.IsBool (out actual));
			Assert.IsFalse (actual);
		}
		#endregion
		
		#region IsFloat Tests
		[Test]
		public void TestValidFloatNoOutParam ()
		{
			_string = "2.34233";
			Assert.IsTrue (_string.IsFloat ());
		}
		
		[Test]
		public void TestInvalidFloatNoOutParam ()
		{
			_string = "This is not a float";
			Assert.IsFalse (_string.IsFloat ());
		}
		
		[Test]
		public void TestValidFloatOutParam ()
		{
			_string = "2.3242342";
			float actual;
			Assert.IsTrue (_string.IsFloat (out actual));
			Assert.IsTrue (2.3242342, actual);
		}
		
		[Test]
		public void TestInvalidFloatOutParam ()
		{
			_string = "This is not a float.";
			float actual;
			Assert.IsFalse (_string.IsFloat (out actual));
			Assert.AreSame (0, actual);
		}
		#endregion
		
		#region IsInt Tests
		[Test]
		public void TestValidIntNoOutParam ()
		{
			_string = "123456";
			Assert.IsTrue (_string.IsInt ());
		}
		
		[Test]
		public void TestInvalidIntNoOutParam ()
		{
			_string = "This is not an int.";
			Assert.IsFalse (_string.IsInt ());
		}
		
		[Test]
		public void TestValidIntOutParam ()
		{
			_string = "9000";
			int actual;
			Assert.IsTrue (_string.IsInt (out actual));
			Assert.AreEqual (9000, actual);
		}
		
		[Test]
		public void TestInvalidIntOutParam ()
		{
			_string = "This is not an int.";
			int actual;
			Assert.IsFalse (_string.IsInt (out actual));
			Assert.AreEqual (0, actual);
		}
		#endregion
		
		#region IsDouble Tests
		[Test]
		public void TestValidDoubleNoOutParam ()
		{
			_string = "9000.00";
			Assert.IsTrue (_string.IsDouble ());
		}
		
		[Test]
		public void TestInvalidDoubleNoOutParam ()
		{
			_string = "This is not a double.";
			Assert.IsFalse (_string.IsDouble ());
		}
		
		[Test]
		public void TestValidDoubleOutParam ()
		{
			_string = "9000.000";
			double actual;
			Assert.IsTrue (_string.IsDouble (out actual));
			Assert.AreEqual (9000.000, actual);
		}
		
		[Test]
		public void TestInvalidDoubleOutParam ()
		{
			_string = "This is not a double.";
			double actual;
			Assert.IsFalse (_string.IsDouble (out actual));
			Assert.AreEqual (0, actual);
		}
		#endregion
		
		#region IsChar Tests
		[Test]
		public void TestValidCharNoOutParam ()
		{
			_string = "C";
			Assert.IsTrue (_string.IsChar ());
		}
		
		[Test]
		public void TestInvalidCharNoOutParam ()
		{
			_string = "This is not a char.";
			Assert.IsFalse (_string.IsChar ());
		}
		
		[Test]
		public void TestValidCharOutParam ()
		{
			_string = "C";
			char actual;
			Assert.IsTrue (_string.IsChar (out actual));
			Assert.AreEqual ('C', actual);
		}
		
		[Test]
		public void TestInvalidCharOutParam ()
		{
			_string = "This is not a char.";
			char actual;
			Assert.IsFalse (_string.IsChar (out actual));
			Assert.AreEqual (0, actual);
		}
		#endregion
		
		#region IsLong Tests
		[Test]
		public void TestValidLongNoOutParam ()
		{
			_string = "9999999999999";
			Assert.IsTrue (_string.IsLong ());
		}
		
		[Test]
		public void TestInvalidLongNoOutParam ()
		{
			_string = "This is not a long.";
			Assert.IsFalse (_string.IsLong ());
		}
		
		[Test]
		public void TestValidLongOutParam ()
		{
			long expected = 9999999999999L;
			_string = "9999999999999";
			long actual;
			Assert.IsTrue (_string.IsLong (out actual));
			Assert.AreEqual (expected, actual);
		}
		
		[Test]
		public void TestInvalidLongTooLarge ()
		{
			_string = "99999999999999999999999999";
			Assert.IsFalse(_string.IsLong());
		}
		#endregion
		#endregion
	}
}

