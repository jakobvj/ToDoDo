using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoDo.Web.Models;
using ToDoDo.Web.Service;

namespace ToDoDo.Web.Pages
{
    public class AddModel : PageModel
    {
        IToDoService _toDoService;
        public AddModel(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }
        public ToDo AddTodo { get; private set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost(ToDo toDo)
        {
            //_toDoService.AddToDo(toDo);
            _toDoService.GetAllToDos();
            return RedirectToPage();
        }
    }
}