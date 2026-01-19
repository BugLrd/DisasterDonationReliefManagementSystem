CREATE DATABASE DisasterDonationReliefDB;
GO

USE DisasterDonationReliefDB;
GO


CREATE TABLE Login (
    LoginID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(255) NOT NULL,
    Role VARCHAR(20) NOT NULL
        CHECK (Role IN ('Manager', 'Admin', 'Victim', 'Donator', 'Volunteer')),
    Status BIT NOT NULL DEFAULT 0,
    Message VARCHAR(255) NOT NULL DEFAULT 'Your account isn''t activated yet. Contact administrator to activate.'
);

CREATE TABLE Admin (
    AdminID INT IDENTITY(1,1) PRIMARY KEY,
    LoginID INT NOT NULL UNIQUE,
    FullName VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL,

    CONSTRAINT FK_Admin_Login
        FOREIGN KEY (LoginID) REFERENCES Login(LoginID)
);

CREATE TABLE Victim (
    VictimID INT IDENTITY(1,1) PRIMARY KEY,
    LoginID INT NOT NULL UNIQUE,
    FullName VARCHAR(100) NOT NULL,
    Phone VARCHAR(20) NOT NULL,
    Address VARCHAR(255) NOT NULL,
    VerificationStatus VARCHAR(20) NOT NULL
        CHECK (VerificationStatus IN ('Pending', 'Verified', 'Rejected')),

    CONSTRAINT FK_Victim_Login
        FOREIGN KEY (LoginID) REFERENCES Login(LoginID)
);

CREATE TABLE Donator (
    DonatorID INT IDENTITY(1,1) PRIMARY KEY,
    LoginID INT NOT NULL UNIQUE,
    FullName VARCHAR(100) NOT NULL,
    Phone VARCHAR(20) NOT NULL,
    Address VARCHAR(255) NOT NULL,

    CONSTRAINT FK_Donator_Login
        FOREIGN KEY (LoginID) REFERENCES Login(LoginID)
);

CREATE TABLE Volunteer (
    VolunteerID INT IDENTITY(1,1) PRIMARY KEY,
    LoginID INT NOT NULL UNIQUE,
    FullName VARCHAR(100) NOT NULL,
    Phone VARCHAR(20) NOT NULL,
    VehicleType VARCHAR(50),
    AvailabilityStatus VARCHAR(20) NOT NULL
        CHECK (AvailabilityStatus IN ('Available', 'Busy', 'Inactive')),

    CONSTRAINT FK_Volunteer_Login
        FOREIGN KEY (LoginID) REFERENCES Login(LoginID)
);

CREATE TABLE DisasterRequest (
    RequestID INT IDENTITY(1,1) PRIMARY KEY,
    VictimID INT NOT NULL,
    DisasterTitle VARCHAR(100) NOT NULL,
    DisasterType VARCHAR(50) NOT NULL,
    Description TEXT,
    RequestedItems TEXT,
    NumberOfMembers INT NOT NULL,
    RequestDate DATETIME NOT NULL DEFAULT GETDATE(),
    Location VARCHAR(255) NOT NULL,
    RequestStatus VARCHAR(20) NOT NULL Default 'Pending'
        CHECK (RequestStatus IN ('Pending', 'Approved', 'Rejected', 'Completed')),

    CONSTRAINT FK_Request_Victim
        FOREIGN KEY (VictimID) REFERENCES Victim(VictimID)
);

CREATE TABLE Donation (
    DonationID INT IDENTITY(1,1) PRIMARY KEY,
    DonatorID INT NOT NULL,
    RequestID INT NOT NULL,
    DonationType VARCHAR(50) NOT NULL,
    ItemDetails TEXT NOT NULL,
    DonationDate DATETIME NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_Donation_Donator
        FOREIGN KEY (DonatorID) REFERENCES Donator(DonatorID),

    CONSTRAINT FK_Donation_Request
        FOREIGN KEY (RequestID) REFERENCES DisasterRequest(RequestID)
);

CREATE TABLE Delivery (
    DeliveryID INT IDENTITY(1,1) PRIMARY KEY,
    DonationID INT NOT NULL,
    VolunteerID INT NULL,
    PickupLocation VARCHAR(255) NOT NULL,
    DeliveryLocation VARCHAR(255) NOT NULL,
    DeliveryStatus VARCHAR(20) NOT NULL Default 'Pending'
        CHECK (DeliveryStatus IN ('Pending', 'Assigned', 'In Transit', 'Delivered', 'Self Delivered')),

    CONSTRAINT FK_Delivery_Donation
        FOREIGN KEY (DonationID) REFERENCES Donation(DonationID),

    CONSTRAINT FK_Delivery_Volunteer
        FOREIGN KEY (VolunteerID) REFERENCES Volunteer(VolunteerID)
);

