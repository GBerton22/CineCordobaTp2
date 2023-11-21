

Create PROCEDURE [dbo].[SP_CONSULTA_CLARI]
 --	parametro para filtrar por meses--
 @fechaDesde datetime =null,
 --parametros para filtrar por tipo de sala--
 @2d varchar(15)= null,
 @2dComfort varchar(15) = null,
 @3d varchar(15) =null,
 @3dComfort varchar(15)= null,
 @premium varchar(15) =null,
 @imax varchar(15) =null,
 --parametros para discriminar genero--
 @accion varchar(20) =null ,
 @comedia varchar(20) =null ,
 @terror varchar(20) =null ,
 @drama varchar(20) =null ,
 @documental varchar(20) =null ,
 @cienciaFiccion varchar(20) =null 

 AS
 begin
set dateformat ymd
select v.nombre 'Vendedor',cl.nombre 'Cliente', tp.tipo 'Sala',p.nombre_pelicula 'Pelicula',F.fecha 'Funcion', genero 'Genero'
from vendedores v join COMPROBANTES c on v.id_vendedor=c.id_vendedor
join clientes cl on cl.id_cliente=c.id_cliente
join DETALLES_COMPROBANTES dc on dc.id_comprobante=c.id_comprobante
join funciones f on f.id_funcion=dc.id_funcion
join salas s on s.id_sala=f.id_sala
join tipos_salas tp on tp.id_tipo_sala=s.id_tipo_sala
join peliculas p on p.id_pelicula=f.id_pelicula
join generos g on g.id_genero=p.id_genero

where  p.id_genero not in (select p.id_genero
						from generos g join peliculas p1 on g.id_genero=p1.id_genero
						where p1.id_pelicula=p.id_pelicula
						and g.genero in (@accion , @comedia, @terror, @drama, @documental, @cienciaFiccion))

 and tp.tipo in (@2d, @2dComfort, @3d, @3dComfort, @premium, @imax)
and c.fecha_compra between @fechaDesde and getdate()

group by dc.id_comprobante,v.nombre,cl.nombre,tp.tipo, p.nombre_pelicula,F.fecha, genero
order by 'Sala'
end ;





Create PROCEDURE [dbo].[SP_PROXIMO_CLIENTES]
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT MAX(id_cliente)+1  FROM clientes);
END




Create procedure [dbo].[sp_insertarCliente]
  @id_cliente int output,
  @nombre varchar(40),
  @apellido varchar(40),
  @fecha_nac smalldatetime,
  @telefono int,
  @email varchar(30),
  @id_barrio int,
  @calle varchar(20),
  @altura int,
  @id_tipo_doc int,
  @nro_doc int

  as
  begin
  insert into clientes(nombre,apellido,fecha_nac,teléfono,email,id_barrio,calle,altura,id_tipo_doc,nro_doc)
  values(@nombre,@apellido,@fecha_nac,@telefono,@email,@id_barrio,@calle,@altura,@id_tipo_doc,@nro_doc)
  set @id_cliente = SCOPE_IDENTITY();
  end



Create procedure [dbo].[sp_barrios]
  @id_ciudad int
  as
  begin
  select b.id_barrio,barrio 
  from ciudades c join barrios b on c.id_ciudad=b.id_ciudad
  
  where c.id_ciudad= @id_ciudad

  end




  Create procedure [dbo].[sp_Ciudad]
  as
  begin
  select id_ciudad,ciudad
  from ciudades
  end



 Create procedure [dbo].[Sp_tipo_Doc]
  as
  begin
  select*
  from tipos_documentos
  end


  Create procedure [dbo].[sp_salas]
	@id_sucursal int
	as
  select  s.id_sala,ts.tipo

  from salas s 
    join salasXsucursales sxs on sxs.id_sala=s.id_sala
  join sucursales su on su.id_sucursal=sxs.id_sucursal
  join tipos_salas ts on ts.id_tipo_sala= s.id_tipo_sala

  where su.id_sucursal = @id_sucursal


   Create procedure [dbo].[sp_sucursales]
  as
  begin
  select id_sucursal,nombre_sucursal
  from sucursales
  end



    Create PROCEDURE [dbo].[sp_consultar_horarios]
