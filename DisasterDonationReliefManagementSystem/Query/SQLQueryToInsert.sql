INSERT INTO Login (Username, Password, Role, Status) VALUES
('admin1', 'pass123', 'Admin', 1),
('victim1', 'pass123', 'Victim', 1),
('victim2', 'pass123', 'Victim', 1),
('donator1', 'pass123', 'Donator', 1),
('volunteer1', 'pass123', 'Volunteer', 1);


INSERT INTO Admin (LoginID, FullName, Email) VALUES
(1, 'System Admin', 'admin@mail.com');


INSERT INTO Victim (LoginID, FullName, Phone, Address, VerificationStatus) VALUES
(2, 'Ali Ahmed', '01711111111', 'Dhaka', 'Verified'),
(3, 'Sara Khan', '01822222222', 'Chittagong', 'Pending');


INSERT INTO Donator (LoginID, FullName, Phone, Address) VALUES
(4, 'Rahim Uddin', '01933333333', 'Dhaka');


INSERT INTO Volunteer (LoginID, FullName, Phone, VehicleType, AvailabilityStatus) VALUES
(5, 'Karim Mia', '01644444444', 'Truck', 'Available');


INSERT INTO DisasterRequest 
(VictimID, DisasterTitle, DisasterType, Description, RequestedItems, NumberOfMembers, Location, RequestStatus)
VALUES
(1, 'Flood Relief', 'Flood', 'House submerged', 'Rice 10kg, Water 20L', 5, 'Sylhet', 'Pending'),
(2, 'Earthquake Help', 'Earthquake', 'Injured family', 'Medicine, Tent', 3, 'Dhaka', 'Approved');


INSERT INTO Donation
(DonatorID, RequestID, DonationType, ItemDetails, DonationStatus)
VALUES
(1, 1, 'Goods', 'Rice 10kg, Water 20L', 'Assigned'),
(1, 2, 'Goods', 'First Aid Kit x2', 'Pending');


INSERT INTO Delivery
(DonationID, VolunteerID, PickupLocation, DeliveryLocation, DeliveryStatus)
VALUES
(1, 1, 'Donator Address', 'Sylhet', 'Pending'),
(2, 1, 'Donator Address', 'Dhaka', 'In Transit');
