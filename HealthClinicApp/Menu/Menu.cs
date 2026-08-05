using System;
using HealthClinicApp.Entities;
using HealthClinicApp.Services;

namespace HealthClinicApp.Menu
{
    public class MainMenu
    {
        private readonly DoctorService _doctorService;
        private readonly PatientService _patientService;
        private readonly AppointmentService _appointmentService;

        public MainMenu()
        {
            // Initialize our services
            _doctorService = new DoctorService();
            _patientService = new PatientService();
            _appointmentService = new AppointmentService();
        }

        public void Start()
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("\n========================================");
                Console.WriteLine("  HEALTH CLINIC MANAGEMENT SYSTEM");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Add a New Doctor");
                Console.WriteLine("2. Register a New Patient");
                Console.WriteLine("3. Schedule an Appointment");
                Console.WriteLine("4. Exit");
                Console.WriteLine("========================================");
                Console.Write("Enter your choice (1-4): ");

                string choice = Console.ReadLine() ?? string.Empty;

                switch (choice)
                {
                    case "1":
                        AddNewDoctorPrompt();
                        break;
                    case "2":
                        AddNewPatientPrompt();
                        break;
                    case "3":
                        AddAppointmentPrompt();
                        break;
                    case "4":
                        keepRunning = false;
                        Console.WriteLine("\nExiting System. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("\n[INVALID] Please enter a number between 1 and 4.");
                        break;
                }
            }
        }

        private void AddNewDoctorPrompt()
        {
            Console.WriteLine("\n--- Add New Doctor ---");
            Doctor newDoctor = new Doctor();
            
            Console.Write("Enter Doctor Name: ");
            newDoctor.DoctorName = Console.ReadLine() ?? string.Empty;
            
            Console.Write("Enter Specialization: ");
            newDoctor.Specialization = Console.ReadLine() ?? string.Empty;
            
            Console.Write("Enter Phone Number: ");
            newDoctor.PhoneNumber = Console.ReadLine() ?? string.Empty;
            
            Console.Write("Enter Email: ");
            newDoctor.Email = Console.ReadLine() ?? string.Empty;

            // Send to database
            _doctorService.AddDoctor(newDoctor);
        }

        private void AddNewPatientPrompt()
        {
            Console.WriteLine("\n--- Register New Patient ---");
            Patient newPatient = new Patient();
            
            Console.Write("Enter Patient Name: ");
            newPatient.PatientName = Console.ReadLine() ?? string.Empty;
            
            Console.Write("Enter Gender (M/F): ");
            newPatient.Gender = Console.ReadLine() ?? string.Empty;
            
            Console.Write("Enter Date of Birth (YYYY-MM-DD): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime dob))
            {
                newPatient.DateOfBirth = dob;
            }
            else
            {
                Console.WriteLine("Invalid Date. Defaulting to today.");
                newPatient.DateOfBirth = DateTime.Now;
            }

            Console.Write("Enter Phone Number: ");
            newPatient.PhoneNumber = Console.ReadLine() ?? string.Empty;
            
            Console.Write("Enter Email: ");
            newPatient.Email = Console.ReadLine() ?? string.Empty;
            
            Console.Write("Enter Address: ");
            newPatient.Address = Console.ReadLine() ?? string.Empty;

            // Send to database
            _patientService.AddPatient(newPatient);
        }

        private void AddAppointmentPrompt()
        {
            Console.WriteLine("\n--- Schedule Appointment ---");
            Appointment newAppt = new Appointment();
            
            Console.Write("Enter Patient ID (Must exist in database): ");
            int.TryParse(Console.ReadLine(), out int patientId);
            newAppt.PatientID = patientId;

            Console.Write("Enter Doctor ID (Must exist in database): ");
            int.TryParse(Console.ReadLine(), out int doctorId);
            newAppt.DoctorID = doctorId;

            Console.Write("Enter Appointment Date (YYYY-MM-DD): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime apptDate))
            {
                newAppt.AppointmentDate = apptDate;
            }

            Console.Write("Enter Appointment Time (HH:MM): ");
            if (TimeSpan.TryParse(Console.ReadLine(), out TimeSpan apptTime))
            {
                newAppt.AppointmentTime = apptTime;
            }

            newAppt.Status = "Scheduled";

            // Send to database
            _appointmentService.AddAppointment(newAppt);
        }
    }
}