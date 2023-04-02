using System;
using System.Collections.Generic;
using DemoCenter.Web.Models.TeacherViews;
using DemoCenter.Web.Views.Bases;
using Microsoft.AspNetCore.Components;

namespace DemoCenter.Web.Views.Components
{
    public partial class TeacherComponent : ComponentBase
    {
        [Parameter]
        public List<TeacherView> Teachers { get; set; }
        public TableBase TeachersTable { get; set; }
        public TableHeadBase FirstNameLabelCell { get; set; }
        public TableCellBase FirstNameValueCell { get; set; }
        public TableHeadBase LastNameLabelCell { get; set; }
        public TableCellBase LastNameValueCell { get; set; }
        public TableHeadBase PhoneNumberLabelCell { get; set; }
        public TableCellBase PhoneNumberValueCell { get; set; }     

    }
}