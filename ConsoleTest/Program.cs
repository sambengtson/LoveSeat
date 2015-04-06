using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            string blah = client.GetConfigKey("couch_httpd_auth", "require_valid_user");
            Console.WriteLine(blah);

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
