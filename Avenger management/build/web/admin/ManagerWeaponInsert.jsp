<%-- 
    Document   : ManagerWeaponInsert
    Created on : Jul 6, 2018, 10:12:07 AM
    Author     : THANG NGUYEN
--%>

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Insert Weapon</title>
    </head>
    <body>
        <a href="/THANGNTSE62915/admin/admin.jsp"><h1>Hello ${sessionScope.INFO.fullname}</h1></a>
        <a href="/THANGNTSE62915/admin/ManagerMemberSearch.jsp">Member</a>
        <a href="/THANGNTSE62915/admin/ManagerMissionInsert.jsp">Mission</a>
        <a href="/THANGNTSE62915/MainControllerWepM?action=LoadInsertPage">Weapon</a></br>
        <a href="/THANGNTSE62915/admin/ManagerWeaponSearch.jsp">Search Weapon</a>
        <a href="/THANGNTSE62915/MainControllerWepM?action=LoadInsertPage">Insert Weapon</a>
        <h1>Insert Weapon</h1>
        <form action="/THANGNTSE62915/InsertControllerMWepM"  enctype="multipart/form-data" method="POST">
            ID: <input type="text" value="${requestScope.DTO.id}" name="txtId"/><font color="red">${requestScope.ERR.errid}</font></br>
            Name <input type="text" name="txtName" value="${requestScope.DTO.name}" /><font color="red">${requestScope.ERR.errname}</font></br>
            Color: <input type="text" name="txtColor" value="${requestScope.DTO.color}" /><font color="red">${requestScope.ERR.errcolor}</font></br>
            Designer: <input type="text" name="txtDesigner" value="${requestScope.DTO.designer}" /><font color="red">${requestScope.ERR.errdesigner}</font></br>
            Power <input type="text" name="txtPower" value="${requestScope.DTO.power}" /><font color="red">${requestScope.ERR.errpower}</font></br>  
            Using <select name="txtIdMem" style="width: 80px">
                <c:forEach var="dto" items="${sessionScope.LIST}">
                    <option value="${dto.username}">${dto.fullname}</option>
                </c:forEach>
            </select>
            Image <input type="file" name="image" accept=".jpg, .jpeg, .png""/>
            <font color="red">${requestScope.ERR.errimage}</font></br>
            <input type="Submit" name="action" value="Insert">  
        </form>

    </body>
</html>
