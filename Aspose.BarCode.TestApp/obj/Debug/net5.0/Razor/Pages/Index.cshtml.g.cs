#pragma checksum "E:\Projects\Aspose.BarCode.TestApp\Aspose.BarCode.TestApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec8926167c86cdefaa3755643d4267041fbad154"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Aspose.BarCode.TestApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Aspose.BarCode.TestApp.Pages
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
#line 1 "E:\Projects\Aspose.BarCode.TestApp\Aspose.BarCode.TestApp\Pages\_ViewImports.cshtml"
using Aspose.BarCode.TestApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec8926167c86cdefaa3755643d4267041fbad154", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7206dedad9c33544ddbb619bab315e88c407049a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Projects\Aspose.BarCode.TestApp\Aspose.BarCode.TestApp\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\" id=\"contentArea\">\r\n    <h1 class=\"display-4\">Aspose.BarCode Test Web Application</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec8926167c86cdefaa3755643d4267041fbad1544034", async() => {
                WriteLiteral("\r\n        <input type=\"file\" id=\"picture\" accept=\".jpg, .jpeg, .bmp, .png, .tif\"/>\r\n        <button onclick=\"SubmitPicture()\">Go</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div id=\"imageArea\">\r\n        <img src=\"favicon.ico\"");
            BeginWriteAttribute("alt", " alt=\"", 447, "\"", 453, 0);
            EndWriteAttribute();
            WriteLiteral("/>\r\n        <div class=\"overlay\">\r\n            <img src=\"bar.gif\"");
            BeginWriteAttribute("alt", " alt=\"", 519, "\"", 525, 0);
            EndWriteAttribute();
            WriteLiteral("/>\r\n        </div>\r\n    </div>\r\n    <div id=\"foundArea\">\r\n        <h2>Found codes:</h2>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $('form').submit(function (e) {
            e.preventDefault();            
        });
        function SubmitPicture() {
            let file = $('#picture').prop('files');
            if (file.length === 0)
            {
                alert('Picture file is required!');
                return;
            }
            let reader = new FileReader();
            reader.readAsDataURL(file[0]);
            reader.onload = function(e) {
                $('#imageArea > img').attr('src', e.target.result);
                $('#imageArea').show();
            };
            let formData = new FormData();
            formData.append(""picture"", file[0]);
            $.ajax({
                type: 'POST',
                contentType: false,
                processData: false,
                dataType: 'json',
                url: '/',
                data: formData,
                headers: {
                    RequestVerificationToken: $('inp");
                WriteLiteral(@"ut:hidden[name=""__RequestVerificationToken""]').val()
                },
                beforeSend: function () {
                    $('#imageArea .codeRectangle').remove();
                    $('#imageArea .overlay').show();
                    $('#foundArea').hide();
                    $('#foundArea p').remove();
                }
            }).done(function (result) {
                $('#imageArea .overlay').hide();
                $.each(result, function (index, code) {
                    $('<p/>',{
                        html: code.codeTypeName + ': ' + code.codeText
                    }).appendTo('#foundArea');
                    $('<div/>',{
                        class: 'codeRectangle',
                        style: 'top: ' + code.region.rectangle.top + 'px;' +
                               'left: ' + code.region.rectangle.left + 'px;' +
                               'width: ' + code.region.rectangle.width + 'px;' +
                               'height: ' + code.region");
                WriteLiteral(@".rectangle.height + 'px;'  
                    }).appendTo('#imageArea');
                });
                if (result.length === 0) {
                    $('<p/>',{
                        html: 'None'
                    }).appendTo('#foundArea');
                }
                $('#foundArea').show();
                
            });
            
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
