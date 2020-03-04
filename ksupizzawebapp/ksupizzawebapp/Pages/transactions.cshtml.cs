using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ksupizzawebapp.Pages
{
    public class TransactionsModel : PageModel
    {
        public string Message { get; set; }
        public List<Transaction> transactions { get; set; }
        public void OnGet()
        {
            Message = "all transaction";
        }
        public List<Transaction> ReturnAllTransaction()
        {
            transactions = new List<Transaction>()
            {
                new Transaction()
                {
                    TransactionID = 10000001,
                    CustomerPhoneNumber = "555 5555 555",
                     Customer = new customer()
                    {
                        Name = "teddy"
                    },
                    Date = DateTime.Now,
                    PaymentType= PaymentType.Cash
                },
                new Transaction()
                {
                    TransactionID = 20000001,
                    CustomerPhoneNumber = "888 5555 555",
                     Customer = new customer()
                    {
                        Name = "selemon"
                    },
                    Date = DateTime.Now,
                    PaymentType= PaymentType.Cash
                },
                new Transaction()
                {
                    TransactionID = 30000001,
                    CustomerPhoneNumber = "999 5555 555",
                     Customer = new customer()
                    {
                        Name = "hana"
                    },
                    Date = DateTime.Now,
                    PaymentType= PaymentType.Check
                },
                 new Transaction()
                {
                    TransactionID = 20000001,
                    CustomerPhoneNumber = "888 5555 555",
                     Customer = new customer()
                    {
                        Name = "selemon"
                    },
                    Date = DateTime.Now,
                    PaymentType= PaymentType.Cash
                },
                new Transaction()
                {
                    TransactionID = 30000001,
                    CustomerPhoneNumber = "999 5555 555",
                     Customer = new customer()
                    {
                        Name = "hana"
                    },
                    Date = DateTime.Now,
                    PaymentType= PaymentType.Check
                }
            };
            return transactions;

        }
    }
    public enum RetrievalType
    {
        Carryout,
        Delivery,
    }

    public class Transaction
    {

        public int TransactionID { get; set; }


        public string CustomerPhoneNumber { get; set; }


        public DateTime Date { get; set; }


        public PaymentType PaymentType { get; set; }



        public double Total { get; set; }


        public RetrievalType RetrievalType { get; set; }


        public string OrderJson { get; set; }


        public customer Customer { get; set; }
    }

}
