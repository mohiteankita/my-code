-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Update_Location_Details
	-- Add the parameters for the stored procedure here
	@location_id int,
	@street_address varchar(40),
	@postal_code varchar(20),
	@city varchar(30),
	@state_province varchar(25),
	@country_id char(2)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE LOCATIONS SET STREET_ADDRESS = @street_address,
	POSTAL_CODE = @postal_code, 
	CITY = @city, 
	STATE_PROVINCE = @state_province,
	COUNTRY_ID = @country_id
	WHERE LOCATION_ID = @location_id
END
GO
