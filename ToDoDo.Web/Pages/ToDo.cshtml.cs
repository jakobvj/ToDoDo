using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ToDoDo.Web.Models;

namespace ToDoDo.Web.Pages
{
    public class ToDoModel : PageModel
    {
        [BindProperty]
        public List<ToDo> Todos { get; private set; }

        private readonly ILogger<ToDoModel> _logger;

        public ToDoModel(ILogger<ToDoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ToDo t = new ToDo();
            t.Id = 1;
            t.ToDoText = "Blive færdig";
            t.Done = false;
            Todos = new List<ToDo>();
            Todos.Add(t);
        }
    }
}