using System;
using System.Collections.Generic;
using System.Text;

namespace ClassManagement.Library.Data.Entities
{
    public class Class : EntityBase<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
        public virtual ICollection<Section> Sections { get; set; } = new List<Section>();
    }
}
