IF OBJECT_ID('Non_Profit_Min_Familia') IS NOT NULL
		DROP DATABASE Non_Profit_Min_Familia
		-- Creatig DataBase Non_Profit_Min_Familia
CREATE DATABASE Non_Profit_Min_Familia

		-- Using DataBase Non_Profit_Min_Familia
USE Non_Profit_Min_Familia
		
		 --Creating Familia_AdminData Table
IF OBJECT_ID('dbo.Familia_AdminData') IS NOT NULL
        DROP TABLE Familia_AdminData
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
IF OBJECT_ID('dbo.Familia_Teams') IS NOT NULL
        DROP TABLE Familia_Teams
CREATE TABLE Familia_Teams
(
	Familia_Teams_Team_ID	varchar(15) PRIMARY KEY,
	Familia_Teams_Team_Name	varchar(40) NOT NULL,
	Familia_Teams_Head_CNIC	char(15) 	NOT NULL,
	Familia_Teams_Head_Name	varchar(40) NOT NULL
)

		-- Creating Familia_MembersData Table
IF OBJECT_ID('dbo.Familia_MembersData') IS NOT NULL
        DROP TABLE Familia_MembersData
CREATE TABLE Familia_MembersData
(
	Familia_MembersData_CNIC		char   (15) PRIMARY KEY,
	Familia_MembersData_Password	varchar(40) NOT NULL,
	Familia_MembersData_Name 		varchar(40) NOT NULL,
	Familia_MembersData_Gender		varchar(15)	NOT NULL,
	Familia_MembersData_Email		varchar(60) UNIQUE,
	Familia_MembersData_Phone		varchar(20) NOT NULL,
	Familia_MembersData_Address		varchar(80) NOT NULL,
	Familia_MembersData_Team_ID		varchar(15) FOREIGN KEY REFERENCES Familia_Teams(Familia_Teams_Team_ID)
)

--SELECT * FROM SYSOBJECTS WHERE xtype = 'U';  --To see all tables in DataBase

SELECT * FROM Familia_AdminData

INSERT INTO Familia_AdminData VALUES('33303-7405121-9', '<786Tayyab786>', 'Muhammad Tayyab Asghar', 'Male', 'muhammadtayyabasghar@gmail.com', '0314 3240296', 'Mera gahr Meri Marzi');
INSERT INTO Familia_MembersData VALUES('33303-2420289-6', 'shazam', 'Zarreen Asghar', 'Female', 'zarreenasghar@gmail.com', '0317 7818280', 'Mera gahr Meri Marzi', NULL);

SELECT Familia_MembersData_Name, Familia_MembersData_CNIC, Familia_MembersData_Email, Familia_MembersData_Phone, Familia_MembersData_Address, Familia_MembersData_Gender, Familia_MembersData_Team_ID FROM Familia_MembersData