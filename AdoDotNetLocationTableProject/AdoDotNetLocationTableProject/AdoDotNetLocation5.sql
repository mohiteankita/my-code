USE [HRMSDB]
GO
/****** Object:  StoredProcedure [dbo].[Delete_Location_Details]    Script Date: 12-02-2022 12:38:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[Delete_Location_Details]
	-- Add the parameters for the stored procedure here
	@location_id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM LOCATIONS WHERE LOCATION_ID = @location_id
END
