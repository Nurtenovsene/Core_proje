
using DataAcessLayor.Abstract;
using DataAcessLayor.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfWriterMessageDal : GenericRepository<WriterMessage>, IWritterMessageDal
    {
        public List<WriterMessage> GetbyFilter(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
