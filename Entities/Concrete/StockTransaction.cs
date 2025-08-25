using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class StockTransaction : IEntity
    {
        public int Id { get; set; }
        public int PartId { get; set; }
        public string PartType { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public List<Part> Part { get; set; }
      
    }
}
