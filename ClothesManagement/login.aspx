<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0" />
    <meta charset="UTF-8" />
    <title>登陆</title>

    <!-- CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/form.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />
    <link href="css/animate.css" rel="stylesheet" />
    <link href="css/generics.css" rel="stylesheet" />
</head>
<body id="skin-blur-violate">
    <section id="login">
        <header>
            <h1>服装仓库管理系统</h1>
            <p>简略说明简略说明简略说明简略说明简略说明简略说明简略说明简略说明简略说明简略说明简略说明简略说明简略说明</p>
        </header>

        <div class="clearfix"></div>

        <!-- Login -->
        <form runat="server">
            <div class="box tile animated active" id="box-login">
                <h2 class="m-t-0 m-b-15">Login</h2>
                <asp:TextBox ID="tbxUsername" runat="server" class="login-control m-b-10" placeholder="用户名或密码"></asp:TextBox>
                <asp:TextBox ID="tbxPsw" runat="server" class="login-control"></asp:TextBox>
                <div class="checkbox m-b-20">
                    <label>
                        <input type="checkbox" />
                        Remember Me
                   
                    </label>
                </div>
                <asp:Label ID="lblLoginError" runat="server" Text=""></asp:Label>
                <br />
                <asp:Button class="btn btn-sm m-r-5" ID="btnLogin" runat="server" Text="登陆" OnClick="btnLogin_Click" />

                <small>
                    <a class="box-switcher" data-switch="box-register" href="login.html">Don't have an Account?</a> or
                   
                <a class="box-switcher" data-switch="box-reset" href="login.html">Forgot Password?</a>
                </small>
            </div>
        </form>

        <!-- Register -->
        <form class="box animated tile" id="box-register">
            <h2 class="m-t-0 m-b-15">Register</h2>
            <input type="text" class="login-control m-b-10" placeholder="Full Name">
            <input type="text" class="login-control m-b-10" placeholder="Username">
            <input type="email" class="login-control m-b-10" placeholder="Email Address">
            <input type="password" class="login-control m-b-10" placeholder="Password">
            <input type="password" class="login-control m-b-20" placeholder="Confirm Password">

            <button class="btn btn-sm m-r-5">Register</button>

            <small><a class="box-switcher" data-switch="box-login" href="login.html">Already have an Account?</a></small>
        </form>

        <!-- Forgot Password -->
        <form class="box animated tile" id="box-reset">
            <h2 class="m-t-0 m-b-15">Reset Password</h2>
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla eu risus. Curabitur commodo lorem fringilla enim feugiat commodo sed ac lacus.</p>
            <input type="email" class="login-control m-b-20" placeholder="Email Address">

            <button class="btn btn-sm m-r-5">Reset Password</button>

            <small><a class="box-switcher" data-switch="box-login" href="login.html">Already have an Account?</a></small>
        </form>
    </section>

    <!-- Javascript Libraries -->
    <!-- jQuery -->
    <script src="js/jquery.min.js"></script>
    <!-- jQuery Library -->

    <!-- Bootstrap -->
    <script src="js/bootstrap.min.js"></script>

    <!--  Form Related -->
    <script src="js/icheck.js"></script>
    <!-- Custom Checkbox + Radio -->

    <!-- All JS functions -->
    <script src="js/functions.js"></script>
</body>
</html>
