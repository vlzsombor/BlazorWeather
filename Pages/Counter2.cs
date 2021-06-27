
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherServer.Pages
{
    [Route("/counter2")]
    public class Counter2 : ComponentBase
    {
        private int currentCount = 0;


        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            builder.OpenElement(1, "p");
            builder.AddContent(2, "Current count: ");
            builder.AddContent(3, this.currentCount);
            builder.CloseElement();
            builder.AddMarkupContent(4, "\r\n\r\n");
            builder.OpenElement(5, "button");
            builder.AddAttribute(6, "class", "btn btn-primary");

            builder.AddContent(8, "Click me");
            builder.CloseElement();

        }

        private void fas()
        {
            this.currentCount++;
        }
    }
}
