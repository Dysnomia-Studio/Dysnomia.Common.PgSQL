/*
	MIT License

	Copyright (c) 2019 Axel "Elanis" Soupé

	Permission is hereby granted, free of charge, to any person obtaining a copy
	of this software and associated documentation files (the "Software"), to deal
	in the Software without restriction, including without limitation the rights
	to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
	copies of the Software, and to permit persons to whom the Software is
	furnished to do so, subject to the following conditions:

	The above copyright notice and this permission notice shall be included in all
	copies or substantial portions of the Software.

	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
	IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
	FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
	AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
	LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
	OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
	SOFTWARE.
*/
using System;
using System.Data;

namespace Dysnomia.Common.SQL {
	public static class DbReaderMapper {
		/**
		 * String from reader
		 */
		public static string GetString(this IDataReader reader, string key, bool catchNull = true, string defaultValue = "") {
			var id = reader.GetOrdinal(key);

			if(!catchNull || !reader.IsDBNull(id)) {
				return reader.GetString(id);
			}

			return defaultValue;
		}

		/**
		* Short/Int16 from reader
		*/
		public static short GetInt16(this IDataReader reader, string key, bool catchNull = true, short defaultValue = 0) {
			var id = reader.GetOrdinal(key);

			if(!catchNull || !reader.IsDBNull(id)) {
				return reader.GetInt16(id);
			}

			return defaultValue;
		}
		public static short GetShort(this IDataReader reader, string key, bool catchNull = true, short defaultValue = 0) {
			return GetInt16(reader, key, catchNull, defaultValue);
		}

		/**
		 * Nullable Short/Int16 from reader
		 */
		public static short? GetNullableInt16(this IDataReader reader, string key) {
			var id = reader.GetOrdinal(key);

			if(!reader.IsDBNull(id)) {
				return reader.GetInt16(id);
			}

			return null;
		}
		public static short? GetNullableShort(this IDataReader reader, string key) {
			return GetShort(reader, key);
		}

		/**
		 * Int/Int32 from reader
		 */
		public static int GetInt32(this IDataReader reader, string key, bool catchNull = true, int defaultValue = 0) {
			var id = reader.GetOrdinal(key);

			if(!catchNull || !reader.IsDBNull(id)) {
				return reader.GetInt32(id);
			}

			return defaultValue;
		}
		public static int GetInt(this IDataReader reader, string key, bool catchNull = true, short defaultValue = 0) {
			return GetInt32(reader, key, catchNull, defaultValue);
		}

		/**
		 * Nullable Int/Int32 from reader
		 */
		public static int? GetNullableInt32(this IDataReader reader, string key) {
			var id = reader.GetOrdinal(key);

			if(!reader.IsDBNull(id)) {
				return reader.GetInt32(id);
			}

			return null;
		}
		public static int? GetNullableInt(this IDataReader reader, string key) {
			return GetNullableInt32(reader, key);
		}

		/**
		 * Int/Int32 from reader
		 */
		public static long GetInt64(this IDataReader reader, string key, bool catchNull = true, long defaultValue = 0) {
			var id = reader.GetOrdinal(key);

			if(!catchNull || !reader.IsDBNull(id)) {
				return reader.GetInt64(id);
			}

			return defaultValue;
		}
		public static long GetLong(this IDataReader reader, string key, bool catchNull = true, long defaultValue = 0) {
			return GetInt64(reader, key, catchNull, defaultValue);
		}

		/**
		 * Nullable Int/Int32 from reader
		 */
		public static long? GetNullableInt64(this IDataReader reader, string key) {
			var id = reader.GetOrdinal(key);

			if(!reader.IsDBNull(id)) {
				return reader.GetInt64(id);
			}

			return null;
		}
		public static long? GetNullableLong(this IDataReader reader, string key) {
			return GetNullableInt64(reader, key);
		}

		/**
		 * Decimal from reader
		 */
		public static decimal GetDecimal(this IDataReader reader, string key, bool catchNull = true, decimal defaultValue = 0) {
			var id = reader.GetOrdinal(key);

			if(!catchNull || !reader.IsDBNull(id)) {
				return reader.GetDecimal(id);
			}

			return defaultValue;
		}

		/**
		 * Nullable Decimal from reader
		 */
		public static decimal? GetNullableDecimal(this IDataReader reader, string key) {
			var id = reader.GetOrdinal(key);

			if(!reader.IsDBNull(id)) {
				return reader.GetDecimal(id);
			}

			return null;
		}

		/**
		 * Boolean from reader
		 */
		public static bool GetBoolean(this IDataReader reader, string key, bool catchNull = true, bool defaultValue = false) {
			var id = reader.GetOrdinal(key);

			if(!catchNull || !reader.IsDBNull(id)) {
				return reader.GetBoolean(id);
			}

			return defaultValue;
		}

		/**
		 * DateTime from reader
		 */
		public static DateTime GetDateTime(this IDataReader reader, string key, bool catchNull = true, DateTime defaultValue = new DateTime()) {
			var id = reader.GetOrdinal(key);

			if(!catchNull || !reader.IsDBNull(id)) {
				return reader.GetDateTime(id);
			}

			return defaultValue;
		}

		/**
		 * Nullable DateTime from reader
		 */
		public static DateTime? GetNullableDateTime(this IDataReader reader, string key) {
			var id = reader.GetOrdinal(key);

			if(!reader.IsDBNull(id)) {
				return reader.GetDateTime(id);
			}

			return null;
		}

		/**
		 * Guid
		 */
		public static Guid GetGuid(this IDataReader reader, string key, bool catchNull, Guid defaultValue) {
			var id = reader.GetOrdinal(key);

			if(!catchNull || !reader.IsDBNull(id)) {
				return reader.GetGuid(id);
			}

			return defaultValue;
		}
		public static Guid GetGuid(this IDataReader reader, string key, bool catchNull, string guidData) {
			return GetGuid(reader, key, catchNull, Guid.Parse(guidData));
		}
		public static Guid GetGuid(this IDataReader reader, string key, bool catchNull = true) {
			return GetGuid(reader, key, catchNull, Guid.Empty);
		}
	}
}