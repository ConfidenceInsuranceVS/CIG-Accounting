/****** Script for SelectTopNRows command from SSMS  ******/
use [CIGinsurance]
go


alter table [dbo].[Policyhospidetails] add PolicyID int null
go
update [dbo].[Policyhospidetails] set
	PolicyID = (select id from [dbo].[Policies] t1 where [dbo].[Policyhospidetails]._policy = t1.policy and t1.BranchID = 3)
go 

-- Added
alter table [dbo].[Policyhospitalization] add PolicyID int null
go
update [dbo].[Policyhospitalization] set
	PolicyID = (select id from [dbo].[Policies] t1 where [dbo].[Policyhospitalization]._policy = t1.policy and t1.BranchID = 3)
go 

-- Added
alter table [dbo].[Policyhospitalization] add TarifhospitalsID int null
go
update [dbo].[Policyhospitalization] set
	TarifhospitalsID = (select ID from [dbo].[Tarifhospitals] t1 where [dbo].[Policyhospitalization]._Tarifhospital = t1.Code)
go

-- Added
alter table [dbo].[Policyhospitalization] add HospitalsplansID int null
go
update [dbo].[Policyhospitalization] set
	HospitalsplansID = (select ID from [dbo].[Hospitalsplans] t1 where [dbo].[Policyhospitalization]._Planhospital = t1.Code)
go 

alter table [dbo].[Policylifedetails] add PolicyID int null
go
update [dbo].[Policylifedetails] set
	PolicyID = (select id from [dbo].[Policies] t1 where [dbo].[Policylifedetails]._policy = t1.policy and t1.BranchID = 5)
go

alter table [dbo].[Policyworkersdetails] add PolicyID int null, CreatedbyID int null, ModifiedbyID int null
go
update [dbo].[Policyworkersdetails] set
	  PolicyID = (select id from [dbo].[Policies] t1 where [dbo].[Policyworkersdetails]._policy = t1.policy and t1.BranchID = 7)
	, CreatedbyID = (select id from [dbs].[Users] t1 where [dbo].[Policyworkersdetails].createdby = t1.Code)
	, ModifiedByID = (select id from [dbs].[Users] t1 where [dbo].[Policyworkersdetails].modifiedby = t1.Code)
go 

-- Added
alter table [dbo].[Policyout] add HospitalsplansID int null
go
update [dbo].[Policyout] set
	HospitalsplansID = (select ID from [dbo].[Hospitalsplans] t1 where [dbo].[Policyout]._Planhospital = t1.Code)
go 

alter table [dbo].[Policyoutdetails] add PolicyID int null
go
update [dbo].[Policyoutdetails] set
	PolicyID = (select id from [dbo].[Policies] t1 where [dbo].[Policyoutdetails]._policy = t1.policy and t1.BranchID = 13)
go 
 
alter table [dbo].[Policypadetails] add PolicyID int null
go
update [dbo].[Policypadetails] set
	PolicyID = (select id from [dbo].[Policies] t1 where [dbo].[Policypadetails]._policy = t1.policy and t1.BranchID = 6)
go 

alter table [dbo].[Policygtpldetails] add PolicyID int null
go
update [dbo].[Policygtpldetails] set
	PolicyID = (select id from [dbo].[Policies] t1 where [dbo].[Policygtpldetails]._policy = t1.policy and t1.BranchID = 8)
go 

-- Fire
alter table [dbo].[Policyfire] add ZoneID int null
go
update [dbo].[Policyfire] set
	ZoneID = (select id from [dbo].[Zones] t1 where [dbo].[Policyfire]._zone = t1.Code)
go 

alter table [dbo].[Policyfire] add FiretypeID int null
go
update [dbo].[Policyfire] set
	FiretypeID = (select id from [dbo].Firetypes t1 where [dbo].[Policyfire]._Firetype = t1.Code)
go 

alter table [dbo].[Policyfire] add PackageID int null, PackagedetailsID int null
go
update [dbo].[Policyfire] set
	PackageID = (select id from [dbo].Firepackages t1 where [dbo].[Policyfire]._Package = t1.Code)
  , PackagedetailsID = (select id from [dbo].[Firepackagesdetails] t1 
		where [dbo].[Policyfire]._Planfire = t1.Fireplan and [dbo].[Policyfire]._Package = t1._package) 
go 

