CREATE DATABASE [TestWorkMMD]

GO

-- Tables creation

USE [TestWorkMMD]

CREATE TABLE [Cities](
Id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
Name NVARCHAR(25) NOT NULL
);

CREATE TABLE [Regions](
Id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
Name NVARCHAR(25) NOT NULL
);

CREATE TABLE [Countries](
Id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
Name NVARCHAR(25) NOT NULL,
CountryCode NVARCHAR(3) NOT NULL,
CapitalId INT NOT NULL FOREIGN KEY REFERENCES Cities(Id),
Area FLOAT NOT NULL,
Population INT NOT NULL,
RegionId INT NOT NULL FOREIGN KEY REFERENCES Regions(Id)
);

GO
