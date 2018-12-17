<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Customer.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="font-awesome-4.7.0/css/font-awesome.min.css" />
    <link href="register.css" rel="stylesheet" />
    <link href="main.css" rel="stylesheet" />
    <link href="bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="main_box">
              <div id="main_title">

                <a><i class="fa fa-phone"></i>Hotline 09123456789</a>
                <a><i class="fa fa-envelope"></i>bakeryhop@gmail.com</a>

                <% if (((DAOLibrary.tblCustomer)(Session["LoginInfo"])) != null)
                    { %>
                <div style="width: 250px;">
                    <a style="text-decoration: none; color: #FFF" class="login_title"><%: ((DAOLibrary.tblCustomer)(Session["LoginInfo"])).fullname %></a>
                </div>
                <div style="position: absolute; right: 50px;"><a href="Logout.aspx" style="text-decoration: none; color: #FFF">Logout</a></div>
                <% }
                    else
                    { %>
                <div style="width: 250px;">
                    <a style="text-decoration: none; color: #FFF" class="login_title" href="Login.aspx">Login</a>
                </div>
                <div style="position: absolute; right: 50px;"><a href="Register.aspx" style="text-decoration: none; color: #FFF">Register</a></div>
                <% }%>
            </div>
            <header>
                <div class="logo">
                    <a href="Home.aspx">
                        <img src="img/Background/logo.png" width="189" height="80"></a>
                </div>
            
              
            </header>
            <div id="detail_id" class="detail">
                <ul>
                    <li class="drop-down-menu detail_menu"><a href="News.html">NEWS</a>
                        <li class="drop-down-menu detail_menu">
                            <a href="men.html" style="line-height: 40px;">TYPES 
                            <i class="fa fa-chevron-down xoay " aria-hidden="true" style="font-size: 10px"></i>
                            </a>
                            <div class="drop-down ">
                                <div class="drop-down-item">Sneakers</div>
                                <div class="drop-down-item">Sandals</div>
                                <div class="drop-down-item">Boots</div>
                                <div class="drop-down-item">Loafers</div>
                                <div class="drop-down-item">Oxfords</div>
                            </div>
                        </li>

                       
                </ul>
            </div>
            <div class="container">
                <div class="form-signin col-sm-4">
                    <asp:Label ID="alert" runat="server" Text="" CssClass="alert-danger"></asp:Label>
                    <h2 class="form-signin-heading">Login</h2>
                    <input id="txtPhone" runat="server" class="form-control" placeholder="Phone..." />
                    <asp:RequiredFieldValidator ID="RequiredPhoneValidator" ControlToValidate="txtPhone" runat="server" ErrorMessage="Phone is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <input id="txtPassword" runat="server" class="form-control" placeholder="Password..." type="password" />
                    <asp:RequiredFieldValidator ID="RequiredPasswordValidator" ControlToValidate="txtPassword" runat="server" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Sign In" CssClass="btn btn-lg btn-primary btn-block" />
                </div>
                <br />
            </div>
            <footer>
                <div class="footer-menu">
                    <b>Customer Service</b>
                    <ul>
                        <li>Safe Shopping Guarantee</li>
                        <li>Forgot Password</li>
                        <li>Shipping Rates</li>
                        <li>Return Policy</li>

                    </ul>
                </div>
                <div class="footer-menu">

                    <b>Shopping</b>
                    <ul>
                        <li>Vomens</li>
                        <li>Mens</li>
                        <li>Kids</li>
                        <li>Brands</li>
                    </ul>
                </div>
                <div class="footer-menu">

                    <b>My Account</b>
                    <ul>
                        <li>Login/Register</li>
                        <li>My Account</li>
                        <li>Order Status</li>
                        <li>Order History</li>
                        <li>Track My Order</li>
                    </ul>
                </div>
                <div class="footer-menu">
                    <b>Infomation</b>
                    <ul>
                        <li>About</li>
                        <li>Site Map</li>
                        <li>Coupons</li>
                        <li>Find us on:</li>
                        <li>
                            <a href="https://www.youtube.com/" target="_blank"><i class="fa fa-youtube-play fa-lg" aria-hidden="true" style="color: red;"></i></a>
                            <a href="https://www.facebook.com/www.mwc.vn/" target="_blank"><i class="fa fa-facebook-official fa-lg" aria-hidden="true" style="color: #03C"></i></a>
                            <a href="https://twitter.com/?lang=en" target="_blank"><i class="fa fa-twitter-square fa-lg" aria-hidden="true" style="color: #06F"></i></a>
                        </li>
                    </ul>
                </div>
                <div class="footer-menu">
                    <b>Resources</b>
                    <ul>
                        <li>Associate Program</li>
                        <div class="feedback">

                            <strong style="color: #000">How Do You Like Our Website ? </strong>
                            <br />
                            We'd like to get your <a href="#" style="font-size: 16px; color: #000">feedback</a>.
                        </div>
                    </ul>
                </div>
                <div class="service">
                    <a href="#">Terms Of Use</a> | <a href="#">Privacy Policy</a> | <a href="#">Interest-Based Ads </a>
                    | <a href="#">welg</a>
                </div>
                <div class="icon-card">
                    <a href="home.html">
                        <img src="img/card/download.png" width="40">
                    </a>
                    <a href="home.html">
                        <img src="img/card/images.jpg" width="40">
                    </a>

                    <a href="home.html">
                        <img src="img/card/download (1).png" width="40">
                    </a>
                    <a href="home.html">
                        <img src="img/card/download.png" width="40">
                    </a>
                </div>
                <div class="footer-bot">
                    <p>© 2009-2017 mwc.com, Inc. or its affiliates, 400  Avenue. Califonia NV 89101</p>
                    <p>5pm.com is operated by ABC, Inc. Products on 8pm.com are sold by  DEF shop.</p>
                    <p>
                        For premier service, selection, and shipping, visit <a href="#" style="color: #999">Abc.com</a> — your one-stop shop for 	the latest in 
                    <a href="#" style="color: #999">Shoes</a> , <a href="#" style="color: #999">Shadals</a>
                        <p>
                            For luxury and designer styles by  <a href="#" style="color: #999;">T&T</a>
                        </p>
                </div>
            </footer>
    </form>

</body>
</html>
