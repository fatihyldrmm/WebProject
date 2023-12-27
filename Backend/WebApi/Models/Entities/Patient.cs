using WebApi.Models.Entities.Common;

namespace WebApi.Models.Entities
{
    public class Patient : BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
