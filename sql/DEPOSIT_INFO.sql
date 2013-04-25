USE [cjwygl]
GO
/****** Object:  Table [dbo].[DEPOSIT_INFO]    Script Date: 04/25/2013 09:35:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DEPOSIT_INFO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[COMP_ID] [int] NULL,
	[SUM] [real] NULL,
	[RETURNED] [bit] NULL,
 CONSTRAINT [PK_DEPOSIT_INFO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
