namespace Ferris.Json.Test.TestObjects;
public static class TestObjs
{

    public static ValueTestObject GetValueTestObject()
    {
        return new ValueTestObject
        {
            BoolProp = true,
            ByteProp = 23,
            SByteProp = 2,
            CharProp = 'c',
            DecimalProp = 4.5m,
            DoubleProp = 232.2,
            FloatProp = 42.2f,
            IntProp = 244,
            UIntProp = 2424242442,
            //NIntProp = 89283,
            //NUIntProp = 8292832,
            LongProp = 28392832,
            ULongProp = 38294294792,
            Int128Prop = 283829922348,
            UInt128Prop = 757281108,
            ShortProp = 23,
            UShortProp = 23422,
            StringProp = "testString"
        };
    }

    public static string GetValueTestObjectJson() => """{"BoolProp":true,"ByteProp":23,"SByteProp":2,"CharProp":"c","DecimalProp":4.5,"DoubleProp":232.2,"FloatProp":42.2,"IntProp":244,"UIntProp":2424242442,"LongProp":28392832,"ULongProp":38294294792,"Int128Prop":283829922348,"UInt128Prop":757281108,"ShortProp":23,"UShortProp":23422,"StringProp":"testString"}""";

}
