﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicWebAPI.DAL
{
    public class ExecuteSp
    {
        public async Task<IEnumerable<object>> ExecuteSpGetData(string connectionString, string storeProcedureName, string commondName)
        {
            var returnObject = new List<dynamic>();
            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(storeProcedureName, sql))
                {                  
                    cmd.CommandType = CommandType.StoredProcedure;                   
                    cmd.Parameters.Add(new SqlParameter("@StatementType",SqlDbType.NVarChar){ Value = commondName });
                   
                    if (cmd.Connection.State != ConnectionState.Open)
                        cmd.Connection.Open();

                    var retObject = new List<dynamic>();
                    using (var dataReader = await cmd.ExecuteReaderAsync())
                    {
                        while (await dataReader.ReadAsync())
                        {
                            var dataRow = new ExpandoObject() as IDictionary<string, object>;
                            for (var iFiled = 0; iFiled < dataReader.FieldCount; iFiled++)
                            {                             
                                dataRow.Add(
                                    dataReader.GetName(iFiled),
                                    dataReader.IsDBNull(iFiled) ? null : dataReader[iFiled] 
                                );
                            }
                            retObject.Add((ExpandoObject)dataRow);
                        }
                    }
                    return retObject;
                }
            }
        }
        public async Task<IEnumerable<object>> ExecuteSpMasterData(string connectionString, string storeProcedureName, string commondName, ExpandoObject exObj)
        {
            var retObject = new List<dynamic>();
            try
            {
                var returnObject = new List<dynamic>();
                using (SqlConnection sql = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(storeProcedureName, sql))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (exObj != null)
                        {
                            foreach (KeyValuePair<string, object> itm in exObj)
                            {
                                if (itm.Key.ToString().ToUpper() != "BlazId".ToUpper())
                                {
                                    if (itm.Value == null)
                                        cmd.Parameters.AddWithValue("@" + itm.Key, itm.Value);
                                    else
                                    {
                                        cmd.Parameters.AddWithValue("@" + itm.Key, itm.Value.ToString());
                                    }
                                }
                            }
                        }
                        cmd.Parameters.AddWithValue("@StatementType", commondName);
                        if (cmd.Connection.State != ConnectionState.Open)
                            cmd.Connection.Open();

                        using (var dataReader = await cmd.ExecuteReaderAsync())
                        {
                            while (await dataReader.ReadAsync())
                            {
                                var dataRow = new ExpandoObject() as IDictionary<string, object>;
                                for (var iFiled = 0; iFiled < dataReader.FieldCount; iFiled++)
                                {                                  
                                    dataRow.Add(
                                        dataReader.GetName(iFiled),
                                        dataReader.IsDBNull(iFiled) ? null : dataReader[iFiled] // use null instead of {}
                                    );
                                }
                                retObject.Add((ExpandoObject)dataRow);
                            }
                        }
                        return retObject;
                    }
                }
            }
            catch (Exception e)
            {
                string y = e.Message;
                return retObject;
            }
        }
    }
}