﻿
using BusinessLayer.Abstract;
using DataAcessLayor.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{

    public class ToDoListManager : IToDoListService
    {
        IToDoListDal _toDoListDal;

        public ToDoListManager(IToDoListDal toDoListDal)
        {
            _toDoListDal = toDoListDal;
        }

        public void TAdd(ToDoList t)
        {
            throw new System.NotImplementedException();
        }

        public void TDelete(ToDoList t)
        {
            throw new System.NotImplementedException();
        }

        public ToDoList TGetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<ToDoList> TGetList()
        {
            return _toDoListDal.GetList();
        }

        public List<ToDoList> TGetListbyFilter()
        {
            throw new System.NotImplementedException();
        }

        public void TUpdate(ToDoList t)
        {
            throw new System.NotImplementedException();
        }
    }
}
