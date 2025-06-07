IF OBJECT_ID('dbo.Fosile', 'U') IS NOT NULL DROP TABLE dbo.Fosile;
GO

CREATE TABLE dbo.Fosile (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nume NVARCHAR(100) NOT NULL,
    Locatie NVARCHAR(255),
    Latitudine FLOAT,
    Longitudine FLOAT,
    DataDescoperire DATE,
    Descriere NVARCHAR(MAX),
    ImagineURL NVARCHAR(500),
    SpecieId INT FOREIGN KEY REFERENCES Specii(Id),
    CreatDe INT FOREIGN KEY REFERENCES Utilizatori(Id)
);
