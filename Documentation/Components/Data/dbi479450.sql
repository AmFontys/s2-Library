-- phpMyAdmin SQL Dump
-- version 4.9.3
-- https://www.phpmyadmin.net/
--
-- Host: studmysql01.fhict.local
-- Generation Time: Mar 04, 2022 at 10:00 AM
-- Server version: 5.7.26-log
-- PHP Version: 7.4.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbi479450`
--

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE `account` (
  `AccountID` int(11) NOT NULL,
  `Firstname` varchar(50) NOT NULL,
  `Lastname` varchar(100) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `Telephone` varchar(20) DEFAULT NULL,
  `Streetname` varchar(50) NOT NULL,
  `housenumber` varchar(10) NOT NULL,
  `Zipcode` varchar(20) NOT NULL,
  `City` varchar(50) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Keyword` varchar(10) NOT NULL,
  `CardID` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `apply`
--

CREATE TABLE `apply` (
  `ApplyID` int(11) NOT NULL,
  `AccountID` int(11) NOT NULL,
  `PositionID` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Available` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `available`
--

CREATE TABLE `available` (
  `AvailableID` int(11) NOT NULL,
  `WorkerID` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Available` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `bookinfo`
--

CREATE TABLE `bookinfo` (
  `BookID` int(11) NOT NULL,
  `ItemID` int(11) NOT NULL,
  `Pages` int(11) NOT NULL,
  `Author` varchar(50) NOT NULL,
  `Publisher` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `events`
--

CREATE TABLE `events` (
  `EventID` int(11) NOT NULL,
  `EventTypeID` int(11) NOT NULL,
  `EventName` varchar(255) NOT NULL,
  `EventDate` date DEFAULT NULL,
  `EventCost` decimal(10,0) DEFAULT NULL,
  `EventOpeningtime` varchar(6) NOT NULL,
  `EventClosingtime` varchar(6) NOT NULL,
  `EventDescription` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `eventtype`
--

CREATE TABLE `eventtype` (
  `EventTypeID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `genre`
--

CREATE TABLE `genre` (
  `ItemID` int(11) NOT NULL,
  `GenreTypeID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `genretype`
--

CREATE TABLE `genretype` (
  `GenreTypeID` int(11) NOT NULL,
  `GenreName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `item`
--

CREATE TABLE `item` (
  `ItemID` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `ISBN` varchar(30) NOT NULL,
  `Language` varchar(255) DEFAULT NULL,
  `Description` text NOT NULL,
  `cost` decimal(10,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `level`
--

CREATE TABLE `level` (
  `LevelID` int(11) NOT NULL,
  `Levelname` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `movieinfo`
--

CREATE TABLE `movieinfo` (
  `MovieID` int(11) NOT NULL,
  `ItemID` int(11) NOT NULL,
  `SubtitleLanguage` varchar(255) DEFAULT NULL,
  `Producer` varchar(255) NOT NULL,
  `timeInMin` int(11) NOT NULL,
  `Demographic` varchar(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `openinghours`
--

CREATE TABLE `openinghours` (
  `ID` int(11) NOT NULL,
  `OpeningDate` date NOT NULL,
  `Openingtime` date NOT NULL,
  `Closingtime` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `position`
--

CREATE TABLE `position` (
  `PositionID` int(11) NOT NULL,
  `PositionName` varchar(80) NOT NULL,
  `Startingsalary` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `recommendation`
--

CREATE TABLE `recommendation` (
  `RecID` int(11) NOT NULL,
  `AccountID` int(11) NOT NULL,
  `Title` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `reservation`
--

CREATE TABLE `reservation` (
  `ReservationID` int(11) NOT NULL,
  `itemID` int(11) NOT NULL,
  `AccountID` int(11) NOT NULL,
  `StartDate` date NOT NULL,
  `Enddate` date NOT NULL,
  `Extended` int(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `schedule`
--

CREATE TABLE `schedule` (
  `ScheduleID` int(11) NOT NULL,
  `AvailableID` int(11) NOT NULL,
  `Date` date NOT NULL,
  `beginninghour` varchar(6) NOT NULL,
  `Endhour` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `signup`
--

CREATE TABLE `signup` (
  `AccountID` int(11) NOT NULL,
  `EventID` int(11) NOT NULL,
  `SignupDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `worker`
--

CREATE TABLE `worker` (
  `WorkerID` int(11) NOT NULL,
  `AccountID` int(11) NOT NULL,
  `PositionID` int(11) NOT NULL,
  `Workerlevel` int(11) NOT NULL,
  `BankAccount` varchar(100) DEFAULT NULL,
  `Citizenservicenumber` varchar(50) DEFAULT NULL,
  `salary` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`AccountID`);

--
-- Indexes for table `apply`
--
ALTER TABLE `apply`
  ADD PRIMARY KEY (`ApplyID`),
  ADD KEY `AccountID` (`AccountID`),
  ADD KEY `PositionID` (`PositionID`);

--
-- Indexes for table `available`
--
ALTER TABLE `available`
  ADD PRIMARY KEY (`AvailableID`),
  ADD KEY `WorkerID` (`WorkerID`);

--
-- Indexes for table `bookinfo`
--
ALTER TABLE `bookinfo`
  ADD PRIMARY KEY (`BookID`),
  ADD KEY `ItemID` (`ItemID`);

--
-- Indexes for table `events`
--
ALTER TABLE `events`
  ADD PRIMARY KEY (`EventID`),
  ADD KEY `EventTypeID` (`EventTypeID`);

--
-- Indexes for table `eventtype`
--
ALTER TABLE `eventtype`
  ADD PRIMARY KEY (`EventTypeID`);

--
-- Indexes for table `genre`
--
ALTER TABLE `genre`
  ADD KEY `ItemID` (`ItemID`),
  ADD KEY `GenreTypeID` (`GenreTypeID`);

--
-- Indexes for table `genretype`
--
ALTER TABLE `genretype`
  ADD PRIMARY KEY (`GenreTypeID`);

--
-- Indexes for table `item`
--
ALTER TABLE `item`
  ADD PRIMARY KEY (`ItemID`);

--
-- Indexes for table `level`
--
ALTER TABLE `level`
  ADD PRIMARY KEY (`LevelID`);

--
-- Indexes for table `movieinfo`
--
ALTER TABLE `movieinfo`
  ADD PRIMARY KEY (`MovieID`),
  ADD KEY `ItemID` (`ItemID`);

--
-- Indexes for table `openinghours`
--
ALTER TABLE `openinghours`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `position`
--
ALTER TABLE `position`
  ADD PRIMARY KEY (`PositionID`);

--
-- Indexes for table `recommendation`
--
ALTER TABLE `recommendation`
  ADD PRIMARY KEY (`RecID`),
  ADD KEY `AccountID` (`AccountID`);

--
-- Indexes for table `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`ReservationID`),
  ADD KEY `itemID` (`itemID`),
  ADD KEY `AccountID` (`AccountID`);

--
-- Indexes for table `schedule`
--
ALTER TABLE `schedule`
  ADD PRIMARY KEY (`ScheduleID`),
  ADD KEY `AvailableID` (`AvailableID`);

--
-- Indexes for table `signup`
--
ALTER TABLE `signup`
  ADD KEY `AccountID` (`AccountID`),
  ADD KEY `EventID` (`EventID`);

--
-- Indexes for table `worker`
--
ALTER TABLE `worker`
  ADD PRIMARY KEY (`WorkerID`),
  ADD KEY `AccountID` (`AccountID`),
  ADD KEY `Workerlevel` (`Workerlevel`),
  ADD KEY `PositionID` (`PositionID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `account`
--
ALTER TABLE `account`
  MODIFY `AccountID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `apply`
--
ALTER TABLE `apply`
  MODIFY `ApplyID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `available`
--
ALTER TABLE `available`
  MODIFY `AvailableID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `bookinfo`
--
ALTER TABLE `bookinfo`
  MODIFY `BookID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `events`
--
ALTER TABLE `events`
  MODIFY `EventID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `eventtype`
--
ALTER TABLE `eventtype`
  MODIFY `EventTypeID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `genretype`
--
ALTER TABLE `genretype`
  MODIFY `GenreTypeID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `item`
--
ALTER TABLE `item`
  MODIFY `ItemID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `level`
--
ALTER TABLE `level`
  MODIFY `LevelID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `movieinfo`
--
ALTER TABLE `movieinfo`
  MODIFY `MovieID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `openinghours`
--
ALTER TABLE `openinghours`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `position`
--
ALTER TABLE `position`
  MODIFY `PositionID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `recommendation`
--
ALTER TABLE `recommendation`
  MODIFY `RecID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `reservation`
--
ALTER TABLE `reservation`
  MODIFY `ReservationID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `schedule`
--
ALTER TABLE `schedule`
  MODIFY `ScheduleID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `worker`
--
ALTER TABLE `worker`
  MODIFY `WorkerID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `account`
--
ALTER TABLE `account`
  ADD CONSTRAINT `account_ibfk_1` FOREIGN KEY (`AccountID`) REFERENCES `reservation` (`AccountID`);

--
-- Constraints for table `apply`
--
ALTER TABLE `apply`
  ADD CONSTRAINT `apply_ibfk_1` FOREIGN KEY (`AccountID`) REFERENCES `account` (`AccountID`),
  ADD CONSTRAINT `apply_ibfk_2` FOREIGN KEY (`AccountID`) REFERENCES `account` (`AccountID`),
  ADD CONSTRAINT `apply_ibfk_3` FOREIGN KEY (`AccountID`) REFERENCES `account` (`AccountID`),
  ADD CONSTRAINT `apply_ibfk_4` FOREIGN KEY (`AccountID`) REFERENCES `account` (`AccountID`),
  ADD CONSTRAINT `apply_ibfk_5` FOREIGN KEY (`AccountID`) REFERENCES `account` (`AccountID`),
  ADD CONSTRAINT `apply_ibfk_6` FOREIGN KEY (`PositionID`) REFERENCES `position` (`PositionID`);

--
-- Constraints for table `available`
--
ALTER TABLE `available`
  ADD CONSTRAINT `available_ibfk_1` FOREIGN KEY (`WorkerID`) REFERENCES `worker` (`WorkerID`),
  ADD CONSTRAINT `available_ibfk_2` FOREIGN KEY (`WorkerID`) REFERENCES `worker` (`WorkerID`),
  ADD CONSTRAINT `available_ibfk_3` FOREIGN KEY (`WorkerID`) REFERENCES `worker` (`WorkerID`),
  ADD CONSTRAINT `available_ibfk_4` FOREIGN KEY (`WorkerID`) REFERENCES `worker` (`WorkerID`),
  ADD CONSTRAINT `available_ibfk_5` FOREIGN KEY (`WorkerID`) REFERENCES `worker` (`WorkerID`),
  ADD CONSTRAINT `available_ibfk_6` FOREIGN KEY (`WorkerID`) REFERENCES `worker` (`WorkerID`);

--
-- Constraints for table `bookinfo`
--
ALTER TABLE `bookinfo`
  ADD CONSTRAINT `bookinfo_ibfk_1` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`),
  ADD CONSTRAINT `bookinfo_ibfk_2` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`),
  ADD CONSTRAINT `bookinfo_ibfk_3` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`);

--
-- Constraints for table `events`
--
ALTER TABLE `events`
  ADD CONSTRAINT `events_ibfk_1` FOREIGN KEY (`EventTypeID`) REFERENCES `eventtype` (`EventTypeID`),
  ADD CONSTRAINT `events_ibfk_2` FOREIGN KEY (`EventTypeID`) REFERENCES `eventtype` (`EventTypeID`),
  ADD CONSTRAINT `events_ibfk_3` FOREIGN KEY (`EventTypeID`) REFERENCES `eventtype` (`EventTypeID`);

--
-- Constraints for table `genre`
--
ALTER TABLE `genre`
  ADD CONSTRAINT `genre_ibfk_1` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`),
  ADD CONSTRAINT `genre_ibfk_2` FOREIGN KEY (`GenreTypeID`) REFERENCES `genretype` (`GenreTypeID`),
  ADD CONSTRAINT `genre_ibfk_3` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`),
  ADD CONSTRAINT `genre_ibfk_4` FOREIGN KEY (`GenreTypeID`) REFERENCES `genretype` (`GenreTypeID`),
  ADD CONSTRAINT `genre_ibfk_5` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`),
  ADD CONSTRAINT `genre_ibfk_6` FOREIGN KEY (`GenreTypeID`) REFERENCES `genretype` (`GenreTypeID`);

--
-- Constraints for table `movieinfo`
--
ALTER TABLE `movieinfo`
  ADD CONSTRAINT `movieinfo_ibfk_1` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`),
  ADD CONSTRAINT `movieinfo_ibfk_2` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`),
  ADD CONSTRAINT `movieinfo_ibfk_3` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`);

