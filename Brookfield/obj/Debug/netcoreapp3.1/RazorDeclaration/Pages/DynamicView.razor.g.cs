#pragma checksum "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6feb7478dded8dc61455c7b51f9179100c372ff7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Brookfield.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\BlazorPoc\Brookfield\Brookfield\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BlazorPoc\Brookfield\Brookfield\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\BlazorPoc\Brookfield\Brookfield\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\BlazorPoc\Brookfield\Brookfield\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\BlazorPoc\Brookfield\Brookfield\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\BlazorPoc\Brookfield\Brookfield\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\BlazorPoc\Brookfield\Brookfield\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\BlazorPoc\Brookfield\Brookfield\_Imports.razor"
using Brookfield;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\BlazorPoc\Brookfield\Brookfield\_Imports.razor"
using Brookfield.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\BlazorPoc\Brookfield\Brookfield\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
using System.Dynamic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
using Brookfield.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DynamicView")]
    public partial class DynamicView : DynamicViewBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
               

            string display = "d-none";
            string displayMsg = "d-none";
            List<string> toolbar;

            async Task submitedata()
            {
                string jsonstring = string.Empty;
                jsonstring = await DynamicAPIService.GetDatabyParam(ParamList, ConnString, StoreProcedure, "Select", ProviderName);
                var response = JsonConvert.DeserializeObject<Brookfield.Models.OutputData>(jsonstring);

                if (response.DynamicData.Count > 0)
                {
                    RowsCount = response.DynamicData.Count.ToString();
                    IsInitialRender = true;
                    DynamicObject = null;
                    //DtEmployeeList = null;

                    DynamicObject = new ObservableCollection<ExpandoObject>(response.DynamicData);
                    if (IsInitialRenderGrid == false)
                    {
                        DtEmployeeList = Extensions.ToDataTable(response.DynamicData, "tbl");
                        ColumnCount = DtEmployeeList.Columns.Count.ToString();
                    }

                    display = "";
                    displayMsg = "d-none";
                }
                else
                {
                    display = "d-none";
                    displayMsg = "";
                }
            }

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 359 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
          
        public int StartAngle = 0, value = 0, EndAngle = 360, radiusValue = 70, exploderadius = 10;
        public double ExplodeIndex = 1;
        public string OuterRadius = "70%", ExplodeRadius = "10%";
        private void changeAngle(Microsoft.AspNetCore.Components.ChangeEventArgs args)
        {
            value = Convert.ToInt32(args.Value);
            StartAngle = +Convert.ToInt32(args.Value);
            EndAngle = +Convert.ToInt32(args.Value);
        }
        private void ChangeOuterRadius(Microsoft.AspNetCore.Components.ChangeEventArgs args)
        {
            radiusValue = Convert.ToInt32(args.Value);
            OuterRadius = args.Value + "%";
        }
        private void ChangeExplodeRadius(Microsoft.AspNetCore.Components.ChangeEventArgs args)
        {
            exploderadius = Convert.ToInt32(args.Value);
            ExplodeRadius = args.Value + "%";
        }
        private void ChangeExplodeIndex(Microsoft.AspNetCore.Components.ChangeEventArgs args)
        {
            ExplodeIndex = Convert.ToInt32(args.Value);
        }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
