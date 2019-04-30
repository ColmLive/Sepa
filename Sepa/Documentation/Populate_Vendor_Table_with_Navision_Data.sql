/*
Script to insert Vendor Records from Source Database to Vendor Table

Delete all records prior to adding records

Selection based on criteria such as Country Code , IBAN Number 

*/

SET IDENTITY_INSERT Invoices OFF; 
SET IDENTITY_INSERT Vendors ON; 

DELETE FROM Vendors WHERE Vendor_ID is not null

INSERT INTO sepa.dbo.Vendors(Vendor_ID,Vendor_Name,Vendor_Address,Vendor_Address2,Vendor_City,Vendor_Currency,Vendor_Country,Vendor_Email,Vendor_Phone) 

SELECT TOP 10
	   [No_]
      ,[Name] 
      ,[Address]
      ,[Address 2]
      ,[City]
      ,[Currency Code]
      ,[Country Code]
      ,[E-Mail]
      ,[Telephone No_]
	  ,[BACS Account No_]
    
FROM
    Test_Navision.[dbo].[FR Kelly & Co_$Vendor]
WHERE
[Currency Code] in ('EUR', 'STG')
AND 

[Country Code] IN ('IRELAND','UK')

AND [No_] IN 

(sELECT [Buy-from Vendor No_] FROM [Test_Navision].[dbo].[FR Kelly & Co_$Purch_ Inv_ Header])

--update vendors set Vendor_name = 'name'
select * FROM Vendors 
 
select * FROM Test_Navision.[dbo].[FR Kelly & Co_$Vendor]
