using Brookfield.Models;
using Brookfield.Services;
using Brookfield.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Popups;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
        public string Action { get; set; }
        public string Tital { get; set; }
        public SfDialog DlgRef;
        public string PopHeadarMsg { get; set; }
        public string PopMsg { get; set; }
        public bool IsInitialRender = false;
        public bool IsInitialRenderGrid = false;
        public bool IsInitialRenderChart = false;

        public string RowsCount = "0";
        public string ColumnCount = "0";
        private ObservableCollection<ExpandoObject> collection;

        public ObservableCollection<ExpandoObject> DynamicObject
        {          
            get { return collection; }
            set
            {
                this.collection = value;
                NotifyPropertyChanged("DynamicObject");
            }
        }

        private DataTable dataTable;

        public DataTable DtEmployeeList
        {
            get { return dataTable; }
            set { this.dataTable = value; }
        }

        public ObservableCollection<ExpandoObject> ChartDataObj;
        public DataTable ChartdataTable;
        public ChartAttributes AttributesOfChart { get; set; } = new ChartAttributes();


        protected override async Task OnInitializedAsync()
        {
            ReadQueryString();
            if (ParamList.Count == 0)
            {
                string jsonstring = (await DynamicAPIService.GetAppConfiguration(ConnString, StoreProcedure, "Select"));
                DynamicObject = JsonConvert.DeserializeObject<ObservableCollection<ExpandoObject>>(jsonstring);
                if (IsInitialRenderGrid == false)
                {
                    IsInitialRenderGrid = true;
                    DtEmployeeList = (DataTable)JsonConvert.DeserializeObject(jsonstring, (typeof(DataTable)));
                    RowsCount = DynamicObject.Count.ToString();
                }
                ColumnCount = DtEmployeeList.Columns.Count.ToString();

                ///Chart
                if (AttributesOfChart!= null)
                {
                    if (IsInitialRenderChart == false)
                    {
                        IsInitialRenderChart = true;
                        string jsonChartstring = (await DynamicAPIService.GetAppConfiguration(ConnString, AttributesOfChart.SpName, "Select"));
                        ChartDataObj = JsonConvert.DeserializeObject<ObservableCollection<ExpandoObject>>(jsonChartstring);
                        //ChartdataTable = (DataTable)JsonConvert.DeserializeObject(jsonChartstring, (typeof(DataTable)));
                    }
                }
            }
        }

        public SfGrid<ExpandoObject> DefaultGrid;

        public void ToolbarClickHandler(Syncfusion.Blazor.Navigations.ClickEventArgs Args)
        {
            if (Args.Item.Text == "PDF Export")
            {
                PdfExportProperties ExportProperties = new PdfExportProperties();
                ExportProperties.FileName = "test.pdf";
                this.DefaultGrid.PdfExport(ExportProperties);
            }
            else if (Args.Item.Text == "Excel Export")
            {
                ExcelExportProperties ExportProperties = new ExcelExportProperties();
                ExportProperties.ExportType = ExportType.CurrentPage;
                DefaultGrid.ExcelExport(ExportProperties);
            }
        }
        public async Task ActionBeginAsync(ActionEventArgs<ExpandoObject> args)
        {
          
            if (args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
            {
                args.Cancel = true;
                if (args.Action == "add")
                {
                    string jsonstring = await DynamicAPIService.InsertData(args.Data, ConnString, StoreProcedure, "Insert");
                    OutputData exObj = JsonConvert.DeserializeObject<OutputData>(jsonstring);
                    DynamicObject.Add(exObj.DynamicData[0]);
                    this.DlgRef.Visible = true;
                    this.DlgRef.Show();
                    PopHeadarMsg = "Insert";
                    PopMsg = exObj.Msg;
                }
                else
                {
                    int index =Convert.ToInt32(args.RowIndex);
                    string jsonstring = await DynamicAPIService.InsertData(args.Data, ConnString, StoreProcedure, "Update");
                    OutputData exObj = JsonConvert.DeserializeObject<OutputData>(jsonstring);
                    DynamicObject[index]=args.Data;
                    this.DlgRef.Visible = true;
                    this.DlgRef.Show();
                    PopHeadarMsg = "Update";
                    PopMsg = exObj.Msg;
                }
                await DefaultGrid.CloseEdit();
            }
            else if (args.RequestType == Syncfusion.Blazor.Grids.Action.Delete)
            {
                //args.Cancel = true;
                string jsonstring =await DynamicAPIService.InsertData(args.Data, ConnString, StoreProcedure, "Delete");
                OutputData exObj = JsonConvert.DeserializeObject<OutputData>(jsonstring);
                //int index = Convert.ToInt32(args.RowIndex);               
                //DynamicObject.Remove(exObj.DynamicData[0]);               
                this.DlgRef.Visible = true;
                this.DlgRef.Show();
                PopHeadarMsg = "Delete";
                PopMsg = exObj.Msg;
            }
        }

        public void CloseDialog()
        {
            this.DlgRef.Visible = false;
            this.DlgRef.Hide();
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
                Action = root.SelectSingleNode("Action").InnerText.ToString();

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
                            IsPrimaryKey= (c as XmlElement).HasAttribute("IsPrimaryKey")?true:false,
                        });
                    }
                }
                ColumnList = listNonEditable;

                XmlNodeList Xchart = xdoc.GetElementsByTagName("Chart");

                foreach (XmlNode CA in Xchart)
                {
                    if (CA is XmlElement)
                    {
                        AttributesOfChart.SpName = (CA as XmlElement).GetAttribute("SpName").ToString();
                        AttributesOfChart.ChartType = (CA as XmlElement).GetAttribute("ChartType").ToString();
                        AttributesOfChart.ChartTitle = (CA as XmlElement).GetAttribute("ChartTitle").ToString();
                        AttributesOfChart.ValueType = (CA as XmlElement).GetAttribute("ValueType").ToString();
                        AttributesOfChart.Name = (CA as XmlElement).GetAttribute("Name").ToString();
                        AttributesOfChart.XName = (CA as XmlElement).GetAttribute("XName").ToString();
                        AttributesOfChart.YName = (CA as XmlElement).GetAttribute("YName").ToString();
                    }
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
