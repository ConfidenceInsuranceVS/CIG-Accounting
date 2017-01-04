set QUOTED_IDENTIFIER OFF

use [CIGinsurance]
go 

--exec sp_msforeachtable @command1="print '? Constraints disabled'", @command2="alter table ? nocheck constraint all"
--exec sp_msforeachtable @command1="print '? Triggers disabled'", @command2="alter table ? disable trigger all"

alter table [dbo].[Policies] 
	add BranchID int null
	  , BrokerID int null
	  , TarifID int null
	  , OldPolicyID int null
	  , NewPolicyID int null
	  , BasePolicyID int null
	  , CurrencyID int null
go 

alter table [dbo].[Policies] add Creationdate smalldatetime null, CreatedByID int null, ModifiedByID int null
go 

update [dbo].[Policies] set
   ModifiedByID = (select id from [dbs].[Users] t1 where [dbo].[Policies]._Modifiedby = t1.Code)
go 

declare cBranch cursor for select id, Code from Branches order by Code
declare @id int
declare @code varchar(1)

open cBranch
fetch next from cBranch into @id, @Code
WHILE @@FETCH_STATUS = 0  
BEGIN  
	print @code
	update [dbo].[Policies] set 
		BranchID = (select ID from [dbo].[Branches] t1 where t1.Code  = [dbo].[Policies]._Branch)
	  , BrokerID = (select ID from [dbo].[Brokers] t1 where t1.Code = [dbo].[Policies]._Broker)
	  , [OldPolicyID] = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].[Policies]._Oldpolicy and t1._Branch = @code)
	  , [NewPolicyID] = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].[Policies]._Newpolicy and t1._Branch = @code)
	  , [BasePolicyID] = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].[Policies]._Basepolicy and t1._Branch = @code)
	  , [CurrencyID] = (select ID from [dbo].[Currencies] t1 where t1.Code  = [dbo].[Policies]._Valuecurrency)
	where _Branch = @code

	fetch next from cBranch into @id, @Code
END
CLOSE cBranch
DEALLOCATE cBranch

------------ Allrisk Updates -----------------------------------------------------------------------
alter table [dbo].[Policyallrisk] add PolicyID int null
go

update [dbo].[Policyallrisk] set PolicyID = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].[Policyallrisk]._policy and t1._Branch = 'C')
go 

------------ Boats Updates -----------------------------------------------------------------------
alter table [dbo].Policyboat add PolicyID int null
go

update [dbo].Policyboat set PolicyID = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].Policyboat._policy and t1._Branch = 'K')
go 

------------ Burglary Updates -----------------------------------------------------------------------
alter table [dbo].Policyburglary add PolicyID int null
go

update [dbo].Policyburglary set PolicyID = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].Policyburglary._policy and t1._Branch = 'V')
go 

------------ Cars Updates -----------------------------------------------------------------------
alter table [dbo].[Policycars] add
	    BodyTypeID int null
	  , CoverTypeID int null
	  , UsageTypeID int null
	  , LuxuryPolicyID int null
	  , CompulsoryPolicyID int null
	  , TplsuminsuredID int null
	  , CplsuminsuredID int null
go

update [dbo].[Policycars] set 
        BodyTypeID  = (select ID from [dbo].[Bodytypes] t1 where t1.Code = [dbo].[Policycars]._Bodytype)
	  , CoverTypeID = (select ID from [dbo].[Covertypes] t1 where t1.Code = [dbo].[Policycars]._Covertype)
	  , UsageTypeID = (select ID from [dbo].[Usagetypes] t1 where t1.Code = [dbo].[Policycars]._Usagetype)
      , PolicyID = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].[Policycars]._policy and t1._Branch = 'A')
      , LuxuryPolicyID = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].[Policycars]._Luxurypolicy and t1._Branch = 'Q')
      , CompulsoryPolicyID = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].[Policycars]._Compulsorypolicy and t1._Branch = 'B')
      , TplsuminsuredID  = (select ID from [dbo].[Tpltypes] t1 where t1.Code = [dbo].[Policycars].Suminsured)
	  , CplsuminsuredID = (select ID from [dbo].[Cpltypes] t1 where t1.Code = [dbo].[Policycars]._Corporalsuminsured)
go 

------------ Compulsory Updates -----------------------------------------------------------------------
alter table [dbo].Policycompulsory add
	    BodyTypeID int null
	  , CoverTypeID int null
	  , UsageTypeID int null
	  , CarsPolicyID int null
	  , TplsuminsuredID int null
	  , PolicyID int null
go

update [dbo].Policycompulsory set 
        BodyTypeID  = (select ID from [dbo].[Bodytypes] t1 where t1.Code = [dbo].Policycompulsory._Bodytype)
	  , CoverTypeID = (select ID from [dbo].[Covertypes] t1 where t1.Code = [dbo].Policycompulsory._Covertype)
	  , UsageTypeID = (select ID from [dbo].[Usagetypes] t1 where t1.Code = [dbo].Policycompulsory._Usagetype)
      , PolicyID = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].Policycompulsory._policy and t1._Branch = 'B')
      , CarsPolicyID = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].Policycompulsory._carspolicy and t1._Branch = 'A')
      , TplsuminsuredID  = (select ID from [dbo].[Tpltypes] t1 where t1.Code = [dbo].Policycompulsory._suminsured)
