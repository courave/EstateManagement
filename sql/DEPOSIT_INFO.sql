USE [cjwygl]
GO

/****** Object:  Table [dbo].[DEPOSIT_INFO]    Script Date: 05/05/2013 01:02:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DEPOSIT_INFO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[COMP_ID] [int] NULL,
	[SUM] [real] NULL,
	[RETURNED] [bit] NULL,
	[MODIFY_COMMENT] [nvarchar](max) NULL,
 CONSTRAINT [PK_DEPOSIT_INFO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
