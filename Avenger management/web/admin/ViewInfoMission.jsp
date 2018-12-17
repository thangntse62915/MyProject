<%-- 
    Document   : ViewInfoMission
    Created on : Jul 15, 2018, 2:13:58 AM
    Author     : THANG NGUYEN
--%>

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>View Mission</title>
    </head>
    <body>

        <a href="/THANGNTSE62915/admin/admin.jsp"><h1>Hello ${sessionScope.INFO.fullname}</h1></a>
        <a href="/THANGNTSE62915/admin/ManagerMemberSearch.jsp">Member</a>
        <a href="/THANGNTSE62915/admin/ManagerMissionInsert.jsp">Mission</a>
        <a href="/THANGNTSE62915/MainControllerWepM?action=LoadInsertPage">Weapon</a></br>
        <a href="/THANGNTSE62915/admin/ManagerMissionSearch.jsp">Search Mission</a>
        <a href="/THANGNTSE62915/admin/ManagerMissionInsert.jsp">Insert Mission</a>
        <h1>View Mission</h1>
        ID: <input type="text" value="${requestScope.DTO.id}" name="txtId" readonly /></br>
        Name <input type="text" name="txtName" value="${requestScope.DTO.name}" readonly/></font</br>
        Location: <input type="text" name="txtLocal" value="${requestScope.DTO.local}" readonly/></br>
        Level <input type="text" name="txtName" value="${requestScope.DTO.level}"readonly/>
        Start date <input type="date" name="begin" value="${requestScope.DTO.startDate}"readonly ></br>
        End Date<input type="date" name="end" value="${requestScope.DTO.endDate}"readonly/></br>
        Finish Date<input type="date" name="end" value="${requestScope.DTO.finishDate}"readonly/></br>
        <table border="1" style="width: 400px;text-align: center;">
            <thead>
                <tr>
                    <th>#</th>
                    <th>ID</th>
                    <th>Fullname</th>
                    <th>Gender</th>
                    <th>BirthDay</th>
                </tr>
            </thead>
            <tbody><c:forEach var="dto" items="${requestScope.TEAM}" varStatus="counter">
                    <tr>
                        <td>${counter.count}</td>
                        <td>${dto.id}</td>
                        <td>${dto.fullname}</td>
                        <td>${dto.gender}</td>
                        <td>${dto.birthday}</td>
                    </tr>
                </c:forEach>

            </tbody>
        </table>


        <c:url var="searchLink" value="SearchControllerMissM">
            <c:param name="name">${param.name}</c:param>
            <c:param name="location">${param.location}</c:param>
            <c:param name="level">${param.level}</c:param>
            <c:param name="status">${param.status}</c:param>
        </c:url>
        <a href="${searchLink}">Search Again</a>

    </body>
</html>
