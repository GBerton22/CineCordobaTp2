--CREATE DATABASE Cordoba_Cine_GRUPO_N9	
--USE Cordoba_Cine_GRUPO_N9
--SET DATEFORMAT dmy

-- /////////////////// - PARTE 1 - ////////////////////
-- ////////////// - CREACION DE TABLAS - //////////////

--select * from funciones where id_funcion = 9	
ALTER TABLE reservas
DROP CONSTRAINT fk_funcion;


CREATE TABLE provincias
(id_provincia int identity(1,1),
provincia varchar(50)
CONSTRAINT pk_provincias PRIMARY KEY (id_provincia)
)


CREATE TABLE ciudades
(id_ciudad int identity(1,1),
ciudad varchar(50),
id_provincia int
CONSTRAINT pk_ciudades PRIMARY KEY(id_ciudad),
CONSTRAINT fk_ciudades_provincias FOREIGN KEY (id_provincia)
           REFERENCES provincias (id_provincia)
)

CREATE TABLE barrios
(id_barrio int identity(1,1),
barrio varchar(50),
id_ciudad int
CONSTRAINT pk_barrios PRIMARY KEY(id_barrio),
CONSTRAINT fk_barrios_ciudades FOREIGN KEY(id_ciudad)
           REFERENCES ciudades(id_ciudad)
)

CREATE TABLE tipos_documentos
(id_tipo_doc int identity(1,1),
tipo_doc varchar(30)
CONSTRAINT pk_tipos_documentos PRIMARY KEY(id_tipo_doc)
)

CREATE TABLE clientes
(id_cliente int identity(1,1),
nombre varchar(40) not null,
apellido varchar(40) not null,
fecha_nac smalldatetime,
teléfono int not null,
email varchar(30),
id_barrio int,
calle varchar(20),
altura int ,
id_tipo_doc int,
nro_doc int not null
CONSTRAINT pk_id_cliente PRIMARY KEY (id_cliente),
CONSTRAINT fk_clientes_barrios FOREIGN KEY (id_barrio) 
           REFERENCES barrios(id_barrio),
CONSTRAINT fk_clientes_tipos_documentos FOREIGN KEY(id_tipo_doc) 
           REFERENCES tipos_documentos(id_tipo_doc) 
)

create table tipos_salas(
id_tipo_sala int identity(1,1),
tipo varchar (20),
precio smallmoney,

constraint pk_tipo_salas primary key (id_tipo_sala)
)

create table butacas(
id_butaca int identity(1,1),
fila int,
columna int,
constraint pk_butacas primary key (id_butaca)

)

create table salas(
id_sala int ,
id_tipo_sala int,
constraint pk_salas primary key (id_sala),
constraint fk_salas_tipos_salas foreign key (id_tipo_sala)
references tipos_salas (id_tipo_sala)
)

create table salasXbutacas(
id_sala_butaca int identity (1,1),
id_sala int,
id_butaca int,
constraint pk_salasXbutacas primary key (id_sala_butaca),
constraint fk_salas foreign key (id_sala)
references salas (id_sala),
constraint fk_Butacas foreign key (id_butaca)
references butacas (id_butaca)
)

create table sucursales (
id_sucursal int,
nombre_sucursal varchar (30),
id_barrio int,
calle varchar(60),
altura int,
constraint pk_sucursales primary key (id_sucursal),
constraint fk_barrios foreign key (id_barrio)
references Barrios (id_barrio)
)

create table salasXsucursales(
id_sala_sucursal int identity(1,1),
id_sucursal int,
id_sala int,
constraint pk_salasXsucursales primary key (id_sala_sucursal),
constraint fk_salasXsucursales_id_Salas foreign key (id_sala)
references salas (id_sala),
constraint fk_sucursales foreign key (id_sucursal)
references sucursales (id_sucursal)
)

CREATE TABLE clasificaciones(
id_clasificacion int identity(1,1),
clasificacion varchar(30),
constraint pk_clasificaciones primary key (id_clasificacion)
)

CREATE TABLE idiomas(
id_idioma int identity(1,1),
idioma varchar(30),
constraint pk_idiomas primary key (id_idioma)
)

CREATE TABLE generos(
id_genero int identity(1,1),
genero varchar(30),
constraint pk_generos primary key (id_genero)
)

CREATE TABLE peliculas(
id_pelicula int, 
nombre_pelicula varchar(30),
id_genero int, 
id_clasificacion int,
id_idioma int,
duracion varchar(30),
constraint pk_peliculas primary key (id_pelicula),
constraint fk_generos foreign key (id_genero) references
generos (id_genero),
constraint fk_clasificaciones foreign key (id_clasificacion)
references clasificaciones (id_clasificacion),
constraint id_idiomas foreign key (id_idioma) references
idiomas (id_idioma)
)

create table horarios
(id_horario int identity(1,1),
inicio time,
final time,
constraint pk_horario primary key (id_horario))

create table funciones
(id_funcion int identity(1,1),
id_horario int,
fecha datetime,
subtitulo bit,
id_pelicula int,
id_sala int,
constraint pk_funcion primary key (id_funcion),
constraint fk_horario foreign key (id_horario)
references horarios (id_horario),
constraint fk_pelicula foreign key (id_pelicula)
references peliculas (id_pelicula),
constraint fk_sala foreign key (id_sala)
references salas (id_sala))

create table estado_butacas
(id_estado_butacas int,
estado varchar(50),
constraint pk_estado_butacas primary key (id_estado_butacas))

create table reservas
(id_reserva int identity(1,1),
id_cliente int,
id_funcion int,
constraint pk_reservas primary key (id_reserva),
constraint fk_cliente foreign key (id_cliente)
references clientes (id_cliente),
constraint fk_funcion foreign key (id_funcion)
references funciones (id_funcion)
ON DELETE CASCADE
)

create table promos
(id_promo int,
nombre_promo varchar(50),
descuento decimal (4,2),
constraint pk_promo primary key (id_promo))

CREATE TABLE VENDEDORES
(id_vendedor INT IDENTITY (1,1),
nombre varchar (100),
apellido varchar (100),
id_tipo_documento int,
nro_documento varchar(100),
email varchar(100),
telefono varchar(100),
id_barrio int,
calle varchar(100),
altura int,
CONSTRAINT PK_VENDEDORES PRIMARY KEY (id_vendedor),
CONSTRAINT FK_VENDEDORES_id_tipo_documento FOREIGN KEY (id_tipo_documento)
			REFERENCES tipos_documentos (id_tipo_doc),
CONSTRAINT FK_VENDEDORES_id_barrio FOREIGN KEY (id_barrio)
			REFERENCES barrios (id_barrio))

CREATE TABLE FORMAS_PAGO
(id_formas_pago INT IDENTITY (1,1),
formas_pago varchar (100)
CONSTRAINT PK_FORMAS_PAGO PRIMARY KEY (id_formas_pago))

CREATE TABLE COMPROBANTES
(id_comprobante INT IDENTITY (1,1),
fecha_compra datetime NOT NULL,
id_cliente int NOT NULL,
id_sucursal int NOT NULL,
id_forma_pago int NOT NULL,
id_vendedor int NOT NULL,
CONSTRAINT PK_COMPROBANTES PRIMARY KEY (id_comprobante),
CONSTRAINT FK_COMPROBANTES_id_clientes FOREIGN KEY (id_cliente)
			REFERENCES clientes (id_cliente),
CONSTRAINT FK_COMPROBANTES_id_
FOREIGN KEY (id_sucursal)
			REFERENCES sucursales (id_sucursal),
CONSTRAINT FK_COMPROBANTES_id_forma_pago FOREIGN KEY (id_forma_pago)
			REFERENCES formas_pago (id_formas_pago),
CONSTRAINT FK_COMPROBANTES_id_vendedores FOREIGN KEY (id_vendedor)
			REFERENCES vendedores (id_vendedor))

