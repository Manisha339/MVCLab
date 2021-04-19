using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class MarksModel : BaseModel
    {
        public int StudentID { get; set; }
        public int SubjectID { get; set; }
        public int MarksID { get; set; }
        public int marks { get; set; }
    }
}
