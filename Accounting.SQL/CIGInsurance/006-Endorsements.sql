set QUOTED_IDENTIFIER OFF

use [CIGinsurance]
go 

exec sp_msforeachtable @command1="print '? Constraints disabled'", @command2="alter table ? nocheck constraint all"
exec sp_msforeachtable @command1="print '? Triggers disabled'", @command2="alter table ? disable trigger all"

alter table [dbo].[Endorsements]
	add BranchID int null
	  , BrokerID int null
	  , PolicyID int null
	  , TarifID int null
	  , CurrencyID int null
go 

alter table [dbo].[Endorsements] add Creationdate smalldatetime null
go

alter table [dbo].[Endorsements] add CreatedByID int null, ModifiedByID int null
go 

update [dbo].[Endorsements] set
   ModifiedByID = (select id from [dbs].[Users] t1 where [dbo].[Endorsements]._Modifiedby = t1.Code)
go 

declare cBranch cursor for select id, Code from Branches order by Code
declare @id int
declare @code varchar(1)

open cBranch
fetch next from cBranch into @id, @Code
WHILE @@FETCH_STATUS = 0  
BEGIN  
	print @code
	update [dbo].[Endorsements] set 
		BranchID = (select ID from [dbo].[Branches] t1 where t1.Code  = [dbo].[Endorsements]._Branch)
	  , BrokerID = (select ID from [dbo].[Brokers] t1 where t1.Code = [dbo].[Endorsements]._Broker)
	  , [PolicyID] = (select ID from [dbo].[Policies] t1 where t1.Policy = [dbo].[Endorsements]._policy and t1._Branch = @code)
	  , [CurrencyID] = (select ID from [dbo].[Currencies] t1 where t1.Code  = [dbo].[Endorsements]._Valuecurrency)
	where _Branch = @code

	fetch next from cBranch into @id, @Code
END
CLOSE cBranch
DEALLOCATE cBranch

-------------- Endorsements Cars Updates -----------------------------------------------------------------------
---------------------------------------------------------------------------------------------------
alter table [dbo].[Endscars] add
	    BodyTypeID int null
	  , CoverTypeID int null
	  , UsageTypeID int null
	  , EndorsementID int null
	  , TplsuminsuredID int null
go

update [dbo].[Endscars] set 
        BodyTypeID  = (select ID from [dbo].[Bodytypes] t1 where t1.Code = [dbo].[Endscars]._Bodytype)
	  , CoverTypeID = (select ID from [dbo].[Covertypes] t1 where t1.Code = [dbo].[Endscars]._Covertype)
	  , UsageTypeID = (select ID from [dbo].[Usagetypes] t1 where t1.Code = [dbo].[Endscars]._Usagetype)
      , TplsuminsuredID  = (select ID from [dbo].[Tpltypes] t1 where t1.Code = [dbo].[Endscars]._Suminsured)
      , EndorsementID = (select ID from [dbo].[Endorsements] t1 where t1.Endorsement = [dbo].[Endscars]._endorsement and t1._branch = 'A')
go 

------------ Compulsory Updates -----------------------------------------------------------------------
alter table [dbo].[Endscompulsory] add
	    BodyTypeID int null
	  , CoverTypeID int null
	  , UsageTypeID int null
	  , TplsuminsuredID int null
	  , EndorsementID int null
go

update [dbo].[Endscompulsory] set 
        BodyTypeID  = (select ID from [dbo].[Bodytypes] t1 where t1.Code = [dbo].[Endscompulsory]._Bodytype)
	  , CoverTypeID = (select ID from [dbo].[Covertypes] t1 where t1.Code = [dbo].[Endscompulsory]._Covertype)
	  , UsageTypeID = (select ID from [dbo].[Usagetypes] t1 where t1.Code = [dbo].[Endscompulsory]._Usagetype)
      , EndorsementID = (select ID from [dbo].[Endorsements] t1 where t1.Endorsement = [dbo].[Endscompulsory]._code and t1._Branch = 'B')
      , TplsuminsuredID  = (select ID from [dbo].[Tpltypes] t1 where t1.Code = [dbo].[Endscompulsory]._suminsured)
go 

