using System;
using System.Linq;
using System.Collections.Generic;
using LoveSeat;
using LoveSeat.Interfaces;

namespace ConsoleTest
{
    public class LocalCashClaim : IBaseObject
    {       
        public string Id { get; set; }
        public string Rev { get; set; }
        public string Type { get; set; }
        public int ContractType { get; set; }
        public string Email { get; set; }
        public decimal ChangeAmount { get; set; }
        public bool IsSynced { get; set; }
        public long idWarehouse { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var client = new CouchClient("sync.32market.com", 5984, "root", "P4rad1gm", false, AuthenticationType.Basic);
            var db = client.GetDatabase("kiosk-sync");

            while(true)
            {
                Documents docs = new Documents();

                var options = new ViewOptions()
                {
                    Limit = 1000
                };


                ViewResult<LocalCashClaim> vr = db.View<LocalCashClaim>("GetUnsyncedCashClaims", options, "Transactions");

                if (vr.Items.ToList().Count == 0)
                {
                    break;
                }

                foreach (var i in vr.Items)
                {
                    i.IsSynced = true;
                    docs.Values.Add(new Document<LocalCashClaim>(i));
                }

                db.SaveDocuments(docs, true);   
            }

            Console.WriteLine("done");
            Console.ReadLine();
        }

        static void db_DBChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Row added");
        }
    }
}
