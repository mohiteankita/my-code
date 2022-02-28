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
CREATE PROCEDURE UpdateInsertStudData_ByMerge
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
	MERGE STUDENT AS STUDENT_TARGET
	USING(SELECT @student_id, @first_name, @last_name, @address)
	AS STUDENT_SOURCE(student_id, first_name, last_name, address)
	ON STUDENT_TARGET.STUDENT_ID = STUDENT_SOURCE.STUDENT_ID
    WHEN MATCHED THEN
	    UPDATE SET FIRST_NAME = STUDENT_SOURCE.FIRST_NAME,
		           LAST_NAME = STUDENT_SOURCE.LAST_NAME,
				   ADDRESS = STUDENT_SOURCE.ADDRESS

   WHEN NOT MATCHED THEN
   INSERT(STUDENT_ID, FIRST_NAME, LAST_NAME, ADDRESS) 
   VALUES(STUDENT_SOURCE.STUDENT_ID, STUDENT_SOURCE.FIRST_NAME, STUDENT_SOURCE.LAST_NAME, STUDENT_SOURCE.ADDRESS);
END
GO
