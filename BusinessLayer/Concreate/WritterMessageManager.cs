using BusinessLayer.Abstract;
using DataAcessLayor.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
   public class WritterMessageManager:IWritterMessageService
    {
        IWritterMessageDal _writterMessageDal;

        public WritterMessageManager(IWritterMessageDal writterMessageDal)
        {
            _writterMessageDal = writterMessageDal;
        }

        public List<WriterMessage> GetListReceiverMessage(string p)
        {
            return _writterMessageDal.GetByFilter(x => x.Receiver == p);
        }

        public List<WriterMessage> GetListSenderMessage(string p)
        {
            return _writterMessageDal.GetByFilter(x => x.Sender == p);
        }

      

        public void TAdd(WriterMessage t)
        {
            _writterMessageDal.Insert(t);
        }

        public void TDelete(WriterMessage t)
        {
            _writterMessageDal.Delete(t); 
        }

        public WriterMessage TGetByID(int id)
        {
            return _writterMessageDal.GetByID(id);
        }

        public List<WriterMessage> TGetList()
        {
            throw new NotImplementedException();
        }

        //public List<WriterMessage> TGetListbyFilter(string p)
        //{
        //    return _writterMessageDal.GetByFilter(x => x.Receiver == p);
        //}

        public List<WriterMessage> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
