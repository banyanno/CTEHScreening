USE [TEHScreening]
GO

/****** Object:  Table [dbo].[SCREENING_BOOK]    Script Date: 08/23/2018 16:14:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SCREENING_BOOK](
	[SCREEN_BOOKID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[SCREEN_ID] [numeric](18, 0) NULL,
	[PATIENT_NO] [numeric](18, 0) NULL,
	[IS_REFRACTION] [bit] NULL,
	[IS_OPTICALSHOP] [bit] NULL,
	[IS_REFER_PICKUP] [bit] NULL,
	[IS_REFER_BYSELF] [bit] NULL,
 CONSTRAINT [PK_SCREENING_BOOK] PRIMARY KEY CLUSTERED 
(
	[SCREEN_BOOKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

'================================================================================

USE [TEHScreening]
GO

/****** Object:  Table [dbo].[SCREEN_SYSTEMSETTING]    Script Date: 08/23/2018 16:14:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SCREEN_SYSTEMSETTING](
	[SETTING_ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[SETTING_DATE] [datetime] NULL,
	[HEALTH_NAME] [nvarchar](150) NULL,
	[PROVINCE] [nvarchar](50) NULL,
	[DISTRICT] [nvarchar](50) NULL,
	[COMMUNE] [nvarchar](50) NULL,
	[FULL_ADDRESS] [nvarchar](50) NULL,
	[IS_DEFOUL] [bit] NULL,
	[BOOK_NOTE] [nvarchar](250) NULL,
 CONSTRAINT [PK_SCREEN_SYSTEMSETTING] PRIMARY KEY CLUSTERED 
(
	[SETTING_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[SCREEN_SYSTEMSETTING] ADD  CONSTRAINT [DF_SCREEN_SYSTEMSETTING_IS_DEFOUL]  DEFAULT ((0)) FOR [IS_DEFOUL]
GO

