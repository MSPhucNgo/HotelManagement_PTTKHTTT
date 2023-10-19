USE HotelManagement
GO
-- proc get list of room
--CREATE PROC usp_getRoomList
ALTER PROC usp_getRoomList
AS 
BEGIN
	SELECT * FROM ROOM
END
GO
-- proc get list of customer
--CREATE PROC usp_getCustomerList
ALTER PROC usp_getCustomerList
AS
BEGIN
	SELECT * FROM CUSTOMER
END
GO
-- proc get list of waiting customer
--CREATE PROC usp_getWaitingList
ALTER PROC usp_getWaitingList
AS
BEGIN 
	SELECT * FROM WAITING_LIST 
END
GO

-- proc get detail infor of customer form CUSTOMER and INFORMATION_FORM
--CREATE PROC usp_getCustomerDetail
ALTER PROC usp_getCustomerDetail
(@ID_INFORMATION_FORM CHAR(5))
AS
BEGIN
	SELECT CT.*, INF.ARRIVAL_DATE, INF.NUMBER_ROOMS, INF.NUMBER_STAYS, INF.SPECIAL_REQUIREMENTS, INF.TYPE
	FROM CUSTOMER CT
	JOIN INFORMATION_FORM INF
	ON CT.ID_INFORMATION_FORM = INF.ID_INFORMATION_FORM
	WHERE CT.ID_INFORMATION_FORM = @ID_INFORMATION_FORM;
END

EXEC usp_getCustomerDetail I6652;
go
------------------------------------------------------------
use HotelManagement 
go
-- Procedure check if customer has exist in database
-- Input: IDENTIFY_CARD
-- Output: 1 if existed, 0 if not existed
CREATE PROC usp_checkExistedCustomer
--ALTER PROC usp_checkExistedCustomer
(@IDENTIFY_CARD CHAR(14))
AS
BEGIN
SELECT COUNT (*) AS EXIST 
FROM CUSTOMER 
WHERE IDENTIFY_CARD = @IDENTIFY_CARD
END
go
-- Code run and check usp_checkExitCustomer 
DECLARE @ctmExitFlag INT
EXEC @ctmExitFlag = usp_checkExistedCustomer '17849';
PRINT @ctmExitFlag
exec usp_checkExistedCustomer '73446071865366'
go
------------------------------------------------------------
-- Code select infor of customer
-- Input: IDENTIFY_CARD
-- Output: PhoneNumber, Email, Gender, Birthday
USE HotelManagement
GO
--CREATE PROC usp_getExistedCustomer
ALTER PROC usp_getExistedCustomer
(@IDENTIFY_CARD CHAR(14))
AS
BEGIN
	SELECT ID_CUSTOMER, IDENTIFY_CARD, NAME, PHONE, EMAIL, GENDER, BIRTHDAY 
	FROM CUSTOMER
	WHERE IDENTIFY_CARD = @IDENTIFY_CARD
END
GO
EXEC usp_getExistedCustomer '73446071865366'