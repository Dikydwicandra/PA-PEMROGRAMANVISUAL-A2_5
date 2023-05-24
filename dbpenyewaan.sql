-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 24, 2023 at 04:09 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbpenyewaan`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbakun`
--

CREATE TABLE `tbakun` (
  `idAkun` int(100) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `notelp` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbakun`
--

INSERT INTO `tbakun` (`idAkun`, `nama`, `notelp`, `password`) VALUES
(1, 'admin', '', 'admin123'),
(2, 'admin', '', 'admin123');

-- --------------------------------------------------------

--
-- Table structure for table `tbfutsal`
--

CREATE TABLE `tbfutsal` (
  `id` int(3) NOT NULL,
  `nama` varchar(250) NOT NULL,
  `nohp` varchar(20) NOT NULL,
  `totaljam` int(3) NOT NULL,
  `hari` varchar(10) NOT NULL,
  `jam` varchar(10) NOT NULL,
  `totalharga` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbfutsal`
--

INSERT INTO `tbfutsal` (`id`, `nama`, `nohp`, `totaljam`, `hari`, `jam`, `totalharga`) VALUES
(1, 'Rafi new', '08262622', 1, 'Rabu', '13 ', 30000),
(2, 'Rizki', '0827226151', 1, 'Selasa', '10 ', 30000),
(3, 'Ulu new', '08272727', 1, 'Senin', '8 ', 30000),
(4, 'Aji', '0826262555', 1, 'Rabu', '15 ', 30000);

-- --------------------------------------------------------

--
-- Table structure for table `tbminisoccer`
--

CREATE TABLE `tbminisoccer` (
  `id` int(3) NOT NULL,
  `nama` varchar(250) NOT NULL,
  `nohp` varchar(20) NOT NULL,
  `totaljam` int(3) NOT NULL,
  `hari` varchar(10) NOT NULL,
  `jam` varchar(10) NOT NULL,
  `totalharga` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbminisoccer`
--

INSERT INTO `tbminisoccer` (`id`, `nama`, `nohp`, `totaljam`, `hari`, `jam`, `totalharga`) VALUES
(1, 'Diky', '08282828282', 2, 'Rabu', '11 15 ', 60000),
(2, 'Dillah', '08262626', 2, 'Kamis', '11 10 ', 60000),
(3, 'Zaku New', '0827272727', 1, 'Selasa', '14 ', 30000),
(4, 'Lana', '082525252', 2, 'Selasa', '17 16 ', 60000),
(5, 'Ardi new', '082525254', 2, 'Senin', '22 21 ', 100000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbakun`
--
ALTER TABLE `tbakun`
  ADD PRIMARY KEY (`idAkun`);

--
-- Indexes for table `tbfutsal`
--
ALTER TABLE `tbfutsal`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbminisoccer`
--
ALTER TABLE `tbminisoccer`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbakun`
--
ALTER TABLE `tbakun`
  MODIFY `idAkun` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbfutsal`
--
ALTER TABLE `tbfutsal`
  MODIFY `id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tbminisoccer`
--
ALTER TABLE `tbminisoccer`
  MODIFY `id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
