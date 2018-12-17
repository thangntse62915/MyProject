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
public class ErrMissionObj implements Serializable{
     private String errid;
    private String errname;
    private String errlocal;
    private String errlevel;
    private String errstartDate;
    private String errendDate;
    private String errdescription;

    public ErrMissionObj() {
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

    public String getErrlocal() {
        return errlocal;
    }

    public void setErrlocal(String errlocal) {
        this.errlocal = errlocal;
    }

    public String getErrlevel() {
        return errlevel;
    }

    public void setErrlevel(String errlevel) {
        this.errlevel = errlevel;
    }

    public String getErrstartDate() {
        return errstartDate;
    }

    public void setErrstartDate(String errstartDate) {
        this.errstartDate = errstartDate;
    }

    public String getErrendDate() {
        return errendDate;
    }

    public void setErrendDate(String errendDate) {
        this.errendDate = errendDate;
    }

    public String getErrdescription() {
        return errdescription;
    }

    public void setErrdescription(String errdescription) {
        this.errdescription = errdescription;
    }
  
}
