create database Grupo_5
use Grupo_5

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

   
)



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

)



  CREATE TABLE MoviCliente (
 
  IdMCliente                       INT IDENTITY PRIMARY KEY ,
  Fecha							   VARCHAR(15),
  Concepto                         VARCHAR(100), 
  TipoMovimiento                    VARCHAR(20),     
  TipoMoneda                       VARCHAR(10), 
  Importe                          FLOAT,
  Nota						   	   VARCHAR(50),

   IdCliente             INT
)



CREATE TABLE MoviProveedor (
  
  IdMProveedor                     INT IDENTITY PRIMARY KEY, 
  Fecha                            VARCHAR(15),
  Concepto                         VARCHAR (100),
  TipoMovimiento                   VARCHAR (20),
  TipoMoneda                       VARCHAR (10), 
  Importe                          FLOAT, 
  Nota                             VARCHAR (50),

   IdProveedor                     INT

)



CREATE TABLE Registro_Usuario (

  IdUsuario                                INT IDENTITY PRIMARY KEY,
  Usuario                                  VARCHAR(20), 
  Contraseña                               VARCHAR (20), 
  ApellidoPaterno                          VARCHAR(20),
  ApellidoMaterno                          VARCHAR(20), 
  Nombres                                  VARCHAR(30),
  Perfil                                   VARCHAR(30),
  Estado                                   VARCHAR(120) 

)



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

)


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

