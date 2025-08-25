using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Supplier:IEntity
    {
        public int Id { get; set; }
        public string SupplierName { get; set; }
        public string SupplierContactPerson { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierAddress { get; set; }
        public List<Order> Order { get; set; }
    }
}
