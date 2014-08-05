--       Procedimientos Almacenados                   --

--Persona
Create procedure dbo.SelectPersona
as
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM dbo.Persona;
END;


--Colección
Create procedure dbo.SelectColeccion
as
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM dbo.Coleccion;
END;

--familia natural
Create procedure dbo.SelectFamiliaNatural
as
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM dbo.Familia_Natural;
END;

--Genero
CREATE PROCEDURE dbo.SelectGenero	
as
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM dbo.Genero;
END;

EXEC SelectGenero;

--Especie
CREATE PROCEDURE dbo.SelectEspecie
as
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM dbo.Especie;
END;

create procedure dbo.insertarFamiliaNatural
@id nchar(10),
@nombre_familia nvarchar(50)
AS
BEGIN 
	INSERT INTO Familia_Natural VALUES (@id, @nombre_familia);
END;

--Creado Por Carolina Alonzo
--Insertar Genero

create procedure dbo.insertarGenero
@id nchar(10),
@nombre_genero nvarchar(50),
@id_familia nchar(10)
AS
BEGIN
	INSERT INTO Genero VALUES (@id,@nombre_genero,@id_familia)

end;

--Creado Por Carolina Alonzo
--Insertar Especie

CREATE PROCEDURE dbo.insertarEspecie
@nombre_cientifico nvarchar(10),
@id_genero nchar(10)
AS
BEGIN
	INSERT INTO Especie VALUES (@nombre_cientifico,@id_genero)
END;

--Creado Por Carolina Alonzo
--Eliminar Familia Natural
CREATE PROCEDURE dbo.EliminarFamiliaNatural
@identificador nchar(10)
AS
BEGIN
      DELETE FROM Familia_Natural WHERE id = @identificador;
END;

--Creado Por Carolina Alonzo
--Eliminar GEnero
CREATE PROCEDURE dbo.EliminarGenero
@identificador nchar(10)
AS
BEGIN
	 DELETE FROM Genero WHERE id = @identificador;
END;

--Creado Por Carolina Alonzo
--Eliminar Especie
CREATE PROCEDURE dbo.EliminarEspecie 
@nombreCientifico nvarchar(50)
AS
BEGIN
     DELETE FROM Especie WHERE nombre_cientifico = @nombreCientifico;
END;

-- actualizar Familia Natural
--Creado por Carolina Alonzo
CREATE PROCEDURE dbo.actualizar_FamiliaNatural
@idViejo nchar(10),
@idNuevo nchar(10),
@nombre  nvarchar(50)
AS
BEGIN 
	UPDATE Familia_Natural SET id = @idNuevo, nombre_familia = @nombre WHERE id = @idViejo;
END;

--Actualizar Genero
--Creado por Carolina Alonzo
CREATE PROCEDURE dbo.actualizarGenero
@idViejo nchar(10),
@idNuevo nchar(10),
@nombre  nvarchar(50),
@idFamilia nchar(10)
AS
BEGIN
   UPDATE Genero SET id = @idNuevo, nombre_genero = @nombre,id_familia =@idFamilia WHERE id = @idViejo;
END;

--Actualizar Especie
--Creado por Carolina Alonzo
CREATE PROCEDURE dbo.actualizar_especie
@nombreViejo nvarchar(50),
@nombreNuevo nvarchar(50),
@id_genero nchar(10)
AS
BEGIN
	UPDATE Especie SET nombre_cientifico = @nombreNuevo, id_genero = @id_genero WHERE nombre_cientifico = @nombreViejo;
END;

--Zona Geográfica:
CREATE PROCEDURE dbo.SelectZonaGeografica
AS
BEGIN
	SET NOCOUNT ON
	SELECT * FROM dbo.Zona_Geografica
END;

--Especie Zona Geográfica:
CREATE PROCEDURE dbo.SelectEspecieZonaGeografica
AS
BEGIN
	SET NOCOUNT ON
	SELECT * FROM dbo.Especie_Zona_Geografica
END;

CREATE PROCEDURE seleccionar_Mariposa
AS
BEGIN
	SET NOCOUNT ON
	SELECT * FROM Mariposa
END;

--Mariposa Zona Geografica
CREATE PROCEDURE seleccionar_Mariposa_Zona_Geografica
AS 
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Mariposa_Zona_Geografica
END;

-- Mariposa en Observación
CREATE PROCEDURE seleccionar_Mariposa_en_Observacion
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Mariposa_en_Observacion
END;


--Mariposa en Coleccion

CREATE PROCEDURE seleccionar_Mariposa_en_Coleccion
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Mariposa_en_Coleccion
END;

