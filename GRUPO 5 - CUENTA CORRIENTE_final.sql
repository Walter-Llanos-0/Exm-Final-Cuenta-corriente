create database Grupo_5
use Grupo_5;

CREATE TABLE Cliente (
    
    IdCliente             INT IDENTITY PRIMARY KEY,
    Tipocliente           VARCHAR(20),
    Tipodocumento         VARCHAR(10),
    Numerodocumento       VARCHAR(12),
    ApellidoPaterno       VARCHAR(30) NOT NULL,
    ApellidoMaterno       VARCHAR(30),
    Nombre                VARCHAR(50) NOT NULL,
    Ruc                   CHAR(11),
    RazonSocial           VARCHAR(100),
    Domicilio             VARCHAR(50),
    Departamento          VARCHAR(50),
    Provincia             VARCHAR(50),
    Distrito              VARCHAR(50),
    Telefono1             VARCHAR(20),
    Celular               VARCHAR(20),
    Correo                VARCHAR(40),
    Moroso                VARCHAR (50),
    Estado                VARCHAR (50),

   
);



CREATE TABLE Proveedor (

    IdProveedor                     INT IDENTITY PRIMARY KEY ,
    TipoProveedor                   VARCHAR(20),
    Tipodocumento                   VARCHAR(10),
    Numerodocumento                 VARCHAR(12),
    ApellidoPaterno                 VARCHAR(50) NOT NULL,
    ApellidoMaterno                 VARCHAR(50),
    Nombre                          VARCHAR(50) NOT NULL,
    Ruc                             CHAR(11),
    RazonSocial                     VARCHAR(100),
    Domicilio                       VARCHAR(100),
    Departamento                    VARCHAR(50),
    Provincia                       VARCHAR(50),
    Distrito                        VARCHAR(50),
    Telefono1                       VARCHAR(20),
    Contacto                        VARCHAR(20),
    Correo		                    VARCHAR(40),
    BancoFinanciera                 VARCHAR(50),
    Nrocuenta                       INT,
    NroInterbancaria                INT,
    Estado                          VARCHAR (50),

);

 CREATE TABLE MoviCliente (
 
  IdMoviCliente                       INT IDENTITY PRIMARY KEY ,
  Fecha                               VARCHAR(15),
  Concepto                         VARCHAR(100), 
  nota                             VARCHAR(100),
  TipoMovimiento                    VARCHAR(20),
  TipoMoneda                       VARCHAR(10), 
  Importe                          int,
  IdCliente                          INT

);

 

CREATE TABLE MoviProveedor (
  
  IdMProveedor                     INT IDENTITY PRIMARY KEY, 
  Fecha                            VARCHAR(15),
  Concepto                         VARCHAR (100),
   Nota                             VARCHAR (50),
  TipoMovimiento                   VARCHAR (20),
  TipoMoneda                       VARCHAR (10), 
  Importe                          int, 
 
  IdProveedor                     INT

);

CREATE TABLE Registro_Usuario (

  IdUsuario                                INT IDENTITY PRIMARY KEY,
  Usuario                                  VARCHAR(20), 
  Contrasenia                              VARCHAR (20), 
  ApellidoPaterno                          VARCHAR(20),
  ApellidoMaterno                          VARCHAR(20), 
  Nombres                                  VARCHAR(30),
  Perfil                                   VARCHAR(30),
  Estado                                   VARCHAR(20),
  Fotos                                    IMAGE not null
);

