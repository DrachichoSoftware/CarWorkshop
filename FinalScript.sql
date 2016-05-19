USE [CarWorkshop]
GO
/****** Object:  Table [dbo].[ServiceType]    Script Date: 05/19/2016 13:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ServiceType](
	[ID_ServiceType] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](1024) NOT NULL,
 CONSTRAINT [PK_SERVICETYPE] PRIMARY KEY NONCLUSTERED 
(
	[ID_ServiceType] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ServiceType] ON
INSERT [dbo].[ServiceType] ([ID_ServiceType], [Name]) VALUES (1, N'Электрика')
INSERT [dbo].[ServiceType] ([ID_ServiceType], [Name]) VALUES (2, N'Кузовные')
INSERT [dbo].[ServiceType] ([ID_ServiceType], [Name]) VALUES (3, N'Слесарные')
INSERT [dbo].[ServiceType] ([ID_ServiceType], [Name]) VALUES (4, N'ДВС')
INSERT [dbo].[ServiceType] ([ID_ServiceType], [Name]) VALUES (5, N'Техническое обслуживание')
SET IDENTITY_INSERT [dbo].[ServiceType] OFF
/****** Object:  Table [dbo].[Provider]    Script Date: 05/19/2016 13:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Provider](
	[ID_Provider] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](1024) NOT NULL,
 CONSTRAINT [PK_PROVIDER] PRIMARY KEY NONCLUSTERED 
(
	[ID_Provider] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [AK_Provider_Name] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Provider] ON
INSERT [dbo].[Provider] ([ID_Provider], [Name]) VALUES (1, N'ООО "Автодок"')
INSERT [dbo].[Provider] ([ID_Provider], [Name]) VALUES (2, N'ООО "Экзист"')
SET IDENTITY_INSERT [dbo].[Provider] OFF
/****** Object:  Table [dbo].[Price]    Script Date: 05/19/2016 13:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Price](
	[ID_Price] [int] IDENTITY(1,1) NOT NULL,
	[ServiceWork] [varchar](1024) NOT NULL,
	[Coast] [money] NOT NULL,
 CONSTRAINT [PK_PRICE] PRIMARY KEY NONCLUSTERED 
(
	[ID_Price] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Price] ON
INSERT [dbo].[Price] ([ID_Price], [ServiceWork], [Coast]) VALUES (1, N'Прочистка карбюратора', 1000.0000)
INSERT [dbo].[Price] ([ID_Price], [ServiceWork], [Coast]) VALUES (2, N'Замена охлаждающей жидкости радиатора', 600.0000)
INSERT [dbo].[Price] ([ID_Price], [ServiceWork], [Coast]) VALUES (3, N'Установка углов развала и схождения', 800.0000)
INSERT [dbo].[Price] ([ID_Price], [ServiceWork], [Coast]) VALUES (4, N'Замена стоек стабилизатора подвески', 1200.0000)
SET IDENTITY_INSERT [dbo].[Price] OFF
/****** Object:  Table [dbo].[Owner]    Script Date: 05/19/2016 13:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Owner](
	[ID_Owner] [int] IDENTITY(1,1) NOT NULL,
	[RegistrationSertificate] [varchar](10) NOT NULL,
	[LastName] [varchar](32) NOT NULL,
	[FirstName] [varchar](32) NOT NULL,
	[Address] [varchar](64) NULL,
	[Telephone] [varchar](11) NULL,
 CONSTRAINT [PK_OWNER] PRIMARY KEY NONCLUSTERED 
(
	[ID_Owner] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [AK_Owner_RegistrationSertificate] UNIQUE NONCLUSTERED 
(
	[RegistrationSertificate] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Owner] ON
INSERT [dbo].[Owner] ([ID_Owner], [RegistrationSertificate], [LastName], [FirstName], [Address], [Telephone]) VALUES (1, N'62ye756889', N'Петров', N'Валерий', N'ул. Высоковольтная, д.3, кв.18', N'774833')
INSERT [dbo].[Owner] ([ID_Owner], [RegistrationSertificate], [LastName], [FirstName], [Address], [Telephone]) VALUES (2, N'62рм998212', N'Сальцо', N'Георгий', N'ул. Дзержинского, д.4 к.1, кв.45', N'663821')
SET IDENTITY_INSERT [dbo].[Owner] OFF
/****** Object:  Table [dbo].[Master]    Script Date: 05/19/2016 13:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Master](
	[ID_Master] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [varchar](32) NOT NULL,
	[FirstName] [varchar](32) NOT NULL,
	[EmploymentDate] [date] NULL,
 CONSTRAINT [PK_MASTER] PRIMARY KEY NONCLUSTERED 
(
	[ID_Master] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Master] ON
INSERT [dbo].[Master] ([ID_Master], [LastName], [FirstName], [EmploymentDate]) VALUES (1, N'Иванов', N'Кирилл', CAST(0x1D3B0B00 AS Date))
INSERT [dbo].[Master] ([ID_Master], [LastName], [FirstName], [EmploymentDate]) VALUES (2, N'Никифоров', N'Владислав', CAST(0x1F3B0B00 AS Date))
INSERT [dbo].[Master] ([ID_Master], [LastName], [FirstName], [EmploymentDate]) VALUES (3, N'Арсениев', N'Владимир', CAST(0x283B0B00 AS Date))
INSERT [dbo].[Master] ([ID_Master], [LastName], [FirstName], [EmploymentDate]) VALUES (4, N'Трифонов', N'Николай', CAST(0x373B0B00 AS Date))
SET IDENTITY_INSERT [dbo].[Master] OFF
/****** Object:  Table [dbo].[Detail]    Script Date: 05/19/2016 13:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Detail](
	[Article] [varchar](20) NOT NULL,
	[Name] [varchar](1024) NOT NULL,
 CONSTRAINT [PK_DETAIL] PRIMARY KEY NONCLUSTERED 
(
	[Article] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Detail] ([Article], [Name]) VALUES (N'o132-667h', N'Охлаждающая жидкость радиатора')
INSERT [dbo].[Detail] ([Article], [Name]) VALUES (N'55295-hgu21', N'Жидкость для прочистки карбюратора')
/****** Object:  StoredProcedure [dbo].[DeletePrice]    Script Date: 05/19/2016 13:27:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeletePrice](
	@id int)
AS
	DECLARE @code AS INT = 0
	IF EXISTS(SELECT * FROM Price WHERE ID_Price = @id)
		DELETE FROM Price WHERE ID_Price = @id
	ELSE
		SET @code = 1
	RETURN @code
GO
/****** Object:  Table [dbo].[Car]    Script Date: 05/19/2016 13:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Car](
	[VIN-code] [varchar](17) NOT NULL,
	[ID_Owner] [int] NOT NULL,
	[Model] [varchar](1024) NOT NULL,
 CONSTRAINT [PK_CAR] PRIMARY KEY NONCLUSTERED 
(
	[VIN-code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Car] ([VIN-code], [ID_Owner], [Model]) VALUES (N'KNAFU6737AD982U89', 1, N'ГАЗ 2110')
INSERT [dbo].[Car] ([VIN-code], [ID_Owner], [Model]) VALUES (N'HILMO2345123DD09I', 2, N'Nissan Almera')
/****** Object:  StoredProcedure [dbo].[AddProvider]    Script Date: 05/19/2016 13:27:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddProvider] (
	@name varchar(1024))
AS
	DECLARE @code AS INT = 0

	IF NOT EXISTS (SELECT Provider.Name
				FROM Provider
				WHERE Provider.Name = @name)
		INSERT INTO Provider(Name)
			VALUES (@name)
	ELSE
		SET @code = 1
		
	RETURN @code
GO
/****** Object:  StoredProcedure [dbo].[AddPrice]    Script Date: 05/19/2016 13:27:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddPrice](
	@serviceWork varchar(1024),
	@coast money)
AS
	INSERT INTO Price(ServiceWork, Coast)
		VALUES(@serviceWork, @coast)
GO
/****** Object:  StoredProcedure [dbo].[AddOwner]    Script Date: 05/19/2016 13:27:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddOwner] (
	@registrationSertificate varchar(10), 
	@lastName varchar(32), 
	@firstName varchar(32), 
	@address varchar(64),
	@telephone varchar(11))
AS
	DECLARE @code AS INT = 0
	
	IF NOT EXISTS (SELECT [Owner].RegistrationSertificate
					FROM [Owner]
					WHERE [Owner].RegistrationSertificate = @registrationSertificate)
			BEGIN
				INSERT INTO [Owner](RegistrationSertificate, LastName, FirstName, [Address], [Telephone])
					VALUES (@registrationSertificate, @lastName, @firstName, @address, @telephone)
			END
	ELSE
		BEGIN
			SET @code = 1
		END
	RETURN @code
GO
/****** Object:  Table [dbo].[Supply]    Script Date: 05/19/2016 13:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Supply](
	[ID_Provider] [int] NOT NULL,
	[Article] [varchar](20) NOT NULL,
	[ID_Supply] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_SUPPLY] PRIMARY KEY CLUSTERED 
(
	[ID_Supply] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Supply] ON
INSERT [dbo].[Supply] ([ID_Provider], [Article], [ID_Supply]) VALUES (1, N'55295-hgu21', 1)
INSERT [dbo].[Supply] ([ID_Provider], [Article], [ID_Supply]) VALUES (2, N'o132-667h', 2)
SET IDENTITY_INSERT [dbo].[Supply] OFF
/****** Object:  Table [dbo].[Specializations]    Script Date: 05/19/2016 13:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specializations](
	[ID_Master] [int] NOT NULL,
	[ID_ServiceType] [int] NOT NULL,
 CONSTRAINT [PK_SPECIALIZATIONS] PRIMARY KEY NONCLUSTERED 
(
	[ID_Master] ASC,
	[ID_ServiceType] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Specializations] ([ID_Master], [ID_ServiceType]) VALUES (1, 1)
INSERT [dbo].[Specializations] ([ID_Master], [ID_ServiceType]) VALUES (1, 4)
INSERT [dbo].[Specializations] ([ID_Master], [ID_ServiceType]) VALUES (2, 2)
INSERT [dbo].[Specializations] ([ID_Master], [ID_ServiceType]) VALUES (2, 5)
INSERT [dbo].[Specializations] ([ID_Master], [ID_ServiceType]) VALUES (3, 4)
INSERT [dbo].[Specializations] ([ID_Master], [ID_ServiceType]) VALUES (4, 1)
INSERT [dbo].[Specializations] ([ID_Master], [ID_ServiceType]) VALUES (4, 3)
/****** Object:  StoredProcedure [dbo].[DismissMaster]    Script Date: 05/19/2016 13:27:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DismissMaster](
	@id int)
AS
	DECLARE @code AS INT = 0

	IF EXISTS(SELECT *
				FROM [Master]
				WHERE [Master].[ID_Master] = @id)
		BEGIN
			DELETE FROM Specialization WHERE ID_Master = @id
			DELETE FROM [Master] WHERE ID_Master = @id
		END
	ELSE
		SET @code = 1
	RETURN @code
GO
/****** Object:  StoredProcedure [dbo].[AddCar]    Script Date: 05/19/2016 13:27:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddCar](
	@vinCode varchar(17),
	@owner int,
	@model varchar(1024))
AS
	DECLARE @code AS INT = 0
	
	IF EXISTS (SELECT Car.[VIN-code] 
				FROM Car
				WHERE Car.[VIN-code] = @vinCode)
			BEGIN
				SET @code = 1
			END
	ELSE IF NOT EXISTS (SELECT [Owner].ID_Owner
						FROM [Owner]
						WHERE [Owner].ID_Owner = @owner)
		BEGIN
			SET @code = 2
		END
	ELSE
		BEGIN
			INSERT INTO Car([VIN-code], ID_Owner, Model)
				VALUES (@vinCode, @owner, @model)
		END
	RETURN @code
GO
/****** Object:  StoredProcedure [dbo].[MakeDelivery]    Script Date: 05/19/2016 13:27:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MakeDelivery] (
	@detail varchar(20),
	@provider int)
AS
	DECLARE @code AS INT = 0
	
	IF EXISTS (SELECT Detail.Article
				FROM Detail
				WHERE Detail.Article = @detail) AND
	   EXISTS (SELECT Provider.[ID_Provider]
				FROM Provider
				WHERE Provider.[ID_Provider] = @provider)
		INSERT INTO Supply(Article, ID_Provider)
			VALUES (@detail, @provider)
	ELSE IF NOT EXISTS (SELECT Detail.Article
							FROM Detail
							WHERE Detail.Article = @detail) AND
			  NOT EXISTS (SELECT Provider.[ID_Provider]
							FROM Provider
							WHERE Provider.[ID_Provider] = @provider)
		SET @code = 3
	ELSE IF NOT EXISTS (SELECT Detail.Article
							FROM Detail
							WHERE Detail.Article = @detail)
		SET @code = 1
	ELSE IF NOT EXISTS (SELECT Provider.[ID_Provider]
				FROM Provider
				WHERE Provider.[ID_Provider] = @provider)
		SET @code = 2
	
	
	RETURN @code
GO
/****** Object:  StoredProcedure [dbo].[AddMaster]    Script Date: 05/19/2016 13:27:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddMaster](
	@lastName varchar(32),
	@firstName varchar(32),
	@employmentDate date,
	@specialization int)
AS
	DECLARE @code AS INT = 0

	IF EXISTS (SELECT ServiceType.ID_ServiceType
				FROM ServiceType
				WHERE ServiceType.ID_ServiceType = @specialization)
		BEGIN
			INSERT INTO [Master](LastName, FirstName, EmploymentDate)
				VALUES (@lastName, @firstName, @employmentDate)
				
			INSERT INTO Specializations(ID_Master, ID_ServiceType)
				VALUES (@@IDENTITY, @specialization)
		END
	ELSE
		SET @code = 1
	
	RETURN @code
GO
/****** Object:  Table [dbo].[Order]    Script Date: 05/19/2016 13:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Order](
	[ID_Order] [int] IDENTITY(1,1) NOT NULL,
	[VIN-code] [varchar](17) NOT NULL,
 CONSTRAINT [PK_ORDER] PRIMARY KEY NONCLUSTERED 
(
	[ID_Order] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON
INSERT [dbo].[Order] ([ID_Order], [VIN-code]) VALUES (1, N'HILMO2345123DD09I')
INSERT [dbo].[Order] ([ID_Order], [VIN-code]) VALUES (2, N'KNAFU6737AD982U89')
INSERT [dbo].[Order] ([ID_Order], [VIN-code]) VALUES (3, N'HILMO2345123DD09I')
SET IDENTITY_INSERT [dbo].[Order] OFF
/****** Object:  Table [dbo].[Service]    Script Date: 05/19/2016 13:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[ID_Service] [int] IDENTITY(1,1) NOT NULL,
	[Price] [int] NOT NULL,
	[Master] [int] NOT NULL,
	[Order] [int] NOT NULL,
	[IsWaranty] [bit] NOT NULL,
	[BeginDate] [date] NOT NULL,
 CONSTRAINT [PK_SERVICE] PRIMARY KEY NONCLUSTERED 
(
	[ID_Service] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [AK_Service_Order] UNIQUE NONCLUSTERED 
(
	[Order] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Service] ON
INSERT [dbo].[Service] ([ID_Service], [Price], [Master], [Order], [IsWaranty], [BeginDate]) VALUES (1, 1, 2, 2, 0, CAST(0x5A3B0B00 AS Date))
INSERT [dbo].[Service] ([ID_Service], [Price], [Master], [Order], [IsWaranty], [BeginDate]) VALUES (2, 2, 2, 1, 0, CAST(0x5D3B0B00 AS Date))
INSERT [dbo].[Service] ([ID_Service], [Price], [Master], [Order], [IsWaranty], [BeginDate]) VALUES (3, 4, 4, 3, 0, CAST(0x5D3B0B00 AS Date))
SET IDENTITY_INSERT [dbo].[Service] OFF
/****** Object:  Table [dbo].[DetailInService]    Script Date: 05/19/2016 13:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetailInService](
	[ID_Service] [int] NOT NULL,
	[Article] [varchar](20) NOT NULL,
 CONSTRAINT [PK_DETAILINSERVICE] PRIMARY KEY CLUSTERED 
(
	[ID_Service] ASC,
	[Article] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[AddServiceWork]    Script Date: 05/19/2016 13:27:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddServiceWork] (@carVinCode varchar(17), @price int, @master int, @isWaranty bit, @beginDate date)
AS
	DECLARE @code AS INT = 0
	
	IF EXISTS (SELECT Car.[VIN-code] 
				FROM Car
				WHERE Car.[VIN-code] = @carVinCode)
			BEGIN
				INSERT INTO [Order]([VIN-code])
					VALUES (@carVinCode)
				
				INSERT INTO [Service](Price, [Master], [Order], [IsWaranty], [BeginDate])
					VALUES (@price, @master, @@IDENTITY, @isWaranty, @beginDate)
			END
	ELSE
		BEGIN
			SET @code = 1
		END
	RETURN @code
GO
/****** Object:  StoredProcedure [dbo].[AddDetailToService]    Script Date: 05/19/2016 13:27:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddDetailToService] (
	@article varchar(20),
	@name varchar(1024),
	@service int)
AS
	DECLARE @code AS INT = 0
	
	IF NOT EXISTS (SELECT [Service].[ID_Service]
					FROM [Service]
					WHERE [Service].[ID_Service] = @service)
		BEGIN
			SET @code = 1
			RETURN @code
		END
	ELSE
		BEGIN
			IF EXISTS (SELECT Detail.Article
						FROM Detail
						WHERE Detail.Article = @article)
				BEGIN
					INSERT INTO DetailInService(Article, ID_Service)
						VALUES (@article, @service)
				END
			ELSE
				BEGIN
					INSERT INTO Detail(Article, Name)
						VALUES(@article, @name)
						
					INSERT INTO DetailInService(Article, ID_Service)
						VALUES (@article, @service)
				END
		END
	
	RETURN @code
GO
/****** Object:  ForeignKey [FK_CAR_HAS_OWNER]    Script Date: 05/19/2016 13:27:28 ******/
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_CAR_HAS_OWNER] FOREIGN KEY([ID_Owner])
REFERENCES [dbo].[Owner] ([ID_Owner])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_CAR_HAS_OWNER]
GO
/****** Object:  ForeignKey [FK_DETAILIN_EXTEND_DETAIL]    Script Date: 05/19/2016 13:27:28 ******/
ALTER TABLE [dbo].[DetailInService]  WITH CHECK ADD  CONSTRAINT [FK_DETAILIN_EXTEND_DETAIL] FOREIGN KEY([Article])
REFERENCES [dbo].[Detail] ([Article])
GO
ALTER TABLE [dbo].[DetailInService] CHECK CONSTRAINT [FK_DETAILIN_EXTEND_DETAIL]
GO
/****** Object:  ForeignKey [FK_DETAILIN_PARTICIPA_SERVICE]    Script Date: 05/19/2016 13:27:28 ******/
ALTER TABLE [dbo].[DetailInService]  WITH CHECK ADD  CONSTRAINT [FK_DETAILIN_PARTICIPA_SERVICE] FOREIGN KEY([ID_Service])
REFERENCES [dbo].[Service] ([ID_Service])
GO
ALTER TABLE [dbo].[DetailInService] CHECK CONSTRAINT [FK_DETAILIN_PARTICIPA_SERVICE]
GO
/****** Object:  ForeignKey [FK_ORDER_PERFORMIN_CAR]    Script Date: 05/19/2016 13:27:28 ******/
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_PERFORMIN_CAR] FOREIGN KEY([VIN-code])
REFERENCES [dbo].[Car] ([VIN-code])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_ORDER_PERFORMIN_CAR]
GO
/****** Object:  ForeignKey [FK_SERVICE_EXECUTE_MASTER]    Script Date: 05/19/2016 13:27:28 ******/
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [FK_SERVICE_EXECUTE_MASTER] FOREIGN KEY([Master])
REFERENCES [dbo].[Master] ([ID_Master])
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [FK_SERVICE_EXECUTE_MASTER]
GO
/****** Object:  ForeignKey [FK_SERVICE_INCLUDE_PRICE]    Script Date: 05/19/2016 13:27:28 ******/
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [FK_SERVICE_INCLUDE_PRICE] FOREIGN KEY([Price])
REFERENCES [dbo].[Price] ([ID_Price])
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [FK_SERVICE_INCLUDE_PRICE]
GO
/****** Object:  ForeignKey [FK_SERVICE_MAKESON_ORDER]    Script Date: 05/19/2016 13:27:28 ******/
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [FK_SERVICE_MAKESON_ORDER] FOREIGN KEY([Order])
REFERENCES [dbo].[Order] ([ID_Order])
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [FK_SERVICE_MAKESON_ORDER]
GO
/****** Object:  ForeignKey [FK_SPECIALI_CAN_MASTER]    Script Date: 05/19/2016 13:27:28 ******/
ALTER TABLE [dbo].[Specializations]  WITH CHECK ADD  CONSTRAINT [FK_SPECIALI_CAN_MASTER] FOREIGN KEY([ID_Master])
REFERENCES [dbo].[Master] ([ID_Master])
GO
ALTER TABLE [dbo].[Specializations] CHECK CONSTRAINT [FK_SPECIALI_CAN_MASTER]
GO
/****** Object:  ForeignKey [FK_SPECIALI_CONNECT_SERVICET]    Script Date: 05/19/2016 13:27:28 ******/
ALTER TABLE [dbo].[Specializations]  WITH CHECK ADD  CONSTRAINT [FK_SPECIALI_CONNECT_SERVICET] FOREIGN KEY([ID_ServiceType])
REFERENCES [dbo].[ServiceType] ([ID_ServiceType])
GO
ALTER TABLE [dbo].[Specializations] CHECK CONSTRAINT [FK_SPECIALI_CONNECT_SERVICET]
GO
/****** Object:  ForeignKey [FK_SUPPLY_PROVIDE_PROVIDER]    Script Date: 05/19/2016 13:27:28 ******/
ALTER TABLE [dbo].[Supply]  WITH CHECK ADD  CONSTRAINT [FK_SUPPLY_PROVIDE_PROVIDER] FOREIGN KEY([ID_Provider])
REFERENCES [dbo].[Provider] ([ID_Provider])
GO
ALTER TABLE [dbo].[Supply] CHECK CONSTRAINT [FK_SUPPLY_PROVIDE_PROVIDER]
GO
/****** Object:  ForeignKey [FK_SUPPLY_SUPPLYING_DETAIL]    Script Date: 05/19/2016 13:27:28 ******/
ALTER TABLE [dbo].[Supply]  WITH CHECK ADD  CONSTRAINT [FK_SUPPLY_SUPPLYING_DETAIL] FOREIGN KEY([Article])
REFERENCES [dbo].[Detail] ([Article])
GO
ALTER TABLE [dbo].[Supply] CHECK CONSTRAINT [FK_SUPPLY_SUPPLYING_DETAIL]
GO
