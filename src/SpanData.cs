using System;

namespace Ferris.Json
{
    ref struct SpanData
    {
        public SpanData(ReadOnlySpan<char> jsonSpan, object value)
        {
            JsonSpan = jsonSpan;
            Value = value;
        }
        public ReadOnlySpan<char> JsonSpan;
        public object Value;
    }
}
