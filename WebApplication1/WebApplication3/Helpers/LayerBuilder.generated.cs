﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    
    #line 5 "..\..\Helpers\LayerBuilder.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Helpers\LayerBuilder.cshtml"
    using System.Web.Optimization;
    
    #line default
    #line hidden
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 6 "..\..\Helpers\LayerBuilder.cshtml"
    using ClassLibrary1;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public class _Helpers_LayerBuilder_cshtml : System.Web.WebPages.HelperPage
    {

#line 9 "..\..\Helpers\LayerBuilder.cshtml"
public static System.Web.WebPages.HelperResult BuildLayer(LayerData ld)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 10 "..\..\Helpers\LayerBuilder.cshtml"
 
    var v = (System.Web.Mvc.WebViewPage)WebPageContext.Current.Page;
    var html = ((System.Web.Mvc.WebViewPage)WebPageContext.Current.Page).Html;



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <!DOCTYPE html>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <html>\r\n    <head>\r\n        <meta");

WriteLiteralTo(__razor_helper_writer, " charset=\"utf-8\"");

WriteLiteralTo(__razor_helper_writer, " />\r\n        <meta");

WriteLiteralTo(__razor_helper_writer, " name=\"viewport\"");

WriteLiteralTo(__razor_helper_writer, " content=\"width=device-width, initial-scale=1.0\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        <title>My ASP.NET Application</title>\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 20 "..\..\Helpers\LayerBuilder.cshtml"
WriteTo(__razor_helper_writer, Styles.Render("~/Content/css"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 21 "..\..\Helpers\LayerBuilder.cshtml"
WriteTo(__razor_helper_writer, Scripts.Render("~/bundles/modernizr"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 22 "..\..\Helpers\LayerBuilder.cshtml"
WriteTo(__razor_helper_writer, Scripts.Render("~/bundles/jquery"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 23 "..\..\Helpers\LayerBuilder.cshtml"
WriteTo(__razor_helper_writer, Scripts.Render("~/bundles/bootstrap"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 24 "..\..\Helpers\LayerBuilder.cshtml"
WriteTo(__razor_helper_writer, Scripts.Render("/kc/webapplication1/scripts/Sample.js"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 25 "..\..\Helpers\LayerBuilder.cshtml"
WriteTo(__razor_helper_writer, v.RenderSection("scripts", required: false));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n    </head>\r\n    <body>\r\n        <div");

WriteLiteralTo(__razor_helper_writer, " class=\"navbar navbar-inverse navbar-fixed-top\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"container\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                <div");

WriteLiteralTo(__razor_helper_writer, " class=\"navbar-header\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                    <button");

WriteLiteralTo(__razor_helper_writer, " type=\"button\"");

WriteLiteralTo(__razor_helper_writer, " class=\"navbar-toggle\"");

WriteLiteralTo(__razor_helper_writer, " data-toggle=\"collapse\"");

WriteLiteralTo(__razor_helper_writer, " data-target=\".navbar-collapse\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"icon-bar\"");

WriteLiteralTo(__razor_helper_writer, "></span>\r\n                        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"icon-bar\"");

WriteLiteralTo(__razor_helper_writer, "></span>\r\n                        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"icon-bar\"");

WriteLiteralTo(__razor_helper_writer, "></span>\r\n                    </button>\r\n");

WriteLiteralTo(__razor_helper_writer, "                    ");


#line 36 "..\..\Helpers\LayerBuilder.cshtml"
WriteTo(__razor_helper_writer, html.ActionLink("Application name", "Index", "Home", new { area = "" }, new { @class = "navbar-brand" }));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                </div>\r\n                <div");

WriteLiteralTo(__razor_helper_writer, " class=\"navbar-collapse collapse\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                    <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"nav navbar-nav\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                        <li>");


#line 40 "..\..\Helpers\LayerBuilder.cshtml"
WriteTo(__razor_helper_writer, html.ActionLink("Home", "Index", "Home"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</li>\r\n                        <li>");


#line 41 "..\..\Helpers\LayerBuilder.cshtml"
WriteTo(__razor_helper_writer, html.ActionLink("About", "About", "Home"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</li>\r\n                        <li>");


#line 42 "..\..\Helpers\LayerBuilder.cshtml"
WriteTo(__razor_helper_writer, html.ActionLink("Contact", "Contact", "Home"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n   " +
"     </div>\r\n        <div");

WriteLiteralTo(__razor_helper_writer, " class=\"container body-content\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "            ");


#line 48 "..\..\Helpers\LayerBuilder.cshtml"
WriteTo(__razor_helper_writer, v.RenderBody());


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n            <hr />\r\n            <footer>\r\n                <p>&copy; ");


#line 51 "..\..\Helpers\LayerBuilder.cshtml"
WriteTo(__razor_helper_writer, DateTime.Now.Year);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " - My ASP.NET Application</p>\r\n            </footer>\r\n        </div>\r\n        <di" +
"v>");


#line 54 "..\..\Helpers\LayerBuilder.cshtml"
WriteTo(__razor_helper_writer, ld.HogeProp);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>\r\n    </body>\r\n</html>\r\n");


#line 57 "..\..\Helpers\LayerBuilder.cshtml"



#line default
#line hidden
});

#line 58 "..\..\Helpers\LayerBuilder.cshtml"
}
#line default
#line hidden

    }
}
#pragma warning restore 1591
