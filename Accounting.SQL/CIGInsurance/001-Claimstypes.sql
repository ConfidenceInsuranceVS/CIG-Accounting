use [CIGinsurance]
go

alter table [dbo].[Claimtypes] add CreatedByID int null, ModifiedByID int null
alter table [dbo].[Claimtypes] add Creationdate smalldatetime null, Modificationdate smalldatetime null
go 
