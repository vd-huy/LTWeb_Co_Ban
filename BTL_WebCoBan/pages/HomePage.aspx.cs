﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WebCoBan.pages
{
    public partial class HomePage : System.Web.UI.Page
    {
        List<objects.product> products;
        protected void Page_Load(object sender, EventArgs e)
        {
            products = (List<objects.product>)Application["products"];
            string html = "";
            foreach (objects.product product in products)
            {
                if (product.Discount > 0)
                {
                    double priceDisCount = product.Price * (1 - product.Discount);

                   
                    html += " <div class='product__item' '> "
                         + "<img class='product__item--img' src='" + product.Img + "' alt='Image Product'>"
                        + "<h5 class='product__item--name'>" + product.Name + "</h5>"
                        + "<span class='product__item--price'>" + priceDisCount + "</span>"
                        + "<span class='lineThrough'>" + product.Price + "</span>"
                        + "<button class='product__item--btn'>"
                        + "<i class='fa-solid fa-bag-shopping'></i> Chọn mua"
                        + "</button>"
                          + "</div>";
                }
                else
                {
                    html += " <div class='product__item' '> "
                        + "<img class='product__item--img' src='" + product.Img + "' alt='Image Product'>"
                       + "<h5 class='product__item--name'>" + product.Name + "</h5>"
                       + "<span class='product__item--price'>" + product.Price + "</span>"
                       + "<button class='product__item--btn'>"
                       + "<i class='fa-solid fa-bag-shopping'></i> Chọn mua"
                       + "</button>"
                         + "</div>";
                }
            }
            productList.InnerHtml = html;
        }
    }
}