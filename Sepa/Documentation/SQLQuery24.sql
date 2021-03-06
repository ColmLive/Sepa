USE [SEPA]
GO
/****** Object:  StoredProcedure [dbo].[PopulateVendors]    Script Date: 15/03/2019 15:28:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[PopulateVendors] AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
SET IDENTITY_INSERT Vendors ON; 

DELETE FROM Vendors WHERE Vendor_ID is not null

INSERT INTO sepa.dbo.Vendors(Vendor_ID,Vendor_Name,Vendor_Address,Vendor_Address2,Vendor_City,Vendor_Currency,Vendor_Country,Vendor_Email,Vendor_Phone) 

SELECT TOP 100
	   [No_]
      ,[Name]
      ,[Address]
      ,[Address 2]
      ,[City]
      ,[Currency Code]
      ,[Country Code]
      ,[E-Mail]
      ,[Telephone No_]
    
FROM
    Test_Navision.[dbo].[FR Kelly & Co_$Vendor]
WHERE
[Currency Code] in ('EUR')
AND 

[Country Code] IN ('IRELAND','UK')

AND [No_] IN 

(sELECT [Buy-from Vendor No_] FROM [Test_Navision].[dbo].[FR Kelly & Co_$Purch_ Inv_ Header])

END
