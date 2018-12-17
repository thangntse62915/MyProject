<%-- 
    Document   : error.jsp
    Created on : Jul 3, 2018, 9:12:45 AM
    Author     : THANG NGUYEN
--%>

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>

<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Error Page</title>
    </head>
    <body>

        <h1>Hello ${sessionScope.INFO.fullname}</h1>
        Action is failed.${requestScope.MES}<a href="${requestScope.LINK}">Click Here</a> to go back.
    </body>
</html>
