#pragma checksum "C:\Users\dinar\OneDrive\Документы\GitHub\Labs226-2021\BlazorApp\Pages\Tasklist.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97ab8b4a2d29affc6c67bc06a0ab825ddb5dde50"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dinar\OneDrive\Документы\GitHub\Labs226-2021\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dinar\OneDrive\Документы\GitHub\Labs226-2021\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dinar\OneDrive\Документы\GitHub\Labs226-2021\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dinar\OneDrive\Документы\GitHub\Labs226-2021\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dinar\OneDrive\Документы\GitHub\Labs226-2021\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dinar\OneDrive\Документы\GitHub\Labs226-2021\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dinar\OneDrive\Документы\GitHub\Labs226-2021\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dinar\OneDrive\Документы\GitHub\Labs226-2021\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dinar\OneDrive\Документы\GitHub\Labs226-2021\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dinar\OneDrive\Документы\GitHub\Labs226-2021\BlazorApp\Pages\Tasklist.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tasklist")]
    public partial class Tasklist : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "h2");
            __builder.AddAttribute(10, "class", "test-center");
            __builder.AddContent(11, "TaskList. Count of tasks:");
#nullable restore
#line 7 "C:\Users\dinar\OneDrive\Документы\GitHub\Labs226-2021\BlazorApp\Pages\Tasklist.razor"
__builder.AddContent(12, _tasks.Count(x => !x.IsDone));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "table");
            __builder.AddAttribute(15, "class", "table table-striped");
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.AddMarkupContent(17, @"<thead class=""table-dark"">
                    <tr>
                        <th>Mission</th>
                        <th>In Progress</th>
                        <th>Is Done</th>
                        <th>Actions</th>
                    </tr>
                </thead>
");
#nullable restore
#line 17 "C:\Users\dinar\OneDrive\Документы\GitHub\Labs226-2021\BlazorApp\Pages\Tasklist.razor"
                 foreach (var item in _tasks)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "                    ");
            __builder.OpenElement(19, "tbody");
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "\r\n                            ");
            __builder.OpenElement(23, "td");
#nullable restore
#line 21 "C:\Users\dinar\OneDrive\Документы\GitHub\Labs226-2021\BlazorApp\Pages\Tasklist.razor"
__builder.AddContent(24, item.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                            ");
            __builder.OpenElement(26, "td");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "checkbox");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\dinar\OneDrive\Документы\GitHub\Labs226-2021\BlazorApp\Pages\Tasklist.razor"
                                                                    item.InProgress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item.InProgress = __value, item.InProgress));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                            ");
            __builder.OpenElement(32, "td");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "type", "checkbox");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\dinar\OneDrive\Документы\GitHub\Labs226-2021\BlazorApp\Pages\Tasklist.razor"
                                                                    item.IsDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item.IsDone = __value, item.IsDone));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                            ");
            __builder.OpenElement(38, "td");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "class", "btn btn-danger");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\dinar\OneDrive\Документы\GitHub\Labs226-2021\BlazorApp\Pages\Tasklist.razor"
                                                                         (() => DeleteTask(item))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "Delete Task");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 27 "C:\Users\dinar\OneDrive\Документы\GitHub\Labs226-2021\BlazorApp\Pages\Tasklist.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n            ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "row");
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "col");
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "class", "form-control");
            __builder.AddAttribute(56, "placeholder", "Input new tsk here");
            __builder.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\dinar\OneDrive\Документы\GitHub\Labs226-2021\BlazorApp\Pages\Tasklist.razor"
                                                                                              _newTask

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _newTask = __value, _newTask));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "col col-auto");
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "class", "btn btn-outline-dark");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\dinar\OneDrive\Документы\GitHub\Labs226-2021\BlazorApp\Pages\Tasklist.razor"
                                                                   AddNewTaskToList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(67, "Add new Task");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\dinar\OneDrive\Документы\GitHub\Labs226-2021\BlazorApp\Pages\Tasklist.razor"
       
    private List<TaskListItem> _tasks = new List<TaskListItem>(); 

    private string _newTask;
    private void AddNewTaskToList()
    {
        if (!string.IsNullOrEmpty(_newTask))
        {
            _tasks.Add(new TaskListItem(_newTask));
            _newTask = "";
        }
    }
    private void DeleteTask(TaskListItem item)
    {
        _tasks.Remove(item);
    }
    //private void AddToDB()
    //{
    //    MongoExtensions.AddItem(_tasks, "Monday");
    //}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
