using System;
using System.Collections.Generic;
using System.Text;

namespace SkillTreeMVC.Domain.ViewModels.Blog
{
    public class Articles
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string CoverPhoto { get; set; }
        public DateTime CreateDate { get; set; }
        public string Tags { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
    }
}
