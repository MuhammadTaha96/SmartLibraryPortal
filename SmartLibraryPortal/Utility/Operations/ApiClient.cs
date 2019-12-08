using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Utility.Operations
{
    class ApiClient
    {
        public static List<Reservation> GetReservations()
        {
            string urlWebConfig = ConfigurationSettings.AppSettings.Get("ApiURL").ToString();
            string controller = "values";
            string action = "GetReservations";
            string html = string.Empty;
            List<Reservation> reservations = null;

            string url = urlWebConfig + "/" + controller + "/" + action;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
                reservations = JsonConvert.DeserializeObject<List<Reservation>>(html);
            }

            return reservations;
        }

        public static List<Transaction> GetTransactions()
        {
            string urlWebConfig = ConfigurationSettings.AppSettings.Get("ApiURL").ToString();
            string controller = "values";
            string action = "GetTransactions";
            string html = string.Empty;
            List<Transaction> transactions = null;

            string url = urlWebConfig + "/" + controller + "/" + action;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
                transactions = JsonConvert.DeserializeObject<List<Transaction>>(html);
            }

            return transactions;
        }


        public static bool CancleReservation(int reservationId, int copyId)
        {
            string urlWebConfig = ConfigurationSettings.AppSettings.Get("ApiURL").ToString();
            string controller = "values";
            string action = "CancleReservation";
            bool valid = false;
            string html = string.Empty;
            bool success;

            string url = urlWebConfig + "/" + controller + "/" + action + "?reservationId=" + reservationId + "&copyId=" + copyId;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
                success = bool.Parse(html);
            }

            return success;
        }
    }
}