--Procedimiento para filtrar a las personas que son coleccionistas 
--Autor: Carlos Alberto Salgado
--Fecha Añadido: 25/Julio

CREATE PROCEDURE dbo.SelectColeccionistas
AS
BEGIN
	SELECT * FROM Persona WHERE tipo = 'C';
END 



--Procedimiento para insertar en Persona 
--Autor: Carlos Alberto Salgado
--Fecha Añadido: 25/Julio

CREATE PROCEDURE dbo.InsertPersona
@id nchar(10),
@nombres nvarchar(50),
@apellidos nvarchar(50),
@tipo nvarchar(1) = 'B'
AS
BEGIN 
	INSERT INTO Persona VALUES (@id, @nombres, @apellidos, @tipo);
END

--Procedimiento para actualizar en Persona 
--Autor: Carlos Alberto Salgado
--Fecha Añadido: 25/Julio
CREATE PROCEDURE dbo.UpdatePersona
@idViejo nchar(10),
@idNuevo nchar(10),
@nombres nvarchar(50),
@apellidos nvarchar(50),
@tipo nvarchar(1) = 'B'
AS
BEGIN 
	UPDATE Persona SET id=@idNuevo, nombres_persona=@nombres, apellidos_persona = @apellidos, tipo = @tipo WHERE id = @idViejo;
END



--Procedimiento para eliminar en Persona 
--Autor: Carlos Alberto Salgado
--Fecha Añadido: 25/Julio

CREATE PROCEDURE dbo.DeletePersona
@id nchar(10)
AS
BEGIN 
	DELETE FROM Persona WHERE id = @id;
END
--Procedimiento para filtrar a las personas que son biologos 
--Autor: Carlos Alberto Salgado
--Fecha Añadido: 26/Julio
CREATE PROCEDURE dbo.SelectBiologos
AS
BEGIN
	SELECT * FROM Persona WHERE tipo = 'B';
END


--Procedimiento para insertar Zona 
--Autor: Carlos Alberto Salgado
--Fecha Añadido: 26/Julio
CREATE PROCEDURE dbo.InsertZonaGeografica
@nombre nvarchar(50)
AS
BEGIN 
	INSERT INTO Zona_Geografica VALUES (@nombre);
END
--Procedimiento para actualizar Zona 
--Autor: Carlos Alberto Salgado
--Fecha Añadido: 25/Julio
CREATE PROCEDURE dbo.UpdateZonaGeografica
@nombreViejo nvarchar(50),
@nombreNuevo nvarchar(50)
AS
BEGIN 
	UPDATE Zona_Geografica SET nombre_zona = @nombreNuevo WHERE nombre_zona = @nombreViejo;
END


--Procedimiento para eliminar Zona 
--Autor: Carlos Alberto Salgado
--Fecha Añadido: 25/Julio

CREATE PROCEDURE dbo.DeleteZonaGeografica
@nombre nvarchar(50)
AS
BEGIN 
	DELETE FROM Zona_Geografica WHERE nombre_zona = @nombre;
END



--Inserción de mariposas

CREATE PROCEDURE insertarMariposa
	(@idMariposa NCHAR(10), @fechaCaptura DATETIME, @nombreCientifico NVARCHAR(50), @tipo NCHAR(1),
	 @idPersona NCHAR(10), @zonaGeografica NVARCHAR(50), @tiempoObservacion DECIMAL, @precio DECIMAL,
	 @idColeccion NCHAR(10))
AS
BEGIN

	BEGIN TRY

		BEGIN TRANSACTION

		DECLARE @filasAfectadas INT = 0

		--Inserción a la tabla 'Mariposa'
		INSERT INTO Mariposa(id, fecha_captura, nombre_cientifico, tipo, id_persona, zona_geografica, liberado)
		VALUES (@idMariposa, @fechaCaptura, @nombreCientifico, @tipo, @idPersona, @zonaGeografica, 0)

		SET @filasAfectadas = @filasAfectadas + 1
		
		-- Inserción a la tabla 'Mariposa de Colección' o
		-- 'Mariposa de Observación'
		IF @tipo = 'C' --Significa que la mariposa es de colección
			BEGIN
				INSERT INTO Mariposa_en_Coleccion(id_mariposa, precio, id_coleccion)
				VALUES (@idMariposa, @precio, @idColeccion)

				SET @filasAfectadas = @filasAfectadas + 1
			END;
		ELSE			--De lo contrario, es una mariposa de observación.
			BEGIN
				INSERT INTO Mariposa_en_Observacion(id_mariposa, tiempo_observacion)
				VALUES (@idMariposa, @tiempoObservacion)

				SET @filasAfectadas = @filasAfectadas + 1
			END;
			
		IF @filasAfectadas = 2
			COMMIT TRANSACTION
		ELSE
			ROLLBACK TRANSACTION


	END TRY

	BEGIN CATCH
		ROLLBACK TRANSACTION;
	END CATCH;
	
