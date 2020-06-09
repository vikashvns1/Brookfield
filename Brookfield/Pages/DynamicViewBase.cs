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
        public IDynamicAPIService dynamicAPIService { get; set; }
        [Inject]
        public NavigationManager nav { get; set; }
        [Parameter]
        public string xml { get; set; }
        public List<Param> paramList { get; set; }
        public string[] value { get; set; }
        public string connString { get; set; }
        public string StoreProcedure { get; set; }
        public string Tital { get; set; }
        private ObservableCollection<ExpandoObject> collection;

        public ObservableCollection<ExpandoObject> DynamicObject
        {
            get { return collection; }
            set { this.collection = value;}
        }

        private DataTable dataTable;

        public DataTable dtEmployeeList
        {
            get { return dataTable; }
            set { this.dataTable = value; }
        }

        protected override async Task OnInitializedAsync()
        {
            ReadQueryString();
            value = new string[paramList.Count];
            //string jsonstring = string.Empty;
            ////jsonstring = (await dynamicAPIService.GetAppConfiguration(connString, StoreProcedure, "Select"));
            //jsonstring = await dynamicAPIService.GetDatabyParam(paramList, connString, StoreProcedure, "Select");
            //DynamicObject = JsonConvert.DeserializeObject<ObservableCollection<ExpandoObject>>(jsonstring);
            //dtEmployeeList = (DataTable)JsonConvert.DeserializeObject(jsonstring, (typeof(DataTable)));
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
                string jsonstring = string.Empty;

                if (args.Data.First().Value == null)
                {
                    jsonstring = await dynamicAPIService.InsertData(args.Data, connString, StoreProcedure, "Insert");
                    List<ExpandoObject> exObj = new List<ExpandoObject>();
                    exObj = JsonConvert.DeserializeObject<List<ExpandoObject>>(jsonstring);
                    DynamicObject.Add(exObj[0]);
                    //await DefaultGrid.DeleteRow(args.Data);
                    //DefaultGrid.Refresh();
                }
                else
                {
                    jsonstring = await dynamicAPIService.InsertData(args.Data, connString, StoreProcedure, "Update");
                    //StateHasChanged();
                }
                await DefaultGrid.CloseEdit();               
            }
            else if (args.RequestType == Syncfusion.Blazor.Grids.Action.Delete)
            {
               await dynamicAPIService.InsertData(args.Data, connString, StoreProcedure, "Delete");
               DynamicObject.Remove(args.Data);
               //await DefaultGrid.DeleteRow(args.Data);

                //StateHasChanged();
                //DefaultGrid.Refresh();
            }
        }

        public void ReadQueryString()
        {
            System.Uri uri;
            uri = nav.ToAbsoluteUri(nav.Uri);
            if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("ConnString", out var conn))
            {
                connString = conn;
            }

            if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("Tital", out var tital))
            {
                Tital = tital;
            }

            if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("xml", out var qxml))
            {
                xml = qxml;
                XmlDocument xdoc = new XmlDocument();
                xdoc.LoadXml(xml.ToString());

                XmlElement root = xdoc.DocumentElement;
                StoreProcedure = root.SelectSingleNode("Sp").InnerText.ToString();

                XmlNodeList Xparam = xdoc.GetElementsByTagName("Param");
                List<Param> listParam = new List<Param>();

                foreach (XmlNode n in Xparam)
                {
                    if (n is XmlElement)
                    {
                        Param v = new Param();
                        v.Control = (n as XmlElement).GetAttribute("Control").ToString();
                        v.Label = (n as XmlElement).GetAttribute("Label").ToString();
                        v.Type = (n as XmlElement).GetAttribute("type").ToString();
                        //v.Type = null;
                        listParam.Add(v);
                    }
                }

                paramList = listParam;
            }
        }
    }
}
