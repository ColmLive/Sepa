/*
Anonymise data selected from Finacial System
*/
use SEPA
select * from vendors
select * from invoices
update invoices set due_date = (posting_date + 30)
delete  from invoices where Invoice_Value is NULL
update vendors set Vendor_Name = CONCAT('Test Vendor Name ', Vendor_ID)
update vendors set Vendor_Address = CONCAT('Test Vendor Address --', Vendor_ID)
update vendors set Vendor_Address2 = CONCAT('Test Vendor Address 2--', Vendor_ID)
update vendors set Vendor_Email = CONCAT('info@vendor', Vendor_ID, '.com')
update vendors set Vendor_IBAN = CONCAT('IE75BOFI9037795999',cast(Vendor_ID as varchar(4)))

