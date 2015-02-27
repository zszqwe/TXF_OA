﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;

namespace IBLL
{
    public interface Itb_sys_ModuleBLL : IBaseBLL<tb_sys_Module>
    {
        void SaveModule(tb_sys_Module module, string code);
        void UpdateNodeState(string state, int id);
        void DeleteModule(string code);
        /// <summary>
        /// 获取分页数据
        /// </summary>
        DataTable GetPageList(int page, int pagesize, out int total, string code, List<WhereField> listWhere);

    }
}
