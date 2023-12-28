using WebApi.Models.Entities.Common;

namespace WebApi.Models.Entities
{
    public class Policlinic : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }

}
