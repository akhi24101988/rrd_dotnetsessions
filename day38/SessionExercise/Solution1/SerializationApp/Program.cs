﻿using CustomerCommonLib;
using System.Net;
using System.Text.Json;

namespace SerializationApp
{
    internal class Program
    {
        static void Main(string[] args)

        {
            SerializeToJson();
        }

        private static void SerializeToJson()
        {
            var c1 = new Customer
            {
                Id = 1,
                Name = "Markonda",
                Addresses = new List<Address> {
                 new Address { city="Chennai",country="India" },
                 new Address { city="Mumbai",country="India" }
                }
            };


            var jsonString = JsonSerializer.Serialize(c1);
            Console.WriteLine(jsonString);
            var sw = new StreamWriter(@"C:\temp\cust1.json");
            sw.WriteLine(jsonString);
            sw.Close();
            Console.WriteLine("written to file");
        }
    }
}


