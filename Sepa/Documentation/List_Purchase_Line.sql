/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) 
	   [Document No_]
      ,[Line No_]
      ,[Buy-from Vendor No_]
      ,[Type]
      ,[No_]
      ,[Expected Receipt Date]
      ,[Description]
      ,[Quantity]
      ,[Direct Unit Cost]
      ,[Unit Cost (LCY)]
      ,[VAT %]
      ,[Line Discount %]
      ,[Line Discount Amount]
      ,[Amount]
      ,[Amount Including VAT]
      ,[Inv_ Discount Amount]
      ,[Case Reference No_]
      ,[Fee Earner]

  FROM [Test_Navision].[dbo].[FR Kelly & Co_$Purch_ Inv_ Line]
  --where [Document No_] > 10237 and [Document No_] < 10299
  where [Document No_] = 18612

