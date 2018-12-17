<%-- 
    Document   : ManagerWeaponUpdate
    Created on : Jul 5, 2018, 10:07:24 AM
    Author     : THANG NGUYEN
--%>

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Update Weapon</title>
    </head>
    <body> <a href="/THANGNTSE62915/admin/admin.jsp"><h1>Hello ${sessionScope.INFO.fullname}</h1></a>
         <a href="/THANGNTSE62915/admin/ManagerMemberSearch.jsp">Member</a>
        <a href="/THANGNTSE62915/admin/ManagerMissionInsert.jsp">Mission</a>
        <a href="/THANGNTSE62915/MainControllerWepM?action=LoadInsertPage">Weapon</a></br>
        <a href="/THANGNTSE62915/admin/ManagerWeaponSearch.jsp">Search Weapon</a>
        <a href="/THANGNTSE62915/MainControllerWepM?action=LoadInsertPage">Insert Weapon</a>
        <h1>Update Weapon</h1>
        <form action="MainControllerWepM">
            Id: <input type="text" value="${requestScope.DTO.id}" name="txtId" readonly=""/></br>
            Name:<input type="text" value="${requestScope.DTO.name}" name="txtName"/>${requestScope.ERROBJ.errname}</br>
            Color: <input type="text" value="${requestScope.DTO.color}" name="txtColor"/>${requestScope.ERROBJ.errcolor}</br>
            Power <input type="text" value="${requestScope.DTO.power}" name="txtPower"/>${requestScope.ERROBJ.errpower}</br>
            Designer: <input type="text" value="${requestScope.DTO.designer}" name="txtDesigner" />${requestScope.ERROBJ.errdesigner}</br>
            Using <select style="width: 80px" disabled></br>
                <c:forEach var="dto" items="${sessionScope.LIST}">
                    <option value="${dto.username}" ${requestScope.DTO.idMem == dto.username?'selected':''} >${dto.fullname}</option>
                </c:forEach>
            </select></br></br>
            <input type="hidden" name="txtIdMem" value="${requestScope.DTO.idMem}">
            <input type="hidden" name="searchValue" value="${param.searchValue}">
            <input type="hidden" name="status" value="${param.status}">
            <input type="hidden" name="img" value="${requestScope.DTO.img}">
            <input type="submit" name="action" value="Update"></br>
        </form>
        <form action="/THANGNTSE62915/UploadImgWepController"method="POST" enctype="multipart/form-data">
            <div class="upload">
                <img src="${requestScope.DTO.img}" alt="   Upload Image" width="120" height="150" style="line-height: 150px;"/>
                <div class="upload_img">
                    <input type="hidden" value="${requestScope.DTO.id}"  name="txtId" />
                    <input type="file" name="img" accept=".jpg, .jpeg, .png" class="file">
                    <input type="hidden" name="searchValue" value="${requestScope.SEARCH}" />
                    <input type="hidden" name="status" value="${requestScope.STATUS}" />
                </div>
            </div><input type="submit" value="Upload" /></form>
        <font color="red">${requestScope.ERRIMG}</font>
        <c:url value="MainControllerWepM" var="backLink">
            <c:param name="searchValue">${param.searchValue}</c:param>
            <c:param name="status">${param.status}</c:param>
            <c:param name="action">Search</c:param>
        </c:url>
        <a href="${pageScope.backLink}">Click to search  page before</a>
    </body>
</html>
