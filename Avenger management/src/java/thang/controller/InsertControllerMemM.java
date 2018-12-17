/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thang.controller;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import thang.daos.MemberDAO;
import thang.dtos.ErrMemberObj;
import thang.dtos.MemberDTO;
import thang.tool.Validation;

/**
 *
 * @author THANG NGUYEN
 */
public class InsertControllerMemM extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        String url = "admin/ManagerMemberInsert.jsp";

        ErrMemberObj obj = new ErrMemberObj();
        String txtId = "", txtUsername = "";
        MemberDTO dto = new MemberDTO();
        try {
            boolean valid = true;
            txtId = request.getParameter("txtId");
            if (!txtId.matches("AV[0-9]{4}")) {
                obj.setErrId("Id must match AVxxxx. x is a number [0-9]");
                valid = false;
            }
            txtUsername = request.getParameter("txtUsername");
            if (!txtUsername.matches("[0-9a-zA-Z]+") && txtUsername.length() < 6) {
                obj.setErrUsername("Username have only number or character[a-z] and length >=6");
                valid = false;
            }
            String txtPassword = request.getParameter("txtPassword");
            if (txtPassword.length() < 6 || txtPassword.length() > 15) {
                obj.setErrPassword("Password have length [6-15]");
                valid = false;
            }
            String txtConPassword = request.getParameter("txtConPassword");
            if (!txtConPassword.equals(txtPassword)) {
                obj.setErrConPassword("Confirm Password is not match.");
                valid = false;
            }
            String txtFullname = request.getParameter("txtFullname");
            if (txtFullname.length() == 0) {
                obj.setErrFullname("Fullname is not blank");
                valid = false;
            }
            String txtBirthday = request.getParameter("txtBirthday");
            if (new Validation().checkDate(txtBirthday) == false) {
                obj.setErrBirthday("Birthday not valid");
                valid = false;
            }
            String txtGender = request.getParameter("txtGender");
            String txtAddress = request.getParameter("txtAddress");
            if (txtAddress.length() == 0) {
                obj.setErrAddress("Address is not blank");
                valid = false;
            }
            String txtDescription = request.getParameter("txtDescription");
            if (txtDescription.length() == 0) {
                obj.setErrDescription("Description is not blank");
                valid = false;
            }
            dto = new MemberDTO(txtId, txtUsername, txtPassword, txtFullname, txtBirthday, txtGender, txtAddress, txtDescription);
            System.out.println(dto.toString());
            String admin = ((MemberDTO) request.getSession().getAttribute("INFO")).getUsername();
            if (valid == false) {
                request.setAttribute("ERROBJ", obj);
                request.setAttribute("DTO", dto);
            } else {
                MemberDAO dao = new MemberDAO();
                dao.insertMember(dto, admin);
                dao.insertRole(dto);
                request.setAttribute("SUCESS", "Add success full");
            }

        } catch (Exception e) {
            String err = e.getMessage();
            if (err.contains("duplicate")) {
                if (err.contains(txtId)) {
                    obj.setErrId("Id is exist");
                } else {
                    obj.setErrUsername("Username is exist");
                }
                request.setAttribute("ERROBJ", obj);
                request.setAttribute("DTO", dto);
            }
            log(e.getMessage());
        } finally {
            request.getRequestDispatcher(url).forward(request, response);
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
