-- ** Anonymise Data in Source DataBase ** --
-- ** Use different string in SEPA Anonymise Procedure ** --
update [Test_Navision].[dbo].[F_ R_ KELLY & CO_ BELFAST$Vendor] set Name = CONCAT('Org Vendor Name ', No_)
update [Test_Navision].[dbo].[F_ R_ KELLY & CO_ BELFAST$Vendor] set [Search Name] = CONCAT('Org Vendor Name ', No_)
update [Test_Navision].[dbo].[F_ R_ KELLY & CO_ BELFAST$Vendor] set Address = CONCAT('Org Vendor Address --', No_)
update [Test_Navision].[dbo].[F_ R_ KELLY & CO_ BELFAST$Vendor]set [Address 2] = CONCAT('Org Vendor Address 2--',No_)
update [Test_Navision].[dbo].[F_ R_ KELLY & CO_ BELFAST$Vendor] set [Phone No_] = CONCAT('001002',No_)
update [Test_Navision].[dbo].[F_ R_ KELLY & CO_ BELFAST$Vendor] set [Fax No_] = CONCAT('003004',No_)
update [Test_Navision].[dbo].[F_ R_ KELLY & CO_ BELFAST$Vendor] set Name = CONCAT('Org Vendor Name ', No_)
update  [Test_Navision].[dbo].[F_ R_ KELLY & CO_ BELFAST$Vendor]set [E-Mail] = CONCAT('info@vendor', No_, '.com')
update [Test_Navision].[dbo].[F_ R_ KELLY & CO_ BELFAST$Vendor] set [BACS Account No_] = CONCAT('BA75BOFI9037795999',No_)
select * from [Test_Navision].[dbo].[F_ R_ KELLY & CO_ BELFAST$Vendor]
update [Test_Navision].[dbo].[FR Kelly & Co_$Vendor] set Name = CONCAT('Org Vendor Name ', No_)
update [Test_Navision].[dbo].[FR Kelly & Co_$Vendor] set [Search Name] = CONCAT('Org Vendor Name ', No_)
update [Test_Navision].[dbo].[FR Kelly & Co_$Vendor] set Address = CONCAT('Org Vendor Address --', No_)
update [Test_Navision].[dbo].[FR Kelly & Co_$Vendor]set [Address 2] = CONCAT('Org Vendor Address 2--',No_)
update [Test_Navision].[dbo].[FR Kelly & Co_$Vendor] set [Phone No_] = CONCAT('001002',No_)
update [Test_Navision].[dbo].[FR Kelly & Co_$Vendor] set [Fax No_] = CONCAT('003004',No_)
update [Test_Navision].[dbo].[FR Kelly & Co_$Vendor] set Name = CONCAT('Org Vendor Name ', No_)
update  [Test_Navision].[dbo].[FR Kelly & Co_$Vendor]set [E-Mail] = CONCAT('info@vendor', No_, '.com')
update [Test_Navision].[dbo].[FR Kelly & Co_$Vendor] set [BACS Account No_] = CONCAT('BA75BOFI9037795999',No_)
select * from [Test_Navision].[dbo].[FR Kelly & Co_$Vendor]