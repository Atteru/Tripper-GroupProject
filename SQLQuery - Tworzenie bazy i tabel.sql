
IF EXISTS(SELECT name FROM sys.databases
    WHERE name = 'TripperDB')
    DROP DATABASE TripperDB
GO

CREATE DATABASE TripperDB;
GO

USE TripperDB;
GO

  
	CREATE TABLE dbo.Trip
	(
	 TripID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	 Name NVARCHAR(50) NOT NULL,
	 DepartureTime DATETIME NOT NULL,
	 Budget DECIMAL(10,2) DEFAULT 0 NOT NULL,
	 EstimatedCost DECIMAL(10,2) DEFAULT 0 NOT NULL,
	 ModifiedDate DATETIME DEFAULT GETDATE() NOT NULL,
	 CreateDate DATETIME DEFAULT GETDATE() NOT NULL
	 )


	CREATE TABLE dbo.Country
	(
	CountryID CHAR(3) PRIMARY KEY  NOT NULL,
	Name NVARCHAR(50) UNIQUE NOT NULL,
	Continent NVARCHAR(50) NOT NULL,
	ModifiedDate DATETIME DEFAULT GETDATE() NOT NULL,
	CONSTRAINT chk_Continent CHECK (Continent IN ('Azja', 'Afryka', 'Ameryka Pó³nocna', 'Australia i Oceania', 'Ameryka Po³udniowa', 'Europa'))

	) 


	CREATE TABLE dbo.Localization
	(
	LocalizationID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	City NVARCHAR(50) NOT NULL,
	CountryID CHAR(3) NOT NULL,
	ModifiedDate DATETIME DEFAULT GETDATE() NOT NULL,
	CONSTRAINT FK_CountryID FOREIGN KEY(CountryID) REFERENCES Country(CountryID)
	)

	CREATE TABLE dbo.Stayment
	(
	 StaymentID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	 Address NVARCHAR(50) NOT NULL,
	 DateFrom DATETIME NOT NULL,
	 DateTo DATETIME NOT NULL,
	 TripID INT NOT NULL,
	 LocalizationID INT NOT NULL,
	 Cost DECIMAL(10,2) DEFAULT 0 NOT NULL,
	 ModifiedDate DATETIME DEFAULT GETDATE() NOT NULL,
	 CreateDate DATETIME DEFAULT GETDATE() NOT NULL,
	 CONSTRAINT FK_TripStayment FOREIGN KEY(TripID) REFERENCES Trip(TripID),
	 CONSTRAINT FK_LocationStayment FOREIGN KEY(LocalizationID) REFERENCES Localization(LocalizationID)
	 )


	CREATE TABLE dbo.Transport
	(
	TransportID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	Vehicle NVARCHAR(20)  NOT NULL,
	Cost DECIMAL(10,2) DEFAULT 0 NOT NULL,
	IsReturn BIT DEFAULT 0 NOT NULL,
	TripID INT NOT NULL,
	Seats NVARCHAR(10) NULL,
	DepartureTime DATETIME NULL,
	ArrivalTime DATETIME NULL,
	DepartureLocalization INT NOT NULL,
	ArrivalLocalization INT NOT NULL,
	ModifiedDate DATETIME DEFAULT GETDATE() NOT NULL,
	CreateDate DATETIME DEFAULT GETDATE() NOT NULL,
	CONSTRAINT FK_TripTransport FOREIGN KEY(TripID) REFERENCES Trip(TripID),
	CONSTRAINT FK_LocationDeparture FOREIGN KEY(DepartureLocalization) REFERENCES Localization(LocalizationID),
	CONSTRAINT FK_LocationArrival FOREIGN KEY(ArrivalLocalization) REFERENCES Localization(LocalizationID),
	CONSTRAINT chk_Vehicle CHECK (Vehicle IN ('Samolot', 'Samochód', 'Poci¹g', 'Autobus')),
	)


	-- Uzupe³nianie tabel

	USE TripperDB;
GO

