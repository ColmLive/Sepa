USE [SEPA]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[PopulateVendors]

SELECT	'Return Value' = @return_value

GO
