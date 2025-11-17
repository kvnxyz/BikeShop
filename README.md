1. Download ka muna ng XAMPP eto link: https://sourceforge.net/projects/xampp/files/XAMPP%20Windows/8.2.12/xampp-windows-x64-8.2.12-0-VS16-installer.exe/download

2. Gawa ka ng DataBase Table ipangalan mo "bikeinventorysystem".

3. Punta ka Privileges tapos "Add new account" lagay mo sa user: username sa password: password123. Then Gloval Privilege Check All

4. Punta ka sa ginawa mong Database "bikeinventorysystem" then import: [bikeinventorysystem.sql](https://github.com/user-attachments/files/23575231/bikeinventorysystem.sql)

-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 17, 2025 at 06:52 AM
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
-- Database: `bikeinventorysystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

CREATE TABLE `accounts` (
  `Email` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`Email`, `Password`) VALUES
('sampleemail@gmail.com', '123');

-- --------------------------------------------------------

--
-- Table structure for table `parts`
--

CREATE TABLE `parts` (
  `PartID` int(10) UNSIGNED NOT NULL,
  `ItemName` varchar(255) NOT NULL,
  `ItemType` varchar(255) NOT NULL,
  `BikeCategory` varchar(255) NOT NULL,
  `Quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `parts`
--

INSERT INTO `parts` (`PartID`, `ItemName`, `ItemType`, `BikeCategory`, `Quantity`) VALUES
(1, 'Red Frame', 'Frame', 'Road', 25),
(2, 'frame', 'yellow', 'Mountain', 0),
(3, 'frame', 'black', 'Road', 0),
(4, 'Handle Bar', 'Blue', 'Mountain', 0),
(5, 'Crankbrothers iodine 11 handlebars', 'Handle Bar', 'Mountain', 0);

-- --------------------------------------------------------

--
-- Table structure for table `testparts`
--

CREATE TABLE `testparts` (
  `PartID` int(11) NOT NULL,
  `ItemType` varchar(50) NOT NULL,
  `ItemName` varchar(50) NOT NULL,
  `BikeCategory` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`Email`);

--
-- Indexes for table `parts`
--
ALTER TABLE `parts`
  ADD PRIMARY KEY (`PartID`);

--
-- Indexes for table `testparts`
--
ALTER TABLE `testparts`
  ADD PRIMARY KEY (`PartID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `parts`
--
ALTER TABLE `parts`
  MODIFY `PartID` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `testparts`
--
ALTER TABLE `testparts`
  MODIFY `PartID` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
