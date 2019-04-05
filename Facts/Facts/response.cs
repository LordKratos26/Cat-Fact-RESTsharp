using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facts
{
    public class response
    {
        public string _id { get; set; }
        public DateTime updatedAt { get; set; }
        public DateTime createdAt { get; set; }
        public string user { get; set; }
        public string text { get; set; }
        public int __v { get; set; }
        public bool deleted { get; set; }
        public string type { get; set; }
        public string source { get; set; }
        public bool used { get; set; }
    }
}
