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

CREATE TABLE SystemAuditLog
(
    AuditID INT PRIMARY KEY IDENTITY(1,1),
    TableName VARCHAR(50) NOT NULL,          -- Name of the modified table ('Patients', 'Doctors', 'Appointments')
    RecordID INT NOT NULL,                 -- Primary Key value of the changed record
    ActionType VARCHAR(10) NOT NULL,        -- 'INSERT', 'UPDATE', or 'DELETE'
    OldData NVARCHAR(MAX) NULL,             -- JSON snapshot of data before change
    NewData NVARCHAR(MAX) NULL,             -- JSON snapshot of data after change
    ChangedBy VARCHAR(100) DEFAULT SYSTEM_USER,
    ChangedAt DATETIME DEFAULT GETDATE()
);

CREATE TRIGGER trg_Patients_Audit
ON Patients
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Handle INSERT
    IF EXISTS (SELECT 1 FROM inserted) AND NOT EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO SystemAuditLog (TableName, RecordID, ActionType, OldData, NewData)
        SELECT 
            'Patients',
            i.PatientID,
            'INSERT',
            NULL,
            (SELECT i.PatientID, i.PatientName, i.Gender, i.DateOfBirth, i.PhoneNumber, i.Email, i.Address FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)
        FROM inserted i;
    END

    -- Handle UPDATE
    ELSE IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO SystemAuditLog (TableName, RecordID, ActionType, OldData, NewData)
        SELECT 
            'Patients',
            i.PatientID,
            'UPDATE',
            (SELECT d.PatientID, d.PatientName, d.Gender, d.DateOfBirth, d.PhoneNumber, d.Email, d.Address FOR JSON PATH, WITHOUT_ARRAY_WRAPPER),
            (SELECT i.PatientID, i.PatientName, i.Gender, i.DateOfBirth, i.PhoneNumber, i.Email, i.Address FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)
        FROM inserted i
        INNER JOIN deleted d ON i.PatientID = d.PatientID;
    END

    -- Handle DELETE
    ELSE IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        INSERT INTO SystemAuditLog (TableName, RecordID, ActionType, OldData, NewData)
        SELECT 
            'Patients',
            d.PatientID,
            'DELETE',
            (SELECT d.PatientID, d.PatientName, d.Gender, d.DateOfBirth, d.PhoneNumber, d.Email, d.Address FOR JSON PATH, WITHOUT_ARRAY_WRAPPER),
            NULL
        FROM deleted d;
    END
END;
GO

CREATE TRIGGER trg_Doctors_Audit
ON Doctors
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Handle INSERT
    IF EXISTS (SELECT 1 FROM inserted) AND NOT EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO SystemAuditLog (TableName, RecordID, ActionType, OldData, NewData)
        SELECT 
            'Doctors',
            i.DoctorID,
            'INSERT',
            NULL,
            (SELECT i.DoctorID, i.DoctorName, i.Specialization, i.PhoneNumber, i.Email FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)
        FROM inserted i;
    END

    -- Handle UPDATE
    ELSE IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO SystemAuditLog (TableName, RecordID, ActionType, OldData, NewData)
        SELECT 
            'Doctors',
            i.DoctorID,
            'UPDATE',
            (SELECT d.DoctorID, d.DoctorName, d.Specialization, d.PhoneNumber, d.Email FOR JSON PATH, WITHOUT_ARRAY_WRAPPER),
            (SELECT i.DoctorID, i.DoctorName, i.Specialization, i.PhoneNumber, i.Email FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)
        FROM inserted i
        INNER JOIN deleted d ON i.DoctorID = d.DoctorID;
    END

    -- Handle DELETE
    ELSE IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        INSERT INTO SystemAuditLog (TableName, RecordID, ActionType, OldData, NewData)
        SELECT 
            'Doctors',
            d.DoctorID,
            'DELETE',
            (SELECT d.DoctorID, d.DoctorName, d.Specialization, d.PhoneNumber, d.Email FOR JSON PATH, WITHOUT_ARRAY_WRAPPER),
            NULL
        FROM deleted d;
    END
END;
GO

CREATE TRIGGER trg_Appointments_Audit
ON Appointments
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Handle INSERT
    IF EXISTS (SELECT 1 FROM inserted) AND NOT EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO SystemAuditLog (TableName, RecordID, ActionType, OldData, NewData)
        SELECT 
            'Appointments',
            i.AppointmentID,
            'INSERT',
            NULL,
            (SELECT i.AppointmentID, i.PatientID, i.DoctorID, i.AppointmentDate, i.AppointmentTime, i.Status FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)
        FROM inserted i;
    END

    -- Handle UPDATE
    ELSE IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO SystemAuditLog (TableName, RecordID, ActionType, OldData, NewData)
        SELECT 
            'Appointments',
            i.AppointmentID,
            'UPDATE',
            (SELECT d.AppointmentID, d.PatientID, d.DoctorID, d.AppointmentDate, d.AppointmentTime, d.Status FOR JSON PATH, WITHOUT_ARRAY_WRAPPER),
            (SELECT i.AppointmentID, i.PatientID, i.DoctorID, i.AppointmentDate, i.AppointmentTime, i.Status FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)
        FROM inserted i
        INNER JOIN deleted d ON i.AppointmentID = d.AppointmentID;
    END

    -- Handle DELETE
    ELSE IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        INSERT INTO SystemAuditLog (TableName, RecordID, ActionType, OldData, NewData)
        SELECT 
            'Appointments',
            d.AppointmentID,
            'DELETE',
            (SELECT d.AppointmentID, d.PatientID, d.DoctorID, d.AppointmentDate, d.AppointmentTime, d.Status FOR JSON PATH, WITHOUT_ARRAY_WRAPPER),
            NULL
        FROM deleted d;
    END
