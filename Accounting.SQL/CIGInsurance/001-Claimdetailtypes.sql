use [CIGinsurance]
go

alter table [dbo].[Claimdetailtypes]
	add ClaimtypeID int, CreatedByID int null, ModifiedByID int null
	  , Modificationdate smalldatetime null
go
update [dbo].[Claimdetailtypes] set 
    ClaimtypeID = (select id from [dbo].[Claimtypes] t1 where t1.Code = dbo.Claimdetailtypes._Claimtype)
  , CreatedByID = (select id from [dbs].[Users] t1 where _Createdby = t1.Code)
go
