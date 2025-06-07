-- Inserare utilizatori
INSERT INTO Utilizatori (NumeUtilizator, Email, ParolaHash, Rol)
VALUES 
('admin01', 'admin@fosilnet.ro', 'parola123hash', 'administrator'),
('cercetator_maria', 'maria@fosilnet.ro', 'parola456hash', 'cercetator'),
('vizitator_popescu', 'popescu@gmail.com', 'parola789hash', 'vizitator');

-- Inserare specii
INSERT INTO Specii (Nume, Era, Observatii)
VALUES
('Tyrannosaurus Rex', 'Cretacic', 'Specie carnivoră dominantă'),
('Trilobite', 'Cambrian', 'Specie marină fosilă'),
('Mamut lanos', 'Pleistocen', 'Mamifer de mari dimensiuni acoperit cu blană');

-- Inserare fosile
INSERT INTO Fosile (Nume, Locatie, Latitudine, Longitudine, DataDescoperire, Descriere, ImagineURL, SpecieId, CreatDe)
VALUES
('Fosila T-Rex 001', 'Montana, SUA', 45.123456, -110.654321, '2021-06-12', 'Craniu aproape complet de T-Rex', 'https://exemplu.com/imagini/trex.jpg', 1, 1),
('Trilobite Mic', 'Munții Apuseni, România', 46.532198, 22.689341, '2020-04-22', 'Trilobit fosilizat complet', 'https://exemplu.com/imagini/trilobit.jpg', 2, 2),
('Colț de mamut', 'Siberia, Rusia', 66.543210, 89.654321, '2019-09-10', 'Colț de mamut descoperit parțial', 'https://exemplu.com/imagini/mamut.jpg', 3, 2);

-- Inserare date științifice
INSERT INTO DateStiintifice (FosilaId, Masuratori, AnalizaChimica, RezultatDatare, Referinte)
VALUES
(1, 'Lungime: 1.8m, Lățime: 0.9m', 'Conținut ridicat de calciu și fosfați', '65 milioane ani', 'https://link-articol-trex.com'),
(2, 'Lungime: 12cm', 'Structură carbonată, urme de siliciu', '520 milioane ani', 'https://trilobite-journal.com'),
(3, 'Lungime colț: 2.5m', 'Urme de ADN parțial conservat', '10.000 ani', 'https://paleomammoth.org');

-- Inserare fișiere atașate
INSERT INTO FisiereAtasate (FosilaId, TipFisier, URLFisier)
VALUES
(1, 'scanare_3D', 'https://exemplu.com/fisiere/trex_3d.obj'),
(2, 'imagine_microscop', 'https://exemplu.com/fisiere/trilobit_zoom.jpg'),
(3, 'raport_PDF', 'https://exemplu.com/fisiere/mamut_raport.pdf');