CREATE TABLE DETALLES_COMPROBANTES
(id_detalle_comprobante INT IDENTITY (1,1),
id_funcion int,
id_comprobante int,
precio decimal,
id_promo int
CONSTRAINT PK_DETALLES_COMPROBANTES PRIMARY KEY (id_detalle_comprobante),
CONSTRAINT FK_DETALLES_COMPROBANTES_id_funcion FOREIGN KEY (id_funcion)
			REFERENCES funciones (id_funcion),
CONSTRAINT FK_DETALLES_COMPROBANTES_id_comprobante FOREIGN KEY (id_comprobante)
			REFERENCES COMPROBANTES (id_comprobante),
CONSTRAINT FK_DETALLES_COMPROBANTES_id_promo FOREIGN KEY (id_promo)
			REFERENCES promos (id_promo))

ALTER TABLE DETALLES_COMPROBANTES
DROP CONSTRAINT FK_DETALLES_COMPROBANTES_id_funcion;

ALTER TABLE DETALLES_COMPROBANTES
ADD CONSTRAINT FK_DETALLES_COMPROBANTES_id_funcion
FOREIGN KEY (id_funcion)
REFERENCES FUNCIONES (id_funcion)
ON DELETE CASCADE;

create table usuarios(
id_usuario int,
usuario varchar(10),
contraseña varchar(10)
constraint pk_usuarios primary key (id_usuario)
)

			-- ////////////// - Modificacion Butacas  - //////////////

			alter table butacas
add Id_estado_butaca int



			alter table butacas 
add constraint fk_butacas_estados foreign key (Id_estado_butaca)
references Estado_butacas (id_estado_butacas)


-- ////////////// - CARGA DE DATOS - //////////////

---USUARIOS---

insert into usuarios(id_usuario,usuario,contraseña) values (1,'admin','admin123')
---TIPOS_DOCUMENTOS---

INSERT INTO tipos_documentos(tipo_doc) VALUES ('DNI')
INSERT INTO tipos_documentos(tipo_doc) VALUES ('PASAPORTE')
INSERT INTO tipos_documentos(tipo_doc) VALUES ('TARJETA DE RESIDENCIA')
INSERT INTO tipos_documentos(tipo_doc) VALUES ('LIBRETA CIVICA')

---PROVINCIAS----------------------------------------------------------------
INSERT INTO provincias (provincia) VALUES ('CÓRDOBA')
INSERT INTO provincias (provincia) VALUES ('SAN LUIS')

---CIUDADES------------------------------------------------------------------
INSERT INTO ciudades (ciudad,id_provincia) VALUES ('Córdoba capital',1 )
INSERT INTO ciudades (ciudad,id_provincia) VALUES ('Jesús María', 1)
INSERT INTO ciudades (ciudad,id_provincia) VALUES ('Alta Gracia', 1)
INSERT INTO ciudades (ciudad,id_provincia) VALUES ('Villa Carlos Paz', 1)
INSERT INTO ciudades (ciudad,id_provincia) VALUES ('Villa María', 1)
INSERT INTO ciudades (ciudad,id_provincia) VALUES ('La Calera', 1)
INSERT INTO ciudades (ciudad,id_provincia) VALUES ('San Luis capital', 2)
INSERT INTO ciudades (ciudad,id_provincia) VALUES ('Villa Mercedes', 2)
INSERT INTO ciudades (ciudad,id_provincia) VALUES ('Villa de Merlo', 2)
INSERT INTO ciudades (ciudad,id_provincia) VALUES ('Concarán', 2)

---BARRIOS------------------------------------------------------------------
INSERT INTO barrios (barrio,id_ciudad) VALUES ('Centro',1 )
INSERT INTO barrios (barrio,id_ciudad) VALUES ('Nueva Córdoba', 1)
INSERT INTO barrios (barrio,id_ciudad) VALUES ('Cerro', 1)
INSERT INTO barrios (barrio,id_ciudad) VALUES ('Alto Alberdi', 1)
INSERT INTO barrios (barrio,id_ciudad) VALUES ('La Florida', 2)
INSERT INTO barrios (barrio,id_ciudad) VALUES ('Las Vertientes', 2)
INSERT INTO barrios (barrio,id_ciudad) VALUES ('Parque del Virrey', 3)
INSERT INTO barrios (barrio,id_ciudad) VALUES ('Camara', 3)
INSERT INTO barrios (barrio,id_ciudad) VALUES ('Villa del Lago',4 )
INSERT INTO barrios (barrio,id_ciudad) VALUES ('Colinas',4 )
INSERT INTO barrios (barrio,id_ciudad) VALUES ('General San Martin', 5)
INSERT INTO barrios (barrio,id_ciudad) VALUES ('Industrial', 5)
INSERT INTO barrios (barrio,id_ciudad) VALUES ('El Balcón', 6)
INSERT INTO barrios (barrio,id_ciudad) VALUES ('Villa del Sol', 6)
INSERT INTO barrios (barrio,id_ciudad) VALUES ('Las Américas', 7)
INSERT INTO barrios (barrio,id_ciudad) VALUES ('Libertad', 7)
INSERT INTO barrios (barrio,id_ciudad) VALUES ('Los Poetas', 8)
INSERT INTO barrios (barrio,id_ciudad) VALUES ('Los Acacios', 8)
INSERT INTO barrios (barrio,id_ciudad) VALUES ('Los Nogales', 9)
INSERT INTO barrios (barrio,id_ciudad) VALUES ('Nuevo Merlo', 9)
INSERT INTO barrios (barrio,id_ciudad) VALUES ('Leticia', 10)
INSERT INTO barrios (barrio,id_ciudad) VALUES ('Parque', 10)

---CLIENTES------------------------------------------------------------------
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Tomás ', 'Lopéz','25/08/1992 ',3518789721  ,'tomLopez@gmail.com ',1 ,'Av.Malvinas',2547 ,1 ,42257890)
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Amelia ', 'Espinosa ','02/07/1960 ',3534891011 ,'amelia_e@hotmail.com ',1 ,'Caseros ',1524 ,2 ,20782101)
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Constantino ', 'Escobar ','12/01/1947 ',4587526 ,null ,2 ,'monasterio ',245 ,3 ,2065489)
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Mara ', 'Solano ','25/09/1995 ',20489752 ,'msolano@outlook.com ',2 ,'Maestro Vidal ',354 ,4 ,39875245 )
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Jesús', 'Montenegro ','14/06/1958 ',4527892 ,null ,3 ,'Luna ',3005 ,1 ,2687956)
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Martin ', 'Cuadrado ','16/11/1960 ',3157895 ,'cuadradomartin@gmail.com ',3 ,'Dean funes ',2500 ,2 ,3589453 )
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Lara ', 'Mariño ','23/09/1998 ',2358795 ,'lmariño@gmail.com ',4 ,'Colón ',3589 ,3 ,2458976 )
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Olga ', 'Quiros ','10/05/1993 ',2597896 ,'olga123@gmail.com ',4 ,'Montevideo ',4896 ,4 ,879616 )
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Francisco ', 'Adan ','27/04/1999 ',3547895897 ,'franadan@gmail.com ',5 ,'Crisol ',4599 ,1 ,4257895 )
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Valentina ', 'Alcalde ','26/11/1997 ',351789945 ,'valealcalde@gmail.com ',5 ,'General paz ',633 ,2 ,42356988 )
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Angel ', 'Chacon ','11/03/1987 ',35147997 ,'chacon@gmail.com ',6 ,'Velez ',4879 ,3 ,4879856)
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Nicolas ', 'Cerro ','25/02/2003 ',35078956 ,'cerro_n@hotmail.com ',7 ,'Garibaldi ',1234 ,4 ,2547896 )
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Mateo ', 'Corrado ','18/02/2009 ',35084956 ,'corrado@hotmail.com ',8 ,'Gales ',1454 ,1 ,87996 )
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Clarisa ', 'viña ','25/02/2003 ',35078956 ,'cv@hotmail.com ',9 ,'Lima ',4528 ,2 ,4258798 )
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Virgilio ', 'Linares ','25/02/1970 ',3556489 ,null,10 ,'Monseñor ',789,3 ,288996 )
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Silvina ', 'Miranda','03/12/2005 ',3788956 ,'silvi@gmail.com',11 ,'Junin',1412 ,4 ,786 )
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Lautaro ', 'Cordoba ','19/04/2011 ',3515496 ,'lauti@hotmail.com',12,'Gomes ',1288 ,1 ,4875596 )
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Milagros ', 'Beniteo ','05/10/1996 ',35059856 ,'milib@gmail.com ',13,'Baldi ',3568 ,1 ,40589896 )
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Agustina ', 'Baldi ','27/07/2000 ',4528956 ,'agb@hotmail.com ', 14,'Buenos Aires ',5484 ,2 ,458896 )
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Lucas ', 'Molina ','10/10/1992 ',35078956 ,'luca@hotmail.com ',15 ,'Rivadavia ',4254 ,3 ,54752896 )
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Clara ', 'Vazques ',null, 45874956 ,'clara@hotmail.com ',16,'Grilla ',5254 ,1 ,20897534 )
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Benjamin ', 'Acosta','10/02/1969 ',30078956 ,'benja@hotmail.com ',17 ,'Luna y cardenas ',3528 ,4 ,4258798 )
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Alana ', 'Lira ','20/01/1989 ',35578989 ,'alilira@gmail.com',18 ,'Monseñor ',1259,3 ,288996 )
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Silvana ', 'Lopez','12/12/1985 ',155788956 ,'sil@gmail.com',19 ,'Felix paz',112 ,1,78646789 )
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Laureano ', 'Cordoba ','12/10/1995 ',156715496 ,'lau789@hotmail.com',20,'Gauss ',1272 ,1 ,3549596 )
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Milagros ', 'Suarez ','07/02/2000 ',47899856 ,'mili123@gmail.com ',15,'Boulevar ',785 ,1 ,4071096 )
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Augusto ', 'Luna','22/07/2003 ',154788956 ,'augusto@hotmail.com ', 13,'Roma',5184 ,2 ,451296 )
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Lisandro ', 'Junca ','15/08/2000 ',35120256 ,null,18,'Rivadavia ',3200 ,1 ,45752896 )
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Adriana ', 'Linares','10/10/1968 ',13578954 ,'adri@hotmail.com ', 20,'Caseros',4265 ,3 ,451296 )
INSERT INTO clientes (nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc) 
            VALUES('Rafael ', 'Medina ','25/06/1968 ',351007852 ,null,10,'Cayetano Silva ',163 ,1 ,45752224 )

