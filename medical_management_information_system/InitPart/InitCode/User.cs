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
        /// <summary>
        /// 获取员工id
        /// </summary>
        /// <returns></returns>
        private int getStaffId()
        {

            string sql = "select `MediDB`.`User`.`Staff_id` as Staff_id from `MediDB`.`User` where `MediDB`.`User`.`account`=@account;";
            MySqlCommand cmd = new MySqlCommand(sql, this.connect);
            cmd.Parameters.AddWithValue("@account", account);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            if (rdr["Staff_id"].ToString()=="")
            {
                rdr.Close();
                return -1;
            }
            int staffId = int.Parse(rdr["Staff_id"].ToString());
            rdr.Close();
            return staffId;

        }
        /// <summary>
        /// 获取用户姓名
        /// </summary>
        public string getName()
        {
            if (this.account!=null)
            {
                string sql = "";
                MySqlCommand cmd;
                MySqlDataReader rdr;
                sql="select `MediDB`.`Staff`.`name` from `MediDB`.`Staff` where `MediDB`.`Staff`.`Staff_id`="+this.getStaffId()+";";
                cmd=new MySqlCommand(sql, this.connect);
                rdr=cmd.ExecuteReader();
                rdr.Read();
                string name = rdr["name"].ToString();
                rdr.Close();
                return name;
            }
            return "null account";
        }
        /// <summary>
        /// 获取用户性别
        /// </summary>
        public string getGender()
        {
            if (this.account!=null)
            {
                string sql = "";
                MySqlCommand cmd;
                MySqlDataReader rdr;
                sql="select `MediDB`.`Staff`.`gender` from `MediDB`.`Staff` where `MediDB`.`Staff`.`Staff_id`="+this.getStaffId()+";";
                cmd=new MySqlCommand(sql, this.connect);
                rdr=cmd.ExecuteReader();
                rdr.Read();
                string gender = rdr["gender"].ToString();
                rdr.Close();
                return gender;
            }
            return "null account";
        }
        /// <summary>
        /// 获取用户出生日期
        /// </summary>
        public string getBirthDay()
        {
            if (this.account!=null)
            {
                string sql = "";
                MySqlCommand cmd;
                MySqlDataReader rdr;
                sql="select `MediDB`.`Staff`.`birthDay` from `MediDB`.`Staff` where `MediDB`.`Staff`.`Staff_id`="+this.getStaffId()+";";
                cmd=new MySqlCommand(sql, this.connect);
                rdr=cmd.ExecuteReader();
                rdr.Read();
                string birthDay = rdr["birthDay"].ToString();
                rdr.Close();
                return birthDay;
            }
            return "null account";
        }
        /// <summary>
        /// 获取用户所属部门id
        /// </summary>
        private int getDepartmentId()
        {
            if (this.getStaffId()!=-1)
            {
                string sql = "";
                MySqlCommand cmd;
                MySqlDataReader rdr;
                sql="select `MediDB`.`Staff`.`Department_id` from `MediDB`.`Staff` where `MediDB`.`Staff`.`Staff_id`="+this.getStaffId()+";";
                cmd=new MySqlCommand(sql, this.connect);
                rdr=cmd.ExecuteReader();
                rdr.Read();
                int departmentId = int.Parse(rdr["Department_id"].ToString());
                rdr.Close();
                return departmentId;
            }
            return -1;
        }
        /// <summary>
        /// 获取用户所属部门名
        /// </summary>
        public string getDepartmentName()
        {
            if (this.getStaffId()!=-1)
            {
                string sql = "";
                MySqlCommand cmd;
                MySqlDataReader rdr;
                sql="select `MediDB`.`Department`.`name` from `MediDB`.`Department` where `MediDB`.`Department`.`Department_id`="+this.getDepartmentId()+";";
                cmd=new MySqlCommand(sql, this.connect);
                rdr=cmd.ExecuteReader();
                rdr.Read();
                string departmentName = rdr["name"].ToString();
                rdr.Close();
                return departmentName;
            }
            return "";
        }
        /// <summary>
        /// 获取用户所属分部id
        /// </summary>
        private int getBranchId()
        {
            if (this.getStaffId()!=-1)
            {
                string sql = "";
                MySqlCommand cmd;
                MySqlDataReader rdr;
                sql="select `MediDB`.`Department`.`MedicineSupermarket_id` from `MediDB`.`Department` where`MediDB`.`Department`.`Department_id`="+this.getDepartmentId()+";";
                cmd=new MySqlCommand(sql, this.connect);
                rdr=cmd.ExecuteReader();
                rdr.Read();
                int medicineSupermarketId = int.Parse(rdr["MedicineSupermarket_id"].ToString());
                rdr.Close();
                return medicineSupermarketId;
            }
            return -1;
        }
        /// <summary>
        /// 获取用户所属分部名
        /// </summary>
        public string getBranchName()
        {
            if (this.getStaffId()!=-1)
            {
                string sql = "";
                MySqlCommand cmd;
                MySqlDataReader rdr;
                sql="select `MediDB`.`MedicineSupermarket`.`name` from `MediDB`.`MedicineSupermarket` where `MediDB`.`MedicineSupermarket`.`MedicineSupermarket_id`="+this.getBranchId()+";";
                cmd=new MySqlCommand(sql, this.connect);
                rdr=cmd.ExecuteReader();
                rdr.Read();
                string branchName = rdr["name"].ToString();
                rdr.Close();
                return branchName;
            }
            return "null account";
        }
        /// <summary>
        /// 获取用户所属公司id
        /// </summary>
        private int getCompanyId()
        {
            if (this.getStaffId()!=-1)
            {
                string sql = "";
                MySqlCommand cmd;
                MySqlDataReader rdr;
                sql="select `MediDB`.`MedicineSupermarket`.`MedicineSupermarketCompany_id` from `MediDB`.`MedicineSupermarket` where`MediDB`.`MedicineSupermarket`.`MedicineSupermarket_id`="+this.getBranchId()+";";
                cmd=new MySqlCommand(sql, this.connect);
                rdr=cmd.ExecuteReader();
                rdr.Read();
                int CompanyId = int.Parse(rdr["MedicineSupermarketCompany_id"].ToString());
                rdr.Close();
                return CompanyId;
            }
            return -1;
        }

        /// <summary>
        /// 获取用户所属公司名
        /// </summary>
        public string getCompanyName()
        {
            if (this.getStaffId()!=-1)
            {
                string sql = "";
                MySqlCommand cmd;
                MySqlDataReader rdr;
                sql="select `MediDB`.`MedicineSupermarketCompany`.`name` from `MediDB`.`MedicineSupermarketCompany` where `MediDB`.`MedicineSupermarketCompany`.`MedicineSupermarketCompany_id`="+this.getCompanyId()+";";
                cmd=new MySqlCommand(sql, this.connect);
                rdr=cmd.ExecuteReader();
                rdr.Read();
                string companyName = rdr["name"].ToString();
                rdr.Close();
                return companyName;
            }
            return "null account";
        }
        /// <summary>
        /// 获取当前用户地址
        /// </summary>
        public string[] getAddrs()
        {
            if (this.getStaffId()!=-1)
            {
                string sql = "";
                MySqlCommand cmd;
                MySqlDataReader rdr;
                sql="select `MediDB`.`StaffAddr`.`addr` from `MediDB`.`StaffAddr` where `MediDB`.`StaffAddr`.`Staff_id`="+this.getStaffId()+" and isDelete!='是'; ";
                cmd=new MySqlCommand(sql, this.connect);
                rdr=cmd.ExecuteReader();
                List<string> result = new List<string>();
                while (rdr.Read())
                {
                    result.Add(rdr["addr"].ToString());
                }
                rdr.Close();
                return result.ToArray();
            }
            return new string[] { };
        }
        /// <summary>
        /// 获取当前用户电话
        /// </summary>
        public string[] getPhones()
        {
            if (this.getStaffId()!=-1)
            {
                string sql = "";
                MySqlCommand cmd;
                MySqlDataReader rdr;
                sql="select `MediDB`.`StaffPhone`.`phoneNum` from `MediDB`.`StaffPhone` where `MediDB`.`StaffPhone`.`Staff_id`="+this.getStaffId()+" and isDelete!='是'; ";
                cmd=new MySqlCommand(sql, this.connect);
                rdr=cmd.ExecuteReader();
                List<string> result = new List<string>();
                while (rdr.Read())
                {
                    result.Add(rdr["phoneNum"].ToString());
                }
                rdr.Close();
                return result.ToArray();
            }
            return new string[] { };
        }
        /// <summary>
        /// 获取用户权限组id
        /// </summary>
        private int getJurisdictionId()
        {
            if (this.account!=null)
            {
                string sql = "";
                MySqlCommand cmd;
                MySqlDataReader rdr;
                sql="select `MediDB`.`User`.`Jurisdiction_id` "+
                    "from `MediDB`.`User` "+
                    "where `MediDB`.`User`.`account`='"+this.account+"'; ";
                cmd=new MySqlCommand(sql, this.connect);
                rdr=cmd.ExecuteReader();
                rdr.Read();
                int jurisdictionId = int.Parse(rdr["Jurisdiction_id"].ToString());
                rdr.Close();
                return jurisdictionId;
            }
            return -1;
        }


        /// <summary>
        /// 获取权限字典
        /// </summary>
        public Dictionary<string, bool> getJurisdictions()
        {
            Dictionary<string, bool> jurisdictions = new Dictionary<string, bool>();
            string sql = "";
            MySqlCommand cmd;
            MySqlDataReader rdr;
            sql="select * "+
                "from `MediDB`.`Jurisdiction` "+
                "where `MediDB`.`Jurisdiction`.`Jurisdiction_id`="+this.getJurisdictionId()+"; ";
            cmd=new MySqlCommand(sql, this.connect);
            rdr=cmd.ExecuteReader();
            rdr.Read();
            jurisdictions["采购订单页表"]=(rdr["采购订单页表"].ToString()=="True");
            jurisdictions["请购单页表"]=(rdr["请购单页表"].ToString()=="True");
            jurisdictions["经销商管理页表"]=(rdr["经销商管理页表"].ToString()=="True");
            jurisdictions["采购规划页表"]=(rdr["采购规划页表"].ToString()=="True");
            jurisdictions["药品管理页表"]=(rdr["药品管理页表"].ToString()=="True");
            jurisdictions["财务管理页表"]=(rdr["财务管理页表"].ToString()=="True");
            jurisdictions["顾客统计页表"]=(rdr["顾客统计页表"].ToString()=="True");
            jurisdictions["采购人员管理页表"]=(rdr["采购人员管理页表"].ToString()=="True");
            jurisdictions["经办人管理页表"]=(rdr["经办人管理页表"].ToString()=="True");
            jurisdictions["购物窗口页表"]=(rdr["购物窗口页表"].ToString()=="True");
            rdr.Close();
            return jurisdictions;
        }
        /// <summary>
        /// 获取采购单
        /// </summary>
        public string[] getPurchaseOrders(bool isComplete, bool isPurchaseDate)
        {
            if (this.account!=null)
            {
                List<string> purchaseOrders = new List<string>();
                string sql = "";
                MySqlCommand cmd;
                MySqlDataReader rdr;
                if (isComplete)
                {
                    if (isPurchaseDate)
                    {
                        sql="select `MediDB`.`PurchaseOrders`.`purchaseDate` "+
                            "from `MediDB`.`PurchaseOrders` "+
                            "where `isDelete` = '否' "+
                            "and `MediDB`.`PurchaseOrders`.`isComplete`="+1+" "+
                            "order by `MediDB`.`PurchaseOrders`.`purchaseDate` desc; ";
                    }
                    else
                    {
                        sql="select `MediDB`.`PurchaseOrders`.`completDate` "+
                            "from `MediDB`.`PurchaseOrders` "+
                            "where `isDelete` = '否' "+
                            "and `MediDB`.`PurchaseOrders`.`isComplete`="+1+" "+
                            "order by `MediDB`.`PurchaseOrders`.`completDate` desc; ";
                    }
                }
                else
                {
                    if (isPurchaseDate)
                    {
                        sql="select `MediDB`.`PurchaseOrders`.`purchaseDate` "+
                        "from `MediDB`.`PurchaseOrders` "+
                        "where `isDelete` = '否' "+
                        "and `MediDB`.`PurchaseOrders`.`isComplete`="+0+" "+
                        "order by `MediDB`.`PurchaseOrders`.`purchaseDate` desc; ";
                    }
                    else
                    {
                        sql="select `MediDB`.`PurchaseOrders`.`completDate` "+
                               "from `MediDB`.`PurchaseOrders` "+
                               "where `isDelete` = '否' "+
                               "and `MediDB`.`PurchaseOrders`.`isComplete`="+0+" "+
                               "order by `MediDB`.`PurchaseOrders`.`completDate` desc; ";
                    }
                }
                cmd=new MySqlCommand(sql, this.connect);
                rdr=cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (isPurchaseDate)
                    {
                        purchaseOrders.Add(rdr["purchaseDate"].ToString());
                    }
                    else
                    {
                        purchaseOrders.Add(rdr["completDate"].ToString());
                    }
                }
                rdr.Close();
                return purchaseOrders.ToArray();
            }
            return new List<string>().ToArray();
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
            if (this.connect!=null)
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

                sql="select count(*) as Num from `MediDB`.`User` where `MediDB`.`User`.`account`=@account and `MediDB`.`User`.`password`=MD5(@password)";
                cmd=new MySqlCommand(sql, this.connect);
                cmd.Parameters.AddWithValue("@account", account);
                cmd.Parameters.AddWithValue("@password", password);
                rdr=cmd.ExecuteReader();
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
            return "no connect";
        }
        /// <summary>
        /// 尝试注册，注册成功返回相应的值
        /// </summary>
        /// <param account="string">账号</param>
        /// <param password="string">密码/param>
        public string trySigin(string account, string password)
        {
            if (this.connect!=null)
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

                sql="insert into `MediDB`.`User` (`MediDB`.`User`.`account`,`MediDB`.`User`.`password`,`MediDB`.`User`.`Jurisdiction_id`) values (@account,MD5(@password),@jurisdictionId);";
                cmd=new MySqlCommand(sql, this.connect);
                cmd.Parameters.AddWithValue("@account", account);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@jurisdictionId", 1);
                cmd.ExecuteNonQuery();
                this.account=account;
                return "Sigin successful";
            }
            return "no connect";
        }
        /// <summary>
        /// 登出
        /// </summary>
        public void LoginOut()
        {
            this.account=null;
        }

        /// <summary>
        /// 账号和员工之间的绑定
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="birthDay"></param>
        /// <param name="companyName"></param>
        /// <param name="branchName"></param>
        /// <param name="departmentName"></param>
        /// <param name="addrs"></param>
        /// <param name="phones"></param>
        /// <returns></returns>
        public string bindAccount(string name, string gender, string birthDay, string companyName, string branchName, string departmentName, List<string> addrs, List<string> phones)
        {
            if (this.account!=null)
            {
                string sql = "";
                MySqlCommand cmd;
                MySqlDataReader rdr;
                int departmentId = DButils.getDepartmentId(companyName, branchName, departmentName);
                sql="insert into `MediDB`.`Staff` "+
                    "(`Department_id`,`name`,`gender`,`birthDay`)"+
                    "values"+
                    "("+departmentId+", '"+name+"', '"+gender+"', '"+birthDay+"');";
                cmd=new MySqlCommand(sql, this.connect);
                cmd.ExecuteNonQuery();

                sql="select LAST_INSERT_ID() as Staff_id;";
                cmd=new MySqlCommand(sql, this.connect);
                rdr=cmd.ExecuteReader();
                rdr.Read();
                int staffId = int.Parse(rdr["Staff_id"].ToString());
                rdr.Close();

                int jurisdictionId = DButils.getJurisdictionId(companyName+"_"+branchName+"_"+departmentName);
                sql="update `MediDB`.`User` "+
                    "set `Staff_id`="+staffId+",`Jurisdiction_id`="+jurisdictionId+" "+
                    "where `MediDB`.`User`.`account`='"+this.account+"'; ";
                for (int i = 0; i<addrs.Count; i++)
                {
                    sql+="insert into `MediDB`.`StaffAddr` "+
                        "(`Staff_id`,`addr`) "+
                        "values "+
                        "("+staffId+",'"+addrs[i]+"'); ";
                }
                for (int i = 0; i<phones.Count; i++)
                {
                    sql+="insert into `MediDB`.`StaffPhone` "+
                        "(`Staff_id`,`phoneNum`) "+
                        "values "+
                        "("+staffId+","+phones[i]+"); ";
                }
                cmd=new MySqlCommand(sql, this.connect);
                cmd.ExecuteNonQuery();
                return "binding success";
            }
            return "null account";
        }
        /// <summary>
        /// 更新资料
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="birthDay"></param>
        /// <param name="companyName"></param>
        /// <param name="branchName"></param>
        /// <param name="departmentName"></param>
        /// <param name="addrs"></param>
        /// <param name="phones"></param>
        /// <returns></returns>
        public string updateInformation(string name, string gender, string birthDay, string companyName, string branchName, string departmentName, List<string> addrs, List<string> phones)
        {
            if (this.account!=null)
            {
                string sql = "";
                int staffId = this.getStaffId();
                sql+="update `MediDB`.`StaffAddr` "+
                    "set `isDelete`='是' "+
                    "where `Staff_id`="+staffId+" and `isDelete`='否'; ";
                sql+="update `MediDB`.`StaffPhone` "+
                    "set `isDelete`='是' "+
                    "where `Staff_id`="+staffId+" and `isDelete`='否'; ";
                MySqlCommand cmd = new MySqlCommand(sql, this.connect);
                cmd.ExecuteNonQuery();
                sql="";
                for (int i = 0; i<addrs.Count; i++)
                {
                    sql+="insert into `MediDB`.`StaffAddr` "+
                        "(`Staff_id`,`addr`) "+
                        "values "+
                        "("+staffId+",'"+addrs[i]+"'); ";
                }
                for (int i = 0; i<phones.Count; i++)
                {
                    sql+="insert into `MediDB`.`StaffPhone` "+
                        "(`Staff_id`,`phoneNum`) "+
                        "values "+
                        "("+staffId+","+phones[i]+"); ";
                }
                cmd=new MySqlCommand(sql, this.connect);
                cmd.ExecuteNonQuery();

                int departmentId = DButils.getDepartmentId(companyName, branchName, departmentName);
                sql="update `MediDB`.`Staff` "+
                    "set `Department_id`="+departmentId+", `name`='"+name+"', `gender`='"+gender+"', `birthDay`='"+birthDay+"'"+
                    "where `Staff_id`="+staffId+"; ";
                cmd=new MySqlCommand(sql, this.connect);
                cmd.ExecuteNonQuery();

                int jurisdictionId = DButils.getJurisdictionId(companyName+"_"+branchName+"_"+departmentName);
                sql="update `MediDB`.`User` "+
                    "set `Staff_id`="+staffId+",`Jurisdiction_id`="+jurisdictionId+" "+
                    "where `MediDB`.`User`.`account`='"+this.account+"'; ";
                cmd=new MySqlCommand(sql, this.connect);
                cmd.ExecuteNonQuery();
                return "update success";
            }

            return "null account";
        }
        public int addShoppingOrders(int clientId)
        {
            string sql = "";
            MySqlCommand cmd;
            MySqlDataReader rdr;
            sql="insert into `MediDB`.`ShoppingOrders` "+
                "(`Staff_id`,`Client_id`,`shoppingDate`)"+
                "values"+
                "('"+this.getStaffId()+"','"+clientId+"',localtime());";
            cmd=new MySqlCommand(sql, this.connect);
            cmd.ExecuteNonQuery();

            sql="select LAST_INSERT_ID() as ShoppingOrders_id;";
            cmd=new MySqlCommand(sql, this.connect);
            rdr=cmd.ExecuteReader();
            rdr.Read();
            int shoppingOrdersId = int.Parse(rdr["ShoppingOrders_id"].ToString());
            rdr.Close();

            return shoppingOrdersId;
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
