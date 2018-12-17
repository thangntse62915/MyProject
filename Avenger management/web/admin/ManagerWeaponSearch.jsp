<%-- 
    Document   : ManagerWeaponSearch.jsp
    Created on : Jul 4, 2018, 10:07:47 PM
    Author     : THANG NGUYEN
--%>

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Search Weapon</title>
    </head>
    <body>
        <a href="/THANGNTSE62915/admin/admin.jsp"><h1>Hello ${sessionScope.INFO.fullname}</h1></a>
         <a href="/THANGNTSE62915/admin/ManagerMemberSearch.jsp">Member</a>
        <a href="/THANGNTSE62915/admin/ManagerMissionInsert.jsp">Mission</a>
        <a href="/THANGNTSE62915/MainControllerWepM?action=LoadInsertPage">Weapon</a></br>
        <a href="/THANGNTSE62915/admin/ManagerWeaponSearch.jsp">Search Weapon</a>
        <a href="/THANGNTSE62915/MainControllerWepM?action=LoadInsertPage">Insert Weapon</a>
        <h1>Search Weapon</h1>
        <form action="/THANGNTSE62915/MainControllerWepM">
            Name : <input type="text" name="searchValue" /><font color="red">${requestScope.ERR.errname}</font>
            Status : <select name="status">
                <option value="All">All</option>
                <option value="Ready">Ready</option>
                <option value="Using">Using</option>
                <option value="Delete">Delete</option>

            </select>
            <input type="submit" value="Search" name="action" />
            <table border="1">

                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                        <th>Power</th>
                        <th>Designer</th>
                        <th>

                        </th>
                        <th>

                        </th>
                    </tr>
                </thead>
                <tbody>  <c:if test="${requestScope.LIST != null}">
                        <c:forEach var="dto" items="${requestScope.LIST}">
                            <tr>
                                <td>${dto.id}</td>
                                <td>${dto.name}</td>
                                <td>${dto.power}</td>
                                <td>${dto.designer}</td>
                                <td><c:if test="${dto.status == 'Ready'}">
                                        <c:url value="MainControllerWepM" var="delLink">
                                            <c:param name="searchValue">${param.searchValue}</c:param>
                                            <c:param name="status">${param.status}</c:param>
                                            <c:param name="id">${dto.id}</c:param>
                                            <c:param name="action">Delete</c:param>
                                        </c:url>
                                        <a href="${pageScope.delLink}">Delete</a>

                                    </c:if>
                                    <c:if test="${dto.status == 'Delete'}">
                                        <c:url value="MainControllerWepM" var="activeLink">
                                            <c:param name="searchValue">${param.searchValue}</c:param>
                                            <c:param name="status">${param.status}</c:param>
                                            <c:param name="id">${dto.id}</c:param>
                                            <c:param name="action">Active</c:param>
                                        </c:url>
                                        <a href="${pageScope.activeLink}">Active</a>

                                    </c:if>
                                </td>
                                <td>
                                    <c:url value="MainControllerWepM" var="editLink">
                                        <c:param name="searchValue">${param.searchValue}</c:param>
                                        <c:param name="status">${param.status}</c:param>
                                        <c:param name="action">Edit</c:param>
                                        <c:param name="id">${dto.id}</c:param>
                                    </c:url>
                                    <a href="${pageScope.editLink}">Edit</a>
                                </td>
                            </tr>
                        </c:forEach>
                    </c:if>
                </tbody>
            </table>

        </form>
    </body>
</html>
