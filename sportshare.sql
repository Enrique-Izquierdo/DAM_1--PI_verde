CREATE DATABASE if NOT EXISTS sportshare CHARACTER SET UTF8;

SET default_storage_engine=INNODB;

USE sportshare;

CREATE TABLE if NOT EXISTS Usuarios
(id_usuario INTEGER NOT NULL AUTO_INCREMENT,
alias VARCHAR(25) NOT NULL,
nombre VARCHAR(20) NOT NULL,
apellidos VARCHAR(50) NOT NULL,
fecha DATETIME NOT NULL,
telefono INTEGER NOT NULL,
poblacion VARCHAR(35) NOT NULL,
provincia VARCHAR(30) NOT NULL,
peso INTEGER,
altura INTEGER,
deporte VARCHAR(30),
enfermedades VARCHAR(100),
imagen LONGBLOB,
total INTEGER,
total_positivas INTEGER NOT NULL,
total_indiferentes INTEGER NOT NULL,
total_negativas INTEGER NOT NULL,
PRIMARY KEY(id_usuario));

CREATE TABLE if NOT EXISTS Campeonato
(id_campeonato INTEGER NOT NULL AUTO_INCREMENT,
nombre VARCHAR(20) NOT NULL,
descripcion VARCHAR(280) NOT NULL,
PRIMARY KEY(id_campeonato));

CREATE TABLE if NOT EXISTS Actividad
(id_actividad INTEGER NOT NULL AUTO_INCREMENT,
tipo VARCHAR(30) NOT NULL,
nombre VARCHAR(20) NOT NULL,
descripcion VARCHAR(280) NOT NULL,
direccion VARCHAR(60) NOT NULL,
poblacion VARCHAR(35) NOT NULL,
provincia VARCHAR(30) NOT NULL,
fecha_hora DATETIME NOT NULL,
plazas INTEGER NOT NULL,
requerimientos VARCHAR(100),
fecha_limite DATETIME NOT NULL,
edad_limite INTEGER,
nivel_requerido VARCHAR(20),
informacion_extra VARCHAR(100),
dinero DOUBLE(5,3) NOT NULL,
id_creador INTEGER NOT NULL,
id_campeonato INTEGER NOT NULL,
PRIMARY KEY(id_actividad),
FOREIGN KEY(id_campeonato) REFERENCES campeonato(id_campeonato));

CREATE TABLE if NOT EXISTS Participar
(id_usuario INTEGER NOT NULL,
id_actividad INTEGER NOT NULL,
tiene_plaza BOOLEAN NOT NULL,
PRIMARY KEY(id_usuario, id_actividad),
FOREIGN KEY(id_usuario) REFERENCES Usuarios(id_usuario),
FOREIGN KEY(id_actividad) REFERENCES Actividad(id_actividad));

CREATE TABLE if NOT EXISTS Mensaje
(id_mensaje INTEGER NOT NULL AUTO_INCREMENT,
texto_mensaje VARCHAR(999) NOT NULL,
id_usuarioReceptor INTEGER NOT NULL,
fecha_hora DATETIME NOT NULL,
PRIMARY KEY(id_mensaje),
FOREIGN KEY(id_usuarioReceptor) REFERENCES Usuarios(id_usuario));

CREATE TABLE if NOT EXISTS Valoracion
(id_valoracion INTEGER NOT NULL AUTO_INCREMENT,
contenido_Valoracion ENUM('contento','indiferente','triste') NOT NULL,
fecha_hora DATETIME NOT NULL,
id_usuario INTEGER NOT NULL,
id_actividad INTEGER NOT NULL,
PRIMARY KEY(id_valoracion),
FOREIGN KEY(id_usuario) REFERENCES Participar(id_usuario),
FOREIGN KEY(id_actividad) REFERENCES Participar(id_actividad));