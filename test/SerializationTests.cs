using Ferris.Json.Test.TestObjects;
using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace Ferris.Json.Test
{
    public class SerializationTests
    {
        [Theory(DisplayName = "Map bool property to Json")]
        [InlineData(true)]
        [InlineData(false)]
        public void JsonTransformer_MapBoolProperty(bool value)
        {
            //Arrange
            var obj = new BoolPropertyObj
            {
                Property = value
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            Assert.Equal($"{{\"Property\":{value.ToString().ToLower()}}}", jsonString);
        }

        [Fact(DisplayName = "Map byte property to Json")]
        public void JsonTransformer_MapByteProperty()
        {
            //Arrange
            var obj = new BytePropertyObj
            {
                Property = 77
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            Assert.Equal("{\"Property\":77}", jsonString);
        }

        [Fact(DisplayName = "Map sbyte property to Json")]
        public void JsonTransformer_MapSByteProperty()
        {
            //Arrange
            var obj = new SBytePropertyObj
            {
                Property = 79
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            Assert.Equal("{\"Property\":79}", jsonString);
        }

        [Fact(DisplayName = "Map char property to Json")]
        public void JsonTransformer_MapCharProperty()
        {
            //Arrange
            var obj = new CharPropertyObj
            {
                Property = 'M'
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            Assert.Equal("{\"Property\":\"M\"}", jsonString);
        }

        [Fact(DisplayName = "Map decimal property to Json")]
        public void JsonTransformer_MapDecimalProperty()
        {
            //Arrange
            var obj = new DecimalPropertyObj
            {
                Property = 23.29m
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            Assert.Equal("{\"Property\":23.29}", jsonString);
        }

        [Fact(DisplayName = "Map double property to Json")]
        public void JsonTransformer_MapDoubleProperty()
        {
            //Arrange
            var obj = new DoublePropertyObj
            {
                Property = 23.1
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            Assert.Equal("{\"Property\":23.1}", jsonString);
        }

        [Fact(DisplayName = "Map float property to Json")]
        public void JsonTransformer_MapFloatProperty()
        {
            //Arrange
            var obj = new FloatPropertyObj
            {
                Property = 23.1f
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            Assert.Equal("{\"Property\":23.1}", jsonString);
        }

        [Fact(DisplayName = "Map int property to Json")]
        public void JsonTransformer_MapIntProperty()
        {
            //Arrange
            var obj = new IntPropertyObj
            {
                Property = 23
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            Assert.Equal("{\"Property\":23}", jsonString);
        }

        [Fact(DisplayName = "Map uint property to Json")]
        public void JsonTransformer_MapUIntProperty()
        {
            //Arrange
            var obj = new UIntPropertyObj
            {
                Property = 223
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            Assert.Equal("{\"Property\":223}", jsonString);
        }

        //[Fact(DisplayName = "Map nint property to Json")]
        //public void JsonTransformer_MapNIntProperty()
        //{
        //    //Arrange
        //    var obj = new NIntPropertyObj
        //    {
        //        Property = 83
        //    };

        //    //Act
        //    var jsonString = JsonTransformer.Serialize(obj);

        //    //Assert
        //    Assert.Equal("{\"Property\":83}", jsonString);
        //}

        //[Fact(DisplayName = "Map nuint property to Json")]
        //public void JsonTransformer_MapNUIntProperty()
        //{
        //    //Arrange
        //    var obj = new NUIntPropertyObj
        //    {
        //        Property = 2277
        //    };

        //    //Act
        //    var jsonString = JsonTransformer.Serialize(obj);

        //    //Assert
        //    Assert.Equal("{\"Property\":2277}", jsonString);
        //}

        [Fact(DisplayName = "Map long property to Json")]
        public void JsonTransformer_MapLongProperty()
        {
            //Arrange
            var obj = new LongPropertyObj
            {
                Property = 832839272
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            Assert.Equal("{\"Property\":832839272}", jsonString);
        }

        [Fact(DisplayName = "Map ulong property to Json")]
        public void JsonTransformer_MapULongProperty()
        {
            //Arrange
            var obj = new ULongPropertyObj
            {
                Property = 2283283927277
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            Assert.Equal("{\"Property\":2283283927277}", jsonString);
        }

        //[Fact(DisplayName = "Map int128 property to Json")]
        //public void JsonTransformer_MapInt128Property()
        //{
        //    //Arrange
        //    var obj = new Int128PropertyObj
        //    {
        //        Property = 828392722342422424
        //    };

        //    //Act
        //    var jsonString = JsonTransformer.Serialize(obj);

        //    //Assert
        //    Assert.Equal("{\"Property\":828392722342422424}", jsonString);
        //}

        //[Fact(DisplayName = "Map uint128 property to Json")]
        //public void JsonTransformer_MapUInt128Property()
        //{
        //    //Arrange
        //    var obj = new UInt128PropertyObj
        //    {
        //        Property = 8328392722342422424
        //    };

        //    //Act
        //    var jsonString = JsonTransformer.Serialize(obj);

        //    //Assert
        //    Assert.Equal("{\"Property\":8328392722342422424}", jsonString);
        //}

        [Fact(DisplayName = "Map short property to Json")]
        public void JsonTransformer_MapShortProperty()
        {
            //Arrange
            var obj = new ShortPropertyObj
            {
                Property = 22
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            Assert.Equal("{\"Property\":22}", jsonString);
        }

        [Fact(DisplayName = "Map ushort property to Json")]
        public void JsonTransformer_MapUShortProperty()
        {
            //Arrange
            var obj = new UShortPropertyObj
            {
                Property = 2283
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            Assert.Equal("{\"Property\":2283}", jsonString);
        }

        [Fact(DisplayName = "Map string property to Json")]
        public void JsonTransformer_MapStringProperty()
        {
            //Arrange
            var obj = new StringPropertyObj
            {
                Property = "FirstTest"
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            Assert.Equal("{\"Property\":\"FirstTest\"}", jsonString);
        }

        [Fact(DisplayName = "Map null string property to Json")]
        public void JsonTransformer_MapNullStringProperty()
        {
            //Arrange
            var obj = new StringPropertyObj();

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            Assert.Equal("{\"Property\":null}", jsonString);
        }

        //[Fact(DisplayName = "Map null property to Json")]
        //public void JsonTransformer_MapNullProperty()
        //{
        //    //Arrange
        //    var obj = new StringPropertyObj();

        //    //Act
        //    var jsonString = JsonTransformer.Serialize(obj);

        //    //Assert
        //    Assert.Equal("{\"Property\":null}", jsonString);
        //}

        [Fact(DisplayName = "Map nested string property to Json")]
        public void JsonTransformer_MapNestedProperti()
        {
            //Arrange
            var obj = new NestedStringObj
            {
                Property = new StringPropertyObj
                {
                    Property = "value"
                }
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            Assert.Equal("{\"Property\":{\"Property\":\"value\"}}", jsonString);
        }

        [Fact(DisplayName = "Map ValueTestObject to Json")]
        public void JsonTransformer_MapValueTestObject()
        {
            //Arrange
            var obj = TestObjs.GetValueTestObject();

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            Assert.Equal(TestObjs.GetValueTestObjectJson(), jsonString);
        }

        [Fact(DisplayName = "Map datetime property to Json")]
        public void JsonTransformer_MapDateTimeProperty()
        {
            //Arrange
            var obj = new DateTimePropertyObj
            {
                Property = DateTime.MinValue,
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            var dateString = obj.Property.ToString("s", System.Globalization.CultureInfo.InvariantCulture);
            Assert.Equal($"{{\"Property\":\"{dateString}\"}}", jsonString);
        }

        [Fact(DisplayName = "Map list property to json array")]
        public void JsonTransformer_MapListProperty()
        {
            //Arrange
            var obj = new ListTestObj
            {
                Strings = new List<StringPropertyObj>
                {
                    new StringPropertyObj
                    {
                        Property = "FirstString"
                    },
                    new StringPropertyObj
                    {
                        Property = "SecondString"
                    }
                }
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            jsonString.Should().Be("{\"Strings\":[{\"Property\":\"FirstString\"},{\"Property\":\"SecondString\"}]}");
        }

        [Fact(DisplayName = "Map linkedlist property to json array")]
        public void JsonTransformer_MapLinkedListProperty()
        {
            //Arrange
            var strings = new LinkedList<StringPropertyObj>();
            strings.AddLast(new StringPropertyObj
            {
                Property = "FirstString"
            });
            strings.AddLast(new StringPropertyObj
            {
                Property = "SecondString"
            });
            var obj = new LinkedListObj
            {
                Strings = strings
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            jsonString.Should().Be("{\"Strings\":[{\"Property\":\"FirstString\"},{\"Property\":\"SecondString\"}]}");
        }

        [Fact(DisplayName = "Map mixed list property to json array")]
        public void JsonTransformer_MapMixedListProperty()
        {
            //Arrange
            var obj = new MixedListTestObj
            {
                Strings = new List<StringPropertyObj>
                {
                    new StringPropertyObj
                    {
                        Property = "FirstString"
                    },
                    new StringPropertyObj
                    {
                        Property = "SecondString"
                    }
                },
                Property = "prop"
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            jsonString.Should().Be("{\"Strings\":[{\"Property\":\"FirstString\"},{\"Property\":\"SecondString\"}],\"Property\":\"prop\"}");
        }

        [Fact(DisplayName = "Map array property to json array")]
        public void JsonTransformer_MapArrayProperty()
        {
            //Arrange
            var obj = new ArrayTestObj
            {
                Strings = new StringPropertyObj[2]
            };

            obj.Strings[0] = new StringPropertyObj
            {
                Property = "FirstString"
            };
            obj.Strings[1] = new StringPropertyObj
            {
                Property = "SecondString"
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            jsonString.Should().Be("{\"Strings\":[{\"Property\":\"FirstString\"},{\"Property\":\"SecondString\"}]}");
        }

        [Fact(DisplayName = "Map string list to json array")]
        public void JsonTransformer_MapStringListProperty()
        {
            //Arrange
            var obj = new StringListTestObj
            {
                Values = new List<string>
                {
                    "one",
                    "two",
                    "three"
                }
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            jsonString.Should().Be("{\"Values\":[\"one\",\"two\",\"three\"]}");
        }

        [Fact(DisplayName = "Map object list to json array")]
        public void JsonTransformer_MapObjectListProperty()
        {
            //Arrange
            var obj = new ObjectListTestObj
            {
                Objects = new List<object>
                {
                    "one",
                    23,
                    '2',
                    23.42m
                }
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            jsonString.Should().Be("{\"Objects\":[\"one\",23,\"2\",23.42]}");
        }

        [Fact(DisplayName = "Map empty list to json")]
        public void JsonTransform_MapEmptyList()
        {
            var obj = new List<string>();

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            jsonString.Should().Be("[]");
        }

        [Fact(DisplayName = "Map simple string list to json")]
        public void JsonTransform_MapSimpleStringList()
        {
            var obj = new List<string>
            {
                "one",
                "two",
                "three"
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            jsonString.Should().Be("[\"one\",\"two\",\"three\"]");
        }

        [Fact(DisplayName = "Map string object list to json")]
        public void JsonTransform_MapListOfStringObjects()
        {
            var obj = new List<StringPropertyObj>
            {
                new StringPropertyObj
                {
                    Property = "Test"
                },
                new StringPropertyObj
                {
                    Property = "Test2"
                }
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            jsonString.Should().Be("[{\"Property\":\"Test\"},{\"Property\":\"Test2\"}]");
        }

        [Fact(DisplayName = "Map int object list to json")]
        public void JsonTransform_MapListOfIntObjects()
        {
            var obj = new List<IntPropertyObj>
            {
                new IntPropertyObj
                {
                    Property = 123
                },
                new IntPropertyObj
                {
                    Property = 234
                }
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            jsonString.Should().Be("[{\"Property\":123},{\"Property\":234}]");
        }

        [Fact(DisplayName = "Map basic dictionary object to json")]
        public void JsonTransform_CanMapDictObjString()
        {
            var obj = new DictObj<string>
            {
                Values = new Dictionary<string, string>()
            };
            obj.Values.Add("test", "value");
            obj.Values.Add("test2", "value2");
            obj.Values.Add("test3", "value3");

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            jsonString.Should().Be("{\"Values\":{\"test\":\"value\",\"test2\":\"value2\",\"test3\":\"value3\"}}");
        }

        [Fact(DisplayName = "Map double dictionary object to json")]
        public void JsonTransform_CanMapDictObjDouble()
        {
            var obj = new DictObj<double>
            {
                Values = new Dictionary<string, double>()
            };
            obj.Values.Add("test", 23.22);
            obj.Values.Add("test2", 982.28);
            obj.Values.Add("test3", 783.39);

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            jsonString.Should().Be("{\"Values\":{\"test\":23.22,\"test2\":982.28,\"test3\":783.39}}");
        }

        [Fact(DisplayName = "Map string dictionary to json")]
        public void JsonTransform_CanMapDictionary()
        {
            var obj = new Dictionary<string, object>
            {
                { "test", "value" },
                { "test2", "value2" },
                { "test3", "value3" }
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            jsonString.Should().Be("{\"test\":\"value\",\"test2\":\"value2\",\"test3\":\"value3\"}");
        }

        [Fact(DisplayName = "Map int dictionary to json")]
        public void JsonTransform_CanMapIntDictionary()
        {
            var obj = new Dictionary<string, int>
            {
                { "test", 1 },
                { "test2", 2 },
                { "test3", 33 }
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            jsonString.Should().Be("{\"test\":1,\"test2\":2,\"test3\":33}");
        }

        [Fact(DisplayName = "Map empty dictionary to json")]
        public void JsonTransform_CanMapEmptyDictionary()
        {
            var obj = new Dictionary<string, int>();

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            jsonString.Should().Be("{}");
        }

        [Fact(DisplayName = "Map object dictionary to json")]
        public void JsonTransform_CanMapObjectDictionary()
        {
            var obj = new Dictionary<string, StringPropertyObj>
            {
                {
                    "test", new StringPropertyObj
                    {
                        Property = "value1"
                    }
                },
                {
                    "test2", new StringPropertyObj
                    {
                        Property = "value2"
                    }
                },
                {
                    "test3", new StringPropertyObj
                    {
                        Property = "value3"
                    }
                }
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            jsonString.Should().Be("{\"test\":{\"Property\":\"value1\"},\"test2\":{\"Property\":\"value2\"},\"test3\":{\"Property\":\"value3\"}}");
        }

        [Fact(DisplayName = "Map sorted int dictionary to json")]
        public void JsonTransform_CanMapSortedIntDictionary()
        {
            var obj = new SortedDictionary<string, int>
            {
                { "test", 1 },
                { "lol", 2 },
                { "apple", 33 }
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            jsonString.Should().Be("{\"apple\":33,\"lol\":2,\"test\":1}");
        }
    }
}
