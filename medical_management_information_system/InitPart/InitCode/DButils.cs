using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medical_management_information_system
{
    static class DButils
    {
        static public List<string> getAllCompanys()
        {
            List<string> companys = new List<string>();
            string sql = "select `name` from `MediDB`.`MedicineSupermarketCompany`;";
            MySqlCommand cmd = new MySqlCommand(sql, Program.user.getConnect());
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                companys.Add(rdr["name"].ToString());

            }
            rdr.Close();
            return companys;
        }
        static public List<string> getBranch(string companyName)
        {
            List<string> branchs = new List<string>();
            string sql = "select `MediDB`.`MedicineSupermarket`.`name` from `MediDB`.`MedicineSupermarket` where `MediDB`.`MedicineSupermarket`.`MedicineSupermarketCompany_id` in (select `MedicineSupermarketCompany_id` from `MediDB`.`MedicineSupermarketCompany` where `MediDB`.`MedicineSupermarketCompany`.`name`='"+companyName+"');";
            MySqlCommand cmd = new MySqlCommand(sql, Program.user.getConnect());
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                branchs.Add(rdr["name"].ToString());
            }
            rdr.Close();  
            return branchs;
        }
        static public List<string> getDepartment(string branchName)
        {
            List<string> departments = new List<string>();
            string sql = "select `MediDB`.`Department`.`name` from `MediDB`.`Department` where `MediDB`.`Department`.`MedicineSupermarket_id` in (select `MedicineSupermarket_id` from `MediDB`.`MedicineSupermarket` where `MediDB`.`MedicineSupermarket`.`name`='"+branchName+"');";
            MySqlCommand cmd = new MySqlCommand(sql, Program.user.getConnect());
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                departments.Add(rdr["name"].ToString());
            }
            rdr.Close();

            return departments;
        }
    }
}
