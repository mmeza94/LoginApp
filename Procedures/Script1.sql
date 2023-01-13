


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
If OBJECT_ID('[Login].[InsertNewUser]') IS NOT NULL
	DROP PROCEDURE [dbo].[GetProductionGeneralTornosTestV5]
GO


CREATE Procedure [Login].[InsertNewUser]
@email nvarchar(200),
@Password nvarchar(200)
AS
	BEGIN

		IF EXISTS (Select email From [Login].[Users] Where email like @email)
			BEGIN
				Select 0
			END
		ELSE
			BEGIN
				Insert into [Login].[Users](email,Contraseña )
				Values(@email,ENCRYPTBYPASSPHRASE(@email,@Password))

				Select 1
				PRINT 'Prueba'
			END
			
	END