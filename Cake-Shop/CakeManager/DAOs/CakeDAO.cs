using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOs
{
    public class CakeDAO
    {
        String con;
        List<Cake> list = new List<Cake>();

        public CakeDAO()
        {
            this.con = getConnction();
        }

        public string getConnction()
        {
            con = "server=.;database=CakeShop;uid=sa;pwd=12345";
            return con;
        }
        public DataTable getCakes()
        {
            string SQL = "GetAllCake";
            SqlConnection cnn = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtCake = new DataTable();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(dtCake);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return dtCake;
        }



        public bool AddNewCake(Cake c) 
        {
            SqlConnection sqlConnection = new SqlConnection(con);
            string sql = "InsertCake @id,@name,@price,@quantity,@categoryId,@origin,@description,@img1";
            SqlCommand cm = new SqlCommand(sql, sqlConnection);
            cm.Parameters.AddWithValue("@id", c.CakeId);
            cm.Parameters.AddWithValue("@name", c.Name);
            cm.Parameters.AddWithValue("@price", c.Price);
            cm.Parameters.AddWithValue("@categoryId", c.CategoryId);
            cm.Parameters.AddWithValue("@origin", c.Origin);
            cm.Parameters.AddWithValue("@quantity", c.Quantity);
            cm.Parameters.AddWithValue("@img1", c.Img1);
            cm.Parameters.AddWithValue("@description", c.Description);

            int count;
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                count = cm.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                sqlConnection.Close();

            }

            return count > 0;

        }
       public bool UpdateCake(Cake c)
        {
            SqlConnection sqlConnection = new SqlConnection(con);
            
            string sql = "[updateCake] @id,@name, @origin, @price, @quantity, @categoryId, @img1, @description";
            SqlCommand cm = new SqlCommand(sql, sqlConnection);
            cm.Parameters.AddWithValue("@id", c.CakeId);
            cm.Parameters.AddWithValue("@name", c.Name);
            cm.Parameters.AddWithValue("@price", c.Price);
            cm.Parameters.AddWithValue("@categoryId", c.CategoryId);
            cm.Parameters.AddWithValue("@origin", c.Origin);
            cm.Parameters.AddWithValue("@quantity", c.Quantity);
            cm.Parameters.AddWithValue("@img1", c.Img1);
            cm.Parameters.AddWithValue("@description", c.Description);
            int count;
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                count = cm.ExecuteNonQuery();


            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                sqlConnection.Close();

            }

            return count > 0;
        }
        public bool UpdateCakeNoImg(Cake c)
        {
            SqlConnection sqlConnection = new SqlConnection(con);

            string sql = "[updateCakeNoImg] @id,@name, @origin, @price, @quantity, @categoryId, @description";
            SqlCommand cm = new SqlCommand(sql, sqlConnection);
            cm.Parameters.AddWithValue("@id", c.CakeId);
            cm.Parameters.AddWithValue("@name", c.Name);
            cm.Parameters.AddWithValue("@price", c.Price);
            cm.Parameters.AddWithValue("@categoryId", c.CategoryId);
            cm.Parameters.AddWithValue("@origin", c.Origin);
            cm.Parameters.AddWithValue("@quantity", c.Quantity);
          
            cm.Parameters.AddWithValue("@description", c.Description);
            int count;
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                count = cm.ExecuteNonQuery();


            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                sqlConnection.Close();

            }

            return count > 0;
        }
        public bool DeleteCake(string  id)
        {
            SqlConnection sqlConnection = new SqlConnection(con);

            string sql = "[deleteCake] @id";
            SqlCommand cm = new SqlCommand(sql, sqlConnection);
            cm.Parameters.AddWithValue("@id", id);
         
           
            int count;
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                count = cm.ExecuteNonQuery();


            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                sqlConnection.Close();

            }

            return count > 0;
        }
    }
}
