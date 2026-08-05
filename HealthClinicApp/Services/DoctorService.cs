using System;
using Microsoft.Data.SqlClient;
using HealthClinicApp.Entities;

namespace HealthClinicApp.Services
{
    public class DoctorService
    {
        // This connection string tells C# exactly where your SQL Server is located.
        private readonly string _connectionString = "Server=localhost;Database=HealthClinicDB;Integrated Security=True;TrustServerCertificate=True;";

        public void AddDoctor(Doctor doctor)
        {
            // 1. Establish the connection to SQL Server
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                // 2. Call the Stored Procedure you created in SSMS
                using (SqlCommand command = new SqlCommand("sp_AddDoctor", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    // 3. Map the C# Object properties to the SQL Parameters
                    command.Parameters.AddWithValue("@DoctorName", doctor.DoctorName);
                    command.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                    command.Parameters.AddWithValue("@PhoneNumber", doctor.PhoneNumber);
                    command.Parameters.AddWithValue("@Email", doctor.Email);

                    try
                    {
                        // 4. Open the connection and execute the command
                        connection.Open();
                        command.ExecuteNonQuery();
                        Console.WriteLine("\n[SUCCESS] Doctor added successfully to the database!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("\n[ERROR] Could not add doctor: " + ex.Message);
                    }
                }
            }
        }
    }
}