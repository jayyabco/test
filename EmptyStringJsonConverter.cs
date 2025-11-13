using System.Text.Json;
using System.Text.Json.Serialization;

namespace WebApplication1
{
    public sealed class EmptyStringJsonConverter : JsonConverter<string>
    {
        public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.TokenType == JsonTokenType.String ? reader.GetString()! : string.Empty;

        public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
            => writer.WriteStringValue(string.Empty);
    }
}