using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ksupizzawebapp.Pages
{
    public class customerecordModel : PageModel
    {
        public string test = "test";
        public string Message { get; set; }
        public customer customer { get; set; }
        public List<customer> customerlist { get; set; }
        public void OnGet()
        {
            Message = "Geenerate Recipt";
        }
        public List<customer> ReturnAllCustomer()
        {

            customerlist = new List<customer>() {
               new customer()
               {
                   Id ="1001",
                   PhoneNumber = "444 555 8888",
                   Name ="Hana Ted",
                   Address = "2020 Buford HWY NE",
                   PaymentType = PaymentType.Cash
               },
               new customer()
               {
                   Id = "2002",
                    PhoneNumber = "999 555 8888",
                   Name ="Hana Ted",
                   Address = "201 Peachtree St",
                   PaymentType = PaymentType.MasterCard
               },
                new customer()
                {
                    Id = "1003",
                     PhoneNumber = "2222 555 8888",
                   Name ="Hana Ted",
                   Address = "2020 Buford HWY NE",
                   PaymentType = PaymentType.Check
                },
                new customer()
                {
                     Id = "1004",
                     PhoneNumber = "777 555 8888",
                   Name ="selomon teddy",
                   Address = "2020 Buford HWY NE",
                   PaymentType = PaymentType.VisaCard
                },
                               new customer()
               {
                   Id ="1001",
                   PhoneNumber = "444 555 8888",
                   Name ="Hana Ted",
                   Address = "2020 Buford HWY NE",
                   PaymentType = PaymentType.Cash
               },
              
                new customer()
                {
                     Id = "1004",
                     PhoneNumber = "777 555 8888",
                   Name ="selomon teddy",
                   Address = "2020 Buford HWY NE",
                   PaymentType = PaymentType.VisaCard
                }

            };            
            return customerlist;
        }
    }
    public class customer
    {
        public string Id {get;set;} 

        public string PhoneNumber { get; set; }


        public string Name { get; set; }


        public string Address { get; set; }


        public PaymentType PaymentType { get; set; }

        public string AddressDetails { get; set; }

    }
    public enum PaymentType
    {
        Cash,
        Check,
        VisaCard,
        MasterCard,
    }
}
