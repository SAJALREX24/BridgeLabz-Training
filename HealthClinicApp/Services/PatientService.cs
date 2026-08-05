using System;
using Microsoft.Data.SqlClient;
using HealthClinicApp.Entities;

namespace HealthClinicApp.Services
{
    public class PatientService
    {
        private readonly string _connectionString = "Server=localhost;Database=HealthClinicDB;Integrated Security=True;TrustServerCertificate=True;";

        public void AddPatient(Patient patient)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddPatient", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    // Map to the SQL Parameters in your Stored Procedure
                    command.Parameters.AddWithValue("@PatientName", patient.PatientName);
                    command.Parameters.AddWithValue("@Gender", patient.Gender);
                    command.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth);
                    command.Parameters.AddWithValue("@PhoneNumber", patient.PhoneNumber);
                    command.Parameters.AddWithValue("@Email", patient.Email);
                    command.Parameters.AddWithValue("@Address", patient.Address);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        Console.WriteLine("\n[SUCCESS] Patient registered successfully in the database!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("\n[ERROR] Could not register patient: " + ex.Message);
                    }
                }
            }
        }
    }
}