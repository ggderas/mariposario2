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