USE master;
DROP DATABASE VB_Users;

CREATE DATABASE VB_Users;
USE VB_Users;

DROP TABLE IF EXISTS UserStatus;
CREATE TABLE UserStatus(
	id INT NOT NULL PRIMARY KEY,
	value VARCHAR(30) NOT NULL UNIQUE
);

INSERT INTO UserStatus(id, value) VALUES 
(1, 'Active'),
(2, 'Inactive'),
(3, 'Blocked');

DROP TABLE IF EXISTS UserType;
CREATE TABLE UserType(
	id INT NOT NULL PRIMARY KEY,
	value VARCHAR(30) NOT NULL UNIQUE
);

INSERT INTO UserType(id, value) VALUES
(1, 'Administrador'),
(2, 'Profesor'),
(3, 'Estudiante');

DROP TABLE IF EXISTS Users;
CREATE TABLE Users(
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	username VARCHAR(30) NOT NULL UNIQUE,
	password VARCHAR(30) NOT NULL,
	name VARCHAR(100) NOT NULL,
	status INT NOT NULL REFERENCES UserStatus(id),
	type INT NOT NULL REFERENCES UserType(id)
);