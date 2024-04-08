<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs"
Inherits="BTL_WebCoBan.pages.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Login</title>
        <link rel="preconnect" href="https://fonts.googleapis.com">
        <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
        <link
            href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&display=swap"
            rel="stylesheet">
        <link rel="stylesheet" href="../styles/login.css">
    </head>
    <body>
        <form id="formLogin" runat="server" method="post"
            onsubmit="return checkLogin(event)">
            <div class="login__image">
                <img
                    src="https://img.freepik.com/free-photo/computer-security-with-login-password-padlock_107791-16191.jpg"
                    alt="imgage Login">
            </div>
            <div class="container">
                <h3 class="container__titel">Login</h3>
                <p class="container__description">Lorem ipsum dolor sit, amet
                    consectetur adipisicing elit. </p>
                <input type="text" name="userName" runat="server"
                    placeholder="Enter your user name ..." id="userName" />
                <h6 class="error"></h6>
                <input type="password" name="passWord" runat="server"
                    placeholder="Enter your Password ..." id="passWord"  />
                <h6 class="error"></h6>

                <div class="container__action">
                    <div class="remember">
                        <input type="checkbox" id="rememberMe" name="rememberMe"
                            runat="server"
                            checked />
                        <label for="rememberMe">Remember Me</label>
                    </div>

                    <a href="SignUp.aspx">You don't have account</a>
                </div>

                <asp:button CssClass="btnLogin" ID="btnLogin" runat="server"
                    Text="Login"
                    OnClick="btnLogin_Click"  />

                <div runat="server" id="errorLogin"
                    style="color: red;font-weight: 300;margin: 10px;"></div>
            </div>
        </form>

        <script>
            const checkLogin = (e) => {
                
                const  userName = document.querySelector('#userName').value.trim();
                const passWord = document.querySelector("#passWord").value.trim();
                const errors = document.getElementsByClassName("error");
                let check = true;
                if(userName === ""){
                    errors[0].innerHTML = "Please  fill out User Name...";
                    check = false;
                    /*userName.focus();*/
                    e.preventDefault();
                }else{
                    errors[0].innerHTML = "";
                    check=true;
                }
                if(passWord === ""){
                    errors[1].innerHTML = "Please  fill out Password...";
                    check = false;
                   /* passWord.focus();*/
                    e.preventDefault();
                }else{
                    errors[1].innerHTML = "";
                    check=true;
                }

                return check
            }
        </script>
    </body>
</html>
