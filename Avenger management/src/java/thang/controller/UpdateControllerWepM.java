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
import thang.daos.WeaponDAO;

import thang.dtos.ErrWeaponObj;
import thang.dtos.WeaponDTO;

/**
 *
 * @author THANG NGUYEN
 */
public class UpdateControllerWepM extends HttpServlet {

    public static final String ERR = "./admin/ManagerWeaponUpdate.jsp";
    public static final String SUCCESS = "./SearchControllerWepM";

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
        ErrWeaponObj obj = new ErrWeaponObj();
        try {
            boolean valid = true;
            String id = request.getParameter("txtId");
            String name = request.getParameter("txtName");
            String color = request.getParameter("txtColor");
            String power = request.getParameter("txtPower");
            String designer = request.getParameter("txtDesigner");
            String using = request.getParameter("txtIdMem");
            if (name.length() == 0) {
                obj.setErrname("Name is not blank");
                valid = false;
            }
            if (color.length() == 0) {
                obj.setErrcolor("color is not blank");
                valid = false;
            }
            if (power.length() == 0) {
                obj.setErrpower("power is not blank");
                valid = false;
            }
            if (designer.length() == 0) {
                obj.setErrdesigner("Designer is not blank");
                valid = false;
            }
            String img= request.getParameter("img");
            String searchValues = request.getParameter("searchValue");
            String status = request.getParameter("status");
            WeaponDTO dto = new WeaponDTO(id, name, using, power, designer, color,img);

            if (valid == false) {
                request.setAttribute("ERROBJ", obj);
                request.setAttribute("SEARCH", searchValues);
                request.setAttribute("STATUS", status);
                request.setAttribute("DTO", dto);
            } else {
                url = SUCCESS;
                WeaponDAO dao = new WeaponDAO();
                System.out.println(dao.updateWeapon(dto)); ;

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
