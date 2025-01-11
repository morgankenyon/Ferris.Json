using System;
using System.Reflection;

namespace Ferris.Json
{
    internal static class Libs
    {
        internal static (object value, string error) MapValue(Type type, object data)
        {
            if (type == typeof(bool) && bool.TryParse(data.ToString(), out bool boolVal))
            {
                return (boolVal, string.Empty);
            }
            if (type == typeof(byte) && byte.TryParse(data.ToString(), out byte byteVal))
            {
                return (byteVal, string.Empty);
            }
            if (type == typeof(sbyte) && sbyte.TryParse(data.ToString(), out sbyte sbyteVal))
            {
                return (sbyteVal, string.Empty);
            }
            if (type == typeof(char) && char.TryParse(data.ToString(), out char charVal))
            {
                return (charVal, string.Empty);
            }
            if (type == typeof(DateTime) && DateTime.TryParse(data.ToString(), out DateTime dtVal))
            {
                return (dtVal, string.Empty);
            }
            if (type == typeof(decimal) && decimal.TryParse(data.ToString(), out decimal decVal))
            {
                return (decVal, string.Empty);
            }
            if (type == typeof(double) && double.TryParse(data.ToString(), out double doubVal))
            {
                return (doubVal, string.Empty);
            }
            if (type == typeof(float) && float.TryParse(data.ToString(), out float fltVal))
            {
                return (fltVal, string.Empty);
            }
            if (type == typeof(int) && int.TryParse(data.ToString(), out int intVal))
            {
                return (intVal, string.Empty);
            }
            if (type == typeof(uint) && uint.TryParse(data.ToString(), out uint uintVal))
            {
                return (uintVal, string.Empty);
            }
            //if (type == typeof(Int128) && Int128.TryParse(data.ToString(), out var int128Val))
            //{
            //    return (int128Val, string.Empty);
            //}
            //if (type == typeof(UInt128) && UInt128.TryParse(data.ToString(), out var uint128Val))
            //{
            //    return (uint128Val, string.Empty);
            //}
            if (type == typeof(long) && long.TryParse(data.ToString(), out long longVal))
            {
                return (longVal, string.Empty);
            }
            if (type == typeof(ulong) && ulong.TryParse(data.ToString(), out ulong ulongVal))
            {
                return (ulongVal, string.Empty);
            }
            if (type == typeof(short) && short.TryParse(data.ToString(), out short shortVal))
            {
                return (shortVal, string.Empty);
            }
            if (type == typeof(ushort) && ushort.TryParse(data.ToString(), out ushort ushortVal))
            {
                return (ushortVal, string.Empty);
            }
            if (type == typeof(string))
            {
                return (data, string.Empty);
            }

            return (data, string.Empty);
        }
        internal static void MapValue(PropertyInfo propertyInfo, object instance, TokenInfo dataInfo)
        {
            if (!dataInfo.HasValue)
            {
                return;
            }
            object data = dataInfo.Data;

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
                var (result, errorMsg) = MapValue(propertyType, data);
                propertyInfo.SetValue(instance, result);
                //var stringData = (string)data;
                //if (propertyType == typeof(int))
                //{
                //    if (int.TryParse(stringData, out var result))
                //    {
                //        propertyInfo.SetValue(instance, result);
                //    }
                //    else
                //    {
                //        //add error message
                //    }
                //}
                //else if (propertyType == typeof(uint))
                //{
                //    if (uint.TryParse(stringData, out var result))
                //    {
                //        propertyInfo.SetValue(instance, result);
                //    }
                //    else
                //    {
                //        //add error message
                //    }
                //}
                //else if (propertyType == typeof(float))
                //{
                //    if (float.TryParse(stringData, out var result))
                //    {
                //        propertyInfo.SetValue(instance, result);
                //    }
                //    else
                //    {
                //        //add error message
                //    }
                //}
                //else if (propertyType == typeof(double))
                //{
                //    if (double.TryParse(stringData, out var result))
                //    {
                //        propertyInfo.SetValue(instance, result);
                //    }
                //    else
                //    {
                //        //add error message
                //    }
                //}
                //else if (propertyType == typeof(bool))
                //{
                //    if (bool.TryParse(stringData, out var result))
                //    {
                //        propertyInfo.SetValue(instance, result);
                //    }
                //    else
                //    {
                //        //add error message
                //    }
                //}
                //else if (propertyType == typeof(byte))
                //{
                //    if (byte.TryParse(stringData, out var result))
                //    {
                //        propertyInfo.SetValue(instance, result);
                //    }
                //    else
                //    {
                //        //add error message
                //    }
                //}
                //else if (propertyType == typeof(sbyte))
                //{
                //    if (sbyte.TryParse(stringData, out var result))
                //    {
                //        propertyInfo.SetValue(instance, result);
                //    }
                //    else
                //    {
                //        //add error message
                //    }
                //}
                //else if (propertyType == typeof(char))
                //{
                //    if (char.TryParse(stringData, out var result))
                //    {
                //        propertyInfo.SetValue(instance, result);
                //    }
                //    else
                //    {
                //        //add error message
                //    }
                //}
                //else if (propertyType == typeof(decimal))
                //{
                //    if (decimal.TryParse(stringData, out var result))
                //    {
                //        propertyInfo.SetValue(instance, result);
                //    }
                //    else
                //    {
                //        //add error message
                //    }
                //}
                //else if (propertyType == typeof(long))
                //{
                //    if (long.TryParse(stringData, out var result))
                //    {
                //        propertyInfo.SetValue(instance, result);
                //    }
                //    else
                //    {
                //        //add error message
                //    }
                //}
                //else if (propertyType == typeof(ulong))
                //{
                //    if (ulong.TryParse(stringData, out var result))
                //    {
                //        propertyInfo.SetValue(instance, result);
                //    }
                //    else
                //    {
                //        //add error message
                //    }
                //}
                ////else if (propertyType == typeof(Int128))
                ////{
                ////    if (Int128.TryParse(stringData, out var result))
                ////    {
                ////        propertyInfo.SetValue(instance, result);
                ////    }
                ////    else
                ////    {
                ////        //add error message
                ////    }
                ////}
                ////else if (propertyType == typeof(UInt128))
                ////{
                ////    if (UInt128.TryParse(stringData, out var result))
                ////    {
                ////        propertyInfo.SetValue(instance, result);
                ////    }
                ////    else
                ////    {
                ////        //add error message
                ////    }
                ////}
                //else if (propertyType == typeof(short))
                //{
                //    if (short.TryParse(stringData, out var result))
                //    {
                //        propertyInfo.SetValue(instance, result);
                //    }
                //    else
                //    {
                //        //add error message
                //    }
                //}
                //else if (propertyType == typeof(ushort))
                //{
                //    if (ushort.TryParse(stringData, out var result))
                //    {
                //        propertyInfo.SetValue(instance, result);
                //    }
                //    else
                //    {
                //        //add error message
                //    }
                //}
                //else if (propertyType == typeof(DateTime))
                //{
                //    if (DateTime.TryParse(stringData, out var result))
                //    {
                //        propertyInfo.SetValue(instance, result);
                //    }
                //    else
                //    {
                //        //add error message
                //    }
                //}
                //add else statement
            }
        }
    }
}