--
-- Constraints for table `recommendation`
--
ALTER TABLE `recommendation`
  ADD CONSTRAINT `recommendation_ibfk_1` FOREIGN KEY (`AccountID`) REFERENCES `account` (`AccountID`),
  ADD CONSTRAINT `recommendation_ibfk_2` FOREIGN KEY (`AccountID`) REFERENCES `account` (`AccountID`),
  ADD CONSTRAINT `recommendation_ibfk_3` FOREIGN KEY (`AccountID`) REFERENCES `account` (`AccountID`);

--
-- Constraints for table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `reservation_ibfk_1` FOREIGN KEY (`itemID`) REFERENCES `item` (`ItemID`);

--
-- Constraints for table `schedule`
--
ALTER TABLE `schedule`
  ADD CONSTRAINT `schedule_ibfk_1` FOREIGN KEY (`AvailableID`) REFERENCES `available` (`AvailableID`),
  ADD CONSTRAINT `schedule_ibfk_2` FOREIGN KEY (`AvailableID`) REFERENCES `available` (`AvailableID`),
  ADD CONSTRAINT `schedule_ibfk_3` FOREIGN KEY (`AvailableID`) REFERENCES `available` (`AvailableID`),
  ADD CONSTRAINT `schedule_ibfk_4` FOREIGN KEY (`AvailableID`) REFERENCES `available` (`AvailableID`),
  ADD CONSTRAINT `schedule_ibfk_5` FOREIGN KEY (`AvailableID`) REFERENCES `available` (`AvailableID`),
  ADD CONSTRAINT `schedule_ibfk_6` FOREIGN KEY (`AvailableID`) REFERENCES `available` (`AvailableID`);

