using Brookfield.Models;
using Brookfield.Services;
using Brookfield.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Grids;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using System.Xml;

namespace Brookfield.Pages
{
    public class DynamicViewBase : BaseComponent
    {
        [Inject]
        public IDynamicAPIService DynamicAPIService { get; set; }
        [Inject]
        public NavigationManager Nav { get; set; }
        [Parameter]
        public string Xml { get; set; }
        public List<Param> ParamList { get; set; }
        public List<Column> ColumnList { get; set; }
        public string ConnString { get; set; }
        public string StoreProcedure { get; set; }
        public string Tital { get; set; }
        private ObservableCollection<ExpandoObject> collection;

        public ObservableCollection<ExpandoObject> DynamicObject
        {
            get { return collection; }
            set { this.collection = value; }
        }

        private DataTable dataTable;

        public DataTable DtEmployeeList
        {
            get { return dataTable; }
            set { this.dataTable = value; }
        }

        protected override async Task OnInitializedAsync()
        {
            ReadQueryString();
            if (ParamList.Count == 0)
            {
                string jsonstring = (await DynamicAPIService.GetAppConfiguration(ConnString, StoreProcedure, "Select"));
                DynamicObject = JsonConvert.DeserializeObject<ObservableCollection<ExpandoObject>>(jsonstring);
                DtEmployeeList = (DataTable)JsonConvert.DeserializeObject(jsonstring, (typeof(DataTable)));
            }
        }

        public SfGrid<ExpandoObject> DefaultGrid;
        public void ExcelExport()
        {
            ExcelExportProperties ExportProperties = new ExcelExportProperties();
            ExportProperties.ExportType = ExportType.CurrentPage;
            DefaultGrid.ExcelExport(ExportProperties);
        }

        public void PdfExport()
        {
            PdfExportProperties ExportProperties = new PdfExportProperties();
            ExportProperties.FileName = "test.pdf";
            DefaultGrid.PdfExport(ExportProperties);
        }

        public async Task ActionBeginAsync(ActionEventArgs<ExpandoObject> args)
        {
            if (args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
            {
                //string jsonstring = string.Empty;

                if (args.Data.First().Value == null)
                {
                    string jsonstring = await DynamicAPIService.InsertData(args.Data, ConnString, StoreProcedure, "Insert");
                    List<ExpandoObject> exObj = JsonConvert.DeserializeObject<List<ExpandoObject>>(jsonstring);
                    DynamicObject.Add(exObj[0]);

                }
                else
                {
                    await DynamicAPIService.InsertData(args.Data, ConnString, StoreProcedure, "Update");
                    //StateHasChanged();
                }
                await DefaultGrid.CloseEdit();
            }
            else if (args.RequestType == Syncfusion.Blazor.Grids.Action.Delete)
            {
                await DynamicAPIService.InsertData(args.Data, ConnString, StoreProcedure, "Delete");
                DynamicObject.Remove(args.Data);
            }
        }

        public void ReadQueryString()
        {
            System.Uri uri;
            uri = Nav.ToAbsoluteUri(Nav.Uri);
            if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("ConnString", out var conn))
            {
                ConnString = conn;
            }

            if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("Tital", out var tital))
            {
                Tital = tital;
            }

            if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("xml", out var qxml))
            {
                Xml = qxml;
                XmlDocument xdoc = new XmlDocument();
                xdoc.LoadXml(Xml.ToString());

                XmlElement root = xdoc.DocumentElement;
                StoreProcedure = root.SelectSingleNode("Sp").InnerText.ToString();

                XmlNodeList Xparam = xdoc.GetElementsByTagName("Param");
                List<Param> listParam = new List<Param>();

                foreach (XmlNode n in Xparam)
                {
                    if (n is XmlElement)
                    {
                        listParam.Add(new Param
                        {
                            Control = (n as XmlElement).GetAttribute("Control").ToString(),
                            Label = (n as XmlElement).GetAttribute("Label").ToString(),
                            Type = (n as XmlElement).GetAttribute("type").ToString(),
                            Sp = (n as XmlElement).GetAttribute("Sp").ToString(),
                            Key = (n as XmlElement).GetAttribute("Key").ToString(),
                            KeyValue = (n as XmlElement).GetAttribute("KeyValue").ToString(),
                        });
                    }
                }

                ParamList = listParam;

                XmlNodeList XNonEditable = xdoc.GetElementsByTagName("Column");
                List<Column> listNonEditable = new List<Column>();
                foreach (XmlNode c in XNonEditable)
                {
                    if (c is XmlElement)
                    {
                        listNonEditable.Add(new Column
                        {
                            Name = (c as XmlElement).GetAttribute("Name").ToString(),
                            Edit = Convert.ToBoolean((c as XmlElement).GetAttribute("Edit").ToString()),
                            Filter = Convert.ToBoolean((c as XmlElement).GetAttribute("Filter").ToString()),
                        });
                    }
                }
                ColumnList = listNonEditable;
            }
        }
    }
}
