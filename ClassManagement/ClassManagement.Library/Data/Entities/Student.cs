using System;
using System.Collections.Generic;
using System.Text;

namespace ClassManagement.Library.Data.Entities
{
    public class Student : EntityBase<Guid> 
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid ClassId { get; set; }
        public virtual Class Class { get; set; }

    }
}
