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
public class LoginErrObj implements Serializable{
    public String errUsername;
    public String errPassword;

    public LoginErrObj() {
    }

    public String getErrUsername() {
        return errUsername;
    }

    public void setErrUsername(String errUsername) {
        this.errUsername = errUsername;
    }

    public String getErrPassword() {
        return errPassword;
    }

    public void setErrPassword(String errPassword) {
        this.errPassword = errPassword;
    }
    
}
