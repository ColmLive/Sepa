/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [timestamp]
      ,[No_]
      ,[Buy-from Vendor No_]
      ,[Pay-to Vendor No_]
      ,[Pay-to Name]
      ,[Pay-to Name 2]
      ,[Pay-to Address]
      ,[Pay-to Address 2]
      ,[Pay-to City]
      ,[Pay-to Contact]
      ,[Your Reference]
      ,[Ship-to Code]
      ,[Ship-to Name]
      ,[Ship-to Name 2]
      ,[Ship-to Address]
      ,[Ship-to Address 2]
      ,[Ship-to City]
      ,[Ship-to Contact]
      ,[Posting Date]
      ,[Expected Receipt Date]
      ,[Posting Description]
      ,[Payment Terms Code]
      ,[Due Date]
      ,[Payment Discount %]
      ,[Pmt_ Discount Date]
      ,[Shipment Method Code]
      ,[Location Code]
      ,[Shortcut Dimension 1 Code]
      ,[Shortcut Dimension 2 Code]
      ,[Vendor Posting Group]
      ,[Currency Code]
      ,[Currency Factor]
      ,[Invoice Disc_ Code]
      ,[Language Code]
      ,[Purchaser Code]
      ,[No_ Printed]
      ,[On Hold]
      ,[Applies-to Doc_ Type]
      ,[Applies-to Doc_ No_]
      ,[Bal_ Account No_]
      ,[Job No_]
      ,[Vendor Cr_ Memo No_]
      ,[VAT Registration No_]
      ,[Sell-to Customer No_]
      ,[Reason Code]
      ,[Gen_ Bus_ Posting Group]
      ,[Transaction Type]
      ,[Transport Method]
      ,[VAT Country Code]
      ,[Buy-from Vendor Name]
      ,[Buy-from Vendor Name 2]
      ,[Buy-from Address]
      ,[Buy-from Address 2]
      ,[Buy-from City]
      ,[Buy-from Contact]
      ,[Pay-to Post Code]
      ,[Pay-to County]
      ,[Pay-to Country Code]
      ,[Buy-from Post Code]
      ,[Buy-from County]
      ,[Buy-from Country Code]
      ,[Ship-to Post Code]
      ,[Ship-to County]
      ,[Ship-to Country Code]
      ,[Bal_ Account Type]
      ,[Order Address Code]
      ,[Entry Point]
      ,[Correction]
      ,[Document Date]
      ,[Area]
      ,[Transaction Specification]
      ,[Payment Method Code]
      ,[Pre-Assigned No_ Series]
      ,[No_ Series]
      ,[Pre-Assigned No_]
      ,[User ID]
      ,[Source Code]
      ,[Tax Area Code]
      ,[Tax Liable]
      ,[VAT Bus_ Posting Group]
      ,[VAT Base Discount %]
      ,[Type of Supply Code]
      ,[Prices Including VAT]
      ,[Responsibility Center]
      ,[Return Order No_]
      ,[Return Order No_ Series]
      ,[Date Received]
      ,[Time Received]
      ,[BizTalk Purchase Credit Memo]
  FROM [Test_Navision].[dbo].[FR Kelly & Co_$Purch_ Cr_ Memo Hdr_]
  where [Posting Date] > '2010-12-12' and [Pay-to Vendor No_] = 2585