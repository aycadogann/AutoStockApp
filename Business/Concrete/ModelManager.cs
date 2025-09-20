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
    public class ModelManager : IModelService
    {
        IModelDal _modelDal;

        public ModelManager(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }

        public void Add(Model entity)
        {
            _modelDal.Add(entity);
        }

        public List<Model> GetAll()
        {
            return _modelDal.GetAll();
        }

        public void Remove(Model entity)
        {
            _modelDal.Remove(entity);
        }

        public void Update(Model entity)
        {
            _modelDal.Update(entity);
        }
    }
}
