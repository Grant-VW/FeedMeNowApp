#pragma checksum "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7aa88d04c5a4529a33f44ae51ad2a54afe9cd26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_RestaurantList), @"mvc.1.0.view", @"/Views/Shared/RestaurantList.cshtml")]
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
#line 1 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\_ViewImports.cshtml"
using FeedMeNow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
using FeedMeNow.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7aa88d04c5a4529a33f44ae51ad2a54afe9cd26", @"/Views/Shared/RestaurantList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e38299d54a26f6c48fb75815531c349085134f9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_RestaurantList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<Restaurant>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
  
    var data = ViewBag.Message;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br>\r\n<br>\r\n<div>\r\n    <ul>\r\n");
#nullable restore
#line 12 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
         foreach (var restaurant in data)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 243, "\"", 269, 1);
#nullable restore
#line 15 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
WriteAttributeValue("", 249, restaurant.LogoPath, 249, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-rounded\"");
            BeginWriteAttribute("alt", " alt=\"", 290, "\"", 316, 1);
#nullable restore
#line 15 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
WriteAttributeValue("", 296, restaurant.LogoPath, 296, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <h2>");
#nullable restore
#line 16 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
               Write(restaurant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                ");
#nullable restore
#line 17 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
           Write(restaurant.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 18 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
           Write(restaurant.Suburb);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 20 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n\r\n<h3>");
#nullable restore
#line 24 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
Write(data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<Restaurant>> Html { get; private set; }
    }
}
#pragma warning restore 1591