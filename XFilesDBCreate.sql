USE josh;

# Drop tables if they already exist
DROP TABLE IF EXISTS Roster_T;
DROP TABLE IF EXISTS TimeSheet_T;
DROP TABLE IF EXISTS Swimmer_T;
DROP TABLE IF EXISTS Team_T;
DROP TABLE IF EXISTS Event_T;

#Create database (tables)
CREATE TABLE Event_t
			(EventID 		INT NOT NULL AUTO_INCREMENT,
			Distance 		INT NOT NULL DEFAULT 0,
			Stroke			VARCHAR(255),
			EventDate 		DATE,
CONSTRAINT Event_PK 		PRIMARY KEY (EventID));

CREATE TABLE Team_T
			(TeamID			INT NOT NULL AUTO_INCREMENT,
			TeamName 		VARCHAR(255) DEFAULT "Unattached",
CONSTRAINT Team_PK 			PRIMARY KEY (TeamID));

CREATE TABLE Swimmer_T
			(SwimmerID 		INT NOT NULL AUTO_INCREMENT,
			FirstName 		VARCHAR(255) NOT NULL,
			LastName 		VARCHAR(255),
			Gender			VARCHAR(1),
			TeamID 			INT,
CONSTRAINT Swimmer_PK 		PRIMARY KEY (SwimmerID),
CONSTRAINT Team_FK 			FOREIGN KEY (TeamID) REFERENCES Team_T(TeamID) ON UPDATE CASCADE ON DELETE CASCADE );

CREATE TABLE TimeSheet_T
			(SwimmerID  	INT DEFAULT -1,
			EventID 		INT,
			RaceTime 		TIME DEFAULT "00:00:00", # default to time of 0 
CONSTRAINT SwimmerID	 	FOREIGN KEY (SwimmerID) REFERENCES Swimmer_T(SwimmerID) ON UPDATE CASCADE ON DELETE CASCADE,
CONSTRAINT Event_FK			FOREIGN KEY (EventID) REFERENCES Event_T(EventID) ON UPDATE CASCADE ON DELETE CASCADE );

CREATE TABLE Roster_T
			(TeamID 		INT NOT NULL,
			SwimmerID 		INT NOT NULL,
CONSTRAINT Team0_FK 		FOREIGN KEY (TeamID) REFERENCES Team_T(TeamID) ON UPDATE CASCADE ON DELETE CASCADE,
CONSTRAINT Swimmer0_FK		FOREIGN KEY (SwimmerID) REFERENCES Swimmer_T(SwimmerID) ON UPDATE CASCADE ON DELETE CASCADE );


# Insert values into database
INSERT INTO Team_T (TeamName) VALUES
			("Panthers"),
			("Blues"),
			("Bytes");

INSERT INTO Event_T (Distance, Stroke, EventDate) VALUES 
			(50, "Freestyle", "2013-02-13"),
			(100, "Freestyle", "2013-03-13"),
			(200, "Freestyle", "2012-07-27"),
			(100, "Butterfly", "2013-10-19"),
			(100, "Breaststroke", "2013-10-19"),
			(100, "Backstroke", "2012-7-28"),
			(500, "Freestyle", "2012-6-21");

INSERT INTO Swimmer_T (FirstName, LastName, Gender, TeamID) VALUES 
			("Bob", "Johnson", "M", (SELECT TeamID FROM Team_T WHERE TeamName = "Panthers")),
			("Josh", "Harmon", "M", (SELECT TeamID FROM Team_T WHERE TeamName = "Panthers")),
			("Hannah", "Peterson", "F", (SELECT TeamID FROM Team_T WHERE TeamName = "Blues")),
			("Arliss", "Leiderstorm", "F", (SELECT TeamID FROM Team_T WHERE TeamName = "Blues")),
			("Bonny", "Smitherson", "F", (SELECT TeamID FROM Team_T WHERE TeamName = "Bytes")),
			("Jeremey", "Jeromington", "M", (SELECT TeamID FROM Team_T WHERE TeamName = "Bytes"));

