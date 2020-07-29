using DynamicWebAPI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessHandler;

namespace DynamicWebAPI.DAL
{
    public class ExecuteSp
    {
        public async Task<IEnumerable<object>> ExecuteSpGetData(string connectionString, string storeProcedureName, string commondName, string ProviderName)
        {

            DBManager dbManager = new DBManager(connectionString, ProviderName);
            var returnObject = new List<dynamic>();
            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(storeProcedureName, sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@StatementType", SqlDbType.NVarChar) { Value = commondName });

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
        public async Task<OutputData> ExecuteSpMasterData(string connectionString, string storeProcedureName, string commondName, ExpandoObject exObj)
        {
            OutputData _outPut = new OutputData();
            var retObject = new List<ExpandoObject>();
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
                        cmd.Parameters.Add("@Msg", SqlDbType.NVarChar, 50);
                        cmd.Parameters["@Msg"].Direction = ParameterDirection.Output;

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

                        _outPut.Msg = (string)cmd.Parameters["@Msg"].Value.ToString();
                        _outPut.DynamicData = retObject;
                        return _outPut;
                    }
                }
            }
            catch (Exception e)
            {
                string y = e.Message;
                return _outPut;
            }
        }
        public async Task<OutputData> GetDataSpMasterByParam(string connectionString, string storeProcedureName, string commondName, List<Param> exObj)
        {
            OutputData _outPut = new OutputData();
            var retObject = new List<ExpandoObject>();
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
                            foreach (Param itm in exObj)
                            {
                                cmd.Parameters.AddWithValue("@" + itm.Label, itm.Value);
                            }
                        }
                        cmd.Parameters.AddWithValue("@StatementType", commondName);
                        cmd.Parameters.Add("@Msg", SqlDbType.NVarChar, 50);
                        cmd.Parameters["@Msg"].Direction = ParameterDirection.Output;
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

                        _outPut.Msg = (string)cmd.Parameters["@Msg"].Value.ToString();

                        _outPut.DynamicData = retObject;
                        return _outPut;
                    }
                }
            }
            catch (Exception e)
            {
                string y = e.Message;
                return _outPut;
            }
        }

        public async Task<IEnumerable<object>> ExecuteSpGetData1(string connectionString, string storeProcedureName, string commondName, string ProviderName)
        {
            var retObject = new List<dynamic>();
            DBManager dbManager = new DBManager(connectionString, ProviderName);
            var parameters = new List<IDbDataParameter>();
            parameters.Add(dbManager.CreateParameter("@StatementType", commondName, DbType.String));
            IDbConnection connection = null;
            var dataReader = dbManager.GetDataReader(storeProcedureName, CommandType.StoredProcedure, parameters.ToArray(), out connection);
            try
            {
                while (dataReader.Read())
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

                return retObject;
            }
            catch (Exception)
            {
                return retObject;
            }
            finally
            {
                dataReader.Close();
                dbManager.CloseConnection(connection);
            }
        }

        public async Task<OutputData> ExecuteSpMasterData1(string connectionString, string storeProcedureName, string commondName, string ProviderName, ExpandoObject exObj)
        {
            OutputData _outPut = new OutputData();
            var retObject = new List<ExpandoObject>();

            DBManager dbManager = new DBManager(connectionString, ProviderName);
            var parameters = new List<IDbDataParameter>();
            if (exObj != null)
            {
                foreach (KeyValuePair<string, object> itm in exObj)
                {
                    if (itm.Key.ToString().ToUpper() != "BlazId".ToUpper())
                    {
                        if (itm.Value == null)
                            parameters.Add(dbManager.CreateParameter("@" + itm.Key, itm.Value, DbType.String));
                        else
                        {
                            parameters.Add(dbManager.CreateParameter("@" + itm.Key, itm.Value.ToString(), DbType.String));
                        }
                    }
                }
            }

            parameters.Add(dbManager.CreateParameter("@StatementType", commondName, DbType.String));
            parameters.Add(dbManager.CreateParameter("@Msg", 50, _outPut.Msg, DbType.String, ParameterDirection.Output));

            IDbConnection connection = null;
            var dataReader = dbManager.GetDataReader(storeProcedureName, CommandType.StoredProcedure, parameters.ToArray(), out connection);
            try
            {
                while (dataReader.Read())
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

                _outPut.DynamicData = retObject;
                return _outPut;
            }
            catch (Exception e)
            {
                var v = e.Message;
                return _outPut;
            }
            finally
            {
                dataReader.Close();
                _outPut.Msg = parameters.Where(a => a.ParameterName == "@Msg").FirstOrDefault().Value.ToString();
                dbManager.CloseConnection(connection);
            }
        }

        public async Task<OutputData> GetDataSpMasterByParam1(string connectionString, string storeProcedureName, string commondName, string ProviderName, List<Param> exObj)
        {
            OutputData _outPut = new OutputData();
            var retObject = new List<ExpandoObject>();

            DBManager dbManager = new DBManager(connectionString, ProviderName);
            var parameters = new List<IDbDataParameter>();
            if (exObj != null)
            {
                foreach (Param itm in exObj)
                {
                    parameters.Add(dbManager.CreateParameter("@" + itm.Label, itm.Value, DbType.String));
                }
            }

            parameters.Add(dbManager.CreateParameter("@StatementType", commondName, DbType.String));
            parameters.Add(dbManager.CreateParameter("@Msg", 50, _outPut.Msg, DbType.String, ParameterDirection.Output));

            IDbConnection connection = null;
            var dataReader = dbManager.GetDataReader(storeProcedureName, CommandType.StoredProcedure, parameters.ToArray(), out connection);
            try
            {
                while (dataReader.Read())
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

                _outPut.DynamicData = retObject;
                return _outPut;
            }
            catch (Exception e)
            {
                var v = e.Message;
                return _outPut;
            }
            finally
            {
                dataReader.Close();
                _outPut.Msg = parameters.Where(a => a.ParameterName == "@Msg").FirstOrDefault().Value.ToString();
                dbManager.CloseConnection(connection);
            }
        }
    }
}
