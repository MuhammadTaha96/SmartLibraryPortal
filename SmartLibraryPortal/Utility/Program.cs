using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telesign;
using Utility.Operations;

namespace Utility
{
    class Program
    {
        static void Main(string[] args)
        {
           Program.CancleReservations();
            Program.OverDueNotification();

            Console.ReadLine();
        }

        public static void CancleReservations()
        {
            Console.WriteLine("----------Reservation Cancellation Utility Started: " + DateTime.Now + "----------");
            List<Reservation> resList = ApiClient.GetReservations();
            
            if (resList != null)
            {
                resList = resList.Where(x => x.Status.Name.Equals("Active")).ToList();

                if (resList != null)
                {
                    foreach (var res in resList)
                    {
                        if (res.EndDateTime.Date == DateTime.Now.Date)
                        {
                            ApiClient.CancleReservation(res.ReservationId, res.ReservedCopy.CopyId);
                            Console.WriteLine(string.Format("ReservationID: {0} | End Date: {1} --> Cancelled ", res.ReservationId, res.EndDateTime.Date));
                        }
                    }
                }
            }

            Console.WriteLine("----------Reservation Cancellation Utility Ended: " + DateTime.Now + "----------");

        }

        public static void OverDueNotification()
        {
            Console.WriteLine("----------OverDue Notification Utility Started: " + DateTime.Now + "----------");
            List<Transaction> tranList = ApiClient.GetTransactions();
            string smsContent = string.Empty;
           if(tranList != null)
           {
               tranList = tranList.Where(x => x.Type.Name.Equals("CheckIn")).ToList();
           if(tranList != null)
           {
               foreach (var tran in tranList)
               {
                   if(tran.ExpectedReturnDate.Date < DateTime.Now.Date)
                   {
                        smsContent = string.Format("You are {0} days late for returning the book {1}. You will be charged a fine of ruppees {2}", DateTime.Now.Day - tran.ExpectedReturnDate.Day, tran.Reservation.ReservedCopy.Book.Title, 50 * (DateTime.Now.Day - tran.ExpectedReturnDate.Day));
                        Program.SendSMS(tran.User.PhoneNumber, smsContent);
                   }

               }
           }
           
           }
           Console.WriteLine("----------OverDue Notification Utility Ended: " + DateTime.Now + "----------");
        }



        public static void SendSMS(string phoneNumber, string content)
        {

            string customerId = "A7B64D9C-9375-433A-87FE-90454D6F2429";
            string apiKey = "sDfY84uHPfzViXCLXejqkuP0uAzlUKrC1DbwKoNYrBXj6qmzb/WOxvyO1xjGtfnJA9YOzaa9ZTSZeKz2pTzhMA==";

            string message = content;
            string messageType = "ARN";

            try
            {
                MessagingClient messagingClient = new MessagingClient(customerId, apiKey);
                RestClient.TelesignResponse telesignResponse = messagingClient.Message(phoneNumber, message, messageType);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }
    }
}
