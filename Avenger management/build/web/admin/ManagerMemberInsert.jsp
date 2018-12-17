<%-- 
    Document   : ManagerMemberInsert
    Created on : Jul 3, 2018, 10:10:05 PM
    Author     : THANG NGUYEN
--%>

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Insert Member</title>
    </head>
    <body>
        <a href="/THANGNTSE62915/admin/admin.jsp"><h1>Hello ${sessionScope.INFO.fullname}</h1></a>
        <a href="/THANGNTSE62915/admin/ManagerMemberSearch.jsp">Member</a>
        <a href="/THANGNTSE62915/admin/ManagerMissionInsert.jsp">Mission</a>
        <a href="/THANGNTSE62915/MainControllerWepM?action=LoadInsertPage">Weapon</a></br>
        <a href="/THANGNTSE62915/admin/ManagerMemberSearch.jsp">Search Member</a>
        <a href="/THANGNTSE62915/admin/ManagerMemberInsert.jsp">Insert Member</a>
        <h1>Insert Member</h1>
        <form action="/THANGNTSE62915/MainControllerMemM">
            ID: <input type="text" value="${requestScope.DTO.id}" name="txtId"/><font color="red">${requestScope.ERROBJ.errId}</font></br>
            Username: <input type="text" name="txtUsername" value="${requestScope.DTO.username}" /><font color="red">${requestScope.ERROBJ.errUsername}</font></br>
            Password: <input type="password" name="txtPassword" value="" /><font color="red">${requestScope.ERROBJ.errPassword}</font></br>
            Confirm Password: <input type="password" name="txtConPassword"  /><font color="red">${requestScope.ERROBJ.errConPassword}</font></br>
            Full name: <input type="text" name="txtFullname" value="${requestScope.DTO.fullname}" /><font color="red">${requestScope.ERROBJ.errFullname}</font></br>
            Birthday: <input type="text" name="txtBirthday" value="${requestScope.DTO.birthday}" /><font color="red">${requestScope.ERROBJ.errBirthday}</font></br>
            Gender: <select name="txtGender">
                <option value="Male" ${requestScope.DTO.gender == 'Male'?'selected':''}>Male</option>
                <option value="Female" ${requestScope.DTO.gender == 'Female'?'selected':''}>Female</option>
                <option value="Other" ${requestScope.DTO.gender == 'Other'?'selected':''}> Other</option>
            </select></br>
            Address: <input type="text" name="txtAddress" value="${requestScope.DTO.address}" /><font color="red">${requestScope.ERROBJ.errAddress}</font></br>
            Description: <textarea name="txtDescription">${requestScope.DTO.description}</textarea><font color="red">${requestScope.ERROBJ.errDescription}</font></br>
            <input type="Submit" name="action" value="Insert"> 
            ${requestScope.SUCESS}
        </form>
    </body>
</html>
