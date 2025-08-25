using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Order:IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int SupplierId { get; set; }
        public string OrderType { get; set; }
        public DateTime OrderDate { get; set; }
        public bool OrderStatus { get; set; }
        public double TotalAmount { get; set; }
        public Customer Customer { get; set; }
        public Supplier Supplier { get; set; }
        public OrderDetail OrderDetail { get; set; }
    }
}