INSERT INTO TimeSheet_T (SwimmerID, EventID, RaceTime) VALUES 
			((SELECT SwimmerID FROM Swimmer_T WHERE FirstName =  "Bob" AND LastName = "Johnson"), 1, "00:00:24.22"),		# 50  free
			((SELECT SwimmerID FROM Swimmer_T WHERE FirstName =  "Josh" AND LastName = "Harmon"), 2, "00:00:58.39"),		# 100 free
			((SELECT SwimmerID FROM Swimmer_T WHERE FirstName =  "Hannah" AND LastName = "Peterson"), 3, "00:01:44.10"),		# 200 free
			((SELECT SwimmerID FROM Swimmer_T WHERE FirstName =  "Arliss" AND LastName = "Leiderstorm"), 4, "00:00:52.99"),		# 100 fly
			((SELECT SwimmerID FROM Swimmer_T WHERE FirstName =  "Bonny" AND LastName = "Smitherson"), 5, "00:01:02.53"),		# 100 breast
			((SELECT SwimmerID FROM Swimmer_T WHERE FirstName =  "Jeremey" AND LastName = "Jeromington"), 6, "00:00:56.88");		# 100 back

INSERT INTO Roster_T (TeamID, SwimmerID) VALUES 
			((SELECT TeamID FROM Team_T WHERE TeamName = "Panthers"), 1),
			((SELECT TeamID FROM Team_T WHERE TeamName = "Panthers"), 2),
			((SELECT TeamID FROM Team_T WHERE TeamName = "Blues"), 3),
			((SELECT TeamID FROM Team_T WHERE TeamName = "Blues"), 4),
			((SELECT TeamID FROM Team_T WHERE TeamName = "Bytes"), 5),
			((SELECT TeamID FROM Team_T WHERE TeamName = "Bytes"), 6);

# Queries !
# Find all female swimmers
SELECT FirstName, LastName, TeamID FROM Swimmer_T WHERE Gender = "F" GROUP BY TeamID;

# Find all teams that have female swimmers
SELECT TeamName FROM Team_T WHERE TeamID IN (SELECT TeamID From Swimmer_T WHERE Gender =  "F") GROUP BY TeamName; 

# Find any 50 free times
SELECT FirstName, LastName, RaceTime FROM Swimmer_T, TimeSheet_T
	WHERE TimeSheet_T.SwimmerID IN (SELECT SwimmerID From TimeSheet_T 
		WHERE EventID = (SELECT EventID FROM Event_T WHERE Distance = 50 AND Stroke = "Freestyle")) AND
	Swimmer_T.SwimmerID = TimeSheet_T.SwimmerID;

# Insert more times
INSERT INTO TimeSheet_T (SwimmerID, EventID, RaceTime) VALUES 
			((SELECT SwimmerID FROM Swimmer_T WHERE FirstName =  "Josh" AND LastName = "Harmon"), 1, "00:00:21.75"),		
			((SELECT SwimmerID FROM Swimmer_T WHERE FirstName =  "Josh" AND LastName = "Harmon"), 4, "00:00:53.19");

# Find all times of a swimmer
SELECT Distance, Stroke, RaceTime FROM Event_T, TimeSheet_T 
	WHERE SwimmerID = (SELECT SwimmerID FROM Swimmer_T WHERE FirstName = "Josh" AND LastName = "HARMON") AND
	TimeSheet_T.EventID = Event_T.EventID ORDER BY Distance;

# Find total time of a swimmer (A bit useless I will admit, but might be useful in certain high point 
#  scoring situations
SELECT FirstName, LastName, SUM(RaceTime) as TotalTime FROM TimeSheet_T, Swimmer_T 
	WHERE Swimmer_T.SwimmerID = (SELECT SwimmerID FROM Swimmer_T WHERE FirstName = "Josh" AND LastName = "Harmon") AND
	Swimmer_T.SwimmerID = TimeSheet_T.SwimmerID;

# Join Roster With Swimmers
SELECT * FROM Roster_T NATURAL JOIN Swimmer_T; #ON Swimmer_T.SwimmerID = Roster_T.SwimmerID;

# Get fastest time on team
SELECT TeamName, MIN(RaceTime) AS FastestTime FROM TimeSheet_T, Team_T 
	WHERE SwimmerID IN (SELECT SwimmerID FROM Swimmer_T 
		WHERE TeamID = (SELECT TeamID FROM Team_T 
			WHERE TeamName = "Panthers")) AND
	TeamID = (SELECT TeamID FROM Team_T WHERE TeamName = "Panthers");