END;


--Eliminar mariposa

CREATE PROCEDURE eliminarMariposa
	(@idMariposa NCHAR(10))
AS
BEGIN
	
	BEGIN TRY

		BEGIN TRANSACTION

		DECLARE @filasAfectadas INT = 0 

		--Eliminación del registro de la tabla 'Mariposa'
		UPDATE Mariposa
		SET liberado = 1
		WHERE Mariposa.id = @idMariposa
		
		SET @filasAfectadas = @filasAfectadas + 1

		IF @filasAfectadas = 1
			COMMIT TRANSACTION
		ELSE
			ROLLBACK TRANSACTION



	END TRY

	BEGIN CATCH
		ROLLBACK TRANSACTION;
	END CATCH;
END;

--Actualizar mariposa

CREATE PROCEDURE actualizarMariposa
	(@idMariposa NCHAR(10),
	@fechaCaptura DATETIME, 
	@nombreCientifico NVARCHAR(50), @tipo NCHAR(1),
	 @idPersona NCHAR(10), @zonaGeografica NVARCHAR(50),
	 @tiempoObservacion DECIMAL, @precio DECIMAL,
	 @idColeccion NCHAR(10))
AS
BEGIN

	BEGIN TRY

		BEGIN TRANSACTION

		DECLARE @filasAfectadas INT = 0 

		--Actualización a la tabla 'Mariposa'
		UPDATE Mariposa
		SET fecha_captura = @fechaCaptura,
			nombre_cientifico = @nombreCientifico,
			id_persona = @idPersona
		WHERE Mariposa.id = @idMariposa

		SET @filasAfectadas = @filasAfectadas  + 1
	
		--Actualización a las tablas especializadas de Mariposa
		IF @tipo = 'C'
			BEGIN
				UPDATE Mariposa_en_Coleccion
				SET precio = @precio,
					id_coleccion = @idColeccion
				WHERE id_mariposa = @idMariposa

				SET @filasAfectadas = @filasAfectadas  + 1
			END;
		ELSE
			BEGIN
				UPDATE Mariposa_en_Observacion
				SET tiempo_observacion = @tiempoObservacion
				WHERE id_mariposa = @idMariposa

				SET @filasAfectadas = @filasAfectadas  + 1
			END;
	
		IF @filasAfectadas = 2
			COMMIT TRANSACTION
		ELSE
			ROLLBACK TRANSACTION

	END TRY

	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH;
	
END;

-- COLECCIONES (SAULI)
--PROCEDIMIENTO PARA INSERTAR UNA COLECCION Y REALIZAR LAS ACTUALIZACIONES CORRESPONDIENTES

create procedure insertarColeccion (@id nchar(10), @nombre_coleccion nvarchar(50),@precio decimal,@fecha date,@id_persona nchar(10))
as
begin
	insert into Coleccion values(@id,@nombre_coleccion,@precio,@fecha,@id_persona);
	update Persona set tipo='C' where id=@id_persona;
end;


--PROCEDIMIENTO PARA ELIMINAR UNA COLECCION Y REALIZAR LAS ACTUALIZACIONES CORRESPONDIENTES
create procedure eliminarColeccion (@id nchar(10), @id_persona nchar(10))
as
begin
	delete from Mariposa where id in (Select id_mariposa from Mariposa_en_Coleccion where id_coleccion=@id);
	delete from Mariposa_en_Coleccion where id_coleccion=@id;
	delete from Coleccion where id=@id;
	update Persona set tipo='B' where id=@id_persona;
end;

--PROCEDIMIENTO PARA ACTUALIZAR UNA COLECCION Y REALIZAR LAS ACTUALIZACIONES CORRESPONDIENTES

create procedure actualizarColeccion (@id nchar(10), @nombre nvarchar(50),@precio decimal,@fecha date, @id_persona nchar(10))
as
begin
	update Coleccion set nombre_coleccion=@nombre, precio=@precio, fecha_inicio=@fecha, id_persona=@id_persona where id=@id;
	update Persona set tipo='C' where id=@id_persona;
end;

--Selecciona una persona por id (Lo utilizo para seleccionar el dueño de una coleccion)

create procedure seleccionar_Persona_Por_Id (@id nchar(10)) as
begin 
	set nocount on;
	select * from Persona where id=@id;
end;


-- FIN_COLECCIONES