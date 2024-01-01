﻿using WebClient.Models.Entities.Common;

namespace WebClient.Models.Entities
{
    public class Appointment : BaseEntity
    {
        public DateTime AppointmentDay { get; set; }
        public Guid PatientId { get; set; }
        public Patient Patient { get; set; }
        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
