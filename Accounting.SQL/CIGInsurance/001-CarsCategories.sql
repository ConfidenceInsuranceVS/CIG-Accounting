USE [CIGinsurance]
GO
/****** Object:  Table [dbo].[CarsCategories]    Script Date: 03/05/2015 7:36:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarsCategories](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](2) NULL,
	[Description] [nvarchar](100) NULL,
	[ArabicDescription] [nvarchar](100) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[CarsCategories] ON 

GO
INSERT [dbo].[CarsCategories] ([ID], [Code], [Description], [ArabicDescription]) VALUES (1, N'01', N'Private cars
', N'السبارات السياحية الخصوصية
')
GO
INSERT [dbo].[CarsCategories] ([ID], [Code], [Description], [ArabicDescription]) VALUES (2, N'02', N'Taxis
', N'سيارات التكسي السياحية
')
GO
INSERT [dbo].[CarsCategories] ([ID], [Code], [Description], [ArabicDescription]) VALUES (3, N'03', N'Private Buses & School Buses up to 11 passengers
', N'سيارات الباص الخاصة وباصات المدارس حتى 11 راكباً
')
GO
INSERT [dbo].[CarsCategories] ([ID], [Code], [Description], [ArabicDescription]) VALUES (4, N'04', N'Private Buses & School Buses between 12 and 24 passengers
', N'سيارات الباص الخاصة وباصات المدارس بين 12 و24 راكباً
')
GO
INSERT [dbo].[CarsCategories] ([ID], [Code], [Description], [ArabicDescription]) VALUES (5, N'05', N'Private Buses & School Buses 25 passengers and above
', N'سيارات الباص الخاصة وباصات المدارس 25 راكباً وما فوق
')
GO
INSERT [dbo].[CarsCategories] ([ID], [Code], [Description], [ArabicDescription]) VALUES (6, N'06', N'Public Buses up to 11 passengers
', N'باصات النقل العام حتى 11 راكباً
')
GO
INSERT [dbo].[CarsCategories] ([ID], [Code], [Description], [ArabicDescription]) VALUES (7, N'07', N'Public Buses between 12 and 24 passengers
', N'باصات النقل العام بين 12 و24 راكباً
')
GO
INSERT [dbo].[CarsCategories] ([ID], [Code], [Description], [ArabicDescription]) VALUES (8, N'08', N'Public Buses 25 passengers and above
', N'باصات النقل العام 25 راكباً وما فوق
')
GO
INSERT [dbo].[CarsCategories] ([ID], [Code], [Description], [ArabicDescription]) VALUES (9, N'09', N'Private Pickups, Commercial Pickups, Transport Vans transport, Ads Vans
', N'سيارات البيك اب الخصوصية، سيارات البيك اب التجارية، فانات النقل، وفانات الإعلانات
')
GO
INSERT [dbo].[CarsCategories] ([ID], [Code], [Description], [ArabicDescription]) VALUES (10, N'10', N'Private and Public Trucks, Tanks for the transfer of non-inflammable materials
', N'الشاحنات الخصوصية والعمومية والصهاريج المعدة لنقل مواد غير قابلة الإشتعال
')
GO
INSERT [dbo].[CarsCategories] ([ID], [Code], [Description], [ArabicDescription]) VALUES (11, N'11', N'Tractors, Bulldozers,  Water Excavators and any similar vehicles
', N'التراكتورات والبولدوزير والجرافات وحفارات المياه وسائر الآليات الماثلة
')
GO
INSERT [dbo].[CarsCategories] ([ID], [Code], [Description], [ArabicDescription]) VALUES (12, N'12', N'Tankers and oil tankers and fuels and burning hazardous materials

', N'اقلات وصهاريج البترول والمحروقات والمواد المشتعلة والمواد الخطرة 
')
GO
INSERT [dbo].[CarsCategories] ([ID], [Code], [Description], [ArabicDescription]) VALUES (13, N'13', N'Motorcycle

', N'الدراجات النارية')
GO
INSERT [dbo].[CarsCategories] ([ID], [Code], [Description], [ArabicDescription]) VALUES (14, N'14', N'Ambulances and civil defense vehicles and Driving
', N'سيارات الإسعاف والدفاع المدني وسيارات تعليم القيادة 
')
GO
INSERT [dbo].[CarsCategories] ([ID], [Code], [Description], [ArabicDescription]) VALUES (15, N'15', N'Rental cars
', N'سيارات الإيجار
')
GO
SET IDENTITY_INSERT [dbo].[CarsCategories] OFF
GO
