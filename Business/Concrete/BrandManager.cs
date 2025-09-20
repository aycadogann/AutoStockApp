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
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void Add(Brand entity)
        {
            _brandDal.Add(entity);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public void Remove(Brand entity)
        {
            _brandDal.Remove(entity);
        }

        public void Update(Brand entity)
        {
            _brandDal.Update(entity);
        }
    }
}