END;
GO

-- Create Patient
CREATE PROCEDURE sp_AddPatient
    @PatientName VARCHAR(50),
    @Gender CHAR(1),
    @DateOfBirth DATE,
    @PhoneNumber VARCHAR(15),
    @Email VARCHAR(100),
    @Address VARCHAR(200)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        INSERT INTO Patients (PatientName, Gender, DateOfBirth, PhoneNumber, Email, Address)
        VALUES (@PatientName, @Gender, @DateOfBirth, @PhoneNumber, @Email, @Address);
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END;
GO

-- Get Patient by ID
CREATE PROCEDURE sp_GetPatientByID
    @PatientID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT PatientID, PatientName, Gender, DateOfBirth, PhoneNumber, Email, Address
    FROM Patients
    WHERE PatientID = @PatientID;
END;
GO

-- Update Patient
CREATE PROCEDURE sp_UpdatePatient
    @PatientID INT,
    @PatientName VARCHAR(50),
    @Gender CHAR(1),
    @DateOfBirth DATE,
    @PhoneNumber VARCHAR(15),
    @Email VARCHAR(100),
    @Address VARCHAR(200)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        UPDATE Patients
        SET PatientName = @PatientName,
            Gender = @Gender,
            DateOfBirth = @DateOfBirth,
            PhoneNumber = @PhoneNumber,
            Email = @Email,
            Address = @Address
        WHERE PatientID = @PatientID;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END;
GO

-- Delete Patient
CREATE PROCEDURE sp_DeletePatient
    @PatientID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        -- Note: Due to ON DELETE CASCADE on Appointments, patient appointments will also be deleted.
        DELETE FROM Patients
        WHERE PatientID = @PatientID;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END;
GO

-- Create Doctor
CREATE PROCEDURE sp_AddDoctor
    @DoctorName VARCHAR(50),
    @Specialization VARCHAR(100),
    @PhoneNumber VARCHAR(15),
    @Email VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        INSERT INTO Doctors (DoctorName, Specialization, PhoneNumber, Email)
        VALUES (@DoctorName, @Specialization, @PhoneNumber, @Email);
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END;
GO

-- Get Doctor by ID
CREATE PROCEDURE sp_GetDoctorByID
    @DoctorID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT DoctorID, DoctorName, Specialization, PhoneNumber, Email
    FROM Doctors
    WHERE DoctorID = @DoctorID;
END;
GO

-- Update Doctor
CREATE PROCEDURE sp_UpdateDoctor
    @DoctorID INT,
    @DoctorName VARCHAR(50),
    @Specialization VARCHAR(100),
    @PhoneNumber VARCHAR(15),
    @Email VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        UPDATE Doctors
        SET DoctorName = @DoctorName,
            Specialization = @Specialization,
            PhoneNumber = @PhoneNumber,
            Email = @Email
        WHERE DoctorID = @DoctorID;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END;
GO

-- Delete Doctor
CREATE PROCEDURE sp_DeleteDoctor
    @DoctorID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        DELETE FROM Doctors
        WHERE DoctorID = @DoctorID;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END;
GO

-- Create Appointment
CREATE PROCEDURE sp_AddAppointment
    @PatientID INT,
    @DoctorID INT,
    @AppointmentDate DATE,
    @AppointmentTime TIME,
    @Status VARCHAR(20) = 'Scheduled'
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        INSERT INTO Appointments (PatientID, DoctorID, AppointmentDate, AppointmentTime, Status)
        VALUES (@PatientID, @DoctorID, @AppointmentDate, @AppointmentTime, @Status);
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END;
GO

-- Get Appointment Details by ID (Includes Patient and Doctor Info)
CREATE PROCEDURE sp_GetAppointmentDetails
    @AppointmentID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        a.AppointmentID,
        p.PatientName,
        d.DoctorName,
        d.Specialization,
        a.AppointmentDate,
        a.AppointmentTime,
        a.Status
    FROM Appointments a
    INNER JOIN Patients p ON a.PatientID = p.PatientID
    INNER JOIN Doctors d ON a.DoctorID = d.DoctorID
    WHERE a.AppointmentID = @AppointmentID;
END;
GO

-- Update Appointment (Reschedule or Change Status)
CREATE PROCEDURE sp_UpdateAppointment
    @AppointmentID INT,
    @AppointmentDate DATE,
    @AppointmentTime TIME,
    @Status VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        UPDATE Appointments
        SET AppointmentDate = @AppointmentDate,
            AppointmentTime = @AppointmentTime,
            Status = @Status
        WHERE AppointmentID = @AppointmentID;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END;
GO

-- Cancel/Delete Appointment
CREATE PROCEDURE sp_DeleteAppointment
    @AppointmentID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        DELETE FROM Appointments
        WHERE AppointmentID = @AppointmentID;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END;
GO