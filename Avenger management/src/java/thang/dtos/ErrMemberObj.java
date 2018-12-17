/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thang.dtos;

import java.io.Serializable;

/**
 *
 * @author THANG NGUYEN
 */
public class ErrMemberObj implements Serializable{
    private String errId;
    private String errUsername;
    private String errFullname;
    private String errPassword;
    private String errConPassword;
    private String errBirthday;
    private String errAddress;
    private String errDescription;
    private String errImage;
    public ErrMemberObj() {
       
    }

    public String getErrPassword() {
        return errPassword;
    }

    public void setErrPassword(String errPassword) {
        this.errPassword = errPassword;
    }

    public String getErrConPassword() {
        return errConPassword;
    }

    public void setErrConPassword(String errConPassword) {
        this.errConPassword = errConPassword;
    }

    public String getErrBirthday() {
        return errBirthday;
    }

    public void setErrBirthday(String errBirthday) {
        this.errBirthday = errBirthday;
    }

    public String getErrAddress() {
        return errAddress;
    }

    public String getErrId() {
        return errId;
    }

    public void setErrId(String errId) {
        this.errId = errId;
    }

    public String getErrUsername() {
        return errUsername;
    }

    public void setErrUsername(String errUsername) {
        this.errUsername = errUsername;
    }

    public void setErrAddress(String errAddress) {
        this.errAddress = errAddress;
    }

    public String getErrDescription() {
        return errDescription;
    }

    public void setErrDescription(String errDescription) {
        this.errDescription = errDescription;
    }

    public String getErrImage() {
        return errImage;
    }

    public void setErrImage(String errImage) {
        this.errImage = errImage;
    }

    public String getErrFullname() {
        return errFullname;
    }

    public void setErrFullname(String errFullname) {
        this.errFullname = errFullname;
    }
    
}
