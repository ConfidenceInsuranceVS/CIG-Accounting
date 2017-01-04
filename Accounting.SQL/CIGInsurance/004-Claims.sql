set QUOTED_IDENTIFIER ON

use [CIGinsurance]
go 

--exec sp_msforeachtable @command1="print '? Constraints disabled'", @command2="alter table ? nocheck constraint all"
--exec sp_msforeachtable @command1="print '? Triggers disabled'", @command2="alter table ? disable trigger all"
ALTER TABLE [dbo].[Claims] ADD Remain AS Tobepaid - paid PERSISTED
go 

alter table [dbo].[Claims]
	add BranchID int null
	  , PolicyID int null
	  , EndorsementID int null
	  , ClaimnatureID int null
go 

alter table [dbo].[Claims]
	add TpPolicy nvarchar(15) null
	  , TpInformation nvarchar(100) null
go 

alter table [dbo].[Claims] add Creationdate smalldatetime null, CreatedByID int null, ModifiedByID int null
go 

update [dbo].[Claims] set
   ModifiedByID = (select id from [dbs].[Users] t1 where [dbo].[Claims]._Modifiedby = t1.Code)
go 

declare cBranch cursor for select id, Code from Branches order by Code
declare @id int
declare @code varchar(1)

open cBranch
fetch next from cBranch into @id, @Code
WHILE @@FETCH_STATUS = 0  
BEGIN  
	print @code
	update [dbo].[Claims] set 
		  BranchID = (select ID from [dbo].[Branches] t1 where t1.Code  = [dbo].[Claims]._Branch)
	    , [PolicyID] = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].[Claims]._Policy and t1._Branch = @code)
	    , [EndorsementID] = (select ID from [dbo].Endorsements t1 where t1.Endorsement = [dbo].[Claims]._Endorsement and t1._Branch = @code)
	    , [ClaimnatureID] = (select ID from [dbo].Claimnatures t1 where t1.Code = [dbo].[Claims]._Claimnature and t1._Branch = @code)
	where _Branch = @code

	fetch next from cBranch into @id, @Code
END
CLOSE cBranch
DEALLOCATE cBranch

--exec sp_msforeachtable @command1="print '? Triggers enabled'", @command2="alter table ? enable trigger all"
--exec sp_msforeachtable @command1="print '? enabled'", @command2="alter table ? check constraint all"