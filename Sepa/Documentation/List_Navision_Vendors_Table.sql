USE [Test_Navision]
GO

SELECT top 1000
      [No_]
      ,[Name]
      ,[Address]
      ,[Address 2]
      ,[City]
      ,[Our Account No_]
      ,[Currency Code]
      ,[Country Code]
      ,[Post Code]
      ,[County]
      ,[E-Mail]
      ,[Telephone No_]
      ,[E-mail Address]
      ,[BACS Account No_]
  FROM Test_Navision.[dbo].[FR Kelly & Co_$Vendor]
where [Currency Code] in ('STG', 'EUR')
AND [Country Code] IN ('IRELAND' , 'UK')

AND [No_] IN 

(sELECT [Buy-from Vendor No_] FROM [Test_Navision].[dbo].[FR Kelly & Co_$Purch_ Inv_ Header])

GO

/*
UPDATE Test_Navision.[dbo].[FR Kelly & Co_$Vendor]
SET [Country Code] = NULL
WHERE [Country Code] not in (0,1,2,3)

UPDATE Test_Navision.[dbo].[FR Kelly & Co_$Vendor]
SET [Country Code] = 'IRELAND'
WHERE [Country Code] = '0'

UPDATE Test_Navision.[dbo].[FR Kelly & Co_$Vendor]
SET [Currency Code] = 'EUR'
WHERE [Currency Code] = '0'
*/