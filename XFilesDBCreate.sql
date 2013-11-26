#####################################
# XFiles Animal Observation Database
# 
# Database creation MySql script
#
# CSCI320 DBMS
# 11/25/13
#
# Josh Harmon & Kali McKee
#####################################
use XFiles;

# Drop tables if they already exist
DROP TABLE IF EXISTS Group_T;
DROP TABLE IF EXISTS Observation_T;
DROP TABLE IF EXISTS Observer_T;
DROP TABLE IF EXISTS Location_T;
DROP TABLE IF EXISTS Address_T;
DROP TABLE IF EXISTS Animal_T;

# Create Tables
CREATE TABLE Address_T
		(AddressID		INT NOT NULL AUTO_INCREMENT,
		 State 			VARCHAR(16),
		 StreetName		VARCHAR(45),
		 BuildingNumber VARCHAR(16),
		 ZipCode		VARCHAR(5),
CONSTRAINT PRIMARY KEY (AddressID));

CREATE TABLE Animal_T
		(AnimalID 		INT NOT NULL AUTO_INCREMENT,
		 CommonName		VARCHAR(45) NOT NULL,
		 Genus 			VARCHAR(60),
		 Species 		VARCHAR(60),
		 Characteristics VARCHAR(255),
CONSTRAINT PRIMARY KEY (AnimalID));

CREATE TABLE Observer_T
		(ObserverID		INT NOT NULL AUTO_INCREMENT,
		 AddressID		INT NOT NULL,
		 FirstName		VARCHAR(45) NOT NULL,
		 LastName  		VARCHAR(45) NOT NULL,
		 Credentials	ENUM ("Student", "Professor", "Staff", "Visitor", "Other"),
		 PhoneNumber_1	VARCHAR(12) NOT NULL,
		 PhoneNumber_2	VARCHAR(12),
		 EmailAddress	VARCHAR(60) NOT NULL,
CONSTRAINT PRIMARY KEY (ObserverID),
CONSTRAINT FOREIGN KEY (AddressID) REFERENCES Address_T(AddressID) ON UPDATE CASCADE ON DELETE CASCADE);

CREATE TABLE Location_T
		(LocationID		INT NOT NULL AUTO_INCREMENT,
		 AddressID		INT NOT NULL,
		 OfficialName	VARCHAR(45) NOT NULL,
CONSTRAINT PRIMARY KEY (LocationID),
CONSTRAINT FOREIGN KEY (AddressID) REFERENCES Address_T(AddressID) ON UPDATE CASCADE ON DELETE CASCADE);

CREATE TABLE Group_T
		(GroupID		INT NOT NULL AUTO_INCREMENT,
		 ObserverID		INT NOT NULL,
		 GroupName		VARCHAR(45),
		 Active			BOOL NOT NULL DEFAULT TRUE,
CONSTRAINT Group_PK PRIMARY KEY (GroupID),
CONSTRAINT FOREIGN KEY (ObserverID) REFERENCES Observer_T(ObserverID) ON UPDATE CASCADE ON DELETE CASCADE);

CREATE TABLE Observation_T
		(ObservationID	INT NOT NULL AUTO_INCREMENT,
		 LocationID		INT NOT NULL,
		 AnimalID		INT NOT NULL,
		 GroupID		INT NOT NULL,
		 Locality		VARCHAR(45),
		 Latitude		DECIMAL(10, 8),
		 Longitude		DECIMAL(10,8),
		 DateAndTime	DATETIME NOT NULL,
		 Weather		ENUM ("Sunny", "Partly Cloudy", "Cloudy", "Overcast", "Raining"),
		 AirTemperature INT,
		 Number			INT NOT NULL,
		 Color			VARCHAR(24),
		 Characteristics VARCHAR(255),
		 Comments		VARCHAR(255),
CONSTRAINT PRIMARY KEY (ObservationID),
CONSTRAINT FOREIGN KEY (LocationID) REFERENCES Location_T(LocationID) ON UPDATE CASCADE ON DELETE CASCADE,
CONSTRAINT FOREIGN KEY (AnimalID) REFERENCES Animal_T(AnimalID) ON UPDATE CASCADE ON DELETE CASCADE,
CONSTRAINT FOREIGN KEY (GroupID) REFERENCES Group_T(GroupID) ON UPDATE CASCADE ON DELETE CASCADE);

		