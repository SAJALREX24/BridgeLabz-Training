
/*

Hospital Patient Management System
● Concepts: Patient, Doctor, Bill classes.
● OOP: Encapsulation (Properties), Abstraction (Interface IPayable), Inheritance
(InPatient, OutPatient : Patient), Polymorphism (DisplayInfo).

*/

using System;

// Interface representing bill payment behavior 
interface IPayable
{
    double CalculateBill();
}

// Base class 
class PatientBase
{
    // Encapsulated properties
    public int PatientCode { get; set; }
    public string PatientName { get; set; }

    // Virtual method to support polymorphism
    public virtual void ShowDetails()
    {
        Console.WriteLine("Patient ID: " + PatientCode);
        Console.WriteLine("Name: " + PatientName);
    }
}


class InPatientRecord : PatientBase, IPayable
{
   
    public int StayDays;
    public double ChargePerDay;
    public double CalculateBill()
    {
        return StayDays * ChargePerDay;
    }
    public override void ShowDetails()
    {
        Console.WriteLine("In-Patient Details:");
        base.ShowDetails();
        Console.WriteLine("Days Admitted: " + StayDays);
        Console.WriteLine("Total Bill: " + CalculateBill());
    }
}


class OutPatientRecord : PatientBase, IPayable
{
   
    public double VisitFee;

    
    public double CalculateBill()
    {
        return VisitFee;
    }

    // Displays out-patient details
    public override void ShowDetails()
    {
        Console.WriteLine("Out-Patient Details:");
        base.ShowDetails();
        Console.WriteLine("Consultation Fee: " + CalculateBill());
    }
}

// Main class
class HospitalProgram
{
    static void Main()
    {
        // Creating in-patient object using base class reference
        PatientBase patientOne = new InPatientRecord
        {
            PatientCode = 201,
            PatientName = "Patient A",
            StayDays = 5,
            ChargePerDay = 2000
        };

        // Creating out-patient object using base class reference
        PatientBase patientTwo = new OutPatientRecord
        {
            PatientCode = 202,
            PatientName = "Patient B",
            VisitFee = 500
        };

        // Demonstrating polymorphism
        patientOne.ShowDetails();
        Console.WriteLine();

        patientTwo.ShowDetails();
    }
}
