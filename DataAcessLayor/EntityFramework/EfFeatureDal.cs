using DataAcessLayor.Repository;
using EntityLayer.Concrete;
using DataAcessLayor.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayor.EntityFramework
{
    public class EfFeatureDal:GenericRepository<Feature>,IFeatureDal
    {
    }
}
