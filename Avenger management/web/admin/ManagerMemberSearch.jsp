<%-- 
    Document   : ManagerMemberSearch
    Created on : Jul 2, 2018, 2:58:23 PM
    Author     : THANG NGUYEN
--%>

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib  prefix="fn" uri="http://java.sun.com/jsp/jstl/functions" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Search Member</title>
    </head>
    <body> <a href="/THANGNTSE62915/admin/admin.jsp"><h1>Hello ${sessionScope.INFO.fullname}</h1></a>
        <a href="/THANGNTSE62915/admin/ManagerMemberSearch.jsp">Member</a>
        <a href="/THANGNTSE62915/admin/ManagerMissionInsert.jsp">Mission</a>
        <a href="/THANGNTSE62915/MainControllerWepM?action=LoadInsertPage">Weapon</a>
        </br>
        <a href="/THANGNTSE62915/admin/ManagerMemberSearch.jsp">Search Member</a>
        <a href="/THANGNTSE62915/admin/ManagerMemberInsert.jsp">Insert Member</a>
        <h1>Search Member</h1>
        <form action="/THANGNTSE62915/MainControllerMemM">
            Fullname : <input type="text" name="searchValue" />
            <font color="red">${requestScope.ERR.errFullname}</font>
            Status : <select name="status">
                <option value="All">All</option>
                <option value="Ready">Ready</option>
                <option value="Action">Fight</option>
                <option value="Cancel">Cancel</option>
            </select>
            <input type="hidden" name="idAdmin" value="${sessionScope.INFO.id}"/>
            <input type="submit" value="Search" name="action" />
        </form>
        <form action="/THANGNTSE62915/BackController">     
            <input type="hidden" value="${param.searchValue}" name="searchValue">
            <input type="hidden" value="${param.status}" name="status">     
            <input type="submit" name="action" value="<<" ${sessionScope.BEGIN == 0?'disabled':''}/>
        </form>
        ${sessionScope.BEGIN +1 }-${sessionScope.BEGIN+5 > sessionScope.MAX?sessionScope.MAX:sessionScope.BEGIN+5}/${sessionScope.MAX}


        <form action="/THANGNTSE62915/NextController">           
            <input type="hidden" value="${param.searchValue}" name="searchValue">
            <input type="hidden" value="${param.status}" name="status">
            <input type="submit" name="action" value=">>" ${sessionScope.BEGIN > (sessionScope.MAX-6)?'disabled':''}/>
        </form>
        <table border="1">
            <thead>
                <tr><th>#</th>
                    <th>ID</th>
                    <th>Full name</th>
                    <th>Birthday</th>
                    <th>Gender</th>
                    <th>Address</th>
                    <th>Status</th>
                    <th>Delete</th>
                    <th>Edit</th>
                </tr>
            </thead>
            <tbody>
                <c:if test="${sessionScope.LISTDTO != null}">
                    <c:forEach var="dto" items="${sessionScope.LISTDTO}" varStatus="counter" begin="${sessionScope.BEGIN}" end="${sessionScope.BEGIN+4}">
                        <tr><td>${counter.count}</td>
                            <td>${dto.id}</td>
                            <td>${dto.fullname}</td>
                            <td>${dto.birthday}</td>
                            <td>${dto.gender}</td>
                            <td>${dto.address}</td>
                            <td>${dto.status}</td>
                            <td><c:if test="${dto.status == 'Ready'}">
                                    <c:url value="/MainControllerMemM" var="delLink">
                                        <c:param name="searchValue">${sessionScope.SEARCHV}</c:param>
                                        <c:param name="status">${sessionScope.ST}</c:param>
                                        <c:param name="id">${dto.id}</c:param>
                                        <c:param name="action">Delete</c:param>
                                    </c:url>
                                    <a href="${pageScope.delLink}">Delete</a>

                                </c:if>
                                <c:if test="${dto.status == 'Cancel'}">
                                    <c:url value="/MainControllerMemM" var="activeLink">
                                        <c:param name="searchValue">${sessionScope.SEARCHV}</c:param>
                                        <c:param name="status">${sessionScope.ST}</c:param>
                                        <c:param name="id">${dto.id}</c:param>
                                        <c:param name="action">Active</c:param>
                                    </c:url>
                                    <a href="${pageScope.activeLink}">Active</a>

                                </c:if>
                            </td>
                            <td><c:url value="/MainControllerMemM" var="editLink">
                                    <c:param name="searchValue">${sessionScope.SEARCHV}</c:param>
                                    <c:param name="status">${sessionScope.ST}</c:param>
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
        <c:if test="${ requestScope.LISTDTO != null and empty requestScope.LISTDTO}">
            No record
        </c:if>
    </body>
</html>
