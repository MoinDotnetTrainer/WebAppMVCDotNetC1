using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppMVCLayred.Models
{
    [HtmlTargetElement("heading")]
    public class MyCustomeHeadingTag : TagHelper
    {
        // 1-6 , text --> 
        public int Level { get; set; } = 1;

        public string Text { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            // Ensure level is between 1 and 6
            if (Level < 1 || Level > 6)
            {
                Level = 1;
            }

            output.TagName = $"h{Level}";
            output.TagMode = TagMode.StartTagAndEndTag;

            if (!string.IsNullOrEmpty(Text))
            {
                output.Content.SetContent(Text);
            }
        }
    }
}
