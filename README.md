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
- [x] - serializing IEnumerable types
- [x] - serializng arrays ([])
- [ ] - deserializing IEnumerable types
- [ ] - deserializing arrays ([])
- [ ] - handle nulls while deserializing
- [x] - handling empty whitespace
- [ ] - handle other types of whitespace (needed???)
- [ ] - gracefully handling invalid json
- [ ] - handling null values in C# while serializing
- [ ] - add serialization options (pretty print, DateTime format, etc)
- [ ] - handle numbers with exponents
- [ ] - handle nested quotes in strings
- [ ] - support hex
- [ ] - c# dictionaries???
- [ ] - other ienumerable types
- [ ] - non generic data structures
- [ ] - different input types (streams, etc)
