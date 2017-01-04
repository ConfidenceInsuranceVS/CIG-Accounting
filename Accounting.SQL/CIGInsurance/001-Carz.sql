use [CIGinsurance]
go

alter table [dbo].[Bodytypes] add CreatedByID int null, ModifiedByID int null,  Creationdate smalldatetime null,  Modificationdate smalldatetime null
go
alter table [dbo].[Covertypes] add CreatedByID int null, ModifiedByID int null,  Creationdate smalldatetime null,  Modificationdate smalldatetime null
go
alter table [dbo].[Usagetypes] add CreatedByID int null, ModifiedByID int null,  Creationdate smalldatetime null,  Modificationdate smalldatetime null
go
alter table [dbo].[Tpltypes] add CreatedByID int null, ModifiedByID int null,  Creationdate smalldatetime null,  Modificationdate smalldatetime null
go
alter table [dbo].[Cpltypes] add CreatedByID int null, ModifiedByID int null,  Creationdate smalldatetime null,  Modificationdate smalldatetime null
go

alter table [dbo].[CarsCategories] add CreatedByID int null, ModifiedByID int null,  Creationdate smalldatetime null,  Modificationdate smalldatetime null
go

alter table [dbo].[Carstariffs] add CovertypeID int null, BodytypeID int null, UsagetypeID int null, TpltypeID int null
go
update [dbo].[Carstariffs] set
	CovertypeID = (select id from [dbo].[Covertypes] t1 where [dbo].[Carstariffs].[_Covertype] = t1.Code)
go 
update [dbo].[Carstariffs] set
	BodytypeID = (select id from [dbo].[Bodytypes] t1 where [dbo].[Carstariffs].[_Bodytype] = t1.Code)
go 
update [dbo].[Carstariffs] set
	UsagetypeID = (select id from [dbo].[Usagetypes] t1 where [dbo].[Carstariffs]._Usagetype = t1.Code)
go 
update [dbo].[Carstariffs] set
	TpltypeID = (select id from [dbo].[Tpltypes] t1 where [dbo].[Carstariffs].[_Suminsured] = t1.Code)
go 
alter table [dbo].[Carstariffs] add CategoryID int null
go
update [dbo].[Carstariffs] set
	CategoryID = (select id from [dbo].[CarsCategories] t1 where [dbo].[Carstariffs].[_Category] = t1.[Code])
go 
