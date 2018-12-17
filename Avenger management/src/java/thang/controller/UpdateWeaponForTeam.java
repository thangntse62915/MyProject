/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thang.controller;

import java.io.IOException;

import java.util.ArrayList;
import java.util.Hashtable;
import java.util.Iterator;
import java.util.List;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import thang.daos.MissionDAO;
import thang.dtos.MemberDTO;
import thang.dtos.MissionDTO;

/**
 *
 * @author THANG NGUYEN
 */
public class UpdateWeaponForTeam extends HttpServlet {

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
        String url = "error.jsp";
        try {
            HttpSession session = request.getSession();
            Hashtable<String, MemberDTO> hteam = (Hashtable<String, MemberDTO>) session.getAttribute("HTEAM");
            Iterator<MemberDTO> it = hteam.values().iterator();
            String idMiss = ((MissionDTO) session.getAttribute("DTO")).getId();
            MemberDTO dto = null;
            String idWeapon = null;
            List<String> listWep = new ArrayList<>();
            List<String> listMem = new ArrayList<>();
            while (it.hasNext()) {
                dto = it.next();
                idWeapon = request.getParameter(dto.getUsername());
                listWep.add(idWeapon);
                listMem.add(dto.getUsername());
                dto.setWeaponId(idWeapon);

            }
            MissionDAO dao = new MissionDAO();
            dao.insertTeamMisstion(hteam.values(), idMiss);
            dao.updateStatusMission(idMiss, "Send");
            dao.updateStatusMem(listMem);
            dao.updateStatusWep(listWep);
            MissionDTO miss = (MissionDTO) session.getAttribute("LASTSEARCH");
            url = "SearchControllerMissM?name=" + miss.getName() + "&location=" + miss.getLocal() + "&level=" + miss.getLevel() + "&status=" + miss.getStatus();
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