go 

------------ Fire Updates -----------------------------------------------------------------------
alter table [dbo].Policyfire add PolicyID int null
go

update [dbo].Policyfire set PolicyID = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].Policyfire._policy and t1._Branch = 'I')
go 

------------ Gtpl Updates -----------------------------------------------------------------------
alter table [dbo].Policygtpl add PolicyID int null
go

update [dbo].Policygtpl set PolicyID = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].Policygtpl._policy and t1._Branch = 'R')
go 

------------ Hospitalization Updates -----------------------------------------------------------------------
alter table [dbo].Policyhospitalization add PolicyID int null
go

update [dbo].Policyhospitalization set PolicyID = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].Policyhospitalization._policy and t1._Branch = 'R')
go 

------------ Life Updates -----------------------------------------------------------------------
alter table [dbo].Policylife add PolicyID int null
go

update [dbo].Policylife set PolicyID = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].Policylife._policy and t1._Branch = 'L')
go 

------------ Luxury Updates -----------------------------------------------------------------------
alter table [dbo].Policyluxury add
	    BodyTypeID int null
	  , CoverTypeID int null
	  , UsageTypeID int null
	  , CarsPolicyID int null
	  , CompulsoryPolicyID int null
	  , TplsuminsuredID int null
	  , PolicyID int null
go

update [dbo].Policyluxury set 
        BodyTypeID  = (select ID from [dbo].[Bodytypes] t1 where t1.Code = [dbo].Policyluxury._Bodytype)
	  , CoverTypeID = (select ID from [dbo].[Covertypes] t1 where t1.Code = [dbo].Policyluxury._Covertype)
	  , UsageTypeID = (select ID from [dbo].[Usagetypes] t1 where t1.Code = [dbo].Policyluxury._Usagetype)
      , PolicyID = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].Policyluxury._policy and t1._Branch = 'Q')
      , CarsPolicyID = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].Policyluxury._carspolicy and t1._Branch = 'A')
      , CompulsoryPolicyID = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].Policyluxury._Compulsorypolicy and t1._Branch = 'B')
      , TplsuminsuredID  = (select ID from [dbo].[Tpltypes] t1 where t1.Code = [dbo].Policyluxury._suminsured)
go 

------------ Orange Card Updates -----------------------------------------------------------------------
alter table [dbo].Policyorangecard add
	    BodyTypeID int null
	  , CoverTypeID int null
	  , UsageTypeID int null
	  , TplsuminsuredID int null
	  , PolicyID int null
go

update [dbo].Policyorangecard set 
        BodyTypeID  = (select ID from [dbo].[Bodytypes] t1 where t1.Code = [dbo].Policyorangecard._Bodytype)
	  , CoverTypeID = (select ID from [dbo].[Covertypes] t1 where t1.Code = [dbo].Policyorangecard._Covertype)
	  , UsageTypeID = (select ID from [dbo].[Usagetypes] t1 where t1.Code = [dbo].Policyorangecard._Usagetype)
      , PolicyID = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].Policyorangecard._policy and t1._Branch = 'M')
      , TplsuminsuredID  = (select ID from [dbo].[Tpltypes] t1 where t1.Code = [dbo].Policyorangecard._suminsured)
go 

------------ Out Updates -----------------------------------------------------------------------
alter table [dbo].Policyout add PolicyID int null
go

update [dbo].Policyout set PolicyID = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].Policyout._policy and t1._Branch = 'O')
go 

------------ Political Updates -----------------------------------------------------------------------
alter table [dbo].Policypolitical add PolicyID int null
go

update [dbo].Policypolitical set PolicyID = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].Policypolitical._policy and t1._Branch = 'D')
go 

------------ Transport Updates -----------------------------------------------------------------------
alter table [dbo].Policytransport add PolicyID int null
go

update [dbo].Policytransport set PolicyID = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].Policytransport._policy and t1._Branch = 'T')
go 

------------ Travel Updates -----------------------------------------------------------------------
alter table [dbo].Policytravel add PolicyID int null
go

update [dbo].Policytravel set PolicyID = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].Policytravel._policy and t1._Branch = 'J')
go 

------------ Workers Updates -----------------------------------------------------------------------
alter table [dbo].Policyworkers add PolicyID int null
go

update [dbo].Policyworkers set PolicyID = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].Policyworkers._policy and t1._Branch = 'S')
go 

------------ Workmens Updates -----------------------------------------------------------------------
alter table [dbo].Policyworkmens add PolicyID int null
go

update [dbo].Policyworkmens set PolicyID = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].Policyworkmens._policy and t1._Branch = 'W')
go 

--exec sp_msforeachtable @command1="print '? Triggers enabled'", @command2="alter table ? enable trigger all"
--exec sp_msforeachtable @command1="print '? enabled'", @command2="alter table ? check constraint all"