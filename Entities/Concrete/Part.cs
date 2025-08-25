using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Part:IEntity
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public int LocationId { get; set; }
        public string PartName { get; set; }
        public string PartNumber { get; set; }
        public int StockQuantity { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        public Location Location { get; set; }
        public StockTransaction StockTransaction { get; set; }
        public OrderDetail OrderDetail { get; set; }
    }
}
