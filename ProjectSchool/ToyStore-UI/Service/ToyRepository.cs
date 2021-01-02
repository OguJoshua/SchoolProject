using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ToyStore_UI.Models;
using ToyStore_UI.Contracts;


namespace ToyStore_UI.Service
{
    public class ToyRepository : BaseRepository<Toy>, IToyRepository
    {
        private readonly IHttpClientFactory _client;
        private readonly ILocalStorageService _localStorage;



        public ToyRepository(IHttpClientFactory client,
            ILocalStorageService localStorage) : base(client, localStorage)
        {
            _client = client;
            _localStorage = localStorage;
        
        }


    }
}
