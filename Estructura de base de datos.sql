CREATE DATABASE MariposarioDB;
USE MariposarioDB

create table Familia_Natural(
	id nchar(10) not null,
	nombre_familia nvarchar(50),
	constraint familia_naturalPK primary key (id)
);

create table Genero(
	id nchar(10) not null,
	nombre_genero nvarchar(50),
	id_familia nchar(10),
	constraint generoPK primary key (id),
	constraint genero_familiaFK foreign key (id_familia) references Familia_Natural(id) on update cascade on delete cascade
);

create table Especie(
	nombre_cientifico nvarchar(50) not null,
	id_genero nchar(10),
	constraint especiePK primary key (nombre_cientifico),
	constraint especie_generoFK foreign key (id_genero) references Genero(id) on update cascade on delete cascade
);

create table Zona_Geografica(
	nombre_zona nvarchar(50) not null,
	constraint zona_geograficaPK primary key (nombre_zona)
);

create table Especie_Zona_Geografica(
	id_especie nvarchar(50) not null,
	nombre_zona nvarchar(50) not null,
	nombre_comun_especie nvarchar(50),
	constraint especie_zgPK primary key (id_especie,nombre_zona),
	constraint especie_zg_especieFK foreign key (id_especie) references Especie(nombre_cientifico) on update cascade on delete cascade,
	constraint especie_zg_zgFK foreign key (nombre_zona) references Zona_Geografica(nombre_zona) on update cascade on delete cascade
);

create table Persona(
	id nchar(10) not null,
	nombres_persona nvarchar(50),
	apellidos_persona nvarchar(50),
	tipo nvarchar(1) DEFAULT 'B',
	constraint personaPK primary key (id)
);

create table Mariposa(
	id nchar(10) not null,
	fecha_captura date,
	nombre_cientifico nvarchar(50),
	tipo  nvarchar(50),
	id_persona nchar(10),
	zona_geografica nvarchar(50) not null,
	constraint mariposaPK primary key (id),
	liberado BIT NOT NULL,
	constraint mariposa_especieFK foreign key (nombre_cientifico) references Especie(nombre_cientifico) on update cascade on delete cascade,
	constraint mariposa_personaFK foreign key (id_persona) references Persona(id) on update cascade on delete cascade,
	constraint mariposa_zonaFK foreign key (zona_geografica) references Zona_Geografica(nombre_zona) ON UPDATE CASCADE ON DELETE CASCADE
);

create table Coleccion(
	id nchar(10) not null,
	nombre_coleccion nvarchar(50),
	precio decimal,
	fecha_inicio date,
	id_persona nchar(10) UNIQUE,
	constraint coleccionPK primary key (id),
	constraint coleccion_personaFK foreign key (id_persona) references Persona(id) on update cascade on delete cascade
);

--Modificación del tipo de campo tiempo_observación ya que debería ser Date/time dado que C# no posee un tipo de dato time.
create table Mariposa_en_Observacion(
	id_mariposa nchar(10) not null,
	tiempo_observacion DECIMAL,
	constraint mariposa_oPK primary key (id_mariposa),
	constraint mariposa_o_mariposaFK foreign key (id_mariposa) references Mariposa(id) on update cascade on delete cascade
);

create table Mariposa_en_Coleccion(
	id_mariposa nchar(10) not null,
	precio decimal,
	id_coleccion nchar(10) not null,
	constraint mariposa_cPK primary key (id_mariposa),
	constraint mariposa_c_mariposaFK foreign key (id_mariposa) references Mariposa(id) on update cascade on delete cascade, 
	constraint mariposa_o_coleccionFK foreign key (id_coleccion) references Coleccion(id) 
);
