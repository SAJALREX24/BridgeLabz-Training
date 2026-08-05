using System;

namespace HealthClinicApp.Entities
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string PatientName { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
}