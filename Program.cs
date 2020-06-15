using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;

namespace SupremeFuckery
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var stockData = await GetMobileStockData();

            stockData.ProductsAndCategories.TryGetValue("new", out var newItems);

            if (newItems != null)
                foreach (var newItem in newItems)
                {
                    Console.WriteLine(newItem.Name);
                    Console.WriteLine(newItem.Price);
                    Console.WriteLine(newItem.CategoryName);
                    Console.WriteLine(newItem.ImageUrlHi);
                    Console.WriteLine();


                }
        }

        static async Task<MobileStockResponseData> GetMobileStockData()
        {
            var httpClient = new HttpClient();

            var mobileStockRequest = new HttpRequestMessage
            {
                RequestUri = new Uri("https://www.supremenewyork.com/mobile_stock.json"),
                Method = HttpMethod.Get
            };
            var mobileStockResponse = await httpClient.SendAsync(mobileStockRequest);

            var mobileStockResponseData =
                JsonConvert.DeserializeObject<MobileStockResponseData>(await mobileStockResponse.Content
                    .ReadAsStringAsync());

            return mobileStockResponseData;
        }
    }
}