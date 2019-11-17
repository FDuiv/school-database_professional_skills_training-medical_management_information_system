using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

        static public List<string> getBranchs(string companyName)
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

        static public List<string> getDepartments(string branchName)
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
        static public int getDepartmentId(string companyName,string branchName,string departmentName)
        {
            string sql = "";
            sql="select `MediDB`.`Department`.`Department_id` "+
                "from `MediDB`.`Department` "+
                "where `MediDB`.`Department`.`MedicineSupermarket_id` in "+
                "( "+
                    "select `MediDB`.`MedicineSupermarket`.`MedicineSupermarket_id` "+
                    "from `MediDB`.`MedicineSupermarket` "+
                    "where `MediDB`.`MedicineSupermarket`.`MedicineSupermarketCompany_id` in "+
                    "( "+
                        "select `MediDB`.`MedicineSupermarketCompany`.`MedicineSupermarketCompany_id` "+
                        "from `MediDB`.`MedicineSupermarketCompany` "+
                        "where `MediDB`.`MedicineSupermarketCompany`.`name`='"+companyName+"' "+
                    ") "+
                    "and `MediDB`.`MedicineSupermarket`.`name`='"+branchName+"' "+
                ") "+
                "and `MediDB`.`Department`.`name`='"+departmentName+"'; ";
            MySqlCommand cmd = new MySqlCommand(sql, Program.user.getConnect());
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            int departmentId = int.Parse(rdr["Department_id"].ToString());
            rdr.Close();
            return departmentId;
        }


        static public int getJurisdictionId(string name)
        {
            string sql = "select `MediDB`.`Jurisdiction`.`Jurisdiction_id` " +
                "from `MediDB`.`Jurisdiction` " +
                "where `MediDB`.`Jurisdiction`.`name`='"+name+"';";
            MySqlCommand cmd;
            MySqlDataReader rdr;
            cmd=new MySqlCommand(sql, Program.user.getConnect());
            rdr=cmd.ExecuteReader();
            rdr.Read();
            int jurisdictionId = int.Parse(rdr["Jurisdiction_id"].ToString());
            rdr.Close();
            return jurisdictionId;
        }
        static public int getPurchaseOrdersId(string date,bool isPurchaseDate)
        {
            string sql = "";
            MySqlCommand cmd;
            MySqlDataReader rdr;
            if (isPurchaseDate)
            {
                sql="select `MediDB`.`PurchaseOrders`.`PurchaseOrders_id` from `MediDB`.`PurchaseOrders` where `MediDB`.`PurchaseOrders`.`purchaseDate` = "+date+"; ";
            }
            else
            {
                sql="select `MediDB`.`PurchaseOrders`.`PurchaseOrders_id` from `MediDB`.`PurchaseOrders` where `MediDB`.`PurchaseOrders`.`completDate` = "+date+"; ";
            }
            cmd=new MySqlCommand(sql, Program.user.getConnect());
            rdr=cmd.ExecuteReader();
            rdr.Read();
            int purchaseOrdersId = int.Parse(rdr["PurchaseOrders_id"].ToString());
            rdr.Close();
            return purchaseOrdersId;
        }
        static public string[] getDrugNames(string name="")
        {
           
            List<string> drugNames = new List<string>();
            string sql = "";
            MySqlCommand cmd;
            MySqlDataReader rdr;
            if (name=="")
            {
                sql="select`MediDB`.`Drug`.`name` "+
                    "from `MediDB`.`Drug`;";
            }
            else
            {
                sql="select`MediDB`.`Drug`.`name` "+
                    "from `MediDB`.`Drug` " +
                    "where instr(`MediDB`.`Drug`.`name`,'"+name+"');";
            }
            cmd=new MySqlCommand(sql, Program.user.getConnect());
            rdr=cmd.ExecuteReader();
            while (rdr.Read())
            {
                drugNames.Add(rdr["name"].ToString());
            }
            rdr.Close();
            return drugNames.ToArray();
        }

        static public DataTable getDrugGridView(int id=-1,string name="")
        {
            string sql = "";
            MySqlCommand cmd;
            MySqlDataReader rdr;
            MySqlDataAdapter adapter;
            DataTable newDataTable;
            if ((name==""&&id==-1)||(name!=""&&id!=-1))
            {
                sql="select `MediDB`.`Drug`.`Drug_id` '药品编号', "+
                    "`MediDB`.`Drug`.`name` '药品名',"+
                    "`MediDB`.`Drug`.`unitPrice` '单价',"+
                    "`MediDB`.`Drug`.`approvalNumber` '批准文号',"+
                    "`MediDB`.`Drug`.`attendingFunctions` '功能主治',"+
                    "`MediDB`.`Drug`.`taboo` '禁忌',"+
                    "`MediDB`.`Drug`.`adverseReaction` '不良反应',"+
                    "`MediDB`.`Drug`.`expirationDate` '保质期/月',"+
                    "`MediDB`.`Drug`.`usage` '服用方法'"+
                    "from `MediDB`.`Drug` "+
                    "where `MediDB`.`Drug`.`isDelete`='否';";
            }
            else if(id==-1&&name!="")
            {
                sql="select `MediDB`.`Drug`.`Drug_id` '药品编号', "+
                    "`MediDB`.`Drug`.`name` '药品名',"+
                    "`MediDB`.`Drug`.`unitPrice` '单价',"+
                    "`MediDB`.`Drug`.`approvalNumber` '批准文号',"+
                    "`MediDB`.`Drug`.`attendingFunctions` '功能主治',"+
                    "`MediDB`.`Drug`.`taboo` '禁忌',"+
                    "`MediDB`.`Drug`.`adverseReaction` '不良反应',"+
                    "`MediDB`.`Drug`.`expirationDate` '保质期/月',"+
                    "`MediDB`.`Drug`.`usage` '服用方法'"+
                    "from `MediDB`.`Drug` "+
                    "where `MediDB`.`Drug`.`isDelete`='否'" +
                    "and instr(`MediDB`.`Drug`.`name`,'"+name+"');";
            }
            else if (id!=-1&&name=="")
            {
                sql="select `MediDB`.`Drug`.`Drug_id` '药品编号', "+
                    "`MediDB`.`Drug`.`name` '药品名',"+
                    "`MediDB`.`Drug`.`unitPrice` '单价',"+
                    "`MediDB`.`Drug`.`approvalNumber` '批准文号',"+
                    "`MediDB`.`Drug`.`attendingFunctions` '功能主治',"+
                    "`MediDB`.`Drug`.`taboo` '禁忌',"+
                    "`MediDB`.`Drug`.`adverseReaction` '不良反应',"+
                    "`MediDB`.`Drug`.`expirationDate` '保质期/月',"+
                    "`MediDB`.`Drug`.`usage` '服用方法'"+
                    "from `MediDB`.`Drug` "+
                    "where `MediDB`.`Drug`.`isDelete`='否'"+
                    "and `MediDB`.`Drug`.`Drug_id`="+id+";";
            }
            adapter=new MySqlDataAdapter(sql, Program.user.getConnect());
            newDataTable=new DataTable();
            adapter.Fill(newDataTable);
            return newDataTable;
        }
        static public void deleteDrug(List<int> drugIds)
        {
            string sql = "";
            MySqlCommand cmd;
            string ids = "";
            for (int i = 0; i<drugIds.Count; i++)
            {
                ids+=drugIds[i].ToString();
                if (drugIds.Count!=i+1)
                {
                    ids+=',';
                }
            }
            sql="update `MediDB`.`Drug` " +
                "set `MediDB`.`Drug`.`isDelete`='是' " +
                "where `MediDB`.`Drug`.`Drug_id` in " +
                "("+ids+")";
            cmd=new MySqlCommand(sql, Program.user.getConnect());
            cmd.ExecuteNonQuery();
        }
        static public void addDrug(string name,string approvalNumber,string attendingFunctions,string taboo,string adverseReaction,int expirationDate,string usage,double unitPrice)
        {
            try
            {
                string sql = "";
                MySqlCommand cmd;
                sql="insert into `MediDB`.`Drug` "+
                    "(`name`,`approvalNumber`,`attendingFunctions`,`taboo`,`adverseReaction`,`expirationDate`,`usage`,`unitPrice`) "+
                    "values"+
                    "('"+name+"','"+approvalNumber+"','"+attendingFunctions+"','"+taboo+"','"+adverseReaction+"',"+expirationDate+",'"+usage+"',"+unitPrice+");";
                cmd=new MySqlCommand(sql, Program.user.getConnect());
                cmd.ExecuteNonQuery();
            }
            catch
            { }
        }
        static public void updateDrug(int drugId,string name, string approvalNumber, string attendingFunctions, string taboo, string adverseReaction, int expirationDate, string usage, double unitPrice)
        {
            try
            {
                string sql = "";
                MySqlCommand cmd;
                sql="update `MediDB`.`Drug` "+
                    "set `name`='"+name+"'," +
                    "`approvalNumber` = '"+approvalNumber+"'," +
                    "`attendingFunctions`='"+attendingFunctions+"'," +
                    "`taboo`='"+taboo+"'," +
                    "`adverseReaction`='"+adverseReaction+"'," +
                    "`expirationDate`="+expirationDate+"," +
                    "`usage`='"+usage+"'," +
                    "`unitPrice`="+unitPrice+" "+
                    "where `MediDB`.`Drug`.`Drug_id`="+drugId+";";
                cmd=new MySqlCommand(sql, Program.user.getConnect());
                cmd.ExecuteNonQuery();
            }
            catch
            { }
        }
        static public string[] getPharmaceuticalDistributorCompanys()
        {
            List<string> companyNames = new List<string>();
            string sql = "select `MediDB`.`PharmaceuticalDistributorCompany`.`name` "+
                "from `MediDB`.`PharmaceuticalDistributorCompany` " +
                "where `MediDB`.`PharmaceuticalDistributorCompany`.`isDelete`='否';";
            MySqlCommand cmd;
            MySqlDataReader rdr;
            cmd=new MySqlCommand(sql, Program.user.getConnect());
            rdr=cmd.ExecuteReader();
            while (rdr.Read())
            {
                companyNames.Add(rdr["name"].ToString());
            }
            rdr.Close();
            return companyNames.ToArray();
        }
        static public string[] getPharmaceuticalDistributors(string companyName)
        {
            List<string> distributorNames = new List<string>();
            string sql = "select `MediDB`.`PharmaceuticalDistributor`.`name` "+
                "from `MediDB`.`PharmaceuticalDistributor` " +
                "where `MediDB`.`PharmaceuticalDistributor`.`PharmaceuticalDistributorCompany_id` in " +
                "(" +
                "   select `MediDB`.`PharmaceuticalDistributorCompany`.`PharmaceuticalDistributorCompany_id` from " +
                "   `MediDB`.`PharmaceuticalDistributorCompany` " +
                "   where `MediDB`.`PharmaceuticalDistributorCompany`.`name`='"+companyName+"' " +
                "   and `MediDB`.`PharmaceuticalDistributorCompany`.`isDelete`='否'"+ 
                ") " +
                "and `MediDB`.`PharmaceuticalDistributor`.`isDelete`='否';";
            MySqlCommand cmd;
            MySqlDataReader rdr;
            cmd=new MySqlCommand(sql, Program.user.getConnect());
            rdr=cmd.ExecuteReader();
            while (rdr.Read())
            {
                distributorNames.Add(rdr["name"].ToString());
            }
            rdr.Close();
            return distributorNames.ToArray();
        }
        static public void addPharmaceuticalCompany(string name)
        {
            try
            {
                string sql = "";
                MySqlCommand cmd;
                sql="insert into `MediDB`.`PharmaceuticalDistributorCompany` " +
                    "(name)" +
                    "values" +
                    "('"+name+"');";
                cmd=new MySqlCommand(sql, Program.user.getConnect());
                cmd.ExecuteNonQuery();
            }
            catch
            { }
        }
        static public int getPharmaceuticalCompanyId(string companyName)
        {

            string sql = "";
            MySqlCommand cmd;
            MySqlDataReader rdr;
            sql="select `PharmaceuticalDistributorCompany_id` "+
                "from `MediDB`.`PharmaceuticalDistributorCompany` "+
                "where `MediDB`.`PharmaceuticalDistributorCompany`.`name`='"+companyName+"';";
            cmd=new MySqlCommand(sql, Program.user.getConnect());
            rdr=cmd.ExecuteReader();
            rdr.Read();
            int distributorCompanyId = int.Parse(rdr["PharmaceuticalDistributorCompany_id"].ToString());
            rdr.Close();
            return distributorCompanyId;
        }
        static public int getPharmaceuticalId(string companyName, string distributorName)
        {

            string sql = "";
            MySqlCommand cmd;
            MySqlDataReader rdr;
            sql ="select `MediDB`.`PharmaceuticalDistributor`.`PharmaceuticalDistributor_id` "+
                "from `MediDB`.`PharmaceuticalDistributor` "+
                "where `MediDB`.`PharmaceuticalDistributor`.`PharmaceuticalDistributorCompany_id` in "+
                "("+
                "   select `MediDB`.`PharmaceuticalDistributorCompany`.`PharmaceuticalDistributorCompany_id` from "+
                "   `MediDB`.`PharmaceuticalDistributorCompany` "+
                "   where `MediDB`.`PharmaceuticalDistributorCompany`.`name`='"+companyName+"' "+
                "   and `MediDB`.`PharmaceuticalDistributorCompany`.`isDelete`='否'"+
                ") " +
                "and `MediDB`.`PharmaceuticalDistributor`.`name`='"+distributorName+"' "+
                "and `MediDB`.`PharmaceuticalDistributor`.`isDelete`='否';";
            cmd=new MySqlCommand(sql, Program.user.getConnect());
            rdr=cmd.ExecuteReader();
            rdr.Read();
            int distributorId = int.Parse(rdr["PharmaceuticalDistributor_id"].ToString());
            rdr.Close();
            return distributorId;
        }
        static public void addPharmaceuticalDistributor(string companyName,string distributorName)
        {
            try
            {
                string sql = "";
                MySqlCommand cmd;
                int distributorCompanyId = DButils.getPharmaceuticalCompanyId(companyName);
                sql="insert into `MediDB`.`PharmaceuticalDistributor` "+
                    "(PharmaceuticalDistributorCompany_id,name)"+
                    "values"+
                    "("+distributorCompanyId+",'"+distributorName+"');";
                cmd=new MySqlCommand(sql, Program.user.getConnect());
                cmd.ExecuteNonQuery();
            }
            catch
            { }
        }
        static public void deletePharmaceuticalDistributor(string companyName, string distributorName)
        {
            try
            {
                string sql = "";
                MySqlCommand cmd;
                int distributorCompanyId = DButils.getPharmaceuticalCompanyId(companyName);
                sql="update `MediDB`.`PharmaceuticalDistributor` " +
                    "set `isDelete`='是' " +
                    "where `PharmaceuticalDistributorCompany_id`="+distributorCompanyId+" " +
                    "and `name`='"+distributorName+"';";
                cmd=new MySqlCommand(sql, Program.user.getConnect());
                cmd.ExecuteNonQuery();
            }
            catch
            { }
        }
        static public void deletePharmaceuticalCompany(string companyName)
        {
            try
            {
                string sql = "";
                MySqlCommand cmd;
                int distributorCompanyId = DButils.getPharmaceuticalCompanyId(companyName);
                sql="update `MediDB`.`PharmaceuticalDistributor` "+
                    "set `isDelete`='是' "+
                    "where `PharmaceuticalDistributorCompany_id`="+distributorCompanyId+" ;";
                cmd=new MySqlCommand(sql, Program.user.getConnect());
                cmd.ExecuteNonQuery();
                sql="update `MediDB`.`PharmaceuticalDistributorCompany` "+
                    "set `isDelete`='是' "+
                    "where `name`='"+companyName+"';";
                cmd=new MySqlCommand(sql, Program.user.getConnect());
                cmd.ExecuteNonQuery();
            }
            catch
            { }
        }
        static public DataTable getDistributorDrug(int distributorId,string drugName="")
        {
            string sql = "";
            MySqlCommand cmd;
            MySqlDataReader rdr;
            MySqlDataAdapter adapter;
            DataTable newDataTable;
            if (drugName=="")
            {
                sql="select b.`DistributorDrug_id` as '编号',"+
                    "d.`name` as '经销商公司名',"+
                    "a.`name` as '经销商分部名',"+
                    "c.`name` as '药品名',"+
                    "b.`inventory` as '库存',"+
                    "b.`unitPrice` as '单价',"+
                    "c.`approvalNumber` as '批准文号',"+
                    "c.`attendingFunctions` as '功能主治',"+
                    "c.`taboo` as '禁忌',"+
                    "c.`adverseReaction` as '不良反应',"+
                    "c.`expirationDate` as '保质期/月',"+
                    "c.`usage` as '服用方法'"+
                    "from `MediDB`.`PharmaceuticalDistributor` as a,`MediDB`.`DistributorDrug` as b,`MediDB`.`Drug` as c,`MediDB`.`PharmaceuticalDistributorCompany` as d "+
                    "where a.`PharmaceuticalDistributor_id`=b.`PharmaceuticalDistributor_id`"+
                    "and b.`Drug_id`= c.`Drug_id`"+
                    "and a.`PharmaceuticalDistributorCompany_id`=d.`PharmaceuticalDistributorCompany_id`"+
                    "and a.`isDelete`='否'"+
                    "and b.`isDelete`='否'"+
                    "and c.`isDelete`='否'"+
                    "and d.`isDelete`='否'"+
                    "and a.`PharmaceuticalDistributor_id`="+distributorId+";";
            }
            else
            {
                sql="select b.`DistributorDrug_id` as '编号',"+
                "d.`name` as '经销商公司名',"+
                "a.`name` as '经销商分部名',"+
                "c.`name` as '药品名',"+
                "b.`inventory` as '库存',"+
                "b.`unitPrice` as '单价',"+
                "c.`approvalNumber` as '批准文号',"+
                "c.`attendingFunctions` as '功能主治',"+
                "c.`taboo` as '禁忌',"+
                "c.`adverseReaction` as '不良反应',"+
                "c.`expirationDate` as '保质期/月',"+
                "c.`usage` as '服用方法'"+
                "from `MediDB`.`PharmaceuticalDistributor` as a,`MediDB`.`DistributorDrug` as b,`MediDB`.`Drug` as c,`MediDB`.`PharmaceuticalDistributorCompany` as d "+
                "where a.`PharmaceuticalDistributor_id`=b.`PharmaceuticalDistributor_id`"+
                "and b.`Drug_id`= c.`Drug_id`"+
                "and a.`PharmaceuticalDistributorCompany_id`=d.`PharmaceuticalDistributorCompany_id`"+
                "and a.`isDelete`='否'"+
                "and b.`isDelete`='否'"+
                "and c.`isDelete`='否'"+
                "and d.`isDelete`='否'"+
                "and a.`PharmaceuticalDistributor_id`="+distributorId+" " +
                "and instr(c.`name` ,'"+drugName+"');";
            }
            adapter=new MySqlDataAdapter(sql, Program.user.getConnect());
            newDataTable=new DataTable();
            adapter.Fill(newDataTable);
            return newDataTable;
        }
        static public void addDistributorDrug(int pharmaceuticalDistributorId,int drugId,int inventory,float unitPrice)
        {
            try
            {
                string sql = "";
                MySqlCommand cmd;
                sql="insert into `MediDB`.`DistributorDrug` "+
                    "(`PharmaceuticalDistributor_id`,`Drug_id`,`inventory`,`unitPrice`) "+
                    "values "+
                    "("+pharmaceuticalDistributorId+","+drugId+","+inventory+","+unitPrice+");";
                cmd=new MySqlCommand(sql, Program.user.getConnect());
                cmd.ExecuteNonQuery();
            }
            catch
            { }
        }
        static public DataTable getDistributorDrugNeed(int distributorId, string drugName = "")
        {
            string sql = "";
            MySqlCommand cmd;
            MySqlDataReader rdr;
            MySqlDataAdapter adapter;
            DataTable newDataTable;
            if (drugName=="")
            {
                sql="select `MediDB`.`Drug`.`Drug_id` '药品编号', "+
                     "`MediDB`.`Drug`.`name` '药品名',"+
                     "`MediDB`.`Drug`.`unitPrice` '单价',"+
                     "`MediDB`.`Drug`.`approvalNumber` '批准文号',"+
                     "`MediDB`.`Drug`.`attendingFunctions` '功能主治',"+
                     "`MediDB`.`Drug`.`taboo` '禁忌',"+
                     "`MediDB`.`Drug`.`adverseReaction` '不良反应',"+
                     "`MediDB`.`Drug`.`expirationDate` '保质期/月',"+
                     "`MediDB`.`Drug`.`usage` '服用方法'"+
                     "from `MediDB`.`Drug` "+
                     "where `MediDB`.`Drug`.`isDelete`='否'" +
                     "and `MediDB`.`Drug`.`Drug_id` not in "+
                     "(" +
                     "  select `MediDB`.`DistributorDrug`.`Drug_id`" +
                     "  from `MediDB`.`DistributorDrug` " +
                     "  where `MediDB`.`DistributorDrug`.`PharmaceuticalDistributor_id` = "+distributorId+"" +
                     "  and `MediDB`.`DistributorDrug`.`isDelete`='否'"+
                     ");";
            }
            else
            {
                sql="select `MediDB`.`Drug`.`Drug_id` '药品编号', "+
                    "`MediDB`.`Drug`.`name` '药品名',"+
                    "`MediDB`.`Drug`.`unitPrice` '单价',"+
                    "`MediDB`.`Drug`.`approvalNumber` '批准文号',"+
                    "`MediDB`.`Drug`.`attendingFunctions` '功能主治',"+
                    "`MediDB`.`Drug`.`taboo` '禁忌',"+
                    "`MediDB`.`Drug`.`adverseReaction` '不良反应',"+
                    "`MediDB`.`Drug`.`expirationDate` '保质期/月',"+
                    "`MediDB`.`Drug`.`usage` '服用方法'"+    
                    "from `MediDB`.`Drug` "+
                    "where `MediDB`.`Drug`.`isDelete`='否'"+
                    "and instr(`MediDB`.`Drug`.`name`,'"+drugName+"')" +
                    "and `MediDB`.`Drug`.`Drug_id` not in "+
                    "("+
                    "  select `MediDB`.`DistributorDrug`.`Drug_id`"+
                    "  from `MediDB`.`DistributorDrug` "+
                    "  where `MediDB`.`DistributorDrug`.`PharmaceuticalDistributor_id` = "+distributorId+"" +
                    "  and `MediDB`.`DistributorDrug`.`isDelete`='否'"+
                    ");";
            }
            adapter=new MySqlDataAdapter(sql, Program.user.getConnect());
            newDataTable=new DataTable();
            adapter.Fill(newDataTable);
            return newDataTable;
        }
        static public void deleteDistributorDrug(int distributorDrugId)
        {
            try
            {
                string sql = "";
                MySqlCommand cmd;
                sql="update `MediDB`.`DistributorDrug` "+
                    "set `MediDB`.`DistributorDrug`.`isDelete`='是' "+
                    "where `MediDB`.`DistributorDrug`.`DistributorDrug_id`="+distributorDrugId+";";
                cmd=new MySqlCommand(sql, Program.user.getConnect());
                cmd.ExecuteNonQuery();
            }
            catch { }
        }
        static public List<string> getAllDrugId()
        {
            List<string> allDrugs = new List<string>();
            string sql = "";
            MySqlCommand cmd;
            MySqlDataReader rdr;
            sql="select `MediDB`.`Drug`.`Drug_id` " +
                "from `MediDB`.`Drug`" +
                "where `MediDB`.`Drug`.`isDelete`='否';";
            cmd=new MySqlCommand(sql, Program.user.getConnect());
            rdr=cmd.ExecuteReader();
            while (rdr.Read())
            {
                allDrugs.Add(rdr["Drug_id"].ToString());
            }
            rdr.Close();
            return allDrugs;
        }
        static public DataTable getPurchaseDrug(List<string> drugId,string drugName,bool isNot)
        {
            string sql = "";
            MySqlCommand cmd;
            MySqlDataReader rdr;
            MySqlDataAdapter adapter;
            DataTable newDataTable;
            if (drugName=="")
            {
                if (isNot)
                {
                    sql="select `MediDB`.`Drug`.`Drug_id` '药品编号', "+
                                "`MediDB`.`Drug`.`name` '药品名',"+
                                "`MediDB`.`Drug`.`unitPrice` '单价',"+
                                "`MediDB`.`Drug`.`approvalNumber` '批准文号',"+
                                "`MediDB`.`Drug`.`attendingFunctions` '功能主治',"+
                                "`MediDB`.`Drug`.`taboo` '禁忌',"+
                                "`MediDB`.`Drug`.`adverseReaction` '不良反应',"+
                                "`MediDB`.`Drug`.`expirationDate` '保质期/月',"+
                                "`MediDB`.`Drug`.`usage` '服用方法'"+
                                "from `MediDB`.`Drug` "+
                                "where `MediDB`.`Drug`.`isDelete`='否'"+
                                "and `MediDB`.`Drug`.`Drug_id` not in ("+string.Join(",", drugId.ToArray())+");";
                }
                else
                {
                    sql="select `MediDB`.`Drug`.`Drug_id` '药品编号', "+
                             "`MediDB`.`Drug`.`name` '药品名',"+
                             "`MediDB`.`Drug`.`unitPrice` '单价',"+
                             "`MediDB`.`Drug`.`approvalNumber` '批准文号',"+
                             "`MediDB`.`Drug`.`attendingFunctions` '功能主治',"+
                             "`MediDB`.`Drug`.`taboo` '禁忌',"+
                             "`MediDB`.`Drug`.`adverseReaction` '不良反应',"+
                             "`MediDB`.`Drug`.`expirationDate` '保质期/月',"+
                             "`MediDB`.`Drug`.`usage` '服用方法'"+
                             "from `MediDB`.`Drug` "+
                             "where `MediDB`.`Drug`.`isDelete`='否'"+
                             "and `MediDB`.`Drug`.`Drug_id` in ("+string.Join(",", drugId.ToArray())+");";
                }
            }
            else
            {
                if (isNot)
                {
                    sql="select `MediDB`.`Drug`.`Drug_id` '药品编号', "+
                                "`MediDB`.`Drug`.`name` '药品名',"+
                                "`MediDB`.`Drug`.`unitPrice` '单价',"+
                                "`MediDB`.`Drug`.`approvalNumber` '批准文号',"+
                                "`MediDB`.`Drug`.`attendingFunctions` '功能主治',"+
                                "`MediDB`.`Drug`.`taboo` '禁忌',"+
                                "`MediDB`.`Drug`.`adverseReaction` '不良反应',"+
                                "`MediDB`.`Drug`.`expirationDate` '保质期/月',"+
                                "`MediDB`.`Drug`.`usage` '服用方法'"+
                                "from `MediDB`.`Drug` "+
                                "where `MediDB`.`Drug`.`isDelete`='否'"+
                                "and `MediDB`.`Drug`.`Drug_id` not in ("+string.Join(",", drugId.ToArray())+")"+
                                "and instr(`MediDB`.`Drug`.`name`,'"+drugName+"');";

                }
                else
                {
                    sql="select `MediDB`.`Drug`.`Drug_id` '药品编号', "+
                             "`MediDB`.`Drug`.`name` '药品名',"+
                             "`MediDB`.`Drug`.`unitPrice` '单价',"+
                             "`MediDB`.`Drug`.`approvalNumber` '批准文号',"+
                             "`MediDB`.`Drug`.`attendingFunctions` '功能主治',"+
                             "`MediDB`.`Drug`.`taboo` '禁忌',"+
                             "`MediDB`.`Drug`.`adverseReaction` '不良反应',"+
                             "`MediDB`.`Drug`.`expirationDate` '保质期/月',"+
                             "`MediDB`.`Drug`.`usage` '服用方法'"+
                             "from `MediDB`.`Drug` "+
                             "where `MediDB`.`Drug`.`isDelete`='否'"+
                             "and `MediDB`.`Drug`.`Drug_id` in ("+string.Join(",", drugId.ToArray())+")"+
                             "and instr(`MediDB`.`Drug`.`name`,'"+drugName+"');";
                }
            }
            adapter=new MySqlDataAdapter(sql, Program.user.getConnect());
            newDataTable=new DataTable();
            adapter.Fill(newDataTable);
            return newDataTable;
        }

        static public void addPurchaseOrders(List<string[]> purchaseDrugIds)
        {
            try
            {
                string sql = "";
                MySqlCommand cmd;
                MySqlDataReader rdr;
                sql="insert into `MediDB`.`PurchaseOrders` " +
                    "(`purchaseDate`) " +
                    "values" +
                    "(localtime());";
                cmd=new MySqlCommand(sql, Program.user.getConnect());
                cmd.ExecuteNonQuery();
                sql="select LAST_INSERT_ID() as PurchaseOrders_id;";
                cmd=new MySqlCommand(sql, Program.user.getConnect());
                rdr=cmd.ExecuteReader();
                rdr.Read();
                int purchaseOrdersId = int.Parse(rdr["PurchaseOrders_id"].ToString());
                rdr.Close();
                sql="";
                for (int i = 0; i<purchaseDrugIds.Count; i++)
                {
                    sql+="insert into `MediDB`.`PurchasingList` " +
                        "(`PurchaseOrders_id`,`Drug_id`,`PurchasingNum`) "+
                        "values" +
                        "("+purchaseOrdersId+","+purchaseDrugIds[i][0]+","+purchaseDrugIds[i][1]+");";
                }
               
                cmd=new MySqlCommand(sql, Program.user.getConnect());
                cmd.ExecuteNonQuery();
            }
            catch { }
        }
        static public string[] getRequisitionOrders()
        {
            List<string> requisitionOrders = new List<string>();
            string sql = "select `MediDB`.`PurchaseOrders`.`purchaseDate` "+
                "from `MediDB`.`PurchaseOrders` "+
                "where `MediDB`.`PurchaseOrders`.`isComplete`=0 " +
                "order by `MediDB`.`PurchaseOrders`.`purchaseDate` desc;";
            MySqlCommand cmd;
            MySqlDataReader rdr;
            cmd=new MySqlCommand(sql, Program.user.getConnect());
            rdr=cmd.ExecuteReader();
            while (rdr.Read())
            {
                requisitionOrders.Add(rdr["purchaseDate"].ToString());
            }
            rdr.Close();
            return requisitionOrders.ToArray();
        }
        static public int getRequisitionOrderId(string date,bool isPurchaseDate)
        {
            string sql = "";
            MySqlCommand cmd;
            MySqlDataReader rdr;
            if (isPurchaseDate)
            {
                sql="select `MediDB`.`PurchaseOrders`.`PurchaseOrders_id` "+
                    "from `MediDB`.`PurchaseOrders` "+
                    "where `MediDB`.`PurchaseOrders`.`purchaseDate`='"+date+"';";
            }
            else
            {
                sql="select `MediDB`.`PurchaseOrders`.`PurchaseOrders_id` "+
                    "from `MediDB`.`PurchaseOrders` "+
                    "where `MediDB`.`PurchaseOrders`.`completDate`='"+date+"';";
            }
            cmd=new MySqlCommand(sql, Program.user.getConnect());
            rdr=cmd.ExecuteReader();
            rdr.Read();
            int requisitionOrderId = int.Parse(rdr["PurchaseOrders_id"].ToString());
            rdr.Close();
            return requisitionOrderId;
        }
        static public DataTable getPurchasingList(int requisitionOrderId,bool isComplete)
        {
            string sql = "";
            MySqlDataAdapter adapter;
            DataTable newDataTable;
            if (isComplete)
            {
                sql="select b.`name` as '药名',"+
                   "c.`name` as '提供商',"+
                   "a.`PurchasingNum` as '采购数量'"+
                   "from `MediDB`.`PurchasingList` as a, "+
                   "`MediDB`.`Drug` as b, "+
                   "`MediDB`.PharmaceuticalDistributor as c "+
                   "where a.`Drug_id`=b.`Drug_id`"+
                   "and a.`PharmaceuticalDistributor_id`=c.`PharmaceuticalDistributor_id`"+
                   "and a.`isDelete`='否'"+
                   "and a.`PurchaseOrders_id`="+requisitionOrderId+";";
            }
            else
            {
                sql="select `a`.`PurchasingList_id` as '编号',"+
                       "`b`.`Drug_id` as '药品编号',"+
                       "b.`name` as '药名',"+
                       "a.`PurchasingNum` as '采购数量'"+
                       "from `MediDB`.`PurchasingList` as a, `MediDB`.`Drug` as b "+
                       "where a.`Drug_id`=b.`Drug_id`"+
                       "and a.`isDelete`='否'"+
                       "and a.`PharmaceuticalDistributor_id` is null "+
                       "and a.`PurchaseOrders_id`="+requisitionOrderId+";";
               
            }
            adapter=new MySqlDataAdapter(sql, Program.user.getConnect());
            newDataTable=new DataTable();
            adapter.Fill(newDataTable);
            return newDataTable;
        }
        static public string[] getDistributorWithDrug(int drugId)
        {
            List<string> distributorNames = new List<string>();
            string sql = "select `MediDB`.`PharmaceuticalDistributor`.`name` " +
                "from `MediDB`.`PharmaceuticalDistributor`" +
                "where `MediDB`.`PharmaceuticalDistributor`.`PharmaceuticalDistributor_id` in " +
                "("+
                "   select `MediDB`.`DistributorDrug`.`PharmaceuticalDistributor_id` " +
                "   from `MediDB`.`DistributorDrug` " +
                "   where `MediDB`.`DistributorDrug`.`Drug_id` = "+drugId+"" +
                ");";
            MySqlCommand cmd;
            MySqlDataReader rdr;
            cmd=new MySqlCommand(sql, Program.user.getConnect());
            rdr=cmd.ExecuteReader();
            while (rdr.Read())
            {
                distributorNames.Add(rdr["name"].ToString());
            }
            rdr.Close();
            return distributorNames.ToArray();
        }
        static public void updateDistributorDrug(int purchasingListId,int pharmaceuticalDistributorId)
        {
            MySqlCommand cmd;
            MySqlDataReader rdr;
            string sql= "update `MediDB`.`PurchasingList` " +
                "set `MediDB`.`PurchasingList`.`PharmaceuticalDistributor_id`="+pharmaceuticalDistributorId+" " +
                "where `MediDB`.`PurchasingList`.`PurchasingList_id`="+purchasingListId+";";
            cmd=new MySqlCommand(sql, Program.user.getConnect());
            cmd.ExecuteNonQuery();
        }
        static public int getDistributorId(string name)
        {
            string sql = "select `MediDB`.`PharmaceuticalDistributor`.`PharmaceuticalDistributor_id` "+
                "from `MediDB`.`PharmaceuticalDistributor` " +
                "where `MediDB`.`PharmaceuticalDistributor`.`name` ='"+name+"';";
            MySqlCommand cmd;
            MySqlDataReader rdr;
            cmd=new MySqlCommand(sql, Program.user.getConnect());
            rdr=cmd.ExecuteReader();
            rdr.Read();
            int distributorId=int.Parse(rdr["PharmaceuticalDistributor_id"].ToString());
            
            rdr.Close();
            return distributorId;
        }
        static public void completePurchase(int purchaseOrdersId)
        {
            MySqlCommand cmd;
            MySqlDataReader rdr;
            string sql = "update `MediDB`.`PurchaseOrders` "+
                "set `MediDB`.`PurchaseOrders`.`isComplete`=1, " +
                "`MediDB`.`PurchaseOrders`.`completDate`= localtime() "+
                "where `MediDB`.`PurchaseOrders`.`PurchaseOrders_id`="+purchaseOrdersId+";";
            cmd=new MySqlCommand(sql, Program.user.getConnect());
            cmd.ExecuteNonQuery();
        }
        /*
select `a`.`Drug_id` '药品编号',
`a`.`name` '药品名',
`a`.`approvalNumber` '批准文号',
`a`.`attendingFunctions` '功能主治',
`a`.`taboo` '禁忌',
`a`.`adverseReaction` '不良反应',
`a`.`expirationDate` '保质期/月',
`a`.`usage` '服用方法',
`b`.`PurchasingNum` '采购数量',
`b`.`unitPrice` '单价',
`a`.`isDelete` '药品是否被删除'
from `MediDB`.`Drug` as `a`,
	(select `MediDB`.`PurchasingList`.`PurchasingList_id`, 
    `MediDB`.`PurchasingList`.`Drug_id`,
    `MediDB`.`PurchasingList`.`PurchasingNum`,
    `MediDB`.`PurchasingList`.`unitPrice`
	from `MediDB`.`PurchasingList` 
	where `MediDB`.`PurchasingList`.`isDelete` = 0
	and `MediDB`.`PurchasingList`.`PurchaseOrders_id` in 
	(
		select `MediDB`.`PurchaseOrders`.`PurchaseOrders_id`
		from `MediDB`.`PurchaseOrders`
		where `MediDB`.`PurchaseOrders`.`purchaseDate`='2019-11-05 18:33:30'
	)) as `b`
where `a`.`Drug_id`= `b`.`Drug_id`;
         */
    }
}
