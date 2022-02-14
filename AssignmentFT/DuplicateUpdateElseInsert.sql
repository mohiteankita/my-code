USE [DatabaseFT]
GO
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
CREATE PROCEDURE UpdateInsertStudData
	-- Add the parameters for the stored procedure here
	@student_id int,
	@first_name varchar(20),
	@last_name varchar(20),
	@address varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF EXISTS (SELECT 1 FROM STUDENT WHERE STUDENT_ID = @student_id)

	BEGIN

	    UPDATE STUDENT SET FIRST_NAME = @first_name, LAST_NAME = @last_name, ADDRESS = @address
		WHERE STUDENT_ID = @student_id
		END
	ELSE

	BEGIN
	    INSERT INTO STUDENT VALUES(@student_id, @first_name, @last_name, @address)
		END
END
GO
