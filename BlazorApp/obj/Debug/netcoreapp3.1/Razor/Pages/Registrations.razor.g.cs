#pragma checksum "C:\Users\262021\Documents\GitHub\Labs226-2021\BlazorApp\Pages\Registrations.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "532543feb89c513837bdb4eb7ca70c8e5fa44d98"
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
#line 1 "C:\Users\262021\Documents\GitHub\Labs226-2021\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\262021\Documents\GitHub\Labs226-2021\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\262021\Documents\GitHub\Labs226-2021\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\262021\Documents\GitHub\Labs226-2021\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\262021\Documents\GitHub\Labs226-2021\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\262021\Documents\GitHub\Labs226-2021\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\262021\Documents\GitHub\Labs226-2021\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\262021\Documents\GitHub\Labs226-2021\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\262021\Documents\GitHub\Labs226-2021\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\262021\Documents\GitHub\Labs226-2021\BlazorApp\Pages\Registrations.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/regist")]
    public partial class Registrations : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"h1Font\">Registrations</h1><br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\262021\Documents\GitHub\Labs226-2021\BlazorApp\Pages\Registrations.razor"
                 user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "class", "form-bottom");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "Auth1");
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenElement(9, "label");
                __builder2.AddMarkupContent(10, "\r\n        Login\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "class", "inputText1");
                __builder2.AddAttribute(13, "placeholder", "Login");
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\262021\Documents\GitHub\Labs226-2021\BlazorApp\Pages\Registrations.razor"
                                                                       UserService.Login

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserService.Login = __value, UserService.Login))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserService.Login));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __Blazor.BlazorApp.Pages.Registrations.TypeInference.CreateValidationMessage_0(__builder2, 18, 19, 
#nullable restore
#line 13 "C:\Users\262021\Documents\GitHub\Labs226-2021\BlazorApp\Pages\Registrations.razor"
                                ()=>UserService.Login

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(20, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n    <br>\r\n    ");
                __builder2.OpenElement(22, "label");
                __builder2.AddMarkupContent(23, "\r\n        E-mail\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "class", "inputText1");
                __builder2.AddAttribute(26, "placeholder", "Email");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\262021\Documents\GitHub\Labs226-2021\BlazorApp\Pages\Registrations.razor"
                                                                       UserService.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserService.Email = __value, UserService.Email))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserService.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n    <br>\r\n     ");
                __builder2.OpenElement(32, "label");
                __builder2.AddMarkupContent(33, "\r\n        Pass\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(34);
                __builder2.AddAttribute(35, "class", "inputText1");
                __builder2.AddAttribute(36, "type", "password");
                __builder2.AddAttribute(37, "placeholder", "Pass");
                __builder2.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\262021\Documents\GitHub\Labs226-2021\BlazorApp\Pages\Registrations.razor"
                                                                                      user.Pass

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Pass = __value, user.Pass))));
                __builder2.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Pass));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n    <br>\r\n    ");
                __builder2.OpenElement(43, "label");
                __builder2.AddMarkupContent(44, "\r\n        Pass\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(45);
                __builder2.AddAttribute(46, "class", "inputText1");
                __builder2.AddAttribute(47, "type", "password");
                __builder2.AddAttribute(48, "placeholder", "Pass");
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\262021\Documents\GitHub\Labs226-2021\BlazorApp\Pages\Registrations.razor"
                                                                                      bufPass

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => bufPass = __value, bufPass))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => bufPass));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n    ");
                __builder2.OpenElement(54, "button");
                __builder2.AddAttribute(55, "class", "btn btn-primary");
                __builder2.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\262021\Documents\GitHub\Labs226-2021\BlazorApp\Pages\Registrations.razor"
                                              NextPage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(57, " Next ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\262021\Documents\GitHub\Labs226-2021\BlazorApp\Pages\Registrations.razor"
       
    public string bufPass;

	User user = new User();

      private void NextPage() 
    { 
       NavigationManager.NavigateTo("acc");
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.UserService UserService { get; set; }
    }
}
namespace __Blazor.BlazorApp.Pages.Registrations
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