CREATE TABLE Consulta(

     IdConsulta            INT IDENTITY PRIMARY KEY,
    IdCliente                          INT,
    C_Tipocliente           VARCHAR(20),
    C_Tipodocumento         VARCHAR(10),
    C_Numerodocumento       VARCHAR(12),
    C_ApellidoPaterno       VARCHAR(30) NOT NULL,
    C_ApellidoMaterno       VARCHAR(30),
    C_Nombre                VARCHAR(50) NOT NULL,
    C_Ruc                   CHAR(11),
    C_RazonSocial           VARCHAR(100),
    C_Domicilio             VARCHAR(50),
    C_Departamento          VARCHAR(50),
    C_Provincia             VARCHAR(50),
    C_Distrito              VARCHAR(50),
IdProveedor                     INT  ,
    P_TipoProveedor                   VARCHAR(20),
    P_Tipodocumento                   VARCHAR(10),
    P_Numerodocumento                 VARCHAR(12),
    P_ApellidoPaterno                 VARCHAR(50) NOT NULL,
    P_ApellidoMaterno                 VARCHAR(50),
    P_Nombre                          VARCHAR(50) NOT NULL,
    P_Ruc                             CHAR(11),
    P_RazonSocial                     VARCHAR(100),
    P_Domicilio                       VARCHAR(100),
    P_Departamento                    VARCHAR(50),
    P_Provincia                       VARCHAR(50),
    P_Distrito                        VARCHAR(50),

);


alter table MoviCliente 
add constraint fk_1
foreign key (IdCliente)
references Cliente(IdCliente)


alter table MoviProveedor
add constraint fk_2
foreign key (IdProveedor)
references Proveedor(IdProveedor)

alter table Consulta
add constraint fk_3
foreign key (IdCliente)
references Cliente(IdCliente)

alter table Consulta
add constraint fk_4
foreign key (IdProveedor)
references Proveedor(IdProveedor)


-- SP DE REGISTRO USUARIO -- 
-- listar

go
create procedure sp_ListarRegistro_Usuario
as
  select * from Registro_Usuario
  order by IdUsuario 
go
--Probar 
execute sp_ListarRegistro_Usuario

-- SP - INSERTAR USUARIO 
go
create procedure sp_InsertarRegistro_Usuario
@p_usuario     varchar(20),
@p_contrasenia varchar(20),
@p_apepaterno  varchar(20),
@p_apematerno  varchar(20),
@p_nombre      varchar(30),
@p_perfil      varchar(30),
@p_estado      varchar(20),
@p_FotoUsuario image 

as
  insert into Registro_Usuario(Usuario,Contrasenia,ApellidoPaterno,ApellidoMaterno,Nombres,Perfil,Estado,Fotos)
  values (@p_usuario,@p_contrasenia,@p_apepaterno,@p_apematerno,@p_nombre,@p_perfil,@p_estado,@p_FotoUsuario)
go

-- Probar 
execute sp_InsertarRegistro_Usuario

--SP -  ACTUALIZAR USUARIO 
go
create procedure sp_ActualizarResgistro_Usuario
@p_idusuario int,
@p_usuario varchar(20),
@p_contrasenia varchar(20),
@p_apepaterno varchar(20),
@p_apematerno varchar(20),
@p_nombre varchar(30),
@p_perfil varchar(30),
@p_estado varchar(120),
@p_FotoUsuario image

as
 update Registro_Usuario set Usuario=@p_usuario,Contrasenia=@p_contrasenia,ApellidoPaterno=@p_apepaterno,
 ApellidoMaterno=@p_apematerno,Nombres=@p_nombre,Perfil=@p_perfil,Estado=@p_estado,Fotos=@p_FotoUsuario
 where IdUsuario = @p_idusuario
go

-- Probar 
execute sp_ActualizarResgistro_Usuario

-- SP - BUSCAR USUARIO 
go
create procedure sp_BuscarRegistro_Usuario
@p_idusuario int
as
    select * from Registro_Usuario
    where  IdUsuario=@p_idusuario
go
--Probar 
execute sp_BuscarRegistro_Usuario 

-- SP - ELIMINAR USUARIO 
go
create procedure sp_EliminarRegistro_Usuario 
@p_idusuario int 
as
  delete from Registro_Usuario
  where IdUsuario = @p_idusuario
go
--Probar
execute sp_EliminarRegistro_Usuario

----------------------------------------------------------------------------------------

-- SP DE PROVEEDORES -- 

-- Listar

