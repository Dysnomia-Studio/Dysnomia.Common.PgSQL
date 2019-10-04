using System;
using System.Data;

namespace Dysnomia.Common.SQL.Common {
	public static class DbReaderMapper {
		/**
		 * String from reader
		 */
		public static string GetString(IDataReader reader, string key, bool catchNull = true, string defaultValue = "") {
			var id = reader.GetOrdinal(key);

			if (!catchNull || !reader.IsDBNull(id)) {
				return reader.GetString(id);
			}

			return defaultValue;
		}

		/**
		* Short/Int16 from reader
		*/
		public static short GetShort(IDataReader reader, string key, bool catchNull = true, short defaultValue = 0) {
		var id = reader.GetOrdinal(key);

		if (!catchNull || !reader.IsDBNull(id)) {
			return reader.GetInt16(id);
		}

		return defaultValue;
		}
		public static short GetInt16(IDataReader reader, string key, bool catchNull = true, short defaultValue = 0) {
			return GetShort(reader, key, catchNull, defaultValue);
		}

		/**
		 * Nullable Short/Int16 from reader
		 */
		public static short? GetNullableInt16(IDataReader reader, string key) {
			var id = reader.GetOrdinal(key);

			if (!reader.IsDBNull(id)) {
				return reader.GetInt16(id);
			}

			return null;
		}
		public static short? GetInt16(IDataReader reader, string key) {
			return GetShort(reader, key);
		}

		/**
		 * Int/Int32 from reader
		 */
		public static int GetInt32(IDataReader reader, string key, bool catchNull = true, int defaultValue = 0) {
			var id = reader.GetOrdinal(key);

			if (!catchNull || !reader.IsDBNull(id)) {
				return reader.GetInt32(id);
			}

			return defaultValue;
		}
		public static int GetInt(IDataReader reader, string key, bool catchNull = true, short defaultValue = 0) {
			return GetInt32(reader, key, catchNull, defaultValue);
		}

		/**
		 * Nullable Int/Int32 from reader
		 */
		public static int? GetNullableInt32(IDataReader reader, string key) {
			var id = reader.GetOrdinal(key);

			if (!reader.IsDBNull(id)) {
				return reader.GetInt32(id);
			}

			return null;
		}
		public static int? GetNullableInt(IDataReader reader, string key) {
			return GetNullableInt32(reader, key);
		}

		/**
		 * Int/Int32 from reader
		 */
		public static long GetInt64(IDataReader reader, string key, bool catchNull = true, long defaultValue = 0) {
			var id = reader.GetOrdinal(key);

			if (!catchNull || !reader.IsDBNull(id)) {
				return reader.GetInt32(id);
			}

			return defaultValue;
		}
		public static long GetLong(IDataReader reader, string key, bool catchNull = true, long defaultValue = 0) {
			return GetInt64(reader, key, catchNull, defaultValue);
		}

		/**
		 * Nullable Int/Int32 from reader
		 */
		public static long? GetNullableInt64(IDataReader reader, string key) {
			var id = reader.GetOrdinal(key);

			if (!reader.IsDBNull(id)) {
				return reader.GetInt32(id);
			}

			return null;
		}
		public static long? GetNullableLong(IDataReader reader, string key) {
			return GetNullableInt64(reader, key);
		}

		/**
		 * Boolean from reader
		 */
		public static bool GetBoolean(IDataReader reader, string key, bool catchNull = true, bool defaultValue = false) {
			var id = reader.GetOrdinal(key);

			if (!catchNull || !reader.IsDBNull(id)) {
				return reader.GetBoolean(id);
			}

			return defaultValue;
		}

		/**
		 * DateTime from reader
		 */
		public static DateTime GetDateTime(IDataReader reader, string key, bool catchNull = true, DateTime defaultValue = new DateTime()) {
			var id = reader.GetOrdinal(key);

			if (!catchNull || !reader.IsDBNull(id)) {
				return reader.GetDateTime(id);
			}

			return defaultValue;
		}

		/**
		 * Nullable DateTime from reader
		 */
		public static DateTime? GetNullableDateTime(IDataReader reader, string key) {
			var id = reader.GetOrdinal(key);

			if (!reader.IsDBNull(id)) {
				return reader.GetDateTime(id);
			}

			return null;
		}
	}
}