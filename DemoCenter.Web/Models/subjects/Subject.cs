﻿using System;

namespace DemoCenter.Web.Models.Subjects
{
    public class Subject
    {
        public Guid Id { get; set; }
        public string SubjectName { get; set; }
        public int Price { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }

     //   public virtual IEnumerable<Group> Groups { get; set; }
    }
}