-------------------------------------------------------
--Agustin(estado butaca)
-----------------------------------------------------
insert into estado_butacas (id_estado_butacas, estado)
		values (1, 'Libre')
insert into estado_butacas (id_estado_butacas, estado)
		values (2, 'Reservado')
insert into estado_butacas (id_estado_butacas, estado)
		values (3, 'Comprado')

---------------------------------------------------------
-- ↓ TOMAS ↓
---------------------------------------------------------
insert into tipos_salas(tipo,precio) values('2D',2380)
insert into tipos_salas(tipo,precio) values('2D Confort',2880)
insert into tipos_salas(tipo,precio) values('3D',3860)
insert into tipos_salas(tipo,precio) values('3D Confort',4000)
insert into tipos_salas(tipo,precio) values('Premium',5100)
insert into tipos_salas(tipo,precio) values('Imax',6080)

insert into butacas(fila,columna,Id_estado_butaca) values (1,1,1)
insert into butacas(fila,columna,Id_estado_butaca) values (1,2,1)
insert into butacas(fila,columna,Id_estado_butaca) values (1,3,1)
insert into butacas(fila,columna,Id_estado_butaca) values (1,4,1)
insert into butacas(fila,columna,Id_estado_butaca) values (1,5,1) --5
															  
insert into butacas(fila,columna,Id_estado_butaca) values (2,1,1)
insert into butacas(fila,columna,Id_estado_butaca) values (2,2,1)
insert into butacas(fila,columna,Id_estado_butaca) values (2,3,1)
insert into butacas(fila,columna,Id_estado_butaca) values (2,4,1)
insert into butacas(fila,columna,Id_estado_butaca) values (2,5,1)--10
															  
insert into butacas(fila,columna,Id_estado_butaca) values (3,1,1)
insert into butacas(fila,columna,Id_estado_butaca) values (3,2,1)
insert into butacas(fila,columna,Id_estado_butaca) values (3,3,1)
insert into butacas(fila,columna,Id_estado_butaca) values (3,4,1)
insert into butacas(fila,columna,Id_estado_butaca) values (3,5,1)--15
															  
insert into butacas(fila,columna,Id_estado_butaca) values (4,1,1)
insert into butacas(fila,columna,Id_estado_butaca) values (4,2,1)
insert into butacas(fila,columna,Id_estado_butaca) values (4,3,1)
insert into butacas(fila,columna,Id_estado_butaca) values (4,4,1)
insert into butacas(fila,columna,Id_estado_butaca) values (4,5,1)--20
															  
insert into butacas(fila,columna,Id_estado_butaca) values (5,1,1)
insert into butacas(fila,columna,Id_estado_butaca) values (5,2,1)
insert into butacas(fila,columna,Id_estado_butaca) values (5,3,1)
insert into butacas(fila,columna,Id_estado_butaca) values (5,4,1)
insert into butacas(fila,columna,Id_estado_butaca) values (5,5,1)--25

insert into butacas(fila,columna,Id_estado_butaca) values (6,1,1)
insert into butacas(fila,columna,Id_estado_butaca) values (6,2,1)
insert into butacas(fila,columna,Id_estado_butaca) values (6,3,1)
insert into butacas(fila,columna,Id_estado_butaca) values (6,4,1)
insert into butacas(fila,columna,Id_estado_butaca) values (6,5,1)--30
							
insert into butacas(fila,columna,Id_estado_butaca) values (7,1,1)
insert into butacas(fila,columna,Id_estado_butaca) values (7,2,1)
insert into butacas(fila,columna,Id_estado_butaca) values (7,3,1)
insert into butacas(fila,columna,Id_estado_butaca) values (7,4,1)
insert into butacas(fila,columna,Id_estado_butaca) values (7,5,1)--35
								
insert into butacas(fila,columna,Id_estado_butaca) values (8,1,1)
insert into butacas(fila,columna,Id_estado_butaca) values (8,2,1)
insert into butacas(fila,columna,Id_estado_butaca) values (8,3,1)
insert into butacas(fila,columna,Id_estado_butaca) values (8,4,1)
insert into butacas(fila,columna,Id_estado_butaca) values (8,5,1)--40
							
insert into butacas(fila,columna,Id_estado_butaca) values (9,1,1)
insert into butacas(fila,columna,Id_estado_butaca) values (9,2,1)
insert into butacas(fila,columna,Id_estado_butaca) values (9,3,1)
insert into butacas(fila,columna,Id_estado_butaca) values (9,4,1)
insert into butacas(fila,columna,Id_estado_butaca) values (9,5,1)--45

insert into butacas(fila,columna,Id_estado_butaca) values (10,1,1)
insert into butacas(fila,columna,Id_estado_butaca) values (10,2,1)
insert into butacas(fila,columna,Id_estado_butaca) values (10,3,1)
insert into butacas(fila,columna,Id_estado_butaca) values (10,4,1)
insert into butacas(fila,columna,Id_estado_butaca) values (10,5,1)--50

insert into salas(id_sala,id_tipo_sala) values(1,1) --2d
insert into salas(id_sala,id_tipo_sala) values(2,1) --2d

insert into salas(id_sala,id_tipo_sala) values(3,2) --2d confort
insert into salas(id_sala,id_tipo_sala) values(4,2) --2d confort

insert into salas(id_sala,id_tipo_sala) values(5,3) --3d
insert into salas(id_sala,id_tipo_sala) values(6,3) --3d

insert into salas(id_sala,id_tipo_sala) values(7,4)--3d confort
insert into salas(id_sala,id_tipo_sala) values(8,4)--3d confort

insert into salas(id_sala,id_tipo_sala) values(9,5)--premium
insert into salas(id_sala,id_tipo_sala) values(10,6)--imax

