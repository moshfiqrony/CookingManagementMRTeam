-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 17, 2018 at 06:52 PM
-- Server version: 10.1.26-MariaDB
-- PHP Version: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `gooddfoodd`
--

-- --------------------------------------------------------

--
-- Table structure for table `authentication`
--

CREATE TABLE `authentication` (
  `id` int(11) NOT NULL,
  `UID` varchar(255) NOT NULL,
  `PWSD` varchar(255) NOT NULL,
  `PWR` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `authentication`
--

INSERT INTO `authentication` (`id`, `UID`, `PWSD`, `PWR`) VALUES
(1, 'mrid', 'mrid1234', 1),
(5, 'Rony', '1234', 0),
(6, '1', '1', 0),
(7, 'naiem', '12345', 0);

-- --------------------------------------------------------

--
-- Table structure for table `chalbazaar`
--

CREATE TABLE `chalbazaar` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `stock` double NOT NULL,
  `ratio` double NOT NULL,
  `perKg` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `chalbazaar`
--

INSERT INTO `chalbazaar` (`id`, `name`, `stock`, `ratio`, `perKg`) VALUES
(4, 'Polao Chal', 98, 0.2, 100),
(5, 'Normal Chal', 23, 0.2, 60);

-- --------------------------------------------------------

--
-- Table structure for table `dal`
--

CREATE TABLE `dal` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dal`
--

INSERT INTO `dal` (`id`, `name`) VALUES
(1, 'Mushur'),
(2, 'Mug'),
(3, 'Muri Ghonto');

-- --------------------------------------------------------

--
-- Table structure for table `egg`
--

CREATE TABLE `egg` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `egg`
--

INSERT INTO `egg` (`id`, `name`) VALUES
(1, 'Egg Vuna'),
(2, 'Egg Torkari');

-- --------------------------------------------------------

--
-- Table structure for table `fish`
--

CREATE TABLE `fish` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `stock` double NOT NULL,
  `ratio` double NOT NULL,
  `perKg` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `fish`
--

INSERT INTO `fish` (`id`, `name`, `stock`, `ratio`, `perKg`) VALUES
(2, 'Shorputi', 210, 0.142, 114.29),
(3, 'Gulsha', 0, 0.142, 0),
(4, 'Shing', 0, 0.142, 0),
(5, 'Boal', 10, 0.142, 0),
(6, 'Choto Mach', 25, 0.142, 0),
(7, 'Baiem', 0, 0.142, 0),
(8, 'Kalibaush', 0, 0.142, 20),
(9, 'Kachki', 0, 0.142, 0),
(10, 'Elish', 0, 0.142, 0),
(11, 'Koi', 0, 0.142, 0),
(12, 'Rui', 0, 0.142, 0),
(13, 'Mrigel', 0, 0.142, 0),
(14, 'Katol', 20, 0.142, 0),
(15, 'Bat', 0, 0.142, 0),
(16, 'Pabda', 10, 0.142, 0),
(17, 'Mola', 10, 0.142, 0),
(18, 'Dhela', 10, 0.142, 0),
(19, 'Koral', 0, 0.142, 0),
(20, 'Korolla', 10, 0.142, 0);

-- --------------------------------------------------------

--
-- Table structure for table `kacha_bazaar`
--

CREATE TABLE `kacha_bazaar` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `stock` double NOT NULL,
  `ratio` double NOT NULL,
  `perKg` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `mealhistory`
--

CREATE TABLE `mealhistory` (
  `id` int(11) NOT NULL,
  `date` date DEFAULT NULL,
  `item` varchar(255) NOT NULL,
  `amount` double NOT NULL,
  `PL` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mealhistory`
--

INSERT INTO `mealhistory` (`id`, `date`, `item`, `amount`, `PL`) VALUES
(14, '2017-11-18', 'Polao Chal', 11.25, ''),
(15, '2017-11-18', 'Chicken', 9, ''),
(16, '2017-11-18', 'Alu', 6.75, ''),
(17, '2017-11-18', 'Egg', 45, ''),
(18, '2017-11-18', 'Polao Chal', 2.5, ''),
(19, '2017-11-18', 'Chicken', 2, ''),
(20, '2017-11-18', 'Alu', 1.5, ''),
(21, '2017-11-18', 'Polao Chal', 25, ''),
(22, '2017-11-18', 'Chicken', 20, ''),
(23, '2017-11-18', 'Alu', 15, ''),
(24, '2017-11-18', 'Polao Chal', 2.5, ''),
(25, '2017-11-18', 'Polao Chal', 62.5, ''),
(26, '2017-11-18', 'Polao Chal', 62.5, ''),
(27, '2017-11-18', 'Chicken', 50, ''),
(28, '2017-11-18', 'Alu', 37.5, ''),
(29, '2017-11-18', 'Egg', 250, ''),
(30, '2017-11-19', 'Normal Chal', 2.5, ''),
(31, '2017-11-19', 'Chicken', 2, ''),
(32, '2017-11-19', 'Alu', 1.5, ''),
(33, '2017-11-22', 'Polao Chal', 6.25, ''),
(34, '2017-11-22', 'Chicken', 5, ''),
(35, '2017-11-22', 'Alu', 3.75, ''),
(36, '2017-11-22', 'Egg', 25, ''),
(37, '2017-11-22', 'Polao Chal', 2.5, ''),
(38, '2017-11-22', 'Polao Chal', 2.5, ''),
(39, '2017-11-22', 'Polao Chal', 2.5, ''),
(40, '2017-11-22', 'Polao Chal', 2.5, ''),
(41, '2017-11-22', 'Polao Chal', 2.5, ''),
(42, '2017-11-22', 'Normal Chal', 2.5, ''),
(43, '2017-11-22', 'Normal Chal', 2.5, ''),
(44, '2017-11-22', 'Normal Chal', 2.5, ''),
(45, '2017-11-23', 'Polao Chal', 2.5, ''),
(46, '2017-11-23', 'Polao Chal', 2.5, ''),
(47, '2017-11-23', 'Polao Chal', 2.5, ''),
(48, '2017-11-23', 'Normal Chal', 2.5, ''),
(49, '2017-11-23', 'Normal Chal', 2.5, ''),
(50, '2017-11-24', 'Normal Chal', 2.5, ''),
(51, '2017-11-24', 'Chicken', 2, ''),
(52, '2017-11-24', 'Alu', 1.5, ''),
(53, '2017-11-27', 'Polao Chal', 2, ''),
(54, '2017-11-27', 'Polao Chal', 2, ''),
(55, '2017-11-27', 'Chicken', 1.43, ''),
(56, '2017-11-27', 'Polao Chal', 2, 'Loss 150.Tk'),
(57, '2017-11-27', 'Polao Chal', 2, 'Loss 150.Tk'),
(58, '2017-11-27', 'Polao Chal', 2, '.Tk\nProfit 300.Tk'),
(59, '2017-11-27', 'Polao Chal', 2, '.Tk\nProfit 214.1.Tk'),
(60, '2017-11-27', 'Chicken', 1.43, '.Tk\nProfit 214.1.Tk'),
(61, '2017-11-27', 'Polao Chal', 2, 'Profit 400.Tk'),
(62, '2017-11-27', 'Normal Chal', 5, 'Profit 735.25.Tk'),
(63, '2017-11-27', 'Chicken', 3.575, 'Profit 735.25.Tk'),
(64, '2018-03-17', 'Normal Chal', 2, 'Profit 228.Tk'),
(65, '2018-03-17', 'Egg', 10, 'Profit 228.Tk'),
(66, '2018-03-17', 'Mushur', 2, 'Profit 228.Tk'),
(67, '2018-03-17', 'Chicken Moshla', 0.1, 'Profit 228.Tk');

-- --------------------------------------------------------

--
-- Table structure for table `meat`
--

CREATE TABLE `meat` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `meat`
--

INSERT INTO `meat` (`id`, `name`) VALUES
(1, 'Chicken Vuna'),
(2, 'Chicken Potato Curry'),
(3, 'Chilly Chicken'),
(4, 'Fried Chicken'),
(5, 'Roast'),
(6, 'Mutton Headneck Curry'),
(7, 'Mutton Kolija'),
(8, 'Duck');

-- --------------------------------------------------------

--
-- Table structure for table `meatbazaar`
--

CREATE TABLE `meatbazaar` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `stock` double NOT NULL,
  `ratio` double NOT NULL,
  `perKg` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `meatbazaar`
--

INSERT INTO `meatbazaar` (`id`, `name`, `stock`, `ratio`, `perKg`) VALUES
(2, 'Duck', 42, 0.2, 0),
(3, 'Mutton', 80, 0.1, 0),
(4, 'Egg', 160, 1, 0),
(5, 'Chicken', 3.565, 0.143, 130);

-- --------------------------------------------------------

--
-- Table structure for table `moshla`
--

CREATE TABLE `moshla` (
  `id` int(11) NOT NULL,
  `name` varchar(200) NOT NULL,
  `stock` double NOT NULL,
  `ratio` double NOT NULL,
  `perKg` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `moshla`
--

INSERT INTO `moshla` (`id`, `name`, `stock`, `ratio`, `perKg`) VALUES
(1, 'Chicken Moshla', 20, 0.01, 520);

-- --------------------------------------------------------

--
-- Table structure for table `rice`
--

CREATE TABLE `rice` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `rice`
--

INSERT INTO `rice` (`id`, `name`) VALUES
(1, 'Plane Rice'),
(2, 'Fried Rice'),
(3, 'Khichuri'),
(4, 'Tehari'),
(5, 'Biriani'),
(6, 'Chicken Biriani'),
(7, 'Chawmin Fried Rice Prawn');

-- --------------------------------------------------------

--
-- Table structure for table `shak`
--

CREATE TABLE `shak` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `shak`
--

INSERT INTO `shak` (`id`, `name`) VALUES
(1, 'Lal Shak'),
(2, 'Pui Shak'),
(3, 'Kolmi Shak'),
(4, 'Lau Shak'),
(5, 'Shorisha Shak');

-- --------------------------------------------------------

--
-- Table structure for table `shukna_bazaar`
--

CREATE TABLE `shukna_bazaar` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `stock` double NOT NULL,
  `ratio` double NOT NULL,
  `perKg` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `shukna_bazaar`
--

INSERT INTO `shukna_bazaar` (`id`, `name`, `stock`, `ratio`, `perKg`) VALUES
(1, 'Peaj', 15, 0.6, 0),
(2, 'Morich', 10, 0.5, 0),
(4, 'Ada', 0, 0, 0),
(5, 'Mug', 12, 0.06, 0),
(6, 'Mushur', 98, 0.2, 100);

-- --------------------------------------------------------

--
-- Table structure for table `veg_fry`
--

CREATE TABLE `veg_fry` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `veg_fry`
--

INSERT INTO `veg_fry` (`id`, `name`) VALUES
(1, 'Chal Kumra'),
(2, 'Korola'),
(3, 'Chichinga'),
(4, 'Misti Lau'),
(5, 'Potol'),
(6, 'Alu'),
(7, 'Borboti'),
(8, 'Dherosh'),
(9, 'Patakopi'),
(10, 'Fulkopi'),
(11, 'Alu Dim'),
(12, 'Macher Dim');

-- --------------------------------------------------------

--
-- Table structure for table `vorta`
--

CREATE TABLE `vorta` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `vorta`
--

INSERT INTO `vorta` (`id`, `name`) VALUES
(1, 'Alu'),
(2, 'Pepe'),
(3, 'Misti Lau'),
(4, 'Begun'),
(5, 'Shim'),
(6, 'Dal'),
(7, 'Mach'),
(8, 'Chicken'),
(9, 'Shutki'),
(10, 'Dim'),
(11, 'Potol'),
(12, 'Prawn'),
(13, 'Kacha Kola'),
(14, 'Kacha Tomato'),
(15, 'Dherosh'),
(16, 'Borboti'),
(17, 'Muhi Kochu'),
(18, 'Dhone Pata'),
(19, 'Tometo'),
(20, 'Ool');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `authentication`
--
ALTER TABLE `authentication`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `chalbazaar`
--
ALTER TABLE `chalbazaar`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `dal`
--
ALTER TABLE `dal`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `egg`
--
ALTER TABLE `egg`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `fish`
--
ALTER TABLE `fish`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `kacha_bazaar`
--
ALTER TABLE `kacha_bazaar`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `mealhistory`
--
ALTER TABLE `mealhistory`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `meat`
--
ALTER TABLE `meat`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `meatbazaar`
--
ALTER TABLE `meatbazaar`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `moshla`
--
ALTER TABLE `moshla`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `rice`
--
ALTER TABLE `rice`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `shak`
--
ALTER TABLE `shak`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `shukna_bazaar`
--
ALTER TABLE `shukna_bazaar`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `veg_fry`
--
ALTER TABLE `veg_fry`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `vorta`
--
ALTER TABLE `vorta`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `authentication`
--
ALTER TABLE `authentication`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `chalbazaar`
--
ALTER TABLE `chalbazaar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `dal`
--
ALTER TABLE `dal`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `egg`
--
ALTER TABLE `egg`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `fish`
--
ALTER TABLE `fish`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `kacha_bazaar`
--
ALTER TABLE `kacha_bazaar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `mealhistory`
--
ALTER TABLE `mealhistory`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=68;

--
-- AUTO_INCREMENT for table `meat`
--
ALTER TABLE `meat`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `meatbazaar`
--
ALTER TABLE `meatbazaar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `moshla`
--
ALTER TABLE `moshla`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `rice`
--
ALTER TABLE `rice`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `shak`
--
ALTER TABLE `shak`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `shukna_bazaar`
--
ALTER TABLE `shukna_bazaar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `veg_fry`
--
ALTER TABLE `veg_fry`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `vorta`
--
ALTER TABLE `vorta`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
