using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QuanLyBanHang.App_code
{

    /// <summary>
    /// Summary description for Accounting2Extension
    /// </summary>
    public static class BaseExtension
    {
        public static string OutputNumber(this object val)
        {
            if (!String.IsNullOrEmpty(val.ToString()))
            {
                return Convert.ToDecimal(val.ToString()).ToString("n0", new System.Globalization.CultureInfo("en-US"));
            }
            return "0";
        }

        public static string OutputDate(this object val)
        {
            if (!String.IsNullOrEmpty(val.ToString()))
            {
                return Convert.ToDateTime(val.ToString()).ToString("dd/MM/yyyy");
            }
            return string.Empty;
        }

        public static string OutputDateWithDateless(this object val, object dateless)
        {
            if (!Convert.ToBoolean(dateless.ToString()) && !String.IsNullOrEmpty(val.ToString()))
            {
                return Convert.ToDateTime(val.ToString()).ToString("dd/MM/yyyy");
            }
            return string.Empty;
        }

        public static bool IsMatch(this string source, string compare)
        {
            return string.Equals(source, compare, StringComparison.OrdinalIgnoreCase);
        }

        public static bool IsMatch(this string source, string compare, bool Ordinal)
        {
            if (Ordinal)
            {
                return string.Equals(source, compare, StringComparison.Ordinal);
            }
            else
            {
                return source.IsMatch(compare);
            }
        }

        public static int EnsureInt(this string value)
        {
            if (Regex.IsMatch(value, @"[0-9]+"))
            {
                return int.Parse(value);
            }
            return 0;
        }

        public static decimal EnsureDecimal(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return 0;
            }
            return decimal.Parse(value.Replace(",", "").Replace(".", ""));
        }
    }

	/// <summary>
	/// Summary description for DataReaderExtensions
	/// </summary>
	public static class DataReaderExtensions
	{
        public static Guid? Get_Guid(this SqlDataReader reader, string fieldName)
        {
            return reader.GetGuid(fieldName, null);
        }

        public static Guid? GetGuid(this SqlDataReader reader, string fieldName, Guid? defaultValue)
        {
            if (reader.IsDBNull(reader.GetOrdinal(fieldName)))
            {
                return defaultValue;
            }
            else
            {
                return reader.GetGuid(reader.GetOrdinal(fieldName));
            }
        }

        public static Int64? GetInt_64(this SqlDataReader reader, string fieldName)
        {
            return reader.GetInt64(fieldName, null);
        }

        public static Int64? GetInt64(this SqlDataReader reader, string fieldName, Int64? defaultValue)
        {
            if (reader.IsDBNull(reader.GetOrdinal(fieldName)))
            {
                return defaultValue;
            }
            else
            {
                return reader.GetInt64(reader.GetOrdinal(fieldName));
            }
        }

        public static String Get_String(this SqlDataReader reader, string fieldName)
        {
            return reader.GetString(fieldName, null);
        }

        public static String GetString(this SqlDataReader reader, string fieldName, string defaultValue)
        {
            if (reader.IsDBNull(reader.GetOrdinal(fieldName)))
            {
                return defaultValue;
            }
            else
            {
                return reader.GetString(reader.GetOrdinal(fieldName));
            }
        }

        public static Decimal? Get_Decimal(this SqlDataReader reader, string fieldName)
        {
            return reader.GetDecimal(fieldName, null);
        }

        public static Decimal? GetDecimal(this SqlDataReader reader, string fieldName, Decimal? defaultValue)
        {
            if (reader.IsDBNull(reader.GetOrdinal(fieldName)))
            {
                return defaultValue;
            }
            else
            {
                return reader.GetDecimal(reader.GetOrdinal(fieldName));
            }
        }

        public static Boolean? Get_Boolean(this SqlDataReader reader, string fieldName)
        {
            return reader.GetBoolean(fieldName, null);
        }

        public static Boolean? GetBoolean(this SqlDataReader reader, string fieldName, Boolean? defaultValue)
        {
            if (reader.IsDBNull(reader.GetOrdinal(fieldName)))
            {
                return defaultValue;
            }
            else
            {
                return reader.GetBoolean(reader.GetOrdinal(fieldName));
            }
        }

        public static DateTime? Get_DateTime(this SqlDataReader reader, string fieldName)
        {
            return reader.GetDateTime(fieldName, null);
        }

        public static DateTime? GetDateTime(this SqlDataReader reader, string fieldName, DateTime? defaultValue)
        {
            if (reader.IsDBNull(reader.GetOrdinal(fieldName)))
            {
                return defaultValue;//new DateTime(0);
            }
            else
            {
                return reader.GetDateTime(reader.GetOrdinal(fieldName));
            }
        }

        public static Int32? Get_Int32(this SqlDataReader reader, string fieldName)
        {
            return reader.GetInt32(fieldName, null);
        }

        public static Int32? GetInt32(this SqlDataReader reader, string fieldName, Int32? defaultValue)
        {
            if (reader.IsDBNull(reader.GetOrdinal(fieldName)))
            {
                return defaultValue;
            }
            else
            {
                return reader.GetInt32(reader.GetOrdinal(fieldName));
            }
        }

        public static double? Get_Double(this SqlDataReader reader, string fieldName)
        {
            return reader.GetDouble(fieldName, null);
        }

        public static double? GetDouble(this SqlDataReader reader, string fieldName, double? defaultValue)
        {
            if (reader.IsDBNull(reader.GetOrdinal(fieldName)))
            {
                return defaultValue;
            }
            else
            {
                return reader.GetDouble(reader.GetOrdinal(fieldName));
            }
        }

        public static float? Get_Float(this SqlDataReader reader, string fieldName)
        {
            return reader.GetFloat(fieldName, null);
        }

        public static float? GetFloat(this SqlDataReader reader, string fieldName, float? defaultValue)
        {
            if (reader.IsDBNull(reader.GetOrdinal(fieldName)))
            {
                return defaultValue;
            }
            else
            {
                return reader.GetFloat(reader.GetOrdinal(fieldName));
            }
        }
	}
}