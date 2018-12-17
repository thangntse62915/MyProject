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
import thang.dtos.MemberDTO;

/**
 *
 * @author THANG NGUYEN
 */
public class MainControllerWepM extends HttpServlet {

    private static final String ERROR = "error.jsp";
    private static final String SEARCH = "SearchControllerWepM";
    private static final String DELETE = "DeleteControllerWepM";
    private static final String ACTIVE = "ActiveControllerWepM";
    private static final String EDIT = "EditControllerWepM";
    private static final String UPDATE = "UpdateControllerWepM";
    private static final String INSERT = "InsertControllerWepM";
    private static final String LOADINSERT = "admin/ManagerWeaponInsert.jsp";

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
        String url = ERROR;
        try {
            String action = request.getParameter("action");
            MemberDAO dao = new MemberDAO();
            List<MemberDTO> list = dao.getAllMemberCanUseWeapon();
            HttpSession session = request.getSession();
            session.setAttribute("LIST", list);
            if (action.equals("Search")) {
                url = SEARCH;

            } else if (action.equals("Delete")) {
                url = DELETE;
            } else if (action.equals("Active")) {
                url = ACTIVE;
            } else if (action.equals("Edit")) {
                url = EDIT;
            } else if (action.equals("Update")) {
                url = UPDATE;
            } else if (action.equals("Insert")) {
                url = INSERT;
            } else if (action.equals("LoadInsertPage")) {
                url = LOADINSERT;

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
