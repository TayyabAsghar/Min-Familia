		/* Creatig DataBase */
CREATE DATABASE Min_Familia
		
		/* Creatig DataBase Min_Familia */
USE Min_Familia
		
		/* Creating Familia_AdminData Table */
Create Table Familia_AdminData (
CNIC		char   (15) PRIMARY KEY,
Password	varchar(40) NOT NULL,
Name 		varchar(40) NOT NULL,
Gender 		varchar(15)	NOT NULL,
Email		varchar(60) UNIQUE,
Phone		varchar(20) NOT NULL,
Address     varchar(80) NOT NULL
)

		/* Creating MembersData Table */
Create Table MembersData (
CNIC		char   (15) PRIMARY KEY,
Password	varchar(40) NOT NULL,
Name 		varchar(40) NOT NULL,
Gender 		varchar(15)	NOT NULL,
Email		varchar(60) UNIQUE,
Phone		varchar(20) NOT NULL,
Address     varchar(80) NOT NULL
)

SELECT * FROM AdminData

Select * from 

INSERT INTO AdminData VALUES('33303-7405121-9', '<786Tayyab786>', 'Muhammad Tayyab Asghar', 'Male', 'muhammadtayyabasghar@gmail.com', '0314 3240296', 'Mera gahr Meri Marzi');