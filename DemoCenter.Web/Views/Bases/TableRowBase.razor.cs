using Microsoft.AspNetCore.Components;

namespace DemoCenter.Web.Views.Bases
{
    public partial class TableRowBase : ComponentBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
