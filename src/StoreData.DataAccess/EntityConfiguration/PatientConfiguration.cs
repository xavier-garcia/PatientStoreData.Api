using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StorePatientData.Models;

namespace StoreData.DataAccess.EntityConfiguration
{
    internal class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable("Patient", TransactionContext.DEFAULT_SCHEMA);

            // PK
            builder.HasKey(patient => patient.Id);

            builder.Property(patient => patient.Number);
            builder.Property(patient => patient.Name);
            builder.Property(patient => patient.Surname1);
            builder.Property(patient => patient.Surname2);
        }
    }
}
