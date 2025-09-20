using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities;
using System.Collections.Generic;
namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        private readonly IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color entity)
        {
            _colorDal.Add(entity);
        }

        public List<Color> GetAll()
        {
           return _colorDal.GetAll();
        }

        public void Remove(Color entity)
        {
             _colorDal.Remove(entity);
        }

        public void Update(Color entity)
        {
            _colorDal.Update(entity);
        }
    }
}
