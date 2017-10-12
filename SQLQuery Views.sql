USE TripperDB;
GO


IF EXISTS(SELECT name FROM sys.views
    WHERE name = 'v_Localization')
    DROP VIEW v_Localization;
GO

CREATE VIEW v_Localization AS
SELECT l.LocalizationID, l.City, c.CountryID ,c.name AS Country FROM Localization AS l
JOIN Country AS c ON c.CountryID = l.CountryID;
GO


IF EXISTS(SELECT name FROM sys.views
    WHERE name = 'v_Transport')
    DROP VIEW v_Transport;
GO

CREATE VIEW v_Transport AS
SELECT t.TransportID, t.Cost, t.IsReturn, t.TripID, tp.Name AS TripName, v.Name AS Vehicle FROM Transport AS T
JOIN Trip AS tp on t.TripID = tp.TripID
JOIN Vehicle AS v on t.VehicleID = v.VehicleID;
GO


IF EXISTS(SELECT name FROM sys.views
    WHERE name = 'v_Ticket')
    DROP VIEW v_Ticket;
GO


CREATE VIEW v_Ticket AS
SELECT t.TicketID, t.Seats, t.Departure_Time, t.ArrivalTime, t.TransportID, cd.Name AS DepartreCountry, ld .City AS DepartureCity, ca.Name AS ArrivalCountry, la.City AS ArrivalCity  FROM Ticket AS t
JOIN Localization AS ld ON t.DepartureLocalization = ld.LocalizationID
JOIN Country AS cd ON cd.CountryID = ld.CountryID
JOIN Localization AS la ON t.ArrivalLocalization = la.LocalizationID
JOIN Country AS ca ON ca.CountryID = la.CountryID;
GO

IF EXISTS(SELECT name FROM sys.views
    WHERE name = 'v_Stayment')
    DROP VIEW v_Stayment;
GO


SELECT s.StaymentID, s.Name, s.DateFrom, s.DateTo, s.TripID, c.Name AS Country, l.City AS City FROM Stayment AS s
JOIN Localization AS l ON s.LocalizationID = l.LocalizationID
JOIN Country AS c ON c.CountryID = l.CountryID;
GO