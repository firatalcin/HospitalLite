using HospitalLite.Core.Common;
using HospitalLite.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalLite.Core.Entities
{
    public class Appointment : BaseEntity
    {
        public int PatientId { get; set; }
        public virtual AppUser Patient { get; set; } = null!; // Hasta aslında bir AppUser

        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; } = null!;

        public DateTime AppointmentDate { get; set; }
        public AppointmentStatus Status { get; set; } = AppointmentStatus.Scheduled;
    }
}
