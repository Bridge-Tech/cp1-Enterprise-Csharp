using System;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Fiap.Web.BridgeTechnology.Hotel.TagHelpers
{
    public class BotaoTagHelper : TagHelper
    {
        public string Texto { get; set; }
        public string Class { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "input";

            if (String.IsNullOrEmpty(Class))
                output.Attributes.SetAttribute("class", "btn btn-success");
            else
                output.Attributes.SetAttribute("class", Class);

            output.Attributes.SetAttribute("type", "submit");
            output.Attributes.SetAttribute("value", String.IsNullOrEmpty(Texto) ? "Cadastrar" : Texto);
        }
    }
}
