using System;
using System.Collections.Generic;
using StorePatientData.Models;

namespace StoreData.DataAccess.Repositories
{
    public interface IPatientRepository
    {
        Guid Add(AddPatientRequest patient);
        Patient Get(int number);
        IEnumerable<Patient> Get();
    }
}
