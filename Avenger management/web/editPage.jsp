<%-- 
    Document   : editPage
    Created on : Jul 15, 2018, 4:52:52 PM
    Author     : THANG NGUYEN
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Edit Information</title>
        <link href="css/user.css" rel="stylesheet" type="text/css"/>
    </head>

    <body><div class="infomation">
            <div class="header">
                <a href="./member/member.jsp" class="dashboard">
                    <img src="image/logo1.png" alt="" width="100"/></a> 
                <a href="/THANGNTSE62915/EditInformation" class="info">Hello ${sessionScope.INFO.fullname}</a> 

                <a href="./LogoutController" class="logout">Logout</a>
            </div>
            <div class="left">
                <form action="/THANGNTSE62915/UploadInfoImgController"method="POST" enctype="multipart/form-data">
                    <div class="upload">
                        <img src="${requestScope.DTO.image}" alt="Upload Image" width="240" height="300" />
                        <div class="upload_img">
                            <input type="hidden" value="${requestScope.DTO.username}"  name="txtUsername" />
                            <input type="file" name="img" accept=".jpg, .jpeg, .png" class="file">
                        </div>
                    </div>
                    <input type="submit" value="Upload" class="upload_buton" />
                </form>
                <font color="red">${requestScope.ERRIMG}</font>
            </div>
            <div class="right">

                <form action="/THANGNTSE62915/UpdateInfomation">
                    <input type="hidden" name="image" value="${requestScope.DTO.image}">
                    <table > <thead>
                            <tr>
                                <th colspan="2" style="font-size: 30px;
                                    ">Information</th>

                            </tr>
                        </thead>
                        <tbody>

                            </th>
                            <tr>
                                <td>Username:</td>
                                <td><input type="text" name="txtUsername" value="${requestScope.DTO.username}"  readonly/><font color="red">${requestScope.ERROBJ.errUsername}</font></br></td>
                            </tr>
                            <tr>
                                <td>Password:</td>
                                <td><input type="password" name="txtPassword" value="" /><font color="red">${requestScope.ERROBJ.errPassword}</font></br></td>
                            </tr>
                            <tr>
                                <td>Full name:</td>
                                <td> <input type="text" name="txtFullname" value="${requestScope.DTO.fullname}" /><font color="red">${requestScope.ERROBJ.errFullname}</font></br></td>
                            </tr>
                            <tr>
                                <td>Birthday: </td>
                                <td><input type="text" name="txtBirthday" value="${requestScope.DTO.birthday}" /><font color="red">${requestScope.ERROBJ.errBirthday}</font></br></td>
                            </tr>
                            <tr>
                                <td>Gender: </td>
                                <td><select name="txtGender">
                                        <option value="Male" ${requestScope.DTO.gender == 'Male'?'selected':''}>Male</option>
                                        <option value="Female" ${requestScope.DTO.gender == 'Female'?'selected':''}>Female</option>
                                        <option value="Other" ${requestScope.DTO.gender == 'Other'?'selected':''}> Other</option>
                                    </select></td>
                            </tr>
                            <tr>
                                <td>Address:</td>
                                <td> <input type="text" name="txtAddress" value="${requestScope.DTO.address}" /><font color="red">${requestScope.ERROBJ.errAddress}</font></br></td>
                            </tr>
                            <tr>
                                <td> Description: </td>
                                <td> <textarea name="txtDescription">${requestScope.DTO.description}</textarea><font color="red">${requestScope.ERROBJ.errDescription}</font></br></td>
                            </tr>
                            <tr>
                                <td colspan="2"><input type="Submit" name="action" value="Update" style=" width: 100px;
                height: 30px;"> </td>

                            </tr>
                        </tbody>
                    </table>
                </form>
            </div>
        </div>
    </body>
</html>
