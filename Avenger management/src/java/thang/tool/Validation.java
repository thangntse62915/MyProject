/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thang.tool;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;


/**
 *
 * @author THANG NGUYEN
 */
public class Validation {

    public Validation() {
    }

    public  boolean checkDate(String date) {
        
        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
        sdf.setLenient(false);
        try {
           return sdf.parse(date).before(new Date());
        } catch (ParseException ex) {
            return  false;
        }
      
    }
}
