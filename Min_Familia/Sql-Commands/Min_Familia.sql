		-- Creatig DataBase Non_Profit_Min_Familia
IF OBJECT_ID('Non_Profit_Min_Familia') IS NOT NULL
		DROP DATABASE Non_Profit_Min_Familia
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
	Familia_Admin_Address   varchar(80) NOT NULL,
	Familia_Admin_Joining	date		NOT NULL
)

		-- Creating Familia_Teams Table
IF OBJECT_ID('dbo.Familia_TeamsData') IS NOT NULL
        DROP TABLE dbo.Familia_TeamsData
CREATE TABLE Familia_TeamsData
(
	Familia_Team_ID				varchar(15) PRIMARY KEY,
	Familia_Team_Name			varchar(40) NOT NULL,
	Familia_Team_Head_CNIC		char(15) 	NOT NULL,
	Familia_Team_Head_Name		varchar(40) NOT NULL,
	Familia_Team_Creation_Date	date		NOT NULL
)

		-- Creating Familia_Members Table
IF OBJECT_ID('dbo.Familia_MembersData') IS NOT NULL
        DROP TABLE dbo.Familia_MembersData
CREATE TABLE Familia_MembersData
(
	Familia_Member_CNIC					char   (15) PRIMARY KEY,
	Familia_Member_Password				varchar(40) NOT NULL,
	Familia_Member_Name 				varchar(40) NOT NULL,
	Familia_Member_Gender				varchar(15)	NOT NULL,
	Familia_Member_Email				varchar(60) UNIQUE,
	Familia_Member_Phone				varchar(20) NOT NULL,
	Familia_Member_Address				varchar(80) NOT NULL,
	Familia_Member_Joining_Date			date		NOT NULL,
	Familia_Member_Team_Joining_Date	date,
	Familia_Member_Team_ID				varchar(15) FOREIGN KEY REFERENCES Familia_TeamsData(Familia_Team_ID)
)

		-- Creating Familia_ReferencesData Table
IF OBJECT_ID('dbo.Familia_ReferencesData') IS NOT NULL
        DROP TABLE dbo.Familia_ReferencesData
CREATE TABLE Familia_ReferencesData
(
	Familia_Reference_CNIC		char   (15) PRIMARY KEY,
	Familia_Reference_Name 		varchar(40) NOT NULL,
	Familia_Reference_Email		varchar(60) UNIQUE,
	Familia_Reference_Phone		varchar(20) NOT NULL,
	Familia_Reference_Address	varchar(80) NOT NULL,
	Familia_Reference_Gender	varchar(15)	NOT NULL,
	Familia_Reference_Date		date		NOT NULL,
	Familia_Reference_Cases		int
)


		-- Creating Familia_CasesData Table
IF OBJECT_ID('dbo.Familia_CasesData') IS NOT NULL
        DROP TABLE dbo.Familia_CasesData
CREATE TABLE Familia_CasesData
(
	Familia_Case_ID					varchar(15)		PRIMARY KEY,
	Familia_Case_Expected_Support	int				NOT NULL,
	Familia_Case_Total_Support		int				NOT NULL,
	Familia_Case_Adding_Date		date			NOT NULL,
	Familia_Case_Case_Status		varchar(9)		NOT NULL,  -- Maximun Letters of Completed Status
	Familia_Case_Completion_Date	date,
	Familia_Case_Reference_ID		char(15)		FOREIGN KEY REFERENCES Familia_ReferencesData(Familia_Reference_CNIC),
	Familia_Case_Team_ID			varchar(15)		FOREIGN KEY REFERENCES Familia_TeamsData(Familia_Team_ID),
	Familia_Case_Description		varchar(150)	NOT NULL,
	Familia_Case_Review				varchar(100)	NOT NULL,
	Familia_Case_House_Description	varchar(80)		NOT NULL,
)








--SELECT * FROM SYSOBJECTS WHERE xtype = 'U';  --To see all tables in DataBase
SELECT * FROM Familia_AdminData
INSERT INTO Familia_MembersData VALUES('33303-9420249-6', 'shazam', 'Zarreen Asghar', 'Female', 'zhrgreenasjh67ar@gmail.com', '0317 7818280', 'Mera gahr Meri Marzi', CONVERT (DATE, CURRENT_TIMESTAMP), NULL, NULL);
INSERT INTO Familia_AdminData VALUES('33303-7405121-9', '<786Tayyab786>', 'Muhammad Tayyab Asghar', 'Male', 'muhammadtayyabasghar@gmail.com', '0314 3240296', 'Mera gahr Meri Marzi', CONVERT (DATE, CURRENT_TIMESTAMP));
INSERT INTO Familia_MembersData VALUES('33303-9420249-6', 'shazam', 'Zarreen Asghar', 'Female', 'zhrgreenasjh67ar@gmail.com', '0317 7818280', 'Mera gahr Meri Marzi', NULL);
--SELECT Familia_Member_Name, Familia_Member_CNIC, Familia_Member_Email, Familia_Member_Phone, Familia_Member_Address, Familia_Member_Gender, Familia_Member_Team_ID FROM Familia_MembersData
SELECT CONVERT(DATE, GETDATE()) Tayyab;
SELECT * FROM Familia_MembersData
UPDATE Familia_MembersData SET Familia_Member_CNIC = '33303-7405121-9' WHERE Familia_Member_CNIC = '00000-0000000-0'
INSERT INTO Familia_TeamsData VALUES('Covid', 'Covid-19', '33303-2420289-6', 'Zarreen Asghar')

Select serverproperty('IsFullTextInstalled');

--SELECT Convert(Date, Date_Datas) FROM Date_Data;
--Update Date_Data SET Date_Datas = CURRENT_TIMESTAMP WHERE Names = 'Asghar';


SELECT CASE WHEN EXISTS (SELECT 1 FROM Familia_MembersData WHERE Familia_Member_Email = '' AND Familia_Member_Team_ID = NULL ) THEN 1 ELSE 0 END Team_Head;
