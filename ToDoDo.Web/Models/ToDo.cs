using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoDo.Web.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string ToDoText { get; set; }
        public bool Done { get; set; }

    }
}
