
using Xunit;

namespace Dysnomia.Common.SQL.Tests {
	public class TestObject {
		public string Foo { get; set; }
		public int Bar { get; set; }
	}

	public class DataTableHelperTest {
		[Fact]
		public void CreateDataTableFromObject_null() {
			var testObject = new TestObject() {
				Foo = null,
				Bar = 0
			};

			Assert.Equal(
				1,
				DataTableHelper.CreateDataTableFromObject(testObject).Rows.Count
			);
		}

		[Fact]
		public void CreateDataTableFromObject_string() {
			var testObject = new TestObject() {
				Foo = "test",
				Bar = 0
			};

			Assert.Equal(
				1,
				DataTableHelper.CreateDataTableFromObject(testObject).Rows.Count
			);
		}
	}
}
