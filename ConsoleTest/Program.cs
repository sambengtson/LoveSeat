using System;
using System.Collections.Generic;
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

            var resp = client.TriggerReplication("offline-activities", "https://sync.32market.com/kiosk-sync/", true, true);
            Console.WriteLine(resp);
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
