USE [cjwygl]
GO

/****** Object:  View [dbo].[View_CUSTOMERS]    Script Date: 05/05/2013 01:01:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

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

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_CUSTOMERS'
GO

