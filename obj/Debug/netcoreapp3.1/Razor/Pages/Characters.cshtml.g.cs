#pragma checksum "C:\Users\gomez\OneDrive\Desktop\C# Homework\ChristianGomezFinal\Pages\Characters.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58a2a00a9bac4cd148968b4b1041200df77c4c0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ChristianGomezFinal.Pages.Pages_Characters), @"mvc.1.0.razor-page", @"/Pages/Characters.cshtml")]
namespace ChristianGomezFinal.Pages
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
#line 1 "C:\Users\gomez\OneDrive\Desktop\C# Homework\ChristianGomezFinal\Pages\_ViewImports.cshtml"
using ChristianGomezFinal;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58a2a00a9bac4cd148968b4b1041200df77c4c0e", @"/Pages/Characters.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f28dd37158a8848dd5a0ee068008e2ba4177cc1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Characters : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\gomez\OneDrive\Desktop\C# Homework\ChristianGomezFinal\Pages\Characters.cshtml"
  
    ViewData["Title"] = "All Characters";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Characters</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\gomez\OneDrive\Desktop\C# Homework\ChristianGomezFinal\Pages\Characters.cshtml"
 foreach (var c in Model.Characters)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>Name</p>  <p>");
#nullable restore
#line 14 "C:\Users\gomez\OneDrive\Desktop\C# Homework\ChristianGomezFinal\Pages\Characters.cshtml"
             Write(Html.DisplayFor(ModelItem => c.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n   <p>Age</p> <p>");
#nullable restore
#line 15 "C:\Users\gomez\OneDrive\Desktop\C# Homework\ChristianGomezFinal\Pages\Characters.cshtml"
            Write(Html.DisplayFor(ModelItem => c.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n   <p>Playable</p> <p>");
#nullable restore
#line 16 "C:\Users\gomez\OneDrive\Desktop\C# Homework\ChristianGomezFinal\Pages\Characters.cshtml"
                 Write(Html.DisplayFor(ModelItem => c.isplayable));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n  <p>Description</p>  <p>");
#nullable restore
#line 17 "C:\Users\gomez\OneDrive\Desktop\C# Homework\ChristianGomezFinal\Pages\Characters.cshtml"
                    Write(Html.DisplayFor(ModelItem => c.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n  <p>Voice Actor</p>  <p>");
#nullable restore
#line 18 "C:\Users\gomez\OneDrive\Desktop\C# Homework\ChristianGomezFinal\Pages\Characters.cshtml"
                    Write(Html.DisplayFor(ModelItem => c.VoiceActor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 19 "C:\Users\gomez\OneDrive\Desktop\C# Homework\ChristianGomezFinal\Pages\Characters.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CharacterModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CharacterModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CharacterModel>)PageContext?.ViewData;
        public CharacterModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
