using System;

using Xunit;

namespace Dysnomia.Common.SQL.Tests {
	public class DbNullHelperTest {
		[Fact]
		public void DbNullOrString_EmptyString() {
			Assert.Equal(
				"".DbNullOrString(),
				DBNull.Value
			);
		}

		[Fact]
		public void DbNullOrString_Null() {
			string str = null;

			Assert.Equal(
				str.DbNullOrString(),
				DBNull.Value
			);
		}

		[Fact]
		public void DbNullOrString_String() {
			var str = "data";

			Assert.Equal(
				str.DbNullOrString(),
				str
			);
		}
	}
}
