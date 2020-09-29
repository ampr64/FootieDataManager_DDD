using Domain.Entities;
using Domain.ValueObjects;
using System;

namespace Domain.Common
{
    public abstract class Person : AuditableEntity<long>
    {
        public PersonName Name { get; protected set; }

        public int CountryId { get; protected set; }

        public Country Country { get; protected set; }

        public DateTime BirthDate { get; protected set; }

        public string PictureUrl { get; private set; }

        public int Age => CalculateAge();

        protected Person(string firstName, string lastName, int countryId, DateTime birthDate)
        {
            Name = PersonName.Of(firstName, lastName);
            CountryId = countryId;
            BirthDate = birthDate;
        }

        private int CalculateAge()
        {
            int age = DateTime.Today.Year - BirthDate.Year;
            return BirthDate.Date > DateTime.UtcNow.Date
                ? age -= 1
                : age;
        }
    }
}
