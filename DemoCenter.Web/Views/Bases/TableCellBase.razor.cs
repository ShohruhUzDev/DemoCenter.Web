using Microsoft.AspNetCore.Components;

namespace DemoCenter.Web.Views.Bases
{
    public partial class TableCellBase : ComponentBase
    {
        [Parameter]
        public string Value { get; set; }
    }
}