--Carga sala 1 2d 25 butacas--
insert into salasXbutacas(id_sala,id_butaca) values (1,1)
insert into salasXbutacas(id_sala,id_butaca) values (1,2)
insert into salasXbutacas(id_sala,id_butaca) values (1,3)
insert into salasXbutacas(id_sala,id_butaca) values (1,4)
insert into salasXbutacas(id_sala,id_butaca) values (1,5)
insert into salasXbutacas(id_sala,id_butaca) values (1,6)
insert into salasXbutacas(id_sala,id_butaca) values (1,7)
insert into salasXbutacas(id_sala,id_butaca) values (1,8)
insert into salasXbutacas(id_sala,id_butaca) values (1,9)
insert into salasXbutacas(id_sala,id_butaca) values (1,10)
insert into salasXbutacas(id_sala,id_butaca) values (1,11)
insert into salasXbutacas(id_sala,id_butaca) values (1,12)
insert into salasXbutacas(id_sala,id_butaca) values (1,13)
insert into salasXbutacas(id_sala,id_butaca) values (1,14)
insert into salasXbutacas(id_sala,id_butaca) values (1,15)
insert into salasXbutacas(id_sala,id_butaca) values (1,16)
insert into salasXbutacas(id_sala,id_butaca) values (1,17)
insert into salasXbutacas(id_sala,id_butaca) values (1,18)
insert into salasXbutacas(id_sala,id_butaca) values (1,19)
insert into salasXbutacas(id_sala,id_butaca) values (1,20)
insert into salasXbutacas(id_sala,id_butaca) values (1,21)
insert into salasXbutacas(id_sala,id_butaca) values (1,22)
insert into salasXbutacas(id_sala,id_butaca) values (1,23)
insert into salasXbutacas(id_sala,id_butaca) values (1,24)
insert into salasXbutacas(id_sala,id_butaca) values (1,25)


--carga sala 2 2d 25 butacas--
insert into salasXbutacas(id_sala,id_butaca) values (2,1)
insert into salasXbutacas(id_sala,id_butaca) values (2,2)
insert into salasXbutacas(id_sala,id_butaca) values (2,3)
insert into salasXbutacas(id_sala,id_butaca) values (2,4)
insert into salasXbutacas(id_sala,id_butaca) values (2,5)
insert into salasXbutacas(id_sala,id_butaca) values (2,6)
insert into salasXbutacas(id_sala,id_butaca) values (2,7)
insert into salasXbutacas(id_sala,id_butaca) values (2,8)
insert into salasXbutacas(id_sala,id_butaca) values (2,9)
insert into salasXbutacas(id_sala,id_butaca) values (2,10)
insert into salasXbutacas(id_sala,id_butaca) values (2,11)
insert into salasXbutacas(id_sala,id_butaca) values (2,12)
insert into salasXbutacas(id_sala,id_butaca) values (2,13)
insert into salasXbutacas(id_sala,id_butaca) values (2,14)
insert into salasXbutacas(id_sala,id_butaca) values (2,15)
insert into salasXbutacas(id_sala,id_butaca) values (2,16)
insert into salasXbutacas(id_sala,id_butaca) values (2,17)
insert into salasXbutacas(id_sala,id_butaca) values (2,18)
insert into salasXbutacas(id_sala,id_butaca) values (2,19)
insert into salasXbutacas(id_sala,id_butaca) values (2,20)
insert into salasXbutacas(id_sala,id_butaca) values (2,21)
insert into salasXbutacas(id_sala,id_butaca) values (2,22)
insert into salasXbutacas(id_sala,id_butaca) values (2,23)
insert into salasXbutacas(id_sala,id_butaca) values (2,24)
insert into salasXbutacas(id_sala,id_butaca) values (2,25)


--carga sala 3 2d 25 butacas--
insert into salasXbutacas(id_sala,id_butaca) values (3,1)
insert into salasXbutacas(id_sala,id_butaca) values (3,2)
insert into salasXbutacas(id_sala,id_butaca) values (3,3)
insert into salasXbutacas(id_sala,id_butaca) values (3,4)
insert into salasXbutacas(id_sala,id_butaca) values (3,5)
insert into salasXbutacas(id_sala,id_butaca) values (3,6)
insert into salasXbutacas(id_sala,id_butaca) values (3,7)
insert into salasXbutacas(id_sala,id_butaca) values (3,8)
insert into salasXbutacas(id_sala,id_butaca) values (3,9)
insert into salasXbutacas(id_sala,id_butaca) values (3,10)
insert into salasXbutacas(id_sala,id_butaca) values (3,11)
insert into salasXbutacas(id_sala,id_butaca) values (3,12)
insert into salasXbutacas(id_sala,id_butaca) values (3,13)
insert into salasXbutacas(id_sala,id_butaca) values (3,14)
insert into salasXbutacas(id_sala,id_butaca) values (3,15)
insert into salasXbutacas(id_sala,id_butaca) values (3,16)
insert into salasXbutacas(id_sala,id_butaca) values (3,17)
insert into salasXbutacas(id_sala,id_butaca) values (3,18)
insert into salasXbutacas(id_sala,id_butaca) values (3,19)
insert into salasXbutacas(id_sala,id_butaca) values (3,20)
insert into salasXbutacas(id_sala,id_butaca) values (3,21)
insert into salasXbutacas(id_sala,id_butaca) values (3,22)
insert into salasXbutacas(id_sala,id_butaca) values (3,23)
insert into salasXbutacas(id_sala,id_butaca) values (3,24)
insert into salasXbutacas(id_sala,id_butaca) values (3,25)

--sala 4  2d conford 25 butacas--
insert into salasXbutacas(id_sala,id_butaca) values (4,1)
insert into salasXbutacas(id_sala,id_butaca) values (4,2)
insert into salasXbutacas(id_sala,id_butaca) values (4,3)
insert into salasXbutacas(id_sala,id_butaca) values (4,4)
insert into salasXbutacas(id_sala,id_butaca) values (4,5)
insert into salasXbutacas(id_sala,id_butaca) values (4,6)
insert into salasXbutacas(id_sala,id_butaca) values (4,7)
insert into salasXbutacas(id_sala,id_butaca) values (4,8)
insert into salasXbutacas(id_sala,id_butaca) values (4,9)
insert into salasXbutacas(id_sala,id_butaca) values (4,10)
insert into salasXbutacas(id_sala,id_butaca) values (4,11)
insert into salasXbutacas(id_sala,id_butaca) values (4,12)
insert into salasXbutacas(id_sala,id_butaca) values (4,13)
insert into salasXbutacas(id_sala,id_butaca) values (4,14)
insert into salasXbutacas(id_sala,id_butaca) values (4,15)
insert into salasXbutacas(id_sala,id_butaca) values (4,16)
insert into salasXbutacas(id_sala,id_butaca) values (4,17)
insert into salasXbutacas(id_sala,id_butaca) values (4,18)
insert into salasXbutacas(id_sala,id_butaca) values (4,19)
insert into salasXbutacas(id_sala,id_butaca) values (4,20)
insert into salasXbutacas(id_sala,id_butaca) values (4,21)
insert into salasXbutacas(id_sala,id_butaca) values (4,22)
insert into salasXbutacas(id_sala,id_butaca) values (4,23)
insert into salasXbutacas(id_sala,id_butaca) values (4,24)
insert into salasXbutacas(id_sala,id_butaca) values (4,25)

--carga sala 5 2d conford  25 butacas--
insert into salasXbutacas(id_sala,id_butaca) values (5,1)
insert into salasXbutacas(id_sala,id_butaca) values (5,2)
insert into salasXbutacas(id_sala,id_butaca) values (5,3)
insert into salasXbutacas(id_sala,id_butaca) values (5,4)
insert into salasXbutacas(id_sala,id_butaca) values (5,5)
insert into salasXbutacas(id_sala,id_butaca) values (5,6)
insert into salasXbutacas(id_sala,id_butaca) values (5,7)
insert into salasXbutacas(id_sala,id_butaca) values (5,8)
insert into salasXbutacas(id_sala,id_butaca) values (5,9)
insert into salasXbutacas(id_sala,id_butaca) values (5,10)
insert into salasXbutacas(id_sala,id_butaca) values (5,11)
insert into salasXbutacas(id_sala,id_butaca) values (5,12)
insert into salasXbutacas(id_sala,id_butaca) values (5,13)
insert into salasXbutacas(id_sala,id_butaca) values (5,14)
insert into salasXbutacas(id_sala,id_butaca) values (5,15)
insert into salasXbutacas(id_sala,id_butaca) values (5,16)
insert into salasXbutacas(id_sala,id_butaca) values (5,17)
insert into salasXbutacas(id_sala,id_butaca) values (5,18)
insert into salasXbutacas(id_sala,id_butaca) values (5,19)
insert into salasXbutacas(id_sala,id_butaca) values (5,20)
insert into salasXbutacas(id_sala,id_butaca) values (5,21)
insert into salasXbutacas(id_sala,id_butaca) values (5,22)
insert into salasXbutacas(id_sala,id_butaca) values (5,23)
insert into salasXbutacas(id_sala,id_butaca) values (5,24)
insert into salasXbutacas(id_sala,id_butaca) values (5,25)

