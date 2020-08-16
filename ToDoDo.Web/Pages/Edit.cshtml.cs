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
    public class EditModel : PageModel
    {
        IToDoService _toDoService;
        public EditModel(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }
        public IActionResult OnGet(int? id)
        {
            // ToDo todo;
            //if (id == null)
            //{
            //    return NotFound();
            //}
            //if (id != null)
            //{
            //    todo = _toDoService.GetToDoById(id);
            //    if (todo == null)
            //    {
            //        return NotFound();
            //    }
            //}
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            //var toDoToUpdate = _toDoService.GetToDoById(id);

            //if (toDoToUpdate == null)
            //{
            //    return NotFound();
            //}

            //_toDoService.EditToDo(toDoToUpdate);
            return RedirectToPage("./ToDo");
            
        }
    }
}