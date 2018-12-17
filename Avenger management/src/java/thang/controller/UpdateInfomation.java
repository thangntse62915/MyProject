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
public class UpdateInfomation extends HttpServlet {
public static final String SUCCESS = "/EditInformation";
public static final String ERR = "/editPage.jsp";
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
        String url = ERR;
        ErrMemberObj obj = new ErrMemberObj();
        try {
            boolean valid = true;
            String txtUsername = request.getParameter("txtUsername");
            String txtPassword = request.getParameter("txtPassword");
            if ((txtPassword.length() > 0 && txtPassword.length() < 6) || txtPassword.length() > 15) {
                obj.setErrPassword("Password have length [6-15]");
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

            String image = request.getParameter("image");
            MemberDTO dto = new MemberDTO(null, txtUsername, txtPassword, txtFullname, txtBirthday, txtGender, txtAddress, txtDescription, image);
            if (valid == false) {
                request.setAttribute("ERROBJ", obj);
                request.setAttribute("DTO", dto);
            } else {
                url = SUCCESS;
                MemberDAO dao = new MemberDAO();
                dao.updateInformationMember(dto);

            }
        } catch (Exception e) {
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