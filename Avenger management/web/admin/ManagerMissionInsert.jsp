<%-- 
    Document   : ManagerMissionInsert
    Created on : Jul 11, 2018, 8:31:57 AM
    Author     : THANG NGUYEN
--%>

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
        <h1>Create Mission</h1>
        <form action="/THANGNTSE62915/InsertControllerMissM"  enctype="multipart/form-data" method="POST">
            ID: <input type="text" value="${requestScope.DTO.id}" name="txtId"/><font color="red">${requestScope.ERR.errid}</font></br>
            Name <input type="text" name="txtName" value="${requestScope.DTO.name}" /><font color="red">${requestScope.ERR.errname}</font></br>
            Location: <input type="text" name="txtLocal" value="${requestScope.DTO.local}" /><font color="red">${requestScope.ERR.errlocal}</font></br>
            Level <select name="txtLevel" style="width: 80px">
                <option value="SSS">SSS</option>
                <option value="SS">SS</option>
                <option value="S">S</option>
                <option value="A">A</option>
                <option value="B">B</option>            
            </select></br>
            Start date <input type="date" name="begin" value="${requestScope.DTO.startDate}" ><font color="red">${requestScope.ERR.errstartDate}</font></br>
            End Date<input type="date" name="end" value="${requestScope.DTO.endDate}" /><font color="red">${requestScope.ERR.errendDate}</font></br>
            Description and image: <input type="file" name="file" value="" accept=".rar" /><font color="red">${requestScope.ERR.errdescription}</font></br>
            <input type="Submit" name="action" value="Create & Add Team">  
        </form>
    </body>
</html>
