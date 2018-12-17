/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thang.controller;

import java.io.File;
import java.io.IOException;

import java.text.SimpleDateFormat;
import java.util.Hashtable;
import java.util.Iterator;
import java.util.List;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import org.apache.commons.fileupload.FileItem;
import org.apache.commons.fileupload.disk.DiskFileItemFactory;
import org.apache.commons.fileupload.servlet.ServletFileUpload;
import thang.daos.MemberDAO;
import thang.daos.MissionDAO;
import thang.dtos.ErrMissionObj;
import thang.dtos.MemberDTO;
import thang.dtos.MissionDTO;

/**
 *
 * @author THANG NGUYEN
 */
public class UpdateControllerMissM extends HttpServlet {

    public static final String INSERT = "admin/ManagerMissionUpdate.jsp";
    public static final String ADDTEAM = "admin/ManagerTeamMissionUpdate.jsp";

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
        String url = INSERT;
        ErrMissionObj err = new ErrMissionObj();
        try {
            String filename = "";
            boolean check = ServletFileUpload.isMultipartContent(request);
            if (check == true) {
                List<FileItem> list = new ServletFileUpload(new DiskFileItemFactory()).parseRequest(request);
                Hashtable hash = new Hashtable();
                FileItem file = null;
                FileItem fileInput = null;
                Iterator<FileItem> it = list.iterator();
                while (it.hasNext()) {
                    file = it.next();
                    if (file.isFormField()) {
                        hash.put(file.getFieldName(), file.getString());
                    } else {
                        fileInput = file;
                        String link = file.getName();
                        filename = link.substring(link.lastIndexOf("\\") + 1);
                        hash.put("txtFile", filename);
                    }
                }
                String txtId = (String) hash.get("txtId");
                String txtName = (String) hash.get("txtName");
                String txtLocal = (String) hash.get("txtLocal");
                String txtLevel = (String) hash.get("txtLevel");
                String begin = (String) hash.get("begin");
                String end = (String) hash.get("end");
             

                String txtFile = (String) hash.get("txtFile");
                String action = (String) hash.get("action");
                HttpSession session = request.getSession();

                String idAdmin = ((MemberDTO) session.getAttribute("INFO")).getId();
                MissionDTO dto = new MissionDTO(txtId, txtName, txtLocal, txtLevel, begin, end, "\\image\\mission\\" + txtId + ".rar", "Create", idAdmin);

                boolean valid = true;
                if (!txtId.matches("MS[0-9]{4}")) {
                    err.setErrid("ID must match MSxxxx");
                    valid = false;
                }
                if (txtName.length() == 0) {
                    err.setErrname("Name is not blank");
                    valid = false;
                }

                if (txtLocal.length() == 0) {
                    err.setErrlocal("Local is not blank");
                    valid = false;
                }
                SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
                if (begin.length() == 0) {
                    err.setErrstartDate("Date is not blank");
                }
                if (end.length() == 0) {
                    err.setErrendDate("Date is not blank");
                }
                if (begin.length() != 0 && end.length() != 0) {
                    if (sdf.parse(begin).before(sdf.parse(end)) == false && !begin.equals(end)) {
                        err.setErrendDate("Date is not valid");
                        valid = false;
                    }
                }
                if (!txtFile.contains(".rar")) {
                    err.setErrdescription("This file not valid. ");
                    valid = false;

                }
                   String name = (String) hash.get("name");
                String location = (String) hash.get("location");
                String level = (String) hash.get("level");
                String status = (String) hash.get("status");
                MissionDTO miss = new MissionDTO(name, location, level, status);
                if (valid == false) {
                    request.setAttribute("DTO", dto);
                    request.setAttribute("ERR", err);
                    request.setAttribute("MISS", miss);
                } else {
                    MissionDAO dao = new MissionDAO();
                    dao.updateMission(dto);
                    fileInput.write(new File(getServletContext().getRealPath("\\") + "\\image\\mission\\" + txtId + ".rar"));
                    url = ADDTEAM;
                    request.getSession().setAttribute("DTO", dto);
                    MemberDAO memdao = new MemberDAO();
                    List<MemberDTO> listMem = memdao.getAllMemberCanAddMission();
                    request.getSession().setAttribute("LIST", listMem);
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
