﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using LavaCar_DAL.Data_Base;
using LavaCar_BLL.Data_Base;

namespace LavaCar_BLL.Cat_Mant
{
    public class cls_Centro_de_Lavado_BLL
    {
        public DataTable Listar_LavadoOctopus(ref string sMsjError)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();
            Obj_DAL.sTableName = "Octopus";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Listar_LavadoOctopus"].ToString().Trim();
            Obj_BLL.Execute_DataAdapter(ref Obj_DAL);

            if (Obj_DAL.sMsjError == string.Empty)
            {
                sMsjError = string.Empty;
                return Obj_DAL.Obj_DSet.Tables[0];
            }
            else
            {
                sMsjError = Obj_DAL.sMsjError;
                return null;
            }

        }
    }
}
