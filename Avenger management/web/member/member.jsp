<%-- 
    Document   : member
    Created on : Jul 2, 2018, 2:48:20 PM
    Author     : THANG NGUYEN
--%>

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>DashBoard</title>
    </head>
    <body>

        <a href="/THANGNTSE62915/EditInformation"><h1>Hello ${sessionScope.INFO.fullname}</h1></a> 
        <a href="/THANGNTSE62915/member/member.jsp">Dashboard</a> 
        <a  href="/THANGNTSE62915/LogoutController">Logout</a>
        <c:if test="${requestScope.TEAMMISSION!= null}">
            <c:if test="${not empty requestScope.TEAMMISSION}"> <h1>Your Mission</h1>
                <form action="/THANGNTSE62915/InsertControllerMissM">
                    ID: <input type="text" value="${requestScope.MISSION.id}" name="txtId" readonly=""/></br>
                    Name <input type="text" name="txtName" value="${requestScope.MISSION.name}" readonly/></br>
                    Location: <input type="text" name="txtLocal" value="${requestScope.MISSION.local}"readonly /></br>
                    Level: <input type="text" name="txtLocal" value="${requestScope.MISSION.level}" readonly/></br>
                    Start date <input type="date" name="begin" value="${requestScope.MISSION.startDate}"readonly></br>
                    End Date<input type="date" name="end" value="${requestScope.MISSION.endDate}" readonly/></br>
                    <a href=".${requestScope.MISSION.description}" download="">Information of mission</a>
                </form>
                <table border="1">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Fullname</th>
                            <th>Gender</th>
                            <th>Address</th>
                            <th>Leader</th>
                        </tr>
                    </thead>
                    <tbody>
                        <c:forEach var="dto" items="${requestScope.TEAMMISSION}">
                            <tr>
                                <td>${dto.id}</td>
                                <td>${dto.fullname}</td>
                                <td>${dto.gender}</td>
                                <td>${dto.address}</td>
                                <td>${dto.username == requestScope.LEADER?'O':'' }</td>
                            </tr>
                        </c:forEach>
                    </tbody>
                </table>
                <c:if test="${sessionScope.INFO.username == requestScope.LEADER}">
                    <c:if test="${requestScope.MISSION.status == 'Send'}">
                        <form action="ReceiveController">
                            <input type="hidden" value="${requestScope.MISSION.id}" name="id">
                            <input type="submit" value="Recieve" name="action">
                        </form>
                    </c:if>
                    <c:if test="${requestScope.MISSION.status == 'Receive'}">

                        <form action="FinishController" method="POST" enctype="multipart/form-data">
                            <input type="hidden" value="${requestScope.MISSION.id}" name="txtId">
                            <input type="file" name="file" accept=".rar"/>
                            <input type="submit" value="Finish" name="action">
                        </form>

                    </c:if>
                </c:if>
            </c:if>

        </c:if>
        <c:if test="${empty requestScope.TEAMMISSION}">No have Mission</c:if>
    </body>
</html>