--Carga sala 6 3d 25 butacas--
insert into salasXbutacas(id_sala,id_butaca) values (6,1)
insert into salasXbutacas(id_sala,id_butaca) values (6,2)
insert into salasXbutacas(id_sala,id_butaca) values (6,3)
insert into salasXbutacas(id_sala,id_butaca) values (6,4)
insert into salasXbutacas(id_sala,id_butaca) values (6,5)
insert into salasXbutacas(id_sala,id_butaca) values (6,6)
insert into salasXbutacas(id_sala,id_butaca) values (6,7)
insert into salasXbutacas(id_sala,id_butaca) values (6,8)
insert into salasXbutacas(id_sala,id_butaca) values (6,9)
insert into salasXbutacas(id_sala,id_butaca) values (6,10)
insert into salasXbutacas(id_sala,id_butaca) values (6,11)
insert into salasXbutacas(id_sala,id_butaca) values (6,12)
insert into salasXbutacas(id_sala,id_butaca) values (6,13)
insert into salasXbutacas(id_sala,id_butaca) values (6,14)
insert into salasXbutacas(id_sala,id_butaca) values (6,15)
insert into salasXbutacas(id_sala,id_butaca) values (6,16)
insert into salasXbutacas(id_sala,id_butaca) values (6,17)
insert into salasXbutacas(id_sala,id_butaca) values (6,18)
insert into salasXbutacas(id_sala,id_butaca) values (6,19)
insert into salasXbutacas(id_sala,id_butaca) values (6,20)
insert into salasXbutacas(id_sala,id_butaca) values (6,21)
insert into salasXbutacas(id_sala,id_butaca) values (6,22)
insert into salasXbutacas(id_sala,id_butaca) values (6,23)
insert into salasXbutacas(id_sala,id_butaca) values (6,24)
insert into salasXbutacas(id_sala,id_butaca) values (6,25)

--carga sala 7 3d 25 butacas--
insert into salasXbutacas(id_sala,id_butaca) values (7,1)
insert into salasXbutacas(id_sala,id_butaca) values (7,2)
insert into salasXbutacas(id_sala,id_butaca) values (7,3)
insert into salasXbutacas(id_sala,id_butaca) values (7,4)
insert into salasXbutacas(id_sala,id_butaca) values (7,5)
insert into salasXbutacas(id_sala,id_butaca) values (7,6)
insert into salasXbutacas(id_sala,id_butaca) values (7,7)
insert into salasXbutacas(id_sala,id_butaca) values (7,8)
insert into salasXbutacas(id_sala,id_butaca) values (7,9)
insert into salasXbutacas(id_sala,id_butaca) values (7,10)
insert into salasXbutacas(id_sala,id_butaca) values (7,11)
insert into salasXbutacas(id_sala,id_butaca) values (7,12)
insert into salasXbutacas(id_sala,id_butaca) values (7,13)
insert into salasXbutacas(id_sala,id_butaca) values (7,14)
insert into salasXbutacas(id_sala,id_butaca) values (7,15)
insert into salasXbutacas(id_sala,id_butaca) values (7,16)
insert into salasXbutacas(id_sala,id_butaca) values (7,17)
insert into salasXbutacas(id_sala,id_butaca) values (7,18)
insert into salasXbutacas(id_sala,id_butaca) values (7,19)
insert into salasXbutacas(id_sala,id_butaca) values (7,20)
insert into salasXbutacas(id_sala,id_butaca) values (7,21)
insert into salasXbutacas(id_sala,id_butaca) values (7,22)
insert into salasXbutacas(id_sala,id_butaca) values (7,23)
insert into salasXbutacas(id_sala,id_butaca) values (7,24)
insert into salasXbutacas(id_sala,id_butaca) values (7,25)

--carga sala 8 3d 25 butacas--
insert into salasXbutacas(id_sala,id_butaca) values (8,1)
insert into salasXbutacas(id_sala,id_butaca) values (8,2)
insert into salasXbutacas(id_sala,id_butaca) values (8,3)
insert into salasXbutacas(id_sala,id_butaca) values (8,4)
insert into salasXbutacas(id_sala,id_butaca) values (8,5)
insert into salasXbutacas(id_sala,id_butaca) values (8,6)
insert into salasXbutacas(id_sala,id_butaca) values (8,7)
insert into salasXbutacas(id_sala,id_butaca) values (8,8)
insert into salasXbutacas(id_sala,id_butaca) values (8,9)
insert into salasXbutacas(id_sala,id_butaca) values (8,10)
insert into salasXbutacas(id_sala,id_butaca) values (8,11)
insert into salasXbutacas(id_sala,id_butaca) values (8,12)
insert into salasXbutacas(id_sala,id_butaca) values (8,13)
insert into salasXbutacas(id_sala,id_butaca) values (8,14)
insert into salasXbutacas(id_sala,id_butaca) values (8,15)
insert into salasXbutacas(id_sala,id_butaca) values (8,16)
insert into salasXbutacas(id_sala,id_butaca) values (8,17)
insert into salasXbutacas(id_sala,id_butaca) values (8,18)
insert into salasXbutacas(id_sala,id_butaca) values (8,19)
insert into salasXbutacas(id_sala,id_butaca) values (8,20)
insert into salasXbutacas(id_sala,id_butaca) values (8,21)
insert into salasXbutacas(id_sala,id_butaca) values (8,22)
insert into salasXbutacas(id_sala,id_butaca) values (8,23)
insert into salasXbutacas(id_sala,id_butaca) values (8,24)
insert into salasXbutacas(id_sala,id_butaca) values (8,25)
 

 --sala 9  3d conford 25 butacas--
insert into salasXbutacas(id_sala,id_butaca) values (9,1)
insert into salasXbutacas(id_sala,id_butaca) values (9,2)
insert into salasXbutacas(id_sala,id_butaca) values (9,3)
insert into salasXbutacas(id_sala,id_butaca) values (9,4)
insert into salasXbutacas(id_sala,id_butaca) values (9,5)
insert into salasXbutacas(id_sala,id_butaca) values (9,6)
insert into salasXbutacas(id_sala,id_butaca) values (9,7)
insert into salasXbutacas(id_sala,id_butaca) values (9,8)
insert into salasXbutacas(id_sala,id_butaca) values (9,9)
insert into salasXbutacas(id_sala,id_butaca) values (9,10)
insert into salasXbutacas(id_sala,id_butaca) values (9,11)
insert into salasXbutacas(id_sala,id_butaca) values (9,12)
insert into salasXbutacas(id_sala,id_butaca) values (9,13)
insert into salasXbutacas(id_sala,id_butaca) values (9,14)
insert into salasXbutacas(id_sala,id_butaca) values (9,15)
insert into salasXbutacas(id_sala,id_butaca) values (9,16)
insert into salasXbutacas(id_sala,id_butaca) values (9,17)
insert into salasXbutacas(id_sala,id_butaca) values (9,18)
insert into salasXbutacas(id_sala,id_butaca) values (9,19)
insert into salasXbutacas(id_sala,id_butaca) values (9,20)
insert into salasXbutacas(id_sala,id_butaca) values (9,21)
insert into salasXbutacas(id_sala,id_butaca) values (9,22)
insert into salasXbutacas(id_sala,id_butaca) values (9,23)
insert into salasXbutacas(id_sala,id_butaca) values (9,24)
insert into salasXbutacas(id_sala,id_butaca) values (9,25)

