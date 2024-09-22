-- Create the PARENT table with a unique constraint on Contact_no
CREATE TABLE [PARENT](
    [Parent_id] INT PRIMARY KEY IDENTITY(1,1),
    [FullName] VARCHAR(50),
    [Contact_no] VARCHAR(20) UNIQUE -- Unique constraint to ensure unique contact numbers
);

-- Create the CHILD table with a unique constraint on (FullName, DateOfBirth)
CREATE TABLE [CHILD](
    [Child_id] INT PRIMARY KEY IDENTITY(1,1),
    [FullName] VARCHAR(50),
    [DateOfBirth] DATE CHECK (DATEDIFF(YEAR, DateOfBirth, GETDATE()) <= 2),
    [Gender] VARCHAR(25),
    [Parent_id] INT FOREIGN KEY REFERENCES [PARENT]([Parent_id]),
    UNIQUE ([FullName], [DateOfBirth]) -- Unique constraint to ensure unique child information
);

CREATE TABLE [QUALIFICATION](
    [Qualification_id] INT PRIMARY KEY IDENTITY(1,1),
    [Qualification_name] VARCHAR(50)
);

CREATE TABLE [HOSPITAL](
    [Hospital_id] INT PRIMARY KEY IDENTITY(1,1),
    [Hospital_name] VARCHAR(50),
    [Hospital_contact] VARCHAR(20) -- Assuming Hospital_contact is a string
);

CREATE TABLE [DOCTOR](
    [Doctor_id] INT PRIMARY KEY IDENTITY(1,1),
    [FullName] VARCHAR(50),
    [Qualification_id] INT FOREIGN KEY REFERENCES [QUALIFICATION]([Qualification_id]),
    [Hospital_id] INT FOREIGN KEY REFERENCES [HOSPITAL]([Hospital_id])
);
-- Create the Vaccine_intake table with Dose_id as a foreign key
CREATE TABLE [Vaccine_intake] (
    [Vaccine_intake_id] INT PRIMARY KEY IDENTITY(1,1),
    [Child_id] INT FOREIGN KEY REFERENCES [CHILD]([Child_id]),
    [Vaccine_id] INT FOREIGN KEY REFERENCES [VACCINE]([Vaccine_id]),
    [Doctor_id] INT FOREIGN KEY REFERENCES [DOCTOR]([Doctor_id]),
    [TimeOfVaccine] VARCHAR(50),
    [Date] DATE
);

CREATE TABLE [APPOINTMENT] (
    [Appointment_id] INT PRIMARY KEY IDENTITY(1,1),
    [Doctor_id] INT FOREIGN KEY REFERENCES [DOCTOR]([Doctor_id]),
    [Child_id] INT FOREIGN KEY REFERENCES [CHILD]([Child_id]),
    [Appointment_date] DATE,
    [Appointment_time] TIME
);
CREATE TABLE [VACCINE] (
    [Vaccine_id] INT PRIMARY KEY IDENTITY(1,1),
    [Vaccine_name] VARCHAR(50),
    [Child_id] INT, -- Ensure this column exists and is of the correct type
    FOREIGN KEY ([Child_id]) REFERENCES [CHILD]([Child_id])
);
