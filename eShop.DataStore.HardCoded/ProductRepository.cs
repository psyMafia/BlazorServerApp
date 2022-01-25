using System;
using System.Collections.Generic;
using System.Linq;
using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using Newtonsoft.Json;
using RestSharp;

namespace eShop.DataStore.HardCoded
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;
        private RestClient _restClient;


        public ProductRepository()
        {
            _restClient = new RestClient("https://fakestoreapi.com/");
            Fetch();
        }

        public IEnumerable<Product> GetProducts(string filter)
        {
            return _products.Where(product => product.Name.ToLower().Contains(filter.ToLower()));
        }

        public Product GetProduct(int id)
        {
            return _products.First(product => product.Id == id);
        }

        private void Fetch()
        {
            if (_products != null)
                return;

            RestRequest restRequest = new RestRequest("products", Method.Get);
            RestResponse restResponse = _restClient.ExecuteAsync(restRequest).Result;

            _products = JsonConvert.DeserializeObject<List<Product>>(restResponse.Content);
        }
    }
}