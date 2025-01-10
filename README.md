# Ferris.Json

A library for serializing and deserializing json.

Current status: 

* Handles a lot of the simple C# and json string use cases.
* Does not handle more complex C# types
* Does not handle invalid json string well

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
- [x] - handle nested quotes in strings
- [ ] - Supporting enums
- [ ] - gracefully handling invalid json
- [ ] - handle other types of whitespace (needed???)
- [ ] - add serialization options (pretty print, DateTime format, enums to strings, etc)
- [ ] - Supporting data classes
- [ ] - Supporting classes with constructors
- [ ] - handle numbers with exponents
- [ ] - deserializing IList<T> types
- [ ] - support hex
- [ ] - c# dictionaries???
- [ ] - other ienumerable types
- [ ] - non generic data structures
- [ ] - different input types (streams, etc)
- [ ] - F# support