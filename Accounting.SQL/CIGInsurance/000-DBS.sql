USE [CIGInsurance]
GO
/****** Object:  Schema [dbs]    Script Date: 08/06/2015 2:51:58 PM ******/
CREATE SCHEMA [dbs]
GO
/****** Object:  Schema [tmp]    Script Date: 08/06/2015 2:51:58 PM ******/
CREATE SCHEMA [tmp]
GO
/****** Object:  StoredProcedure [dbo].[RowCount]    Script Date: 08/06/2015 2:51:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Batch submitted through debugger: SQLQuery14.sql|7|0|C:\Users\Rafic\AppData\Local\Temp\~vs5B80.sql


CREATE procedure [dbo].[RowCount] 
(
	@Table nvarchar(max)
)
AS
BEGIN
DECLARE   @Count INT
		, @SQL NVARCHAR(1000)

--SET @Table = 'Claiminvoicedetails'
SET @SQL = N'SELECT @Count = COUNT(id) from ' + @Table

EXEC sp_executesql @SQL, N'@Count INT OUTPUT', @Count OUTPUT

select @Count
END








GO
/****** Object:  StoredProcedure [dbo].[ssp_DropTable]    Script Date: 08/06/2015 2:51:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[ssp_DropTable](@TableName nvarchar(30))
AS
BEGIN
  declare @fullname nvarchar(50)
  set @fullname = 'tempdb..'+@tablename
  IF OBJECT_ID(@fullname,'u') IS NOT NULL
	BEGIN
		exec ('DROP TABLE '+@tablename)
	END
END








GO
/****** Object:  UserDefinedFunction [dbo].[getMonthYear]    Script Date: 08/06/2015 2:51:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

/*
PadLeft() – Returns string with character(s) provided attached to left side of string up to total length requested
Created: 2.4.2009
Author: Sam Moreira (smoreira @ itblognow com)
*/
CREATE Function [dbo].[getMonthYear]
(
	@month int, 
	@year Int
)

Returns Varchar(5)
As Begin
	Declare @mResult Varchar(5)
	if @month = 0 or @year = 0
	set @mResult = 'ERR00'
	else
	Set @mResult = upper(left(DateName( month , DateAdd( month , @month , -1 )),3)) + right(convert(nvarchar,@year),2)
	Return @mResult
End






GO
/****** Object:  UserDefinedFunction [dbo].[GetNextClaim]    Script Date: 08/06/2015 2:51:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO


/*
PadLeft() – Returns string with character(s) provided attached to left side of string up to total length requested
Created: 2.4.2009
Author: Sam Moreira (smoreira @ itblognow com)
*/
CREATE Function [dbo].[GetNextClaim]
(
	@branch Varchar(1), 
	@Code Varchar(15)
)

Returns Varchar(15)
As Begin
	Declare @mResult Varchar(15)
	declare @year nvarchar(4) = convert(nvarchar,year(getdate()))
	declare @ser int = 1

	if @code is not null
		begin 
		set @ser = convert(int,substring(@Code,9,5))+1
		end 

		Set @mResult = 'C'+@branch+'/'+@year+'/'+[dbo].[PadLeft](convert(nvarchar,@ser),'0','5')
	Return @mResult
End







GO
/****** Object:  UserDefinedFunction [dbo].[IsNullOrEmpty]    Script Date: 08/06/2015 2:51:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 
CREATE FUNCTION [dbo].[IsNullOrEmpty] (@string_val varchar(8000))
 
RETURNS bit
WITH EXECUTE AS CALLER
AS
BEGIN
 
    IF @string_val IS NULL OR @string_val = '' RETURN 1
    RETURN 0;
    
END;




GO
/****** Object:  UserDefinedFunction [dbo].[PadLeft]    Script Date: 08/06/2015 2:51:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

/*
PadLeft() – Returns string with character(s) provided attached to left side of string up to total length requested
Created: 2.4.2009
Author: Sam Moreira (smoreira @ itblognow com)
*/
CREATE Function [dbo].[PadLeft]
(
	@i_vString Varchar(50), 
	@i_vChar Varchar(5), 
	@i_iLength Int
)

