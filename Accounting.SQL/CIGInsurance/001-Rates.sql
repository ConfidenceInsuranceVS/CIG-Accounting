use [CIGinsurance]
go

alter table [dbo].[Rates] add CurrencyID int
go

update [dbo].[Rates] set [CurrencyID] = (select id from [dbo].[Currencies] where [dbo].[Currencies].code = [dbo].[Rates].code)
go 
ALTER TABLE [dbo].[Rates] ADD Ydate AS year(ratedate), Mdate AS month(ratedate), Ddate AS day(ratedate)
go
