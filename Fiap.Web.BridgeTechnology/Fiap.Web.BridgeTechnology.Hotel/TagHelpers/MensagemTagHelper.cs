using System;
using Microsoft.AspNetCore.Razor.TagHelpers;


namespace Fiap.Web.BridgeTechnology.Hotel.TagHelpers
{
    public class MensagemTagHelper : TagHelper
    {
        public string Texto { get; set; }
        public string Class { get; set; }
        
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!String.IsNullOrEmpty(Texto))
            {
                //Definir o nome da tag
                output.TagName = "div";
                //Definir o atributo class
                output.Attributes.SetAttribute("class", String.IsNullOrEmpty(Class) ? "alert alert-success" : Class);
                //Definir o conteúdo da tag
                output.Content.SetContent(Texto);
            }
        }
    }
}