------------ Luxury Updates -----------------------------------------------------------------------
alter table [dbo].[Endsluxury] add
	    BodyTypeID int null
	  , CoverTypeID int null
	  , UsageTypeID int null
	  , TplsuminsuredID int null
	  , EndorsementID int null
go

update [dbo].[Endsluxury] set 
        BodyTypeID  = (select ID from [dbo].[Bodytypes] t1 where t1.Code = [dbo].[Endsluxury]._Bodytype)
	  , CoverTypeID = (select ID from [dbo].[Covertypes] t1 where t1.Code = [dbo].[Endsluxury]._Covertype)
	  , UsageTypeID = (select ID from [dbo].[Usagetypes] t1 where t1.Code = [dbo].[Endsluxury]._Usagetype)
      , EndorsementID = (select ID from [dbo].[Endorsements] t1 where t1.Endorsement = [dbo].[Endsluxury]._code and t1._Branch = 'B')
      , TplsuminsuredID  = (select ID from [dbo].[Tpltypes] t1 where t1.Code = [dbo].[Endsluxury]._suminsured)
go 

------------ Orange Card Updates -----------------------------------------------------------------------
alter table [dbo].[Endsorangecard] add
	    BodyTypeID int null
	  , CoverTypeID int null
	  , UsageTypeID int null
	  , TplsuminsuredID int null
	  , EndorsementID int null
go

update [dbo].[Endsorangecard] set 
        BodyTypeID  = (select ID from [dbo].[Bodytypes] t1 where t1.Code = [dbo].[Endsorangecard]._Bodytype)
	  , CoverTypeID = (select ID from [dbo].[Covertypes] t1 where t1.Code = [dbo].[Endsorangecard]._Covertype)
	  , UsageTypeID = (select ID from [dbo].[Usagetypes] t1 where t1.Code = [dbo].[Endsorangecard]._Usagetype)
      , EndorsementID = (select ID from [dbo].[Endorsements] t1 where t1.Endorsement = [dbo].[Endsorangecard]._code and t1._Branch = 'M')
      , TplsuminsuredID  = (select ID from [dbo].[Tpltypes] t1 where t1.Code = [dbo].[Endsorangecard].suminsured)
go 

------------ Allrisk Updates -----------------------------------------------------------------------
alter table [dbo].[Endsallrisk] add EndorsementID int null
go

update [dbo].[Endsallrisk] set EndorsementID = (select ID from [dbo].[Endorsements] t1 where t1.Endorsement = [dbo].[Endsallrisk]._code and t1._Branch = 'C')
go 

------------ Boats Updates -----------------------------------------------------------------------
alter table [dbo].[Endsboat] add EndorsementID int null
go

update [dbo].[Endsboat] set EndorsementID = (select ID from [dbo].Endorsements t1 where t1.Endorsement = [dbo].[Endsboat]._code and t1._Branch = 'K')
go 

------------ Burglary Updates -----------------------------------------------------------------------
alter table [dbo].[Endsburglary] add EndorsementID int null
go

update [dbo].[Endsburglary] set EndorsementID = (select ID from [dbo].[Endorsements] t1 where t1.Endorsement = [dbo].[Endsburglary]._code and t1._Branch = 'V')
go 

------------ Fire Updates -----------------------------------------------------------------------
alter table [dbo].[Endsfire] add EndorsementID int null
go

update [dbo].[Endsfire] set EndorsementID = (select ID from [dbo].[Endorsements] t1 where t1.Endorsement = [dbo].[Endsfire]._code and t1._Branch = 'I')
go 

alter table [dbo].[Endsfire] add ZoneID int null
go
update [dbo].[Endsfire] set
	ZoneID = (select id from [dbo].[Zones] t1 where [dbo].[Endsfire]._zone = t1.Code)
go 

alter table [dbo].[Endsfire] add FiretypeID int null
go
update [dbo].[Endsfire] set
	FiretypeID = (select id from [dbo].Firetypes t1 where [dbo].[Endsfire]._Firetype = t1.Code)
go 

alter table [dbo].[Endsfire] add PackageID int null, PackagedetailsID int null
go
update [dbo].[Endsfire] set
	PackageID = (select id from [dbo].Firepackages t1 where [dbo].[Endsfire]._Package = t1.Code)
  , PackagedetailsID = (select id from [dbo].[Firepackagesdetails] t1 
		where [dbo].[Endsfire]._Fireplan = t1.Fireplan and [dbo].[Endsfire]._Package = t1._package) 
