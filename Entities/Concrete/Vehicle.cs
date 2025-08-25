using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Vehicle:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public int ColorId { get; set; }
        public int LocationId { get; set; }
        public int VehicleYear { get; set; }
        public string VinNumber { get; set; }
        public string EngineType { get; set; }
        public int StockQuantity { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        public Location Location { get; set; }
        public Brand Brand { get; set; }
        public Color Color { get; set; }
        public Model Model { get; set; }
    }
}
