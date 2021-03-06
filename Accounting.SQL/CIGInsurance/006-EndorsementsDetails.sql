/****** Script for SelectTopNRows command from SSMS  ******/
use [CIGinsurance]
go


alter table [dbo].[Endorsementhospidetails] add EndorsementID int null
go
update [dbo].[Endorsementhospidetails] set
	EndorsementID = (select id from [dbo].[Endorsements] t1 where [dbo].[Endorsementhospidetails]._end = t1.endorsement and t1.BranchID = 3)
go 

alter table [dbo].[Endorsementlifedetails] add EndorsementID int null
go
update [dbo].[Endorsementlifedetails] set
	EndorsementID = (select id from [dbo].[Endorsements] t1 where [dbo].[Endorsementlifedetails]._End = t1.Endorsement and t1.BranchID = 5)
go

alter table [dbo].[Endorsementworkersdetails] add EndorsementID int null, CreatedbyID int null, ModifiedbyID int null
go
update [dbo].[Endorsementworkersdetails] set
	  EndorsementID = (select id from [dbo].[Endorsements] t1 where [dbo].[Endorsementworkersdetails]._End = t1.Endorsement and t1.BranchID = 7)
	, CreatedbyID = (select id from [dbs].[Users] t1 where [dbo].[Endorsementworkersdetails].createdby = t1.Code)
	, ModifiedByID = (select id from [dbs].[Users] t1 where [dbo].[Endorsementworkersdetails].modifiedby = t1.Code)
go 

alter table [dbo].[Endorsementoutdetails] add EndorsementID int null
go
update [dbo].[Endorsementoutdetails] set
	EndorsementID = (select id from [dbo].[Endorsements] t1 where [dbo].[Endorsementoutdetails]._End = t1.Endorsement and t1.BranchID = 13)
go 
 
alter table [dbo].[Endorsementpadetails] add EndorsementID int null
go
update [dbo].[Endorsementpadetails] set
	EndorsementID = (select id from [dbo].[Endorsements] t1 where [dbo].[Endorsementpadetails]._End = t1.Endorsement and t1.BranchID = 6)
go 

alter table [dbo].[Endorsementgtpldetails] add EndorsementID int null
go
update [dbo].[Endorsementgtpldetails] set
	EndorsementID = (select id from [dbo].[Endorsements] t1 where [dbo].[Endorsementgtpldetails]._End = t1.Endorsement and t1.BranchID = 8)
go 
