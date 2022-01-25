using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace eShop.CoreBusiness.Models
{
    public class Product
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("category")]
        public string Brand { get; set; }
        [JsonProperty("title")]
        public string Name { get; set; }
        [JsonProperty("price")]
        public double Price { get; set; }
        [JsonProperty("image")]
        public string ImageLink { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }
    public class ProductJ
    {
        public int id { get; set; }
        public string title { get; set; }
        public string price { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public string image { get; set; }
    }
}
