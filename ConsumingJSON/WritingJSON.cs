using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsumingJSON
{
    public class WritingJSON
    {
        public static void WritingJSONMain()
        {
            var options = new JsonWriterOptions
            {
                Indented = true
            };

            using var stream = new MemoryStream();
            using var writer = new Utf8JsonWriter(stream, options);

            writer.WriteStartObject();
            writer.WriteStartArray("Person");
            writer.WriteStartObject();
            writer.WriteString("firstName", "Sergio");
            writer.WriteString("firstName", "Perez");
            writer.WriteEndObject();
            writer.WriteStartObject();
            writer.WriteString("firstName", "Jose");
            writer.WriteString("firstName", "Garcia");
            writer.WriteEndObject();
            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.Flush();

            string json = Encoding.UTF8.GetString(stream.ToArray());
            Console.WriteLine(json);
            Console.ReadKey();
        }
    }
}
