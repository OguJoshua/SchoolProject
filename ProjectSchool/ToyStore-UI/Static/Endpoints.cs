using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToyStore_UI.Static
{
    public static class Endpoints
    {
        public static string BaseUrl = "http://localhost:44319/";
        public static string SellersEndpoint = $"{BaseUrl}api/sellers/";
        public static string ToysEndpoint = $"{BaseUrl}api/toys/";
        public static string RegisterEndpoint = $"{BaseUrl}api/users/register";
        public static string LoginEndpoint = $"{BaseUrl}api/users/login";


    }
}
