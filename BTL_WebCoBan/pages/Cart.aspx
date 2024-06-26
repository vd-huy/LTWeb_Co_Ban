﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="BTL_WebCoBan.pages.Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Cart</title>
    <link rel="stylesheet" href="../styles/cart.css">
    <link rel="stylesheet"
        href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css"
        integrity="sha512-DTOQO9RWCH3ppGqcWaEA1BIZOC6xxalwEsw9c2QQeAIftl+Vegovlnee1c9QX4TctnWMn13TZye+giMm8e2LwA=="
        crossorigin="anonymous" referrerpolicy="no-referrer" />
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link
        href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&display=swap"
        rel="stylesheet">
</head>
 <body>
     <div class="topbar">
         <h3 class="topbar__title">Giao hàng hỏa tốc trong 2H trong HN</h3>
     </div>

     <div class="container">
         <header class="header">
             <div class="header__menu">
                 <!-- <i class="header__menu--icon fa-solid fa-bars"></i> -->

                 <nav class="mobile__menu">
                     <input type="checkbox" id="check" hidden>

                     <label for="check" class="btnCheck">
                         <i class="check fa-solid fa-bars"></i>
                     </label>

                     <ul class="menu">
                         <li class="menu__home"><i
                                 class="fa-solid fa-house"></i></li>
                         <li class="menu__item">Mua Đồ cho chó</li>
                         <li class="menu__item ">Mua Đồ cho
                             méo</li>
                         <li class="menu__item">PETTAG MOZZI</li>
                         <li class="menu__item">Dịch vụ Spa</li>
                         <li class="menu__item">Khuyến mãi</li>
                         <li class="menu__item">Tin Tức</li>
                         <li class="menu__item">Liên hệ</li>
                     </ul>
                 </nav>

                 <a href="HomePage.aspx">
                     <img
                         src="https://theme.hstatic.net/200000263355/1001161916/14/logo.png?v=65"
                         alt="logo" class="header__logo">
                 </a>
             </div>

             <div class="header__search">
                 <input type="text" placeholder="Tìm kiếm sản phẩm">
                 <i class="fa-solid fa-magnifying-glass"></i>
             </div>

             <div class="header__controls">
                 <i class="header__controls--user fa-regular fa-user"></i>

                 <i
                     class="header__controls--cart fa-solid fa-cart-shopping"></i>
             </div>
         </header>

         <ul class="menu">
             <li class="menu__home"><i class="fa-solid fa-house"></i></li>
             <li class="menu__item">Mua Đồ cho chó</li>
             <li class="menu__item menu__item--active">Mua Đồ cho méo</li>
             <li class="menu__item">PETTAG MOZZI</li>
             <li class="menu__item">Dịch vụ Spa</li>
             <li class="menu__item">Khuyến mãi</li>
             <li class="menu__item">Tin Tức</li>
             <li class="menu__item">Liên hệ</li>
         </ul>

         <div class="cart__content">
             <div class="cart__item">
                 <h4 class="cart__title">Giỏ hàng của bạn</h4>

                 <hr>

                 <h4 class="cart__item--total">
                     Bạn đang có
                     <span class="count__product" runat="server" id="countProductTotal">1 sản phẩm
                     </span>
                     trong giỏ hàng</h4>
                 <div class="cart__product--list" runat="server" id="cartList">
                     <%-- List Product in Cart --%>
                 </div>
             </div>

             <div class="cart__total">
                 <div class="cart__title">Thông tin đơn hàng</div>

                 <hr />

                 <div class="total__price">
                     Tổng tiền:
                     <span
                         style="font-size: 24px; color: red;float: right; "></span>
                 </div>

                 <hr />

                 <ul class="cart__summary">
                     <li class="cart__summary--item">Miễn phí vận chuyển cho
                         đơn hàng từ 399.000đ (giảm tối đa 20.000đ)</li>
                     <li class="cart__summary--item">Giao hàng hỏa tốc trong
                         vòng 4 giờ, áp dụng tại khu vực nội thành Hà
                         Nội</li>
                 </ul>

                 <button class="cart__btn">Thanh Toán</button>
             </div>
         </div>

     </div>

     <hr>

     <footer class="footer">

         <div class="footer__content">
             <div class="footer__contact">
                 <h4 class="footer__title">Thông tin liên hệ</h4>
                 <h5 class="footer__contact--desc">
                     Mozzi.vn là trang mua sắm trực tuyến các sản phẩm bán lẻ
                     dành cho thú cưng của Mozzi Pet Shop. Công ty TNHH
                     MOZZI. Giấy chứng nhận Đăng ký Kinh doanh số 0315592769
                     do Sở Kế hoạch và Đầu tư Thành phố Hồ Chí Minh cấp ngày
                     28/03/2019.
                 </h5>

                 <img
                     src="https://theme.hstatic.net/200000263355/1001161916/14/footer_logobct_img.png?v=67"
                     alt="Chứng nhận bộ công thương"
                     class="footer__contact--img">
             </div>
             <div class="footer__infor">
                 <h4 class="footer__title">Thông tin cửa hàng</h4>

                 <h5 class="footer__contact--desc">
                     <p>Cửa hàng 1 : 544 Lê Hồng Phong, P.10, Quận 10,HCM
                     </p>
                     <p>
                         Cửa hàng 2 : 136 Huỳnh Văn Bánh, P.12, Quận Phú
                         Nhuận,HCM
                     </p>
                     <p> 0988.004.089</p>
                     <p>info@mozzi.vn</p>
                 </h5>
             </div>
             <div class="footer__service">
                 <h4 class="footer__title">Hỗ trợ khách hàng</h4>

                 <ul class="footer__service--list">
                     <li class="footer__service--item">Tìm kiếm</li>
                     <li class="footer__service--item">Giới thiệu</li>
                     <li class="footer__service--item">Chính sách bảo
                         mật</li>
                     <li class="footer__service--item">Chính sách thanh toán
                     </li>
                     <li class="footer__service--item">Chính sách giao
                         hàng</li>
                     <li class="footer__service--item">Chính sách đổi
                         trả</li>
                     <li class="footer__service--item">Hướng dẫn mua
                         hàng</li>
                     <li class="footer__service--item">Điền khoản dịch
                         vụ</li>
                 </ul>

             </div>
             <div class="footer__social ">
                 <h4 class="footer__title">Follow Us</h4>

                 <span class="footer__social--icon">
                     <i class="fa-brands fa-facebook"></i>
                 </span>
                 <span class="footer__social--icon">
                     <i class="fa-brands fa-instagram"></i>
                 </span>
                 <span class="footer__social--icon">
                     <i class="fa-brands fa-tiktok"></i>
                 </span>
                 <span class="footer__social--icon">
                     <i class="fa-brands fa-twitter"></i>
                 </span>

             </div>

         </div>

         <hr>

         <div class="footer__copyright">
             Copyright © 2024 by VuDucHuy,TranKhanhHung,NguyenVanHuy
         </div>
         
     </footer>
     

     <script type="text/javascript">

         const countCart = document.querySelector(".header__controls--cart");
         const plus = document.querySelectorAll(".plus");
         const minus = document.querySelectorAll(".minus");
         const count = document.querySelectorAll(".count");  
         const countProductTotal = document.querySelector(".count__product");

         const totalPrice = document.querySelector(".total__price span");
         let price;

         const btnDelete = document.querySelectorAll(".action__delete");
         
         window.addEventListener("DOMContentLoaded", () => {
             var countProductInCart = <%= getProductInCarts()%>
                 countProductTotal.innerHTML = ` ${countProductInCart} sản phẩm`;

                 countCart.setAttribute("data-total", countProductInCart);
                 price = <%=  getTotalPrice()%>
                
                     totalPrice.innerHTML = `${price.toLocaleString('en-US') }₫`;
         })
         
         plus.forEach((item,index)=>{
             item.addEventListener("click", () => {
                 let countProduct = count[index].innerText;
                 countProduct++;
                 count[index].innerHTML = countProduct;

                 window.location.href = `https://localhost:44392/pages/Cart.aspx?count=${countProduct}&&index=${index}`
               
                 let countProductInCart = <%= getProductInCarts()%>
                     countProductTotal.innerHTML = ` ${countProductInCart} sản phẩm`;

                 countCart.setAttribute("data-total", countProductInCart);
                 
             })
         })

         minus.forEach((item,index)=>{
             item.addEventListener('click', () => {
                 let countProduct = count[index].innerText;
                 if (countProduct > 1) {
                     countProduct--;
                     count[index].innerHTML = countProduct;

                     countProductt = countProduct;
                     indexProduct = index;

                     window.location.href = `https://localhost:44392/pages/Cart.aspx?count=${countProduct}&&index=${index}`

                     var countProductInCart = <%= getProductInCarts()%>
                         countProductTotal.innerHTML = ` ${countProductInCart} sản phẩm`;

                     countCart.setAttribute("data-total", countProductInCart);
                    
                 } else {
                     alert("You must have at least one item in your shopping cart.");
                 }
             })
         })

         btnDelete.forEach((item, index) => {
             item.addEventListener("click", () => {
                 window.location.href = `https://localhost:44392/pages/Cart.aspx?indexDelete=${index}`
             })
         })
         
     </script>

 </body>
</html>