--carga sala 10 3d conford  25 butacas--
insert into salasXbutacas(id_sala,id_butaca) values (10,1)
insert into salasXbutacas(id_sala,id_butaca) values (10,2)
insert into salasXbutacas(id_sala,id_butaca) values (10,3)
insert into salasXbutacas(id_sala,id_butaca) values (10,4)
insert into salasXbutacas(id_sala,id_butaca) values (10,5)
insert into salasXbutacas(id_sala,id_butaca) values (10,6)
insert into salasXbutacas(id_sala,id_butaca) values (10,7)
insert into salasXbutacas(id_sala,id_butaca) values (10,8)
insert into salasXbutacas(id_sala,id_butaca) values (10,9)
insert into salasXbutacas(id_sala,id_butaca) values (10,10)
insert into salasXbutacas(id_sala,id_butaca) values (10,11)
insert into salasXbutacas(id_sala,id_butaca) values (10,12)
insert into salasXbutacas(id_sala,id_butaca) values (10,13)
insert into salasXbutacas(id_sala,id_butaca) values (10,14)
insert into salasXbutacas(id_sala,id_butaca) values (10,15)
insert into salasXbutacas(id_sala,id_butaca) values (10,16)
insert into salasXbutacas(id_sala,id_butaca) values (10,17)
insert into salasXbutacas(id_sala,id_butaca) values (10,18)
insert into salasXbutacas(id_sala,id_butaca) values (10,19)
insert into salasXbutacas(id_sala,id_butaca) values (10,20)
insert into salasXbutacas(id_sala,id_butaca) values (10,21)
insert into salasXbutacas(id_sala,id_butaca) values (10,22)
insert into salasXbutacas(id_sala,id_butaca) values (10,23)
insert into salasXbutacas(id_sala,id_butaca) values (10,24)
insert into salasXbutacas(id_sala,id_butaca) values (10,25)



--
insert into sucursales(id_sucursal,nombre_sucursal,id_barrio,calle,altura) values (1,'Patio Olmos',1,'AV. Velez Sarsfiel',361)
insert into sucursales(id_sucursal,nombre_sucursal,id_barrio,calle,altura) values (2,'Rossas',21,'AV. Rafael Nulez',3850)
insert into sucursales(id_sucursal,nombre_sucursal,id_barrio,calle,altura) values (3,'Nuevocentro shopping',22,'AV. Duarte Quiros',1400)
insert into sucursales(id_sucursal,nombre_sucursal,id_barrio,calle,altura) values (4,'Nuevocentro San Luis',20,'San Martin',23)

--sucursal olmos
insert into salasXsucursales (id_sucursal,id_sala) values (1,1)--2d
insert into salasXsucursales (id_sucursal,id_sala) values (1,2)--2d
insert into salasXsucursales (id_sucursal,id_sala) values (1,6)--3d
insert into salasXsucursales (id_sucursal,id_sala) values (1,7)--3d
insert into salasXsucursales (id_sucursal,id_sala) values (1,4)--2dconfort


--sucursal Rossas
insert into salasXsucursales (id_sucursal,id_sala) values (2,1)--2d
insert into salasXsucursales (id_sucursal,id_sala) values (2,2)--2d
insert into salasXsucursales (id_sucursal,id_sala) values (2,6)--3d
insert into salasXsucursales (id_sucursal,id_sala) values (2,7)--3d
insert into salasXsucursales (id_sucursal,id_sala) values (2,4)--2dconfort
insert into salasXsucursales (id_sucursal,id_sala) values (2,9)--3dconfort


--sucursal Nuevo centro
insert into salasXsucursales (id_sucursal,id_sala) values (3,1)--2d
insert into salasXsucursales (id_sucursal,id_sala) values (3,2)--2d
insert into salasXsucursales (id_sucursal,id_sala) values (3,3)--2d
insert into salasXsucursales (id_sucursal,id_sala) values (3,4)--2dconfort
insert into salasXsucursales (id_sucursal,id_sala) values (3,5)--2dconfort
insert into salasXsucursales (id_sucursal,id_sala) values (3,6)--3d
insert into salasXsucursales (id_sucursal,id_sala) values (3,7)--3d
insert into salasXsucursales (id_sucursal,id_sala) values (3,9)--3dconfort
insert into salasXsucursales (id_sucursal,id_sala) values (3,10)--3dconfort

---------------------------------------------------------
-- ↓ LISANDRO ↓
---------------------------------------------------------
INSERT INTO clasificaciones(clasificacion) VALUES ('ATP')
INSERT INTO clasificaciones(clasificacion) VALUES ('+13')
INSERT INTO clasificaciones(clasificacion) VALUES ('+16')
INSERT INTO clasificaciones(clasificacion) VALUES ('+18')

--
INSERT INTO idiomas(idioma) VALUES ('Ingles')
INSERT INTO idiomas(idioma) VALUES ('Español')
Insert INTO idiomas(idioma) Values ('Aleman')
Insert INTO idiomas(idioma) Values ('Frances')
Insert INTO idiomas(idioma) Values ('Portugues')
Insert INTO idiomas(idioma) Values ('Italiano')
Insert INTO idiomas(idioma) Values ('Chino')

--
INSERT INTO generos(genero) VALUES ('Accion')
INSERT INTO generos(genero) VALUES ('Comedia')
INSERT INTO generos(genero) VALUES ('Terror')
INSERT INTO generos(genero) VALUES ('Drama')
INSERT INTO generos(genero) VALUES ('Documental')
INSERT INTO generos(genero) VALUES ('Ciencia ficcion')

--
INSERT INTO peliculas(id_pelicula,nombre_pelicula , id_genero, id_clasificacion, id_idioma, duracion ) VALUES (1, 'Oppenheimer', 4, 2, 1,'3hrs 0min' )
INSERT INTO peliculas(id_pelicula,nombre_pelicula , id_genero, id_clasificacion, id_idioma, duracion ) VALUES (2, 'Barbie', 2, 1, 2,'1hrs 0min' )
INSERT INTO peliculas(id_pelicula,nombre_pelicula , id_genero, id_clasificacion, id_idioma, duracion) VALUES (3, 'La monja 2', 3, 2, 1, '1hrs 50min')
INSERT INTO peliculas(id_pelicula,nombre_pelicula , id_genero, id_clasificacion, id_idioma, duracion ) VALUES (4, 'Avatar 2', 6, 2, 1, '2hrs 47min')
INSERT INTO peliculas(id_pelicula,nombre_pelicula , id_genero, id_clasificacion, id_idioma, duracion ) VALUES (5, 'Avengers Endgame', 1, 2, 5, '2hrs 55min')
INSERT INTO peliculas(id_pelicula,nombre_pelicula , id_genero, id_clasificacion, id_idioma, duracion ) VALUES (6, 'Top gun Maverick', 1, 2, 1, '2hrs 11min')
INSERT INTO peliculas(id_pelicula,nombre_pelicula , id_genero, id_clasificacion, id_idioma, duracion ) VALUES (7, 'Asteroid City', 2, 2, 4, '1hrs 45min')
---------------------------------------------------------
-- ↓ AGUSTIN ↓
---------------------------------------------------------


--
insert into promos (id_promo, nombre_promo, descuento)
			values (1, 'Mayores 50%', 0.5)
insert into promos (id_promo, nombre_promo, descuento)
			values (2, 'Menores 40%', 0.4)
insert into promos (id_promo, nombre_promo, descuento)
			values (3, 'Embarazada 45%', 0.45)
insert into promos (id_promo, nombre_promo, descuento)
			values (4, 'Discapacidad 60%', 0.6)
insert into promos (id_promo, nombre_promo, descuento)
			values (5, 'Jueves 30%', 0.3)


--
insert into horarios(inicio, final)
			values ('12:00:00','15:00:00')
insert into horarios(inicio, final)
			values ('15:00:00','18:00:00')
insert into horarios(inicio, final)
			values ('18:00:00','21:00:00')
insert into horarios(inicio, final)
			values ('21:00:00','00:00:00')
