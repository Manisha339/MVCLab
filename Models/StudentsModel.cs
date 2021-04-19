using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class StudentsModel : BaseModel
    {
        public int StudentID { get; set; }

        public string Name { get; set; }

        public int Grade { get; set; }
    }
}
