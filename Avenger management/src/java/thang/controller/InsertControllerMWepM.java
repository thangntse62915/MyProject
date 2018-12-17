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
import thang.dtos.ErrWeaponObj;
import thang.dtos.WeaponDTO;

/**
 *
 * @author THANG NGUYEN
 */
public class InsertControllerMWepM extends HttpServlet {

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
        String url = "admin/ManagerWeaponInsert.jsp";
        ErrWeaponObj err = new ErrWeaponObj();
        WeaponDTO dto = null;
        try {
            System.out.println("rrr");
            boolean check = ServletFileUpload.isMultipartContent(request);
            if (check == true) {
                System.out.println("rrr");
                List<FileItem> list = new ServletFileUpload(new DiskFileItemFactory()).parseRequest(request);
                Iterator<FileItem> it = list.iterator();
                Hashtable hash = new Hashtable();
                FileItem item = null;
                FileItem image = null;
                while (it.hasNext()) {
                    item = it.next();
                    if (item.isFormField()) {
                        hash.put(item.getFieldName(), item.getString());
                    } else {
                        image = item;
                        String img = image.getName();

                        hash.put("image", img.substring(img.lastIndexOf("\\") + 1));
                    }
                }
                String txtId = (String) hash.get("txtId");
                String txtName = (String) hash.get("txtName");
                String txtColor = (String) hash.get("txtColor");
                String txtDesigner = (String) hash.get("txtDesigner");
                String txtPower = (String) hash.get("txtPower");
                System.out.println((String) hash.get("txtdate")+"--");
                String txtIdMem = (String) hash.get("txtIdMem");
                String txtImg = "image\\weapon\\" + txtId + (String) hash.get("image");
                dto = new WeaponDTO(txtId, txtName, txtIdMem, txtPower, txtDesigner, txtColor, txtImg);

                boolean valid = true;

                if (!txtId.matches("WE[0-9]{4}")) {
                    err.setErrid("ID must match WExxxx.x is a number");
                    valid = false;
                }
                if (txtName.length() == 0) {
                    err.setErrname("Name is not blank");
                    valid = false;
                }

                if (txtColor.length() == 0) {
                    err.setErrcolor("Color is not blank");
                    valid = false;
                }
                if (txtDesigner.length() == 0) {
                    err.setErrdesigner("Designer is not blank");
                    valid = false;
                }
                if (txtPower.length() == 0) {
                    err.setErrpower("Power is not blank");
                    valid = false;
                }
                if (!txtImg.matches(".+\\.(jpg|png|jpeg|)")) {
                    err.setErrimage("Image is not valid");
                    valid = false;
                } else if (image.getSize() / 1000000 >= 3) {
                    System.out.println(image.getSize());
                    err.setErrimage("Image have Size < 5M");
                    valid = false;
                }
                if (valid == false) {
                    request.setAttribute("DTO", dto);
                    request.setAttribute("ERR", err);
                } else {
                    WeaponDAO dao = new WeaponDAO();
                    dao.insertWeapon(dto);
                    image.write(new File(getServletContext().getRealPath("/") +"\\"+ txtImg));                                   
                }

            }

        } catch (Exception e) {
            log(e.getMessage());
            if (e.getMessage().contains("duplicate")) {
                err.setErrid("Id is exist");
                request.setAttribute("DTO", dto);
                request.setAttribute("ERR", err);
            }
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
