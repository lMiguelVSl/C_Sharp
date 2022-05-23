using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsumingJSON
{
    public class ReadingJSON
    {
        public static void ReadingJSONMain()
        {
            using (JsonDocument document = JsonDocument.Parse(File.ReadAllText("People.json")))
            {
                JsonElement root = document.RootElement;
                JsonElement peopleElement = root.GetProperty("People");
                JsonElement personElement = peopleElement.GetProperty("Person");
                foreach (JsonElement person in personElement.EnumerateArray())
                {
                    if (person.TryGetProperty("firstName", out JsonElement firstNameElement))
                    {
                        Console.WriteLine($"First Name: {firstNameElement}");
                    }
                    if (person.TryGetProperty("lastName", out JsonElement lastNameElement))
                    {
                        Console.WriteLine($"Last Name: {lastNameElement}");
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
