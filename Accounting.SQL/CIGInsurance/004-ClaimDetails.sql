set QUOTED_IDENTIFIER ON

use [CIGinsurance]
go 

CREATE TABLE [dbo].[Paymenttypes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](15) NULL,
 CONSTRAINT [PK_Paymenttypes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--exec sp_msforeachtable @command1="print '? Constraints disabled'", @command2="alter table ? nocheck constraint all"
--exec sp_msforeachtable @command1="print '? Triggers disabled'", @command2="alter table ? disable trigger all"

UPDATE [dbo].[Claimdetails] set _Claimtype = 'HOSPITAL' where _CLAIMTYPE = 'H'
UPDATE [dbo].[Claimdetails] set _Claimtype = 'DOCTOR' where _CLAIMTYPE = 'D'
go

alter table [dbo].[Claimdetails]
	add BranchID int null
	  , ClaimID int null
	  , CurrencyID int null
	  , ClaimtypeID int null
	  , ClaimdetailtypeID int null
go 

declare cBranch cursor for select id, Code from Branches order by Code
declare @id int
declare @code varchar(1)

open cBranch
fetch next from cBranch into @id, @Code
WHILE @@FETCH_STATUS = 0  
BEGIN  
	print @code
	update [dbo].[Claimdetails] set 
		[BranchID] = (select ID from [dbo].[Branches] t1 where t1.Code  = [dbo].[Claimdetails]._Branch)
	  , [ClaimID] = (select ID from [dbo].[Claims] t1 where t1.Claim = [dbo].[Claimdetails]._Claim and t1._Branch = @code)
	  , [CurrencyID] = (select ID from [dbo].[Currencies] t1 where t1.Code = [dbo].[Claimdetails]._Outstandingcurrency)
	  , [ClaimtypeID] = (select ID from [dbo].[Claimtypes] t1 where t1.Code = [dbo].[Claimdetails]._Claimtype)
	where _Branch = @code

	fetch next from cBranch into @id, @Code
END
CLOSE cBranch
DEALLOCATE cBranch

update [dbo].[Claimdetails] set 
	   [ClaimdetailtypeID] = (select ID from [dbo].[Claimdetailtypes] t1 where t1.Code = [dbo].[Claimdetails]._Code and t1._Claimtype = [dbo].[Claimdetails]._claimtype)
go 

alter table [dbo].[Claimdetails] add PaymenttypeID int null
go 

update [dbo].[Claimdetails] set 
	   [PaymenttypeID] = (select ID from [dbo].Paymenttypes t1 where t1.Description = upper([dbo].[Claimdetails].Paymenttype))
go 

