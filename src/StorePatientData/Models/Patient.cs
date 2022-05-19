using System;

namespace StorePatientData.Models
{
    public class Patient
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Surname1 { get; }
        public string Surname2 { get; }
        public long Number { get; }

        public Patient(Guid id, string name, string surname1, string surname2, long number)
        {
            Id = id;
            Name = name;
            Surname1 = surname1;
            Surname2 = surname2;
            Number = number;
        }
    }
}