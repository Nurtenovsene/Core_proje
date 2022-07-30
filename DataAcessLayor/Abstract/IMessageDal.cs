using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using DataAcessLayor.Abstract;
using EntityLayer;

namespace DataAccessLayer.Abstract
{
    public interface IMessageDal : IGenericDal<Message>
    {
    }
}
