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

import thang.daos.WeaponDAO;

/**
 *
 * @author THANG NGUYEN
 */
public class UploadImgWepController extends HttpServlet {

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
        boolean check = ServletFileUpload.isMultipartContent(request);
        Hashtable hash = new Hashtable();
        FileItem item = null;
        String filename = "";
        String url = "admin/ManagerWepUpdate.jsp";
        FileItem img = null;
        try {
            if (check == true) {
                List<FileItem> list = new ServletFileUpload(new DiskFileItemFactory()).parseRequest(request);
                Iterator it = list.iterator();
                while (it.hasNext()) {
                    item = (FileItem) it.next();
                    if (item.isFormField()) {
                        hash.put(item.getFieldName(), item.getString());
                    } else {
                        img = item;
                        String name = item.getName();
                        filename = name.substring(name.lastIndexOf("\\") + 1);
                    }
                }
            }
            String id = (String) hash.get("txtId");
            String searchValue = (String) hash.get("searchValue");
            String status = (String) hash.get("status");
            String realpath = "";
            url = "EditControllerWepM?searchValue=" + searchValue + "&status=" + status + "&id=" + id;
            if (!filename.contains(".jpg") && !filename.contains("jpeg") && !filename.contains("png")) {
                request.setAttribute("ERRIMG", "Image no valid.Choose  file.jpg/.png/.jpeg");
                
            } else {
                
                realpath = getServletContext().getRealPath("/") + "image\\weapon\\" + id + filename;
                File saveFile = new File(realpath);
                img.write(saveFile);
                WeaponDAO dao = new WeaponDAO();
                boolean result = dao.uploadImg(id, "image\\weapon\\" + id + filename);
                if (result == false) {
                    request.setAttribute("LINK", url);
                    url = "error.jsp";
                    
                }
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
