USE [NakliyeProje]
GO
/****** Object:  Table [dbo].[TblNakliye]    Script Date: 28.02.2023 20:11:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblNakliye](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ALINAN] [decimal](8, 2) NULL,
	[MASRAF] [decimal](8, 2) NULL,
	[KDVTUTAR] [decimal](8, 2) NULL,
	[KAR] [decimal](8, 2) NULL,
	[NEREDEN] [varchar](16) NULL,
	[NEREYE] [varchar](16) NULL,
	[TARİH] [date] NULL,
	[ACIKLAMA] [varchar](75) NULL,
 CONSTRAINT [PK_TblNakliye] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblToplamlar]    Script Date: 28.02.2023 20:11:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblToplamlar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TOPLAMMASRAF] [decimal](18, 2) NULL,
	[TOPLAMKDV] [decimal](18, 2) NULL,
	[TOPLAMKAR] [decimal](18, 2) NULL,
	[GENELTOPLAM] [decimal](18, 2) NULL,
 CONSTRAINT [PK_TblToplamlar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblNakliye] ON 
GO
INSERT [dbo].[TblNakliye] ([ID], [ALINAN], [MASRAF], [KDVTUTAR], [KAR], [NEREDEN], [NEREYE], [TARİH], [ACIKLAMA]) VALUES (1, CAST(1000.00 AS Decimal(8, 2)), CAST(250.00 AS Decimal(8, 2)), CAST(180.00 AS Decimal(8, 2)), CAST(570.00 AS Decimal(8, 2)), N'GEBZE', N'BAĞCILAR', CAST(N'2023-02-27' AS Date), N'DENEME')
GO
INSERT [dbo].[TblNakliye] ([ID], [ALINAN], [MASRAF], [KDVTUTAR], [KAR], [NEREDEN], [NEREYE], [TARİH], [ACIKLAMA]) VALUES (2, CAST(700.00 AS Decimal(8, 2)), CAST(250.00 AS Decimal(8, 2)), CAST(126.00 AS Decimal(8, 2)), CAST(324.00 AS Decimal(8, 2)), N'İKİTELLİ', N'DUDULLU', CAST(N'2023-02-27' AS Date), N'DENEME')
GO
INSERT [dbo].[TblNakliye] ([ID], [ALINAN], [MASRAF], [KDVTUTAR], [KAR], [NEREDEN], [NEREYE], [TARİH], [ACIKLAMA]) VALUES (3, CAST(1100.00 AS Decimal(8, 2)), CAST(320.00 AS Decimal(8, 2)), CAST(198.00 AS Decimal(8, 2)), CAST(582.00 AS Decimal(8, 2)), N'ARNAVUTKÖY', N'GEBZE', CAST(N'2023-02-28' AS Date), N'DENEME')
GO
INSERT [dbo].[TblNakliye] ([ID], [ALINAN], [MASRAF], [KDVTUTAR], [KAR], [NEREDEN], [NEREYE], [TARİH], [ACIKLAMA]) VALUES (4, CAST(1850.00 AS Decimal(8, 2)), CAST(480.00 AS Decimal(8, 2)), CAST(333.00 AS Decimal(8, 2)), CAST(1037.00 AS Decimal(8, 2)), N'ANKARA', N'İSTANBUL', CAST(N'2023-02-01' AS Date), N'DENEME')
GO
INSERT [dbo].[TblNakliye] ([ID], [ALINAN], [MASRAF], [KDVTUTAR], [KAR], [NEREDEN], [NEREYE], [TARİH], [ACIKLAMA]) VALUES (5, CAST(400.00 AS Decimal(8, 2)), CAST(100.00 AS Decimal(8, 2)), CAST(72.00 AS Decimal(8, 2)), CAST(228.00 AS Decimal(8, 2)), N'ZEYTİNBURNU', N'ÇENGELKÖY', CAST(N'2023-02-09' AS Date), N'DENEME')
GO
INSERT [dbo].[TblNakliye] ([ID], [ALINAN], [MASRAF], [KDVTUTAR], [KAR], [NEREDEN], [NEREYE], [TARİH], [ACIKLAMA]) VALUES (6, CAST(450.00 AS Decimal(8, 2)), CAST(120.00 AS Decimal(8, 2)), CAST(81.00 AS Decimal(8, 2)), CAST(249.00 AS Decimal(8, 2)), N'ÜSKÜDAR', N'SULTANBEYLİ', CAST(N'2023-02-27' AS Date), N'DENEME')
GO
INSERT [dbo].[TblNakliye] ([ID], [ALINAN], [MASRAF], [KDVTUTAR], [KAR], [NEREDEN], [NEREYE], [TARİH], [ACIKLAMA]) VALUES (7, CAST(1500.00 AS Decimal(8, 2)), CAST(400.00 AS Decimal(8, 2)), CAST(270.00 AS Decimal(8, 2)), CAST(830.00 AS Decimal(8, 2)), N'İZMİR', N'İSTANBUL', CAST(N'2023-02-27' AS Date), N'DENEME')
GO
INSERT [dbo].[TblNakliye] ([ID], [ALINAN], [MASRAF], [KDVTUTAR], [KAR], [NEREDEN], [NEREYE], [TARİH], [ACIKLAMA]) VALUES (8, CAST(1200.00 AS Decimal(8, 2)), CAST(350.00 AS Decimal(8, 2)), CAST(216.00 AS Decimal(8, 2)), CAST(634.00 AS Decimal(8, 2)), N'BURSA', N'İSTANBUL', CAST(N'2023-02-23' AS Date), N'DENEME')
GO
SET IDENTITY_INSERT [dbo].[TblNakliye] OFF
GO