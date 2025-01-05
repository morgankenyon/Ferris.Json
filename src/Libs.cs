using System.Reflection;

namespace Ferris.Json;
internal static class Libs
{
    internal static void MapValue(PropertyInfo propertyInfo, object instance, TokenInfo dataInfo)
    {
        if (!dataInfo.HasValue)
        {
            return;
        }
        object data = dataInfo.Data!;

        var propertyType = propertyInfo.PropertyType;
        if (propertyType == typeof(string)
            || propertyType.BaseType == typeof(object)
            || propertyType.IsArray)
        {
            var stringValue = data.ToString();
            if (stringValue != null && stringValue.StartsWith("null"))
            {
                propertyInfo.SetValue(instance, null);
            }
            else
            {
                propertyInfo.SetValue(instance, data);
            }
        }
        else
        {
            var stringData = (string)data;
            if (propertyType == typeof(int))
            {
                if (int.TryParse(stringData, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(uint))
            {
                if (uint.TryParse(stringData, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(float))
            {
                if (float.TryParse(stringData, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(double))
            {
                if (double.TryParse(stringData, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(bool))
            {
                if (bool.TryParse(stringData, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(byte))
            {
                if (byte.TryParse(stringData, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(sbyte))
            {
                if (sbyte.TryParse(stringData, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(char))
            {
                if (char.TryParse(stringData, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(decimal))
            {
                if (decimal.TryParse(stringData, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(long))
            {
                if (long.TryParse(stringData, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(ulong))
            {
                if (ulong.TryParse(stringData, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(Int128))
            {
                if (Int128.TryParse(stringData, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(UInt128))
            {
                if (UInt128.TryParse(stringData, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(short))
            {
                if (short.TryParse(stringData, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(ushort))
            {
                if (ushort.TryParse(stringData, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(DateTime))
            {
                if (DateTime.TryParse(stringData, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            //add else statement
        }
    }
}
