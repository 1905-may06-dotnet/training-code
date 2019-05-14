using System;
using System.Data;
using System.Data.SqlClient;

namespace ADOApplication
{
    //Comments 
    //Hotkeys VS2019 : ctrl + K+C-> comment, ctrl + k+U -> Uncomment, ctrl + K+D -> Indentation
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = "Data Source=utadbServer.database.windows.net;" +
                "Initial Catalog=AdventureWorks;Persist Security Info=True;" +
                "User ID=pushpinder;Password=Password123";
            string query = "select * from SalesLT.Customer where LastName = 'Adams'";
            //1. Make a Sql connection   
            SqlConnection con;
            //2. Fire Sql Command
            SqlCommand cmd;
            #region Connected Objects
            //3. Execute Query and Get Results
            SqlDataReader dr;
            #endregion
            #region disconnected Objects
            SqlDataAdapter da; //use to fire query and also open and close connection
            DataSet ds;//temporary DB at client
            #endregion
            try
            {
                //Connected(conStr, query, out con, out cmd, out dr);
                DisConnected(conStr, query,out con,out da,out ds);
            }
            catch (SqlException ex)
            {
                throw;
                //log Exceptions
            }
        }

        private static void Connected(string conStr, string query, out SqlConnection con, out SqlCommand cmd, out SqlDataReader dr)
        {
            using (con = new SqlConnection(conStr))
            {
                con.Open();
                using (cmd = new SqlCommand(query, con))
                {
                    //Used for select Commands
                    dr = cmd.ExecuteReader();// ExecuteNonQuery(); Used for insert, update and delete 
                    if (dr.HasRows)
                    {
                        //Read() will pull 1 record at a time- So it cannot backtrack, 
                        // that's why we should read/store the previous record
                        while (dr.Read())
                        {
                            Console.WriteLine($"Id: {dr[0]} Name {dr["FirstName"]} {dr["MiddleName"]} {dr["LastName"]}");
                        }
                    }
                    con.Close();
                }
            }
        }

        private static void DisConnected(string conStr, string query, out SqlConnection con, out SqlDataAdapter da, out DataSet ds)
        {
            using (con=new SqlConnection(conStr))
            {
                //Open Sql Connection, fire the query, query executed, returns the results
                da = new SqlDataAdapter(query, con);

                ds = new DataSet();//to hold tables/records/Columns
                
                int rows=da.Fill(ds,"Customers");

                if(rows !=0)
                {
                    foreach (DataRow r in ds.Tables["Customers"].Rows)
                    {
                        Console.WriteLine(r["FirstName"]);
                    }
                }
            }
        }
    }
}