--
-- Constraints for table `signup`
--
ALTER TABLE `signup`
  ADD CONSTRAINT `signup_ibfk_1` FOREIGN KEY (`AccountID`) REFERENCES `account` (`AccountID`),
  ADD CONSTRAINT `signup_ibfk_2` FOREIGN KEY (`EventID`) REFERENCES `events` (`EventID`),
  ADD CONSTRAINT `signup_ibfk_3` FOREIGN KEY (`AccountID`) REFERENCES `account` (`AccountID`),
  ADD CONSTRAINT `signup_ibfk_4` FOREIGN KEY (`EventID`) REFERENCES `events` (`EventID`),
  ADD CONSTRAINT `signup_ibfk_5` FOREIGN KEY (`AccountID`) REFERENCES `account` (`AccountID`),
  ADD CONSTRAINT `signup_ibfk_6` FOREIGN KEY (`EventID`) REFERENCES `events` (`EventID`),
  ADD CONSTRAINT `signup_ibfk_7` FOREIGN KEY (`AccountID`) REFERENCES `account` (`AccountID`),
  ADD CONSTRAINT `signup_ibfk_8` FOREIGN KEY (`EventID`) REFERENCES `events` (`EventID`);

--
-- Constraints for table `worker`
--
ALTER TABLE `worker`
  ADD CONSTRAINT `worker_ibfk_1` FOREIGN KEY (`AccountID`) REFERENCES `account` (`AccountID`),
  ADD CONSTRAINT `worker_ibfk_10` FOREIGN KEY (`Workerlevel`) REFERENCES `level` (`LevelID`),
  ADD CONSTRAINT `worker_ibfk_11` FOREIGN KEY (`AccountID`) REFERENCES `account` (`AccountID`),
  ADD CONSTRAINT `worker_ibfk_12` FOREIGN KEY (`Workerlevel`) REFERENCES `level` (`LevelID`),
  ADD CONSTRAINT `worker_ibfk_13` FOREIGN KEY (`AccountID`) REFERENCES `account` (`AccountID`),
  ADD CONSTRAINT `worker_ibfk_14` FOREIGN KEY (`Workerlevel`) REFERENCES `level` (`LevelID`),
  ADD CONSTRAINT `worker_ibfk_15` FOREIGN KEY (`AccountID`) REFERENCES `account` (`AccountID`),
  ADD CONSTRAINT `worker_ibfk_16` FOREIGN KEY (`Workerlevel`) REFERENCES `level` (`LevelID`),
  ADD CONSTRAINT `worker_ibfk_17` FOREIGN KEY (`PositionID`) REFERENCES `position` (`PositionID`),
  ADD CONSTRAINT `worker_ibfk_2` FOREIGN KEY (`AccountID`) REFERENCES `account` (`AccountID`),
  ADD CONSTRAINT `worker_ibfk_3` FOREIGN KEY (`AccountID`) REFERENCES `account` (`AccountID`),
  ADD CONSTRAINT `worker_ibfk_4` FOREIGN KEY (`Workerlevel`) REFERENCES `level` (`LevelID`),
  ADD CONSTRAINT `worker_ibfk_5` FOREIGN KEY (`AccountID`) REFERENCES `account` (`AccountID`),
  ADD CONSTRAINT `worker_ibfk_6` FOREIGN KEY (`Workerlevel`) REFERENCES `level` (`LevelID`),
  ADD CONSTRAINT `worker_ibfk_7` FOREIGN KEY (`AccountID`) REFERENCES `account` (`AccountID`),
  ADD CONSTRAINT `worker_ibfk_8` FOREIGN KEY (`Workerlevel`) REFERENCES `level` (`LevelID`),
  ADD CONSTRAINT `worker_ibfk_9` FOREIGN KEY (`AccountID`) REFERENCES `account` (`AccountID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
