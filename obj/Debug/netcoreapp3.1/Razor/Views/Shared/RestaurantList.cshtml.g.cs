#pragma checksum "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ebf91aec2d696d9fb4c40582a9721b633368ca2"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ebf91aec2d696d9fb4c40582a9721b633368ca2", @"/Views/Shared/RestaurantList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e38299d54a26f6c48fb75815531c349085134f9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_RestaurantList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<Restaurant>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
  
    var menuItemNameInCity = ViewBag.menuItemNameInCity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
  
    var restaurants = ViewBag.restaurants;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br>\r\nYou searched for&nbsp;&nbsp;&nbsp;&nbsp; <b>");
#nullable restore
#line 11 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
                                       Write(menuItemNameInCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n<br>\r\n<br>\r\n<div>\r\n");
#nullable restore
#line 15 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
     foreach (var restaurant in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 368, "\"", 394, 1);
#nullable restore
#line 18 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
WriteAttributeValue("", 374, restaurant.LogoPath, 374, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-rounded\"");
            BeginWriteAttribute("alt", " alt=\"", 415, "\"", 441, 1);
#nullable restore
#line 18 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
WriteAttributeValue("", 421, restaurant.LogoPath, 421, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <h3>");
#nullable restore
#line 19 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
           Write(restaurant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            ");
#nullable restore
#line 20 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
       Write(restaurant.Suburb);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br>\r\n");
#nullable restore
#line 22 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
             foreach (var category in restaurant.Categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>");
#nullable restore
#line 24 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
                Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 26 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
                 foreach (var menuItem in category.MenuItems)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <label class=\"container\">\r\n                            ");
#nullable restore
#line 30 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
                       Write(menuItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ---  ");
#nullable restore
#line 30 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
                                           Write(String.Format("{0:C}", menuItem.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <input type=\"checkbox\">\r\n                            <span class=\"checkmark\"></span>\r\n                        </label>\r\n                    </div>\r\n");
#nullable restore
#line 35 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <br>\r\n        <br>\r\n");
#nullable restore
#line 40 "C:\Users\GCPC\Desktop\Projects\FeedMeNow\Views\Shared\RestaurantList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>>\r\n\r\n");
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
