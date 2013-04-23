USE [cjwygl]
GO

/****** Object:  Table [dbo].[CONTRACT_INFO]    Script Date: 04/23/2013 21:09:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CONTRACT_INFO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[COMP_NAME] [nvarchar](255) NOT NULL,
	[CONTRACT_NO] [nvarchar](255) NULL,
	[START_DATE] [datetime] NULL,
	[END_DATE] [datetime] NULL,
	[RENT_AREA] [real] NULL,
	[CORP_REP] [nvarchar](50) NULL,
	[CONTACT] [nvarchar](50) NULL,
	[TELEPHONE] [nvarchar](50) NULL,
	[MOBILE] [nvarchar](50) NULL,
	[CAPITAL] [real] NULL,
	[PLACE] [nvarchar](255) NULL,
	[TAX_ID] [nvarchar](50) NULL,
	[IC_ID] [nvarchar](50) NULL,
	[ORG_CODE] [nvarchar](50) NULL,
	[CATEGORY] [nvarchar](50) NULL,
	[MAIN_BUZZ] [nvarchar](255) NULL,
	[TERMINATE] [bit] NULL,
	[COMMENT] [nvarchar](255) NULL,
	[MODIFY_COMMENT] [nvarchar](max) NULL,
 CONSTRAINT [PK_CONTRACT_INFO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

