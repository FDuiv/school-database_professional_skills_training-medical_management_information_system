﻿using MySql.Data.MySqlClient;
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
                    "`MediDB`.`Drug`.`approvalNumber` '批准文号',"+
                    "`MediDB`.`Drug`.`attendingFunctions` '功能主治',"+
                    "`MediDB`.`Drug`.`taboo` '禁忌',"+
                    "`MediDB`.`Drug`.`adverseReaction` '不良反应',"+
                    "`MediDB`.`Drug`.`expirationDate` '保质期/月',"+
                    "`MediDB`.`Drug`.`usage` '服用方法',"+
                    "`MediDB`.`Drug`.`unitPrice` '单价'"+
                    "from `MediDB`.`Drug` "+
                    "where `MediDB`.`Drug`.`isDelete`='否';";
            }
            else if(id==-1&&name!="")
            {
                sql="select `MediDB`.`Drug`.`Drug_id` '药品编号', "+
                    "`MediDB`.`Drug`.`name` '药品名',"+
                    "`MediDB`.`Drug`.`approvalNumber` '批准文号',"+
                    "`MediDB`.`Drug`.`attendingFunctions` '功能主治',"+
                    "`MediDB`.`Drug`.`taboo` '禁忌',"+
                    "`MediDB`.`Drug`.`adverseReaction` '不良反应',"+
                    "`MediDB`.`Drug`.`expirationDate` '保质期/月',"+
                    "`MediDB`.`Drug`.`usage` '服用方法',"+
                    "`MediDB`.`Drug`.`unitPrice` '单价'"+
                    "from `MediDB`.`Drug` "+
                    "where `MediDB`.`Drug`.`isDelete`='否'" +
                    "and instr(`MediDB`.`Drug`.`name`,'"+name+"');";
            }
            else if (id!=-1&&name=="")
            {
                sql="select `MediDB`.`Drug`.`Drug_id` '药品编号', "+
                    "`MediDB`.`Drug`.`name` '药品名',"+
                    "`MediDB`.`Drug`.`approvalNumber` '批准文号',"+
                    "`MediDB`.`Drug`.`attendingFunctions` '功能主治',"+
                    "`MediDB`.`Drug`.`taboo` '禁忌',"+
                    "`MediDB`.`Drug`.`adverseReaction` '不良反应',"+
                    "`MediDB`.`Drug`.`expirationDate` '保质期/月',"+
                    "`MediDB`.`Drug`.`usage` '服用方法',"+
                    "`MediDB`.`Drug`.`unitPrice` '单价'"+
                    "from `MediDB`.`Drug` "+
                    "where `MediDB`.`Drug`.`isDelete`='否'"+
                    "and `MediDB`.`Drug`.`Drug_id`="+id+";";
            }
            adapter=new MySqlDataAdapter(sql, Program.user.getConnect());
            newDataTable=new DataTable();
            adapter.Fill(newDataTable);
            newDataTable.Rows[0].ToString();
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
