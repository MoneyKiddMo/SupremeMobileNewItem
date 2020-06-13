using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SupremeMobileMonitor
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var program = new Program();
            await program.GetItem();
            
        }
        // Declaring variables in the list
        static List<ItemDetail> ProductList = new List<ItemDetail>();
        List<string> productDesc = new List<string> { "new_item", "price", "category", "imageurl", "itemURL" };
        List<string> category = new List<string> { "new","jackets", "shirts", "tops_sweaters", "pants", "hats", "accessories", "shoes", "skate" };

        //creating a class for intializing Json Deserializer 

        public class MobileStockResponse
    {
        [JsonProperty("unique_image_url_prefixes")]
        public List<object> UniqueImageUrlPrefixes { get; set; }

        [JsonProperty("products_and_categories")]
        public Dictionary<string, List<ProductsAndCategory>> ProductsAndCategories { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [JsonProperty("release_week")]
        public string ReleaseWeek { get; set; }
    }
        public partial class ProductsAndCategory
        {
            [JsonProperty("name")]
            public string Name { get; set; }
            [JsonProperty("id")]
            public long Id { get; set; }
            [JsonProperty("image_url")]
            public string ImageUrl { get; set; }
            [JsonProperty("image_url_hi")]
            public string ImageUrlHi { get; set; }
            [JsonProperty("price")]
            public long Price { get; set; }
            [JsonProperty("sale_price")]
            public long SalePrice { get; set; }
            [JsonProperty("new_item")]
            public bool NewItem { get; set; }
            [JsonProperty("position")]
            public long Position { get; set; }
            [JsonProperty("category_name")]
            public string CategoryName { get; set; }

        }


        //Initializing HttpClient for Requests and po
        public async Task GetItem()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri("https://www.supremenewyork.com/mobile_stock.json"),
                Method = HttpMethod.Get
            };
            var response = await client.SendAsync(request);
            var responseContent = await response.Content.ReadAsStringAsync();
            var responseObject = JsonConvert.DeserializeObject<MobileStockResponse>(responseContent);
            var productsAndCategories = responseObject.ProductsAndCategories;

            Console.WriteLine(JsonConvert.SerializeObject(productsAndCategories, Formatting.Indented));
        }






        }

    }
