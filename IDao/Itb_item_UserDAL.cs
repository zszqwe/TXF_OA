﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;

namespace IDao
{
    public interface Itb_item_UserDAL : IBaseDAL<tb_item_User>
    {
        DataTable GetPageList(int page, int pagesize, out int total, string code, string disabled, List<WhereField> listWhere);
        DataTable GetModel(int id);
        void DeleteDepinfo(string id);
        int CheckItemNo(int id, string itemNo);
    }
}
