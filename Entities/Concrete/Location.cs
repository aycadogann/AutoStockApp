using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Location:IEntity
    {
        public int Id { get; set; }
        public string LoctionName { get; set; }
        public string LoctionAddress { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public List<Part> Part { get; set; }
    }
}
