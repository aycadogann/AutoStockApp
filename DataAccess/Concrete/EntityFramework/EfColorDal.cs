using DataAccess.Abstract;
using DataAccess.Repositories;
using Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : GenericRepository<Color>, IColorDal
    {

    }
}
