USE [ArheoTrack];
GO

SET ANSI_NULLS ON;
GO

SET QUOTED_IDENTIFIER ON;
GO
    DROP TABLE dbo.Utilizatori;
GO

CREATE TABLE [dbo].[Utilizatori](
    Id INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
    Nume NVARCHAR(100) NOT NULL,
    Prenume NVARCHAR(100) NOT NULL,
    Email NVARCHAR(255) NOT NULL UNIQUE,
    Parola NVARCHAR(255) NOT NULL,
    DataNastere DATE NULL,
    Adresa NVARCHAR(255) NULL,
    NumarTelefon NVARCHAR(20) NULL,
    Studii NVARCHAR(255) NULL,
    Rol NVARCHAR(50) NOT NULL CHECK (Rol IN ('vizitator', 'cercetator', 'administrator')),
    EmailInstitutional NVARCHAR(255) NULL,
    DataCreare DATETIME NOT NULL DEFAULT GETDATE()
);
GO
-- INSERT 1 - Administrator
INSERT INTO Utilizatori 
(Nume, Prenume, Email, Parola, DataNastere, Adresa, NumarTelefon, Studii, Rol, EmailInstitutional)
VALUES 
('Popescu', 'Ion', 'admin@arheotrack.ro', 'admin123', '1980-01-15', 'Str. Principala 1', '0712345678', 'Doctorat Arheologie', 'administrator', 'ion.popescu@univ.ro');

-- INSERT 2 - Cercet?tor
INSERT INTO Utilizatori 
(Nume, Prenume, Email, Parola, DataNastere, Adresa, NumarTelefon, Studii, Rol, EmailInstitutional)
VALUES 
('Ionescu', 'Maria', 'cercetator@arheotrack.ro', 'cerc2024', '1990-05-20', 'Str. Cercetarii 5', '0723456789', 'Master Istorie Veche', 'cercetator', 'maria.ionescu@institut.ro');

-- INSERT 3 - Vizitator
INSERT INTO Utilizatori 
(Nume, Prenume, Email, Parola, DataNastere, Adresa, NumarTelefon, Studii, Rol, EmailInstitutional)
VALUES 
('Radu', 'Elena', 'vizitator@arheotrack.ro', 'viz123', '2002-11-30', 'Str. Vizitatorului 12', '0734567890', 'Liceu', 'vizitator', NULL);

-- INSERT 4 - Administrator
INSERT INTO Utilizatori 
(Nume, Prenume, Email, Parola, DataNastere, Adresa, NumarTelefon, Studii, Rol, EmailInstitutional)
VALUES 
('Dumitrescu', 'Cristina', 'cristina.d@admin.ro', 'adminpass', '1985-04-11', 'Str. Adminilor 99', '0745678901', 'Doctorat Management Cultural', 'administrator', 'cristina.dumitrescu@muzeu.ro');

-- INSERT 5 - Cercet?tor
INSERT INTO Utilizatori 
(Nume, Prenume, Email, Parola, DataNastere, Adresa, NumarTelefon, Studii, Rol, EmailInstitutional)
VALUES 
('Mihai', 'George', 'george.mihai@cercetare.ro', 'gmihaipass', '1987-09-09', 'Bd. ?tiin?ei 45', '0756789012', 'Doctorat Geologie', 'cercetator', 'george.mihai@geo.ro');

-- INSERT 6 - Vizitator
INSERT INTO Utilizatori 
(Nume, Prenume, Email, Parola, DataNastere, Adresa, NumarTelefon, Studii, Rol, EmailInstitutional)
VALUES 
('Stoica', 'Ana', 'ana.stoica@vizitator.ro', 'ana2024', '1998-07-01', 'Str. Turismului 3', '0767890123', 'Facultate Istorie', 'vizitator', NULL);

-- INSERT 7 - Administrator
INSERT INTO Utilizatori 
(Nume, Prenume, Email, Parola, DataNastere, Adresa, NumarTelefon, Studii, Rol, EmailInstitutional)
VALUES 
('Neagu', 'Roxana', 'roxana.neagu@admin.ro', 'roxana123', '1975-06-22', 'Str. Central? 8', '0778901234', 'Doctorat Patrimoniu', 'administrator', 'roxana.neagu@patrimoniu.ro');

-- INSERT 8 - Cercet?tor
INSERT INTO Utilizatori 
(Nume, Prenume, Email, Parola, DataNastere, Adresa, NumarTelefon, Studii, Rol, EmailInstitutional)
VALUES 
('Laz?r', 'Adrian', 'adrian.lazar@cerc.ro', 'lazarpass', '1992-12-12', 'Str. Arheologiei 15', '0789012345', 'Master Paleontologie', 'cercetator', 'adrian.lazar@paleo.ro');

-- INSERT 9 - Vizitator
INSERT INTO Utilizatori 
(Nume, Prenume, Email, Parola, DataNastere, Adresa, NumarTelefon, Studii, Rol, EmailInstitutional)
VALUES 
('Ciobanu', 'Irina', 'irina.ciobanu@viz.ro', 'irina2025', '2001-08-19', 'Aleea Vizitatorilor 21', '0790123456', 'Student?', 'vizitator', NULL);

-- INSERT 10 - Cercet?tor
INSERT INTO Utilizatori 
(Nume, Prenume, Email, Parola, DataNastere, Adresa, NumarTelefon, Studii, Rol, EmailInstitutional)
VALUES 
('Toma', 'Florin', 'florin.toma@institut.ro', 'florinpass', '1989-03-27', 'Str. Fosilelor 17', '0701234567', 'Doctorat Arheozoologie', 'cercetator', 'florin.toma@instgeo.ro');
GO

