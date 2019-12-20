using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace Dysnomia.Common.SQL {
	public static class DataTableHelper {
		public static DataTable CreateDataTableFromObject<T>(T myObject) {
			Type type = typeof(T);
			var properties = type.GetProperties();

			DataTable dataTable = new DataTable();
			List<object> values = new List<object>();
			foreach(PropertyInfo info in properties) {
				var value = info.GetValue(myObject);

				if((!value.GetType().IsPrimitive && !(value is string) && !(value is DateTime)) ||
					value is IEnumerable) {

					continue;
				}

				if(value == null) {
					value = DBNull.Value;
				}

				dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
				values.Add(value);
			}

			dataTable.Rows.Add(values.ToArray());

			return dataTable;
		}

	}
}
