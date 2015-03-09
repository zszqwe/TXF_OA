﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDao;
using Dao;
using Ninject;
using Ninject.Modules;

namespace TXF.IOC
{
    public class DaoModule : NinjectModule
    {
        public override void Load()
        {
            Bind<Itb_sys_ModuleDAL>().To<tb_sys_ModuleDAL>().InSingletonScope();
            Bind<Itb_sys_ItemDAL>().To<tb_sys_ItemDAL>().InSingletonScope();
            Bind<Itb_item_CompanyDAL>().To<tb_item_CompanyDAL>().InSingletonScope();
            Bind<Itb_item_DepartmentDAL>().To<tb_item_DepartmentDAL>().InSingletonScope();
            Bind<Itb_item_UserDAL>().To<tb_item_UserDAL>().InSingletonScope();
            Bind<Itb_item_RoleDAL>().To<tb_item_RoleDAL>().InSingletonScope();
        }
    }
}
