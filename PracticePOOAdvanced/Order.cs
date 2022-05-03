using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePOOAdvanced
{
    class Order : IEntity //heredar de una clase 
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
    }
}
