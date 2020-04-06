IF OBJECT_ID('Non_Profit_Min_Familia') IS NOT NULL
		DROP DATABASE Non_Profit_Min_Familia
		-- Creatig DataBase Non_Profit_Min_Familia
CREATE DATABASE Non_Profit_Min_Familia

		-- Using DataBase Non_Profit_Min_Familia
USE Non_Profit_Min_Familia
		
		 --Creating Familia_AdminData Table
IF OBJECT_ID('dbo.Familia_AdminData') IS NOT NULL
        DROP TABLE dbo.Familia_AdminData
CREATE TABLE Familia_AdminData
(
	Familia_Admin_CNIC		char   (15) PRIMARY KEY,
	Familia_Admin_Password	varchar(40) NOT NULL,
	Familia_Admin_Name 		varchar(40) NOT NULL,
	Familia_Admin_Gender 	varchar(15)	NOT NULL,
	Familia_Admin_Email		varchar(60) UNIQUE,
	Familia_Admin_Phone		varchar(20) NOT NULL,
	Familia_Admin_Address   varchar(80) NOT NULL
)

		-- Creating Familia_Teams Table
IF OBJECT_ID('dbo.Familia_TeamsData') IS NOT NULL
        DROP TABLE dbo.Familia_TeamsData
CREATE TABLE Familia_TeamsData
(
	Familia_Team_ID	varchar(15) PRIMARY KEY,
	Familia_Team_Name	varchar(40) NOT NULL,
	Familia_Team_Head_CNIC	char(15) 	NOT NULL,
	Familia_Team_Head_Name	varchar(40) NOT NULL
)

		-- Creating Familia_Members Table
IF OBJECT_ID('dbo.Familia_MembersData') IS NOT NULL
        DROP TABLE dbo.Familia_MembersData
CREATE TABLE Familia_MembersData
(
	Familia_Member_CNIC			char   (15) PRIMARY KEY,
	Familia_Member_Password		varchar(40) NOT NULL,
	Familia_Member_Name 		varchar(40) NOT NULL,
	Familia_Member_Gender		varchar(15)	NOT NULL,
	Familia_Member_Email		varchar(60) UNIQUE,
	Familia_Member_Phone		varchar(20) NOT NULL,
	Familia_Member_Address		varchar(80) NOT NULL,
	Familia_Member_Team_ID		varchar(15) FOREIGN KEY REFERENCES Familia_TeamsData(Familia_Team_ID)
)

--SELECT * FROM SYSOBJECTS WHERE xtype = 'U';  --To see all tables in DataBase

SELECT * FROM Familia_AdminData
INSERT INTO Familia_AdminData VALUES('33303-7405121-9', '<786Tayyab786>', 'Muhammad Tayyab Asghar', 'Male', 'muhammadtayyabasghar@gmail.com', '0314 3240296', 'Mera gahr Meri Marzi');
INSERT INTO Familia_MembersData VALUES('33303-2420289-6', 'shazam', 'Zarreen Asghar', 'Female', 'zarreenasghar@gmail.com', '0317 7818280', 'Mera gahr Meri Marzi', NULL);

SELECT Familia_Member_Name, Familia_Member_CNIC, Familia_Member_Email, Familia_Member_Phone, Familia_Member_Address, Familia_Member_Gender, Familia_Member_Team_ID FROM Familia_MembersData
SELECT Familia_Admin_CNIC CNIC FROM Familia_AdminData WHERE Familia_Admin_CNIC = '33303-2420289-6'
UNION ALL
SELECT Familia_Member_CNIC FROM Familia_MembersData WHERE Familia_Member_CNIC = '33303-2420289-6'

SELECT CASE WHEN EXISTS (SELECT 1 FROM Familia_AdminData WHERE Familia_Admin_CNIC = '33303-2420s289-6') OR EXISTS (SELECT 1 FROM Familia_MembersData WHERE Familia_Member_CNIC = '33303-2420289-6') THEN 1 ELSE 0 END OPTION (OPTIMIZE FOR UNKNOWN);

Select serverproperty('IsFullTextInstalled');