/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     10.05.2016 11:59:57                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Car') and o.name = 'FK_CAR_HAS_OWNER')
alter table Car
   drop constraint FK_CAR_HAS_OWNER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DetailInService') and o.name = 'FK_DETAILIN_EXTEND_DETAIL')
alter table DetailInService
   drop constraint FK_DETAILIN_EXTEND_DETAIL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DetailInService') and o.name = 'FK_DETAILIN_PARTICIPA_SERVICE')
alter table DetailInService
   drop constraint FK_DETAILIN_PARTICIPA_SERVICE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"Order"') and o.name = 'FK_ORDER_PERFORMIN_CAR')
alter table "Order"
   drop constraint FK_ORDER_PERFORMIN_CAR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Service') and o.name = 'FK_SERVICE_EXECUTE_MASTER')
alter table Service
   drop constraint FK_SERVICE_EXECUTE_MASTER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Service') and o.name = 'FK_SERVICE_INCLUDE_PRICE')
alter table Service
   drop constraint FK_SERVICE_INCLUDE_PRICE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Service') and o.name = 'FK_SERVICE_MAKESON_ORDER')
alter table Service
   drop constraint FK_SERVICE_MAKESON_ORDER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Specializations') and o.name = 'FK_SPECIALI_CAN_MASTER')
alter table Specializations
   drop constraint FK_SPECIALI_CAN_MASTER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Specializations') and o.name = 'FK_SPECIALI_CONNECT_SERVICET')
alter table Specializations
   drop constraint FK_SPECIALI_CONNECT_SERVICET
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Supply') and o.name = 'FK_SUPPLY_PROVIDE_PROVIDER')
alter table Supply
   drop constraint FK_SUPPLY_PROVIDE_PROVIDER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Supply') and o.name = 'FK_SUPPLY_SUPPLYING_DETAIL')
alter table Supply
   drop constraint FK_SUPPLY_SUPPLYING_DETAIL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Car')
            and   name  = 'Has_FK'
            and   indid > 0
            and   indid < 255)
   drop index Car.Has_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Car')
            and   type = 'U')
   drop table Car
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Detail')
            and   type = 'U')
   drop table Detail
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DetailInService')
            and   name  = 'Participate_FK'
            and   indid > 0
            and   indid < 255)
   drop index DetailInService.Participate_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DetailInService')
            and   name  = 'Extend_FK'
            and   indid > 0
            and   indid < 255)
   drop index DetailInService.Extend_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DetailInService')
            and   type = 'U')
   drop table DetailInService
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Master')
            and   type = 'U')
   drop table Master
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"Order"')
            and   name  = 'Performing_FK'
            and   indid > 0
            and   indid < 255)
   drop index "Order".Performing_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"Order"')
            and   type = 'U')
   drop table "Order"
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Owner')
            and   type = 'U')
   drop table Owner
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Price')
            and   type = 'U')
   drop table Price
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Provider')
            and   type = 'U')
   drop table Provider
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Service')
            and   name  = 'MakesOn_FK'
            and   indid > 0
            and   indid < 255)
   drop index Service.MakesOn_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Service')
            and   name  = 'Execute_FK'
            and   indid > 0
            and   indid < 255)
   drop index Service.Execute_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Service')
            and   name  = 'Include_FK'
            and   indid > 0
            and   indid < 255)
   drop index Service.Include_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Service')
            and   type = 'U')
   drop table Service
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ServiceType')
            and   type = 'U')
   drop table ServiceType
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Specializations')
            and   name  = 'Can_FK'
            and   indid > 0
            and   indid < 255)
   drop index Specializations.Can_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Specializations')
            and   name  = 'Connect_FK'
            and   indid > 0
            and   indid < 255)
   drop index Specializations.Connect_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Specializations')
            and   type = 'U')
   drop table Specializations
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Supply')
            and   name  = 'Provide_FK'
            and   indid > 0
            and   indid < 255)
   drop index Supply.Provide_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Supply')
            and   name  = 'Supplying_FK'
            and   indid > 0
            and   indid < 255)
   drop index Supply.Supplying_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Supply')
            and   type = 'U')
   drop table Supply
go

/*==============================================================*/
/* Table: Car                                                   */
/*==============================================================*/
create table Car (
   "VIN-code"           varchar(17)          not null,
   ID_Owner             int                  not null,
   Model                varchar(1024)        not null,
   constraint PK_CAR primary key nonclustered ("VIN-code")
)
go

/*==============================================================*/
/* Index: Has_FK                                                */
/*==============================================================*/
create index Has_FK on Car (
ID_Owner ASC
)
go

/*==============================================================*/
/* Table: Detail                                                */
/*==============================================================*/
create table Detail (
   Article              varchar(20)          not null,
   Name                 varchar(1024)        not null,
   constraint PK_DETAIL primary key nonclustered (Article)
)
go

/*==============================================================*/
/* Table: DetailInService                                       */
/*==============================================================*/
create table DetailInService (
   ID_Service           int                  not null,
   Article              varchar(20)          not null,
   constraint PK_DETAILINSERVICE primary key nonclustered (ID_Service, Article)
)
go

/*==============================================================*/
/* Index: Extend_FK                                             */
/*==============================================================*/
create index Extend_FK on DetailInService (
Article ASC
)
go

/*==============================================================*/
/* Index: Participate_FK                                        */
/*==============================================================*/
create index Participate_FK on DetailInService (
ID_Service ASC
)
go

