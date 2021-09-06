using System;
using System.ComponentModel.DataAnnotations;

namespace CoCApp.Domain.Entities
{
    public class PersonalInformation : DbEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Residence { get; set; }
        public string Birthplace { get; set; }

        public Guid InvestigatorId { get; set; }
        public Investigator Investigator { get; set; }
    }
}