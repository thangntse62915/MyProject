/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thang.conn;

import java.sql.Connection;
import java.sql.DriverManager;

/**
 *
 * @author THANG NGUYEN
 */
public class MyConnection {
    public static Connection getConnection()throws Exception{
        Connection conn = null;
        Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
        conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databaseName=avenger","sa","12345");
        return conn;
    }
}
