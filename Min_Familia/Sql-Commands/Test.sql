		-- Creatig DataBase Non_Profit_Min_Familia
IF OBJECT_ID('Test') IS NOT NULL
		DROP DATABASE Test
CREATE DATABASE Test

		-- Using DataBase Non_Profit_Min_Familia
USE Test

IF OBJECT_ID (N'ProductDocs', N'U') IS NOT NULL  
DROP TABLE ProductDocs  
GO  
CREATE TABLE ProductDocs (  
  DocID INT NOT NULL IDENTITY,  
  DocTitle NVARCHAR(50) NOT NULL,  
  DocFilename NVARCHAR(400) NOT NULL,  
  FileExtension NVARCHAR(8) NOT NULL,  
  DocSummary NVARCHAR(MAX) NULL,  
  DocContent VARBINARY(MAX) NULL,  
  CONSTRAINT [PK_ProductDocs_DocID] PRIMARY KEY CLUSTERED (DocID ASC)  
)  
GO

CREATE FULLTEXT CATALOG ProductFTS 
WITH ACCENT_SENSITIVITY = OFF

SELECT name, collation_name FROM sys.databases  
WHERE name = 'Test'

SELECT fulltext_catalog_id, name FROM sys.fulltext_catalogs

CREATE FULLTEXT INDEX ON ProductDocs  
(DocSummary, DocContent TYPE COLUMN FileExtension LANGUAGE 1033)  
KEY INDEX PK_ProductDocs_DocID  
ON ProductFTS
WITH STOPLIST = SYSTEM

SELECT document_type, version, manufacturer 
FROM sys.fulltext_document_types

SELECT * FROM sys.fulltext_languages  
ORDER BY lcid

SELECT t.name AS TableName, c.name AS FTCatalogName  
FROM sys.tables t JOIN sys.fulltext_indexes i  
  ON t.object_id = i.object_id  
JOIN sys.fulltext_catalogs c  
  ON i.fulltext_catalog_id = c.fulltext_catalog_id

SELECT display_term, column_id, document_count 
FROM sys.dm_fts_index_keywords  
  (DB_ID('Test'), OBJECT_ID('ProductDocs'))

  -- stoplist
CREATE FULLTEXT STOPLIST ProductSL 
FROM SYSTEM STOPLIST;

-- verifing stop list
SELECT stoplist_id, name FROM sys.fulltext_stoplists

-- viewing words
SELECT stopword FROM sys.fulltext_stopwords  
WHERE stoplist_id = 5 AND language_id = 1033

--altering data
ALTER FULLTEXT STOPLIST ProductSL  
ADD 'nuts' LANGUAGE 1033;

--testing data
SELECT special_term, display_term  
FROM sys.dm_fts_parser  
  (' "testing for fruit and nuts, any type of nut" ', 1033, OBJECT_ID('SYSTEM STOPLIST'), 0)



ALTER FULLTEXT INDEX ON ProductDocs  
SET STOPLIST ProductSL