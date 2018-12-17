<%-- 
    Document   : ManagerTeamMissionInsert
    Created on : Jul 12, 2018, 10:41:50 AM
    Author     : THANG NGUYEN
--%>

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Insert Mission</title>
    </head>
    <body>
       <a href="/THANGNTSE62915/admin/admin.jsp"><h1>Hello ${sessionScope.INFO.fullname}</h1></a>
        <a href="/THANGNTSE62915/admin/ManagerMemberSearch.jsp">Member</a>
        <a href="/THANGNTSE62915/admin/ManagerMissionInsert.jsp">Mission</a>
        <a href="/THANGNTSE62915/MainControllerWepM?action=LoadInsertPage">Weapon</a></br>
        <a href="/THANGNTSE62915/admin/ManagerMissionSearch.jsp">Search Mission</a>
        <a href="/THANGNTSE62915/admin/ManagerMissionInsert.jsp">Insert Mission</a>
        
        <form action="AddMissionTeam">
            <select name="txtName">
                <c:forEach items="${sessionScope.LIST}" var="dto">
                    <option value="${dto.username}-${dto.fullname}">${dto.fullname}</option>
                </c:forEach>
            </select><font color="red">${requestScope.ERR}</font>
            <input type="hidden" name="idMission" value="${sessionScope.DTO.id}" />        
            <input type="submit" name="action" value="Add">
        </form><table border="1">
            <thead>
                <tr>
                    <th>#</th>
                    <th>ID</th>
                    <th>Full name</th>
                    <th>Action</th>
                    <th>Position</th>
                </tr>
            </thead>
            <tbody>
                <c:if test="${ not empty requestScope.TEAM}" >
                    <c:forEach items="${requestScope.TEAM}" var="dt" varStatus="counter">
                        <tr>
                            <td>${counter.count}</td>
                            <td>${dt.id}</td> 
                            <td> ${dt.fullname}</td>
                            <td>
                                <c:url value="DeleteMemberInTeam" var="delLink">
                                    <c:param value="${dt.username}" name="username"></c:param>
                                </c:url>
                                <a href="${pageScope.delLink}">Delete</a>
                            </td>
                            <td>
                                <c:if test="${counter.count == 1}">
                                    Leader </c:if>
                                </td>
                            </tr>
                    </c:forEach> </c:if>
                </tbody>
            </table>
        <c:if test="${sessionScope.HTEAM.size() >0}">
            <form action="GetWeaponForTeam">
                <
                <input type="hidden" name="status" value="${sessionScope.LASTSEARCH.status}">
                <input type="hidden" name="idMission" value="${sessionScope.DTO.id}" />
                <input type="submit" name="action" value="Add Weapon" />
            </form>
        </c:if>

    </body>
</html>
