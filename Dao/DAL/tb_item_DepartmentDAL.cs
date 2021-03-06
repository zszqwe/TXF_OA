﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using IDao;
using System.Data;

namespace Dao
{
    public class tb_item_DepartmentDAL : BaseDAL<tb_item_Department>, Itb_item_DepartmentDAL
    {
        public DataTable GetPageList(int page, int pagesize, out int total, string code, string isDelete, string where)
        {
            try
            {
                if (!string.IsNullOrEmpty(code))
                    where += " AND LEFT(ItemNo," + code.Length + ")='" + code + "'";
                if (!string.IsNullOrEmpty(isDelete))
                    where += " AND IsDelete=0";
                string sql = "SELECT COUNT(1)CNT FROM (SELECT a.ID,a.ItemNo,a.ItemName,b.ItemName Manager,a.Phone,a.Fax,a.IsDelete FROM dbo.tb_item_Department a"
                           + "LEFT JOIN dbo.tb_item_User b ON b.ID=a.EmpID) AS t WHERE " + where + "";
                total = (int)DBHelper.SingleQuery(sql);
                sql = string.Format(@"SELECT TOP({0})* FROM(SELECT ROW_NUMBER()OVER(ORDER BY ItemNo)RowNo,* FROM 
                                (SELECT a.ID,a.ItemID,a.ItemNo,a.ItemName,b.ItemName Manager,a.Phone,a.Fax,a.IsDelete 
                                 FROM dbo.Com_Department a LEFT JOIN dbo.Com_Emp b ON b.ID=a.EmpID) AS t WHERE {1}) 
                                 as tt WHERE RowNo>{2}", pagesize, where, (page - 1) * pagesize);
                return DBHelper.Query(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