go 
create proc sp_listaProveedor
as
select * from Proveedor
order by  IdProveedor
go
--------
exec sp_listaProveedor 

--SP INSERTAR PROVEEDOR

go 
create proc sp_insertarProveedor
@p_tipoPro varchar(20),
@p_tipoDoc varchar(20),
@p_numeroDoc varchar(20),
@p_apePat varchar(20),
@p_apeMat varchar (20),
@p_nombre varchar(20),
@p_ruc varchar(20),
@p_razon varchar(20),
@p_domi varchar(20),
@p_depar varchar(20),
@p_provi varchar(20),
@p_dist varchar(20),
@p_tele varchar(20),
@p_contacto varchar(20),
@p_correo varchar(20),
@p_bancofina varchar(20),
@p_nroCuenta int ,
@p_nroInter int,
@p_estado varchar(20)
as
insert  Proveedor (TipoProveedor,Tipodocumento,Numerodocumento,ApellidoPaterno,ApellidoMaterno,Nombre,Ruc,RazonSocial,
Domicilio,Departamento,Provincia,Distrito,Telefono1,Contacto,Correo,BancoFinanciera,Nrocuenta,NroInterbancaria,Estado)
values (@p_tipoPro,@p_tipoDoc,@p_numeroDoc,@p_apePat,@p_apeMat,@p_nombre,@p_ruc,@p_razon,@p_domi,@p_depar,@p_provi,
@p_dist,@p_tele,@p_contacto,@p_correo,@p_bancofina,@p_nroCuenta,@p_nroInter,@p_estado)
go

-- SP ACTUALIZAR PROVEEDOR

go 
create proc sp_actualizarProveedor
@p_idProveedor int,
@p_tipoPro varchar(20),
@p_tipoDoc varchar(20),
@p_numeroDoc varchar(20),
@p_apePat varchar(20),
@p_apeMat varchar (20),
@p_nombre varchar(20),
@p_ruc varchar(20),
@p_razon varchar(20),
@p_domi varchar(20),
@p_depar varchar(20),
@p_provi varchar(20),
@p_dist varchar(20),
@p_tele varchar(20),
@p_contacto varchar(20),
@p_correo varchar(20),
@p_banco varchar(20),
@p_nroCuenta int ,
@p_nroInter int,
@p_estado varchar(20)
as
update Proveedor set TipoProveedor=@p_tipoPro,Tipodocumento=@p_tipoDoc,Numerodocumento=@p_numeroDoc,ApellidoPaterno=@p_apePat,
ApellidoMaterno=@p_apeMat,Nombre=@p_nombre,Ruc=@p_ruc,RazonSocial=@p_razon,Domicilio=@p_domi,Departamento=@p_depar,Provincia=@p_provi,
Distrito=@p_dist,Telefono1=@p_tele,Contacto=@p_contacto,Correo=@p_correo,BancoFinanciera=@p_banco,Nrocuenta=@p_nroCuenta,
NroInterbancaria=@p_nroInter,Estado=@p_estado
where IdProveedor=@p_idProveedor
go

--SP BUSCAR PROVEEDOR

go
create proc sp_buscarProovedor
@p_idProveedor int
as
select * from Proveedor
where IdProveedor=@p_idProveedor
go

-- SP ELIMINAR PROVEEDOR

go
create proc sp_eliminarProovedor
@p_idProovedor int
as
delete from Proveedor
where IdProveedor=@p_idProovedor
go


---------------------------------------------------------------------
-------------------------------------------------------------
--MOVIMIENTO PROOVEDOR--
--SP LISTAR

go
create proc sp_listamoviPro
as
select * from MoviProveedor
order by IdMProveedor
go

--SP INSERTAR MOVI-MOVIPROVEEDOR
go
create proc sp_insertarmovi
@p_fecha varchar(15),
@p_concepto varchar(100),
@p_nota varchar(50),
@p_tipomov varchar(20),
@p_tipomon varchar (50),
@p_importe int,

