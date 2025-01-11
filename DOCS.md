# Ferris.Json Docs

## Tagging Release

* `git tag -a v0.1.0 -m "First release"`
* `git push origin tag v0.1.0`

## Json Spec

https://ecma-international.org/wp-content/uploads/ECMA-404.pdf

## Todo items

- [ ] - How does parsing Double.MaxValue/Double.MinValue impact numbers: https://stackoverflow.com/questions/4441782/why-does-double-tryparse-return-false-for-a-string-containing-double-maxvalue

## Error When Parsing DateTimes

* On test: JsonTransformer_Deserialize_ParseToDateTimeList
  * `<9999-12-31 23:59:59.9999999>, but found <9999-12-31 23:59:59>`
  * Fixed with `obj.Values.Skip(1).First().Should().BeCloseTo(DateTime.MaxValue, TimeSpan.FromSeconds(1));`
* on test: JsonTransformer_Deserialize_ParseToFloatList
  * On .netframework
  * Expected obj.Values[0] to be -3.40282347E+38F, but found -3.402823E+38F.
  * Expected obj.Values[1] to be 3.40282347E+38F, but found 3.402823E+38F.
  * Expected obj.Values[2] to be -3.40282347E+38F, but found -3.402823E+38F.
* on test: JsonTransformer_Deserialize_ParseToDoubleList
  * System.ArgumentException : The value "-1.79769313486232E+308" is not of type "System.Double" and cannot be used in this generic collection.
