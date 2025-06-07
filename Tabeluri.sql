-- Tabelul Utilizatori
CREATE TABLE Utilizatori (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NumeUtilizator NVARCHAR(150) UNIQUE NOT NULL,
    Email NVARCHAR(255) UNIQUE NOT NULL,
    ParolaHash NVARCHAR(MAX) NOT NULL,
    Rol NVARCHAR(50) CHECK (Rol IN ('administrator', 'cercetator', 'vizitator')) NOT NULL,
    DataCreare DATETIME DEFAULT GETDATE()
);

-- Tabelul Specii
CREATE TABLE Specii (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nume NVARCHAR(255) NOT NULL,
    Era NVARCHAR(100),
    Observatii NVARCHAR(MAX)
);

-- Tabelul Fosile
CREATE TABLE Fosile (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nume NVARCHAR(255) NOT NULL,
    Locatie NVARCHAR(MAX),
    Latitudine DECIMAL(9,6),
    Longitudine DECIMAL(9,6),
    DataDescoperire DATE,
    Descriere NVARCHAR(MAX),
    ImagineURL NVARCHAR(MAX),
    SpecieId INT FOREIGN KEY REFERENCES Specii(Id),
    CreatDe INT FOREIGN KEY REFERENCES Utilizatori(Id),
    DataCreare DATETIME DEFAULT GETDATE()
);

-- Tabelul DateStiintifice
CREATE TABLE DateStiintifice (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FosilaId INT FOREIGN KEY REFERENCES Fosile(Id) ON DELETE CASCADE,
    Masuratori NVARCHAR(MAX),
    AnalizaChimica NVARCHAR(MAX),
    RezultatDatare NVARCHAR(MAX),
    Referinte NVARCHAR(MAX)
);

-- Tabelul FisiereAtasate
CREATE TABLE FisiereAtasate (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FosilaId INT FOREIGN KEY REFERENCES Fosile(Id) ON DELETE CASCADE,
    TipFisier NVARCHAR(50),
    URLFisier NVARCHAR(MAX),
    DataIncarcare DATETIME DEFAULT GETDATE()
);
