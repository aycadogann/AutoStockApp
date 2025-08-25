using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class OrderDetail:IEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int PartId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double Discount { get; set; }
        public List<Part> Part { get; set; }
        public List<Order> Order { get; set; }
    }
}
