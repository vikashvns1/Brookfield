#pragma checksum "D:\BlazorPoc\Brookfield\Brookfield\Pages\AppConfiguration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c3c9f694ced6a337489bf3c24d861e1025e796c"
// <auto-generated/>
#pragma warning disable 1591
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
#line 11 "D:\BlazorPoc\Brookfield\Brookfield\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\BlazorPoc\Brookfield\Brookfield\Pages\AppConfiguration.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class AppConfiguration : AppConfigutaionBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AppConfiguration</h3>\r\n\r\n");
#nullable restore
#line 8 "D:\BlazorPoc\Brookfield\Brookfield\Pages\AppConfiguration.razor"
 if (appConfiguration == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading....</em></p>\r\n");
#nullable restore
#line 11 "D:\BlazorPoc\Brookfield\Brookfield\Pages\AppConfiguration.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __Blazor.Brookfield.Pages.AppConfiguration.TypeInference.CreateSfGrid_0(__builder, 4, 5, 
#nullable restore
#line 14 "D:\BlazorPoc\Brookfield\Brookfield\Pages\AppConfiguration.razor"
                         appConfiguration

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 14 "D:\BlazorPoc\Brookfield\Brookfield\Pages\AppConfiguration.razor"
                                                       GridLine.Both

#line default
#line hidden
#nullable disable
            , 7, 
#nullable restore
#line 14 "D:\BlazorPoc\Brookfield\Brookfield\Pages\AppConfiguration.razor"
                                                                                     true

#line default
#line hidden
#nullable disable
            , 8, 
#nullable restore
#line 14 "D:\BlazorPoc\Brookfield\Brookfield\Pages\AppConfiguration.razor"
                                                                                                          true

#line default
#line hidden
#nullable disable
            , 9, (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(11);
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "\r\n");
#nullable restore
#line 16 "D:\BlazorPoc\Brookfield\Brookfield\Pages\AppConfiguration.razor"
             foreach (DataColumn col in dtList.Columns)
            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(14, "                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(15);
                    __builder3.AddAttribute(16, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "D:\BlazorPoc\Brookfield\Brookfield\Pages\AppConfiguration.razor"
                                   col.ColumnName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(17, "\r\n");
#nullable restore
#line 19 "D:\BlazorPoc\Brookfield\Brookfield\Pages\AppConfiguration.razor"
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(18, "            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(19);
                    __builder3.AddAttribute(20, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 20 "D:\BlazorPoc\Brookfield\Brookfield\Pages\AppConfiguration.razor"
                                    TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "Width", "70px");
                    __builder3.AddAttribute(22, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(23, "\r\n");
#nullable restore
#line 22 "D:\BlazorPoc\Brookfield\Brookfield\Pages\AppConfiguration.razor"
                      
                        string Xml = ((string)(context as IDictionary<string, object>)["Xml"]);
                        string ConnectionString = ((string)(context as IDictionary<string, object>)["ConnectionString"]);
                        string ScreenName = ((string)(context as IDictionary<string, object>)["ScreenName"]);

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(24, "                        ");
                        __builder4.OpenElement(25, "a");
                        __builder4.AddAttribute(26, "href", "#");
                        __builder4.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "D:\BlazorPoc\Brookfield\Brookfield\Pages\AppConfiguration.razor"
                                                () => OnClick(ScreenName,ConnectionString,Xml)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddMarkupContent(28, "\r\n                            Check\r\n                        ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(29, "\r\n");
                        __builder4.AddContent(30, "                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 41 "D:\BlazorPoc\Brookfield\Brookfield\Pages\AppConfiguration.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "D:\BlazorPoc\Brookfield\Brookfield\Pages\AppConfiguration.razor"
           
        //...
        void OnClick(string screen, string conn, string xml)
        {          
           urihelper.NavigateTo("/DynamicView/?xml=" + xml + "&ConnString=" + conn + "&Tital=" + screen);
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager urihelper { get; set; }
    }
}
namespace __Blazor.Brookfield.Pages.AppConfiguration
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::Syncfusion.Blazor.Grids.GridLine __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "GridLines", __arg1);
        __builder.AddAttribute(__seq2, "AllowTextWrap", __arg2);
        __builder.AddAttribute(__seq3, "AllowResizing", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591