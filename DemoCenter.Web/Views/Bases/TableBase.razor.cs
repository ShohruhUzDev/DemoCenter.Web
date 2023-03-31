using Microsoft.AspNetCore.Components;

namespace DemoCenter.Web.Views.Bases
{
    public partial class TableBase : ComponentBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}