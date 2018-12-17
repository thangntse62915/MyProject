<%-- 
    Document   : ManagerMemberUpdate
    Created on : Jul 3, 2018, 10:07:43 AM
    Author     : THANG NGUYEN
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link href="../css/newcss.css" rel="stylesheet" type="text/css"/>
        <title>Update Member</title>
        <style>
            .upload_img .file{
                width: 120px;
                height: 150px;
                opacity: 0;
                position: absolute;


            }
            .upload{
                width: 120px;
                height: 170px;
                position: relative;


            }
            .upload img{
                position: absolute;
                text-align: center;
                line-height: 150px;

            }
        </style>
    </head>
    <body>
         <a href="/THANGNTSE62915/admin/admin.jsp"><h1>Hello ${sessionScope.INFO.fullname}</h1></a>
        <a href="/THANGNTSE62915/admin/ManagerMemberSearch.jsp">Member</a>
        <a href="/THANGNTSE62915/admin/ManagerMissionInsert.jsp">Mission</a>
        <a href="/THANGNTSE62915/MainControllerWepM?action=LoadInsertPage">Weapon</a></br>
        <a href="/THANGNTSE62915/admin/ManagerMemberSearch.jsp">Search Member</a>
        <a href="/THANGNTSE62915/admin/ManagerMemberInsert.jsp">Insert Member</a>
        <h1>Update Member</h1>
        <form action="MainControllerMemM">
            ID: <input type="text" value="${requestScope.DTO.id}" readonly name="txtId" /></br>
            Username: <input type="text" name="txtUsername" value="${requestScope.DTO.username}" readonly /></br>
            Password: <input type="password" name="txtPassword" /><font color="red">${requestScope.ERROBJ.errPassword}</font></br>
            Full name: <input type="text" name="txtFullname" value="${requestScope.DTO.fullname}" /><font color="red">${requestScope.ERROBJ.errFullname}</font></br>
            Birthday: <input type="text" name="txtBirthday" value="${requestScope.DTO.birthday}" /><font color="red">${requestScope.ERROBJ.errBirthday}</font></br>
            Gender: <select name="txtGender">
                <option value="Male" ${requestScope.DTO.gender == 'Male'?'selected':''}>Male</option>
                <option value="Female" ${requestScope.DTO.gender == 'Female'?'selected':''}>Female</option>
                <option value="Other" ${requestScope.DTO.gender == 'Other'?'selected':''}> Other</option>
            </select></br>
            Address: <input type="text" name="txtAddress" value="${requestScope.DTO.address}" /><font color="red">${requestScope.ERROBJ.errAddress}</font></br>
            Description: <textarea name="txtDescription">${requestScope.DTO.description}</textarea><font color="red">${requestScope.ERROBJ.errDescription}</font></br>
            Enroll date: <input type="text" name="txtEnroll" value="${requestScope.DTO.enrolldate}" readonly></br>
            Cancel date: <input type="text" name="txtCancel" value="${requestScope.DTO.unenrolldate}" readonly/></br>
            <input type="hidden" name="searchValue" value="${requestScope.SEARCH}" />
            <input type="hidden" name="status" value="${requestScope.STATUS}" />
            <input type="hidden" name="image" value="${requestScope.DTO.image}" />
            <input type="Submit" name="action" value="Update">  

        </form>
        <form action="/THANGNTSE62915/UploadImgController"method="POST" enctype="multipart/form-data">
            <div class="upload">
                <img src="${requestScope.DTO.image}" alt="Upload Image" width="120" height="150" style="line-height: 150px;"/>
                <div class="upload_img">
                    <input type="hidden" value="${requestScope.DTO.id}"  name="txtId" />
                    <input type="file" name="img" accept=".jpg, .jpeg, .png" class="file">
                    <input type="hidden" name="searchValue" value="${requestScope.SEARCH}" />
                    <input type="hidden" name="status" value="${requestScope.STATUS}" />
                </div>
            </div><input type="submit" value="Upload" /></form>
        <font color="red">${requestScope.ERRIMG}</font>
    </body>
</html>
