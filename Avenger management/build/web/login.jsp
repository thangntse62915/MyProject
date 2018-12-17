<%-- 
    Document   : index
    Created on : Jul 2, 2018, 9:01:59 AM
    Author     : THANG NGUYEN
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Login</title>
    </head>
    <body>
        <div>
            <h1>Login</h1>
            <form action="LoginController">
                Username: <input type="text" name="txtUsername" value="" /><font color="red">${requestScope.ERR.errUsername}</font></br>
                Password: <input type="password" name="txtPassword" value="" /><font color="red">${requestScope.ERR.errPassword}</font></br>
                Role <select name="role">
                    <option value="Admin">Admin</option>
                    <option value="Member">Member</option>
                </select></br>

                <input type="submit" value="Login" name="action" /> <font color="red">${requestScope.FAIL}</font>
            </form>
        </div>
    </body>
</html>
