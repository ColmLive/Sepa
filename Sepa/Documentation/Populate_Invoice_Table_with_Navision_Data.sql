/*
Script to insert Invoice Records from Source Database to Invoices Table

Delete all records prior to adding records

Calculate Toal value from Line Items

*/
SET IDENTITY_INSERT Vendors OFF; 
SET IDENTITY_INSERT Invoices ON; 

DELETE FROM Invoices WHERE Vendor_ID is not null

INSERT INTO sepa.dbo.Invoices(Invoice_ID,Vendor_ID,Vendor_InvNo,Currency_Code,Posting_Desc,Posting_Date,Due_Date,Discount,StatusCode) 

SELECT TOP 1000
	   [No_]
      ,[Buy-from Vendor No_]
      ,[Vendor Invoice No_]
	   ,[Currency Code]
      ,[Posting Description]
      ,[Posting Date]
      ,[Due Date]
	  ,[Payment Discount %]
	  ,0
         
FROM
    Test_Navision.[dbo].[FR Kelly & Co_$Purch_ Inv_ Header]

WHERE
[Currency Code] in (' ', 'STG')
and [Buy-from Vendor No_] in 
(select Vendor_ID from Vendors)

select * FROM Invoices
Select * from Vendors
 
 UPDATE Invoices 

SET Invoice_Value = (SELECT SUM (Amount) as s1

 FROM [Test_Navision].[dbo].[FR Kelly & Co_$Purch_ Inv_ Line] PL WHERE [Invoice_ID] = PL.[Document No_])

 /*
 UPDATE Invoices 

SET Discount = 0

*/