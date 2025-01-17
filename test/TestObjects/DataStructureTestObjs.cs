using System.Collections.Generic;

namespace Ferris.Json.Test.TestObjects
{
    public class DictObj<V>
    {
        public Dictionary<string, V> Values { get; set; }
    }
}
