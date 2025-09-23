using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LocationManager : ILocationService
    {
        private readonly ILocationDal _locationDal;

        public LocationManager(ILocationDal locationDal)
        {
            _locationDal = locationDal;
        }

        public void Add(Location entity)
        {
            _locationDal.Add(entity);
        }

        public List<Location> GetAll()
        {
            return _locationDal.GetAll();
        }

        public void Remove(Location entity)
        {
            _locationDal.Remove(entity);
        }

        public void Update(Location entity)
        {
            _locationDal.Update(entity);
        }
    }
}
