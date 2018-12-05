using System;
using System.Collections.Generic;

namespace WEBAPI_200349465.Models
{
    public partial class TblCourses
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int? CourseHours { get; set; }
        public string CourseCode { get; set; }
    }
}
