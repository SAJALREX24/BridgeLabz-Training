using System;
using Microsoft.Data.SqlClient;
using HealthClinicApp.Entities;

namespace HealthClinicApp.Services
{
    public class AppointmentService
    {
        private readonly string _connectionString = "Server=localhost;Database=HealthClinicDB;Integrated Security=True;TrustServerCertificate=True;";

        public void AddAppointment(Appointment appointment)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddAppointment", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PatientID", appointment.PatientID);
                    command.Parameters.AddWithValue("@DoctorID", appointment.DoctorID);
                    command.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
                    command.Parameters.AddWithValue("@AppointmentTime", appointment.AppointmentTime);
                    command.Parameters.AddWithValue("@Status", appointment.Status);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        Console.WriteLine("\n[SUCCESS] Appointment scheduled successfully!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("\n[ERROR] Could not schedule appointment: " + ex.Message);
                    }
                }
            }
        }
    }
}