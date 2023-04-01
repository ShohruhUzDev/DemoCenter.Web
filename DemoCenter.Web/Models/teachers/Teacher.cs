using System.Text.Json.Serialization;

namespace DemoCenter.Web.Models.Teachers
{
    public class Teacher
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }

      //  [JsonIgnore]
      //  public IEnumerable<Group> Groups { get; set; }
    }
}
