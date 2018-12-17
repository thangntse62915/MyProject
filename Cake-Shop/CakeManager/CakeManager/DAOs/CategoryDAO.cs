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
    public class CategoryDAO
    {
        String con;
        

        public CategoryDAO()
        {
            this.con = getConnction();
        }

        public string getConnction()
        {
            con = "server=.;database=CakeShop;uid=sa;pwd=1";
            return con;
        }
        public List<Category> getListCategory()
        {
            List<Category> list = new List<Category>();
            string sql = "Select [categoryId],[name] from tblCategory where status = 1";
            SqlConnection cnn = new SqlConnection(con);
            SqlCommand com = new SqlCommand(sql, cnn);
            try
            {
                if(cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader sdr = com.ExecuteReader();
                while (sdr.Read())
                {
                    list.Add(new Category(sdr.GetString(0), sdr.GetString(1)));
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                cnn.Close();
            }return list;
        }
    }
}
