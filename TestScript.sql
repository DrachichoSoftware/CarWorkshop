USE [master]
GO
/****** Object:  Database [CarWorkshop]    Script Date: 05/12/2016 13:51:19 ******/
CREATE DATABASE [CarWorkshop] ON  PRIMARY 
( NAME = N'CarWorkshop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\CarWorkshop.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CarWorkshop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\CarWorkshop_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CarWorkshop] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarWorkshop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarWorkshop] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [CarWorkshop] SET ANSI_NULLS OFF
GO
ALTER DATABASE [CarWorkshop] SET ANSI_PADDING OFF
GO
ALTER DATABASE [CarWorkshop] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [CarWorkshop] SET ARITHABORT OFF
GO
ALTER DATABASE [CarWorkshop] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [CarWorkshop] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [CarWorkshop] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [CarWorkshop] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [CarWorkshop] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [CarWorkshop] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [CarWorkshop] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [CarWorkshop] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [CarWorkshop] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [CarWorkshop] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [CarWorkshop] SET  DISABLE_BROKER
GO
ALTER DATABASE [CarWorkshop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [CarWorkshop] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [CarWorkshop] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [CarWorkshop] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [CarWorkshop] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [CarWorkshop] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [CarWorkshop] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [CarWorkshop] SET  READ_WRITE
GO
ALTER DATABASE [CarWorkshop] SET RECOVERY FULL
GO
ALTER DATABASE [CarWorkshop] SET  MULTI_USER
GO
ALTER DATABASE [CarWorkshop] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [CarWorkshop] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'CarWorkshop', N'ON'
GO
USE [CarWorkshop]
GO
/****** Object:  Table [dbo].[Provider]    Script Date: 05/12/2016 13:51:19 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Provider] ON
INSERT [dbo].[Provider] ([ID_Provider], [Name]) VALUES (1, N'ООО "Автодок"')
INSERT [dbo].[Provider] ([ID_Provider], [Name]) VALUES (2, N'ООО "Экзист"')
SET IDENTITY_INSERT [dbo].[Provider] OFF
/****** Object:  Table [dbo].[Price]    Script Date: 05/12/2016 13:51:19 ******/
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
/****** Object:  Table [dbo].[Owner]    Script Date: 05/12/2016 13:51:19 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Owner] ON
INSERT [dbo].[Owner] ([ID_Owner], [RegistrationSertificate], [LastName], [FirstName], [Address], [Telephone]) VALUES (1, N'62ye756889', N'Петров', N'Валерий', N'ул. Высоковольтная, д.3, кв.18', N'774833')
INSERT [dbo].[Owner] ([ID_Owner], [RegistrationSertificate], [LastName], [FirstName], [Address], [Telephone]) VALUES (2, N'62рм998212', N'Сальцо', N'Георгий', N'ул. Дзержинского, д.4 к.1, кв.45', N'663821')
SET IDENTITY_INSERT [dbo].[Owner] OFF
/****** Object:  Table [dbo].[Master]    Script Date: 05/12/2016 13:51:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Master](
	[ID_Master] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [varchar](1024) NOT NULL,
	[FirstName] [varchar](1024) NOT NULL,
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
/****** Object:  Table [dbo].[Detail]    Script Date: 05/12/2016 13:51:19 ******/
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
/****** Object:  Table [dbo].[ServiceType]    Script Date: 05/12/2016 13:51:19 ******/
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
/****** Object:  Table [dbo].[Supply]    Script Date: 05/12/2016 13:51:19 ******/
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
CREATE NONCLUSTERED INDEX [Provide_FK] ON [dbo].[Supply] 
(
	[ID_Provider] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Supplying_FK] ON [dbo].[Supply] 
(
	[Article] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Supply] ON
INSERT [dbo].[Supply] ([ID_Provider], [Article], [ID_Supply]) VALUES (1, N'55295-hgu21', 1)
INSERT [dbo].[Supply] ([ID_Provider], [Article], [ID_Supply]) VALUES (2, N'o132-667h', 2)
SET IDENTITY_INSERT [dbo].[Supply] OFF
/****** Object:  Table [dbo].[Specializations]    Script Date: 05/12/2016 13:51:19 ******/
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
CREATE NONCLUSTERED INDEX [Can_FK] ON [dbo].[Specializations] 
(
	[ID_Master] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Connect_FK] ON [dbo].[Specializations] 
(
	[ID_ServiceType] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[Specializations] ([ID_Master], [ID_ServiceType]) VALUES (1, 1)
INSERT [dbo].[Specializations] ([ID_Master], [ID_ServiceType]) VALUES (1, 4)
INSERT [dbo].[Specializations] ([ID_Master], [ID_ServiceType]) VALUES (2, 2)
INSERT [dbo].[Specializations] ([ID_Master], [ID_ServiceType]) VALUES (2, 5)
INSERT [dbo].[Specializations] ([ID_Master], [ID_ServiceType]) VALUES (3, 4)
INSERT [dbo].[Specializations] ([ID_Master], [ID_ServiceType]) VALUES (4, 1)
INSERT [dbo].[Specializations] ([ID_Master], [ID_ServiceType]) VALUES (4, 3)
/****** Object:  Table [dbo].[Car]    Script Date: 05/12/2016 13:51:19 ******/
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
CREATE NONCLUSTERED INDEX [Has_FK] ON [dbo].[Car] 
(
	[ID_Owner] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[Car] ([VIN-code], [ID_Owner], [Model]) VALUES (N'KNAFU6737AD982U89', 1, N'ГАЗ 2110')
INSERT [dbo].[Car] ([VIN-code], [ID_Owner], [Model]) VALUES (N'HILMO2345123DD09I', 2, N'Nissan Almera')
/****** Object:  Table [dbo].[Order]    Script Date: 05/12/2016 13:51:19 ******/
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
CREATE NONCLUSTERED INDEX [Performing_FK] ON [dbo].[Order] 
(
	[VIN-code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Order] ON
INSERT [dbo].[Order] ([ID_Order], [VIN-code]) VALUES (1, N'HILMO2345123DD09I')
INSERT [dbo].[Order] ([ID_Order], [VIN-code]) VALUES (2, N'KNAFU6737AD982U89')
INSERT [dbo].[Order] ([ID_Order], [VIN-code]) VALUES (3, N'HILMO2345123DD09I')
SET IDENTITY_INSERT [dbo].[Order] OFF
/****** Object:  Table [dbo].[Service]    Script Date: 05/12/2016 13:51:19 ******/
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
CREATE NONCLUSTERED INDEX [Execute_FK] ON [dbo].[Service] 
(
	[Master] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Include_FK] ON [dbo].[Service] 
(
	[Price] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [MakesOn_FK] ON [dbo].[Service] 
(
	[Order] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Service] ON
INSERT [dbo].[Service] ([ID_Service], [Price], [Master], [Order], [IsWaranty], [BeginDate]) VALUES (1, 1, 2, 2, 0, CAST(0x5A3B0B00 AS Date))
INSERT [dbo].[Service] ([ID_Service], [Price], [Master], [Order], [IsWaranty], [BeginDate]) VALUES (2, 2, 2, 1, 0, CAST(0x5D3B0B00 AS Date))
INSERT [dbo].[Service] ([ID_Service], [Price], [Master], [Order], [IsWaranty], [BeginDate]) VALUES (3, 4, 4, 3, 0, CAST(0x5D3B0B00 AS Date))
SET IDENTITY_INSERT [dbo].[Service] OFF
/****** Object:  Table [dbo].[DetailInService]    Script Date: 05/12/2016 13:51:19 ******/
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
CREATE NONCLUSTERED INDEX [Extend_FK] ON [dbo].[DetailInService] 
(
	[Article] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Participate_FK] ON [dbo].[DetailInService] 
(
	[ID_Service] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_SUPPLY_PROVIDE_PROVIDER]    Script Date: 05/12/2016 13:51:19 ******/
ALTER TABLE [dbo].[Supply]  WITH CHECK ADD  CONSTRAINT [FK_SUPPLY_PROVIDE_PROVIDER] FOREIGN KEY([ID_Provider])
REFERENCES [dbo].[Provider] ([ID_Provider])
GO
ALTER TABLE [dbo].[Supply] CHECK CONSTRAINT [FK_SUPPLY_PROVIDE_PROVIDER]
GO
/****** Object:  ForeignKey [FK_SUPPLY_SUPPLYING_DETAIL]    Script Date: 05/12/2016 13:51:19 ******/
ALTER TABLE [dbo].[Supply]  WITH CHECK ADD  CONSTRAINT [FK_SUPPLY_SUPPLYING_DETAIL] FOREIGN KEY([Article])
REFERENCES [dbo].[Detail] ([Article])
GO
ALTER TABLE [dbo].[Supply] CHECK CONSTRAINT [FK_SUPPLY_SUPPLYING_DETAIL]
GO
/****** Object:  ForeignKey [FK_SPECIALI_CAN_MASTER]    Script Date: 05/12/2016 13:51:19 ******/
ALTER TABLE [dbo].[Specializations]  WITH CHECK ADD  CONSTRAINT [FK_SPECIALI_CAN_MASTER] FOREIGN KEY([ID_Master])
REFERENCES [dbo].[Master] ([ID_Master])
GO
ALTER TABLE [dbo].[Specializations] CHECK CONSTRAINT [FK_SPECIALI_CAN_MASTER]
GO
/****** Object:  ForeignKey [FK_SPECIALI_CONNECT_SERVICET]    Script Date: 05/12/2016 13:51:19 ******/
ALTER TABLE [dbo].[Specializations]  WITH CHECK ADD  CONSTRAINT [FK_SPECIALI_CONNECT_SERVICET] FOREIGN KEY([ID_ServiceType])
REFERENCES [dbo].[ServiceType] ([ID_ServiceType])
GO
ALTER TABLE [dbo].[Specializations] CHECK CONSTRAINT [FK_SPECIALI_CONNECT_SERVICET]
GO
/****** Object:  ForeignKey [FK_CAR_HAS_OWNER]    Script Date: 05/12/2016 13:51:19 ******/
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_CAR_HAS_OWNER] FOREIGN KEY([ID_Owner])
REFERENCES [dbo].[Owner] ([ID_Owner])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_CAR_HAS_OWNER]
GO
/****** Object:  ForeignKey [FK_ORDER_PERFORMIN_CAR]    Script Date: 05/12/2016 13:51:19 ******/
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_PERFORMIN_CAR] FOREIGN KEY([VIN-code])
REFERENCES [dbo].[Car] ([VIN-code])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_ORDER_PERFORMIN_CAR]
GO
/****** Object:  ForeignKey [FK_SERVICE_EXECUTE_MASTER]    Script Date: 05/12/2016 13:51:19 ******/
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [FK_SERVICE_EXECUTE_MASTER] FOREIGN KEY([Master])
REFERENCES [dbo].[Master] ([ID_Master])
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [FK_SERVICE_EXECUTE_MASTER]
GO
/****** Object:  ForeignKey [FK_SERVICE_INCLUDE_PRICE]    Script Date: 05/12/2016 13:51:19 ******/
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [FK_SERVICE_INCLUDE_PRICE] FOREIGN KEY([Price])
REFERENCES [dbo].[Price] ([ID_Price])
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [FK_SERVICE_INCLUDE_PRICE]
GO
/****** Object:  ForeignKey [FK_SERVICE_MAKESON_ORDER]    Script Date: 05/12/2016 13:51:19 ******/
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [FK_SERVICE_MAKESON_ORDER] FOREIGN KEY([Order])
REFERENCES [dbo].[Order] ([ID_Order])
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [FK_SERVICE_MAKESON_ORDER]
GO
/****** Object:  ForeignKey [FK_DETAILIN_EXTEND_DETAIL]    Script Date: 05/12/2016 13:51:19 ******/
ALTER TABLE [dbo].[DetailInService]  WITH CHECK ADD  CONSTRAINT [FK_DETAILIN_EXTEND_DETAIL] FOREIGN KEY([Article])
REFERENCES [dbo].[Detail] ([Article])
GO
ALTER TABLE [dbo].[DetailInService] CHECK CONSTRAINT [FK_DETAILIN_EXTEND_DETAIL]
GO
/****** Object:  ForeignKey [FK_DETAILIN_PARTICIPA_SERVICE]    Script Date: 05/12/2016 13:51:19 ******/
ALTER TABLE [dbo].[DetailInService]  WITH CHECK ADD  CONSTRAINT [FK_DETAILIN_PARTICIPA_SERVICE] FOREIGN KEY([ID_Service])
REFERENCES [dbo].[Service] ([ID_Service])
GO
ALTER TABLE [dbo].[DetailInService] CHECK CONSTRAINT [FK_DETAILIN_PARTICIPA_SERVICE]
GO
