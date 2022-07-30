using DataAcessLayor.Abstract;
using DataAcessLayor.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayor.EntityFramework
{
    public class EfAbutDal:GenericRepository<About>,IAboutDal
    {

    }
    

    
}
