using Microsoft.AspNetCore.Components;

namespace DemoCenter.Web.Views.Bases
{
    public partial class TableHeadBase
    {
        [Parameter]
        public string Value { get; set; }
    }
}