using System;

namespace CoCApp.Domain.Dtos
{
    public class PersonalInformation
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Residence { get; set; }
        public string Birthplace { get; set; }
    }
}
