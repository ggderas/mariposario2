--1
CREATE PROCEDURE consulta1 
AS
BEGIN
	SELECT * FROM Especie
	WHERE Especie.nombre_cientifico IN
	(
		SELECT Mariposa.nombre_cientifico FROM Mariposa
		WHERE DATEPART(MONTH, Mariposa.fecha_captura) >= 4
		AND DATEPART(YEAR, Mariposa.fecha_captura) >= 1999
	)
END;

--2
CREATE PROCEDURE consulta2
AS
BEGIN
	SELECT Zona_Geografica.nombre_zona AS 'Zona', Especie_Zona_Geografica.nombre_comun_especie AS 'Nombre Comun', 
			Especie.nombre_cientifico AS 'Nombre científico'
	
	FROM Zona_Geografica INNER JOIN Especie_Zona_Geografica ON Zona_Geografica.nombre_zona = Especie_Zona_Geografica.nombre_zona
	INNER JOIN Especie ON Especie.nombre_cientifico = Especie_Zona_Geografica.id_especie
	WHERE Especie.nombre_cientifico IN
	(
		SELECT Mariposa.nombre_cientifico FROM Mariposa
		WHERE DATEPART(YEAR,Mariposa.fecha_captura) BETWEEN 1996 AND 1997
	)
	GROUP BY Zona_Geografica.nombre_zona, Especie_Zona_Geografica.nombre_comun_especie, Especie.nombre_cientifico
END;

--5
create procedure consulta5 as
begin
	select Especie.nombre_cientifico as 'Nombre Cientifico de Especie', Genero.id as 'ID Genero', Genero.nombre_genero as 'Nombre Genero', 
	Familia_Natural.id as 'ID Familia Natural', Familia_Natural.nombre_familia as 'Nombre Familia Natural'
	from ((Especie inner join Genero on Genero.id=Especie.id_genero) 
	inner join Familia_Natural on Familia_Natural.id=Genero.id_familia)
	where nombre_cientifico not in (select nombre_cientifico from Mariposa);
end;
--6
create procedure consulta6 as
begin
	select zona_geografica as 'Zona Geográfica', Count(zona_geografica) as 'Cantidad de capturas' 
	from Mariposa group by zona_geografica having Count(zona_geografica) > 6 order by Count(zona_geografica) ASC
end;

--7

   CREATE VIEW Consulta7
AS
SELECT Coleccion.id AS "ID Coleccción", Coleccion.nombre_coleccion AS "Nombre Colección",Coleccion.precio AS "Precio Colección ",
	Persona.id AS "DNI Persona",persona.nombres_persona AS "Nombre Persona",Persona.apellidos_persona AS "Apellido Persona"  
FROM Mariposa_en_Coleccion JOIN COLECCION ON (Coleccion.id = Mariposa_en_Coleccion.id_coleccion) 
 JOIN Mariposa  ON ( Mariposa.id = Mariposa_en_Coleccion.id_mariposa and YEAR(Mariposa.fecha_captura)>=1996)
 JOIN Persona ON ( persona.id = Mariposa.id_persona)

 
--8

CREATE VIEW Consulta8 as
SELECT P.id AS DNI, P.nombres_persona AS NOMBRE ,P.apellidos_persona AS APELLIDO FROM Persona AS P
WHERE P.id IN (SELECT M.id_persona  FROM Mariposa AS M WHERE M.fecha_captura<'5-10-1990')
AND P.id NOT IN(SELECT C.id FROM Coleccion AS C)
			 