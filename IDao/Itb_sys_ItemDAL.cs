﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;

namespace IDao
{
    public interface Itb_sys_ItemDAL : IBaseDAL<tb_sys_Item>
    {
        DataTable SelectTreeList(string url);
        void IsValidNode(tb_sys_Item item);
        void SaveItemInfo(tb_sys_Item entity, string preCode);
        void UpdateNodeState(int id, string state);
        void DeleteByNodeCode(string code);
    }
}
