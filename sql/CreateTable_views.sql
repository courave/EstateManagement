SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CJ_ADMIN]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CJ_ADMIN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[USERNAME] [nvarchar](255) NOT NULL,
	[PASSWORD] [nvarchar](255) NULL,
	[NICKNAME] [nvarchar](255) NULL,
	[ROLE_ID] [int] NOT NULL,
 CONSTRAINT [PK_CJ_ADMIN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CJ_ROLE]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CJ_ROLE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ROLE_NAME] [nvarchar](255) NULL,
	[PERMISSIONS] [nvarchar](max) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CJ_MISC_FEE]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CJ_MISC_FEE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FEE_TYPE] [nvarchar](255) NULL,
	[CB_NUM] [real] NULL,
	[CB_TIME] [datetime] NULL,
	[CB_FEE] [real] NULL,
	[CB_EMPLOYEE] [nvarchar](255) NULL,
	[CB_COMMENT] [nvarchar](max) NULL,
	[OP_NAME] [nvarchar](255) NULL,
	[OP_ID] [int] NULL,
	[LOG_TIME] [datetime] NULL,
	[MODIFY_COMMENT] [nvarchar](max) NULL,
	[LAST_MODUFY_DATE] [datetime] NULL,
	[COMPANY_ID] [int] NOT NULL,
	[IS_PAID] [bit] NOT NULL CONSTRAINT [DF_CJ_MISC_FEE_IS_PAID]  DEFAULT ((0)),
 CONSTRAINT [PK_CJ_MISC_FEE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CJ_MAIN_FEE]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CJ_MAIN_FEE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FEE_TYPE] [nvarchar](255) NULL,
	[FEE] [real] NULL,
	[LAST_END] [datetime] NULL,
	[NEXT_START] [datetime] NULL,
	[COMMENT] [nvarchar](max) NULL,
	[OP_NAME] [nvarchar](255) NULL,
	[OP_ID] [int] NULL,
	[LOG_TIME] [datetime] NULL,
	[LAST_MODIFY_DATE] [datetime] NULL,
	[MODIFY_COMMENT] [nvarchar](max) NULL,
	[COMPANY_ID] [int] NOT NULL,
	[IS_PAID] [bit] NOT NULL CONSTRAINT [DF_CJ_MAIN_FEE_IS_PAID]  DEFAULT ((0)),
	[GEN_MONTH] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CJ_MAIN_FEE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ROOM_INFO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ROOM_INFO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ROOM_NO] [nvarchar](50) NOT NULL,
	[LOCATION] [nvarchar](255) NULL,
	[REMARK] [nvarchar](255) NULL,
	[COMP_ID] [int] NULL,
	[HASCOMP] [bit] NULL CONSTRAINT [DF_ROOM_INFO_HASCOMP]  DEFAULT ((0)),
 CONSTRAINT [PK_ROOM_INFO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PARKING_INFO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PARKING_INFO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CAR_PLATE] [nvarchar](50) NULL,
	[ID_CODE] [nvarchar](50) NULL,
	[COMP_ID] [int] NULL,
	[ROOM_ID] [int] NULL,
	[TELE] [nvarchar](50) NULL,
	[START_DATE] [datetime] NULL,
	[END_DATE] [datetime] NULL,
	[PRICE_MONTH] [real] NULL,
	[LOCATION] [nvarchar](255) NULL,
	[REMARK] [nvarchar](255) NULL,
	[CAR_USER] [nvarchar](50) NULL,
	[TERMINATE] [bit] NULL CONSTRAINT [DF_PARKING_INFO_TERMINATE]  DEFAULT ((0)),
 CONSTRAINT [PK_PARKING_INFO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DEPOSIT_INFO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DEPOSIT_INFO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[COMP_ID] [int] NULL,
	[SUM] [real] NULL,
	[RETURNED] [bit] NULL,
	[MODIFY_COMMENT] [nvarchar](max) NULL,
 CONSTRAINT [PK_DEPOSIT_INFO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PRED_CHARGE]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PRED_CHARGE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[COMP_ID] [int] NULL,
	[CHARGE_TYPE] [nvarchar](50) NULL,
	[SUM_MONTH] [real] NULL,
	[INTERVAL] [int] NULL,
 CONSTRAINT [PK_PRED_CHARGE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CONTRACT_INFO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CONTRACT_INFO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[COMP_NAME] [nvarchar](255) NULL,
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
	[TERMINATE] [bit] NULL CONSTRAINT [DF_CONTRACT_INFO_TERMINATE]  DEFAULT ((0)),
	[MODIFY_COMMENT] [nvarchar](max) NULL,
	[COMMENT] [nvarchar](255) NULL,
 CONSTRAINT [PK_CONTRACT_INFO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SDM_INFO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[SDM_INFO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SDM_TYPE] [nvarchar](50) NULL,
	[SDM_SUM] [real] NULL,
	[SDM_CHARGE] [real] NULL,
	[SDM_TIME] [datetime] NULL,
	[COMP_ID] [int] NULL,
	[ISPAID] [bit] NULL CONSTRAINT [DF_sdm_info_ISPAID]  DEFAULT ((0)),
	[COMMENT] [nvarchar](500) NULL,
	[SDM_CBER] [nvarchar](50) NULL,
	[ROOM_ID] [int] NULL,
 CONSTRAINT [PK_sdm_info] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SDM_BASE]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[SDM_BASE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SDM_TYPE] [nvarchar](50) NOT NULL,
	[SDM_UNIT] [real] NOT NULL,
 CONSTRAINT [PK_SDM_BASE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FEE_INFO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[FEE_INFO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FEE_TYPE] [nvarchar](50) NULL,
	[FEE_CHARGE] [real] NULL,
	[LAST_END] [datetime] NULL,
	[NEXT_START] [datetime] NULL,
	[COMP_ID] [int] NULL,
	[COMMENT] [nvarchar](500) NULL,
	[GEN_MONTH] [nvarchar](50) NULL,
	[ISPAID] [bit] NULL CONSTRAINT [DF_FEE_INFO_ISPAID]  DEFAULT ((0)),
 CONSTRAINT [PK_FEE_INFO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CJ_FEE_BASE]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CJ_FEE_BASE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UNIT_NAME] [nvarchar](255) NULL,
	[UNIT_PRICE] [real] NULL,
	[COMMENT] [nvarchar](max) NULL,
 CONSTRAINT [PK_CJ_FEE_BASE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CJ_CUSTOMER_INFO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CJ_CUSTOMER_INFO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ROOM_NO] [nvarchar](255) NULL,
	[COMPANY_NAME] [nvarchar](255) NULL,
	[CONTRACT_NO] [nvarchar](255) NULL,
	[CONTRACT_START_DATE] [datetime] NULL,
	[CONTRACT_END_DATE] [datetime] NULL,
	[RENT_AREA] [real] NULL,
	[MONTHLY_RENTAL] [real] NULL,
	[WUYE] [real] NULL,
	[YEARLY_RENTAL] [real] NULL,
	[PARKING_COUNT] [real] NULL,
	[PARKING_DETAIL] [nvarchar](255) NULL,
	[CORP_REP] [nvarchar](255) NULL,
	[CONTACT] [nvarchar](255) NULL,
	[OFFICE_TELEORFAX] [nvarchar](255) NULL,
	[MOBILE_PHONE] [nvarchar](255) NULL,
	[REGISTERED_CAPITAL] [real] NULL,
	[REGISTERED_PLACE] [nvarchar](255) NULL,
	[TAX_ID] [nvarchar](255) NULL,
	[IC_ID] [nvarchar](255) NULL,
	[ORG_CODE] [nvarchar](255) NULL,
	[INDUSTRY_CATEGORY] [nvarchar](255) NULL,
	[MAIN_BUZZ] [nvarchar](255) NULL,
	[OP_NAME] [nvarchar](255) NULL,
	[OP_ID] [int] NULL,
	[LOG_TIME] [datetime] NULL,
	[LAST_MODIFY_DATE] [datetime] NULL,
	[MODIFY_COMENT] [nvarchar](max) NULL,
	[CONTRACT_TERMINATE] [bit] NOT NULL CONSTRAINT [DF_CJ_CUSTOMER_INFO_CONTRACT_TERMINATE]  DEFAULT ((0)),
 CONSTRAINT [PK_CJ_CUSTOMER_INFO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[View_ADMIN_ROLE]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[View_ADMIN_ROLE]
AS
SELECT     dbo.CJ_ADMIN.ID, dbo.CJ_ADMIN.USERNAME, dbo.CJ_ADMIN.NICKNAME, dbo.CJ_ROLE.ROLE_NAME, dbo.CJ_ROLE.PERMISSIONS
FROM         dbo.CJ_ADMIN INNER JOIN
                      dbo.CJ_ROLE ON dbo.CJ_ADMIN.ROLE_ID = dbo.CJ_ROLE.ID
' 
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'View_ADMIN_ROLE', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "CJ_ADMIN"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 184
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "CJ_ROLE"
            Begin Extent = 
               Top = 6
               Left = 222
               Bottom = 110
               Right = 379
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ADMIN_ROLE'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'View_ADMIN_ROLE', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ADMIN_ROLE'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[View_SINGLE_FEE]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[View_SINGLE_FEE]
AS
SELECT     dbo.CJ_CUSTOMER_INFO.COMPANY_NAME, dbo.CJ_MISC_FEE.ID, dbo.CJ_MISC_FEE.FEE_TYPE, dbo.CJ_MISC_FEE.CB_NUM, dbo.CJ_MISC_FEE.CB_TIME, 
                      dbo.CJ_MISC_FEE.CB_FEE, dbo.CJ_MISC_FEE.CB_EMPLOYEE, dbo.CJ_MISC_FEE.CB_COMMENT, dbo.CJ_MISC_FEE.OP_NAME, dbo.CJ_MISC_FEE.OP_ID, 
                      dbo.CJ_MISC_FEE.LOG_TIME, dbo.CJ_MISC_FEE.MODIFY_COMMENT, dbo.CJ_MISC_FEE.LAST_MODUFY_DATE
FROM         dbo.CJ_CUSTOMER_INFO INNER JOIN
                      dbo.CJ_MISC_FEE ON dbo.CJ_CUSTOMER_INFO.ID = dbo.CJ_MISC_FEE.COMPANY_ID
' 
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'View_SINGLE_FEE', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "CJ_CUSTOMER_INFO"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 252
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CJ_MISC_FEE"
            Begin Extent = 
               Top = 6
               Left = 290
               Bottom = 125
               Right = 483
            End
            DisplayFlags = 280
            TopColumn = 9
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_SINGLE_FEE'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'View_SINGLE_FEE', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_SINGLE_FEE'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[View_MAIN_FEE_REPORT]'))
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [dbo].[View_MAIN_FEE_REPORT]
AS
SELECT     CUSTOMER.ID, CUSTOMER.CONTRACT_NO, CUSTOMER.COMPANY_NAME, CUSTOMER.ROOM_NO, FZ.GEN_MONTH, FZ.IS_PAID, CONVERT(nvarchar(8), 
                      DATEADD(DAY, - 1, FZ.LAST_END), 2) AS DATE_PREV, CONVERT(nvarchar(8), FZ.LAST_END, 2) + ''-'' + CONVERT(nvarchar(8), DATEADD(DAY, - 1, FZ.NEXT_START), 2) 
                      AS DATE_CURRENT, CONVERT(nvarchar(8), FZ.NEXT_START, 2) AS DATE_NEXT, FZ.LAST_END AS FZ_LE, FZ.NEXT_START AS FZ_NS, FZ.FEE AS FZ_FEE, 
                      FZ.COMMENT AS FZ_COMMENT, FWF.LAST_END AS FWF_LE, FWF.NEXT_START AS FWF_NS, FWF.FEE AS FWF_FEE, FWF.COMMENT AS FWF_COMMENT, 
                      WY.LAST_END AS WY_LE, WY.NEXT_START AS WY_NS, WY.FEE AS WY_FEE, WY.COMMENT AS WY_COMMENT, WL.LAST_END AS WL_LE, 
                      WL.NEXT_START AS WL_NS, WL.FEE AS WL_FEE, WL.COMMENT AS WL_COMMENT, CW.LAST_END AS CW_LE, CW.NEXT_START AS CW_NS, CW.FEE AS CW_FEE, 
                      CW.COMMENT AS CW_COMMENT, FY.LAST_END AS FY_LE, FY.NEXT_START AS FY_NS, FY.FEE AS FY_FEE, FY.COMMENT AS FY_COMMENT, 
                      SF.LAST_END AS SF_LE, SF.NEXT_START AS SF_NS, SF.FEE AS SF_FEE, SF.COMMENT AS SF_COMMENT, DF.LAST_END AS DF_LE, DF.NEXT_START AS DF_NS, 
                      DF.FEE AS DF_FEE, DF.COMMENT AS DF_COMMENT, ISNULL(FZ.FEE, 0) + ISNULL(FWF.FEE, 0) + ISNULL(WY.FEE, 0) + ISNULL(WL.FEE, 0) + ISNULL(CW.FEE, 0) 
                      + ISNULL(FY.FEE, 0) + ISNULL(SF.FEE, 0) + ISNULL(DF.FEE, 0) AS TOTAL_FEE
FROM         (SELECT     FEE, LAST_END, NEXT_START, COMMENT, COMPANY_ID, IS_PAID, GEN_MONTH
                       FROM          dbo.CJ_MAIN_FEE
                       WHERE      (FEE_TYPE = ''房租'')) AS FZ LEFT OUTER JOIN
                          (SELECT     ID, ROOM_NO, COMPANY_NAME, CONTRACT_NO
                            FROM          dbo.CJ_CUSTOMER_INFO) AS CUSTOMER ON FZ.COMPANY_ID = CUSTOMER.ID LEFT OUTER JOIN
                          (SELECT     FEE, LAST_END, NEXT_START, COMMENT, COMPANY_ID, IS_PAID, GEN_MONTH
                            FROM          dbo.CJ_MAIN_FEE AS CJ_MAIN_FEE_7
                            WHERE      (FEE_TYPE = ''服务费'')) AS FWF ON FZ.COMPANY_ID = FWF.COMPANY_ID AND FZ.GEN_MONTH = FWF.GEN_MONTH LEFT OUTER JOIN
                          (SELECT     FEE, LAST_END, NEXT_START, COMMENT, COMPANY_ID, IS_PAID, GEN_MONTH
                            FROM          dbo.CJ_MAIN_FEE AS CJ_MAIN_FEE_6
                            WHERE      (FEE_TYPE = ''物业'')) AS WY ON FZ.COMPANY_ID = WY.COMPANY_ID AND FZ.GEN_MONTH = WY.GEN_MONTH LEFT OUTER JOIN
                          (SELECT     FEE, LAST_END, NEXT_START, COMMENT, COMPANY_ID, IS_PAID, GEN_MONTH
                            FROM          dbo.CJ_MAIN_FEE AS CJ_MAIN_FEE_5
                            WHERE      (FEE_TYPE = ''网络'')) AS WL ON FZ.COMPANY_ID = WL.COMPANY_ID AND FZ.GEN_MONTH = WL.GEN_MONTH LEFT OUTER JOIN
                          (SELECT     FEE, LAST_END, NEXT_START, COMMENT, COMPANY_ID, IS_PAID, GEN_MONTH
                            FROM          dbo.CJ_MAIN_FEE AS CJ_MAIN_FEE_4
                            WHERE      (FEE_TYPE = ''车位'')) AS CW ON FZ.COMPANY_ID = CW.COMPANY_ID AND FZ.GEN_MONTH = CW.GEN_MONTH LEFT OUTER JOIN
                          (SELECT     FEE, LAST_END, NEXT_START, COMMENT, COMPANY_ID, IS_PAID, GEN_MONTH
                            FROM          dbo.CJ_MAIN_FEE AS CJ_MAIN_FEE_3
                            WHERE      (FEE_TYPE = ''复印'')) AS FY ON FZ.COMPANY_ID = FY.COMPANY_ID AND FZ.GEN_MONTH = FY.GEN_MONTH LEFT OUTER JOIN
                          (SELECT     FEE, LAST_END, NEXT_START, COMMENT, COMPANY_ID, IS_PAID, GEN_MONTH
                            FROM          dbo.CJ_MAIN_FEE AS CJ_MAIN_FEE_2
                            WHERE      (FEE_TYPE = ''水费'')) AS SF ON FZ.COMPANY_ID = SF.COMPANY_ID AND FZ.GEN_MONTH = SF.GEN_MONTH LEFT OUTER JOIN
                          (SELECT     FEE, LAST_END, NEXT_START, COMMENT, COMPANY_ID, IS_PAID, GEN_MONTH
                            FROM          dbo.CJ_MAIN_FEE AS CJ_MAIN_FEE_1
                            WHERE      (FEE_TYPE = ''电费'')) AS DF ON FZ.COMPANY_ID = DF.COMPANY_ID AND FZ.GEN_MONTH = DF.GEN_MONTH

' 
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'View_MAIN_FEE_REPORT', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "FZ"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 193
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CUSTOMER"
            Begin Extent = 
               Top = 6
               Left = 231
               Bottom = 125
               Right = 403
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "FWF"
            Begin Extent = 
               Top = 6
               Left = 441
               Bottom = 125
               Right = 596
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "WY"
            Begin Extent = 
               Top = 6
               Left = 634
               Bottom = 125
               Right = 789
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "WL"
            Begin Extent = 
               Top = 126
               Left = 38
               Bottom = 245
               Right = 193
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CW"
            Begin Extent = 
               Top = 126
               Left = 231
               Bottom = 245
               Right = 386
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "FY"
            Begin Extent = 
               Top = 126
               Left = 424
               Bottom = 245
               Right = 579
            End
            DisplayFlags = 280
            TopColumn = 0
   ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_MAIN_FEE_REPORT'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'View_MAIN_FEE_REPORT', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'      End
         Begin Table = "SF"
            Begin Extent = 
               Top = 126
               Left = 617
               Bottom = 245
               Right = 772
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DF"
            Begin Extent = 
               Top = 126
               Left = 810
               Bottom = 245
               Right = 965
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_MAIN_FEE_REPORT'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'View_MAIN_FEE_REPORT', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_MAIN_FEE_REPORT'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[View_FEE_REPORT]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[View_FEE_REPORT]
AS
SELECT     CUSTOMER.ID, CUSTOMER.CONTRACT_NO, CUSTOMER.COMP_NAME, ROOMINFO.ROOMNO, FZ.GEN_MONTH, FZ.ISPAID, CONVERT(nvarchar(8), DATEADD(DAY, - 1, 
                      FZ.LAST_END), 2) AS DATE_PREV, CONVERT(nvarchar(8), FZ.LAST_END, 2) + ''-'' + CONVERT(nvarchar(8), DATEADD(DAY, - 1, FZ.NEXT_START), 2) AS DATE_CURRENT, 
                      CONVERT(nvarchar(8), FZ.NEXT_START, 2) AS DATE_NEXT, FZ.LAST_END AS FZ_LE, FZ.NEXT_START AS FZ_NS, FZ.FEE_CHARGE AS FZ_FEE, 
                      FZ.COMMENT AS FZ_COMMENT, FWF.LAST_END AS FWF_LE, FWF.NEXT_START AS FWF_NS, FWF.FEE_CHARGE AS FWF_FEE, 
                      FWF.COMMENT AS FWF_COMMENT, WY.LAST_END AS WY_LE, WY.NEXT_START AS WY_NS, WY.FEE_CHARGE AS WY_FEE, WY.COMMENT AS WY_COMMENT, 
                      WL.LAST_END AS WL_LE, WL.NEXT_START AS WL_NS, WL.FEE_CHARGE AS WL_FEE, WL.COMMENT AS WL_COMMENT, CW.LAST_END AS CW_LE, 
                      CW.NEXT_START AS CW_NS, CW.FEE_CHARGE AS CW_FEE, CW.COMMENT AS CW_COMMENT, MQF.LAST_END AS MQF_LE, MQF.NEXT_START AS MQF_NS, 
                      MQF.FEE_CHARGE AS MQF_FEE, MQF.COMMENT AS MQF_COMMENT, SF.LAST_END AS SF_LE, SF.NEXT_START AS SF_NS, SF.FEE_CHARGE AS SF_FEE, 
                      SF.COMMENT AS SF_COMMENT, DF.LAST_END AS DF_LE, DF.NEXT_START AS DF_NS, DF.FEE_CHARGE AS DF_FEE, DF.COMMENT AS DF_COMMENT, 
                      QITA.LAST_END AS QITA_LE, QITA.NEXT_START AS QITA_NS, QITA.FEE_CHARGE AS QITA_FEE, QITA.COMMENT AS QITA_COMMENT, ISNULL(FZ.FEE_CHARGE, 0) 
                      + ISNULL(FWF.FEE_CHARGE, 0) + ISNULL(WY.FEE_CHARGE, 0) + ISNULL(WL.FEE_CHARGE, 0) + ISNULL(CW.FEE_CHARGE, 0) + ISNULL(MQF.FEE_CHARGE, 0) 
                      + ISNULL(SF.FEE_CHARGE, 0) + ISNULL(DF.FEE_CHARGE, 0) + ISNULL(QITA.FEE_CHARGE, 0) AS TOTAL_FEE
FROM         (SELECT     FEE_CHARGE, LAST_END, NEXT_START, COMMENT, COMP_ID, ISPAID, GEN_MONTH
                       FROM          dbo.FEE_INFO
                       WHERE      (FEE_TYPE = ''房租'')) AS FZ LEFT OUTER JOIN
                          (SELECT     ID, COMP_NAME, CONTRACT_NO
                            FROM          dbo.CONTRACT_INFO) AS CUSTOMER ON FZ.COMP_ID = CUSTOMER.ID LEFT OUTER JOIN
                          (SELECT     FEE_CHARGE, LAST_END, NEXT_START, COMMENT, COMP_ID, ISPAID, GEN_MONTH
                            FROM          dbo.FEE_INFO AS CJ_MAIN_FEE_7
                            WHERE      (FEE_TYPE = ''服务费'')) AS FWF ON FZ.COMP_ID = FWF.COMP_ID AND FZ.GEN_MONTH = FWF.GEN_MONTH LEFT OUTER JOIN
                          (SELECT     FEE_CHARGE, LAST_END, NEXT_START, COMMENT, COMP_ID, ISPAID, GEN_MONTH
                            FROM          dbo.FEE_INFO AS CJ_MAIN_FEE_6
                            WHERE      (FEE_TYPE = ''物业费'')) AS WY ON FZ.COMP_ID = WY.COMP_ID AND FZ.GEN_MONTH = WY.GEN_MONTH LEFT OUTER JOIN
                          (SELECT     FEE_CHARGE, LAST_END, NEXT_START, COMMENT, COMP_ID, ISPAID, GEN_MONTH
                            FROM          dbo.FEE_INFO AS CJ_MAIN_FEE_5
                            WHERE      (FEE_TYPE = ''网络费'')) AS WL ON FZ.COMP_ID = WL.COMP_ID AND FZ.GEN_MONTH = WL.GEN_MONTH LEFT OUTER JOIN
                          (SELECT     FEE_CHARGE, LAST_END, NEXT_START, COMMENT, COMP_ID, ISPAID, GEN_MONTH
                            FROM          dbo.FEE_INFO AS CJ_MAIN_FEE_4
                            WHERE      (FEE_TYPE = ''车位费'')) AS CW ON FZ.COMP_ID = CW.COMP_ID AND FZ.GEN_MONTH = CW.GEN_MONTH LEFT OUTER JOIN
                          (SELECT     FEE_CHARGE, LAST_END, NEXT_START, COMMENT, COMP_ID, ISPAID, GEN_MONTH
                            FROM          dbo.FEE_INFO AS CJ_MAIN_FEE_3
                            WHERE      (FEE_TYPE = ''煤气费'')) AS MQF ON FZ.COMP_ID = MQF.COMP_ID AND FZ.GEN_MONTH = MQF.GEN_MONTH LEFT OUTER JOIN
                          (SELECT     FEE_CHARGE, LAST_END, NEXT_START, COMMENT, COMP_ID, ISPAID, GEN_MONTH
                            FROM          dbo.FEE_INFO AS CJ_MAIN_FEE_2
                            WHERE      (FEE_TYPE = ''水费'')) AS SF ON FZ.COMP_ID = SF.COMP_ID AND FZ.GEN_MONTH = SF.GEN_MONTH LEFT OUTER JOIN
                          (SELECT     FEE_CHARGE, LAST_END, NEXT_START, COMMENT, COMP_ID, ISPAID, GEN_MONTH
                            FROM          dbo.FEE_INFO AS CJ_MAIN_FEE_1
                            WHERE      (FEE_TYPE = ''电费'')) AS DF ON FZ.COMP_ID = DF.COMP_ID AND FZ.GEN_MONTH = DF.GEN_MONTH LEFT OUTER JOIN
                          (SELECT DISTINCT BB.FEE_CHARGE, NULL AS LAST_END, NULL AS NEXT_START, AA.COMMENT, AA.COMP_ID, 0 AS ISPAID, AA.GEN_MONTH
                            FROM          (SELECT DISTINCT BBB.COMP_ID, BBB.GEN_MONTH,
                                                                               (SELECT     AAA.FEE_TYPE + '':'' + CONVERT(NVARCHAR(50), AAA.FEE_CHARGE) + '';''
                                                                                 FROM          DBO.FEE_INFO AS AAA
                                                                                 WHERE      (FEE_TYPE <> ''电费'') AND (FEE_TYPE <> ''房租'') AND (FEE_TYPE <> ''服务费'') AND (FEE_TYPE <> ''物业费'') AND 
                                                                                                        (FEE_TYPE <> ''网络费'') AND (FEE_TYPE <> ''车位费'') AND (FEE_TYPE <> ''煤气费'') AND (FEE_TYPE <> ''水费'') AND 
                                                                                                        AAA.COMP_ID = BBB.COMP_ID AND AAA.GEN_MONTH = BBB.GEN_MONTH FOR XML PATH('''')) COMMENT
                                                    FROM          FEE_INFO BBB) AS AA,
                                                       (SELECT     SUM(FEE_CHARGE) AS FEE_CHARGE, COMP_ID, GEN_MONTH
                                                         FROM          DBO.FEE_INFO AS FEE_INFO_1
                                                         WHERE      (FEE_TYPE <> ''电费'') AND (FEE_TYPE <> ''房租'') AND (FEE_TYPE <> ''服务费'') AND (FEE_TYPE <> ''物业费'') AND (FEE_TYPE <> ''网络费'') 
                                                                                AND (FEE_TYPE <> ''车位费'') AND (FEE_TYPE <> ''煤气费'') AND (FEE_TYPE <> ''水费'')
                                                         GROUP BY COMP_ID, GEN_MONTH) AS BB
                            WHERE      AA.COMP_ID = BB.COMP_ID AND AA.GEN_MONTH = BB.GEN_MONTH) AS QITA ON FZ.COMP_ID = QITA.COMP_ID AND 
                      FZ.GEN_MONTH = QITA.GEN_MONTH LEFT OUTER JOIN
                          (SELECT DISTINCT MROOM1.COMP_ID,
                                                       (SELECT     MROOM2.ROOM_NO + '';'' AS [text()]
                                                         FROM          ROOM_INFO MROOM2
                                                         WHERE      MROOM2.COMP_ID = MROOM1.COMP_ID
                                                         ORDER BY MROOM2.COMP_ID FOR XML PATH('''')) ROOMNO
                            FROM          ROOM_INFO MROOM1) AS ROOMINFO ON FZ.COMP_ID = ROOMINFO.COMP_ID
' 
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'View_FEE_REPORT', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_FEE_REPORT'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'View_FEE_REPORT', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_FEE_REPORT'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[View_COMP_DEPOSIT]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[View_COMP_DEPOSIT]
AS
SELECT     dbo.CONTRACT_INFO.COMP_NAME, dbo.DEPOSIT_INFO.SUM, dbo.DEPOSIT_INFO.RETURNED, dbo.DEPOSIT_INFO.ID
FROM         dbo.CONTRACT_INFO INNER JOIN
                      dbo.DEPOSIT_INFO ON dbo.CONTRACT_INFO.ID = dbo.DEPOSIT_INFO.COMP_ID
' 
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'View_COMP_DEPOSIT', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "CONTRACT_INFO"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 222
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DEPOSIT_INFO"
            Begin Extent = 
               Top = 6
               Left = 260
               Bottom = 139
               Right = 420
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_COMP_DEPOSIT'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'View_COMP_DEPOSIT', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_COMP_DEPOSIT'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[View_PRED_CHARGE]'))
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [dbo].[View_PRED_CHARGE]
AS
SELECT     A.COMP_ID, A.FANGZU, B.WUYE, C.FUWU, D.WANGLUO, A.INTERVAL
FROM         (SELECT     COMP_ID, SUM_MONTH AS FANGZU, INTERVAL
                       FROM          dbo.PRED_CHARGE
                       WHERE      (CHARGE_TYPE = ''房租'')) AS A INNER JOIN
                          (SELECT     COMP_ID, SUM_MONTH AS WUYE, INTERVAL
                            FROM          dbo.PRED_CHARGE AS PRED_CHARGE_3
                            WHERE      (CHARGE_TYPE = ''物业费'')) AS B ON A.COMP_ID = B.COMP_ID INNER JOIN
                          (SELECT     COMP_ID, SUM_MONTH AS FUWU, INTERVAL
                            FROM          dbo.PRED_CHARGE AS PRED_CHARGE_2
                            WHERE      (CHARGE_TYPE = ''服务费'')) AS C ON A.COMP_ID = C.COMP_ID INNER JOIN
                          (SELECT     COMP_ID, SUM_MONTH AS WANGLUO, INTERVAL
                            FROM          dbo.PRED_CHARGE AS PRED_CHARGE_1
                            WHERE      (CHARGE_TYPE = ''网络费'')) AS D ON A.COMP_ID = D.COMP_ID

' 
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'View_PRED_CHARGE', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "A"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 110
               Right = 180
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "B"
            Begin Extent = 
               Top = 6
               Left = 218
               Bottom = 110
               Right = 360
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "C"
            Begin Extent = 
               Top = 6
               Left = 398
               Bottom = 110
               Right = 540
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "D"
            Begin Extent = 
               Top = 6
               Left = 578
               Bottom = 110
               Right = 720
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_PRED_CHARGE'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'View_PRED_CHARGE', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_PRED_CHARGE'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[View_MAIN_FEE]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[View_MAIN_FEE]
AS
SELECT     A.ID, B.COMP_NAME, A.COMP_ID, A.FEE_TYPE, A.FEE_CHARGE, A.LAST_END, A.NEXT_START, A.COMMENT, A.GEN_MONTH, A.ISPAID, B.TERMINATE, 
                      B.CONTRACT_NO, B.START_DATE, B.END_DATE, B.CONTACT, B.TELEPHONE, B.MOBILE
FROM         dbo.FEE_INFO AS A LEFT OUTER JOIN
                      dbo.CONTRACT_INFO AS B ON A.COMP_ID = B.ID
' 
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'View_MAIN_FEE', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "A"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "B"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 125
               Right = 420
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_MAIN_FEE'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'View_MAIN_FEE', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_MAIN_FEE'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[View_CUSTOMERS]'))
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [dbo].[View_CUSTOMERS]
AS
SELECT     A.ID, A.COMP_NAME, A.CONTRACT_NO, A.START_DATE, A.END_DATE, A.RENT_AREA, A.CORP_REP, A.CONTACT, A.TELEPHONE, A.MOBILE, A.CAPITAL, A.PLACE, 
                      A.TAX_ID, A.IC_ID, A.ORG_CODE, A.CATEGORY, A.MAIN_BUZZ, A.TERMINATE, A.COMMENT, A.MODIFY_COMMENT, B.FANGZU, B.WUYE, B.FUWU, B.WANGLUO, 
                      B.INTERVAL, ISNULL(C.ROOMCOUNT, 0) AS ROOMCOUNT, ISNULL(D.PARKINGCOUNT, 0) AS PARKINGCOUNT, E.SUM AS YAJIN
FROM         dbo.CONTRACT_INFO AS A LEFT OUTER JOIN
                      dbo.View_PRED_CHARGE AS B ON A.ID = B.COMP_ID LEFT OUTER JOIN
                          (SELECT     COMP_ID, COUNT(ID) AS ROOMCOUNT
                            FROM          dbo.ROOM_INFO
                            GROUP BY COMP_ID) AS C ON A.ID = C.COMP_ID LEFT OUTER JOIN
                          (SELECT     COMP_ID, COUNT(ID) AS PARKINGCOUNT
                            FROM          dbo.PARKING_INFO
                            GROUP BY COMP_ID) AS D ON A.ID = D.COMP_ID LEFT OUTER JOIN
                      dbo.DEPOSIT_INFO AS E ON A.ID = E.COMP_ID

' 
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'View_CUSTOMERS', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "A"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 222
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "E"
            Begin Extent = 
               Top = 6
               Left = 260
               Bottom = 125
               Right = 444
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "B"
            Begin Extent = 
               Top = 6
               Left = 482
               Bottom = 125
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "C"
            Begin Extent = 
               Top = 6
               Left = 662
               Bottom = 95
               Right = 817
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "D"
            Begin Extent = 
               Top = 96
               Left = 662
               Bottom = 185
               Right = 830
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_CUSTOMERS'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'View_CUSTOMERS', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_CUSTOMERS'
