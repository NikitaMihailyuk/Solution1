using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person<sclass, sclass> person = new Person<sclass, sclass>();
            List<string> names = new List<string>()
            {
                "234", "345", "34535"
            };
            names.Add("34123");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.Remove("234");

            names.Contains("234");
            names.Clear();
            names.Count();

            List<string> list = new List<string>() {
            "all"
            };
            list.AddRange(names);
            int i = names.IndexOf("234");
            names.Insert(i+1, "Marry");
            names.Reverse();
             string n= names[0];

            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>()
            {
                {"Hello",new List<string>{"Pri", "Zdravi"} },
                {"Hello2",new List<string>{"Pri2", "Zdravi2"} },
                {"Hello3",new List<string>{"Pri3", "Zdravi3"} }
            };

            List<string> values = dict["Hello"];

            foreach (KeyValuePair<string, List<string>> pair in dict)
            {
                foreach (string val in pair.Value)
                {
                    Console.WriteLine(pair.Key + "frdf" + pair.Value);
                }
            }

            List<string> value = dict["Hello"];
            dict.ContainsKey("hello"); //bool

            List<string> keys = dict.Keys.ToList();

            dict.Add("123", new List<string> { "d23" });

         

            foreach ()
        
    }


    }
}
