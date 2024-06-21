-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 18, 2024 at 03:46 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `eshop`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

CREATE TABLE `accounts` (
  `Id` int(11) NOT NULL,
  `Username` varchar(255) COLLATE utf8_vietnamese_ci NOT NULL,
  `Password` varchar(255) COLLATE utf8_vietnamese_ci NOT NULL,
  `Email` varchar(255) COLLATE utf8_vietnamese_ci DEFAULT NULL,
  `Phone` varchar(255) COLLATE utf8_vietnamese_ci DEFAULT NULL,
  `Address` varchar(255) COLLATE utf8_vietnamese_ci DEFAULT NULL,
  `FullName` varchar(255) COLLATE utf8_vietnamese_ci DEFAULT NULL,
  `IsAdmin` tinyint(4) NOT NULL DEFAULT 0,
  `Avatar` varchar(255) COLLATE utf8_vietnamese_ci DEFAULT NULL,
  `Status` tinyint(4) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_vietnamese_ci;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`Id`, `Username`, `Password`, `Email`, `Phone`, `Address`, `FullName`, `IsAdmin`, `Avatar`, `Status`) VALUES
(1, 'admin', 'admin', 'admin@eshop.com', '0123456789', 'Tp.Hồ Chí Minh', 'Nguyễn Văn Ad Min', 1, 'admin.jpg', 1),
(2, 'john', '123456', 'john@gmail.com', '0905486957', 'Đà Nẵng', 'John Henry', 0, 'john.jpg', 1),
(3, 'dhphuoc', '123456', 'dhphuoc@gmail.com', '0904863125', 'Tp.Hồ Chí Minh', 'Dương Hữu Phước', 0, 'dhphuoc.jpg', 1),
(4, 'longvic', '123456', 'longvic@gmail.com', '0459123845', 'Nha Trang', 'Long Vic', 0, 'longvic.jpg', 1),
(5, 'customer', '123456', 'customer@gmail.com', '0987654321', 'Huế', 'Trần Thị B', 0, 'customer.jpg', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accounts`
--
ALTER TABLE `accounts`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
