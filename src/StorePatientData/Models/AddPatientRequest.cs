using System;

namespace StorePatientData.Models
{
    public class AddPatientRequest
    {
        public string Name { get; set; }
        public string Surname1 { get; set; }
        public string Surname2 { get; set; }
        public long Number { get; set; }
    }
}