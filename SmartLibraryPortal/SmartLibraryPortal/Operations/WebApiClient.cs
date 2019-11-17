using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Configuration;

namespace SmartLibraryPortal.Operations
{
    class WebApiClient
    {
        public static UserLogin ValidateLibrarian(string username, string password)
        {
            UserLogin userVM = new UserLogin();
            string urlWebConfig = ConfigurationSettings.AppSettings.Get("ApiURL").ToString();
            string controller = "values";
            string action = "ValidateLibrarian";
            string html = string.Empty;
            UserLogin user = null;

            string url = urlWebConfig + "/" + controller + "/" + action + "?username=" + username + "&password=" + password;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
                user = JsonConvert.DeserializeObject<UserLogin>(html);
            }

            return user;
        }

        public static List<Book> GetAllBooks()
        {
            string urlWebConfig = ConfigurationSettings.AppSettings.Get("ApiURL").ToString();
            string controller = "values";
            string action = "GetAllBooks";
            string html = string.Empty;
            List<Book> books = null;

            string url = urlWebConfig + "/" + controller + "/" + action;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
                books = JsonConvert.DeserializeObject<List<Book>>(html);
            }

            return books;
        }

        public static List<Category> GetCategories()
        {
            string urlWebConfig = ConfigurationSettings.AppSettings.Get("ApiURL").ToString();
            string controller = "values";
            string action = "GetCategories";
            bool valid = false;
            string html = string.Empty;
            List<Category> categoryList = null;

            string url = urlWebConfig + "/" + controller + "/" + action;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
                categoryList = JsonConvert.DeserializeObject<List<Category>>(html);
            }

            return categoryList;
        }

        public static List<Publisher> GetPublishers()
        {
            string urlWebConfig = ConfigurationSettings.AppSettings.Get("ApiURL").ToString();
            string controller = "values";
            string action = "GetPublishers";
            bool valid = false;
            string html = string.Empty;
            List<Publisher> publisherList = null;

            string url = urlWebConfig + "/" + controller + "/" + action;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
                publisherList = JsonConvert.DeserializeObject<List<Publisher>>(html);
            }

            return publisherList;
        }

        public static List<Author> GetAllAuthors()
        {
            string urlWebConfig = ConfigurationSettings.AppSettings.Get("ApiURL").ToString();
            string controller = "values";
            string action = "GetAllAuthors";
            bool valid = false;
            string html = string.Empty;
            List<Author> authorList = null;

            string url = urlWebConfig + "/" + controller + "/" + action;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
                authorList = JsonConvert.DeserializeObject<List<Author>>(html);
            }

            return authorList;
        }

        public static Book GetBookDetails(int bookId)
        {
            string urlWebConfig = ConfigurationSettings.AppSettings.Get("ApiURL").ToString();
            string controller = "values";
            string action = "GetBookDetails";
            bool valid = false;
            string html = string.Empty;
            Book book = null;

            string url = urlWebConfig + "/" + controller + "/" + action + "?bookId=" + bookId;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
                book = JsonConvert.DeserializeObject<Book>(html);
            }

            return book;
        }

        


        public static bool AddBook(Book book)
        {
            string urlWebConfig = ConfigurationSettings.AppSettings.Get("ApiURL").ToString();
            string controller = "values";
            string action = "AddBook";
            string html = string.Empty;
            bool isSuccess = false;

            string url = urlWebConfig + "/" + controller + "/" + action;
            string response = string.Empty;
            var httpWebRequest = (System.Net.HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(book);

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                result = result.ToString();
                response = result;
                isSuccess = bool.Parse(response);
            }

            return isSuccess;

        }

        public static bool AddAuthor(Author author)
        {
            string urlWebConfig = ConfigurationSettings.AppSettings.Get("ApiURL").ToString();
            string controller = "values";
            string action = "AddAuthor";
            string html = string.Empty;
            bool isSuccess = false;

            string url = urlWebConfig + "/" + controller + "/" + action;
            string response = string.Empty;
            var httpWebRequest = (System.Net.HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(author);

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                result = result.ToString();
                response = result;
                isSuccess = bool.Parse(response);
            }

            return isSuccess;

        }

        public static bool AddCategory(Category category)
        {
            string urlWebConfig = ConfigurationSettings.AppSettings.Get("ApiURL").ToString();
            string controller = "values";
            string action = "AddCategory";
            string html = string.Empty;
            bool isSuccess = false;

            string url = urlWebConfig + "/" + controller + "/" + action;
            string response = string.Empty;
            var httpWebRequest = (System.Net.HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(category);

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                result = result.ToString();
                response = result;
                isSuccess = bool.Parse(response);
            }

            return isSuccess;

        }

        public static bool AddPublisher(Publisher publisher)
        {
            string urlWebConfig = ConfigurationSettings.AppSettings.Get("ApiURL").ToString();
            string controller = "values";
            string action = "AddPublisher";
            string html = string.Empty;
            bool isSuccess = false;

            string url = urlWebConfig + "/" + controller + "/" + action;
            string response = string.Empty;
            var httpWebRequest = (System.Net.HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(publisher);

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                result = result.ToString();
                response = result;
                isSuccess = bool.Parse(response);
            }

            return isSuccess;

        }


        public static List<Location> GetAvailableLocation()
        {
            string urlWebConfig = ConfigurationSettings.AppSettings.Get("ApiURL").ToString();
            string controller = "values";
            string action = "GetShelve";
            string html = string.Empty;
            List<Location> locations = null;

            string url = urlWebConfig + "/" + controller + "/" + action;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
                locations = JsonConvert.DeserializeObject<List<Location>>(html);
            }

            return locations;
        }

        public static bool AddCopy(Copy book)
        {
            string urlWebConfig = ConfigurationSettings.AppSettings.Get("ApiURL").ToString();
            string controller = "values";
            string action = "AddCopy";
            string html = string.Empty;
            bool isSuccess = false;

            string url = urlWebConfig + "/" + controller + "/" + action;
            string response = string.Empty;
            var httpWebRequest = (System.Net.HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(book);

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                result = result.ToString();
                response = result;
                isSuccess = bool.Parse(response);
            }

            return isSuccess;
        }

        
    }
}
