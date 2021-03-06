#pragma checksum "C:\Users\Vinod\Desktop\.Net\TodoList\Pages\Todo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4375e4e39658f11cb88163ed9d49720ff8f0fb81"
// <auto-generated/>
#pragma warning disable 1591
namespace TodoList.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Vinod\Desktop\.Net\TodoList\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vinod\Desktop\.Net\TodoList\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Vinod\Desktop\.Net\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Vinod\Desktop\.Net\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Vinod\Desktop\.Net\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Vinod\Desktop\.Net\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Vinod\Desktop\.Net\TodoList\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Vinod\Desktop\.Net\TodoList\_Imports.razor"
using TodoList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Vinod\Desktop\.Net\TodoList\_Imports.razor"
using TodoList.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h2");
            __builder.AddContent(1, "Todo (");
            __builder.AddContent(2, 
#nullable restore
#line 3 "C:\Users\Vinod\Desktop\.Net\TodoList\Pages\Todo.razor"
           todos.Count(todo => !todo.IsDone)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "placeholder", "TodoItem");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 4 "C:\Users\Vinod\Desktop\.Net\TodoList\Pages\Todo.razor"
                                     newTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTodo = __value, newTodo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\Vinod\Desktop\.Net\TodoList\Pages\Todo.razor"
                  AddTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "Add todo");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Vinod\Desktop\.Net\TodoList\Pages\Todo.razor"
     foreach (var todo in todos)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "todo-iteam");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "p");
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "checkbox");
            __builder.AddAttribute(22, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\Vinod\Desktop\.Net\TodoList\Pages\Todo.razor"
                                              todo.IsDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.IsDone = __value, todo.IsDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\Vinod\Desktop\.Net\TodoList\Pages\Todo.razor"
                              todo.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.Title = __value, todo.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 15 "C:\Users\Vinod\Desktop\.Net\TodoList\Pages\Todo.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "<style>\r\n    h2{\r\n        text-align: center;\r\n    }\r\n    input{\r\n        margin-left: 40%;\r\n    }\r\n    .todo-iteam{\r\n        background: #f4f4f4;\r\n        padding: 10px;\r\n        border-bottom: 1px #ccc;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\Vinod\Desktop\.Net\TodoList\Pages\Todo.razor"
       
    private IList<TodoItem> todos = new List<TodoItem>();
    private string newTodo;
    private void AddTodo()
    {
        if (!string.IsNullOrWhiteSpace(newTodo))
            {
                todos.Add(new TodoItem { Title = newTodo });
                newTodo = string.Empty;
            }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
