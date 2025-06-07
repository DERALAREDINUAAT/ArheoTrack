IF OBJECT_ID('dbo.DateStiintifice', 'U') IS NOT NULL DROP TABLE dbo.DateStiintifice;
GO

CREATE TABLE dbo.DateStiintifice (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FosilaId INT NOT NULL FOREIGN KEY REFERENCES Fosile(Id),
    Masuratori NVARCHAR(MAX),
    AnalizaChimica NVARCHAR(MAX),
    RezultatDatare NVARCHAR(255)
);
