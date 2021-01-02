using Blazored.LocalStorage;
using BookStore_UI.WASM.Service;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ToyStore_UI.WASM.Contracts;
using ToyStore_UI.WASM.Models;

namespace ToyStore_UI.WASM.Service
{
    public class SellerRepository: BaseRepository<Seller>, ISellerRepository
    {
        private readonly IHttpClientFactory _client;
        private readonly ILocalStorageService _localStorage;

        public SellerRepository(IHttpClientFactory client,
            ILocalStorageService localStorage) : base(client, localStorage)
        {
            _client = client;
            _localStorage = localStorage;
        }

    }
}
