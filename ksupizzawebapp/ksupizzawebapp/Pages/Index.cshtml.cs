using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using ksupizzawebapp.Models;

namespace ksupizzawebapp.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }
        public List<Menu> menulist { get; set; }
        public void OnGet()
        {
            menulist = Menu.ReturnAll();


        }
    }
}
