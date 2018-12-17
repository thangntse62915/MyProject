<%-- 
    Document   : ManagerMissionSearch
    Created on : Jul 13, 2018, 1:19:42 AM
    Author     : THANG NGUYEN
--%>

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Search Mission</title>
    </head>
    <body>
        <a href="/THANGNTSE62915/admin/admin.jsp"><h1>Hello ${sessionScope.INFO.fullname}</h1></a>
        <a href="/THANGNTSE62915/admin/ManagerMemberSearch.jsp">Member</a>
        <a href="/THANGNTSE62915/admin/ManagerMissionInsert.jsp">Mission</a>
        <a href="/THANGNTSE62915/MainControllerWepM?action=LoadInsertPage">Weapon</a></br>
        <a href="/THANGNTSE62915/admin/ManagerMissionSearch.jsp">Search Mission</a>
        <a href="/THANGNTSE62915/admin/ManagerMissionInsert.jsp">Insert Mission</a>
        <form action="/THANGNTSE62915/SearchControllerMissM">
            Name : <input type="text" name="name">
            Location : <input type="text" name="location" />
            Level <select name="level" style="width: 80px">
                <option value="SSS">SSS</option>
                <option value="SS">SS</option>
                <option value="S">S</option>
                <option value="A">A</option>
                <option value="B">B</option>            
            </select>

            Status : <select name="status">
                <option value="All">All</option>
                <option value="Create">Create</option>
                <option value="Create">Send</option>
                <option value="Receive">Receive</option>
                <option value="Finish">Finish</option>
            </select>
            <input type="submit" value="Search" name="action" />
        </form>
        <table border="1">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Start Date</th>
                    <th>End Date</th>
                    <th>Status</th>
                    <th colspan="2">Action</th>

                </tr>
            </thead>
            <tbody>
                <c:if test="${requestScope.LIST != null}">
                    <c:forEach var="dto" items="${requestScope.LIST}">
                        <tr>
                            <td>${dto.id}</td>
                            <td>${dto.name}</td>
                            <td>${dto.startDate}</td>
                            <td>${dto.endDate}</td>
                            <td>${dto.status}</td>
                            <td><c:if test="${dto.status == 'Create'}">
                                    <c:url var="delLink" value="DeleteControllerMissM">
                                        <c:param name="name">${param.name}</c:param>
                                        <c:param name="location">${param.location}</c:param>
                                        <c:param name="level">${param.level}</c:param>
                                        <c:param name="status">${param.status}</c:param>
                                        <c:param name="action">Delete</c:param>
                                        <c:param name="id">${dto.id}</c:param>
                                    </c:url>
                                    <a href="${pageScope.delLink}">Delete</a>
                                </c:if>
                            </td>
                            <td><c:if test="${dto.status == 'Create'}">
                                    <c:url var="editLink" value="./EditControllerMissM">
                                        <c:param name="name">${param.name}</c:param>
                                        <c:param name="location">${param.location}</c:param>
                                        <c:param name="level">${param.level}</c:param>
                                        <c:param name="status">${param.status}</c:param>
                                        <c:param name="id">${dto.id}</c:param>
                                    </c:url>
                                    <a href="${pageScope.editLink}">Edit</a>
                                </c:if>
                                <c:if test="${dto.status != 'Create'}">
                                    <c:url var="viewLink" value="./GetAllInfoMission">
                                        <c:param name="name">${param.name}</c:param>
                                        <c:param name="location">${param.location}</c:param>
                                        <c:param name="level">${param.level}</c:param>
                                        <c:param name="status">${param.status}</c:param>
                                        <c:param name="id">${dto.id}</c:param>
                                    </c:url>
                                    <a href="${pageScope.viewLink}">View</a>
                                </c:if>
                            </td>
                        </tr>
                    </c:forEach>
                </c:if>
            </tbody>
        </table>

    </body>
</html>
