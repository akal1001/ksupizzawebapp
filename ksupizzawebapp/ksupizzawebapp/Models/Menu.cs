using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ksupizzawebapp.Models
{
    public class Menu
    {
        public string menueId { get; set; }
        public string menuname{ get; set; }
        public string ImageReferaceId { get; set; }
        public double price { get; set; }

       
        public static List<Menu> ReturnAll()
        {
            var menus = new List<Menu>()
            {
               new Menu()
               {
                   menueId = "r4343534t43t432",
                   menuname = "pizz name",
                    ImageReferaceId = "https://greenwich-pizza-cdn.tillster.com/6fa30d87-fb0c-47ac-ab47-0fa59d59ade0.png"
      },
               new Menu()
               {
                    menueId = "r4343534t43t432",
                   menuname = "pizz name",
                   ImageReferaceId = "https://previews.123rf.com/images/milkos/milkos1507/milkos150700058/42770663-delicious-pizza-with-fresh-onions-leek-bacon-and-cherry-tomatoes-thin-pastry-crust-isolated-at-woode.jpg"
               },
              
                 new Menu()
               {
                    menueId = "r4343534t43t432",
                   menuname = "pizz name",
                   ImageReferaceId = "https://greenwich-pizza-cdn.tillster.com/6fa30d87-fb0c-47ac-ab47-0fa59d59ade0.png"
               },
                  new Menu()
               {
                    menueId = "r4343534t43t432",
                   menuname = "pizz name",
                   ImageReferaceId = "https://greenwich-pizza-cdn.tillster.com/6fa30d87-fb0c-47ac-ab47-0fa59d59ade0.png"
               },
                   new Menu()
               {
                    menueId = "r4343534t43t432",
                   menuname = "pizz name",
                   ImageReferaceId = "https://upload.wikimedia.org/wikipedia/commons/a/a3/Eq_it-na_pizza-margherita_sep2005_sml.jpg"
               },
                    new Menu()
               {
                    menueId = "r4343534t43t432",
                   menuname = "pizz name",
                   ImageReferaceId = "https://greenwich-pizza-cdn.tillster.com/6fa30d87-fb0c-47ac-ab47-0fa59d59ade0.png"
               },
                     new Menu()
               {
                    menueId = "r4343534t43t432",
                   menuname = "pizz name",
                   ImageReferaceId = "https://greenwich-pizza-cdn.tillster.com/6fa30d87-fb0c-47ac-ab47-0fa59d59ade0.png"
               },
                        new Menu()
               {
                    menueId = "r4343534t43t432",
                   menuname = "pizz name",
                   ImageReferaceId = "https://greenwich-pizza-cdn.tillster.com/6fa30d87-fb0c-47ac-ab47-0fa59d59ade0.png"
               }
            };
            return menus;
        }

     
    }
}
