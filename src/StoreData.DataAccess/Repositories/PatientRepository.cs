using StorePatientData.Models;
using System;

namespace StoreData.DataAccess.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        public Guid Add(AddPatientRequest addedPatient)
        {
            var patient = new Patient(Guid.NewGuid(), addedPatient.Name, addedPatient.Surname1, addedPatient.Surname2, addedPatient.Number);
            return patient.Id;
        }

        public Patient Get(int number)
        {
            return new Patient(Guid.NewGuid(), "Xavi", "Garcia", "Vera", number);
        }
    }
}