Returns Varchar(500)
As Begin
	Declare @mResult Varchar(500)
	declare @L int
	--Remove Spaces From String
	Set @mResult =RTrim(LTrim(@i_vString))
	set @L = @i_iLength - Len(@mResult)
	--Check the need to run statements
	If (@i_iLength > Len(@mResult) And @i_iLength <= 500)
		Begin
		--Add character(s) to left side of string
		Set @mResult = Replicate(@i_vChar, @L) + @mResult
		Set @mResult = Left(@mResult, @i_iLength)
		End
	Return @mResult
End






GO
/****** Object:  UserDefinedFunction [dbo].[PadRight]    Script Date: 08/06/2015 2:51:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

--select test = dbo.padleft('RDE', 'N', 20)

/*
PadRight() – Returns string with character(s) provided attached to right side of string up to total length requested
Created: 2.4.2009
Author: Sam Moreira (smoreira @ itblognow com)
*/
Create Function [dbo].[PadRight]
(
	@i_vString Varchar(50), 
	@i_vChar Varchar(5), 
	@i_iLength Int
)
Returns Varchar(500)

As Begin
	Declare @mResult Varchar(500)
	declare @L int
	--Remove Spaces From String
	Set @mResult =RTrim(LTrim(@i_vString))
	set @L = @i_iLength - Len(@mResult)
	--Check the need to run statements
	If (@i_iLength > Len(@mResult) And @i_iLength <= 500)
		Begin
			--Add character(s) to right side of string
			Set @mResult = @mResult + Replicate(@i_vChar, @L)
			Set @mResult = Right(@mResult, @i_iLength)
		End
	Return @mResult
End





GO
/****** Object:  Table [dbs].[Departments]    Script Date: 08/06/2015 2:51:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbs].[Departments](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](40) NULL,
	[Notes] [ntext] NULL,
	[CreatedByID] [int] NULL,
	[Creationdate] [smalldatetime] NULL,
	[ModifiedByID] [int] NULL,
	[Modificationdate] [smalldatetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbs].[Forms]    Script Date: 08/06/2015 2:51:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbs].[Forms](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ButtonID] [int] NULL,
	[Panel] [nvarchar](40) NULL,
	[FormGroup] [nvarchar](40) NULL,
	[FormName] [nvarchar](40) NULL,
	[CreatedByID] [int] NULL,
	[CreationDate] [smalldatetime] NULL,
	[ModifiedByID] [int] NULL,
	[ModificationDate] [smalldatetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbs].[GroupRoles]    Script Date: 08/06/2015 2:51:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbs].[GroupRoles](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GroupID] [int] NULL,
	[FormID] [int] NULL,
	[Allowed] [bit] NULL,
	[CanAdd] [bit] NULL,
	[CanEdit] [bit] NULL,
	[CanDelete] [bit] NULL,
	[CanPrint] [bit] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbs].[Groups]    Script Date: 08/06/2015 2:51:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbs].[Groups](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](50) NULL,
	[CreatedByID] [int] NULL,
	[CreationDate] [smalldatetime] NULL,
	[ModifiedByID] [int] NULL,
	[ModificationDate] [smalldatetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbs].[UserRoles]    Script Date: 08/06/2015 2:51:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbs].[UserRoles](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[FormID] [int] NULL,
	[Allowed] [bit] NULL,
	[CanAdd] [bit] NULL,
	[CanEdit] [bit] NULL,
	[CanDelete] [bit] NULL,
	[CanPrint] [bit] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbs].[Users]    Script Date: 08/06/2015 2:51:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbs].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[Password] [nvarchar](max) NULL,
	[DepartmentID] [int] NULL,
	[GroupID] [int] NULL,
	[LevelID] [int] NULL,
	[isBlocked] [bit] NULL,
	[Notes] [text] NULL,
	[BirthDate] [date] NULL,
	[LastLogin] [smalldatetime] NULL,
	[CreatedByID] [int] NULL,
	[CreationDate] [smalldatetime] NULL,
	[ModifiedByID] [int] NULL,
	[ModificationDate] [smalldatetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Index [PK_Departments]    Script Date: 08/06/2015 2:51:58 PM ******/
