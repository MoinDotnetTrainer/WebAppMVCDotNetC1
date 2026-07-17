using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppMVCLayred.Models
{
    [HtmlTargetElement("button-helper")]
    public class CustomeButton : TagHelper
    {
        public string Text { get; set; } = "Button";

        public string Type { get; set; } = "button";

        public string CssClass { get; set; } = "btn btn-primary";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.TagMode = TagMode.StartTagAndEndTag;

            output.Attributes.SetAttribute("type", Type);
            output.Attributes.SetAttribute("class", CssClass);

            output.Content.SetContent(Text);
        }

    }
}