AS
BEGIN
     SELECT [id_horario],
           [inicio],
           [final]
    FROM [Cordoba_Cine_GRUPO_N9].[dbo].[horarios]
    ORDER BY [inicio] ASC;
END;



Create procedure [dbo].[sp_consultar_peliculas]
as
begin
select id_pelicula,nombre_pelicula,id_genero
from peliculas
end



Create PROCEDURE [dbo].[SP_PROXIMO_ID]
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT MAX(id_funcion)+1  FROM funciones);
END



Create procedure [dbo].[CrearFuncion]
  @id_Funcion int output,
  @id_horario int,
  @fecha datetime,
  @subtitulo bit,
  @id_pelicula int,
  @id_sala int
  as
  begin

  insert into funciones(id_horario,fecha,subtitulo,id_pelicula,id_sala)
  values(@id_horario,@fecha,@subtitulo,@id_pelicula,@id_sala)
   set @id_Funcion = SCOPE_IDENTITY();

  end




 Create procedure [dbo].[sp_inicio_sesion]

@Usuario varchar(50),
@Contraseña varchar(50),
@Resultado int output
as
begin
declare @Cantidad int
select @Cantidad = count(id_Usuario) from usuarios 
where Usuario = @Usuario and
      Contraseña = @Contraseña
if(@Cantidad  = 1)
set @Resultado = 1
else
set @Resultado = 0
end



--STORE PROCEDURE LISAN--

Create proc [dbo].[cargarBarrios]
as
select id_barrio, barrio, id_ciudad
from barrios


Create procedure [dbo].[ModificarCliente]
@id_cliente int,
@nombre varchar(40),
@apellido varchar(40),
@fecha_nac smalldatetime,
@telefono int,
@email varchar(30),
@id_barrio int,
@calle varchar(20),
@altura int,
@id_tipo_doc int,
@nro_doc int 
as
update clientes
set nombre = @nombre,
apellido = @apellido,
fecha_nac = @fecha_nac,
teléfono = @telefono,
email = @email,
id_barrio = @id_barrio,
calle = @calle,
altura = @altura,
id_tipo_doc = @id_tipo_doc,
nro_doc = @nro_doc
where id_cliente = @id_cliente


Create procedure [dbo].[sp_consultar_cliente_id]
@id_cliente int
as
select  id_cliente, nombre, apellido, fecha_nac, teléfono, email, id_barrio, calle, altura, id_tipo_doc, nro_doc
from clientes
where id_cliente = @id_cliente



CREATE procedure [dbo].[SP_ELIMINAR_CLIENTE]
@id_cliente int
as
ALTER TABLE dbo.COMPROBANTES ALTER COLUMN id_cliente INT NULL;
ALTER TABLE dbo.reservas ALTER COLUMN id_cliente INT NULL;
UPDATE dbo.COMPROBANTES SET id_cliente = NULL WHERE id_cliente = @id_cliente;
UPDATE dbo.reservas SET id_cliente = NULL WHERE id_cliente = @id_cliente;
DELETE FROM dbo.clientes WHERE id_cliente = @id_cliente;


CREATE procedure [dbo].[spActualizarCliente]
@id_cliente int,
@nombre varchar(40),
@apellido varchar(40),
@fecha_Nac smalldatetime,
@telefono int,
@email varchar(30),
@id_Barrio int,
@calle varchar(20),
@altura int, 
@id_Tipo_Doc int,
@nro_Doc int
as
update clientes
set nombre= @nombre,
apellido  =@apellido,
fecha_nac = @fecha_nac,
teléfono = @telefono,
email = @email,
id_barrio = @id_Barrio,
calle = @calle,
altura= @altura,
id_tipo_doc= @id_Tipo_Doc,
nro_doc = @nro_Doc



Create proc [dbo].[spCargarTipoDocumento]
as
select id_tipo_doc, tipo_doc
from tipos_documentos


CREATE procedure [dbo].[spConsultarClientes]
as
select * from clientes



