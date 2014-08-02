use MariposarioDB
--Selecciona una persona por id (Lo utilizo para seleccionar el dueño de una coleccion)

create procedure seleccionar_Persona_Por_Id (@id nchar(10)) as
begin 
	set nocount on;
	select * from Persona where id=@id;
end;


--PROCEDIMIENTO PARA INSERTAR COLECCION (TAMBIÉN INCLUI UNA FUNCIÓN PARA PODER ACTUALIZAR LAS MARIPOSAS)

--Funcion para crear tabla de parametros (Se recive una cadena con los parametros separdos por comas(',')  y se devuelve una tabla con todos los parametros. Es una forma de simular una arreglo en sql.
CREATE FUNCTION [dbo].[ArrayToTable] (@delimStr NVARCHAR(max))
RETURNS 

@StrValTable TABLE 
(
    -- Add the column definitions for the TABLE variable here
    StrVal VARCHAR(20) 
)
AS
BEGIN
    -- Fill the table variable with the rows for your result set
    DECLARE @strlist NVARCHAR(max), @pos INT, @delim CHAR, @lstr NVARCHAR(max)
    SET @strlist = ISNULL(@delimStr,'')
    SET @delim = ','

    WHILE ((len(@strlist) > 0) and (@strlist <> ''))
    BEGIN
        SET @pos = charindex(@delim, @strlist)
        
        IF @pos > 0
           BEGIN
              SET @lstr = substring(@strlist, 1, @pos-1)
              SET @strlist = ltrim(substring(@strlist,charindex(@delim, @strlist)+1, 8000))
           END
        ELSE
           BEGIN
              SET @lstr = @strlist
              SET @strlist = ''
           END

        INSERT @StrValTable VALUES (@lstr)
    END
        RETURN 
    END
GO

--PROCEDIMIENTO PARA INSERTAR UNA COLECCION Y REALIZAR LAS ACTUALIZACIONES CORRESPONDIENTES

create procedure insertarColeccion (@id nchar(10), @nombre_coleccion nvarchar(50),@precio decimal,@id_persona nchar(10),@Parametros nvarchar(Max))
as
begin
	insert into Coleccion values(@id,@nombre_coleccion,@precio,@id_persona);
	update Persona set tipo='C' where id=@id_persona;
	update Mariposa set tipo='C' where id in (SELECT * FROM dbo.ArrayToTable(@Parametros));
	delete Mariposa_en_Observacion where id_mariposa in (SELECT * FROM dbo.ArrayToTable(@Parametros));
end;

--INSERTAR MARIPOSA EN COLECCION
create procedure insertarMariposaDeColeccion (@id nchar(10),@precio decimal,@id_coleccion nchar(10)) as
begin
	insert into Mariposa_en_Coleccion values(@id,@precio,@id_coleccion);
	delete from Mariposa_en_Observacion where id_mariposa=@id;
	update Mariposa set tipo = 'C' where id = @id;
end;

--PROCEDIMIENTO PARA ELIMINAR UNA COLECCION Y REALIZAR LAS ACTUALIZACIONES CORRESPONDIENTES
create procedure eliminarColeccion (@id nchar(10), @id_persona nchar(10),@Parametros nvarchar(Max))
as
begin
	delete Mariposa_en_Coleccion where id_coleccion = @id;
	delete from Coleccion where id=@id;
	update Persona set tipo='B' where id=@id_persona;
	update Mariposa set tipo='O' where id in (SELECT * FROM dbo.ArrayToTable(@Parametros));
end;

--INSERTAR MARIPOSA EN OBSERVACION
create procedure insertarMariposaEnObservacion (@id nchar(10),@tiempo int) as
begin
	insert into Mariposa_en_Observacion values(@id,@tiempo);
	delete from Mariposa_en_Coleccion where id_mariposa = @id;
	update Mariposa set tipo = 'O' where id = @id;
end;

--PROCEDIMIENTO PARA ACTUALIZAR UNA COLECCION Y REALIZAR LAS ACTUALIZACIONES CORRESPONDIENTES

create procedure actualizarColeccion (@id nchar(10), @nombre nvarchar(50),@precio decimal,@id_persona nchar(10),@Parametros nvarchar(Max))
as
begin
	update Coleccion set nombre_coleccion=@nombre, precio=@precio, id_persona=@id_persona where id=@id;
	update Persona set tipo='C' where id=@id_persona;
	update Mariposa set tipo='C' where id in (SELECT * FROM dbo.ArrayToTable(@Parametros));
	delete from Mariposa_en_Observacion;
	delete from Mariposa_en_Coleccion where id_mariposa in (SELECT * FROM dbo.ArrayToTable(@Parametros));
end;