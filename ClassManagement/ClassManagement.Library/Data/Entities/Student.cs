using System;
using System.Collections.Generic;
using System.Text;

namespace ClassManagement.Library.Data.Entities
{
    public class Student : EntityBase<Guid> 
    {
        public string Code { get; set; }
        public int RollNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Mark { get; set; }
        public string Address { get; set; }
        public Guid ClassId { get; set; }
        public virtual Class Class { get; set; }
        public Guid DepatmentId { get; set; }
        public virtual Department Department { get; set; }

    }
}
