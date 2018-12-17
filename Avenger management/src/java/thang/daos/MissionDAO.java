/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thang.daos;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Collection;
import java.util.Iterator;
import java.util.List;

import thang.conn.MyConnection;
import thang.dtos.MemberDTO;
import thang.dtos.MissionDTO;

/**
 *
 * @author THANG NGUYEN
 */
public class MissionDAO {

    private Connection con;
    private PreparedStatement pStm;
    private ResultSet rs;

    public MissionDAO() {
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

    public boolean insertMisstion(MissionDTO dto) throws Exception {
        boolean result = true;
        try {
            String sql = "insert into Mission(id, name, location, startDate, endDate, [level],description,idAdmin,status) values(?,?,?,?,?,?,?,?,?)";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, dto.getId());
            pStm.setString(2, dto.getName());
            pStm.setString(3, dto.getLocal());
            pStm.setString(4, dto.getStartDate());
            pStm.setString(5, dto.getEndDate());
            pStm.setString(6, dto.getLevel());
            pStm.setString(7, dto.getDescription());
            pStm.setString(8, dto.getIdAdmin());
            pStm.setString(9, dto.getStatus());
            result = pStm.executeUpdate() > 0;
        } finally {
            closeConnection();
        }
        return result;
    }

    public boolean updateMission(MissionDTO dto) throws Exception {
        boolean check = false;
        try {
            String sql = "Update Mission set name = ? , location = ?, level = ? , startDate = ?,endDate = ? where id = ?";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, dto.getName());
            pStm.setString(2, dto.getLocal());
            pStm.setString(3, dto.getLevel());
            pStm.setString(4, dto.getStartDate());
            pStm.setString(5, dto.getEndDate());
            pStm.setString(6, dto.getId());
            check = pStm.executeUpdate() > 0;

        } finally {
            closeConnection();
        }
        return check;
    }

    public boolean insertTeamMisstion(Collection<MemberDTO> setMem, String idMiss) throws Exception {
        boolean result = false;
        try {
            MemberDTO dto = null;
            String sql = "insert into MissionDetail(id,idMis,idMem,isLeader,idWeapon) values (?,?,?,?,?)";
            Iterator<MemberDTO> it = setMem.iterator();
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            int i = 1;
            con.setAutoCommit(false);
            while (it.hasNext()) {
                dto = it.next();
                pStm.setString(1, idMiss + dto.getUsername());
                pStm.setString(2, idMiss);
                pStm.setString(3, dto.getUsername());
                if (i == 1) {
                    pStm.setBoolean(4, true);
                } else {
                    pStm.setBoolean(4, false);
                }
                pStm.setString(5, dto.getWeaponId());
                pStm.addBatch();
                i++;
            }
            pStm.executeBatch();
            con.commit();

        } finally {
            closeConnection();
        }
        return true;
    }

    public void updateStatusMission(String id, String status) throws Exception {
        try {
            String sql = "update Mission set status  = ? where id = ?";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, status);
            pStm.setString(2, id);
            pStm.executeUpdate();
        } finally {
            closeConnection();
        }
    }

    public List<MissionDTO> searchMisstion(String name, String location, String level, String status) throws Exception {
        List<MissionDTO> list = new ArrayList<>();
        try {
            String sql = "select id,name,startDate,endDate,status from Mission where name like ? and location like ? and level = ? and status like ?";
            con = MyConnection.getConnection();;
            pStm = con.prepareStatement(sql);
            pStm.setString(1, "%" + name + "%");
            pStm.setString(2, "%" + location + "%");
            pStm.setString(3, level);
            if (status.equals("All")) {
                pStm.setString(4, "%");
            } else {
                pStm.setString(4, status);
            }
            rs = pStm.executeQuery();
            MissionDTO dto = null;
            while (rs.next()) {
                System.out.println(rs.getString("startDate"));
                dto = new MissionDTO(rs.getString("id"), rs.getString("name"), rs.getString("startDate"), rs.getString("endDate"), rs.getString("status"));
                list.add(dto);
            }
        } finally {
            closeConnection();
        }
        return list;
    }

    public boolean deleteMission(String id) throws Exception {
        boolean check = false;
        try {
            String sql = "update  Mission  set status = ?  where id = ?";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, "Delete");
            pStm.setString(2, id);
            check = pStm.executeUpdate() > 0;

        } finally {
            closeConnection();
        }
        return check;
    }

    public MissionDTO getMission(String id) throws Exception {
        MissionDTO dto = null;
        try {
            System.out.println(id);
            String sql = " select id, [name], [location], startDate, endDate ,level, description,finishDate from Mission where id = ?";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, id);
            rs = pStm.executeQuery();
            if (rs.next()) {

                dto = new MissionDTO(rs.getString("id"), rs.getString("name"), rs.getString("location"), rs.getString("level"), rs.getString("startDate"), rs.getString("endDate"), rs.getString("description"), rs.getString("finishDate"));
            }
        } finally {
            closeConnection();
        }
        return dto;
    }

    public void updateStatusMem(List<String> list) throws Exception {
        try {
            String sql = "update Member set status  = ? where username = ?";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            for (String username : list) {
                pStm.setString(1, "Action");
                pStm.setString(2, username);
                pStm.addBatch();
            }
            pStm.executeBatch();
        } finally {
            closeConnection();
        }
    }

    public MissionDTO getMissionForMember(String username) throws Exception {
        MissionDTO dto = null;
        try {
            String sql = "select id ,name,location,startDate,endDate,level,description,status from mission where id  = "
                    + "(select distinct idMis from MissionDetail where idMem = ? and iDmis in "
                    + "(select id from mission where status = ? or status = ?))";

            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, username);
            pStm.setString(2, "Send");
            pStm.setString(3, "Receive");
            rs = pStm.executeQuery();
            if (rs.next()) {
                dto = new MissionDTO();
                dto.setId(rs.getString("id"));
                dto.setName(rs.getString("name"));
                dto.setLocal(rs.getString("location"));
                dto.setStartDate(rs.getString("startDate"));
                dto.setEndDate(rs.getString("endDate"));
                dto.setLevel(rs.getString("level"));
                dto.setDescription(rs.getString("description"));
                dto.setStatus(rs.getString("status"));
            }
        } finally {
            closeConnection();
        }
        return dto;
    }

    public void updateStatusWep(List<String> list) throws Exception {
        try {
            String sql = "update Weapon set status  = ? where id = ?";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            for (String username : list) {
                pStm.setString(1, "Using");
                pStm.setString(2, username);
                pStm.addBatch();
            }
            pStm.executeBatch();
        } finally {
            closeConnection();
        }
    }

    public List<MemberDTO> getMember(String idMiss) throws Exception {
        List<MemberDTO> list = new ArrayList<>();
        try {
            String sql = "select id,username,fullname,gender,birthday,address from member where username in (select idMem from MissionDetail where idMis = ?)";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, idMiss);
            rs = pStm.executeQuery();
            String id, fullname, gender, birthday, address, username;
            MemberDTO dto = null;
            while (rs.next()) {
                id = rs.getString("id");
                username = rs.getString("username");
                fullname = rs.getString("fullname");
                gender = rs.getString("gender");
                birthday = rs.getString("birthday");
                address = rs.getString("address");
                dto = new MemberDTO();
                dto.setId(id);
                dto.setUsername(username);
                dto.setFullname(fullname);
                dto.setGender(gender);
                dto.setGender(gender);
                dto.setBirthday(birthday);
                dto.setAddress(address);
                list.add(dto);

            }
        } finally {
            closeConnection();
        }
        return list;
    }

    public String getLeader(String idMiss) throws Exception {
        String id = "";
        try {
            String sql = "select idMem from MissionDetail where idMis = ?  and  isLeader = ?";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, idMiss);
            pStm.setBoolean(2, true);
            rs = pStm.executeQuery();
            if (rs.next()) {
                id = rs.getString("idMem");
            }
        } finally {
            closeConnection();
        }
        return id;
    }

    public void updateMissionFail() throws Exception {
        try {
            String sql = "update Mission set status = 'Miss' where (startDate > GETDATE() or endDate < GETDATE() ) and status in ('Send','Receive','Create')";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.executeUpdate();
        } finally {
            closeConnection();
        }
    }

    public void finishMission(String id, String finishFile) throws Exception {
        try {
            String sql = "update Mission set status = ?,finishDate = ?,finishFile = ? where id = ?";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, "Finish");
            pStm.setDate(2, new java.sql.Date(new java.util.Date().getTime()));
            pStm.setString(3, finishFile);
            pStm.setString(4, id);
            pStm.executeUpdate();

        } finally {
            closeConnection();
        }
    }

    public void finishMember(String id) throws Exception {
        try {
            String sql = "update Member set status = ? where username in (select idMem from MissionDetail where idMis = ? )";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, "Ready");
            pStm.setString(2, id);
            pStm.executeUpdate();

        } finally {
            closeConnection();
        }
    }

    public void finishWeapon(String id) throws Exception {
        try {
            String sql = "update Weapon set status = ? where idMem in (select idMem from MissionDetail where idMis = ? )";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, "Ready");
            pStm.setString(2, id);
            pStm.executeUpdate();

        } finally {
            closeConnection();
        }
    }
}
