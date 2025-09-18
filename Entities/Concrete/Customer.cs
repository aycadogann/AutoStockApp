using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public List<Order> Order { get; set; }
    }
}