insert into horarios(inicio, final)
			values ('22:00:00','01:00:00') --Horario premium
insert into horarios(inicio, final)
			values ('23:00:00','02:00:00') -- Horario imax


--
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(1, '12/10/23', 0, 1, 1) --Oppenheimer 2d dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(2, '12/10/23', 1, 1, 2) --Oppenheimer 2d sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(3, '12/10/23', 0, 1, 3) --Oppenheimer 2d confort dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(4, '12/10/23', 1, 1, 4) --Oppenheimer 2d confort sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(1, '14/10/23', 0, 1, 5) --Oppenheimer 3d dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(2, '14/10/23', 1, 1, 6) --Oppenheimer 3d sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(3, '14/10/23', 0, 1, 7) --Oppenheimer 3d confort dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(4, '14/10/23', 1, 1, 8) --Oppenheimer 3d confort sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(5, '16/10/23', 1, 1, 9) --Oppenheimer premium sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(6, '16/10/23', 1, 1, 10) --Oppenheimer imax sub


insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(2, '12/10/23', 0, 2, 1) --Barbie 2d dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(1, '12/10/23', 1, 2, 2) --Barbie 2d sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(4, '12/10/23', 0, 2, 3) --Barbie 2d confort dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(3, '12/10/23', 1, 2, 4) --Barbie 2d confort sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(2, '14/10/23', 0, 2, 5) --Barbie 3d dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(1, '14/10/23', 1, 2, 6) --Barbie 3d sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(4, '14/10/23', 0, 2, 7) --Barbie 3d confort dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(3, '14/10/23', 1, 2, 8) --Barbie 3d confort sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(5, '18/10/23', 1, 2, 9) --Barbie premium sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(6, '18/10/23', 1, 2, 10) --Barbie imax sub

insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(3, '12/10/23', 0, 3, 1) --La monja 2 2d dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(4, '12/10/23', 1, 3, 2) --La monja 2 2d sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(1, '12/10/23', 0, 3, 3) --La monja 2 2d confort dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(2, '12/10/23', 1, 3, 4) --La monja 2 2d confort sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(3, '14/10/23', 0, 3, 5) --La monja 2 3d dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(4, '14/10/23', 1, 3, 6) --La monja 2 3d sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(1, '14/10/23', 0, 3, 7) --La monja 2 3d confort dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(2, '14/10/23', 1, 3, 8) --La monja 2 3d confort sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(6, '16/10/23', 1, 3, 9) --La monja 2 premium sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(5, '16/10/23', 1, 3, 10) --La monja 2 imax sub

insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(1, '13/10/23', 0, 4, 1) --Avatar 2 2d dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(2, '13/10/23', 1, 4, 2) --Avatar 2 2d sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(3, '13/10/23', 0, 4, 3) --Avatar 2 2d confort dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(4, '13/10/23', 1, 4, 4) --Avatar 2 2d confort sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(1, '15/10/23', 0, 4, 5) --Avatar 2 3d dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(2, '15/10/23', 1, 4, 6) --Avatar 2 3d sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(3, '15/10/23', 0, 4, 7) --Avatar 2 3d confort dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(4, '15/10/23', 1, 4, 8) --Avatar 2 3d confort sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(5, '17/10/23', 1, 4, 9) --Avatar 2 premium sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(6, '17/10/23', 1, 4, 10) --Avatar 2 imax sub

insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(2, '13/10/23', 0, 5, 1) --Avengers Endgame 2d dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(1, '13/10/23', 1, 5, 2) --Avengers Endgame 2d sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(4, '13/10/23', 0, 5, 3) --Avengers Endgame 2d confort dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(3, '13/10/23', 1, 5, 4) --Avengers Endgame 2d confort sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(2, '15/10/23', 0, 5, 5) --Avengers Endgame 3d dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(1, '15/10/23', 1, 5, 6) --Avengers Endgame 3d sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(4, '15/10/23', 0, 5, 7) --Avengers Endgame 3d confort dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(3, '15/10/23', 1, 5, 8) --Avengers Endgame 3d confort sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(5, '17/10/23', 1, 5, 9) --Avengers Endgame premium sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(6, '17/10/23', 1, 5, 10) --Avengers Endgame imax sub

insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(3, '13/10/23', 0, 6, 1) --Top gun Maverick 2d dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(4, '13/10/23', 1, 6, 2) --Top gun Maverick 2d sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(1, '13/10/23', 0, 6, 3) --Top gun Maverick 2d confort dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(2, '13/10/23', 1, 6, 4) --Top gun Maverick 2d confort sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(3, '15/10/23', 0, 6, 5) --Top gun Maverick 3d dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(4, '15/10/23', 1, 6, 6) --Top gun Maverick 3d sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(1, '15/10/23', 0, 6, 7) --Top gun Maverick 3d confort dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(2, '15/10/23', 1, 6, 8) --Top gun Maverick 3d confort sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(6, '17/10/23', 1, 6, 9) --Top gun Maverick premium sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(5, '17/10/23', 1, 6, 10) --Top gun Maverick imax sub

insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(4, '13/10/23', 0, 7, 1) --Asteroid City 2d dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(3, '13/10/23', 1, 7, 2) --Asteroid City 2d sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(2, '13/10/23', 0, 7, 3) --Asteroid City 2d confort dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(1, '13/10/23', 1, 7, 4) --Asteroid City 2d confort sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(4, '15/10/23', 0, 7, 5) --Asteroid City 3d dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(3, '15/10/23', 1, 7, 6) --Asteroid City 3d sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(2, '15/10/23', 0, 7, 7) --Asteroid City 3d confort dob
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(1, '15/10/23', 1, 7, 8) --Asteroid City 3d confort sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(5, '18/10/23', 1, 7, 9) --Asteroid City premium sub
insert into funciones (id_horario, fecha, subtitulo, id_pelicula, id_sala) values(6, '18/10/23', 1, 7, 10) --Asteroid City imax sub


insert into reservas(id_cliente, id_funcion)
			values (1, 3)
insert into reservas(id_cliente, id_funcion)
			values (2, 4)
insert into reservas(id_cliente, id_funcion)
			values (3, 7)
insert into reservas(id_cliente, id_funcion)
			values (4, 9)
insert into reservas(id_cliente, id_funcion)
			values (6, 11)
insert into reservas(id_cliente, id_funcion)
			values (10, 17)
