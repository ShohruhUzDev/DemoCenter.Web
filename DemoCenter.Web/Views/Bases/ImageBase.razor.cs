
using Microsoft.AspNetCore.Components;

namespace DemoCenter.Web.Views.Bases
{
    public partial class ImageBase : ComponentBase
    {
        [Parameter]
        public string Url { get; set; }

        [Parameter]
        public string Width { get; set; }
    }
}
