namespace DemoCenter.Web.Models.SubjectViews
{
    public class SubjectView
    {
        public Guid Id { get; set; }
        public string SubjectName { get; set; }
        public int Price { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }

    //    public virtual IEnumerable<Group> Groups { get; set; }
    }
}
