using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoveSeat.Interfaces;

namespace LoveSeat
{
    public class ViewCollection : IBaseObject
    {
        public string Id { get; set; }
        public string Rev { get; set; }
        public string Type { get; set; }
        public string language { get; set; }
        List<ViewMap> views { get; set; }
    }

    public class ViewMap
    {
        public string map { get; set; }
    }
}
