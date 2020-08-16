using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoDo.Web.Models;

namespace ToDoDo.Web.Service
{
    public interface IToDoService
    {
        List<ToDo> GetAllToDos();
        void EditToDo(ToDo toDo);
        void AddToDo(ToDo toDo);
    }
}
