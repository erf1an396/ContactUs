using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ContactUs.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement(Attributes = "bold")]
    public class boldTaghelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.PreContent.AppendHtml("<strong>");
            output.PostContent.AppendHtml("</strong>");
            output.Attributes.Add("style", "font-weight: 900");

            base.Process(context, output);
        }
    }
}
