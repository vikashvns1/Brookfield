﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Brookfield.Shared
{
    public class ConvertJsonStringToDataTable
    {
        public DataTable JsonStringToDataTable(string jsonString)
        {
            DataTable dt = new DataTable();
            string[] jsonStringArray = Regex.Split(jsonString.Replace("[", "").Replace("]", ""), "},{");
            List<string> ColumnsName = new List<string>();
            foreach (string jSA in jsonStringArray)
            {
                string[] jsonStringData = Regex.Split(jSA.Replace("{", "").Replace("}", ""), ",");
                foreach (string ColumnsNameData in jsonStringData)
                {
                    try
                    {
                        int idx = ColumnsNameData.IndexOf(":");
                        string ColumnsNameString = ColumnsNameData.Substring(0, idx - 1).Replace("\"", "");
                        if (!ColumnsName.Contains(ColumnsNameString))
                        {
                            ColumnsName.Add(ColumnsNameString);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(string.Format("Error Parsing Column Name : {0}", ColumnsNameData));
                    }
                }
                break;
            }
            foreach (string AddColumnName in ColumnsName)
            {
                dt.Columns.Add(AddColumnName);
            }
            foreach (string jSA in jsonStringArray)
            {
                string[] RowData = Regex.Split(jSA.Replace("{", "").Replace("}", ""), ",");
                DataRow nr = dt.NewRow();
                foreach (string rowData in RowData)
                {
                    try
                    {
                        int idx = rowData.IndexOf(":");
                        string RowColumns = rowData.Substring(0, idx - 1).Replace("\"", "");
                        string RowDataString = rowData.Substring(idx + 1).Replace("\"", "");
                        nr[RowColumns] = RowDataString;
                    }
                    catch (Exception ex)
                    {
                        continue;
                    }
                }
                dt.Rows.Add(nr);
            }
            return dt;
        }

        public ObservableCollection<System.Dynamic.ExpandoObject> GetExpandoList(DataTable dt)
        {
            // Rows of dynamic object
            ObservableCollection<System.Dynamic.ExpandoObject> lstObj = new ObservableCollection<System.Dynamic.ExpandoObject>();
            foreach (DataRow row in dt.Rows)
            {
                System.Dynamic.ExpandoObject e = new System.Dynamic.ExpandoObject();
                foreach (DataColumn col in dt.Columns)
                    e.TryAdd(col.ColumnName, row.ItemArray[col.Ordinal]);
                lstObj.Add(e);
            }
            return lstObj;
        }

        public ExpandoObject GetExpando(DataTable dt)
        {
            DataRow row = dt.Rows[0];
            System.Dynamic.ExpandoObject e = new System.Dynamic.ExpandoObject();
            foreach (DataColumn col in dt.Columns)
                e.TryAdd(col.ColumnName, row.ItemArray[col.Ordinal]);
            return e;
        }
    }
}
