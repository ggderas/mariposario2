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