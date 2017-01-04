use [CIGinsurance]
go

alter table [dbo].[Claimnatures] 
	add BranchID int, CreatedByID int null, ModifiedByID int null
      , Creationdate smalldatetime null, Modificationdate smalldatetime null
go
update [dbo].[Claimnatures] set 
    BranchID = (select id from [dbo].[Branches] t1 where _Branch = t1.Code)
  , Description = Code
go 