@p_idProovedor int
as
insert MoviProveedor (Fecha,Concepto,Nota,TipoMovimiento,TipoMoneda,Importe, IdProveedor) values (@p_fecha,@p_concepto,@p_nota,@p_tipomov,
@p_tipomon,@p_importe,@p_idProovedor)
go

--SP ACTUALIZAR  MOVI-PROVEEDOR
go
create proc sp_actualizarmovi

@p_idmProovedor int,
@p_fecha varchar(15),
@p_concepto varchar(100),
@p_nota varchar(50),

@p_tipomov varchar(20),
@p_tipomon varchar (50),
@p_importe int,
@p_idProovedor int

as
update MoviProveedor set  Fecha=@p_fecha, Concepto=@p_concepto,Nota=@p_nota,TipoMovimiento=@p_tipomov,TipoMoneda=@p_tipomon,
Importe=@p_importe, IdProveedor= @p_idProovedor
where IdMProveedor=@p_idmProovedor
go

--SP BUSCAR MOVI-PROVEEDOR
go
create proc sp_buscarmovi
@p_idmProovedor int
as
select * from MoviProveedor
where IdMProveedor=@p_idmProovedor
go

-- SP  ELIMINAR MOVI-PROVEEDOR

go
create proc sp_eliminarmovi
@p_idmProovedor int
as
delete from MoviProveedor
where IdMProveedor=@p_idmProovedor
go

-- SP CLIENTES
-- Listar

go
create procedure sp_ListarRegistro_Cliente
as
  select * from Cliente
  order by IdCliente
go
--Probar 
execute sp_ListarRegistro_Cliente

-- SP - INSERTAR CLIENTES 
go
create procedure sp_InsertarRegistro_Cliente
    @p_Tipocliente           VARCHAR(20),    @p_Tipodocumento         VARCHAR(10),    @p_Numerodocumento       VARCHAR(12),    @p_ApellidoPaterno       VARCHAR(30) ,
    @p_ApellidoMaterno       VARCHAR(30),    @p_Nombre                VARCHAR(50) ,    @p_Ruc                   VARCHAR(11),    @p_RazonSocial           VARCHAR(100),
    @p_Domicilio             VARCHAR(50),    @p_Departamento          VARCHAR(50),    @p_Provincia             VARCHAR(50),    @p_Distrito              VARCHAR(50),
    @p_Telefono1             VARCHAR(20),    @p_Celular               VARCHAR(20),    @p_Correo                VARCHAR(40),    @p_Moroso                VARCHAR (50),
    @p_Estado                VARCHAR (50)
as
  insert Cliente(Tipocliente,  Tipodocumento,    Numerodocumento, ApellidoPaterno ,    ApellidoMaterno,    Nombre,    Ruc,    RazonSocial ,    Domicilio , 
  Departamento ,    Provincia ,    Distrito ,    Telefono1 ,    Celular ,    Correo ,    Moroso ,    Estado )

  values(@p_Tipocliente ,    @p_Tipodocumento,    @p_Numerodocumento,    @p_ApellidoPaterno ,    @p_ApellidoMaterno,    @p_Nombre,    @p_Ruc,    @p_RazonSocial ,
    @p_Domicilio ,    @p_Departamento ,    @p_Provincia ,    @p_Distrito ,    @p_Telefono1 ,    @p_Celular ,    @p_Correo ,    @p_Moroso ,    @p_Estado ) 
go
-- Probar 
execute sp_InsertarRegistro_Cliente a,a,a,a,a,a,aaaaaaaaaaa,a,a,a,a,a,a,a,a,a,a
--SP -  ACTUALIZAR CLIENTES 
go
create procedure sp_ActualizarResgistro_Cliente
    @p_IdCliente                     int,    @p_Tipocliente           VARCHAR(20),    @p_Tipodocumento         VARCHAR(10),    @p_Numerodocumento       VARCHAR(12),
    @p_ApellidoPaterno       VARCHAR(30),    @p_ApellidoMaterno       VARCHAR(30),    @p_Nombre                VARCHAR(50),    @p_Ruc                   VARCHAR(11),
    @p_RazonSocial           VARCHAR(100),   @p_Domicilio             VARCHAR(50),    @p_Departamento          VARCHAR(50),    @p_Provincia             VARCHAR(50),
    @p_Distrito              VARCHAR(50),    @p_Telefono1             VARCHAR(20),    @p_Celular               VARCHAR(20),    @p_Correo                VARCHAR(40),
    @p_Moroso                VARCHAR (50),   @p_Estado                VARCHAR (50)
