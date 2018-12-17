/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thang.dtos;

import java.io.Serializable;
import java.sql.Date;
import java.util.List;

/**
 *
 * @author THANG NGUYEN
 */
public class MemberDTO implements Serializable {

    private String id;
    private String username;
    private String password;
    private String fullname;
    private String birthday;
    private String gender;
    private String address;
    private String description;
    private Date enrolldate;
    private Date unenrolldate;
    private String status;
    private String role;
    private String image;
    private List<WeaponDTO> list;
    private String weaponId;

    public MemberDTO(String id, String username, String password, String fullname, String birthday, String gender, String address, String description, String image) {
        this.id = null;
        this.username = username;
        this.password = password;
        this.fullname = fullname;
        this.birthday = birthday;
        this.gender = gender;
        this.address = address;
        this.description = description;
        this.image = image;
    }

    public MemberDTO() {
    }

    public MemberDTO(String id, String fullname, String birthday, String gender) {
        this.id = id;
        this.fullname = fullname;
        this.birthday = birthday;
        this.gender = gender;
    }

    public List<WeaponDTO> getList() {
        return list;
    }

    public void setList(List<WeaponDTO> list) {
        this.list = list;
    }

    public String getWeaponId() {
        return weaponId;
    }

    public void setWeaponId(String weaponId) {
        this.weaponId = weaponId;
    }

    public MemberDTO(String username, String fullname) {
        this.username = username;
        this.fullname = fullname;
    }

    public MemberDTO(String id, String username, String password) {
        this.id = id;
        this.username = username;
        this.password = password;
    }

    public MemberDTO(String id, String username, String password, String fullname, String birthday, String gender, String address, String description, java.sql.Date enrolldate, java.sql.Date unenrolldate, String image) {
        this.id = id;
        this.username = username;
        this.fullname = fullname;
        this.birthday = birthday;
        this.gender = gender;
        this.address = address;
        this.description = description;
        this.enrolldate = enrolldate;
        this.unenrolldate = unenrolldate;
        this.password = password;
        this.image = image;
    }

    public MemberDTO(String id, String fullname, String birthday, String gender, String address, String status) {
        this.id = id;
        this.fullname = fullname;
        this.birthday = birthday;
        this.gender = gender;
        this.address = address;
        this.status = status;
    }

    public MemberDTO(String id, String username, String password, String fullname, String birthday, String gender, String address, String description) {
        this.id = id;
        this.username = username;
        this.password = password;
        this.fullname = fullname;
        this.birthday = birthday;
        this.gender = gender;
        this.address = address;
        this.description = description;

    }

    public String getImage() {
        return image;
    }

    public void setImage(String image) {
        this.image = image;
    }

    public String getRole() {
        return role;
    }

    public void setRole(String role) {
        this.role = role;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getFullname() {
        return fullname;
    }

    public void setFullname(String fullname) {
        this.fullname = fullname;
    }

    public String getBirthday() {
        return birthday;
    }

    public void setBirthday(String birthday) {
        this.birthday = birthday;
    }

    public String getGender() {
        return gender;
    }

    public void setGender(String gender) {
        this.gender = gender;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public Date getEnrolldate() {
        return enrolldate;
    }

    public void setEnrolldate(Date enrolldate) {
        this.enrolldate = enrolldate;
    }

    public Date getUnenrolldate() {
        return unenrolldate;
    }

    public void setUnenrolldate(Date unenrolldate) {
        this.unenrolldate = unenrolldate;
    }

    public String getStatus() {
        return status;
    }

    public void setStatus(String status) {
        this.status = status;
    }

    @Override
    public String toString() {
        return "MemberDTO{" + "id=" + id + ", username=" + username + ", password=" + password + ", fullname=" + fullname + ", birthday=" + birthday + ", gender=" + gender + ", address=" + address + ", description=" + description + ", enrolldate=" + enrolldate + ", unenrolldate=" + unenrolldate + ", status=" + status + ", role=" + role + ", image=" + image + ", list=" + list + ", weaponId=" + weaponId + '}';
    }

   
}
