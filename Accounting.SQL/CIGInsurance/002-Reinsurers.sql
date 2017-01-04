use [CIGinsurance]
go

alter table [dbo].[Reinsurers] alter column [type] bit null
go
alter table [dbo].[Reinsurers] add CreatedByID int null, ModifiedByID int null
go
update [dbo].[Clauses] set 
    CreatedByID = (select id from [dbs].[Users] t1 where _Createdby = t1.Code)
  , ModifiedByID = (select id from [dbs].[Users] t1 where _Modifiedby = t1.Code)
go 

