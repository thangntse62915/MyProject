/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thang.controller;

import java.io.IOException;

import java.util.List;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import thang.daos.MemberDAO;
import thang.dtos.ErrMemberObj;
import thang.dtos.MemberDTO;

/**
 *
 * @author THANG NGUYEN
 */
public class SearchControllerMemM extends HttpServlet {

    private static final String SEARCH = "admin/ManagerMemberSearch.jsp";

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
        String url = SEARCH;
        ErrMemberObj obj = new ErrMemberObj();
        try {
            String searchValue = request.getParameter("searchValue");
            String status = request.getParameter("status");
            boolean valid = true;
            if (searchValue.length() == 0) {
                valid = false;
                obj.setErrFullname("Input fullname to search!");
            }
            if (valid == false) {
                request.setAttribute("ERR", obj);
            } else {
                MemberDAO dao = new MemberDAO();
                List<MemberDTO> list = dao.searchMember(searchValue, status);
                HttpSession session = request.getSession();
                session.setAttribute("SEARCHV", searchValue);
                session.setAttribute("ST", status);
              
                session.setAttribute("LISTDTO", list);
                session.setAttribute("MAX", list.size());
                session.setAttribute("BEGIN", 0);
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
