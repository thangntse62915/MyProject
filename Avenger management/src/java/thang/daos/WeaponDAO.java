/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thang.daos;

import java.io.Serializable;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;
import thang.conn.MyConnection;

import thang.dtos.WeaponDTO;

/**
 *
 * @author THANG NGUYEN
 */
public class WeaponDAO implements Serializable{

    private Connection con;
    private PreparedStatement pStm;
    private ResultSet rs;

    public WeaponDAO() {
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

    public List<WeaponDTO> searchWeapon(String name, String status) throws Exception {
        List<WeaponDTO> list = new ArrayList<>();
        try {
            String sql = "select id, name,power,designer,status from Weapon where name like ? and status like ?";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, "%" + name + "%");
            if (status.equals("All")) {
                pStm.setString(2, "%");
            } else {
                pStm.setString(2, status);
            }
            rs = pStm.executeQuery();
            while (rs.next()) {
                list.add(new WeaponDTO(rs.getString("id"), rs.getString("name"), rs.getString("power"), rs.getString("designer"), rs.getString("status")));
            }
        } finally {
            closeConnection();
        }
        return list;
    }

    public boolean deleteWeapon(String id) throws Exception {
        boolean check = false;
        try {
            con = MyConnection.getConnection();
            String sql = "update Weapon set status = ? where id = ?";
            pStm = con.prepareStatement(sql);
            pStm.setString(1, "Delete");
            pStm.setString(2, id);
            check = pStm.executeUpdate() > 0;

        } finally {
            closeConnection();
        }
        return check;
    }

    public boolean activeWeapon(String id) throws Exception {
        boolean check = false;
        try {
            con = MyConnection.getConnection();
            String sql = "update Weapon set status = ?  where id = ?";
            pStm = con.prepareStatement(sql);
            pStm.setString(1, "Ready");
            pStm.setString(2, id);
            check = pStm.executeUpdate() > 0;

        } finally {
            closeConnection();
        }
        return check;
    }

    public WeaponDTO getWeapon(String id) throws Exception {
        WeaponDTO dto = new WeaponDTO();
        try {
            String sql = "Select id, name, power, designer, color, image, idMem from Weapon where id  = ?";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, id);
            rs = pStm.executeQuery();
            if (rs.next()) {
                dto.setId(id);
                dto.setName(rs.getString("name"));
                dto.setPower(rs.getString("power"));
                dto.setDesigner(rs.getString("designer"));
                dto.setColor(rs.getString("color"));
                dto.setImg(rs.getString("image"));
                dto.setIdMem(rs.getString("idMem"));

            }
        } finally {
            closeConnection();
        }
        return dto;
    }

    public boolean uploadImg(String id, String filename) throws Exception {
        boolean result = false;
        try {
            String sql = "update Weapon set image = ? where id = ?";
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

    public boolean insertWeapon(WeaponDTO dto) throws Exception {
        boolean result = true;
        try {
            String sql = "insert into Weapon(id, name, power, designer, color, idMem,status,image) values(?,?,?,?,?,?,?,?)";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, dto.getId());
            pStm.setString(2, dto.getName());
            pStm.setString(3, dto.getPower());
            pStm.setString(4, dto.getDesigner());
            pStm.setString(5, dto.getColor());
            pStm.setString(6, dto.getIdMem());
            pStm.setString(7, "Ready");
            pStm.setString(8, dto.getImg());
            result = pStm.executeUpdate() > 0;
        } finally {
            closeConnection();
        }
        return result;
    }

    public List<WeaponDTO> getWeaponByIdUser(String id) throws Exception {
        List<WeaponDTO> list = new ArrayList<>();
        try {
            String sql = "select id, name from Weapon where idMem  = (select username from member where username  = ?) and status != ?";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, id);
            pStm.setString(2, "Delete");
            rs = pStm.executeQuery();
            WeaponDTO dto = null;
            while (rs.next()) {
                dto = new WeaponDTO(rs.getString("id"), rs.getString("name"));
                list.add(dto);
            }
            System.out.println(list.size());
        } finally {
            closeConnection();
        }
        return list;
    }

    public boolean updateWeapon(WeaponDTO dto) throws Exception {
        boolean check = false;

        try {
            String sql = "update Weapon set name =?,power= ?,color = ? ,designer = ? where id  = ?";
            con = MyConnection.getConnection();
            pStm = con.prepareStatement(sql);
            pStm.setString(1, dto.getName());
            pStm.setString(2, dto.getPower());
            pStm.setString(3, dto.getColor());
            pStm.setString(4, dto.getDesigner());
            pStm.setString(5, dto.getId());
            check = pStm.executeUpdate() > 0;
        } finally {
            closeConnection();
        }
        return check;
    }

}
