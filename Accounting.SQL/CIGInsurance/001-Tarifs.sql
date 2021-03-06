/****** Script for SelectTopNRows command from SSMS  ******/
use [CIGinsurance]
go

alter table [dbo].[Firepackages] add CreatedByID int null, ModifiedByID int null,  Creationdate smalldatetime null,  Modificationdate smalldatetime null
go
alter table [dbo].[Hospitalsplans] add CreatedByID int null, ModifiedByID int null,  Creationdate smalldatetime null,  Modificationdate smalldatetime null
go
alter table [dbo].[Hospitalsplans] add TreatyID int null, TreatyOutID int null
go
update [dbo].[Hospitalsplans] set 
    TreatyID = (select id from [dbo].[Treaties] t1 where [dbo].[Hospitalsplans]._treaty = t1.Code)
  , TreatyOutID = (select id from [dbo].[Treaties] t1 where [dbo].[Hospitalsplans]._treatyout = t1.Code)
go

alter table [dbo].[Travelrates] add CreatedByID int null, ModifiedByID int null,  Creationdate smalldatetime null,  Modificationdate smalldatetime null
go
alter table [dbo].[Tariffs] add BranchID int, CreatedByID int null, ModifiedByID int null, Modificationdate smalldatetime null
go
ALTER TABLE [dbo].[Tariffs] ADD TotlaPremium AS ([Premium]+[Fees]+[Policycost]+[Proportionalstamps]+[Fixedstamps]+[Municipaltax])
go 
update [dbo].[Tariffs] set 
    BranchID = (select id from [dbo].[Branches] t1 where _Branch = t1.Code)
  , CreatedByID = (select id from [dbs].[Users] t1 where _Createdby = t1.Code)
go
alter table [dbo].[Tarifhospitals] add Description nvarchar(30) null, CreatedByID int null, ModifiedByID int null,  Creationdate smalldatetime null,  Modificationdate smalldatetime null
go
alter table [dbo].[Tarifhospitalsdetails] add TarifID int null
go
update [dbo].[Tarifhospitalsdetails] set
	tarifid = (select id from [dbo].[Tarifhospitals] t1 where [dbo].[Tarifhospitalsdetails].[_Code] = t1.Code)
go 
alter table [dbo].[Tarifworkers] add Description nvarchar(30) null, CreatedByID int null, ModifiedByID int null,  Creationdate smalldatetime null,  Modificationdate smalldatetime null
go
alter table [dbo].[Tarifworkersdetails] add TarifID int null
go
update [dbo].[Tarifworkersdetails] set
	tarifid = (select id from [dbo].[Tarifworkers] t1 where [dbo].[Tarifworkersdetails].[_Code] = t1.Code)
go 

alter table [dbo].[Firepackages] add CreatedByID int null, ModifiedByID int null,  Creationdate smalldatetime null,  Modificationdate smalldatetime null
go
alter table [dbo].[Firepackagesdetails] add PackageID int null
go
update [dbo].[Firepackagesdetails] set
	PackageID = (select id from [dbo].[Firepackages] t1 where [dbo].[Firepackagesdetails].[_package] = t1.Code)
go 