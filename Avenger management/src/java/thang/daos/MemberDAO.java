/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thang.daos;

import java.sql.Connection;
import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;
import thang.conn.MyConnection;
import thang.dtos.MemberDTO;


/**
 *
 * @author THANG NGUYEN
 */
public class MemberDAO {

    private Connection con;
    private PreparedStatement pStm;
    private ResultSet rs;

    public MemberDAO() {
    }

    private void closeConnection() throws Exception {
        if (rs != null) {
            rs.close();
        }
        if (pStm != null) {
            pStm.close();
        }
        if (con != null) {
            con.close();
        }
    }

    public String checkLogin(String username, String password, String role) throws Exception {
        MemberDTO result = new MemberDTO();
        String fullname = "failed";
        try {
            String sql = "select fullname from Registration where username = ? and password = ? and role   = ? and username not in (select username from Member where username = ? and status = ?)";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, username);
            pStm.setString(2, password);
            pStm.setString(3, role);
            pStm.setString(4, username);
            pStm.setString(5, "Delete");
            rs = pStm.executeQuery();
            if (rs.next()) {
                fullname = rs.getString("fullname");
            }

        } finally {
            closeConnection();
        }
        return fullname;
    }

    public List<MemberDTO> searchMember(String sFullname, String sStatus) throws Exception {
        List<MemberDTO> result = new ArrayList<>();
        try {
            System.out.println(sFullname + sStatus);
            String sql = "select Id, Fullname, birthday,gender,address,status from Member where fullname like ? and status like ? and username not in (select username from Registration where role = ?)";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, "%" + sFullname + "%");
            if (sStatus.equals("All")) {
                pStm.setString(2, "%");
            } else {
                pStm.setString(2, sStatus);
            }
            pStm.setString(3, "Admin");
            rs = pStm.executeQuery();
            MemberDTO dto = null;
            String id = null;
            String fullname = null;
            String birthday = null;
            String gender = null;
            String address = null;
            String status = null;
            while (rs.next()) {
                id = rs.getString("id");
                fullname = rs.getString("fullname");
                birthday = rs.getString("birthday");
                gender = rs.getString("gender");
                address = rs.getString("address");
                status = rs.getString("status");
                dto = new MemberDTO(id, fullname, birthday, gender, address, status);
                result.add(dto);
            }
        } finally {
            closeConnection();
        }
        return result;
    }

    public boolean deleteMember(String id, String idAdmin) throws Exception {
        boolean check = false;
        try {
            con = MyConnection.getConnection();
            String sql = "update Member set status = ? , idAction = ? , unenrolldate = ? where id = ?";
            pStm = con.prepareStatement(sql);
            pStm.setString(1, "Cancel");
            pStm.setString(2, idAdmin);
            pStm.setDate(3, new Date(new java.util.Date().getTime()));
            pStm.setString(4, id);
            check = pStm.executeUpdate() > 0;

        } finally {
            closeConnection();
        }
        return check;
    }

    public boolean activeMember(String id, String idAdmin) throws Exception {
        boolean check = false;
        try {
            con = MyConnection.getConnection();
            String sql = "update Member set status = ? , idAction = ? where id = ?";
            pStm = con.prepareStatement(sql);
            pStm.setString(1, "Ready");
            pStm.setString(2, idAdmin);

            pStm.setString(3, id);
            check = pStm.executeUpdate() > 0;

        } finally {
            closeConnection();
        }
        return check;
    }

    public MemberDTO getMember(String id) throws Exception {
        MemberDTO dto = new MemberDTO();
        try {
            String sql = "Select Fullname, Birthday, Gender, Address, Description, EnrollDate, UnenrollDate,image from Member where id  = ?";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, id);
            rs = pStm.executeQuery();
            if (rs.next()) {
                dto.setId(id);
                dto.setFullname(rs.getString("Fullname"));
                dto.setBirthday(rs.getString("Birthday"));
                dto.setGender(rs.getString("Gender"));
                dto.setAddress(rs.getString("Address"));
                dto.setDescription(rs.getString("Description"));
                dto.setEnrolldate(rs.getDate("EnrollDate"));
                dto.setUnenrolldate(rs.getDate("UnEnrollDate"));
                dto.setImage(rs.getString("image"));
            }
            sql = "select username ,password from Registration where id  = ?";
            pStm = con.prepareStatement(sql);
            pStm.setString(1, id);
            rs = pStm.executeQuery();
            if (rs.next()) {
                dto.setUsername(rs.getString("Username"));
                dto.setPassword(rs.getString("Password"));
            }
        } finally {
            closeConnection();
        }
        return dto;
    }

    public boolean updateMember(MemberDTO dto) throws Exception {
        boolean result1 = false;
        boolean result2 = false;
        try {
            boolean check = dto.getPassword().length() == 0;
            String updatePass = "";
            if (!check) {
                updatePass = ",password = ?";
            }
            String sql = "update Member set Fullname = ?,Birthday = ?,Gender = ?,Description = ?,address = ?" + updatePass + " where id = ?";
            System.out.println(sql);
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, dto.getFullname());
            pStm.setString(2, dto.getBirthday());
            pStm.setString(3, dto.getGender());
            pStm.setString(4, dto.getDescription());
            pStm.setString(5, dto.getAddress());
            if (check) {
                pStm.setString(6, dto.getId());
            } else {
                pStm.setString(6, dto.getPassword());
                pStm.setString(7, dto.getId());
            }

            result1 = pStm.executeUpdate() > 0;
            sql = "update Registration set Fullname = ? " + updatePass + " where id = ?";
            pStm = con.prepareStatement(sql);
            pStm.setString(1, dto.getFullname());
            if (check) {
                pStm.setString(2, dto.getId());
            } else {
                pStm.setString(2, dto.getPassword());
                pStm.setString(3, dto.getId());
            }
            result2 = pStm.executeUpdate() > 0;

        } finally {
            closeConnection();
        }
        return (result1 == true) && (result2 == true);
    }

    public boolean uploadImg(String id, String filename) throws Exception {
        boolean result = false;
        try {
            String sql = "update Member set image = ? where id = ?";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, filename);
            pStm.setString(2, id);

            result = pStm.executeUpdate() > 0;
        } finally {
            closeConnection();
        }
        return result;
    }
    
    public boolean uploadImgByUsername(String username, String filename) throws Exception {
        boolean result = false;
        try {
            String sql = "update Member set image = ? where username = ?";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, filename);
            pStm.setString(2, username);

            result = pStm.executeUpdate() > 0;
        } finally {
            closeConnection();
        }
        return result;
    }


    public List<MemberDTO> getAllMemberCanUseWeapon() throws Exception {
        List<MemberDTO> list = new ArrayList<>();
        MemberDTO dto = null;
        try {
            String sql = "select username ,fullname from Member where status != ? and id  in (select id from registration where role = ?) ";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, "Cancel");
            pStm.setString(2, "Member");
            rs = pStm.executeQuery();
            while (rs.next()) {
                dto = new MemberDTO();
                dto.setUsername(rs.getString("username"));
                dto.setFullname(rs.getString("fullname"));
                list.add(dto);
            }
        } finally {
            closeConnection();
        }
        return list;
    }

    public boolean insertMember(MemberDTO dto, String admin) throws Exception {
        boolean result = true;
        try {
            String sql = "insert into Member(id, username  ,password,fullname,birthday,gender,address,description,enrolldate,status,idAction) values (?,?,?,?,?,?,?,?,?,?,?)";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, dto.getId());
            pStm.setString(2, dto.getUsername());
            pStm.setString(3, dto.getPassword());
            pStm.setString(4, dto.getFullname());
            pStm.setString(5, dto.getBirthday());
            pStm.setString(6, dto.getGender());
            pStm.setString(7, dto.getAddress());
            pStm.setString(8, dto.getDescription());
            pStm.setDate(9, new java.sql.Date(new java.util.Date().getTime()));
            pStm.setString(10, "Ready");
            pStm.setString(11, admin);
            result = pStm.executeUpdate() > 0;
        } finally {
            closeConnection();
        }
        return result;
    }

    public boolean insertRole(MemberDTO dto) throws Exception {
        boolean result = true;
        try {
            System.out.println("=--");
            String sql = "insert into Registration(id, username ,password,fullname,role) values (?,?,?,?,?)";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, dto.getId());
            pStm.setString(2, dto.getUsername());
            pStm.setString(3, dto.getPassword());
            pStm.setString(4, dto.getFullname());
            pStm.setString(5, "Member");

            result = pStm.executeUpdate() > 0;
            System.out.println("=+--");
            System.out.println(result);
        } finally {
            closeConnection();
        }
        return result;
    }

    public List<MemberDTO> getAllMemberCanAddMission() throws Exception {
        List<MemberDTO> list = new ArrayList<>();
        MemberDTO dto = null;
        try {
            String sql = "select username ,fullname from Member where status = ? ";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, "Ready");
            rs = pStm.executeQuery();
            while (rs.next()) {
                dto = new MemberDTO();
                dto.setUsername(rs.getString("username"));
                dto.setFullname(rs.getString("fullname"));
                list.add(dto);
            }
        } finally {
            closeConnection();
        }
        return list;
    }

    public MemberDTO getMemberByUsername(String username) throws Exception {
        MemberDTO dto = new MemberDTO();
        try {
            String sql = "Select username ,password , Fullname, Birthday, Gender, Address, Description,image from Member where username  = ?";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, username);
            rs = pStm.executeQuery();
            if (rs.next()) {
                dto.setUsername(rs.getString("Username"));
                dto.setPassword(rs.getString("Password"));
                dto.setFullname(rs.getString("Fullname"));
                dto.setBirthday(rs.getString("Birthday"));
                dto.setGender(rs.getString("Gender"));
                dto.setAddress(rs.getString("Address"));
                dto.setDescription(rs.getString("Description"));
                dto.setImage(rs.getString("image"));
            }
            System.out.println(dto.toString());
        } finally {
            closeConnection();
        }
        return dto;
    }

    public boolean updateInformationMember(MemberDTO dto) throws Exception {
        boolean result1 = false;
        boolean result2 = false;
        try {
            boolean check = dto.getPassword().length() == 0;
            String updatePass = "";
            if (!check) {
                updatePass = ",password = ?";
            }
            String sql = "update Member set Fullname = ?,Birthday = ?,Gender = ?,Description = ?,address = ?" + updatePass + " where username = ?";
            System.out.println(sql);
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, dto.getFullname());
            pStm.setString(2, dto.getBirthday());
            pStm.setString(3, dto.getGender());
            pStm.setString(4, dto.getDescription());
            pStm.setString(5, dto.getAddress());
            if (check) {
                pStm.setString(6, dto.getUsername());
            } else {
                pStm.setString(6, dto.getPassword());
                pStm.setString(7, dto.getUsername());
            }

            result1 = pStm.executeUpdate() > 0;
            sql = "update Registration set Fullname = ? " + updatePass + " where username= ?";
            pStm = con.prepareStatement(sql);
            pStm.setString(1, dto.getFullname());
            if (check) {
                pStm.setString(2, dto.getUsername());
            } else {
                pStm.setString(2, dto.getPassword());
                pStm.setString(3, dto.getUsername());
            }
            result2 = pStm.executeUpdate() > 0;

        } finally {
            closeConnection();
        }
        return (result1 == true) && (result2 == true);
    
    }

}
