using System;
using System.Collections.Generic;
using System.Text;

namespace ClassManagement.Library.Data.Entities
{
    public class Department : EntityBase<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public virtual Student Student { get; set; }
    }
}
