<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Customer.demo2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="main.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="font-awesome-4.7.0/css/font-awesome.min.css" />
 
    <link href="bootstrap.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form" runat="server">
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
            
              <div class="cart" style="border:none;">
                    <asp:Button ID="Button3" runat="server" OnClick="Button1_Click1" Text="MyCart" Height="40" CssClass="btn btn-info" />
                </div>
            </header>
            <div id="detail_id" class="detail" style="width:1200px;">
<ul>
                    <li class="drop-down-menu detail_menu"><a href="Home.aspx">HOME</a>
                        <li class="drop-down-menu detail_menu">
                            <a href="AllCakes.aspx" style="line-height: 40px;">CAKES 
                            <i class="fa fa-chevron-down xoay " aria-hidden="true" style="font-size: 10px"></i>
                            </a>
                        </li>
                </ul>
            </div>
            <div class="introduce">
                <img src="img/Background/images1.jpg"  id="img1" width="1280" height="500">
                <img src="img/Background/images2.jpg"  id="img2" width="1280" height="500">
                <img src="img/Background/images4.jpg"  id="img3" width="1280" height="500">
                <img src="img/Background/images5.jpg"  id="img4" width="1280" height="500">
                <img ssrc="img/Background/images.jpg" " id="img5" width="1280" height="500">
            </div>
            <table width="1280" border="0" style="margin-top: 20px;">
                <tr>
                    <td height="76" colspan="4" style="font-weight: bold; font-size: 33px; text-align: center;">
                        <hr width="40%" size="2px" align="center" color="#999999" style="margin-left: auto; margin-right: auto; margin-bottom: 5px;" />
                        BEST SELLERS
                    </td>
                </tr>
                <tr>
                    
                    <asp:Repeater ID="Repeater2" runat="server" >
                        <ItemTemplate>
                            <td>
                                <div class="box_product" style="display: inline-block; margin-left: 35px">
                                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# "data:Image/png;base64,"+ Convert.ToBase64String((byte[])Eval("img1"))    %>' ForeColor="#0000C8" Width="136" Height="102" />
                                    <div>
                                        <div class="brand_box1"><%#Eval("name")%></div>

                                        <div>
                                            <span class="brand_box3-1"><%#Eval("price")%></span><span class="brand_box3-2"> VND</span><span class="brand_box3-3"></span>

                                        </div>
                                    </div>
                                    <div class="add_cart" style="margin-top: 17px;">
                                        <asp:Button ID="Button1" runat="server" Text="ADD TO CART" OnClick="Button1_Click" CommandArgument='<%#Eval("CakeId") + ","+Eval("name")+ ","+Eval("price") %>' />
                                    </div>
                            </td>
                        </ItemTemplate>
                    </asp:Repeater>


                </tr>

            </table>


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
