using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LinqProject
{
    class Data
    {
        String ConnectionString = "Server=HSC-5YQM6Y2; Database=School; Integrated Security=true;";
        public List<User> Get()
        {
            List<User> users = new List<User>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from [User]", con);
                cmd.CommandType = System.Data.CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    User user = new User();
                    user.ID = Convert.ToInt32(rdr["ID"]);
                    user.Age = Convert.ToInt32(rdr["Age"]);
                    user.Name = rdr["Name"].ToString();
                    user.City = rdr["City"].ToString();
                    users.Add(user);
                }
                con.Close();
            }
            return users;
        }

    }
}