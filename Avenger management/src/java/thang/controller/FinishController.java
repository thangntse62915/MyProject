/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thang.controller;

import java.io.File;
import java.io.IOException;

import java.util.Hashtable;
import java.util.Iterator;
import java.util.List;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import org.apache.commons.fileupload.FileItem;
import org.apache.commons.fileupload.disk.DiskFileItemFactory;
import org.apache.commons.fileupload.servlet.ServletFileUpload;

import thang.daos.MissionDAO;

/**
 *
 * @author THANG NGUYEN
 */
public class FinishController extends HttpServlet {

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
        Hashtable hash = new Hashtable();
        FileItem img = null;
        String fileName = "";
        String realpath;
        String url = "LoadMissionController";
        try {
            boolean check = ServletFileUpload.isMultipartContent(request);
            if (check == true) {
                List<FileItem> list = new ServletFileUpload(new DiskFileItemFactory()).parseRequest(request);
                Iterator it = list.iterator();
                while (it.hasNext()) {
                    FileItem item = (FileItem) it.next();
                    if (item.isFormField()) {
                        hash.put(item.getFieldName(), item.getString());
                    } else {
                        img = item;
                        String name = img.getName();
                        fileName = name.substring(name.lastIndexOf("\\") + 1);

                    }
                }
            }
            String id = (String) hash.get("txtId");
            if (!fileName.contains(".rar")) {
                request.setAttribute("ERRFILE", "File not valid .please choos file.rar");

            } else {
                realpath = getServletContext().getRealPath("/") + "finish\\" + id + fileName;
                File saveFile = new File(realpath);
                System.out.println(img == null);
                img.write(saveFile);

                MissionDAO dao = new MissionDAO();

                dao.finishMember(id);
                dao.finishMission(id, "finish\\" + id + fileName);
                dao.finishWeapon(id);
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