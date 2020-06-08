using Brookfield.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Brookfield.Shared;
using System.Collections.ObjectModel;
using System.Dynamic;
using Newtonsoft.Json;

namespace Brookfield.Pages
{
    public class AppConfigutaionBase : ComponentBase
    {
        [Inject]
        public IDynamicAPIService dynamicAPIService { get; set; }
        public ObservableCollection<ExpandoObject> appConfiguration { get; set; }
        public DataTable dtList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            string conn = "Data Source=DESKTOP-97IJ0BQ;Initial Catalog=Inventory;Integrated Security=True;Timeout=90;User Id=sa;Password=abc123;";
            string storeProc = "GetAppConfiguration";
            string jsonstring = string.Empty;
            jsonstring = (await dynamicAPIService.GetAppConfiguration(conn,storeProc,"AppConfig"));
            appConfiguration = JsonConvert.DeserializeObject<ObservableCollection<ExpandoObject>>(jsonstring);
            dtList = (DataTable)JsonConvert.DeserializeObject(jsonstring, (typeof(DataTable)));          
        }
    }
}
