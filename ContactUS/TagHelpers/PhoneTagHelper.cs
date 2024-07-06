using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ContactUs.TagHelpers
{

    [HtmlTargetElement("call", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class PhoneTagHelper : TagHelper
    {
        public string phoneNumber { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //output.TagName = "a";
            output.Attributes.Add("href", $"tel:{phoneNumber}");
            output.Content.AppendHtml($"Call {phoneNumber}");
            base.Process(context, output);
        }
    }
}
