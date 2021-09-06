using System;
using System.ComponentModel.DataAnnotations;

namespace CoCApp.Domain.Entities
{
    public class Investigator : DbEntity
    {
        [Key]
        public Guid Id { get; set; }

        public PersonalInformation PersonalInformation { get; set; }
        public Characteristics Characteristics { get; set; }
    }
}
