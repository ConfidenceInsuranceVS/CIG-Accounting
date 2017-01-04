use [CIGinsurance]
go

alter table [dbo].[Branches] add ReinsurerID int null, CreatedByID int null, ModifiedByID int null
go 

update [dbo].[Branches] set
	ReinsurerID = (select id from [dbo].Reinsurers t1 where _Reincode = t1.Code)
  , CreatedByID = (select id from [dbs].[Users] t1 where _Createdby = t1.Code)
  , ModifiedByID = (select id from [dbs].[Users] t1 where _Modifiedby = t1.Code)