/*==============================================================*/
/* Table: Master                                                */
/*==============================================================*/
create table Master (
   ID_Master            int                  identity,
   LastName             varchar(1024)        not null,
   FirstName            varchar(1024)        not null,
   EmploymentDate       datetime             not null,
   constraint PK_MASTER primary key nonclustered (ID_Master)
)
go

/*==============================================================*/
/* Table: "Order"                                               */
/*==============================================================*/
create table "Order" (
   ID_Order             int                  identity,
   "VIN-code"           varchar(17)          not null,
   constraint PK_ORDER primary key nonclustered (ID_Order)
)
go

/*==============================================================*/
/* Index: Performing_FK                                         */
/*==============================================================*/
create index Performing_FK on "Order" (
"VIN-code" ASC
)
go

/*==============================================================*/
/* Table: Owner                                                 */
/*==============================================================*/
create table Owner (
   ID_Owner             int                  identity,
   RegistrationSertificate varchar(10)          not null,
   LastName             varchar(32)          not null,
   FirstName            varchar(32)          not null,
   Address              varchar(64)          null,
   constraint PK_OWNER primary key nonclustered (ID_Owner)
)
go

/*==============================================================*/
/* Table: Price                                                 */
/*==============================================================*/
create table Price (
   ID_Price             int                  identity,
   ServiceWork          varchar(1024)        not null,
   Coast                money                not null,
   constraint PK_PRICE primary key nonclustered (ID_Price)
)
go

/*==============================================================*/
/* Table: Provider                                              */
/*==============================================================*/
create table Provider (
   ID_Provider          int                  identity,
   Name                 varchar(1024)        not null,
   constraint PK_PROVIDER primary key nonclustered (ID_Provider)
)
go

/*==============================================================*/
/* Table: Service                                               */
/*==============================================================*/
create table Service (
   ID_Service           int                  identity,
   Price                int                  not null,
   Master               int                  not null,
   "Order"              int                  not null,
   IsWaranty            bit                  not null,
   BeginDate            datetime             not null,
   constraint PK_SERVICE primary key nonclustered (ID_Service)
)
go

/*==============================================================*/
/* Index: Include_FK                                            */
/*==============================================================*/
create index Include_FK on Service (
Price ASC
)
go

/*==============================================================*/
/* Index: Execute_FK                                            */
/*==============================================================*/
create index Execute_FK on Service (
Master ASC
)
go

/*==============================================================*/
/* Index: MakesOn_FK                                            */
/*==============================================================*/
create index MakesOn_FK on Service (
"Order" ASC
)
go

/*==============================================================*/
/* Table: ServiceType                                           */
/*==============================================================*/
create table ServiceType (
   ID_ServiceType       int                  identity,
   Name                 varchar(1024)        not null,
   constraint PK_SERVICETYPE primary key nonclustered (ID_ServiceType)
)
go

/*==============================================================*/
/* Table: Specializations                                       */
/*==============================================================*/
create table Specializations (
   ID_Master            int                  not null,
   ID_ServiceType       int                  not null,
   constraint PK_SPECIALIZATIONS primary key nonclustered (ID_Master, ID_ServiceType)
)
go

/*==============================================================*/
/* Index: Connect_FK                                            */
/*==============================================================*/
create index Connect_FK on Specializations (
ID_ServiceType ASC
)
go

/*==============================================================*/
/* Index: Can_FK                                                */
/*==============================================================*/
create index Can_FK on Specializations (
ID_Master ASC
)
go

/*==============================================================*/
/* Table: Supply                                                */
/*==============================================================*/
create table Supply (
   ID_Provider          int                  not null,
   Article              varchar(20)          not null,
   constraint PK_SUPPLY primary key nonclustered (ID_Provider, Article)
)
go

/*==============================================================*/
/* Index: Supplying_FK                                          */
/*==============================================================*/
create index Supplying_FK on Supply (
Article ASC
)
go

/*==============================================================*/
/* Index: Provide_FK                                            */
/*==============================================================*/
create index Provide_FK on Supply (
ID_Provider ASC
)
go

alter table Car
   add constraint FK_CAR_HAS_OWNER foreign key (ID_Owner)
      references Owner (ID_Owner)
go

alter table DetailInService
   add constraint FK_DETAILIN_EXTEND_DETAIL foreign key (Article)
      references Detail (Article)
go

alter table DetailInService
   add constraint FK_DETAILIN_PARTICIPA_SERVICE foreign key (ID_Service)
      references Service (ID_Service)
go

alter table "Order"
   add constraint FK_ORDER_PERFORMIN_CAR foreign key ("VIN-code")
      references Car ("VIN-code")
go

alter table Service
   add constraint FK_SERVICE_EXECUTE_MASTER foreign key (Master)
      references Master (ID_Master)
go

alter table Service
   add constraint FK_SERVICE_INCLUDE_PRICE foreign key (Price)
      references Price (ID_Price)
go

alter table Service
   add constraint FK_SERVICE_MAKESON_ORDER foreign key ("Order")
      references "Order" (ID_Order)
go

alter table Specializations
   add constraint FK_SPECIALI_CAN_MASTER foreign key (ID_Master)
      references Master (ID_Master)
go

alter table Specializations
   add constraint FK_SPECIALI_CONNECT_SERVICET foreign key (ID_ServiceType)
      references ServiceType (ID_ServiceType)
go

alter table Supply
   add constraint FK_SUPPLY_PROVIDE_PROVIDER foreign key (ID_Provider)
      references Provider (ID_Provider)
go

alter table Supply
   add constraint FK_SUPPLY_SUPPLYING_DETAIL foreign key (Article)
      references Detail (Article)
go