as
 update Cliente 
 set Tipocliente=@p_Tipocliente ,    Tipodocumento=@p_Tipodocumento,   Numerodocumento= @p_Numerodocumento,  ApellidoPaterno=  @p_ApellidoPaterno ,  ApellidoMaterno=  @p_ApellidoMaterno,   Nombre=@p_Nombre,  Ruc= @p_Ruc,   RazonSocial= @p_RazonSocial ,
   Domicilio= @p_Domicilio ,   Departamento= @p_Departamento ,  Provincia = @p_Provincia , Distrito= @p_Distrito ,  Telefono1=  @p_Telefono1 ,   Celular= @p_Celular ,   Correo= @p_Correo ,  Moroso=  @p_Moroso ,  Estado=  @p_Estado 
 where IdCliente = @p_IdCliente
go
-- Probar 
execute sp_ActualizarResgistro_Cliente 3 ,b,a,a,a,a,a,aaaaaaaaaaa,a,a,a,a,a,a,a,a,a,a

-- SP - BUSCAR CLIENTES 
go
create procedure sp_BuscarRegistro_Cliente
@p_IdCliente int
as
    select * from Cliente
    where  IdCliente=@p_IdCliente
go

--Probar 
execute sp_BuscarRegistro_Cliente 1

-- SP - ELIMINAR CLIENTES 
go
create procedure sp_EliminarRegistro_Cliente 
@p_IdCliente int 
as
  delete from Cliente
  where IdCliente = @p_IdCliente
go
--Probar
execute sp_EliminarRegistro_Cliente 1
----------------------------------------------------------------
--------------------------------------------------------------------
-------------------------------------------------------------------


-- SP MOVI CLIENTE
-- LISTAR--
go
create proc sp_listamovicli
as
select * from MoviCliente
order by IdMoviCliente
go

--SP INSERTAR MOVI-MOVICLIENTE
go
create proc sp_insertarmovicli
@p_fecha varchar(15),
@p_concepto varchar(100),
@p_nota varchar(50),
@p_tipomov varchar(20),
@p_tipomon varchar (50),
@p_importe int,
@p_idCliente int
as
insert MoviCliente(Fecha,Concepto,Nota,TipoMovimiento,TipoMoneda,Importe, IdCliente) values (@p_fecha,@p_concepto,@p_nota,@p_tipomov,
@p_tipomon,@p_importe,@p_idCliente)
go

--SP ACTUALIZAR  MOVI-CLIENTE
go
create proc sp_actualizarmovicli

@p_idmCliente int,
@p_fecha varchar(15),
@p_concepto varchar(100),
@p_nota varchar(50),
@p_tipomov varchar(20),
@p_tipomon varchar (50),
@p_importe int,
@p_idCliente int

as
update MoviCliente set  Fecha=@p_fecha, Concepto=@p_concepto,Nota=@p_nota,TipoMovimiento=@p_tipomov,TipoMoneda=@p_tipomon,
Importe=@p_importe, IdCliente= @p_idCliente
where IdMoviCliente=@p_idmCliente
go

--SP BUSCAR MOVI-CLIENTE
go
create proc sp_buscarmovicli
@p_idmCliente int
as
select * from MoviCliente
where IdMoviCliente=@p_idmCliente
go

-- SP  ELIMINAR MOVI-CLIENTE

go
create proc sp_eliminarmovicli
@p_idmCliente int
as
delete from MoviCliente
where IdMoviCliente=@p_idmCliente
go
