USE TripperDB;
GO


IF EXISTS(SELECT name FROM sys.views
    WHERE name = 'v_Localization')
    DROP VIEW v_Localization;
GO

CREATE VIEW v_Localization AS
SELECT l.LocalizationID, l.City, c.CountryID ,c.name AS Country, c.Continent FROM Localization AS l
JOIN Country AS c ON c.CountryID = l.CountryID;
GO


IF EXISTS(SELECT name FROM sys.views
    WHERE name = 'v_Transport')
    DROP VIEW v_Transport;
GO

CREATE VIEW v_Transport AS
SELECT t.TransportID, t.TripID, t.IsReturn, t.Vehicle, tp.Name AS TripName, t.Cost, t.Seats, t.DepartureTime, t.ArrivalTime, cd.Name AS DepartreCountry, ld .City AS DepartureCity, ca.Name AS ArrivalCountry, la.City AS ArrivalCity FROM Transport AS t
JOIN Trip AS tp on t.TripID = tp.TripID
JOIN Localization AS ld ON t.DepartureLocalization = ld.LocalizationID
JOIN Country AS cd ON cd.CountryID = ld.CountryID
JOIN Localization AS la ON t.ArrivalLocalization = la.LocalizationID
JOIN Country AS ca ON ca.CountryID = la.CountryID;
GO
GO


IF EXISTS(SELECT name FROM sys.views
    WHERE name = 'v_Stayment')
    DROP VIEW v_Stayment;
GO

CREATE VIEW v_Stayment AS
SELECT s.StaymentID, s.Address, s.DateFrom, s.DateTo, s.TripID, c.Name AS Country, l.City AS City FROM Stayment AS s
JOIN Localization AS l ON s.LocalizationID = l.LocalizationID
JOIN Country AS c ON c.CountryID = l.CountryID;
GO