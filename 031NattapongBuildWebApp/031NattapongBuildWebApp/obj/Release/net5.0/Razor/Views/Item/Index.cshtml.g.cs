#pragma checksum "/Users/flukee/Nattapong/Work/SIT-KMUTT STD/ปี 4 เทอม 2/INT374 Cloud Computing Workshop/Project_Cosmos/CosmosLabBuildWebApp/031NattapongBuildWebApp/031NattapongBuildWebApp/Views/Item/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa441347d35bd6de4535dfa77099e09e567c0a0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Index), @"mvc.1.0.view", @"/Views/Item/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/flukee/Nattapong/Work/SIT-KMUTT STD/ปี 4 เทอม 2/INT374 Cloud Computing Workshop/Project_Cosmos/CosmosLabBuildWebApp/031NattapongBuildWebApp/031NattapongBuildWebApp/Views/_ViewImports.cshtml"
using _031NattapongBuildWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/flukee/Nattapong/Work/SIT-KMUTT STD/ปี 4 เทอม 2/INT374 Cloud Computing Workshop/Project_Cosmos/CosmosLabBuildWebApp/031NattapongBuildWebApp/031NattapongBuildWebApp/Views/_ViewImports.cshtml"
using _031NattapongBuildWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa441347d35bd6de4535dfa77099e09e567c0a0c", @"/Views/Item/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d3727008e3837046afb0c2b658c9b69dcb33898", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<todo.Models.Item>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/flukee/Nattapong/Work/SIT-KMUTT STD/ปี 4 เทอม 2/INT374 Cloud Computing Workshop/Project_Cosmos/CosmosLabBuildWebApp/031NattapongBuildWebApp/031NattapongBuildWebApp/Views/Item/Index.cshtml"
  
    ViewBag.Title = "List of To-Do Items";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>List of To-Do Items</h2>\n\n<table class=\"table\">\n    <tr>\n        <th>\n            ");
#nullable restore
#line 13 "/Users/flukee/Nattapong/Work/SIT-KMUTT STD/ปี 4 เทอม 2/INT374 Cloud Computing Workshop/Project_Cosmos/CosmosLabBuildWebApp/031NattapongBuildWebApp/031NattapongBuildWebApp/Views/Item/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 16 "/Users/flukee/Nattapong/Work/SIT-KMUTT STD/ปี 4 เทอม 2/INT374 Cloud Computing Workshop/Project_Cosmos/CosmosLabBuildWebApp/031NattapongBuildWebApp/031NattapongBuildWebApp/Views/Item/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 19 "/Users/flukee/Nattapong/Work/SIT-KMUTT STD/ปี 4 เทอม 2/INT374 Cloud Computing Workshop/Project_Cosmos/CosmosLabBuildWebApp/031NattapongBuildWebApp/031NattapongBuildWebApp/Views/Item/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Completed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th></th>\n    </tr>\n\n");
#nullable restore
#line 24 "/Users/flukee/Nattapong/Work/SIT-KMUTT STD/ปี 4 เทอม 2/INT374 Cloud Computing Workshop/Project_Cosmos/CosmosLabBuildWebApp/031NattapongBuildWebApp/031NattapongBuildWebApp/Views/Item/Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 28 "/Users/flukee/Nattapong/Work/SIT-KMUTT STD/ปี 4 เทอม 2/INT374 Cloud Computing Workshop/Project_Cosmos/CosmosLabBuildWebApp/031NattapongBuildWebApp/031NattapongBuildWebApp/Views/Item/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 31 "/Users/flukee/Nattapong/Work/SIT-KMUTT STD/ปี 4 เทอม 2/INT374 Cloud Computing Workshop/Project_Cosmos/CosmosLabBuildWebApp/031NattapongBuildWebApp/031NattapongBuildWebApp/Views/Item/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 34 "/Users/flukee/Nattapong/Work/SIT-KMUTT STD/ปี 4 เทอม 2/INT374 Cloud Computing Workshop/Project_Cosmos/CosmosLabBuildWebApp/031NattapongBuildWebApp/031NattapongBuildWebApp/Views/Item/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Completed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 37 "/Users/flukee/Nattapong/Work/SIT-KMUTT STD/ปี 4 เทอม 2/INT374 Cloud Computing Workshop/Project_Cosmos/CosmosLabBuildWebApp/031NattapongBuildWebApp/031NattapongBuildWebApp/Views/Item/Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 38 "/Users/flukee/Nattapong/Work/SIT-KMUTT STD/ปี 4 เทอม 2/INT374 Cloud Computing Workshop/Project_Cosmos/CosmosLabBuildWebApp/031NattapongBuildWebApp/031NattapongBuildWebApp/Views/Item/Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 39 "/Users/flukee/Nattapong/Work/SIT-KMUTT STD/ปี 4 เทอม 2/INT374 Cloud Computing Workshop/Project_Cosmos/CosmosLabBuildWebApp/031NattapongBuildWebApp/031NattapongBuildWebApp/Views/Item/Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 42 "/Users/flukee/Nattapong/Work/SIT-KMUTT STD/ปี 4 เทอม 2/INT374 Cloud Computing Workshop/Project_Cosmos/CosmosLabBuildWebApp/031NattapongBuildWebApp/031NattapongBuildWebApp/Views/Item/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</table>\n\n<p>\n    ");
#nullable restore
#line 47 "/Users/flukee/Nattapong/Work/SIT-KMUTT STD/ปี 4 เทอม 2/INT374 Cloud Computing Workshop/Project_Cosmos/CosmosLabBuildWebApp/031NattapongBuildWebApp/031NattapongBuildWebApp/Views/Item/Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</p>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<todo.Models.Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591
