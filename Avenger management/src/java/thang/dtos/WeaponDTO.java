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
public class WeaponDTO implements Serializable{

    private String id;
    private String name;
    private String idMem;
    private String member;
    private String power;
    private String designer;
    private String color;
    private String img;
    private String status;

    public WeaponDTO(String id, String name) {
        this.id = id;
        this.name = name;
    }

    public WeaponDTO(String id, String name, String power, String designer, String status) {
        this.id = id;
        this.name = name;
        this.power = power;
        this.designer = designer;
        this.status = status;
    }

    public WeaponDTO(String id, String name, String idMem, String power, String designer, String color, String img) {
        this.id = id;
        this.name = name;
        this.idMem = idMem;
        this.power = power;
        this.designer = designer;
        this.color = color;
        this.img = img;
    }

    public WeaponDTO(String id, String name, String idMem, String member, String power, String designer, String color, String img) {
        this.id = id;
        this.name = name;
        this.idMem = idMem;
        this.member = member;
        this.power = power;
        this.designer = designer;
        this.color = color;
        this.img = img;
    }

    public WeaponDTO() {
    }

    public String getMember() {
        return member;
    }

    public void setMember(String member) {
        this.member = member;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getIdMem() {
        return idMem;
    }

    public void setIdMem(String idMem) {
        this.idMem = idMem;
    }

    public String getPower() {
        return power;
    }

    public void setPower(String power) {
        this.power = power;
    }

    public String getDesigner() {
        return designer;
    }

    public void setDesigner(String designer) {
        this.designer = designer;
    }

    public String getColor() {
        return color;
    }

    @Override
    public String toString() {
        return "WeaponDTO{" + "id=" + id + ", name=" + name + ", idMem=" + idMem + ", member=" + member + ", power=" + power + ", designer=" + designer + ", color=" + color + ", img=" + img + ", status=" + status + '}';
    }

    public void setColor(String color) {
        this.color = color;
    }

    public String getImg() {
        return img;
    }

    public void setImg(String img) {
        this.img = img;
    }

    public String getStatus() {
        return status;
    }

    public void setStatus(String status) {
        this.status = status;
    }

}
