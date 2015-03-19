using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoveSeat;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new CouchClient("software", "software");
            client.ConfigChange("couch_httpd_auth", "require_valid_user", "false");
        }
    }
}
