﻿namespace Eduhome.Models
{
    public class CourseTag
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int TagId { get; set; }
        public Course Course { get; set; }
        public Tag Tag { get; set; }
    }
}
