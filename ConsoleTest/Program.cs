using System;
using System.Reflection;
using LoveSeat;
using LoveSeat.Interfaces;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new CouchClient();
            var db = client.GetDatabase("tsm-sync");

            var viewItems = db.View<dynamic>("getUserById", 26869, "Users");

            var foo = client.GetActiveTasks();
            Console.WriteLine(foo);
        }
    }

    public class LocalUser : IBaseObject
    {
        public LocalUser()
        {

        }

        public string Id { get; set; }
        public string Rev { get; set; }
        public string Type { get; set; }
        public decimal MarketBalance { get; set; }
        public int ContractType { get; set; }
    }
}
