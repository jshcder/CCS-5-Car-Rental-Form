-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 31, 2026 at 03:41 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `carrentaldb`
--

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `CategoryID` int(11) NOT NULL,
  `CategoryName` varchar(20) NOT NULL,
  `Description` varchar(100) DEFAULT NULL,
  `RatePerDay` decimal(8,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`CategoryID`, `CategoryName`, `Description`, `RatePerDay`) VALUES
(3001, 'Sedan', 'Economy cars for city driving', 1500.00),
(3002, 'SUV', 'Spacious vehicles for long trips', 2500.00),
(3003, 'Van', 'High-capacity vehicles for groups', 3000.00);

-- --------------------------------------------------------

--
-- Table structure for table `clerk`
--

CREATE TABLE `clerk` (
  `EmployeeID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `clerk`
--

INSERT INTO `clerk` (`EmployeeID`) VALUES
(1001),
(1002),
(1004);

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `CustomerID` int(11) NOT NULL,
  `CLastName` varchar(30) NOT NULL,
  `CFirstName` varchar(30) NOT NULL,
  `CMiddleName` varchar(30) DEFAULT NULL,
  `CStreet` varchar(50) NOT NULL,
  `CCity` varchar(30) NOT NULL,
  `CState` varchar(40) NOT NULL,
  `CZipCode` char(4) NOT NULL,
  `CContactNo` char(11) NOT NULL,
  `CEmail` varchar(50) DEFAULT NULL,
  `CDriverLicenseNo` char(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`CustomerID`, `CLastName`, `CFirstName`, `CMiddleName`, `CStreet`, `CCity`, `CState`, `CZipCode`, `CContactNo`, `CEmail`, `CDriverLicenseNo`) VALUES
(2001, 'Santos', 'Maria', 'Rosa', '123 Rizal St', 'Bacolod City', 'Negros Occidental', '6100', '09171112222', 'msantos@email.com', 'N01-23-456789'),
(2002, 'Johnson', 'Mike', 'Lee', '456 Mabini Ave', 'Cebu City', 'Cebu', '6000', '09282223333', 'mjohnson@email.com', 'N02-34-567890'),
(2003, 'Dela Cruz', 'Ana', 'Lim', '789 Aguinaldo St', 'Davao City', 'Davao del Sur', '8000', '09393334444', 'adelacruz@email.com', 'N03-45-678901');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `EmployeeID` int(11) NOT NULL,
  `ELastName` varchar(30) NOT NULL,
  `EFirstName` varchar(30) NOT NULL,
  `EMiddleName` varchar(30) DEFAULT NULL,
  `EContactNo` char(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`EmployeeID`, `ELastName`, `EFirstName`, `EMiddleName`, `EContactNo`) VALUES
(1001, 'Cruz', 'Juan', 'Pablo', '09171234567'),
(1002, 'Reyes', 'Anna', 'Marie', '09281234567'),
(1003, 'Smith', 'John', 'David', '09391234567'),
(1004, 'Garcia', 'Jose', 'Ramon', '09451234567'),
(1005, 'Lee', 'James', 'William', '09561234567'),
(1006, 'Mendoza', 'Rosa', 'Clara', '09671234567');

-- --------------------------------------------------------

--
-- Table structure for table `maintenance`
--

CREATE TABLE `maintenance` (
  `MaintenanceID` int(11) NOT NULL,
  `MaintenanceDate` date NOT NULL,
  `MaintenanceType` varchar(50) NOT NULL,
  `Description` varchar(200) NOT NULL,
  `Cost` decimal(8,2) NOT NULL,
  `MileageAtService` decimal(10,2) NOT NULL,
  `VehicleID` int(11) NOT NULL,
  `EmployeeID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `maintenance`
--

INSERT INTO `maintenance` (`MaintenanceID`, `MaintenanceDate`, `MaintenanceType`, `Description`, `Cost`, `MileageAtService`, `VehicleID`, `EmployeeID`) VALUES
(8001, '2026-02-15', 'Oil Change', 'Regular oil change and filter replacement', 1500.00, 14500.00, 4001, 1003),
(8002, '2026-02-20', 'Tire Rotation', 'Rotation of all four tires', 800.00, 21000.00, 4002, 1005),
(8003, '2026-03-01', 'Engine Check', 'Routine engine diagnostic and inspection', 2000.00, 44500.00, 4003, 1006);

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE `payment` (
  `RentalID` int(11) NOT NULL,
  `PaymentNo` int(11) NOT NULL,
  `PaymentDate` date NOT NULL,
  `AmountPaid` decimal(10,2) NOT NULL,
  `ReceiptNo` varchar(10) NOT NULL,
  `PaymentMethod` varchar(10) NOT NULL,
  `PaymentStatus` varchar(10) NOT NULL,
  `EmployeeID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `payment`
--

INSERT INTO `payment` (`RentalID`, `PaymentNo`, `PaymentDate`, `AmountPaid`, `ReceiptNo`, `PaymentMethod`, `PaymentStatus`, `EmployeeID`) VALUES
(5001, 7001, '2026-03-01', 6000.00, 'OR-0001', 'Cash', 'Full', 1001),
(5002, 7002, '2026-03-10', 12500.00, 'OR-0002', 'GCash', 'Full', 1002),
(5003, 7003, '2026-03-20', 6000.00, 'OR-0003', 'Cash', 'Full', 1004);

-- --------------------------------------------------------

--
-- Table structure for table `rental`
--

CREATE TABLE `rental` (
  `RentalID` int(11) NOT NULL,
  `DateRented` date NOT NULL,
  `DateDueReturn` date NOT NULL,
  `RentalStatus` varchar(10) NOT NULL,
  `CustomerID` int(11) NOT NULL,
  `VehicleID` int(11) NOT NULL,
  `EmployeeID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `rental`
--

INSERT INTO `rental` (`RentalID`, `DateRented`, `DateDueReturn`, `RentalStatus`, `CustomerID`, `VehicleID`, `EmployeeID`) VALUES
(5001, '2026-03-01', '2026-03-05', 'Returned', 2001, 4001, 1001),
(5002, '2026-03-10', '2026-03-15', 'Returned', 2002, 4002, 1002),
(5003, '2026-03-20', '2026-03-22', 'Returned', 2003, 4003, 1004);

-- --------------------------------------------------------

--
-- Table structure for table `return_t`
--

CREATE TABLE `return_t` (
  `RentalID` int(11) NOT NULL,
  `ReturnNo` int(11) NOT NULL,
  `ActualReturnDate` date NOT NULL,
  `MileageUponReturn` decimal(10,2) NOT NULL,
  `VehicleCondition` varchar(10) NOT NULL,
  `Notes` varchar(200) DEFAULT NULL,
  `EmployeeID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `return_t`
--

INSERT INTO `return_t` (`RentalID`, `ReturnNo`, `ActualReturnDate`, `MileageUponReturn`, `VehicleCondition`, `Notes`, `EmployeeID`) VALUES
(5001, 6001, '2026-03-05', 15350.00, 'Good', 'No issues', 1001),
(5002, 6002, '2026-03-16', 45280.00, 'Damaged', 'Minor scratches on bumper', 1002),
(5003, 6003, '2026-03-23', 28000.00, 'Good', 'Returned on time', 1004);

-- --------------------------------------------------------

--
-- Table structure for table `technician`
--

CREATE TABLE `technician` (
  `EmployeeID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `technician`
--

INSERT INTO `technician` (`EmployeeID`) VALUES
(1003),
(1005),
(1006);

-- --------------------------------------------------------

--
-- Table structure for table `vehicle`
--

CREATE TABLE `vehicle` (
  `VehicleID` int(11) NOT NULL,
  `Brand` varchar(30) NOT NULL,
  `Model` varchar(30) NOT NULL,
  `Year` year(4) NOT NULL,
  `Color` varchar(20) NOT NULL,
  `FuelType` varchar(10) NOT NULL,
  `Transmission` varchar(10) NOT NULL,
  `CurrentMileage` decimal(10,2) NOT NULL,
  `PlateNo` char(8) NOT NULL,
  `VStatus` varchar(20) NOT NULL,
  `CategoryID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `vehicle`
--

INSERT INTO `vehicle` (`VehicleID`, `Brand`, `Model`, `Year`, `Color`, `FuelType`, `Transmission`, `CurrentMileage`, `PlateNo`, `VStatus`, `CategoryID`) VALUES
(4001, 'Toyota', 'Vios', '2022', 'White', 'Gasoline', 'Automatic', 15000.00, 'ABC 1234', 'Available', 3001),
(4002, 'Honda', 'CR-V', '2021', 'Silver', 'Gasoline', 'Automatic', 22000.00, 'XYZ 5678', 'Available', 3002),
(4003, 'Toyota', 'HiAce', '2020', 'White', 'Diesel', 'Manual', 45000.00, 'DEF 9012', 'Available', 3003);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`CategoryID`);

--
-- Indexes for table `clerk`
--
ALTER TABLE `clerk`
  ADD PRIMARY KEY (`EmployeeID`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`CustomerID`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`EmployeeID`);

--
-- Indexes for table `maintenance`
--
ALTER TABLE `maintenance`
  ADD PRIMARY KEY (`MaintenanceID`),
  ADD KEY `VehicleID` (`VehicleID`),
  ADD KEY `EmployeeID` (`EmployeeID`);

--
-- Indexes for table `payment`
--
ALTER TABLE `payment`
  ADD PRIMARY KEY (`RentalID`,`PaymentNo`),
  ADD KEY `EmployeeID` (`EmployeeID`);

--
-- Indexes for table `rental`
--
ALTER TABLE `rental`
  ADD PRIMARY KEY (`RentalID`),
  ADD KEY `CustomerID` (`CustomerID`),
  ADD KEY `VehicleID` (`VehicleID`),
  ADD KEY `EmployeeID` (`EmployeeID`);

--
-- Indexes for table `return_t`
--
ALTER TABLE `return_t`
  ADD PRIMARY KEY (`RentalID`,`ReturnNo`),
  ADD KEY `EmployeeID` (`EmployeeID`);

--
-- Indexes for table `technician`
--
ALTER TABLE `technician`
  ADD PRIMARY KEY (`EmployeeID`);

--
-- Indexes for table `vehicle`
--
ALTER TABLE `vehicle`
  ADD PRIMARY KEY (`VehicleID`),
  ADD KEY `CategoryID` (`CategoryID`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `clerk`
--
ALTER TABLE `clerk`
  ADD CONSTRAINT `clerk_ibfk_1` FOREIGN KEY (`EmployeeID`) REFERENCES `employee` (`EmployeeID`);

--
-- Constraints for table `maintenance`
--
ALTER TABLE `maintenance`
  ADD CONSTRAINT `maintenance_ibfk_1` FOREIGN KEY (`VehicleID`) REFERENCES `vehicle` (`VehicleID`),
  ADD CONSTRAINT `maintenance_ibfk_2` FOREIGN KEY (`EmployeeID`) REFERENCES `technician` (`EmployeeID`);

--
-- Constraints for table `payment`
--
ALTER TABLE `payment`
  ADD CONSTRAINT `payment_ibfk_1` FOREIGN KEY (`RentalID`) REFERENCES `rental` (`RentalID`),
  ADD CONSTRAINT `payment_ibfk_2` FOREIGN KEY (`EmployeeID`) REFERENCES `clerk` (`EmployeeID`);

--
-- Constraints for table `rental`
--
ALTER TABLE `rental`
  ADD CONSTRAINT `rental_ibfk_1` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`),
  ADD CONSTRAINT `rental_ibfk_2` FOREIGN KEY (`VehicleID`) REFERENCES `vehicle` (`VehicleID`),
  ADD CONSTRAINT `rental_ibfk_3` FOREIGN KEY (`EmployeeID`) REFERENCES `clerk` (`EmployeeID`);

--
-- Constraints for table `return_t`
--
ALTER TABLE `return_t`
  ADD CONSTRAINT `return_t_ibfk_1` FOREIGN KEY (`RentalID`) REFERENCES `rental` (`RentalID`),
  ADD CONSTRAINT `return_t_ibfk_2` FOREIGN KEY (`EmployeeID`) REFERENCES `clerk` (`EmployeeID`);

--
-- Constraints for table `technician`
--
ALTER TABLE `technician`
  ADD CONSTRAINT `technician_ibfk_1` FOREIGN KEY (`EmployeeID`) REFERENCES `employee` (`EmployeeID`);

--
-- Constraints for table `vehicle`
--
ALTER TABLE `vehicle`
  ADD CONSTRAINT `vehicle_ibfk_1` FOREIGN KEY (`CategoryID`) REFERENCES `category` (`CategoryID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
