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
public class MissionDTO implements Serializable{

    private String id;
    private String name;
    private String local;
    private String level;
    private String startDate;
    private String endDate;
    private String description;
    private String status;
    private String idAdmin;
    private String finishDate;

    public MissionDTO() {
    }

    public MissionDTO(String name, String local, String level, String status) {
        this.name = name;
        this.local = local;
        this.level = level;
        this.status = status;
    }

    public MissionDTO(String id, String name, String local, String level, String startDate, String endDate, String description) {
        this.id = id;
        this.name = name;
        this.local = local;
        this.level = level;
        this.startDate = startDate;
        this.endDate = endDate;
        this.description = description;
    }

    public MissionDTO(String id, String name, String local, String level, String startDate, String endDate, String description, String finishDate) {
        this.id = id;
        this.name = name;
        this.local = local;
        this.level = level;
        this.startDate = startDate;
        this.endDate = endDate;
        this.description = description;
        this.finishDate = finishDate;
    }

    public String getFinishDate() {
        return finishDate;
    }

    public void setFinishDate(String finishDate) {
        this.finishDate = finishDate;
    }

    public MissionDTO(String id, String name, String local, String level, String startDate, String endDate, String description, String status, String idAdmin) {
        this.id = id;
        this.name = name;
        this.local = local;
        this.level = level;
        this.startDate = startDate;
        this.endDate = endDate;
        this.description = description;
        this.status = status;
        this.idAdmin = idAdmin;
    }

    public MissionDTO(String id, String name, String startDate, String endDate, String status) {
        this.id = id;
        this.name = name;
        this.startDate = startDate;
        this.endDate = endDate;
        this.status = status;
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

    public String getLocal() {
        return local;
    }

    public void setLocal(String local) {
        this.local = local;
    }

    public String getLevel() {
        return level;
    }

    public void setLevel(String level) {
        this.level = level;
    }

    public String getStartDate() {
        return startDate;
    }

    public void setStartDate(String startDate) {
        this.startDate = startDate;
    }

    public String getEndDate() {
        return endDate;
    }

    public void setEndDate(String endDate) {
        this.endDate = endDate;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public String getStatus() {
        return status;
    }

    public void setStatus(String status) {
        this.status = status;
    }

    public String getIdAdmin() {
        return idAdmin;
    }

    public void setIdAdmin(String idAdmin) {
        this.idAdmin = idAdmin;
    }

    @Override
    public String toString() {
        return "MissionDTO{" + "id=" + id + ", name=" + name + ", local=" + local + ", level=" + level + ", startDate=" + startDate + ", endDate=" + endDate + ", description=" + description + ", status=" + status + ", idAdmin=" + idAdmin + '}';
    }
}