ALTER TABLE [dbs].[Departments] ADD  CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_Forms]    Script Date: 08/06/2015 2:51:58 PM ******/
ALTER TABLE [dbs].[Forms] ADD  CONSTRAINT [PK_Forms] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_GroupRoles]    Script Date: 08/06/2015 2:51:58 PM ******/
ALTER TABLE [dbs].[GroupRoles] ADD  CONSTRAINT [PK_GroupRoles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_Groups]    Script Date: 08/06/2015 2:51:58 PM ******/
ALTER TABLE [dbs].[Groups] ADD  CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_UserRoles]    Script Date: 08/06/2015 2:51:58 PM ******/
ALTER TABLE [dbs].[UserRoles] ADD  CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_Users]    Script Date: 08/06/2015 2:51:58 PM ******/
ALTER TABLE [dbs].[Users] ADD  CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbs].[Departments] ON 

GO
INSERT [dbs].[Departments] ([ID], [Description], [Notes], [CreatedByID], [Creationdate], [ModifiedByID], [Modificationdate]) VALUES (2, N'CLAIMS', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Departments] ([ID], [Description], [Notes], [CreatedByID], [Creationdate], [ModifiedByID], [Modificationdate]) VALUES (3, N'UNDERWRITING', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Departments] ([ID], [Description], [Notes], [CreatedByID], [Creationdate], [ModifiedByID], [Modificationdate]) VALUES (4, N'ACCOUNTING', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Departments] ([ID], [Description], [Notes], [CreatedByID], [Creationdate], [ModifiedByID], [Modificationdate]) VALUES (9, N'BBBB GGGG', NULL, 32, CAST(0xA4670301 AS SmallDateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbs].[Departments] OFF
GO
SET IDENTITY_INSERT [dbs].[Forms] ON 

GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (1, 306, N'Configuration', N'Main', N'FormClauses', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (2, 309, N'Configuration', N'Main', N'FormReinsurers', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (3, 310, N'Configuration', N'Main', N'FormTreaties', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (4, 313, N'Configuration', N'Main', N'FormNationalities', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (5, 314, N'Configuration', N'Main', N'FormProfessions', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (6, 315, N'Configuration', N'Main', N'FormFirePackages', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (7, 317, N'Configuration', N'Main', N'FormRecours', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (8, 333, N'Configuration', N'Main', N'FormHospitalsPlans', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (9, 312, N'Configuration', N'Main', N'FormTravelRates', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (10, 334, N'Configuration', N'Motor', N'FormBodyTypes', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (11, 335, N'Configuration', N'Motor', N'FormCoverTypes', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (12, 336, N'Configuration', N'Motor', N'FormUsageTypes', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (13, 337, N'Configuration', N'Motor', N'FormTplTypes', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (14, 414, N'Configuration', N'Motor', N'FormCplTypes', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (15, 339, N'Configuration', N'Tariffs', N'FormCarsTariffs', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (16, 338, N'Configuration', N'Tariffs', N'FormTariffs', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (17, 316, N'Configuration', N'Tariffs', N'FormTarifWorkers', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (18, 332, N'Configuration', N'Tariffs', N'FormTarifHospital', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (19, 330, N'Configuration', N'H  And L Ratios', N'FormInfirmityLifeRatios', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (20, 331, N'Configuration', N'H  And L Ratios', N'FormTermLifeRatios', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (21, 245, N'Policies', N'Vehicles', N'FormPoliciesCars', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (22, 246, N'Policies', N'Vehicles', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (23, 247, N'Policies', N'Vehicles', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (24, 248, N'Policies', N'Vehicles', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (25, 254, N'Policies', N'Vehicles', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (26, 259, N'Policies', N'Medical', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (27, 261, N'Policies', N'Medical', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (28, 255, N'Policies', N'Miscellaneous [DIVERS]', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (29, 257, N'Policies', N'Miscellaneous [DIVERS]', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (30, 265, N'Policies', N'Miscellaneous [DIVERS]', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (31, 264, N'Policies', N'Miscellaneous [DIVERS]', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (32, 258, N'Policies', N'Miscellaneous [DIVERS]', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (33, 262, N'Policies', N'Miscellaneous [DIVERS]', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (34, 256, N'Policies', N'Miscellaneous [DIVERS]', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (35, 266, N'Policies', N'Others', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (36, 260, N'Policies', N'Others', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (37, 267, N'Policies', N'Others', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (38, 263, N'Policies', N'Others', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (39, 280, N'Endorsements', N'Vehicles Endorsements', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (40, 281, N'Endorsements', N'Vehicles Endorsements', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (41, 282, N'Endorsements', N'Vehicles Endorsements', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (42, 283, N'Endorsements', N'Vehicles Endorsements', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (43, 284, N'Endorsements', N'Vehicles Endorsements', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (44, 285, N'Endorsements', N'Medical Endorsements', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (45, 286, N'Endorsements', N'Medical Endorsements', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (46, 287, N'Endorsements', N'Miscellaneous [DIVERS] Endorsements', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (47, 288, N'Endorsements', N'Miscellaneous [DIVERS] Endorsements', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (48, 289, N'Endorsements', N'Miscellaneous [DIVERS] Endorsements', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (49, 290, N'Endorsements', N'Miscellaneous [DIVERS] Endorsements', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (50, 291, N'Endorsements', N'Miscellaneous [DIVERS] Endorsements', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (51, 292, N'Endorsements', N'Miscellaneous [DIVERS] Endorsements', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (52, 293, N'Endorsements', N'Miscellaneous [DIVERS] Endorsements', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (53, 294, N'Endorsements', N'Others Endorsements', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (54, 295, N'Endorsements', N'Others Endorsements', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (55, 296, N'Endorsements', N'Others Endorsements', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (56, 297, N'Endorsements', N'Others Endorsements', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (57, 360, N'Claims', N'Controller', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (58, 359, N'Claims', N'Vehicles', N'FormClaimsCars', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (59, 354, N'Claims', N'Vehicles', N'FormClaimsCompulsory', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (60, 352, N'Claims', N'Vehicles', N'FormClaimsOrangeCard', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (61, 355, N'Claims', N'Vehicles', N'FormClaimsLuxuryCars', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (62, 357, N'Claims', N'Vehicles', N'FormClaimsBoats', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (63, 348, N'Claims', N'Medical', N'FormClaimsHospitalization', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (64, 351, N'Claims', N'Medical', N'FormClaimsOut', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (65, 347, N'Claims', N'Miscellaneous', N'FormClaimsBurglary', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (66, 343, N'Claims', N'Miscellaneous', N'FormClaimsFire', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (67, 353, N'Claims', N'Miscellaneous', N'FormClaimsTravel', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (68, 346, N'Claims', N'Miscellaneous', N'FormClaimsTransport', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (69, 342, N'Claims', N'Miscellaneous', N'FormClaimsGTPL', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (70, 350, N'Claims', N'Miscellaneous', N'FormClaimsPersonalAccident', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (71, 344, N'Claims', N'Miscellaneous', N'FormClaimsContractors', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (72, 345, N'Claims', N'Others', N'FormClaimsWorkers', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (73, 349, N'Claims', N'Others', N'FormClaimsLife', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (74, 341, N'Claims', N'Others', N'FormClaimsWorkmens', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (75, 356, N'Claims', N'Others', N'FormClaimsPoliticalViolence', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (76, 361, N'Reinsurance', N'Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (77, 362, N'Reinsurance', N'Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (78, 368, N'Reinsurance', N'Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (79, 371, N'Reinsurance', N'Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (80, 367, N'Reinsurance', N'Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (81, 363, N'Reinsurance', N'Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (82, 372, N'Reinsurance', N'Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (83, 366, N'Reinsurance', N'Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (84, 370, N'Reinsurance', N'Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (85, 364, N'Reinsurance', N'Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (86, 365, N'Reinsurance', N'Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (87, 369, N'Reinsurance', N'Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (88, 374, N'Reinsurance', N'Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (89, 373, N'Reinsurance', N'Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (90, 375, N'Reinsurance', N'Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (91, 377, N'Claims Reinsurance', N'Claims Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (92, 378, N'Claims Reinsurance', N'Claims Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (93, 379, N'Claims Reinsurance', N'Claims Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (94, 380, N'Claims Reinsurance', N'Claims Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (95, 381, N'Claims Reinsurance', N'Claims Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (96, 382, N'Claims Reinsurance', N'Claims Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (97, 383, N'Claims Reinsurance', N'Claims Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (98, 384, N'Claims Reinsurance', N'Claims Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (99, 385, N'Claims Reinsurance', N'Claims Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (100, 386, N'Claims Reinsurance', N'Claims Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (101, 387, N'Claims Reinsurance', N'Claims Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (102, 388, N'Claims Reinsurance', N'Claims Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (103, 389, N'Claims Reinsurance', N'Claims Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (104, 390, N'Claims Reinsurance', N'Claims Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (105, 391, N'Claims Reinsurance', N'Claims Reinsurance', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (106, 392, N'Reports', N'Reports', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (107, 395, N'Reports', N'Reports', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (108, 400, N'Reports', N'Reports', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (109, 408, N'Reports', N'Reports', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (110, 413, N'Reports', N'Reports', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (111, 402, N'Reports', N'Reports', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (112, 411, N'Reports', N'Reports', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (113, 393, N'Reports', N'Reports', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (114, 405, N'Reports', N'Reports', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (115, 401, N'Reports', N'Reports', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (116, 412, N'Reports', N'Reports', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (117, 394, N'Reports', N'Reports', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (118, 399, N'Reports', N'Reports', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (119, 403, N'Reports', N'Reports', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (120, 404, N'Reports', N'Reports', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (121, 396, N'Reports', N'Reports', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (122, 406, N'Reports', N'Reports', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (123, 409, N'Reports', N'Reports', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (124, 407, N'Reports', N'Reports', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (125, 410, N'Reports', N'Reports', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (126, 398, N'Reports', N'Reports', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (127, 397, N'Reports', N'Reports', N'', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (128, 100, N'Tools', N'Tools', N'FormChangePassword', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (129, 222, N'Tools', N'Tools', N'efPreferences', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (130, 105, N'Tools', N'Administrator', N'efActivityLogger', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (131, 223, N'Tools', N'Administrator', N'FormSetConnections', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (132, 224, N'Tools', N'Administrator', N'FormParameters', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (133, 97, N'Tools', N'Security', N'FormDepartments', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (134, 103, N'Tools', N'Security', N'FormUsers', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (135, 225, N'Tools', N'Security', N'FormGroups', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (136, 227, N'Tools', N'Security', N'FormUserRoles', NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Forms] ([ID], [ButtonID], [Panel], [FormGroup], [FormName], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (137, 228, N'Tools', N'Security', N'FormGroupRoles', NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbs].[Forms] OFF
GO
SET IDENTITY_INSERT [dbs].[Groups] ON 

GO
INSERT [dbs].[Groups] ([ID], [Description], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (1, N'Administrators', NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbs].[Groups] OFF
GO
SET IDENTITY_INSERT [dbs].[Users] ON 

GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (32, N'WD', N'ADMINISTRATOR', N'EAAAACiXHMvz0PVEMfedo40UUiEo/4bgPJCU6LCC9bqE/rmP', NULL, NULL, 1, 0, N'', CAST(0x59950A00 AS Date), CAST(0xA4600354 AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (33, N'CH', N'Carlos Hasbani', N'EAAAAM6y7abT62BTm71d5Dc36NRYALeJ+Kw2+9CjzuapNZq5', NULL, NULL, 1, 0, N'', CAST(0x59950A00 AS Date), CAST(0xA45301F3 AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (34, N'AK', N'Antoine Kahi', N'EAAAALZT7Bv+mZlBEuaSvxRpQADRnr9z+4OL8EiaH3c0dtuH', NULL, NULL, 1, 1, N'', CAST(0x59950A00 AS Date), CAST(0x924A0312 AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (35, N'RA', N'Rita Abboud', N'EAAAAGRBC0317EGLFswAnr0Q4EkTmEKHKyBlL3mQ6OuOV2he', NULL, NULL, 3, 1, N'', CAST(0x59950A00 AS Date), CAST(0x9DB501FD AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (36, N'NM', N'Nadine Marj', N'EAAAANVPZ2GG6B7DGu9Rz2UUG4b5FcZCLJc4D7FcoWKf6bkR', NULL, NULL, 3, 0, N'', CAST(0x59950A00 AS Date), CAST(0xA45301EC AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (37, N'ZK', N'Zeina Karam', N'EAAAAIPqgzKtc4ZoDSzfV+wMTvnDHb2NA+qSH4wZyBPZg7C1', NULL, NULL, 1, 1, N'', CAST(0x59950A00 AS Date), CAST(0x94BB01EA AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (38, N'LC', N'Lydia Chedid', N'EAAAAJi/gLHH/YOea+MJKkrNt+LAbbTH386Us6q4lInY6se8', NULL, NULL, 3, 1, N'', CAST(0x59950A00 AS Date), CAST(0x9A35020F AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (39, N'JAC', N'Jacqueline Sokhn', N'EAAAADU564EWkrbeF7PtRAO1mJaOmwTm/2EAZj704wBRzcG3', NULL, NULL, 1, 0, N'', CAST(0x59950A00 AS Date), CAST(0xA3FD029B AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (40, N'GH', N'Gabriel Hajjar', N'EAAAAEffVti+ufaNmBaQ8RFp9PD36zkvWPaK2V1H7/di3E3H', NULL, NULL, 2, 0, N'', CAST(0x59950A00 AS Date), CAST(0x9E1F0257 AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (41, N'ACC', N'Rania Karam', N'EAAAAG/WOdzL2xYlYBO0+AZooMV6pL3lEwXk9a0ZzjbXJXrQ', NULL, NULL, 2, 0, N'', CAST(0x59950A00 AS Date), CAST(0xA453031E AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (42, N'RIKO', N'Richard Kassas', N'EAAAAOyRnbESRrhhjA5ya8IcAD0I96bpCvSEUEkWt5ozDpfl', NULL, NULL, 3, 1, N'', CAST(0x59950A00 AS Date), CAST(0x9E76028A AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (43, N'MART', N'Marta Melhem', N'EAAAACaolEPU3jWCuRxvSE3x/+H54Z9nvpNjxTbv8EUSaz1y', NULL, NULL, 3, 1, N'', CAST(0x59950A00 AS Date), CAST(0x94AE01E5 AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (44, N'GHAS', N'Ghassan Siriany', N'EAAAALoRgrA8STzU0bS/KQk2S1CTBkdm/+hpdJiQxI8ZZzr+', NULL, NULL, 3, 1, N'', CAST(0x59950A00 AS Date), CAST(0x9A180248 AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (45, N'MICH', N'Michele Sokhn', N'EAAAAJ5WnuWQnT1+4GMLKrlSCL6u93SckP7Bh22QaCzxQd2I', NULL, NULL, 3, 1, N'', CAST(0x96FE0A00 AS Date), CAST(0x9697024A AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (46, N'P.K', N'Pierre Khoury', N'EAAAAJXd/j6x+p8n9Vtik2r30TpWXNfz84kghg0s/B1+mn1P', NULL, NULL, 3, 0, N'', CAST(0x59950A00 AS Date), CAST(0xA02A01E9 AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (47, N'RH', N'Rabieh Silfani', N'EAAAAKvpr75t9ZSKMYepjqOOBpoNMiv1viD6w81Ek15fRYDH', NULL, NULL, 1, 1, N'', CAST(0x59950A00 AS Date), CAST(0x9944021B AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (48, N'RITA', N'Rita Abou Mansour', N'EAAAAGG002GapgonzneDwkab+mZbysZyvLerQAWEEkqPnLJs', NULL, NULL, 3, 1, N'', CAST(0x59950A00 AS Date), CAST(0xA014028C AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (49, N'JAD', N'Jad Jaber', N'EAAAANWXsZ4Tx+OWSbGDulwacm7pdzLu6EYeNluP5zV+BzYU', NULL, NULL, 3, 1, N'', CAST(0x59950A00 AS Date), CAST(0x9C7603E7 AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (50, N'HK', N'Helene Al Khoury', N'EAAAAIJhygdyMGLr9x56XW8cZhGGSvXvy9sC8BOF5BDiRMbN', NULL, NULL, 3, 1, N'', CAST(0x59950A00 AS Date), CAST(0x9D280337 AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (51, N'AKH', N'Amal Khairallah', N'EAAAAKtjvwPwGbX/WctY13yC058xtQCxqgi3OonVGLig/lkU', NULL, NULL, 1, 1, N'', CAST(0x59950A00 AS Date), CAST(0x9CE70403 AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (52, N'ELIE', N'Elie Ghanem', N'EAAAAMWdDji7YiZSVYZCsWWx/lb4CWhbNPknlsRxK6YbjWzU', NULL, NULL, 3, 1, N'', CAST(0x220B0B00 AS Date), CAST(0xA19E0209 AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (53, N'RAT', N'Rita Khoury Moussa', N'EAAAAEU0wZ3PQ3jlfhjx7c+Gydgg2i3+CHe84HGCtaPiDcec', NULL, NULL, 3, 1, N'', CAST(0xC60B0B00 AS Date), CAST(0xA2FF035D AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (54, N'R.B', N'Rabih Barouky', N'EAAAABW3cJ/8NbBtDxFqJN1CKRZ+Qq0d7aU4hx5Z0LsOX0ar', NULL, NULL, 3, 0, N'', CAST(0x59950A00 AS Date), CAST(0xA07501E7 AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (55, N'JM', N'John Masbanji', N'EAAAAI3OuZeKfp0ylSI4JwjDjfOKI5ZzLrvTQz7fIG1W2DR8', NULL, NULL, 1, 0, N'', CAST(0x59950A00 AS Date), CAST(0xA4530319 AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (56, N'ARAB', N'Mirna Georges Arab', N'EAAAAD8DhuIdxJMzoR64hgqeoXvWheixz0FS9WZBmJVBh5v7', NULL, NULL, 2, 1, N'', CAST(0x59950A00 AS Date), CAST(0x9FAD036A AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (57, N'JESY', N'Jessy Joseph Harfouche', N'EAAAAH/zLZPSu4+tWMkUVjbJlOfCUpAzlLWRT0vEQh1lJjRr', NULL, NULL, 3, 1, N'', CAST(0x50160B00 AS Date), CAST(0xA0A301E5 AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (58, N'YARA', N'Yara Richa', N'EAAAADCokTtD+Be/qeFE3AF8ma3oUvMbNSKp1Sg1/F1VKiH9', NULL, NULL, 3, 1, N'', CAST(0xAE160B00 AS Date), CAST(0xA0C80260 AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (59, N'VILM', N'Vilma Azzi', N'EAAAALd4VpVdI7auIaSOmN1QVJGgZJeOlYUrl15zSw89XrZC', NULL, NULL, 3, 1, N'', CAST(0xA10E0B00 AS Date), CAST(0xA1950252 AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (60, N'GINA', N'Gina Elie Jaber', N'EAAAAJsRUN38Z6zK0EYDrYbTQIydGXRv7El1zTvsNO/9Ing3', NULL, NULL, 3, 0, N'', CAST(0x59950A00 AS Date), CAST(0xA45301FE AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (61, N'JOE', N'Joseph Nassour', N'EAAAAKtF8Ah2ky7sSg4ZcmCw8SNoYaKxRKaXpJ6YlwDic1LA', NULL, NULL, 3, 0, N'', CAST(0x59950A00 AS Date), CAST(0xA4530207 AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (62, N'JOSE', N'Joseph Salemeh', N'EAAAAPLDR3ejIZLlAHcwu3c52NwOSim8MgDrEf/gsBBdHe0Y', NULL, NULL, 3, 0, N'', CAST(0x59950A00 AS Date), CAST(0xA45301FA AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (63, N'RC', N'Rakelle Chebel', N'EAAAAGPsndEJH3IWr/TT7FoDJXoqpJsxJDVSs/ffAuMWAmqd', NULL, NULL, 3, 1, N'', CAST(0x59950A00 AS Date), CAST(0xA3FF0397 AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (64, N'CK', N'Cynthia Kassab', N'EAAAAAH1NURtLX5tnl6LocH8qFmD5cQQIB2aF//+f4Llf6Mx', NULL, NULL, 3, 0, N'', CAST(0x59950A00 AS Date), CAST(0xA45301EE AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (65, N'SN', N'Sonia Abi Nakhoul', N'EAAAANPl4crfpIARsGTDuPQ7c+WccTSiBqCHj0fpy/uAqhBv', NULL, NULL, 1, 0, N'', CAST(0x59950A00 AS Date), CAST(0xA45402AC AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbs].[Users] ([ID], [Code], [Name], [Password], [DepartmentID], [GroupID], [LevelID], [isBlocked], [Notes], [BirthDate], [LastLogin], [CreatedByID], [CreationDate], [ModifiedByID], [ModificationDate]) VALUES (66, N'MH', N'Michel Hasbani', N'EAAAAOvk7rG36clvrzDmCPPOky1kVUA0yIxfgySQ3tx+xZzV', NULL, NULL, 1, 0, N'', CAST(0x59950A00 AS Date), CAST(0xA45702AA AS SmallDateTime), NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbs].[Users] OFF
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
