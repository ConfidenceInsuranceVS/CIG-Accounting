use [CIGinsurance]
go

alter table [dbo].[Countries] add CreatedByID int null, ModifiedByID int null
alter table [dbo].[Countries] add Creationdate smalldatetime null, Modificationdate smalldatetime null
go 