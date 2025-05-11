using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace MVCProject.Models
{
    public class RegistrationDll
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Dob { get; set; }
        public string AAdhar { get; set; }
        public string Address { get; set; }
        public string password { get; set; }



    }

    public class BLRegistration
    {
        public static void ConnectionDB(RegistrationDll Robj)
        {
            try
            {
                SqlConnection con = new SqlConnection("data source=DESKTOP-34SUGAB; database=Demo_DB; integrated security=true");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO student (studentName, email,phone,dOB,addhar,address,password) VALUES ('" + Robj.Name + "','" + Robj.Email + "','" + Robj.Phone + "','" + Robj.Dob + "','" + Robj.AAdhar + "','" + Robj.Address + "','" + Robj.password + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {

            }

        }
    }
}