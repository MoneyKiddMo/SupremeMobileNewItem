using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SupremeFuckery
{
    public class MobileStockResponseData
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

    public class ProductsAndCategory
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

        [JsonProperty("price_euro")]
        public long PriceEuro { get; set; }

        [JsonProperty("sale_price_euro")]
        public long SalePriceEuro { get; set; }
    }
}