USE [cjwygl]
GO
/****** Object:  Table [dbo].[PARKING_INFO]    Script Date: 04/25/2013 09:36:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PARKING_INFO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CAR_PLATE] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[ID_CODE] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[COMP_ID] [int] NULL,
	[ROOM_ID] [int] NULL,
	[TELE] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[START_DATE] [datetime] NULL,
	[END_DATE] [datetime] NULL,
	[PRICE_MONTH] [real] NULL,
	[LOCATION] [nvarchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[REMARK] [nvarchar](255) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_PARKING_INFO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
