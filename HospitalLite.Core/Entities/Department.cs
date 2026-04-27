using HospitalLite.Core.Common;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace HospitalLite.Core.Entities
{
    public class Department : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
    }
}
