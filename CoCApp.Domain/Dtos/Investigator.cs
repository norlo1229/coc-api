using System;

namespace CoCApp.Domain.Dtos
{
    public class Investigator
    {
        public Guid Id { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
        public Characteristics Characteristics { get; set; }
    }
}
