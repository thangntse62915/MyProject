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
public class ErrWeaponObj implements Serializable{
    private String errid;
    private String errname;
    private String errcolor;
    private String errdesigner;
    private String errpower;
    private String errimage;

    public ErrWeaponObj() {
    }

    public String getErrid() {
        return errid;
    }

    public void setErrid(String errid) {
        this.errid = errid;
    }

    public String getErrname() {
        return errname;
    }

    public void setErrname(String errname) {
        this.errname = errname;
    }

    public String getErrcolor() {
        return errcolor;
    }

    public void setErrcolor(String errcolor) {
        this.errcolor = errcolor;
    }

    public String getErrdesigner() {
        return errdesigner;
    }

    public void setErrdesigner(String errdesigner) {
        this.errdesigner = errdesigner;
    }

    public String getErrpower() {
        return errpower;
    }

    public void setErrpower(String errpower) {
        this.errpower = errpower;
    }

    public String getErrimage() {
        return errimage;
    }

    public void setErrimage(String errimage) {
        this.errimage = errimage;
    }

  
}
