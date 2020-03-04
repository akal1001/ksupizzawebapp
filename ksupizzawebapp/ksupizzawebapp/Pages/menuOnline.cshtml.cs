using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ksupizzawebapp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ksupizzawebapp.Pages
{
    public class MenuOnlineModel : PageModel    
    {
        public string Message { get; set; }
        public List<Menu> menulist { get; set; }
        public void OnGet()
        {
            menulist = Menu.ReturnAll();
            
          
        }
        
    }
}
        