using BTL_WebCoBan.objects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WebCoBan.pages
{
    public partial class Cart : System.Web.UI.Page
    {
       public List<objects.productInCart> listProductCarts;
        protected void Page_Load(object sender, EventArgs e)
        {
            listProductCarts = (List<objects.productInCart>)Application["productInCarts"];
            string html = "";
            string strCount = Request.QueryString["count"];
            string strIndex = Request.QueryString["index"];
            string strIndexDelete = Request.QueryString["indexDelete"];
            int count, index, indexDelete;

            if (strCount != null && strIndex != null)
            {

                for (global::System.Int32 i = 0; i < listProductCarts.Count; i++)
                {
                    int.TryParse(strCount, out count);
                    int.TryParse(strIndex, out index);
                    if (listProductCarts[i].UserName == Session["userName"] && index == i)
                    {
                        listProductCarts[index].CountProduct = count;
                    }
                }
            }
            if (strIndexDelete != null && listProductCarts.Count > 0)
            {
                int.TryParse(strIndexDelete, out indexDelete);
                listProductCarts.RemoveAt(indexDelete);
               
            }

            if (listProductCarts.Count > 0)
            {
                foreach (objects.productInCart product in listProductCarts)
                {
                    if (product.UserName == Session["userName"])
                    {
                        double priceDisCount = product.Product.Price * (1 - product.Product.Discount);
                        string strPrice = priceDisCount.ToString("#,##0");
                        html += "<div class='cart__product--item'>"
                            + "<div class='product__item--detail'>"
                            + "<img src='" + product.Product.Img + "' alt='cart product'>"
                            + "<div> <h5 class='product__item--name'>" + product.Product.Name + "</h5> "
                            + "<h5 class= product__item--price >" + strPrice + "</h5> </div> "
                            + "</div> <div class='product__item--action'> "
                            + "<div class='item__count'>"
                            + "<button class='item__count--icon minus'><i class='fa-solid fa-minus'></i></button>"
                            + "<span class='count'>" + product.CountProduct + "</span>"
                            + "<button class='item__count--icon plus' ><i class='fa-solid fa-plus'></i></button></div> "
                            + "<button class='action__delete'>Xóa</button></div></div>";
                    }
                }
            }
            else
            {
                html += "<center>" +
                    "<img src='../Images/nodata.jpg'" +
                    "alt='No Product In Cart '> " +
                    "</center>";
            }
            

            cartList.InnerHtml = html;

        }

        protected double getTotalPrice()
        {
            listProductCarts = (List<objects.productInCart>)Application["productInCarts"];

            double totalPrice = 0;

            foreach (objects.productInCart product in listProductCarts)
            {
                if (product.UserName == Session["userName"])
                {    
                    double priceDisCount = product.Product.Price * (1 - product.Product.Discount);
                    double price = priceDisCount * product.CountProduct ;
                    
                    totalPrice += price;
                }
            }

            return totalPrice ;
        }

        //protected int[] getCountProduct()
        //{
        //    listProductCarts = (List<objects.productInCart>)Application["productInCarts"];
        //    var arrayCount = new int[listProductCarts.Count];
        //    for (int i = 0; i < listProductCarts.Count; i++)
        //    {
        //        arrayCount[i] = listProductCarts[i].CountProduct;
        //    }
        //    return arrayCount;
        //}

        protected int getProductInCarts()
        {
            listProductCarts = (List<objects.productInCart>)Application["productInCarts"];

            if (listProductCarts == null)
            {
                return 0;
            }
            else
            {
                int countProduct = 0;
                foreach (objects.productInCart product in listProductCarts)
                {
                    
                    if (product.UserName == Session["userName"]) {
                            countProduct += product.CountProduct;
                        }
                }

                return countProduct;
            }

        }


    }
}