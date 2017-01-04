use [CIGinsurance]
go

alter table [dbo].[Brokerdetails] add BrokerID int, BranchID int
go

update [dbo].[Brokerdetails] set 
    BranchID = (select id from [dbo].[Branches] t1 where _Branch = t1.Code)
  , BrokerID = (select id from [dbo].[Brokers] t1 where _Broker = t1.Code)
go 

alter table [dbo].[Brokers] add CreatedByID int null, ModifiedByID int null
go 

update [dbo].[Brokers] set
	CreatedByID = (select id from [dbs].[Users] t1 where _Createdby = t1.Code)
  , ModifiedByID = (select id from [dbs].[Users] t1 where _Modifiedby = t1.Code)
go 

