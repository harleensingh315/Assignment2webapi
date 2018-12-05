using System;
using System.Collections.Generic;

namespace WEBAPI_200349465.Models
{
    public partial class TblStudents
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public int? CourseId { get; set; }
    }
}
