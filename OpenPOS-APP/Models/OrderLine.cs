using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPOS_APP.Models
{
    public class OrderLine
    {
        public int Order_id { get; set; }
        public int Bill_id { get; set; }
        public bool Status { get; set; } 
        public int Amount { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public DateTime Created_at { get; set; } 
        public OrderLine() { }
    }
}
