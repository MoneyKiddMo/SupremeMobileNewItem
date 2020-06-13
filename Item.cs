using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Newtonsoft.Json;
using RestSharp;

namespace SupremeMobileMonitor
{
    class ItemDetail
    {
        public string Name;
        public long Id;
        public string ImageUrl;
        public string ImageUrlHi;
        public long Price;
        public long SalePrice;
        public bool NewItem;
        public long Position;
        public string CategoryName;


        public ItemDetail(string name, long id, string imageUrl, string imageUrlHi, long price, long salePrice, bool newItem, long position, string categoryName)
        {
            Name = name;
            Id = id;
            ImageUrl = imageUrl;
            ImageUrlHi = imageUrlHi;
            Price = price;
            SalePrice = salePrice;
            NewItem = newItem;
            Position = position;
            CategoryName = categoryName;
        }
    }
}
