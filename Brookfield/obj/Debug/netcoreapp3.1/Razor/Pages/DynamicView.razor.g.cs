#pragma checksum "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "827313864934bfdbd450a9ee2772ecdd4b178252"
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
#line 6 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
using System.Dynamic;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DynamicView")]
    public partial class DynamicView : DynamicViewBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, 
#nullable restore
#line 8 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
     Tital

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n\r\n");
#nullable restore
#line 10 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
 if (paramList != null)
{
    int i = 0;
    string name="u";


#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddMarkupContent(5, "\r\n        \r\n");
#nullable restore
#line 17 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
         foreach (var item in paramList)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "label");
            __builder.AddContent(8, 
#nullable restore
#line 19 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                    item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", 
#nullable restore
#line 20 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                          item.Type

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "class", "input-group-sm");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 21 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                        i++;
           
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "\r\n\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 64 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "card" + " mb-3" + " " + (
#nullable restore
#line 65 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                       display

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(18, "\r\n\r\n");
#nullable restore
#line 67 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
     if (DynamicObject == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "        ");
            __builder.AddMarkupContent(20, "<p><em>Loading.......</em></p>\r\n");
#nullable restore
#line 70 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "        ");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(22);
            __builder.AddAttribute(23, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                           ExcelExport

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(24, "Content", "Excel Export");
            __builder.AddAttribute(25, "CssClass", "e-success");
            __builder.CloseComponent();
            __builder.AddContent(26, " ");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(27);
            __builder.AddAttribute(28, "CssClass", "e-success");
            __builder.AddAttribute(29, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                                                                                                        PdfExport

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(30, "Content", "Pdf Export");
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenComponent<Syncfusion.Blazor.Grids.SfGrid<ExpandoObject>>(32);
            __builder.AddAttribute(33, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ExpandoObject>>(
#nullable restore
#line 74 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                             DynamicObject

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "GridLines", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.GridLine>(
#nullable restore
#line 74 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                        GridLine.Both

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "Toolbar", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 75 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                  new List<string>() { "Add","Edit", "Delete", "Update", "Cancel","Search","Print" }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 75 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                                                                                                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "AllowGrouping", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 76 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "AllowMultiSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 76 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                        true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 76 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "AllowReordering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 76 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "AllowTextWrap", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 76 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                                                                                        true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "AllowResizing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 76 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                                                                                                             true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "AllowPdfExport", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 76 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                                                                                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "AllowExcelExport", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 76 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                                                                                                                                                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEvents<ExpandoObject>>(47);
                __builder2.AddAttribute(48, "OnActionBegin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Grids.ActionEventArgs<ExpandoObject>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Grids.ActionEventArgs<ExpandoObject>>(this, 
#nullable restore
#line 77 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                       ActionBeginAsync

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEditSettings>(50);
                __builder2.AddAttribute(51, "AllowAdding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 78 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "AllowDeleting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 78 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "AllowEditing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 78 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.EditMode>(
#nullable restore
#line 78 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                                                                EditMode.Normal

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(56);
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(58, "\r\n");
#nullable restore
#line 80 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                 foreach (DataColumn col in dtEmployeeList.Columns)
                {
                    switch (col.DataType.FullName)
                    {
                        case "System.Int64":

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(59, "                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(60);
                    __builder3.AddAttribute(61, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 85 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                col.ToString()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(62, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.ColumnType>(
#nullable restore
#line 85 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                                      ColumnType.Number

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(63, "HeaderTextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 85 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                                                                           TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(64, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 85 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                                                                                                         TextAlign.Right

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(65, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 85 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                                                                                                                                          false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(66, "FilterTemplate", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder4) => {
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(67, "\r\n");
#nullable restore
#line 88 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                            break;
                        case "System.DateTime":

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(68, "                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(69);
                    __builder3.AddAttribute(70, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 90 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                col.ToString()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "Format", "MM/dd/yyyy");
                    __builder3.AddAttribute(72, "HeaderTextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 90 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                                                                      TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(73, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.ColumnType>(
#nullable restore
#line 90 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                                                                                              ColumnType.Date

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(74, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 90 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                                                                                                                               true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(76, "\r\n                            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\r\n");
#nullable restore
#line 95 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                            break;
                        case "System.String":

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(78, "                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(79);
                    __builder3.AddAttribute(80, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 97 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                col.ToString()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(81, "HeaderTextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 97 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                                                  TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(82, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.ColumnType>(
#nullable restore
#line 97 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                                                                          ColumnType.String

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(83, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 97 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                                                                                                             true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(84, "\r\n");
#nullable restore
#line 98 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                            break;
                    }
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(85, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(86, "\r\n        ");
            }
            ));
            __builder.AddComponentReferenceCapture(87, (__value) => {
#nullable restore
#line 74 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
                                                                             DefaultGrid = (Syncfusion.Blazor.Grids.SfGrid<ExpandoObject>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(88, "\r\n");
#nullable restore
#line 104 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "D:\BlazorPoc\Brookfield\Brookfield\Pages\DynamicView.razor"
               



            [Parameter]
            public DataTable dt { get; set; }
            string display = "d-none";

            //void submitedata()
            //{
            //    dt = GetUserList("", "", value[0], value[1], value[2]);
            //    if (dt.Rows.Count > 0)
            //    {
            //        List<Models.UserInfo> studentList = new List<Models.UserInfo>();
            //        for (int i = 0; i < dt.Rows.Count; i++)
            //        {
            //            Models.UserInfo student = new Models.UserInfo();
            //            student.UserId = Convert.ToInt32(dt.Rows[i]["UserId"]);
            //            student.FirstName = dt.Rows[i]["FirstName"].ToString();
            //            student.LastName = dt.Rows[i]["LastName"].ToString();
            //            student.UserName = dt.Rows[i]["UserName"].ToString();
            //            student.Email = dt.Rows[i]["Email"].ToString();
            //            student.Password = dt.Rows[i]["Password"].ToString();
            //            student.CreatedDate = Convert.ToDateTime(dt.Rows[i]["CreatedDate"].ToString());
            //            studentList.Add(student);
            //        }

            //        UserInfo = studentList;
            //        display = "";
            //    }
            //    else
            //        display = "d-none";
            //}

        

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591