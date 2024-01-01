using HospitalBackend.Models.Entities.Common;

namespace HospitalBackend.Models.Entities
{
    public class Policlinic : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }

}
