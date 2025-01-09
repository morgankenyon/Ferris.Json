# Ferris.Json

A library for serializing and deserializing json.

Current status: not ready to be used for anything.

## Usages

### Serializing
```csharp
var obj = new TestObject
{
    Property = "string"
};

var jsonString = JsonTransformer.Serialize(obj);
```

### Deserializing
```csharp
var jsonString = "{\"Property\":\"string\"}"

var obj = JsonTransformer.Deserialize<TestObject>(jsonString);
```

## Code structure

* `/src` - contains all source code for Ferris.Json
* `/test` - contains all tests for Ferris.Json
* `/benchmark` - contains benchmarks between Ferris.Json, Newtonsoft and System.Text.Json

## Features

- [x] - serializing basic types
- [x] - serializing nested objects
- [x] - deserializing basic types
- [x] - deserializing nested object
- [x] - serializing IEnumerable of object types
- [x] - serializing IEnumerable of primitive (string, bool, etc) types
- [x] - serializing arrays ([])
- [x] - handling empty whitespace
- [x] - deserializing List<T> types
- [x] - deserializing arrays ([])
- [x] - handle nulls while deserializing
- [x] - handling null values in C# while serializing
- [ ] - handle nested quotes in strings
- [ ] - gracefully handling invalid json
- [ ] - handle other types of whitespace (needed???)
- [ ] - add serialization options (pretty print, DateTime format, etc)
- [ ] - handle numbers with exponents
- [ ] - deserializing IList<T> types
- [ ] - support hex
- [ ] - c# dictionaries???
- [ ] - other ienumerable types
- [ ] - non generic data structures
- [ ] - different input types (streams, etc)
- [ ] - F# support
- [ ] - Supporting data classes
- [ ] - Supporting enums

## Todo items

- [ ] - How does parsing Double.MaxValue/Double.MinValue impact numbers: https://stackoverflow.com/questions/4441782/why-does-double-tryparse-return-false-for-a-string-containing-double-maxvalue