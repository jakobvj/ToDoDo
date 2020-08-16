using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ToDoDo.Web.Models;

namespace ToDoDo.Web.Service
{
    public class ToDoService : IToDoService
    {
        string connectionString = @"Data Source=DESKTOP-AH0FKUK\SQLEXPRESS;Initial Catalog=ToDoDb;Integrated Security=True;";

        public void AddToDo(ToDo toDo)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tblToDo Values(@Description, @Done)", connection);
                cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = toDo.ToDoText;
                cmd.Parameters.Add("@Done", SqlDbType.Bit).Value = false;
                try
                {
                    connection.Open();

                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    connection.Close();
                }
            }
            

        }

        public void EditToDo(ToDo toDo)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                    SqlCommand cmd = new SqlCommand("UPDATE tblToDo SET Description = @Description, Done = @Done WHERE ID = @ToDoId", connection);
                
                cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = toDo.ToDoText;
                cmd.Parameters.Add("@Done", SqlDbType.Bit).Value = toDo.Done;
                try
                {
                    connection.Open();

                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public List<ToDo> GetAllToDos()
        {
            DataTable table = new DataTable("tblToDo");
            SqlDataReader dr;
            List<ToDo> ToDos = new List<ToDo>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblToDo", connection);
                try
                {
                    connection.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ToDos.Add(new ToDo()
                        {
                            Id = dr.GetInt32(dr.GetOrdinal("Id")),
                            ToDoText = dr.GetString(dr.GetOrdinal("Description")),
                            Done = dr.GetBoolean(dr.GetOrdinal("Done"))
                        });

                    }
                }
                finally
                {
                    connection.Close();
                }


            }

            return ToDos;
        }
    }
}
