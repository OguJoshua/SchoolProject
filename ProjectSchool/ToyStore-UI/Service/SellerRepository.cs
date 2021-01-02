using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ToyStore_UI.Contracts;
using ToyStore_UI.Models;

namespace ToyStore_UI.Service
{
    public class SellerRepository: BaseRepository<Seller>, ISellerRepository
    {
        private readonly IHttpClientFactory _client;
        private readonly ILocalStorageService _localStorage;

        public SellerRepository(IHttpClientFactory client,
            ILocalStorageService localStorage) : base(client, localStorage)
        {
            _client = client;
        }

    }
}
