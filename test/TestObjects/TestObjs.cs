namespace Ferris.Json.Test.TestObjects;
public static class TestObjs
{
    public static StringPropertyObj GetStringTestObject()
    {
        return new StringPropertyObj
        {
            Property = "testProperty"
        };
    }

    public static string GetStringTestObjectJson() =>
        $"{{\"Property\":\"testProperty\"}}";

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

    public static MixedListTestObj GetListTestObject()
    {
        return new MixedListTestObj
        {
            Strings = new List<StringPropertyObj>
            {
                new StringPropertyObj
                {
                    Property = "Test1"
                },
                new StringPropertyObj
                {
                    Property = "Test2"
                },
                new StringPropertyObj
                {
                    Property = "Test3"
                },
                new StringPropertyObj
                {
                    Property = "Test4"
                }
            },
            Property = "BaseString"
        };
    }

    public static string GetListTestObjectJson() =>
        $"{{\"Strings\":[{{\"Property\":\"Test1\"}},{{\"Property\":\"Test2\"}},{{\"Property\":\"Test3\"}},{{\"Property\":\"Test4\"}},\"Property\":\"BaseString\"]}}";
}
