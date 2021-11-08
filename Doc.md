<a name='assembly'></a>
# Dysnomia.Common.SQL

## Contents

- [DataTableHelper](#T-Dysnomia-Common-SQL-DataTableHelper 'Dysnomia.Common.SQL.DataTableHelper')
  - [CreateDataTableFromObject\`\`1(myObject)](#M-Dysnomia-Common-SQL-DataTableHelper-CreateDataTableFromObject``1-``0- 'Dysnomia.Common.SQL.DataTableHelper.CreateDataTableFromObject``1(``0)')
- [DbHelper](#T-Dysnomia-Common-SQL-DbHelper 'Dysnomia.Common.SQL.DbHelper')
  - [ExecStoredProcedure(connection,procName,parameters,transaction)](#M-Dysnomia-Common-SQL-DbHelper-ExecStoredProcedure-System-Data-IDbConnection,System-String,System-Collections-Generic-Dictionary{System-String,System-Object},System-Data-IDbTransaction,System-Int32- 'Dysnomia.Common.SQL.DbHelper.ExecStoredProcedure(System.Data.IDbConnection,System.String,System.Collections.Generic.Dictionary{System.String,System.Object},System.Data.IDbTransaction,System.Int32)')
  - [ExecuteNonQuery(connection,sqlStatement,parameters,transaction)](#M-Dysnomia-Common-SQL-DbHelper-ExecuteNonQuery-System-Data-IDbConnection,System-String,System-Collections-Generic-Dictionary{System-String,System-Object},System-Data-IDbTransaction,System-Int32- 'Dysnomia.Common.SQL.DbHelper.ExecuteNonQuery(System.Data.IDbConnection,System.String,System.Collections.Generic.Dictionary{System.String,System.Object},System.Data.IDbTransaction,System.Int32)')
  - [ExecuteQuery(connection,sqlStatement,parameters,transaction)](#M-Dysnomia-Common-SQL-DbHelper-ExecuteQuery-System-Data-IDbConnection,System-String,System-Collections-Generic-Dictionary{System-String,System-Object},System-Data-IDbTransaction,System-Int32- 'Dysnomia.Common.SQL.DbHelper.ExecuteQuery(System.Data.IDbConnection,System.String,System.Collections.Generic.Dictionary{System.String,System.Object},System.Data.IDbTransaction,System.Int32)')
- [DbNullHelper](#T-Dysnomia-Common-SQL-DbNullHelper 'Dysnomia.Common.SQL.DbNullHelper')
  - [DbNullOrString(val)](#M-Dysnomia-Common-SQL-DbNullHelper-DbNullOrString-System-String- 'Dysnomia.Common.SQL.DbNullHelper.DbNullOrString(System.String)')
  - [DbNullOrValue(val)](#M-Dysnomia-Common-SQL-DbNullHelper-DbNullOrValue-System-Object- 'Dysnomia.Common.SQL.DbNullHelper.DbNullOrValue(System.Object)')
- [DbReaderMapper](#T-Dysnomia-Common-SQL-DbReaderMapper 'Dysnomia.Common.SQL.DbReaderMapper')
  - [GetBoolean()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetBoolean-System-Data-IDataReader,System-String,System-Boolean,System-Boolean- 'Dysnomia.Common.SQL.DbReaderMapper.GetBoolean(System.Data.IDataReader,System.String,System.Boolean,System.Boolean)')
  - [GetDateTime()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetDateTime-System-Data-IDataReader,System-String,System-Boolean,System-DateTime- 'Dysnomia.Common.SQL.DbReaderMapper.GetDateTime(System.Data.IDataReader,System.String,System.Boolean,System.DateTime)')
  - [GetDecimal()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetDecimal-System-Data-IDataReader,System-String,System-Boolean,System-Decimal- 'Dysnomia.Common.SQL.DbReaderMapper.GetDecimal(System.Data.IDataReader,System.String,System.Boolean,System.Decimal)')
  - [GetDouble()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetDouble-System-Data-IDataReader,System-String,System-Boolean,System-Double- 'Dysnomia.Common.SQL.DbReaderMapper.GetDouble(System.Data.IDataReader,System.String,System.Boolean,System.Double)')
  - [GetGuid()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetGuid-System-Data-IDataReader,System-String,System-Boolean,System-Guid- 'Dysnomia.Common.SQL.DbReaderMapper.GetGuid(System.Data.IDataReader,System.String,System.Boolean,System.Guid)')
  - [GetGuid()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetGuid-System-Data-IDataReader,System-String,System-Boolean,System-String- 'Dysnomia.Common.SQL.DbReaderMapper.GetGuid(System.Data.IDataReader,System.String,System.Boolean,System.String)')
  - [GetGuid()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetGuid-System-Data-IDataReader,System-String,System-Boolean- 'Dysnomia.Common.SQL.DbReaderMapper.GetGuid(System.Data.IDataReader,System.String,System.Boolean)')
  - [GetInt()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetInt-System-Data-IDataReader,System-String,System-Boolean,System-Int32- 'Dysnomia.Common.SQL.DbReaderMapper.GetInt(System.Data.IDataReader,System.String,System.Boolean,System.Int32)')
  - [GetInt16()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetInt16-System-Data-IDataReader,System-String,System-Boolean,System-Int16- 'Dysnomia.Common.SQL.DbReaderMapper.GetInt16(System.Data.IDataReader,System.String,System.Boolean,System.Int16)')
  - [GetInt32()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetInt32-System-Data-IDataReader,System-String,System-Boolean,System-Int32- 'Dysnomia.Common.SQL.DbReaderMapper.GetInt32(System.Data.IDataReader,System.String,System.Boolean,System.Int32)')
  - [GetInt64()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetInt64-System-Data-IDataReader,System-String,System-Boolean,System-Int64- 'Dysnomia.Common.SQL.DbReaderMapper.GetInt64(System.Data.IDataReader,System.String,System.Boolean,System.Int64)')
  - [GetLong()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetLong-System-Data-IDataReader,System-String,System-Boolean,System-Int64- 'Dysnomia.Common.SQL.DbReaderMapper.GetLong(System.Data.IDataReader,System.String,System.Boolean,System.Int64)')
  - [GetNullableBoolean()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableBoolean-System-Data-IDataReader,System-String- 'Dysnomia.Common.SQL.DbReaderMapper.GetNullableBoolean(System.Data.IDataReader,System.String)')
  - [GetNullableDateTime()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableDateTime-System-Data-IDataReader,System-String- 'Dysnomia.Common.SQL.DbReaderMapper.GetNullableDateTime(System.Data.IDataReader,System.String)')
  - [GetNullableDecimal()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableDecimal-System-Data-IDataReader,System-String- 'Dysnomia.Common.SQL.DbReaderMapper.GetNullableDecimal(System.Data.IDataReader,System.String)')
  - [GetNullableDouble()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableDouble-System-Data-IDataReader,System-String- 'Dysnomia.Common.SQL.DbReaderMapper.GetNullableDouble(System.Data.IDataReader,System.String)')
  - [GetNullableGuid()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableGuid-System-Data-IDataReader,System-String- 'Dysnomia.Common.SQL.DbReaderMapper.GetNullableGuid(System.Data.IDataReader,System.String)')
  - [GetNullableInt()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableInt-System-Data-IDataReader,System-String- 'Dysnomia.Common.SQL.DbReaderMapper.GetNullableInt(System.Data.IDataReader,System.String)')
  - [GetNullableInt16()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableInt16-System-Data-IDataReader,System-String- 'Dysnomia.Common.SQL.DbReaderMapper.GetNullableInt16(System.Data.IDataReader,System.String)')
  - [GetNullableInt32()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableInt32-System-Data-IDataReader,System-String- 'Dysnomia.Common.SQL.DbReaderMapper.GetNullableInt32(System.Data.IDataReader,System.String)')
  - [GetNullableInt64()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableInt64-System-Data-IDataReader,System-String- 'Dysnomia.Common.SQL.DbReaderMapper.GetNullableInt64(System.Data.IDataReader,System.String)')
  - [GetNullableLong()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableLong-System-Data-IDataReader,System-String- 'Dysnomia.Common.SQL.DbReaderMapper.GetNullableLong(System.Data.IDataReader,System.String)')
  - [GetNullableShort()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableShort-System-Data-IDataReader,System-String- 'Dysnomia.Common.SQL.DbReaderMapper.GetNullableShort(System.Data.IDataReader,System.String)')
  - [GetNullableUInt()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableUInt-System-Data-IDataReader,System-String- 'Dysnomia.Common.SQL.DbReaderMapper.GetNullableUInt(System.Data.IDataReader,System.String)')
  - [GetNullableUInt16()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableUInt16-System-Data-IDataReader,System-String- 'Dysnomia.Common.SQL.DbReaderMapper.GetNullableUInt16(System.Data.IDataReader,System.String)')
  - [GetNullableUInt32()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableUInt32-System-Data-IDataReader,System-String- 'Dysnomia.Common.SQL.DbReaderMapper.GetNullableUInt32(System.Data.IDataReader,System.String)')
  - [GetNullableUInt64()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableUInt64-System-Data-IDataReader,System-String- 'Dysnomia.Common.SQL.DbReaderMapper.GetNullableUInt64(System.Data.IDataReader,System.String)')
  - [GetNullableULong()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableULong-System-Data-IDataReader,System-String- 'Dysnomia.Common.SQL.DbReaderMapper.GetNullableULong(System.Data.IDataReader,System.String)')
  - [GetNullableUShort()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableUShort-System-Data-IDataReader,System-String- 'Dysnomia.Common.SQL.DbReaderMapper.GetNullableUShort(System.Data.IDataReader,System.String)')
  - [GetShort()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetShort-System-Data-IDataReader,System-String,System-Boolean,System-Int16- 'Dysnomia.Common.SQL.DbReaderMapper.GetShort(System.Data.IDataReader,System.String,System.Boolean,System.Int16)')
  - [GetString()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetString-System-Data-IDataReader,System-String,System-Boolean,System-String- 'Dysnomia.Common.SQL.DbReaderMapper.GetString(System.Data.IDataReader,System.String,System.Boolean,System.String)')
  - [GetUInt()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetUInt-System-Data-IDataReader,System-String,System-Boolean,System-UInt32- 'Dysnomia.Common.SQL.DbReaderMapper.GetUInt(System.Data.IDataReader,System.String,System.Boolean,System.UInt32)')
  - [GetUInt16()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetUInt16-System-Data-IDataReader,System-String,System-Boolean,System-UInt16- 'Dysnomia.Common.SQL.DbReaderMapper.GetUInt16(System.Data.IDataReader,System.String,System.Boolean,System.UInt16)')
  - [GetUInt32()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetUInt32-System-Data-IDataReader,System-String,System-Boolean,System-UInt32- 'Dysnomia.Common.SQL.DbReaderMapper.GetUInt32(System.Data.IDataReader,System.String,System.Boolean,System.UInt32)')
  - [GetUInt64()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetUInt64-System-Data-IDataReader,System-String,System-Boolean,System-UInt64- 'Dysnomia.Common.SQL.DbReaderMapper.GetUInt64(System.Data.IDataReader,System.String,System.Boolean,System.UInt64)')
  - [GetULong()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetULong-System-Data-IDataReader,System-String,System-Boolean,System-UInt64- 'Dysnomia.Common.SQL.DbReaderMapper.GetULong(System.Data.IDataReader,System.String,System.Boolean,System.UInt64)')
  - [GetUShort()](#M-Dysnomia-Common-SQL-DbReaderMapper-GetUShort-System-Data-IDataReader,System-String,System-Boolean,System-UInt16- 'Dysnomia.Common.SQL.DbReaderMapper.GetUShort(System.Data.IDataReader,System.String,System.Boolean,System.UInt16)')

<a name='T-Dysnomia-Common-SQL-DataTableHelper'></a>
## DataTableHelper `type`

##### Namespace

Dysnomia.Common.SQL

<a name='M-Dysnomia-Common-SQL-DataTableHelper-CreateDataTableFromObject``1-``0-'></a>
### CreateDataTableFromObject\`\`1(myObject) `method`

##### Summary

Generates a datatable from an object

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| myObject | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any type |

<a name='T-Dysnomia-Common-SQL-DbHelper'></a>
## DbHelper `type`

##### Namespace

Dysnomia.Common.SQL

<a name='M-Dysnomia-Common-SQL-DbHelper-ExecStoredProcedure-System-Data-IDbConnection,System-String,System-Collections-Generic-Dictionary{System-String,System-Object},System-Data-IDbTransaction,System-Int32-'></a>
### ExecStoredProcedure(connection,procName,parameters,transaction) `method`

##### Summary

Execute SQL stored procedure with reader as a result

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| connection | [System.Data.IDbConnection](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.IDbConnection 'System.Data.IDbConnection') | Database connection |
| procName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Procedure to execute |
| parameters | [System.Collections.Generic.Dictionary{System.String,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.Object}') | Statement parameters |
| transaction | [System.Data.IDbTransaction](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.IDbTransaction 'System.Data.IDbTransaction') | (Optional) Transaction this statement should be in |

<a name='M-Dysnomia-Common-SQL-DbHelper-ExecuteNonQuery-System-Data-IDbConnection,System-String,System-Collections-Generic-Dictionary{System-String,System-Object},System-Data-IDbTransaction,System-Int32-'></a>
### ExecuteNonQuery(connection,sqlStatement,parameters,transaction) `method`

##### Summary

Execute SQL query without any result returned

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| connection | [System.Data.IDbConnection](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.IDbConnection 'System.Data.IDbConnection') | Database connection |
| sqlStatement | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Statement to execute |
| parameters | [System.Collections.Generic.Dictionary{System.String,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.Object}') | Statement parameters |
| transaction | [System.Data.IDbTransaction](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.IDbTransaction 'System.Data.IDbTransaction') | (Optional) Transaction this statement should be in |

<a name='M-Dysnomia-Common-SQL-DbHelper-ExecuteQuery-System-Data-IDbConnection,System-String,System-Collections-Generic-Dictionary{System-String,System-Object},System-Data-IDbTransaction,System-Int32-'></a>
### ExecuteQuery(connection,sqlStatement,parameters,transaction) `method`

##### Summary

Execute SQL query with reader as a result

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| connection | [System.Data.IDbConnection](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.IDbConnection 'System.Data.IDbConnection') | Database connection |
| sqlStatement | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Statement to execute |
| parameters | [System.Collections.Generic.Dictionary{System.String,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.Object}') | Statement parameters |
| transaction | [System.Data.IDbTransaction](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.IDbTransaction 'System.Data.IDbTransaction') | (Optional) Transaction this statement should be in |

<a name='T-Dysnomia-Common-SQL-DbNullHelper'></a>
## DbNullHelper `type`

##### Namespace

Dysnomia.Common.SQL

<a name='M-Dysnomia-Common-SQL-DbNullHelper-DbNullOrString-System-String-'></a>
### DbNullOrString(val) `method`

##### Summary

Return string or DbNull if the string is null or empty

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| val | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Dysnomia-Common-SQL-DbNullHelper-DbNullOrValue-System-Object-'></a>
### DbNullOrValue(val) `method`

##### Summary

Return value or DbNull if the value is null

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| val | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |

<a name='T-Dysnomia-Common-SQL-DbReaderMapper'></a>
## DbReaderMapper `type`

##### Namespace

Dysnomia.Common.SQL

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetBoolean-System-Data-IDataReader,System-String,System-Boolean,System-Boolean-'></a>
### GetBoolean() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetDateTime-System-Data-IDataReader,System-String,System-Boolean,System-DateTime-'></a>
### GetDateTime() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetDecimal-System-Data-IDataReader,System-String,System-Boolean,System-Decimal-'></a>
### GetDecimal() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetDouble-System-Data-IDataReader,System-String,System-Boolean,System-Double-'></a>
### GetDouble() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetGuid-System-Data-IDataReader,System-String,System-Boolean,System-Guid-'></a>
### GetGuid() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetGuid-System-Data-IDataReader,System-String,System-Boolean,System-String-'></a>
### GetGuid() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetGuid-System-Data-IDataReader,System-String,System-Boolean-'></a>
### GetGuid() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetInt-System-Data-IDataReader,System-String,System-Boolean,System-Int32-'></a>
### GetInt() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetInt16-System-Data-IDataReader,System-String,System-Boolean,System-Int16-'></a>
### GetInt16() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetInt32-System-Data-IDataReader,System-String,System-Boolean,System-Int32-'></a>
### GetInt32() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetInt64-System-Data-IDataReader,System-String,System-Boolean,System-Int64-'></a>
### GetInt64() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetLong-System-Data-IDataReader,System-String,System-Boolean,System-Int64-'></a>
### GetLong() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableBoolean-System-Data-IDataReader,System-String-'></a>
### GetNullableBoolean() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableDateTime-System-Data-IDataReader,System-String-'></a>
### GetNullableDateTime() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableDecimal-System-Data-IDataReader,System-String-'></a>
### GetNullableDecimal() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableDouble-System-Data-IDataReader,System-String-'></a>
### GetNullableDouble() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableGuid-System-Data-IDataReader,System-String-'></a>
### GetNullableGuid() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableInt-System-Data-IDataReader,System-String-'></a>
### GetNullableInt() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableInt16-System-Data-IDataReader,System-String-'></a>
### GetNullableInt16() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableInt32-System-Data-IDataReader,System-String-'></a>
### GetNullableInt32() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableInt64-System-Data-IDataReader,System-String-'></a>
### GetNullableInt64() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableLong-System-Data-IDataReader,System-String-'></a>
### GetNullableLong() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableShort-System-Data-IDataReader,System-String-'></a>
### GetNullableShort() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableUInt-System-Data-IDataReader,System-String-'></a>
### GetNullableUInt() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableUInt16-System-Data-IDataReader,System-String-'></a>
### GetNullableUInt16() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableUInt32-System-Data-IDataReader,System-String-'></a>
### GetNullableUInt32() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableUInt64-System-Data-IDataReader,System-String-'></a>
### GetNullableUInt64() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableULong-System-Data-IDataReader,System-String-'></a>
### GetNullableULong() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetNullableUShort-System-Data-IDataReader,System-String-'></a>
### GetNullableUShort() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetShort-System-Data-IDataReader,System-String,System-Boolean,System-Int16-'></a>
### GetShort() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetString-System-Data-IDataReader,System-String,System-Boolean,System-String-'></a>
### GetString() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetUInt-System-Data-IDataReader,System-String,System-Boolean,System-UInt32-'></a>
### GetUInt() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetUInt16-System-Data-IDataReader,System-String,System-Boolean,System-UInt16-'></a>
### GetUInt16() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetUInt32-System-Data-IDataReader,System-String,System-Boolean,System-UInt32-'></a>
### GetUInt32() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetUInt64-System-Data-IDataReader,System-String,System-Boolean,System-UInt64-'></a>
### GetUInt64() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetULong-System-Data-IDataReader,System-String,System-Boolean,System-UInt64-'></a>
### GetULong() `method`

##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SQL-DbReaderMapper-GetUShort-System-Data-IDataReader,System-String,System-Boolean,System-UInt16-'></a>
### GetUShort() `method`

##### Parameters

This method has no parameters.
