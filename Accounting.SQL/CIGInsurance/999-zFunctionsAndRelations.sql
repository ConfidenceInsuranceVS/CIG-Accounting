USE [CIGInsurance]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[usp_CheckCode]
( 
	  @Table nvarchar(30)
	, @code NVARCHAR(20)
	, @codeCount INT OUTPUT 
) 
AS 

declare @cmd nvarchar(max) = "SELECT @codeCount = COUNT(*) FROM "+@table+" WHERE code = @code"

EXECUTE sp_executesql @cmd, N'@code nvarchar(20),@codeCount int OUTPUT', @code = @code, @codeCount=@codeCount OUTPUT

GO

/****** Object:  StoredProcedure [dbo].[usp_CheckColumn]    Script Date: 06/06/2015 8:40:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO


CREATE PROCEDURE [dbo].[usp_CheckColumn]
( 
	  @Table nvarchar(30)
	, @Column nvarchar(20)
	, @code NVARCHAR(20)
	, @codeCount INT OUTPUT 
) 
AS 

declare @cmd nvarchar(max) =
"SELECT @codeCount = COUNT(*) FROM "+@table+" WHERE "+@Column+" = @code"

EXECUTE sp_executesql @cmd, N'@code nvarchar(20),@codeCount int OUTPUT', @code = @code, @codeCount=@codeCount OUTPUT
GO


/****** Object:  StoredProcedure [dbo].[usp_CheckID]    Script Date: 06/06/2015 8:40:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

create PROCEDURE [dbo].[usp_CheckID]
( 
	  @Table nvarchar(30)
	, @ID int
	, @codeCount INT OUTPUT 
) 
AS 

declare @cmd nvarchar(max) =
"SELECT @codeCount = COUNT(*) FROM "+@table+" WHERE id = @ID"

EXECUTE sp_executesql @cmd, N'@ID int,@codeCount int OUTPUT', @ID = @ID, @codeCount=@codeCount OUTPUT
GO

/****** Object:  Table [dbo].[_ActivityLogger]    Script Date: 06/06/2015 8:40:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_ActivityLogger](
	[Guid] [nvarchar](36) NOT NULL,
	[UserID] [int] NOT NULL,
	[Machine] [nvarchar](50) NULL,
	[FormName] [nvarchar](50) NULL,
	[DateIn] [smalldatetime] NULL,
	[DateOut] [smalldatetime] NULL,
	[Remarks] [nvarchar](256) NULL,
 CONSTRAINT [PK__ActivityLogger] PRIMARY KEY CLUSTERED 
(
	[Guid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  UserDefinedFunction [dbo].[vBranches]    Script Date: 06/06/2015 8:40:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[vBranches]() RETURNS TABLE AS RETURN (SELECT ISNULL(ID, - 1) AS ID, Code, Description FROM dbo.Branches)


GO
/****** Object:  UserDefinedFunction [dbo].[vBrokers]    Script Date: 06/06/2015 8:40:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[vBrokers]() RETURNS TABLE AS RETURN (SELECT ISNULL(ID, - 1) AS ID, Code, Name FROM dbo.Brokers)


GO
/****** Object:  UserDefinedFunction [dbo].[vClaimdetailtypes]    Script Date: 06/06/2015 8:40:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[vClaimdetailtypes]() RETURNS TABLE AS RETURN (SELECT ISNULL(ID, - 1) AS ID, Code, Description FROM [dbo].[Claimdetailtypes])


GO
/****** Object:  UserDefinedFunction [dbo].[vClaimnatures]    Script Date: 06/06/2015 8:40:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[vClaimnatures] () RETURNS TABLE AS RETURN (SELECT ISNULL(ID, - 1) AS ID, Code, [Description] FROM dbo.Claimnatures)


GO
/****** Object:  UserDefinedFunction [dbo].[vClaims]    Script Date: 06/06/2015 8:40:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE FUNCTION [dbo].[vClaims](@branchID int) RETURNS TABLE AS RETURN 
(
	SELECT ISNULL(t1.ID, - 1) AS ID
		 , t1.Claim
		 , t2.Policy
		 , t1.Declarationdate
		 , t1.Claimdate
	FROM dbo.Claims t1
	left outer join Policies t2 on t1.PolicyID = t2.ID 
   where t1.BranchID = @branchID
)




GO
/****** Object:  UserDefinedFunction [dbo].[vClaimstypes]    Script Date: 06/06/2015 8:40:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[vClaimstypes]() RETURNS TABLE AS RETURN (SELECT ISNULL(ID, - 1) AS ID, Code, Description FROM [dbo].[Claimtypes])


GO
/****** Object:  UserDefinedFunction [dbo].[vClauses]    Script Date: 06/06/2015 8:40:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[vClauses] () RETURNS TABLE AS RETURN (SELECT ISNULL(ID, - 1) AS ID, Code, [Description] FROM dbo.Clauses)


GO
/****** Object:  UserDefinedFunction [dbo].[vCountries]    Script Date: 06/06/2015 8:40:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[vCountries] () RETURNS TABLE AS RETURN (SELECT ISNULL(ID, - 1) AS ID, Code, [Description] FROM dbo.Countries)



GO
/****** Object:  UserDefinedFunction [dbo].[vCurrencies]    Script Date: 06/06/2015 8:40:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[vCurrencies] () RETURNS TABLE AS RETURN (SELECT ISNULL(ID, - 1) AS ID, Code, [Description] FROM dbo.Currencies)



GO
/****** Object:  UserDefinedFunction [dbo].[vPolicies]    Script Date: 06/06/2015 8:40:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [dbo].[vPolicies](@branchID int) RETURNS TABLE AS RETURN 
(
	SELECT ISNULL(ID, - 1) AS ID
		 , Policy 
		 , Insured
		 , Issuedate 
	FROM dbo.Policies 
   where BranchID = @branchID
)



GO
/****** Object:  UserDefinedFunction [dbo].[vReinsurers]    Script Date: 06/06/2015 8:40:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [dbo].[vReinsurers]() RETURNS TABLE AS RETURN (SELECT ISNULL(ID, - 1) AS ID, Code, Name FROM dbo.Reinsurers)



GO
/****** Object:  UserDefinedFunction [dbo].[vTreaties]    Script Date: 06/06/2015 8:40:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[vTreaties] () RETURNS TABLE AS RETURN (SELECT ISNULL(ID, - 1) AS ID, Code, [Description] FROM dbo.Treaties)
GO
/****** Object:  UserDefinedFunction [dbo].[vZones]    Script Date: 06/06/2015 8:40:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[vZones] () RETURNS TABLE AS RETURN (SELECT ISNULL(ID, - 1) AS ID, Code, [Description] FROM dbo.Zones)



GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Policies_BranchPolicy]    Script Date: 06/06/2015 8:40:52 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Policies_BranchPolicy] ON [dbo].[Policies]
(
	[BranchID] ASC,
	[Policy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Bodytypes]  WITH NOCHECK ADD  CONSTRAINT [FK_Bodytypes_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Bodytypes] CHECK CONSTRAINT [FK_Bodytypes_Users_CID]
GO
ALTER TABLE [dbo].[Bodytypes]  WITH NOCHECK ADD  CONSTRAINT [FK_Bodytypes_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Bodytypes] CHECK CONSTRAINT [FK_Bodytypes_Users_MID]
GO
ALTER TABLE [dbo].[Branches]  WITH NOCHECK ADD  CONSTRAINT [FK_Branches_Reinsurers] FOREIGN KEY([ReinsurerID])
REFERENCES [dbo].[Reinsurers] ([ID])
GO
ALTER TABLE [dbo].[Branches] CHECK CONSTRAINT [FK_Branches_Reinsurers]
GO
ALTER TABLE [dbo].[Branches]  WITH NOCHECK ADD  CONSTRAINT [FK_Branches_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Branches] CHECK CONSTRAINT [FK_Branches_Users_CID]
GO
ALTER TABLE [dbo].[Branches]  WITH NOCHECK ADD  CONSTRAINT [FK_Branches_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Branches] CHECK CONSTRAINT [FK_Branches_Users_MID]
GO
ALTER TABLE [dbo].[Brokerdetails]  WITH NOCHECK ADD  CONSTRAINT [FK_Brokerdetails_Brokers] FOREIGN KEY([BrokerID])
REFERENCES [dbo].[Brokers] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Brokerdetails] CHECK CONSTRAINT [FK_Brokerdetails_Brokers]
GO
ALTER TABLE [dbo].[Brokers]  WITH NOCHECK ADD  CONSTRAINT [FK_Brokers_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Brokers] CHECK CONSTRAINT [FK_Brokers_Users_CID]
GO
ALTER TABLE [dbo].[Brokers]  WITH NOCHECK ADD  CONSTRAINT [FK_Brokers_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Brokers] CHECK CONSTRAINT [FK_Brokers_Users_MID]
GO
ALTER TABLE [dbo].[CarsCategories]  WITH NOCHECK ADD  CONSTRAINT [FK_CarsCategories_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[CarsCategories] CHECK CONSTRAINT [FK_CarsCategories_Users_CID]
GO
ALTER TABLE [dbo].[CarsCategories]  WITH NOCHECK ADD  CONSTRAINT [FK_CarsCategories_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[CarsCategories] CHECK CONSTRAINT [FK_CarsCategories_Users_MID]
GO
ALTER TABLE [dbo].[Carstariffs]  WITH NOCHECK ADD  CONSTRAINT [FK_Carstariffs_Bodytypes] FOREIGN KEY([BodytypeID])
REFERENCES [dbo].[Bodytypes] ([ID])
GO
ALTER TABLE [dbo].[Carstariffs] CHECK CONSTRAINT [FK_Carstariffs_Bodytypes]
GO
ALTER TABLE [dbo].[Carstariffs]  WITH NOCHECK ADD  CONSTRAINT [FK_Carstariffs_CarsCategories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[CarsCategories] ([ID])
GO
ALTER TABLE [dbo].[Carstariffs] CHECK CONSTRAINT [FK_Carstariffs_CarsCategories]
GO
ALTER TABLE [dbo].[Carstariffs]  WITH NOCHECK ADD  CONSTRAINT [FK_Carstariffs_Covertypes] FOREIGN KEY([CovertypeID])
REFERENCES [dbo].[Covertypes] ([ID])
GO
ALTER TABLE [dbo].[Carstariffs] CHECK CONSTRAINT [FK_Carstariffs_Covertypes]
GO
ALTER TABLE [dbo].[Carstariffs]  WITH NOCHECK ADD  CONSTRAINT [FK_Carstariffs_Tpltypes] FOREIGN KEY([TpltypeID])
REFERENCES [dbo].[Tpltypes] ([ID])
GO
ALTER TABLE [dbo].[Carstariffs] CHECK CONSTRAINT [FK_Carstariffs_Tpltypes]
GO
ALTER TABLE [dbo].[Carstariffs]  WITH NOCHECK ADD  CONSTRAINT [FK_Carstariffs_Usagetypes] FOREIGN KEY([UsagetypeID])
REFERENCES [dbo].[Usagetypes] ([ID])
GO
ALTER TABLE [dbo].[Carstariffs] CHECK CONSTRAINT [FK_Carstariffs_Usagetypes]
GO
ALTER TABLE [dbo].[Claimdetails]  WITH NOCHECK ADD  CONSTRAINT [FK_Claimdetails_Claims] FOREIGN KEY([ClaimID])
REFERENCES [dbo].[Claims] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Claimdetails] CHECK CONSTRAINT [FK_Claimdetails_Claims]
GO
ALTER TABLE [dbo].[Claimdetails]  WITH NOCHECK ADD  CONSTRAINT [FK_Claimdetails_Currencies] FOREIGN KEY([CurrencyID])
REFERENCES [dbo].[Currencies] ([ID])
GO
ALTER TABLE [dbo].[Claimdetails] CHECK CONSTRAINT [FK_Claimdetails_Currencies]
GO
ALTER TABLE [dbo].[Claimdetailtypes]  WITH NOCHECK ADD  CONSTRAINT [FK_Claimdetailtypes_Claimtypes] FOREIGN KEY([ClaimtypeID])
REFERENCES [dbo].[Claimtypes] ([ID])
GO
ALTER TABLE [dbo].[Claimdetailtypes] CHECK CONSTRAINT [FK_Claimdetailtypes_Claimtypes]
GO
ALTER TABLE [dbo].[Claimdetailtypes]  WITH NOCHECK ADD  CONSTRAINT [FK_Claimdetailtypes_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Claimdetailtypes] CHECK CONSTRAINT [FK_Claimdetailtypes_Users_CID]
GO
ALTER TABLE [dbo].[Claimdetailtypes]  WITH NOCHECK ADD  CONSTRAINT [FK_Claimdetailtypes_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Claimdetailtypes] CHECK CONSTRAINT [FK_Claimdetailtypes_Users_MID]
GO
ALTER TABLE [dbo].[Claimnatures]  WITH NOCHECK ADD  CONSTRAINT [FK_Claimnatures_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Claimnatures] CHECK CONSTRAINT [FK_Claimnatures_Users_CID]
GO
ALTER TABLE [dbo].[Claimnatures]  WITH NOCHECK ADD  CONSTRAINT [FK_Claimnatures_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Claimnatures] CHECK CONSTRAINT [FK_Claimnatures_Users_MID]
GO
ALTER TABLE [dbo].[Claims]  WITH CHECK ADD  CONSTRAINT [FK_Claims_Endorsements] FOREIGN KEY([EndorsementID])
REFERENCES [dbo].[Endorsements] ([ID])
GO
ALTER TABLE [dbo].[Claims] CHECK CONSTRAINT [FK_Claims_Endorsements]
GO
ALTER TABLE [dbo].[Claims]  WITH NOCHECK ADD  CONSTRAINT [FK_Claims_Policies] FOREIGN KEY([PolicyID])
REFERENCES [dbo].[Policies] ([ID])
GO
ALTER TABLE [dbo].[Claims] CHECK CONSTRAINT [FK_Claims_Policies]
GO
ALTER TABLE [dbo].[Claims]  WITH NOCHECK ADD  CONSTRAINT [FK_Claims_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Claims] CHECK CONSTRAINT [FK_Claims_Users_CID]
GO
ALTER TABLE [dbo].[Claims]  WITH NOCHECK ADD  CONSTRAINT [FK_Claims_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Claims] CHECK CONSTRAINT [FK_Claims_Users_MID]
GO
ALTER TABLE [dbo].[Claimtypes]  WITH NOCHECK ADD  CONSTRAINT [FK_Claimtypes_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Claimtypes] CHECK CONSTRAINT [FK_Claimtypes_Users_CID]
GO
ALTER TABLE [dbo].[Claimtypes]  WITH NOCHECK ADD  CONSTRAINT [FK_Claimtypes_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Claimtypes] CHECK CONSTRAINT [FK_Claimtypes_Users_MID]
GO
ALTER TABLE [dbo].[Clauses]  WITH NOCHECK ADD  CONSTRAINT [FK_Clauses_Branches] FOREIGN KEY([BranchID])
REFERENCES [dbo].[Branches] ([ID])
GO
ALTER TABLE [dbo].[Clauses] CHECK CONSTRAINT [FK_Clauses_Branches]
GO
ALTER TABLE [dbo].[Clauses]  WITH NOCHECK ADD  CONSTRAINT [FK_Clauses_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Clauses] CHECK CONSTRAINT [FK_Clauses_Users_CID]
GO
ALTER TABLE [dbo].[Clauses]  WITH NOCHECK ADD  CONSTRAINT [FK_Clauses_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Clauses] CHECK CONSTRAINT [FK_Clauses_Users_MID]
GO
ALTER TABLE [dbo].[Countries]  WITH NOCHECK ADD  CONSTRAINT [FK_Countries_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Countries] CHECK CONSTRAINT [FK_Countries_Users_CID]
GO
ALTER TABLE [dbo].[Countries]  WITH NOCHECK ADD  CONSTRAINT [FK_Countries_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Countries] CHECK CONSTRAINT [FK_Countries_Users_MID]
GO
ALTER TABLE [dbo].[Covertypes]  WITH NOCHECK ADD  CONSTRAINT [FK_Covertypes_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Covertypes] CHECK CONSTRAINT [FK_Covertypes_Users_CID]
GO
ALTER TABLE [dbo].[Covertypes]  WITH NOCHECK ADD  CONSTRAINT [FK_Covertypes_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Covertypes] CHECK CONSTRAINT [FK_Covertypes_Users_MID]
GO
ALTER TABLE [dbo].[Cpltypes]  WITH NOCHECK ADD  CONSTRAINT [FK_Cpltypes_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Cpltypes] CHECK CONSTRAINT [FK_Cpltypes_Users_CID]
GO
ALTER TABLE [dbo].[Cpltypes]  WITH NOCHECK ADD  CONSTRAINT [FK_Cpltypes_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Cpltypes] CHECK CONSTRAINT [FK_Cpltypes_Users_MID]
GO
ALTER TABLE [dbo].[Endorsementcars]  WITH CHECK ADD  CONSTRAINT [FK_Endorsementcars_Endorsements] FOREIGN KEY([EndorsementID])
REFERENCES [dbo].[Endorsements] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Endorsementcars] CHECK CONSTRAINT [FK_Endorsementcars_Endorsements]
GO
ALTER TABLE [dbo].[Endorsements]  WITH CHECK ADD  CONSTRAINT [FK_Endorsements_Branches] FOREIGN KEY([BranchID])
REFERENCES [dbo].[Branches] ([ID])
GO
ALTER TABLE [dbo].[Endorsements] CHECK CONSTRAINT [FK_Endorsements_Branches]
GO
ALTER TABLE [dbo].[Endorsements]  WITH CHECK ADD  CONSTRAINT [FK_Endorsements_Brokers] FOREIGN KEY([BrokerID])
REFERENCES [dbo].[Brokers] ([ID])
GO
ALTER TABLE [dbo].[Endorsements] CHECK CONSTRAINT [FK_Endorsements_Brokers]
GO
ALTER TABLE [dbo].[Endorsements]  WITH CHECK ADD  CONSTRAINT [FK_Endorsements_Currencies] FOREIGN KEY([CurrencyID])
REFERENCES [dbo].[Currencies] ([ID])
GO
ALTER TABLE [dbo].[Endorsements] CHECK CONSTRAINT [FK_Endorsements_Currencies]
GO
ALTER TABLE [dbo].[Endorsements]  WITH CHECK ADD  CONSTRAINT [FK_Endorsements_Policies] FOREIGN KEY([PolicyID])
REFERENCES [dbo].[Policies] ([ID])
GO
ALTER TABLE [dbo].[Endorsements] CHECK CONSTRAINT [FK_Endorsements_Policies]
GO
ALTER TABLE [dbo].[Endorsements]  WITH CHECK ADD  CONSTRAINT [FK_Endorsements_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Endorsements] CHECK CONSTRAINT [FK_Endorsements_Users_CID]
GO
ALTER TABLE [dbo].[Endorsements]  WITH CHECK ADD  CONSTRAINT [FK_Endorsements_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Endorsements] CHECK CONSTRAINT [FK_Endorsements_Users_MID]
GO
ALTER TABLE [dbo].[Firepackages]  WITH NOCHECK ADD  CONSTRAINT [FK_Firepackages_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Firepackages] CHECK CONSTRAINT [FK_Firepackages_Users_CID]
GO
ALTER TABLE [dbo].[Firepackages]  WITH NOCHECK ADD  CONSTRAINT [FK_Firepackages_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Firepackages] CHECK CONSTRAINT [FK_Firepackages_Users_MID]
GO
ALTER TABLE [dbo].[Hospitalsplans]  WITH NOCHECK ADD  CONSTRAINT [FK_Hospitalsplans_Treaties] FOREIGN KEY([TreatyID])
REFERENCES [dbo].[Treaties] ([ID])
GO
ALTER TABLE [dbo].[Hospitalsplans] CHECK CONSTRAINT [FK_Hospitalsplans_Treaties]
GO
ALTER TABLE [dbo].[Hospitalsplans]  WITH NOCHECK ADD  CONSTRAINT [FK_Hospitalsplans_Treaties_OUT] FOREIGN KEY([TreatyOutID])
REFERENCES [dbo].[Treaties] ([ID])
GO
ALTER TABLE [dbo].[Hospitalsplans] CHECK CONSTRAINT [FK_Hospitalsplans_Treaties_OUT]
GO
ALTER TABLE [dbo].[Hospitalsplans]  WITH NOCHECK ADD  CONSTRAINT [FK_Hospitalsplans_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Hospitalsplans] CHECK CONSTRAINT [FK_Hospitalsplans_Users_CID]
GO
ALTER TABLE [dbo].[Hospitalsplans]  WITH NOCHECK ADD  CONSTRAINT [FK_Hospitalsplans_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Hospitalsplans] CHECK CONSTRAINT [FK_Hospitalsplans_Users_MID]
GO
ALTER TABLE [dbo].[Policies]  WITH NOCHECK ADD  CONSTRAINT [FK_Policies_Brokers] FOREIGN KEY([BrokerID])
REFERENCES [dbo].[Brokers] ([ID])
GO
ALTER TABLE [dbo].[Policies] CHECK CONSTRAINT [FK_Policies_Brokers]
GO
ALTER TABLE [dbo].[Policies]  WITH NOCHECK ADD  CONSTRAINT [FK_Policies_Currencies] FOREIGN KEY([CurrencyID])
REFERENCES [dbo].[Currencies] ([ID])
GO
ALTER TABLE [dbo].[Policies] CHECK CONSTRAINT [FK_Policies_Currencies]
GO
ALTER TABLE [dbo].[Policies]  WITH NOCHECK ADD  CONSTRAINT [FK_Policies_Policies_BASE] FOREIGN KEY([BasePolicyID])
REFERENCES [dbo].[Policies] ([ID])
GO
ALTER TABLE [dbo].[Policies] CHECK CONSTRAINT [FK_Policies_Policies_BASE]
GO
ALTER TABLE [dbo].[Policies]  WITH NOCHECK ADD  CONSTRAINT [FK_Policies_Policies_NEW] FOREIGN KEY([NewPolicyID])
REFERENCES [dbo].[Policies] ([ID])
GO
ALTER TABLE [dbo].[Policies] CHECK CONSTRAINT [FK_Policies_Policies_NEW]
GO
ALTER TABLE [dbo].[Policies]  WITH NOCHECK ADD  CONSTRAINT [FK_Policies_Policies_OLD] FOREIGN KEY([OldPolicyID])
REFERENCES [dbo].[Policies] ([ID])
GO
ALTER TABLE [dbo].[Policies] CHECK CONSTRAINT [FK_Policies_Policies_OLD]
GO
ALTER TABLE [dbo].[Policies]  WITH NOCHECK ADD  CONSTRAINT [FK_Policies_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Policies] CHECK CONSTRAINT [FK_Policies_Users_CID]
GO
ALTER TABLE [dbo].[Policies]  WITH NOCHECK ADD  CONSTRAINT [FK_Policies_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Policies] CHECK CONSTRAINT [FK_Policies_Users_MID]
GO
ALTER TABLE [dbo].[Policycars]  WITH NOCHECK ADD  CONSTRAINT [FK_Policycars_Policies] FOREIGN KEY([PolicyID])
REFERENCES [dbo].[Policies] ([ID])
GO
ALTER TABLE [dbo].[Policycars] CHECK CONSTRAINT [FK_Policycars_Policies]
GO
ALTER TABLE [dbo].[Policycars]  WITH NOCHECK ADD  CONSTRAINT [FK_Policycars_Policies_Luxury] FOREIGN KEY([LuxuryPolicyID])
REFERENCES [dbo].[Policies] ([ID])
GO
ALTER TABLE [dbo].[Policycars] CHECK CONSTRAINT [FK_Policycars_Policies_Luxury]
GO
ALTER TABLE [dbo].[Rates]  WITH NOCHECK ADD  CONSTRAINT [FK_Rates_Currencies] FOREIGN KEY([CurrencyID])
REFERENCES [dbo].[Currencies] ([ID])
GO
ALTER TABLE [dbo].[Rates] CHECK CONSTRAINT [FK_Rates_Currencies]
GO
ALTER TABLE [dbo].[Recours]  WITH NOCHECK ADD  CONSTRAINT [FK_Recours_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Recours] CHECK CONSTRAINT [FK_Recours_Users_CID]
GO
ALTER TABLE [dbo].[Recours]  WITH NOCHECK ADD  CONSTRAINT [FK_Recours_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Recours] CHECK CONSTRAINT [FK_Recours_Users_MID]
GO
ALTER TABLE [dbo].[Reinsurers]  WITH NOCHECK ADD  CONSTRAINT [FK_Reinsurers_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Reinsurers] CHECK CONSTRAINT [FK_Reinsurers_Users_CID]
GO
ALTER TABLE [dbo].[Reinsurers]  WITH NOCHECK ADD  CONSTRAINT [FK_Reinsurers_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Reinsurers] CHECK CONSTRAINT [FK_Reinsurers_Users_MID]
GO
ALTER TABLE [dbo].[Tariffs]  WITH NOCHECK ADD  CONSTRAINT [FK_Tariffs_Branches] FOREIGN KEY([BranchID])
REFERENCES [dbo].[Branches] ([ID])
GO
ALTER TABLE [dbo].[Tariffs] CHECK CONSTRAINT [FK_Tariffs_Branches]
GO
ALTER TABLE [dbo].[Tariffs]  WITH NOCHECK ADD  CONSTRAINT [FK_Tariffs_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Tariffs] CHECK CONSTRAINT [FK_Tariffs_Users_CID]
GO
ALTER TABLE [dbo].[Tariffs]  WITH NOCHECK ADD  CONSTRAINT [FK_Tariffs_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Tariffs] CHECK CONSTRAINT [FK_Tariffs_Users_MID]
GO
ALTER TABLE [dbo].[Tarifhospitals]  WITH NOCHECK ADD  CONSTRAINT [FK_Tarifhospitals_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Tarifhospitals] CHECK CONSTRAINT [FK_Tarifhospitals_Users_CID]
GO
ALTER TABLE [dbo].[Tarifhospitals]  WITH NOCHECK ADD  CONSTRAINT [FK_Tarifhospitals_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Tarifhospitals] CHECK CONSTRAINT [FK_Tarifhospitals_Users_MID]
GO
ALTER TABLE [dbo].[Tarifhospitalsdetails]  WITH NOCHECK ADD  CONSTRAINT [FK_Tarifhospitalsdetails_Tarifhospitals] FOREIGN KEY([TarifID])
REFERENCES [dbo].[Tarifhospitals] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tarifhospitalsdetails] CHECK CONSTRAINT [FK_Tarifhospitalsdetails_Tarifhospitals]
GO
ALTER TABLE [dbo].[Tarifworkers]  WITH NOCHECK ADD  CONSTRAINT [FK_Tarifworkers_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Tarifworkers] CHECK CONSTRAINT [FK_Tarifworkers_Users_CID]
GO
ALTER TABLE [dbo].[Tarifworkers]  WITH NOCHECK ADD  CONSTRAINT [FK_Tarifworkers_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Tarifworkers] CHECK CONSTRAINT [FK_Tarifworkers_Users_MID]
GO
ALTER TABLE [dbo].[Tarifworkersdetails]  WITH NOCHECK ADD  CONSTRAINT [FK_Tarifworkersdetails_Tarifworkers] FOREIGN KEY([TarifID])
REFERENCES [dbo].[Tarifworkers] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tarifworkersdetails] CHECK CONSTRAINT [FK_Tarifworkersdetails_Tarifworkers]
GO
ALTER TABLE [dbo].[Tpltypes]  WITH NOCHECK ADD  CONSTRAINT [FK_Tpltypes_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Tpltypes] CHECK CONSTRAINT [FK_Tpltypes_Users_CID]
GO
ALTER TABLE [dbo].[Tpltypes]  WITH NOCHECK ADD  CONSTRAINT [FK_Tpltypes_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Tpltypes] CHECK CONSTRAINT [FK_Tpltypes_Users_MID]
GO
ALTER TABLE [dbo].[Travelrates]  WITH NOCHECK ADD  CONSTRAINT [FK_Travelrates_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Travelrates] CHECK CONSTRAINT [FK_Travelrates_Users_CID]
GO
ALTER TABLE [dbo].[Travelrates]  WITH NOCHECK ADD  CONSTRAINT [FK_Travelrates_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Travelrates] CHECK CONSTRAINT [FK_Travelrates_Users_MID]
GO
ALTER TABLE [dbo].[Treaties]  WITH NOCHECK ADD  CONSTRAINT [FK_Treaties_Branches] FOREIGN KEY([BranchID])
REFERENCES [dbo].[Branches] ([ID])
GO
ALTER TABLE [dbo].[Treaties] CHECK CONSTRAINT [FK_Treaties_Branches]
GO
ALTER TABLE [dbo].[Treaties]  WITH NOCHECK ADD  CONSTRAINT [FK_Treaties_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Treaties] CHECK CONSTRAINT [FK_Treaties_Users_CID]
GO
ALTER TABLE [dbo].[Treaties]  WITH NOCHECK ADD  CONSTRAINT [FK_Treaties_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Treaties] CHECK CONSTRAINT [FK_Treaties_Users_MID]
GO
ALTER TABLE [dbo].[Treatydetails]  WITH NOCHECK ADD  CONSTRAINT [FK_Treatydetails_Reinsurers] FOREIGN KEY([ReinsurerID])
REFERENCES [dbo].[Reinsurers] ([ID])
GO
ALTER TABLE [dbo].[Treatydetails] CHECK CONSTRAINT [FK_Treatydetails_Reinsurers]
GO
ALTER TABLE [dbo].[Treatydetails]  WITH NOCHECK ADD  CONSTRAINT [FK_Treatydetails_Treaties] FOREIGN KEY([TreatyID])
REFERENCES [dbo].[Treaties] ([ID])
GO
ALTER TABLE [dbo].[Treatydetails] CHECK CONSTRAINT [FK_Treatydetails_Treaties]
GO
ALTER TABLE [dbo].[Usagetypes]  WITH NOCHECK ADD  CONSTRAINT [FK_Usagetypes_Users_CID] FOREIGN KEY([CreatedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Usagetypes] CHECK CONSTRAINT [FK_Usagetypes_Users_CID]
GO
ALTER TABLE [dbo].[Usagetypes]  WITH NOCHECK ADD  CONSTRAINT [FK_Usagetypes_Users_MID] FOREIGN KEY([ModifiedByID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbo].[Usagetypes] CHECK CONSTRAINT [FK_Usagetypes_Users_MID]
GO
ALTER TABLE [dbs].[GroupRoles]  WITH NOCHECK ADD  CONSTRAINT [FK_GroupRoles_Forms] FOREIGN KEY([FormID])
REFERENCES [dbs].[Forms] ([ID])
GO
ALTER TABLE [dbs].[GroupRoles] CHECK CONSTRAINT [FK_GroupRoles_Forms]
GO
ALTER TABLE [dbs].[GroupRoles]  WITH NOCHECK ADD  CONSTRAINT [FK_GroupRoles_Groups] FOREIGN KEY([GroupID])
REFERENCES [dbs].[Groups] ([ID])
GO
ALTER TABLE [dbs].[GroupRoles] CHECK CONSTRAINT [FK_GroupRoles_Groups]
GO
ALTER TABLE [dbs].[UserRoles]  WITH NOCHECK ADD  CONSTRAINT [FK_UserRoles_Forms] FOREIGN KEY([FormID])
REFERENCES [dbs].[Forms] ([ID])
GO
ALTER TABLE [dbs].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Forms]
GO
ALTER TABLE [dbs].[UserRoles]  WITH NOCHECK ADD  CONSTRAINT [FK_UserRoles_Users] FOREIGN KEY([UserID])
REFERENCES [dbs].[Users] ([ID])
GO
ALTER TABLE [dbs].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Users]
GO
ALTER TABLE [dbs].[Users]  WITH NOCHECK ADD  CONSTRAINT [FK_Users_Departments] FOREIGN KEY([DepartmentID])
REFERENCES [dbs].[Departments] ([ID])
GO
ALTER TABLE [dbs].[Users] CHECK CONSTRAINT [FK_Users_Departments]
GO
ALTER TABLE [dbs].[Users]  WITH NOCHECK ADD  CONSTRAINT [FK_Users_Groups] FOREIGN KEY([GroupID])
REFERENCES [dbs].[Groups] ([ID])
GO
ALTER TABLE [dbs].[Users] CHECK CONSTRAINT [FK_Users_Groups]
GO
USE [master]
GO
ALTER DATABASE [CIGinsurance] SET  READ_WRITE 
GO

-----------------------------------------------------------------------------------------------------------------------------------
ALTER TABLE [dbo].Policyallrisk  WITH NOCHECK ADD  CONSTRAINT [FK_Policyallrisk_Policies] FOREIGN KEY([PolicyID])
REFERENCES [dbo].[Policies] ([ID])
GO
ALTER TABLE [dbo].Policyallrisk CHECK CONSTRAINT [FK_Policyallrisk_Policies]
GO
-----------------------------------------------------------------------------------------------------------------------------------
ALTER TABLE [dbo].Policyboat  WITH NOCHECK ADD  CONSTRAINT [FK_Policyboat_Policies] FOREIGN KEY([PolicyID])
REFERENCES [dbo].[Policies] ([ID])
GO
ALTER TABLE [dbo].Policyboat CHECK CONSTRAINT [FK_Policyboat_Policies]
GO
-----------------------------------------------------------------------------------------------------------------------------------
ALTER TABLE [dbo].Policyburglary  WITH NOCHECK ADD  CONSTRAINT [FK_Policyburglary_Policies] FOREIGN KEY([PolicyID])
REFERENCES [dbo].[Policies] ([ID])
GO
ALTER TABLE [dbo].Policyburglary CHECK CONSTRAINT [FK_Policyburglary_Policies]
GO
-----------------------------------------------------------------------------------------------------------------------------------
ALTER TABLE [dbo].Policycompulsory  WITH NOCHECK ADD  CONSTRAINT [FK_Policycompulsory_Policies] FOREIGN KEY([PolicyID])
REFERENCES [dbo].[Policies] ([ID])
GO
ALTER TABLE [dbo].Policycompulsory CHECK CONSTRAINT [FK_Policycompulsory_Policies]
GO
-----------------------------------------------------------------------------------------------------------------------------------
ALTER TABLE [dbo].Policyfire  WITH NOCHECK ADD  CONSTRAINT [FK_Policyfire_Policies] FOREIGN KEY([PolicyID])
REFERENCES [dbo].[Policies] ([ID])
GO
ALTER TABLE [dbo].Policyfire CHECK CONSTRAINT [FK_Policyfire_Policies]
GO
-----------------------------------------------------------------------------------------------------------------------------------
ALTER TABLE [dbo].Policygtpl  WITH NOCHECK ADD  CONSTRAINT [FK_Policygtpl_Policies] FOREIGN KEY([PolicyID])
REFERENCES [dbo].[Policies] ([ID])
GO
ALTER TABLE [dbo].Policygtpl CHECK CONSTRAINT [FK_Policygtpl_Policies]
GO
-----------------------------------------------------------------------------------------------------------------------------------
ALTER TABLE [dbo].Policyhospitalization  WITH NOCHECK ADD  CONSTRAINT [FK_Policyhospitalization_Policies] FOREIGN KEY([PolicyID])
REFERENCES [dbo].[Policies] ([ID])
GO
ALTER TABLE [dbo].Policyhospitalization CHECK CONSTRAINT [FK_Policyhospitalization_Policies]
GO
-----------------------------------------------------------------------------------------------------------------------------------
ALTER TABLE [dbo].Policylife  WITH NOCHECK ADD  CONSTRAINT [FK_Policylife_Policies] FOREIGN KEY([PolicyID])
REFERENCES [dbo].[Policies] ([ID])
GO
ALTER TABLE [dbo].Policylife CHECK CONSTRAINT [FK_Policylife_Policies]
GO
-----------------------------------------------------------------------------------------------------------------------------------
ALTER TABLE [dbo].Policyluxury  WITH NOCHECK ADD  CONSTRAINT [FK_Policyluxury_Policies] FOREIGN KEY([PolicyID])
REFERENCES [dbo].[Policies] ([ID])
GO
ALTER TABLE [dbo].Policyluxury CHECK CONSTRAINT [FK_Policyluxury_Policies]
GO
-----------------------------------------------------------------------------------------------------------------------------------
ALTER TABLE [dbo].Policyorangecard  WITH NOCHECK ADD  CONSTRAINT [FK_Policyorangecard_Policies] FOREIGN KEY([PolicyID])
REFERENCES [dbo].[Policies] ([ID])
GO
ALTER TABLE [dbo].Policyorangecard CHECK CONSTRAINT [FK_Policyorangecard_Policies]
GO
-----------------------------------------------------------------------------------------------------------------------------------
ALTER TABLE [dbo].Policyout  WITH NOCHECK ADD  CONSTRAINT [FK_Policyout_Policies] FOREIGN KEY([PolicyID])
REFERENCES [dbo].[Policies] ([ID])
GO
ALTER TABLE [dbo].Policyout CHECK CONSTRAINT [FK_Policyout_Policies]
GO
-----------------------------------------------------------------------------------------------------------------------------------
ALTER TABLE [dbo].Policypolitical  WITH NOCHECK ADD  CONSTRAINT [FK_Policypolitical_Policies] FOREIGN KEY([PolicyID])
REFERENCES [dbo].[Policies] ([ID])
GO
ALTER TABLE [dbo].Policypolitical CHECK CONSTRAINT [FK_Policypolitical_Policies]
GO
-----------------------------------------------------------------------------------------------------------------------------------
ALTER TABLE [dbo].Policytravel  WITH NOCHECK ADD  CONSTRAINT [FK_Policytravel_Policies] FOREIGN KEY([PolicyID])
REFERENCES [dbo].[Policies] ([ID])
GO
ALTER TABLE [dbo].Policytravel CHECK CONSTRAINT [FK_Policytravel_Policies]
GO
-----------------------------------------------------------------------------------------------------------------------------------
ALTER TABLE [dbo].Policyworkers  WITH NOCHECK ADD  CONSTRAINT [FK_Policyworkers_Policies] FOREIGN KEY([PolicyID])
REFERENCES [dbo].[Policies] ([ID])
GO
ALTER TABLE [dbo].Policyworkers CHECK CONSTRAINT [FK_Policyworkers_Policies]
GO
-----------------------------------------------------------------------------------------------------------------------------------
ALTER TABLE [dbo].Policyworkmens  WITH NOCHECK ADD  CONSTRAINT [FK_Policyworkmens_Policies] FOREIGN KEY([PolicyID])
REFERENCES [dbo].[Policies] ([ID])
GO
ALTER TABLE [dbo].Policyworkmens CHECK CONSTRAINT [FK_Policyworkmens_Policies]
GO
