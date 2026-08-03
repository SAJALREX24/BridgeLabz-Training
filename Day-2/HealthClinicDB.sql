CREATE DATABASE HealthClinicDB;
GO

USE HealthClinicDB;
GO

CREATE TABLE Patients
(
    PatientID INT PRIMARY KEY IDENTITY(1,1),
    PatientName VARCHAR(50) NOT NULL,
    Gender CHAR(1),
    DateOfBirth DATE,
    PhoneNumber VARCHAR(15),
    Email VARCHAR(100),
    Address VARCHAR(200)
);

CREATE TABLE Doctors
(
    DoctorID INT PRIMARY KEY IDENTITY(1,1),
    DoctorName VARCHAR(50) NOT NULL,
    Specialization VARCHAR(100),
    PhoneNumber VARCHAR(15),
    Email VARCHAR(100)
);

CREATE TABLE Appointments
(
    AppointmentID INT PRIMARY KEY IDENTITY(1,1),

    PatientID INT NOT NULL,
    DoctorID INT NOT NULL,

    AppointmentDate DATE NOT NULL,
    AppointmentTime TIME NOT NULL,

    Status VARCHAR(20),

    FOREIGN KEY (PatientID)
        REFERENCES Patients(PatientID)
        ON DELETE CASCADE,

    FOREIGN KEY (DoctorID)
        REFERENCES Doctors(DoctorID)
);
CREATE TABLE Rooms
(
    RoomID INT PRIMARY KEY IDENTITY(1,1),
    RoomNumber VARCHAR(10) NOT NULL UNIQUE,
    FloorNumber INT,
    RoomType VARCHAR(50)
);

CREATE TABLE Doctor_Room
(
    DoctorID INT NOT NULL,
    RoomID INT NOT NULL,

    PRIMARY KEY (DoctorID, RoomID),

    FOREIGN KEY (DoctorID)
        REFERENCES Doctors(DoctorID)
        ON DELETE CASCADE,

    FOREIGN KEY (RoomID)
        REFERENCES Rooms(RoomID)
        ON DELETE CASCADE
);

EXPLAIN
SELECT *
FROM Appointments
WHERE Status='Completed';

CREATE INDEX idx_status
ON Appointments(Status);

EXPLAIN
SELECT *
FROM Appointments
WHERE Status='Completed';

CREATE INDEX idx_doctor_date
ON Appointments(DoctorID, AppointmentDate);

EXPLAIN
SELECT *
FROM Appointments
WHERE DoctorID=2
AND AppointmentDate='2026-08-10';


CREATE TABLE Patient_Phones
(
    PatientID INT,
    PhoneNumber VARCHAR(15),
    PRIMARY KEY(PatientID, PhoneNumber),

    FOREIGN KEY(PatientID)
        REFERENCES Patients(PatientID)
);

SELECT
DoctorID,
AppointmentDate,
Status
FROM Appointments
WHERE DoctorID=2;

CREATE INDEX idx_covering
ON Appointments
(
    DoctorID,
    AppointmentDate,
    Status
);

EXPLAIN
SELECT
DoctorID,
AppointmentDate,
Status
FROM Appointments
WHERE DoctorID=2;
