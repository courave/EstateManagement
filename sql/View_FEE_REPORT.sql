USE [cjwygl]
GO
/****** Object:  View [dbo].[View_FEE_REPORT]    Script Date: 05/14/2013 16:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_FEE_REPORT]
AS
SELECT     CUSTOMER.ID, CUSTOMER.CONTRACT_NO, CUSTOMER.COMP_NAME, ROOMINFO.ROOMNO, FZ.GEN_MONTH, FZ.ISPAID, CONVERT(nvarchar(8), DATEADD(DAY, - 1, 
                      FZ.LAST_END), 2) AS DATE_PREV, CONVERT(nvarchar(8), FZ.LAST_END, 2) + '-' + CONVERT(nvarchar(8), DATEADD(DAY, - 1, FZ.NEXT_START), 2) AS DATE_CURRENT, 
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
                       WHERE      (FEE_TYPE = '房租')) AS FZ LEFT OUTER JOIN
                          (SELECT     ID, COMP_NAME, CONTRACT_NO
                            FROM          dbo.CONTRACT_INFO) AS CUSTOMER ON FZ.COMP_ID = CUSTOMER.ID LEFT OUTER JOIN
                          (SELECT     FEE_CHARGE, LAST_END, NEXT_START, COMMENT, COMP_ID, ISPAID, GEN_MONTH
                            FROM          dbo.FEE_INFO AS CJ_MAIN_FEE_7
                            WHERE      (FEE_TYPE = '服务费')) AS FWF ON FZ.COMP_ID = FWF.COMP_ID AND FZ.GEN_MONTH = FWF.GEN_MONTH LEFT OUTER JOIN
                          (SELECT     FEE_CHARGE, LAST_END, NEXT_START, COMMENT, COMP_ID, ISPAID, GEN_MONTH
                            FROM          dbo.FEE_INFO AS CJ_MAIN_FEE_6
                            WHERE      (FEE_TYPE = '物业费')) AS WY ON FZ.COMP_ID = WY.COMP_ID AND FZ.GEN_MONTH = WY.GEN_MONTH LEFT OUTER JOIN
                          (SELECT     FEE_CHARGE, LAST_END, NEXT_START, COMMENT, COMP_ID, ISPAID, GEN_MONTH
                            FROM          dbo.FEE_INFO AS CJ_MAIN_FEE_5
                            WHERE      (FEE_TYPE = '网络费')) AS WL ON FZ.COMP_ID = WL.COMP_ID AND FZ.GEN_MONTH = WL.GEN_MONTH LEFT OUTER JOIN
                          (SELECT     FEE_CHARGE, LAST_END, NEXT_START, COMMENT, COMP_ID, ISPAID, GEN_MONTH
                            FROM          dbo.FEE_INFO AS CJ_MAIN_FEE_4
                            WHERE      (FEE_TYPE = '车位费')) AS CW ON FZ.COMP_ID = CW.COMP_ID AND FZ.GEN_MONTH = CW.GEN_MONTH LEFT OUTER JOIN
                          (SELECT     FEE_CHARGE, LAST_END, NEXT_START, COMMENT, COMP_ID, ISPAID, GEN_MONTH
                            FROM          dbo.FEE_INFO AS CJ_MAIN_FEE_3
                            WHERE      (FEE_TYPE = '煤气费')) AS MQF ON FZ.COMP_ID = MQF.COMP_ID AND FZ.GEN_MONTH = MQF.GEN_MONTH LEFT OUTER JOIN
                          (SELECT     FEE_CHARGE, LAST_END, NEXT_START, COMMENT, COMP_ID, ISPAID, GEN_MONTH
                            FROM          dbo.FEE_INFO AS CJ_MAIN_FEE_2
                            WHERE      (FEE_TYPE = '水费')) AS SF ON FZ.COMP_ID = SF.COMP_ID AND FZ.GEN_MONTH = SF.GEN_MONTH LEFT OUTER JOIN
                          (SELECT     FEE_CHARGE, LAST_END, NEXT_START, COMMENT, COMP_ID, ISPAID, GEN_MONTH
                            FROM          dbo.FEE_INFO AS CJ_MAIN_FEE_1
                            WHERE      (FEE_TYPE = '电费')) AS DF ON FZ.COMP_ID = DF.COMP_ID AND FZ.GEN_MONTH = DF.GEN_MONTH LEFT OUTER JOIN
                          (SELECT DISTINCT BB.FEE_CHARGE, NULL AS LAST_END, NULL AS NEXT_START, AA.COMMENT, AA.COMP_ID, 0 AS ISPAID, AA.GEN_MONTH
                            FROM          (SELECT DISTINCT BBB.COMP_ID, BBB.GEN_MONTH,
                                                                               (SELECT     AAA.FEE_TYPE + ':' + CONVERT(NVARCHAR(50), AAA.FEE_CHARGE) + ';'
                                                                                 FROM          DBO.FEE_INFO AS AAA
                                                                                 WHERE      (FEE_TYPE <> '电费') AND (FEE_TYPE <> '房租') AND (FEE_TYPE <> '服务费') AND (FEE_TYPE <> '物业费') AND 
                                                                                                        (FEE_TYPE <> '网络费') AND (FEE_TYPE <> '车位费') AND (FEE_TYPE <> '煤气费') AND (FEE_TYPE <> '水费') AND 
                                                                                                        AAA.COMP_ID = BBB.COMP_ID AND AAA.GEN_MONTH = BBB.GEN_MONTH FOR XML PATH('')) COMMENT
                                                    FROM          FEE_INFO BBB) AS AA,
                                                       (SELECT     SUM(FEE_CHARGE) AS FEE_CHARGE, COMP_ID, GEN_MONTH
                                                         FROM          DBO.FEE_INFO AS FEE_INFO_1
                                                         WHERE      (FEE_TYPE <> '电费') AND (FEE_TYPE <> '房租') AND (FEE_TYPE <> '服务费') AND (FEE_TYPE <> '物业费') AND (FEE_TYPE <> '网络费') 
                                                                                AND (FEE_TYPE <> '车位费') AND (FEE_TYPE <> '煤气费') AND (FEE_TYPE <> '水费')
                                                         GROUP BY COMP_ID, GEN_MONTH) AS BB
                            WHERE      AA.COMP_ID = BB.COMP_ID AND AA.GEN_MONTH = BB.GEN_MONTH) AS QITA ON FZ.COMP_ID = QITA.COMP_ID AND 
                      FZ.GEN_MONTH = QITA.GEN_MONTH LEFT OUTER JOIN
                          (SELECT DISTINCT MROOM1.COMP_ID,
                                                       (SELECT     MROOM2.ROOM_NO + ';' AS [text()]
                                                         FROM          ROOM_INFO MROOM2
                                                         WHERE      MROOM2.COMP_ID = MROOM1.COMP_ID
                                                         ORDER BY MROOM2.COMP_ID FOR XML PATH('')) ROOMNO
                            FROM          ROOM_INFO MROOM1) AS ROOMINFO ON FZ.COMP_ID = ROOMINFO.COMP_ID

GO
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
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_FEE_REPORT'