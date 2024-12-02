using NSubstitute;

using System;
using System.Collections.Generic;
using System.Data;

using Xunit;

namespace Dysnomia.Common.SQL.Tests {
    public class DbReaderMapperTestObject {
        public string StrElement { get; set; }

        public uint UShortElement { get; set; }
        public uint? NullableUShortElement { get; set; }
        public int ShortElement { get; set; }
        public int? NullableShortElement { get; set; }

        public uint UIntElement { get; set; }
        public uint? NullableUIntElement { get; set; }
        public int IntElement { get; set; }
        public int? NullableIntElement { get; set; }

        public long LongElement { get; set; }
        public long? NullableLongElement { get; set; }
        public ulong UlongElement { get; set; }
        public ulong? NullableUlongElement { get; set; }

        public decimal DecimalElement { get; set; }
        public decimal? NullableDecimalElement { get; set; }

        public double DoubleElement { get; set; }
        public double? NullableDoubleElement { get; set; }

        public bool BoolElement { get; set; }
        public bool? NullableBoolElement { get; set; }

        public DateTime DateTimeElement { get; set; }
        public DateTime? NullableDateElement { get; set; }

        //public Guid GuidElement { get; set; }
        //public Guid? NullableGuidElement { get; set; }
    }

    public class DbReaderMapperTest {
        [Fact]
        public void Tests() {
            var data = new List<DbReaderMapperTestObject> {
                new DbReaderMapperTestObject(),
                new DbReaderMapperTestObject() {
                    StrElement = "",

                    NullableUShortElement = 0,
                    NullableShortElement = 0,

                    NullableUIntElement = 0,
                    NullableIntElement = 0,

                    NullableLongElement = 0,
                    NullableUlongElement = 0,

                    NullableDecimalElement = 0,

                    NullableDoubleElement = 0,

                    NullableBoolElement = false,

                    NullableDateElement = DateTime.Now,
                }
            };

            IDataReader reader = Substitute.For<IDataReader>();

            while (reader.Read()) {
                _ = new DbReaderMapperTestObject() {
                    StrElement = reader.GetString("StrElement"),

                    UShortElement = reader.GetUShort("UShortElement"),
                    NullableUShortElement = reader.GetNullableUShort("NullableUShortElement"),
                    ShortElement = reader.GetShort("ShortElement"),
                    NullableShortElement = reader.GetNullableShort("NullableShortElement"),

                    UIntElement = reader.GetUInt("UIntElement"),
                    NullableUIntElement = reader.GetNullableUInt("NullableUIntElement"),
                    IntElement = reader.GetInt("IntElement"),
                    NullableIntElement = reader.GetNullableInt("NullableIntElement"),

                    LongElement = reader.GetLong("LongElement"),
                    NullableLongElement = reader.GetNullableLong("NullableLongElement"),
                    UlongElement = reader.GetULong("UlongElement"),
                    NullableUlongElement = reader.GetNullableULong("NullableUlongElement"),

                    DecimalElement = reader.GetDecimal("DecimalElement"),
                    NullableDecimalElement = reader.GetNullableDecimal("NullableDecimalElement"),

                    DoubleElement = reader.GetDouble("DoubleElement"),
                    NullableDoubleElement = reader.GetNullableDouble("NullableDoubleElement"),

                    BoolElement = reader.GetBoolean("BoolElement"),
                    NullableBoolElement = reader.GetNullableBoolean("NullableBoolElement"),

                    DateTimeElement = reader.GetDateTime("DateTimeElement"),
                    NullableDateElement = reader.GetNullableDateTime("NullableDateElement"),

                    //GuidElement = reader.GetGuid("GuidElement"),
                    //NullableGuidElement = reader.GetNullableGuid("NullableGuidElement"),
                };
            }
        }
    }
}
