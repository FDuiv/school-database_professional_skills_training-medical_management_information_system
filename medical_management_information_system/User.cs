using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace medical_management_information_system
{
    class User
    {
        protected MySqlConnection connect;
        protected string account = null;
        /// <summary>
        /// 尝试注册，注册成功返回相应的值
        /// </summary>
        /// <param account="string">账号</param>
        /// <param password="string">密码/param>
        public string trySigin(string account, string password)
        {
            string sql = "select count(*) as Num from `MediDB`.`User` where `MediDB`.`User`.`account`=@account;";
            MySqlCommand cmd = new MySqlCommand(sql, this.connect);
            cmd.Parameters.AddWithValue("@account", account);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            if ((rdr["Num"].ToString()=="1"))
            {
                rdr.Close();
                return "Account already exists";
            }
            rdr.Close();

            sql="insert into `MediDB`.`User` (`MediDB`.`User`.`account`,`MediDB`.`User`.`password`) values (@account,MD5(@password));";
            cmd=new MySqlCommand(sql, this.connect);
            cmd.Parameters.AddWithValue("@account", account);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.ExecuteNonQuery();
            this.account=account;
            return "Sigin successful";
        }

        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <param ip="string">IP地址</param>
        /// <param port="string">端口号/param>
        /// <param user="string">账号</param>
        /// <param password="string">密码</param>
        public string Connect(string ip, string port, string user, string password)
        {
            this.connect=new MySqlConnection(String.Format("server={0};port={1};user={2};password={3}", ip, port, user, password));
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                connect.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return ex.Message.ToString();
            }
            new MySqlCommand("use MediDB;", this.connect).ExecuteReader().Close();
            return "Connection successful";
        }
        /// <summary>
        /// 尝试登陆，登陆成功返回相应的值
        /// </summary>
        /// <param account="string">账号</param>
        /// <param password="string">密码/param>
        public string tryLogin(string account, string password)
        {
            string sql = "select count(*) as Num from `MediDB`.`User` where `MediDB`.`User`.`account`=@account";
            MySqlCommand cmd = new MySqlCommand(sql, this.connect);
            cmd.Parameters.AddWithValue("@account", account);
            cmd.Parameters.AddWithValue("@password", password);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            if (!(rdr["Num"].ToString()=="1"))
            {
                rdr.Close();
                return "Account does not exist";
            }
            rdr.Close();

            sql ="select count(*) as Num from `MediDB`.`User` where `MediDB`.`User`.`account`=@account and `MediDB`.`User`.`password`=MD5(@password)";
            cmd = new MySqlCommand(sql, this.connect);
            cmd.Parameters.AddWithValue("@account", account);
            cmd.Parameters.AddWithValue("@password", password);
            rdr = cmd.ExecuteReader();
            rdr.Read();
            if (!(rdr["Num"].ToString()=="1"))
            {
                rdr.Close();
                return "Password error";
            }
            rdr.Close();

            sql="update `MediDB`.`User` set `MediDB`.`User`.`newLoginTime`=localtime() where `MediDB`.`User`.`account`=@account;";
            cmd=new MySqlCommand(sql, this.connect);
            cmd.Parameters.AddWithValue("@account", account);
            cmd.ExecuteNonQuery();
            this.account=account;
            return "Login successful";
        }
        /// <summary>
        /// 登出
        /// </summary>
        public void LoginOut()
        {
            this.account=null;
        }
        /// <summary>
        /// 获取当前登入账号
        /// </summary>
        public string getAccount()
        {
            return this.account;
        }
        /// <summary>
        /// 获取当前连接
        /// </summary>
        public MySqlConnection getConnect()
        {
            return this.connect;
        }
        public string getStaffId()
        {
            if (this.account!=null)
            {
                string sql = "select `MediDB`.`User`.`Staff_id` as Staff_id from `MediDB`.`User` where `MediDB`.`User`.`account`=@account;";
                MySqlCommand cmd = new MySqlCommand(sql, this.connect);
                cmd.Parameters.AddWithValue("@account", account);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                string staffId = rdr["Staff_id"].ToString();
                rdr.Close();
                return staffId;
            }
            return "null account";
        }
        public string bindAccount(string name,string gender,string birthDay, string companyName, string departmentName,string addrs,string phones)
        {
            if (this.account!=null)
            {

            }
            return "null account";
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        public void Close()
        {
            this.LoginOut();
            if (this.connect!=null)
            {
                Console.WriteLine("MySQL close.");
                this.connect.Clone();
                this.connect=null;
            }
        }
        /// <summary>
        /// 析构
        /// </summary>
        ~User()
        {
            this.Close();
        }
    }
}