go 

------------ Gtpl Updates -----------------------------------------------------------------------
alter table [dbo].[Endsgtpl]  add EndorsementID int null
go

update [dbo].[Endsgtpl] set EndorsementID = (select ID from [dbo].[Endorsements] t1 where t1.Endorsement = [dbo].[Endsgtpl]._code and t1._Branch = 'R')
go 

------------ Hospitalization Updates -----------------------------------------------------------------------
alter table [dbo].[Endshospitalization] add EndorsementID int null
go

update [dbo].[Endshospitalization] set EndorsementID = (select ID from [dbo].[Endorsements] t1 where t1.Endorsement = [dbo].[Endshospitalization]._code and t1._Branch = 'H')
go 

-- Added
alter table [dbo].[Endshospitalization] add TarifhospitalsID int null
go

update [dbo].[Endshospitalization] set
	TarifhospitalsID = (select ID from [dbo].[Tarifhospitals] t1 where [dbo].[Endshospitalization]._Tarifhospital = t1.Code)
go

-- Added
alter table [dbo].[Endshospitalization] add HospitalsplansID int null
go

update [dbo].[Endshospitalization] set
	HospitalsplansID = (select ID from [dbo].[Hospitalsplans] t1 where [dbo].[Endshospitalization]._Planhospital = t1.Code)
go 

------------ Life Updates -----------------------------------------------------------------------
alter table [dbo].[Endslife] add EndorsementID int null
go

update [dbo].[Endslife] set EndorsementID = (select ID from [dbo].[Endorsements] t1 where t1.Endorsement = [dbo].[Endslife]._code and t1._Branch = 'L')
go 

------------ Out Updates -----------------------------------------------------------------------
alter table [dbo].[Endsout] add EndorsementID int null
go

update [dbo].[Endsout] set EndorsementID = (select ID from [dbo].[Endorsements] t1 where t1.Endorsement = [dbo].[Endsout]._code and t1._Branch = 'O')
go 

-- Added
alter table [dbo].[Endsout] add HospitalsplansID int null
go

update [dbo].[Endsout] set
	HospitalsplansID = (select ID from [dbo].[Hospitalsplans] t1 where [dbo].[Endsout]._Planhospital = t1.Code)
go 
------------ Political Updates -----------------------------------------------------------------------
alter table [dbo].[Endspolitical] add EndorsementID int null
go

update [dbo].[Endspolitical] set EndorsementID = (select ID from [dbo].[Endorsements] t1 where t1.Endorsement = [dbo].[Endspolitical]._code and t1._Branch = 'D')
go 

------------ Transport Updates -----------------------------------------------------------------------
alter table[dbo].[Endstransport]  add EndorsementID int null
go

update [dbo].[Endstransport] set EndorsementID = (select ID from [dbo].[Endorsements] t1 where t1.Endorsement = [dbo].[Endstransport]._code and t1._Branch = 'T')
go 

------------ Travel Updates -----------------------------------------------------------------------
alter table [dbo].[Endstravel] add EndorsementID int null
go

update [dbo].[Endstravel] set EndorsementID = (select ID from [dbo].[Endorsements] t1 where t1.Endorsement = [dbo].[Endstravel]._code and t1._Branch = 'J')
go 

------------ Workers Updates -----------------------------------------------------------------------
alter table [dbo].[Endsworkers] add EndorsementID int null
go

update [dbo].[Endsworkers] set EndorsementID = (select ID from [dbo].[Endorsements] t1 where t1.Endorsement = [dbo].[Endsworkers]._code and t1._Branch = 'S')
go 

------------ Workmens Updates -----------------------------------------------------------------------
alter table [dbo].[Endsworkmens] add EndorsementID int null
go

update [dbo].[Endsworkmens] set EndorsementID = (select ID from [dbo].[Endorsements] t1 where t1.Endorsement = [dbo].[Endsworkmens]._code and t1._Branch = 'W')
go 


exec sp_msforeachtable @command1="print '? Triggers enabled'", @command2="alter table ? enable trigger all"
exec sp_msforeachtable @command1="print '? enabled'", @command2="alter table ? check constraint all"