---------------------------------------------------------
-- ↓ MARIANO ↓
---------------------------------------------------------
--VENDEDORES (30)
--
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Bruno', 'Delfino', 1, '40345123', 'bruno_delfino@gmail.com', '+5492664657495', 2, 'Peru', 135)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Tomas', 'Lamas', 2, 'ZAG657453', 'Tomas_ll07@outlook.com', '+549351745693', 20, 'Maipu', 815)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Julia', 'Correa', 1, '38776453', 'Julii2000@hotmail.com.ar', '+5492664356453', 21, 'San Martin', 95)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Manuel', 'Delfino', 4, '546354856', 'maudelf.87@yahoo.com.ar', '+5492665746307', 22, 'Patricio', 2000)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Alan', 'Gonzales', 1, '41645375', 'alan_gonzales@gmail.com', '+5492664376485', 19, 'Maipu', 10)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Maira', 'Bianchi', 2, 'ZAG475864', 'B.maira@outlook.com', '+5492664375639', 19, 'Heroes de malvinas', '')
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Tomas Eduardo', 'Kohler', 3, 'Y7010V12', 'KHOLER.tom@yahoo.com', '+5492657456586', 2, '', '')
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Claribel', 'Medina', 1, '4657354657', 'Clara._med07@hotmail.es', '+549351645374', 1, 'Av. Velez Sarfield', 485)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Mariano Jesus', 'Benitez Correa', 1, '39992156', 'mariano_b7@outlook.com', '+5492657634207', 2, 'Crisol', 222)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Agustin', 'Agrelo', 2, 'ZAG4758645', 'Agus-lo@gmail.com.ar', '+54911746584', 3, 'Mitre', 321)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Lisandro', 'Rodriguez', 4, 'W87364B32', 'Rodri.li@hotmail.com', '+549351', 4, 'Peña', 5463)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Chiara', 'Benitez', 1, '64537835', 'chara.beni@gmail.com', '+54926647564563', 5, 'Belgrano', 0)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Candela', 'Mora', 2, 'ZGA546768', '', '+54926657654857', 6, 'Iñaqui', 23)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Pricila', 'Correa', 1, '645375978', 'picha@yahoo.es', '+54926657465746', 8, 'Lauren', 3)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Jeremias', 'Isabel', 3, '6546476', '', '+549351456609', 9, 'Ciclon', 1807)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Juan Carlos', 'Tutti', 2, 'ZGA546732', 'tutti@hotmail.tv', '+549116475867', 10, 'Pelegrini', 27)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Majo', 'Sanchez', 1, '645375978', 'majo@yahoo.com.ar', '+549351645396', 11, 'San Martin', '')
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Camila', 'Platner', 1, '645389675', 'camilin.07@outlook.com', '+54911645374960', 13, 'Ayacucho', 64)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Maira', 'Rodriguez', 4, 'Y7364Z64', 'RODRI.MAIRA@gmail.com.ar', '+5492664465860', 14, 'Gutierrez', 2195)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Santiago', 'Denis', 1, '45837596', '', '+549351759476', 15, 'Obispo Trejo', 887)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Franco lula', 'Sosa', 1, '6475845', 'franquito@utn.com.ar', '', 16, 'Bocura', 23)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Saul', 'Dominguez', 2, 'ZGA5769784', '', '+549351759786', 17, 'Ituzaingp', 992)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Valetin', 'Falco', 1, '41658675', 'calentin@yahoo.com.es', '+54926643737305', 18, '', 21)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Mabel Irene', 'Correa', 4, '674658', 'mabicorrea@merlo-sl.com.ar', '+5492664375648', 15, 'Pery', 148)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Ana Laura', 'Benitez', 1, '6574895906', 'ana.ll@gamil.com', '+5492664768596', 10, 'Los Sonajos', 74)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Julian', 'Gonzalez', 1, '6574856', 'jujuli@gmail.com', '+5492664377305', 11, 'Milei', 1990)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Enzo', 'Fernandez', 1, '4365768', '', '+549351867597', 3, 'Latorre', 1)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Leonel', 'Martinez', 2, 'Y7453645', 'elmasgrande.10@gmailc.com.ar', '+549116574869', 6, 'San Cristobal', 28)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Juan Alberto', 'Spinetta', 4, '5756356', '', '+54911758965', 15, 'Rock', 1997)
INSERT INTO VENDEDORES (nombre, apellido, id_tipo_documento, nro_documento, email, telefono, id_barrio, calle, altura)
			VALUES ('Facundo', 'Faraena', 1, '65746597', 'facfacu@yahoo.com', '+549351756453', 3, 'Paz', 007)
--FORMAS_PAGO (7)
--
INSERT INTO FORMAS_PAGO (formas_pago)
			VALUES ('Efectivo')
INSERT INTO FORMAS_PAGO (formas_pago)
			VALUES ('Debito')
INSERT INTO FORMAS_PAGO (formas_pago)
			VALUES ('Credito')
INSERT INTO FORMAS_PAGO (formas_pago)
			VALUES ('(QR)-Billetera_Electronica')
INSERT INTO FORMAS_PAGO (formas_pago)
			VALUES ('Transferencia')
INSERT INTO FORMAS_PAGO (formas_pago)
			VALUES ('Cheque')
INSERT INTO FORMAS_PAGO (formas_pago)
			VALUES ('Voucher')

--COMPROBANTES (50)
--
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('05/01/2023', 1, 2, 1, 30)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('17/07/2023', 2, 1, 4, 30)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('04/05/2023', 23, 2, 2, 22)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('04/06/2023', 3, 3, 2, 20)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('02/04/2023', 4, 1, 3, 2)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('24/07/2023', 5, 2, 7, 5)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('29/03/2023', 5, 3, 6, 14)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('02/11/2023', 6, 3, 2, 16)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('07/02/2023', 7, 2, 4, 10)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('18/10/2023', 8, 3, 3, 4)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('9/8/2023', 9, 1, 5, 1)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('18/3/2023', 10, 1, 6, 7)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('17/3/2023', 10, 1, 4, 15)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('26/10/2023', 10, 1, 1, 5)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('1/5/2023', 2, 3, 1, 3)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('4/9/2023', 11, 2, 2, 13)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('28/5/2023', 12, 3, 3, 21)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('20/8/2023', 13, 1, 6, 10)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('8/1/2023', 14, 2, 7, 22)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('22/8/2023', 15, 3, 7, 9)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('19/1/2023', 16, 3, 4, 4)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('19/6/2023', 18, 2, 1, 3)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('31/1/2023', 19, 1, 2, 2)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('18/5/2023', 20, 2, 3, 14)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('3/6/2023', 21, 3, 1, 29)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('25/2/2023', 22, 2, 3, 1)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('23/9/2023', 22, 2, 3, 30)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('20/10/2023', 22, 2, 1, 20)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('21/6/2023', 22, 2, 2, 11)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('7/7/2023', 22, 2, 2, 20)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('24/12/2023', 22, 2, 2, 8)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('24/12/2023', 22, 2, 6, 14)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('3/11/2023', 23, 1, 7, 9)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('3/11/2023', 24, 3, 5, 6)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('3/5/2023', 25, 3, 5, 14)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('23/11/2023', 2, 3, 3, 4)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('12/5/2023', 3, 3, 2, 22)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('19/5/2023', 1, 2, 1, 17)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('11/3/2023', 26, 1, 1, 24)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('20/11/2023', 2, 3, 1, 30)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('21/5/2023', 27, 1, 1, 28)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('8/2/2023', 28, 2, 6, 13)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('16/9/2023', 29, 3, 6, 4)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('13/2/2023', 30, 3, 3, 26)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('23/12/2023', 4, 1, 3, 3)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('30/7/2023', 3, 1, 2, 26)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('4/5/2023', 22, 2, 7, 30)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('20/5/2023', 20, 1, 3, 24)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('8/3/2023', 26, 1, 2, 26)
INSERT INTO COMPROBANTES (fecha_compra, id_cliente, id_sucursal, id_forma_pago, id_vendedor)
			VALUES ('19/6/2023', 27, 2, 7, 17)

--DETALLES_COMPROBANTES (50)
--
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (7, 1, 4000, 1)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (22, 2, 2380, 4)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (29, 3, 5100, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (60, 4, 6080, 5)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (34, 5, 2880, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (2, 6, 5100, 3)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (33, 7, 2880, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (41, 8, 2380, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (42, 9, 2380, 3)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (61, 10, 2380, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (67, 11, 4000, 5)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (1, 12, 2380, 1)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (42, 13, 2380, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (37, 14, 4000, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (10, 15, 6080, 3)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (29, 16, 5100, 3)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (44, 17, 2880, 3)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (22, 18, 2380, 4)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (22, 19, 2380, 2)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (29, 20, 5100, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (11, 21, 2380, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (51, 22, 2380, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (1, 23, 2380, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (2, 24, 2380, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (1, 25, 2380, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (1, 26, 2380, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (2, 27, 2380, 3)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (11, 28, 2380, 5)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (41, 29, 2380, 4)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (21, 30, 2380, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (51, 31, 2380, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (61, 32, 2380, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (1, 33, 2380, 2)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (22, 34, 2380, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (32, 35, 2380, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (69, 36, 5100, 1)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (29, 37, 5100, 3)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (22, 38, 2380, 4)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (1, 39, 2380, 2)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (20, 40, 6080, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (66, 41, 3860, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (1, 42, 3860, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (49, 43, 5100, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (67, 44, 4000, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (36, 45, 3860, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (24, 46, 2880, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (26, 47, 3860, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (56, 48, 3860, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (22, 49, 2380, NULL)
INSERT INTO DETALLES_COMPROBANTES (id_funcion, id_comprobante, precio, id_promo)
			VALUES (2, 50, 2380, NULL)

update clientes 
set fecha_nac = '12/01/1947 '
where id_cliente= 21


ALTER TABLE clientes
ALTER COLUMN  teléfono  int

select * from clientes