using StorePatientData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using StoreData.DataAccess.EntityConfiguration;
using Voxel.Billback.Infrastructure.Repositories;

namespace StoreData.DataAccess.Repositories
{
    public class PatientRepository : BaseRepository<Patient>, IPatientRepository
    {
        private readonly List<Patient> _patients;

        public PatientRepository(TransactionContext transactionContext) : base(transactionContext)
        {
            _patients = new List<Patient>
            {
                new Patient(Guid.NewGuid(), "Xavi", "Garcia", "Vera", 101),
                new Patient(Guid.NewGuid(), "Luis", "Salamó", "Fragatí", 102),
                new Patient(Guid.NewGuid(), "Juan", "Mateu", "Cadea", 103),
                new Patient(Guid.NewGuid(), "Noé", "Violero", null, 104),
                new Patient(Guid.NewGuid(), "Xavi", "Sanchez", "Jefe", 105)
            };
        }

        public Guid Add(AddPatientRequest addedPatient)
        {

            var patient = new Patient(Guid.NewGuid(), addedPatient.Name, addedPatient.Surname1, addedPatient.Surname2, addedPatient.Number);

            transactionContext.Add(patient);
            transactionContext.SaveChanges();

            return patient.Id;
        }

        public Patient Get(int number)
        {
            return _patients.FirstOrDefault(patient => patient.Number == number);
        }

        public IEnumerable<Patient> Get()
        {
            return _patients;
        }
    }
}
