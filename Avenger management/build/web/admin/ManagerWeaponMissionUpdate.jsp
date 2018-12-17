<%-- 
    Document   : ManagerWeaponMissionInsert
    Created on : Jul 12, 2018, 8:50:29 PM
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
    <body> <a href="/THANGNTSE62915/admin/admin.jsp"><h1>Hello ${sessionScope.INFO.fullname}</h1></a>
        <a href="/THANGNTSE62915/admin/ManagerMemberSearch.jsp">Member</a>
        <a href="/THANGNTSE62915/admin/ManagerMissionInsert.jsp">Mission</a>
        <a href="/THANGNTSE62915/MainControllerWepM?action=LoadInsertPage">Weapon</a>
        <h1>Insert Weapon</h1>
        <table border="1">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Full name</th>
                    <th>Position</th>
                    <th>Weapon</th>
                </tr>
            </thead> 
            <form action="UpdateWeaponForTeam">
                <tbody>
                    <c:if test="${ not empty requestScope.TEAM}" >
                        <c:forEach items="${requestScope.TEAM}" var="dt" varStatus="counter">
                            <tr>
                                <td>${counter.count}</td>
                                <td> ${dt.fullname}</td>

                                <td>
                                    <c:if test="${counter.count == 1}">
                                        Leader </c:if>
                                    </td>
                                    <td>
                                        <select name="${dt.username}">
                                        <c:forEach items="${dt.list}" var="wepdto">
                                            <option value="${wepdto.id}">${wepdto.name}</option>
                                        </c:forEach>
                                    </select>
                                </td>
                            </tr>

                        </c:forEach> </c:if>
                </tbody>
                <input type="submit" name="action" value="Finish" />
        </table>
         <c:url var="searchLink" value="SearchControllerMissM">
            <c:param name="name">${sessionScope.LASTSEARCH.name}</c:param>
            <c:param name="location">${sessionScope.LASTSEARCH.local}</c:param>
            <c:param name="level">${sessionScope.LASTSEARCH.level}</c:param>
            <c:param name="status">${sessionScope.LASTSEARCH.status}</c:param>
        </c:url>
        <a href="${searchLink}">Search Again</a>
    </form>
</body>
</html>
