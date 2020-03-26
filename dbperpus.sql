-- phpMyAdmin SQL Dump
-- version 4.8.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 26, 2018 at 11:30 PM
-- Server version: 10.1.32-MariaDB
-- PHP Version: 5.6.36

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbperpus`
--

-- --------------------------------------------------------

--
-- Table structure for table `dbmember`
--

CREATE TABLE `dbmember` (
  `kd_member` char(10) NOT NULL,
  `nama` varchar(20) NOT NULL,
  `j_kelamin` varchar(10) NOT NULL,
  `alamat` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dbmember`
--

INSERT INTO `dbmember` (`kd_member`, `nama`, `j_kelamin`, `alamat`) VALUES
('001', 'Jenita', 'Wanita', 'Solo'),
('002', 'Ajik', 'Pria', 'Semarang'),
('003', 'Eni', 'Wanita', 'Solo'),
('004', 'aslan', 'Pria', 'sana'),
('005', 'Toto', 'Pria', 'Karanganyar');

-- --------------------------------------------------------

--
-- Table structure for table `sewa`
--

CREATE TABLE `sewa` (
  `id` char(20) NOT NULL,
  `kd_member` varchar(20) NOT NULL,
  `kd_buku` varchar(20) NOT NULL,
  `jumlah` int(225) NOT NULL,
  `tgl_sewa` varchar(25) NOT NULL,
  `tgl_kembali` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sewa`
--

INSERT INTO `sewa` (`id`, `kd_member`, `kd_buku`, `jumlah`, `tgl_sewa`, `tgl_kembali`) VALUES
('ID002', '005', 'BJ01', 1, '26/12/2018', '29/12/2018'),
('ID01', '002', 'BJ01', 2, '26/12/2018', '29/12/2018');

-- --------------------------------------------------------

--
-- Table structure for table `tbbuku`
--

CREATE TABLE `tbbuku` (
  `kd_buku` char(20) NOT NULL,
  `nama_buku` varchar(25) NOT NULL,
  `penerbit` varchar(20) NOT NULL,
  `jumlah` int(225) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbbuku`
--

INSERT INTO `tbbuku` (`kd_buku`, `nama_buku`, `penerbit`, `jumlah`) VALUES
('BJ01', 'BJ HABIBIE', 'Erlangga', 23);

-- --------------------------------------------------------

--
-- Table structure for table `tbkembali`
--

CREATE TABLE `tbkembali` (
  `id` char(20) NOT NULL,
  `kd_member` varchar(25) NOT NULL,
  `kd_buku` varchar(20) NOT NULL,
  `jumlah` varchar(25) NOT NULL,
  `tgl_pinjam` varchar(25) NOT NULL,
  `tgl_pengembalian` varchar(30) NOT NULL,
  `denda` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbkembali`
--

INSERT INTO `tbkembali` (`id`, `kd_member`, `kd_buku`, `jumlah`, `tgl_pinjam`, `tgl_pengembalian`, `denda`) VALUES
('ID01', '002', 'BJ01', '2', '26/12/2018', '27/12/2018', '10000');

-- --------------------------------------------------------

--
-- Table structure for table `tblogin`
--

CREATE TABLE `tblogin` (
  `username` char(20) NOT NULL,
  `password` varchar(225) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblogin`
--

INSERT INTO `tblogin` (`username`, `password`) VALUES
('admin', 'admin'),
('cahyo', 'cahyo'),
('galang', 'galang');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `dbmember`
--
ALTER TABLE `dbmember`
  ADD PRIMARY KEY (`kd_member`);

--
-- Indexes for table `sewa`
--
ALTER TABLE `sewa`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbbuku`
--
ALTER TABLE `tbbuku`
  ADD PRIMARY KEY (`kd_buku`);

--
-- Indexes for table `tbkembali`
--
ALTER TABLE `tbkembali`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblogin`
--
ALTER TABLE `tblogin`
  ADD PRIMARY KEY (`username`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
