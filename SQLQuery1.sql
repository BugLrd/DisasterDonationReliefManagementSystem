-- Create Database
CREATE DATABASE DisasterReliefDB;
GO

-- Use the Database
USE DisasterReliefDB;
GO

--------------------------------------------------
-- USERS TABLE
--------------------------------------------------
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    Phone VARCHAR(15) NOT NULL,
    Address VARCHAR(150) NOT NULL,
    Role VARCHAR(20) NOT NULL, -- Admin, Victim, Donator, Volunteer
    Status VARCHAR(20) NOT NULL
);
GO

--------------------------------------------------
-- LOGIN TABLE
--------------------------------------------------
CREATE TABLE Login (
    LoginID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL,
    Password VARCHAR(100) NOT NULL,
    CONSTRAINT FK_Login_User
        FOREIGN KEY (UserID)
        REFERENCES Users(UserID)
        ON DELETE CASCADE
);
GO

--------------------------------------------------
-- DISASTER REQUESTS TABLE
--------------------------------------------------
CREATE TABLE DisasterRequests (
    RequestID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL, -- Victim
    DisasterType VARCHAR(50) NOT NULL,
    Description VARCHAR(255),
    RequestedItems VARCHAR(255) NOT NULL,
    RequestDate DATETIME NOT NULL,
    RequestStatus VARCHAR(20) NOT NULL,
    CONSTRAINT FK_Request_User
        FOREIGN KEY (UserID)
        REFERENCES Users(UserID)
);
GO

--------------------------------------------------
-- DONATIONS TABLE
--------------------------------------------------
CREATE TABLE Donations (
    DonationID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL, -- Donator
    RequestID INT NOT NULL,
    DonationType VARCHAR(20) NOT NULL, -- Goods / Money
    ItemDetails VARCHAR(255),
    Quantity INT,
    DonationDate DATETIME NOT NULL,
    DonationStatus VARCHAR(20) NOT NULL,
    CONSTRAINT FK_Donation_User
        FOREIGN KEY (UserID)
        REFERENCES Users(UserID),
    CONSTRAINT FK_Donation_Request
        FOREIGN KEY (RequestID)
        REFERENCES DisasterRequests(RequestID)
);
GO

--------------------------------------------------
-- DELIVERY TABLE
--------------------------------------------------
CREATE TABLE Deliveries (
    DeliveryID INT IDENTITY(1,1) PRIMARY KEY,
    DonationID INT NOT NULL,
    UserID INT NOT NULL, -- Volunteer
    PickupLocation VARCHAR(150) NOT NULL,
    DeliveryLocation VARCHAR(150) NOT NULL,
    DeliveryStatus VARCHAR(20) NOT NULL,
    CONSTRAINT FK_Delivery_Donation
        FOREIGN KEY (DonationID)
        REFERENCES Donations(DonationID),
    CONSTRAINT FK_Delivery_User
        FOREIGN KEY (UserID)
        REFERENCES Users(UserID)
);
GO