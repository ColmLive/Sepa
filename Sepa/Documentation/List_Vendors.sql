USE [Test_Navision]
GO

SELECT TOP 50
[timestamp]
    ,[No_]
      ,[Name]
      ,[Address]
      ,[Address 2]
      ,[City]
      ,[Country Code]
      ,[Currency Code]
	  ,[E-Mail]
	  ,[Phone No_]
      ,[Our Account No_]



      ,[Telephone No_]
  FROM [dbo].[FR Kelly & Co_$Vendor]
  where [Purchaser Code] is not null
GO


