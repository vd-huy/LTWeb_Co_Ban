using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_WebCoBan.objects
{
    public class productInCart
    {
        private objects.product product;
        private string userName;
        private int count;

        public productInCart() { }

        public productInCart(objects.product product, string userName, int count)
        {
            this.product = product;
            this.userName = userName;
            this.count = count;
        }

        public objects.product Product { get => product; set => product = value; }
        public string UserName { get => userName; set => userName = value; }
        public int Count { get => count; set => count = value; }
    }
}