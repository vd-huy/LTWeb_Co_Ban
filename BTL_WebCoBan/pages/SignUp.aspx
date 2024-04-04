<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs"
Inherits="BTL_WebCoBan.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Sign Up</title>
        <link rel="preconnect" href="https://fonts.googleapis.com">
        <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
        <link
            href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&display=swap"
            rel="stylesheet">
        <link rel="stylesheet" href="../styles/login.css"">
        <link rel="stylesheet" href="../styles/signup.css">
    </head>
    <body>

        <form id="formSignUp" runat="server" method="post"
            onsubmit="return checkSignUp(event)">
            <div class="login__image">
                <img
                    src="https://img.freepik.com/free-photo/computer-security-with-login-password-padlock_107791-16191.jpg"
                    alt="imgage Login">
            </div>
            <div class="container">
                <h3 class="container__titel">Login</h3>
                <p class="container__description">Lorem ipsum dolor sit, amet
                    consectetur adipisicing elit. </p>
                <input type="text" name="firstName"
                    placeholder="Enter your First name ..." id="firstName" />
                <h6 class="error"></h6>
                <input type="text" name="lastName"
                    placeholder="Enter your Last Name ..." id="lastName" />
                <h6 class="error"></h6>
                <input type="text" name="userName"
                    placeholder="Enter your user name ..." id="userName" />
                <h6 class="error"></h6>
                <input type="password" name="passWord"
                    placeholder="Enter your Password ..." id="passWord"  />
                <h6 class="error"></h6>
                <input type="email" name="email"
                    placeholder="Enter your Email ..." id="email" />
                <h6 class="error"></h6>

                <div class="container__action">
                    <div class="remember">
                        <input type="checkbox" id="rememberMe" name="rememberMe"
                            checked />
                        <label for="rememberMe">Remember Me</label>
                    </div>

                    <a href="./login.aspx">You have account</a>
                </div>

                <asp:button CssClass="btnSignUp" ID="btnSignUp" runat="server"
                    Text="Sign Up" OnClick="btnSignUp_Click" />

                <div runat="server" id="errorLogin"
                    style="color: red;font-weight: 300;margin: 10px;"></div>

            </div>
        </form>

        <script>
            function checkSignUp(e) {
               /* e.preventDefault();*/
                const  userName = document.querySelector('#userName');
                const passWord = document.querySelector("#passWord");
                const firstName = document.querySelector('#firstName');
                const lastName = document.querySelector("#lastName");
                const email = document.querySelector('#email');
                const errors = document.getElementsByClassName("error");
                let check = true;

                if (firstName.value.trim() === "") {
                    errors[0].innerHTML = "Please  fill out First Name...";
                    firstName.focus();
                    check = false;
                    e.preventDefault();
                } else {
                    errors[0].innerHTML = "";
                    check = true;
                }

                if (lastName.value.trim() === "") {
                    errors[1].innerHTML = "Please  fill out Last Name...";
                    lastName.focus();
                    check = false;
                    e.preventDefault();
                } else {
                    errors[1].innerHTML = "";
                    check = true;
                }

                if (userName.value.trim() === ""){
                    errors[2].innerHTML = "Please  fill out User Name...";
                    userName.focus();
                    check = false;
                    e.preventDefault();
                }else{
                    errors[2].innerHTML = "";
                    check=true;
                }
                if (passWord.value.trim() === ""){
                    errors[3].innerHTML = "Please  fill out Password...";
                    check = false;
                    passWord.focus();
                    e.preventDefault();
                }else{
                    errors[3].innerHTML = "";
                    check=true;
                }
                if (email.value.trim() === "") {
                    errors[4].innerHTML = "Please  fill out Email...";
                    email.focus();
                    check = false;
                    e.preventDefault();
                } else {
                    errors[4].innerHTML = "";
                    check = true;
                }

                return check
            }
        </script>

    </body>
</html>
