using Domain.Entities;
using Domain.Common.ValueObjects;
using System;

namespace Domain.Common
{
    public abstract class Person : AuditableEntity<long>
    {
        public PersonName Name { get; protected set; }

        public int CountryId { get; protected set; }

        public Country Country { get; protected set; }

        public decimal Height { get; private set; }

        public decimal Weight { get; private set; }

        public DateTime BirthDate { get; protected set; }

        public string PictureUrl { get; private set; }

        public int Age => GetAge();

        protected Person() { }

        protected Person(PersonName name, int countryId, decimal height, decimal weight, DateTime birthDate)
        {
            Name = name;
            CountryId = countryId;
            Height = height;
            Weight = weight;
            BirthDate = birthDate;
        }

        private int GetAge()
        {
            int age = DateTime.Today.Year - BirthDate.Year;
            return BirthDate.Date > DateTime.UtcNow.Date
                ? age--
                : age;
        }
    }
}
