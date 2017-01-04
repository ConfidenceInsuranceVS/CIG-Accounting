use [CIGinsurance]
go

alter table [dbo].[Treaties] add BranchID int, CreatedByID int null, ModifiedByID int null,  Modificationdate smalldatetime null
go
update [dbo].[Treaties] set 
    BranchID = (select id from [dbo].[Branches] t1 where _Branch = t1.Code)
  , CreatedByID = (select id from [dbs].[Users] t1 where _Createdby = t1.Code)

go 

alter table [dbo].[Treatydetails] add TreatyID int, ReinsurerID int
go
update [dbo].[Treatydetails] set 
    TreatyID = (select id from [dbo].[Treaties] t1 where [dbo].[Treatydetails].[_Code] = t1.Code)
  , ReinsurerID = (select id from [dbo].[Reinsurers] t1 where [dbo].[Treatydetails]._Reinsurer = t1.Code)
go 
