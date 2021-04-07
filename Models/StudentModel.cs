using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class StudentModel: BaseModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Grade { get; set; }
    }
}
