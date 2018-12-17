<%-- 
    Document   : ManagerMissionUpdate
    Created on : Jul 13, 2018, 11:16:16 AM
    Author     : THANG NGUYEN
--%>

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Update Mission</title>
    </head>
    <body>
 <a href="/THANGNTSE62915/admin/admin.jsp"><h1>Hello ${sessionScope.INFO.fullname}</h1></a>
        <a href="/THANGNTSE62915/admin/ManagerMemberSearch.jsp">Member</a>
        <a href="/THANGNTSE62915/admin/ManagerMissionInsert.jsp">Mission</a>
        <a href="/THANGNTSE62915/MainControllerWepM?action=LoadInsertPage">Weapon</a></br>
        <a href="/THANGNTSE62915/admin/ManagerMissionSearch.jsp">Search Mission</a>
        <a href="/THANGNTSE62915/admin/ManagerMissionInsert.jsp">Insert Mission</a>
        <h1>Create Mission</h1>
        <form action="/THANGNTSE62915/UpdateControllerMissM"  enctype="multipart/form-data" method="POST">

            ID: <input type="text" value="${requestScope.DTO.id}" name="txtId" readonly /><font color="red">${requestScope.ERR.errid}</font></br>
            Name <input type="text" name="txtName" value="${requestScope.DTO.name}" /><font color="red">${requestScope.ERR.errname}</font></br>
            Location: <input type="text" name="txtLocal" value="${requestScope.DTO.local}" /><font color="red">${requestScope.ERR.errlocal}</font></br>
            <c:if test="${param.readonly == 'readonly'}">
                Level <input type="text" name="txtName" value="${requestScope.DTO.level}"/>
            </c:if>
            <c:if test="${param.readonly != 'readonly'}">
                Level <select name="txtLevel" style="width: 80px" >
                    <option value="SSS" ${requestScope.DTO.level == 'SSS'?'selected':''}>SSS</option>
                    <option value="SS"${requestScope.DTO.level == 'SS'?'selected':''}>SS</option>
                    <option value="S"${requestScope.DTO.level == 'S'?'selected':''}>S</option>
                    <option value="A"${requestScope.DTO.level == 'A'?'selected':''}>A</option>
                    <option value="B"${requestScope.DTO.level == 'B'?'selected':''}>B</option>            
                </select>
                Description and image: <input type="file" name="file" value="" accept=".rar" /><font color="red">${requestScope.ERR.errdescription}</font></br>
            </c:if>
            Start date <input type="date" name="begin" value="${requestScope.DTO.startDate}" ><font color="red">${requestScope.ERR.errstartDate}</font></br>
            End Date<input type="date" name="end" value="${requestScope.DTO.endDate}"/><font color="red">${requestScope.ERR.errendDate}</font></br>

            <a href=".${requestScope.DTO.description}" download="">Download to Update File</a>
            <input type="hidden" name="name" value="${sessionScope.LASTSEARCH.name}">
            <input type="hidden" name="location" value="${sessionScope.LASTSEARCH.local}">
            <input type="hidden" name="level" value="${sessionScope.LASTSEARCH.level}">
            <input type="hidden" name="status" value="${sessionScope.LASTSEARCH.status}">
            <c:url var="searchLink" value="SearchControllerMissM">
                <c:param name="name">${sessionScope.LASTSEARCH.name}</c:param>
                <c:param name="location">${sessionScope.LASTSEARCH.local}</c:param>
                <c:param name="level">${sessionScope.LASTSEARCH.level}</c:param>
                <c:param name="status">${sessionScope.LASTSEARCH.status}</c:param>
            </c:url>

            <input type="Submit" name="action" value="Update & Add Team">  

            <a href="${searchLink}">Search Again</a>

        </form>
    </body>
</html>
