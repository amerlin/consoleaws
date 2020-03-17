using System;
using AwsConsole;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleAws
{
    class Program
    {
        static void Main(string[] args)
        {

            var json = File.ReadAllText(@"c:\utility\instance.json");
            var obj = JObject.Parse(json);
            var result = obj.Descendants().OfType<JProperty>().Select(p => new KeyValuePair<string, object>(p.Path, p.Value.Type == JTokenType.Array || p.Value.Type == JTokenType.Object ? null : p.Value));

            var distinctKey = new List<string>();
            distinctKey = result.Select(a => a.Key.Split(".")[0]).Skip(1).Distinct().ToList();

            var rows = new List<string>();
            var oldKeyString = string.Empty;
            foreach (var currentKeyString in distinctKey)
            {
                if (currentKeyString != oldKeyString)
                {
                    rows.Add("----------------");
                    rows.Add($"{currentKeyString.ToUpper()}");
                }

                var temp = result.Where(a => a.Key.Contains(currentKeyString)).Select(a => $"{a.Key.Replace($"{currentKeyString}.", string.Empty)}: {a.Value}").ToList();
                
                rows.AddRange(temp);
                oldKeyString = currentKeyString;
            }

            File.WriteAllLines(@"c:\utility\output.txt", rows);

            Console.ReadLine();

        }
    }
}
