CREATE TABLE [dbo].[Usuarios]
(
	[Nombre] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [Tipo_De_Usuario] NVARCHAR(50) NOT NULL, 
    [Usuario] NVARCHAR(50) NOT NULL, 
    [Contraseña] NVARCHAR(50) NOT NULL
)
