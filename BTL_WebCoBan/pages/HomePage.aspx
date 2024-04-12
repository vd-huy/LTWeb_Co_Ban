<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="BTL_WebCoBan.pages.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Home</title>
        
        <link rel="stylesheet"
            href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css"
            integrity="sha512-DTOQO9RWCH3ppGqcWaEA1BIZOC6xxalwEsw9c2QQeAIftl+Vegovlnee1c9QX4TctnWMn13TZye+giMm8e2LwA=="
            crossorigin="anonymous" referrerpolicy="no-referrer" />
        <link rel="preconnect" href="https://fonts.googleapis.com">
        <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
        <link
            href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&display=swap"
            rel="stylesheet">
        <%--<link rel="stylesheet" href="../styles/home.css">--%>
        <link href="~/Styles/home.css" rel="stylesheet" type="text/css" media="screen" runat="server" />
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
                    
                    <a href="Cart.aspx" style="color: black;">
                    <i class="header__controls--cart fa-solid fa-cart-shopping" ></i>
                    </a>
                </div>
            </header>

            <ul class="menu">
                <li class="menu__home">
                    <a href="HomePage.aspx" style="color: #522f1f;">
                        <i class="fa-solid fa-house"></i>
                    </a>
                </li>
                <li class="menu__item">Mua Đồ cho chó</li>
                <li class="menu__item menu__item--active">Mua Đồ cho mèo</li>
                <li class="menu__item">PETTAG MOZZI</li>
                <li class="menu__item">Dịch vụ Spa</li>
                <li class="menu__item">Khuyến mãi</li>
                <li class="menu__item">Tin Tức</li>
                <li class="menu__item">Liên hệ</li>
            </ul>

            <div class="slider">
                <div class="slider__img">
                    <img
                        src="https://theme.hstatic.net/200000263355/1001161916/14/slide_2_img.jpg?v=65"
                        alt="Slide Image">
                </div>

                <button class="slider__btn slider__prev">
                    <i class="fa-solid fa-chevron-left"></i>
                </button>

                <button class="slider__btn slider__next">
                    <i class="fa-solid fa-chevron-right"></i>
                </button>
            </div>

            <div class="promotion">
                <ul class="menu__promotion">
                    <li class="menu__item menu__promotion--item">Ship code toàn
                        quốc
                        <h4>Thanh toán khi nhận hàng</h4>
                    </li>
                    <li class="menu__item menu__promotion--item">Miễn phí đổi
                        hàng
                        <h4>Trong vòng 7 ngày</h4>
                    </li>
                    <li class="menu__item menu__promotion--item">Giao hàng trong
                        ngày
                        <h4>Với đơn nội thành Hà Nội</h4>
                    </li>
                    <li class="menu__item menu__promotion--item">Đặt hàng trực
                        tuyến
                        <h4>Hotline : 0964129650</h4>
                    </li>

                </ul>
            </div>

            <!-- Product List -->

            <div class="product__discount">
                <h4 class="product__discount--title">Sản phẩm đang khuyến
                    mãi</h4>

                <div class="product__list" runat="server" id="productList">
                    <!-- Product item -->

                </div>
            </div>

        </div>
        <!-- Footer -->

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
            const countCart = document.querySelector('.header__controls--cart');

            var countProductInCart = <%= getProductInCarts()%>

                countCart.setAttribute("data-total", countProductInCart);
        </script>

    </body>
</html>
