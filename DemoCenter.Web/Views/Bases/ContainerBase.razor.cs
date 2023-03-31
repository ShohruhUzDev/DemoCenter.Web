using Microsoft.AspNetCore.Components;

namespace DemoCenter.Web.Views.Bases
{
    public partial class ContainerBase
    {
        [Parameter]
        public string CssClass { get; set; } = "container";

        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}