using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    internal class MessageService : IMessageService
    {
        IMessageDal _messageDal;

        public MessageService(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void TAdd(Message t)
        {
            _messageDal.Insert(t);
        }

        public void TDelete(Message t)
        {
            _messageDal.Delete(t);
        }

        public Message TGetById(int id)
        {
            return _messageDal.GetByID(id); 
        }

        public List<Message> TGetList()
        {
            return _messageDal.GetList();
        }

        public void TUpdate(Message t)
        {
            _messageDal.Update(t);
        }
    }
}