INSERT INTO Country (CountryID, Name, Continent) Values('AFG', 'Afganistan', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('ALB', 'Albania', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('DZA', 'Algieria', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('AND', 'Andora', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('AGO', 'Angola', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('AIA', 'Anguilla', 'Ameryka Pó³nocna');
INSERT INTO Country (CountryID, Name, Continent) Values('SAU', 'Arabia Saudyjska', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('ARG', 'Argentyna', 'Ameryka Po³udniowa');
INSERT INTO Country (CountryID, Name, Continent) Values('ARM', 'Armenia', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('AUS', 'Australia', 'Australia i Oceania');
INSERT INTO Country (CountryID, Name, Continent) Values('AUT', 'Austria', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('AZE', 'Azerbejd¿an', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('BHS', 'Bahamy', 'Ameryka Pó³nocna');
INSERT INTO Country (CountryID, Name, Continent) Values('BHR', 'Bahrajn', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('BGD', 'Bangladesz', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('BRB', 'Barbados', 'Ameryka Pó³nocna');
INSERT INTO Country (CountryID, Name, Continent) Values('BEL', 'Belgia', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('BLZ', 'Belize', 'Ameryka Pó³nocna');
INSERT INTO Country (CountryID, Name, Continent) Values('BEN', 'Benin', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('BTN', 'Bhutan', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('BLR', 'Bia³oruœ', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('BOL', 'Boliwia', 'Ameryka Po³udniowa');
INSERT INTO Country (CountryID, Name, Continent) Values('BIH', 'Boœnia i Hercegowina', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('BWA', 'Botswana', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('BRA', 'Brazylia', 'Ameryka Po³udniowa');
INSERT INTO Country (CountryID, Name, Continent) Values('BRN', 'Brunei', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('BGR', 'Bu³garia', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('BFA', 'Burkina Faso', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('BDI', 'Burundi', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('CHL', 'Chile', 'Ameryka Po³udniowa');
INSERT INTO Country (CountryID, Name, Continent) Values('CHN', 'Chiny', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('HRV', 'Chorwacja', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('CYP', 'Cypr', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('TCD', 'Czad', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('MNE', 'Czarnogóra', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('CZE', 'Czechy', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('DNK', 'Dania', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('COD', 'Demokratyczna Republika Konga', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('DMA', 'Dominika', 'Ameryka Pó³nocna');
INSERT INTO Country (CountryID, Name, Continent) Values('DOM', 'Dominikana', 'Ameryka Pó³nocna');
INSERT INTO Country (CountryID, Name, Continent) Values('DJI', 'D¿ibuti', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('EGY', 'Egipt', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('ECU', 'Ekwador', 'Ameryka Po³udniowa');
INSERT INTO Country (CountryID, Name, Continent) Values('ERI', 'Erytrea', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('EST', 'Estonia', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('ETH', 'Etiopia', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('FJI', 'Fid¿i', 'Australia i Oceania');
INSERT INTO Country (CountryID, Name, Continent) Values('PHL', 'Filipiny', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('FIN', 'Finlandia', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('FRA', 'Francja', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('ATF', 'Francuskie Terytoria Po³udniowe i Antarktyczne', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('GAB', 'Gabon', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('GHA', 'Ghana', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('GRC', 'Grecja', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('GRD', 'Grenada', 'Ameryka Pó³nocna');
INSERT INTO Country (CountryID, Name, Continent) Values('GEO', 'Gruzja', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('GUY', 'Gujana', 'Ameryka Po³udniowa');
INSERT INTO Country (CountryID, Name, Continent) Values('GTM', 'Gwatemala', 'Ameryka Pó³nocna');
INSERT INTO Country (CountryID, Name, Continent) Values('GIN', 'Gwinea', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('GNB', 'Gwinea Bissau', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('GNQ', 'Gwinea Równikowa', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('HTI', 'Haiti', 'Ameryka Pó³nocna');
INSERT INTO Country (CountryID, Name, Continent) Values('ESP', 'Hiszpania', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('NLD', 'Holandia', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('HND', 'Honduras', 'Ameryka Pó³nocna');
INSERT INTO Country (CountryID, Name, Continent) Values('IND', 'Indie', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('IDN', 'Indonezja', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('IRQ', 'Irak', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('IRN', 'Iran', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('IRL', 'Irlandia', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('ISL', 'Islandia', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('ISR', 'Izrael', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('JAM', 'Jamajka', 'Ameryka Pó³nocna');
INSERT INTO Country (CountryID, Name, Continent) Values('JPN', 'Japonia', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('YEM', 'Jemen', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('JOR', 'Jordania', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('KHM', 'Kambod¿a', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('CMR', 'Kamerun', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('CAN', 'Kanada', 'Ameryka Pó³nocna');
INSERT INTO Country (CountryID, Name, Continent) Values('QAT', 'Katar', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('KAZ', 'Kazachstan', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('KEN', 'Kenia', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('KGZ', 'Kirgistan', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('KIR', 'Kiribati', 'Australia i Oceania');
INSERT INTO Country (CountryID, Name, Continent) Values('COL', 'Kolumbia', 'Ameryka Po³udniowa');
INSERT INTO Country (CountryID, Name, Continent) Values('COM', 'Komory', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('COG', 'Kongo', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('KOR', 'Korea Po³udniowa', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('PRK', 'Korea Pó³nocna', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('CRI', 'Kostaryka', 'Ameryka Pó³nocna');
INSERT INTO Country (CountryID, Name, Continent) Values('CUB', 'Kuba', 'Ameryka Pó³nocna');
INSERT INTO Country (CountryID, Name, Continent) Values('KWT', 'Kuwejt', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('LAO', 'Laos', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('LSO', 'Lesotho', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('LBN', 'Liban', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('LBR', 'Liberia', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('LBY', 'Libia', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('LIE', 'Liechtenstein', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('LTU', 'Litwa', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('LUX', 'Luksemburg', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('LVA', '£otwa', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('MKD', 'Macedonia', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('MDG', 'Madagaskar', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('MYT', 'Majotta', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('MWI', 'Malawi', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('MDV', 'Malediwy', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('MYS', 'Malezja', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('MLI', 'Mali', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('MLT', 'Malta', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('MAR', 'Maroko', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('MRT', 'Mauretania', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('MUS', 'Mauritius', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('MEX', 'Meksyk', 'Ameryka Pó³nocna');
INSERT INTO Country (CountryID, Name, Continent) Values('FSM', 'Mikronezja', 'Australia i Oceania');
INSERT INTO Country (CountryID, Name, Continent) Values('MDA', 'Mo³dawia', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('MCO', 'Monako', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('MNG', 'Mongolia', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('MOZ', 'Mozambik', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('NAM', 'Namibia', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('NRU', 'Nauru', 'Australia i Oceania');
INSERT INTO Country (CountryID, Name, Continent) Values('NPL', 'Nepal', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('DEU', 'Niemcy', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('NER', 'Niger', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('NGA', 'Nigeria', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('NIC', 'Nikaragua', 'Ameryka Pó³nocna');
INSERT INTO Country (CountryID, Name, Continent) Values('NOR', 'Norwegia', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('NZL', 'Nowa Zelandia', 'Australia i Oceania');
INSERT INTO Country (CountryID, Name, Continent) Values('OMN', 'Oman', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('PAK', 'Pakistan', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('PLW', 'Palau', 'Australia i Oceania');
INSERT INTO Country (CountryID, Name, Continent) Values('PAN', 'Panama', 'Ameryka Pó³nocna');
INSERT INTO Country (CountryID, Name, Continent) Values('PNG', 'Papua-Nowa Gwinea', 'Australia i Oceania');
INSERT INTO Country (CountryID, Name, Continent) Values('PRY', 'Paragwaj', 'Ameryka Po³udniowa');
INSERT INTO Country (CountryID, Name, Continent) Values('PER', 'Peru', 'Ameryka Po³udniowa');
INSERT INTO Country (CountryID, Name, Continent) Values('POL', 'Polska', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('PRT', 'Portugalia', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('ZAF', 'Republika Po³udniowej Afryki', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('CAF', 'Republika Œrodkowoafrykañska', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('CPV', 'Republika Zielonego Przyl¹dka', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('RUS', 'Rosja', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('ROU', 'Rumunia', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('RWA', 'Rwanda', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('KNA', 'Saint Kitts i Nevis', 'Ameryka Pó³nocna');
INSERT INTO Country (CountryID, Name, Continent) Values('LCA', 'Saint Lucia', 'Ameryka Pó³nocna');
INSERT INTO Country (CountryID, Name, Continent) Values('VCT', 'Saint Vincent i Grenadyny', 'Ameryka Pó³nocna');
INSERT INTO Country (CountryID, Name, Continent) Values('SLV', 'Salwador', 'Ameryka Pó³nocna');
INSERT INTO Country (CountryID, Name, Continent) Values('WSM', 'Samoa', 'Australia i Oceania');
INSERT INTO Country (CountryID, Name, Continent) Values('SMR', 'San Marino', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('SEN', 'Senegal', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('SRB', 'Serbia', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('SYC', 'Seszele', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('SLE', 'Sierra Leone', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('SGP', 'Singapur', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('SVK', 'S³owacja', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('SVN', 'S³owenia', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('SOM', 'Somalia', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('LKA', 'Sri Lanka', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('USA', 'Stany Zjednoczone', 'Ameryka Pó³nocna');
INSERT INTO Country (CountryID, Name, Continent) Values('SWZ', 'Suazi', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('SDN', 'Sudan', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('SUR', 'Surinam', 'Ameryka Po³udniowa');
INSERT INTO Country (CountryID, Name, Continent) Values('SYR', 'Syria', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('CHE', 'Szwajcaria', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('SWE', 'Szwecja', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('TJK', 'Tad¿ykistan', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('THA', 'Tajlandia', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('TZA', 'Tanzania', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('TLS', 'Timor Wschodni', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('TGO', 'Togo', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('TON', 'Tonga', 'Australia i Oceania');
INSERT INTO Country (CountryID, Name, Continent) Values('TTO', 'Trynidad i Tobago', 'Ameryka Po³udniowa');
INSERT INTO Country (CountryID, Name, Continent) Values('TUN', 'Tunezja', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('TUR', 'Turcja', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('TKM', 'Turkmenistan', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('TUV', 'Tuvalu', 'Australia i Oceania');
INSERT INTO Country (CountryID, Name, Continent) Values('UGA', 'Uganda', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('UKR', 'Ukraina', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('URY', 'Urugwaj', 'Ameryka Po³udniowa');
INSERT INTO Country (CountryID, Name, Continent) Values('UZB', 'Uzbekistan', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('VUT', 'Vanuatu', 'Australia i Oceania');
INSERT INTO Country (CountryID, Name, Continent) Values('VAT', 'Watykan', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('VEN', 'Wenezuela', 'Ameryka Po³udniowa');
INSERT INTO Country (CountryID, Name, Continent) Values('HUN', 'Wêgry', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('GBR', 'Wielka Brytania', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('VNM', 'Wietnam', 'Azja');
INSERT INTO Country (CountryID, Name, Continent) Values('ITA', 'W³ochy', 'Europa');
INSERT INTO Country (CountryID, Name, Continent) Values('CIV', 'Wybrze¿e Koœci S³oniowej', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('MHL', 'Wyspy Marshalla', 'Australia i Oceania');
INSERT INTO Country (CountryID, Name, Continent) Values('SLB', 'Wyspy Salomona', 'Australia i Oceania');
INSERT INTO Country (CountryID, Name, Continent) Values('STP', 'Wyspy Œwiêtego Tomasza i Ksi¹¿êca', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('ZMB', 'Zambia', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('ZWE', 'Zimbabwe', 'Afryka');
INSERT INTO Country (CountryID, Name, Continent) Values('ARE', 'Zjednoczone Emiraty Arabskie', 'Azja');
GO

INSERT INTO Localization(City, CountryID) VALUES('Rzym', 'ITA');
INSERT INTO Localization(City, CountryID) VALUES('Wenecja', 'ITA');
INSERT INTO Localization(City, CountryID) VALUES('Florencja', 'ITA');
GO

INSERT INTO Localization(City, CountryID) VALUES('Madryt', 'ESP');
INSERT INTO Localization(City, CountryID) VALUES('Barcelona', 'ESP');
INSERT INTO Localization(City, CountryID) VALUES('Lloret de Mar', 'ESP');
GO

INSERT INTO Localization(City, CountryID) VALUES('Moskwa', 'RUS');
INSERT INTO Localization(City, CountryID) VALUES('Petersburb', 'RUS');
GO

INSERT INTO Localization(City, CountryID) VALUES('Waszyngton', 'USA');
INSERT INTO Localization(City, CountryID) VALUES('Nowy Jork', 'USA');
INSERT INTO Localization(City, CountryID) VALUES('Las Vegas', 'USA');
GO

INSERT INTO Localization(City, CountryID) VALUES('Warszawa', 'POL');
INSERT INTO Localization(City, CountryID) VALUES('£ódŸ', 'POL');
GO

INSERT INTO Trip (Name, DepartureTime, Budget) VALUES ('Tour po stanach', '2018-07-01', 19000);
INSERT INTO Trip (Name, DepartureTime, Budget) VALUES ('Pamiêtniki z wakacji','2018-08-25', 7000);
INSERT INTO Trip (Name, DepartureTime, Budget) VALUES ('Sylwester z Vladymirem', '2017-12-29', 2500);
GO

INSERT INTO Stayment(Address, DateFrom, DateTo, TripID, LocalizationID, Cost) VALUES('First st. 1,', '2018-07-02', '2018-07-09', 1, 9, 2500);
INSERT INTO Stayment(Address, DateFrom, DateTo, TripID, LocalizationID, Cost) VALUES('Second av. 22,', '2018-07-09', '2018-07-14', 1, 10, 1760);
INSERT INTO Stayment(Address, DateFrom, DateTo, TripID, LocalizationID, Cost) VALUES('Third st. 31,', '2018-07-14', '2018-07-16', 1, 11, 1900);
INSERT INTO Stayment(Address, DateFrom, DateTo, TripID, LocalizationID, Cost) VALUES('Primicia 1,', '2018-08-25', '2018-09-07', 2, 6, 2500);
INSERT INTO Stayment(Address, DateFrom, DateTo, TripID, LocalizationID, Cost) VALUES('Plac Czerwony 1,', '2017-12-29', '2018-01-03', 3, 7, 1500);


INSERT INTO Transport(TripID, Vehicle, Cost, IsReturn, Seats, DepartureTime, ArrivalTime, DepartureLocalization, ArrivalLocalization) VALUES(1, 'Samolot', 2500, 0, '33', '2017-07-01 16:40:00', '2017-07-02 05:20:00', 12, 9);
INSERT INTO Transport(TripID, Vehicle, Cost, IsReturn, Seats, DepartureTime, ArrivalTime, DepartureLocalization, ArrivalLocalization) VALUES(1, 'Poci¹g', 300, 0, '51', '2017-07-09 09:10:00', '2017-07-09 15:00:00', 9, 10);
INSERT INTO Transport(TripID, Vehicle, Cost, IsReturn, Seats, DepartureTime, ArrivalTime, DepartureLocalization, ArrivalLocalization) VALUES(1, 'Samolot', 1000, 0, '23', '2017-07-14 15:00:00', '2017-07-14 18:30:00', 10, 11);
INSERT INTO Transport(TripID, Vehicle, Cost, IsReturn, Seats, DepartureTime, ArrivalTime, DepartureLocalization, ArrivalLocalization) VALUES(1,'Samolot', 2600, 1, '44', '2017-07-16 18:00:00', '2017-07-17 10:00:00', 11, 12);

INSERT INTO Transport(TripID, Vehicle, Cost, IsReturn, Seats, DepartureTime, ArrivalTime, DepartureLocalization, ArrivalLocalization) VALUES(2, 'Samolot', 1450, 0, '04', '2017-08-25 05:00:00', '2017-08-25 14:00:00', 12, 5);
INSERT INTO Transport(TripID, Vehicle, Cost, IsReturn, Seats, DepartureTime, ArrivalTime, DepartureLocalization, ArrivalLocalization) VALUES(2, 'Autobus', 70, 0, '', '2017-08-25 15:00:00', '2017-08-25 17:00:00', 5, 6);
INSERT INTO Transport(TripID, Vehicle, Cost, IsReturn, Seats, DepartureTime, ArrivalTime, DepartureLocalization, ArrivalLocalization) VALUES(2, 'Samolot', 1450, 1, '04', '2017-09-07 15:00:00', '2017-09-07 23:00:00', 6, 12);

INSERT INTO Transport(TripID, Vehicle, Cost, IsReturn, DepartureLocalization, ArrivalLocalization) VALUES(3, 'Samochód', 300, 0, 13, 7);
INSERT INTO Transport(TripID, Vehicle, Cost, IsReturn, DepartureLocalization, ArrivalLocalization) VALUES(3, 'Samochód', 300, 0, 7, 13);


