/****** Script for SelectTopNRows command from SSMS  ******/
use [CIGinsurance]
go

alter table [dbo].[Clauses] add BranchID int, CreatedByID int null, ModifiedByID int null
go
update [dbo].[Clauses] set 
    BranchID = (select id from [dbo].[Branches] t1 where _Branch = t1.Code)
  , CreatedByID = (select id from [dbs].[Users] t1 where _Createdby = t1.Code)
  , ModifiedByID = (select id from [dbs].[Users] t1 where _Modifiedby = t1.Code)
go 
 