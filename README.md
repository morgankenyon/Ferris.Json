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

var obj = JsonTransformer.Deserialize(jsonString);
```

## Code structure

* `/src` - contains all source code for Ferris.Json
* `/test` - contains all tests for Ferris.Json
* `/benchmark` - contains benchmarks between Ferris.Json, Newtonsoft and System.Text.Json