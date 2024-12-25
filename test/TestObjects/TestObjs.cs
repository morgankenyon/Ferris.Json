namespace Ferris.Json.Test.TestObjects;
public static class TestObjs
{

    public static ValueTestObject GetValueTestObject()
    {
        return new ValueTestObject
        {
            BoolProp = true,
            ByteProp = byte.MaxValue,
            SByteProp = sbyte.MaxValue,
            CharProp = char.MaxValue,
            DecimalProp = decimal.MaxValue,
            DoubleProp = double.MaxValue,
            FloatProp = float.MaxValue,
            IntProp = int.MaxValue,
            UIntProp = uint.MaxValue,
            //NIntProp = 89283,
            //NUIntProp = 8292832,
            LongProp = long.MaxValue,
            ULongProp = ulong.MaxValue,
            Int128Prop = Int128.MaxValue,
            UInt128Prop = UInt128.MaxValue,
            ShortProp = short.MaxValue,
            UShortProp = ushort.MaxValue,
            StringProp = "maxValue"
        };
    }

    public static string GetValueTestObjectJson() => $"{{\"BoolProp\":true,\"ByteProp\":{byte.MaxValue},\"SByteProp\":{sbyte.MaxValue},\"CharProp\":\"{char.MaxValue}\",\"DecimalProp\":{decimal.MaxValue},\"DoubleProp\":{double.MaxValue},\"FloatProp\":{float.MaxValue},\"IntProp\":{int.MaxValue},\"UIntProp\":{uint.MaxValue},\"LongProp\":{long.MaxValue},\"ULongProp\":{ulong.MaxValue},\"Int128Prop\":{Int128.MaxValue},\"UInt128Prop\":{UInt128.MaxValue},\"ShortProp\":{short.MaxValue},\"UShortProp\":{ushort.MaxValue},\"StringProp\":\"maxValue\"}}";

}
