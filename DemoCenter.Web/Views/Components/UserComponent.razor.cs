using DemoCenter.Web.Models.UserViews;
using DemoCenter.Web.Views.Bases;
using Microsoft.AspNetCore.Components;

namespace DemoCenter.Web.Views.Components
{
    public partial class UserComponent : ComponentBase
    {
        [Parameter]
        public List<UserView> Users { get; set; }

        public TableBase UsersTable { get; set; }
        public TableHeadBase FirstNameLabelCell { get; set; }
        public TableCellBase FirstNameValueCell { get; set; }
        public TableHeadBase LastNameLabelCell { get; set; }
        public TableCellBase LastNameValueCell { get; set; }
        public TableHeadBase PhoneNumberLabelCell { get; set; }
        public TableCellBase PhoneNumberValueCell { get; set; }
        public TableHeadBase EmailLabelCell { get; set; }
        public TableCellBase EmailValueCell { get; set; }
        public TableHeadBase BirthDateLabelCell { get; set; }
        public TableCellBase BirthDateValueCell { get; set; }
        public TableHeadBase PasswordLabelCell { get; set; }
        public TableCellBase PasswordValueCell { get; set; }


    }
}