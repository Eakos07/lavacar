USE [master]
GO

CREATE DATABASE [BD_Centro_Lavado_Octopus]
GO

USE [BD_Centro_Lavado_Octopus]
GO

CREATE SCHEMA [Sch_Administrativo]
GO
CREATE SCHEMA [Sch_General]
GO

--Creacion de tablas

CREATE TABLE [Sch_General].[T_Centro_de_lavado_Octopus]
(
	CedulaJuridica int not null,
	NombreComercial varchar (30) not null,
	Telefono int not null,
	Direccion varchar (150) not null,
	Email varchar (30) not null

	CONSTRAINT [PK_Cedula_Juridica] PRIMARY KEY CLUSTERED
	(
		CedulaJuridica ASC
	)
)
GO

CREATE TABLE [Sch_General].[T_Estados]
(
	IdEstado char not null,
	Nombre varchar (25) not null,
	
	CONSTRAINT [PK_IdEstado] PRIMARY KEY CLUSTERED  
	(
		IdEstado ASC
	)
)
GO

CREATE TABLE [Sch_Administrativo].[T_Polizas]
(
	IdPoliza varchar (20) not null,
	IdTipoPoliza char not null,
	FechaVencimiento date not null,
	IdEstado char  not null,
	CedulaJuridica int not null

	CONSTRAINT [PK_NumPolizas] PRIMARY KEY CLUSTERED
	(
		IdPoliza ASC
	) 
)
GO

CREATE TABLE [Sch_Administrativo].[T_Tipo_Polizas]
(
	IdTipoPoliza char not null,
	NombrePoliza varchar (20) not null,
	Compañia varchar (25) not null,
	IdProveedor tinyint not null

	CONSTRAINT [PK_IdTipoPoliza] PRIMARY KEY CLUSTERED
	(
		IdTipoPoliza ASC
	)
)
GO

CREATE TABLE [Sch_General].[T_Citas]
(
	NumeroCita int identity not null,
	Nombre varchar (30),
	Telefono int not null,
	NumPlaca varchar (10) not null,
	CodServicio char not null,
	Email varchar (50) not null,
	FechaCita datetime not null,
	HoraCita varchar (10) not null,
	IdEstado char not null,
	IdEmpleado tinyint not null

	CONSTRAINT [PK_IdCita] PRIMARY KEY CLUSTERED
	(
		NumeroCita ASC
	)
)
GO

CREATE TABLE [Sch_Administrativo].[T_Clientes]
(
	NumPlaca varchar (10)  not null,
	IdTipoPlaca tinyint not null,
	IdTipoVehiculo tinyint not null,
	NumVisitas tinyint not null

	CONSTRAINT [PK_NumPlaca] PRIMARY KEY CLUSTERED
	(
		NumPlaca ASC
	)
)
GO

CREATE TABLE [Sch_General].[T_TipoPlaca]
(
	IdTipoPlaca tinyint not null,
	Descripcion varchar (25) not null

	CONSTRAINT [PK_IdTipoPlaca] PRIMARY KEY CLUSTERED
	(
		IdTipoPlaca ASC
	)
)
GO

CREATE TABLE [Sch_General].[T_TipoVehiculo]
(
	IdTipoVehiculo tinyint not null,
	Descripcion varchar (25) not null

	CONSTRAINT [PK_IdTipoVehiculo] PRIMARY KEY CLUSTERED
	(
		IdTipoVehiculo ASC
	)
)
GO

CREATE TABLE [Sch_General].[T_TipoServicio]
(
	CodServicio char not null,
	NombreServicio varchar (25) not null,
	Precio money not null,
	Duracion varchar (10) not null,
	IdTipoVehiculo tinyint not null

	CONSTRAINT [PK_IdTipoServicio] PRIMARY KEY CLUSTERED
	(
		CodServicio ASC
	)
)
GO

CREATE TABLE [Sch_Administrativo].[T_Articulos]
(
	IdArticulo varchar (25) unique not null,
	NombreArticulo varchar (50) not null,
	Cantidad smallint not null,
	IdFamilia varchar (4) not null,
	IdTipoArticulo char not null,
	InventarioMinimo smallint not null,
	PrecioVenta money not null,
	IdEstado char not null

	CONSTRAINT [PK_IdArticulo] PRIMARY KEY CLUSTERED
	(
		IdArticulo ASC
	)
)
GO

CREATE TABLE [Sch_Administrativo].[T_TipoArticulo]
(
	IdTipoArticulo char not null,
	Descripcion varchar (20) not null,
	IdEstado char not null
	
	 CONSTRAINT [PK_IdTipoArticulo] PRIMARY KEY CLUSTERED
	(
		IdTipoArticulo ASC
	)
)
GO

CREATE TABLE [Sch_Administrativo].[T_OrdenesCompra]
(
	IdNumOrden int identity not null,
	IdProveedor tinyint not null,
	IdArticulo varchar (25) not null,
	Cantidad smallint not null,
	Precio money not null,
	IdEstado char not null

	 CONSTRAINT [PK_IdOrdenCompra] PRIMARY KEY CLUSTERED
	(
		IdNumOrden ASC
	)
)
GO

CREATE TABLE [Sch_Administrativo].[T_FamiliaArticulos]
(
	IdFamilia varchar (4)  not null,
	Descripcion varchar (20) not null,
	IdEstado char not null

	CONSTRAINT [PK_IdFamilia] PRIMARY KEY CLUSTERED
	(
		IdFamilia ASC
	)
)
GO

CREATE TABLE [Sch_Administrativo].[T_Proveedores]
(
	IdProveedor tinyint identity not null,
	NombreProveedor varchar (60) not null,
	Email varchar (40) not null,
	Telefono int not null,
	PlazoPago tinyint not null,
	IdEstado char not null

	CONSTRAINT [PK_IdProveedor] PRIMARY KEY CLUSTERED
	(
		IdProveedor ASC
	)
)
GO

CREATE TABLE [Sch_Administrativo].[T_Planillas]
(
	IdPlanilla int not null,
	IdEmpleado  tinyint  not null,
	IdHorario tinyint  not null,
	IdEstado char not null

	CONSTRAINT [PK_IdPlanilla] PRIMARY KEY CLUSTERED
	(
		IdPlanilla ASC
	)
)
GO

CREATE TABLE [Sch_Administrativo].[T_Empleados]
(
	IdEmpleado tinyint identity not null,
	Identificacion varchar (50) not null,
	Nombre varchar (45) not null,
	Apellidos varchar (120) not null,
	Telefono int not null,
	Direccion varchar (50) not null,
	Email varchar (30) not null,
	Puesto varchar (15) not null,
	IdEstado char not null,
	IdPoliza varchar (20) not null,
	IdUsuario varchar (20)  not null

	CONSTRAINT [PK_IdEmpleado] PRIMARY KEY CLUSTERED
	(
		IdEmpleado ASC
	)
)
GO

CREATE TABLE [Sch_Administrativo].[T_Usuarios]
(
	IdUsuario varchar (20)  not null,
	Contraseña varchar (50)  not null,
	IdRole tinyint not null,
	IdEstado char not null

	CONSTRAINT [PK_IdUsuario] PRIMARY KEY CLUSTERED
	(
		IdUsuario ASC
	)
)
GO

CREATE TABLE [Sch_Administrativo].[T_Roles]
 (
   IdRole tinyint NOT NULL,
   Nivel tinyint NOT NULL,
   Descripcion varchar (25) not null,
   IdEstado char NOT NULL

   CONSTRAINT [PK_IdRole] PRIMARY KEY CLUSTERED
	(
		IdRole ASC
	)
 )
GO

CREATE TABLE [Sch_Administrativo].[T_Horarios]
 (
   IdHorario tinyint identity NOT NULL, 
   Descripcion VARCHAR(20) NOT NULL,
   CantHoras float NOT NULL,
   Entrada DATETIME not null,
   Salida DATETIME not null,
   IdEstado char NOT NULL

   CONSTRAINT [PK_IdHorario] PRIMARY KEY CLUSTERED
	(
		IdHorario ASC
	)
 )
GO

CREATE TABLE [Sch_General].[T_Factura]
 (
	NumFactura INT identity,
	NumPlaca varchar (10) NOT NULL,
	CodServicio char NOT NULL,
   	IdTipoCambio CHAR NOT NULL,
   	CedulaJuridica int NOT NULL,
 	MontoNeto money not null,
  	Descuento money not null,
  	MontoTotal money not null,
	IdPromocion char not null,
	IdTipoFactura char not null

   CONSTRAINT [PK_NumFactura] PRIMARY KEY CLUSTERED
	(
		NumFactura ASC
	)
 )
GO

CREATE TABLE [Sch_General].[T_TipoCambio]
 (
	  IdTipoCambio CHAR NOT NULL,
	  Valor money NOT NULL,
	  Fecha DATE NOT NULL

	  CONSTRAINT [PK_IdTipoCambio] PRIMARY KEY CLUSTERED
		(
			IdTipoCambio ASC
		)
 )
 GO

 CREATE TABLE [Sch_Administrativo].[T_Promociones]
(
	IdPromocion char not null,
	TipoPromocion varchar (20),
	Descripcion varchar (70)

	CONSTRAINT [PK_IdPromocion] PRIMARY KEY CLUSTERED
		(
			IdPromocion ASC
		)
)
GO

 CREATE TABLE [Sch_Administrativo].[T_TipoFactura]
(
	IdTipoFactura char not null,
	TipoFactura varchar (20),
	Descripcion varchar (70)

	CONSTRAINT [PK_IdTipoFactura] PRIMARY KEY CLUSTERED
		(
			IdTipoFactura ASC
		)
)
GO

 --------------- Kevin
 CREATE TABLE [Sch_General].[T_TransaccionesCompra]
(
    IdTransaccionCompra int identity (1,1),
    IdNumOrden int not null,
    IdArticulo varchar (25) not null,
    IdProveedor tinyint not null,
    Documento varchar(30) not null,
    Fecha datetime not null,
    Cantidad smallint not null,
	Monto money not null

    CONSTRAINT [Pk_IdTransCompra] PRIMARY KEY CLUSTERED
    (
        IdTransaccionCompra
    )
)

CREATE TABLE  [Sch_General].[T_AjustesInventario]
(
    IdTransaccionAjusteInventario int identity (1,1),
    IdArticulo varchar (25) not null,
    Descripcion varchar(70) not null,
    Fecha datetime not null,
    Cantidad smallint not null,
    Monto money not null

    CONSTRAINT [Pk_IdTransAjuste] PRIMARY KEY CLUSTERED
    (
        IdTransaccionAjusteInventario
    )
)

CREATE TABLE [Sch_General].[T_TransaccionesVenta]
(
    IdTransaccionVenta int identity (1,1),
    IdArticulo varchar (25) not null,
    NumFactura int not null,
    Fecha datetime not null,
    Cantidad smallint not null,
	Monto money not null,
	IdEstado char not null

    CONSTRAINT [Pk_IdTransVenta] PRIMARY KEY CLUSTERED
    (
        IdTransaccionVenta
    )
)

 -------------Creacion de llaves foraneas---------------------

 -----------------------------------------------------------Jeff
 ---T_Polizas

		ALTER TABLE [Sch_Administrativo].[T_Polizas]  WITH NOCHECK 
		ADD CONSTRAINT FK_Estados_Polizas_IdEstado 
		FOREIGN KEY(IdEstado)
		REFERENCES [Sch_General].[T_Estados] (IdEstado)
GO
		ALTER TABLE [Sch_Administrativo].[T_Polizas] 
		CHECK CONSTRAINT FK_Estados_Polizas_IdEstado 
GO
--
		ALTER TABLE [Sch_Administrativo].[T_Polizas]  WITH NOCHECK 
		ADD CONSTRAINT FK_TipoPolizas_Polizas_IdTipoPoliza
		FOREIGN KEY(IdTipoPoliza)
		REFERENCES [Sch_Administrativo].[T_Tipo_Polizas] (IdTipoPoliza)
GO
		ALTER TABLE [Sch_Administrativo].[T_Polizas] 
		CHECK CONSTRAINT FK_TipoPolizas_Polizas_IdTipoPoliza
GO
--
		ALTER TABLE [Sch_Administrativo].[T_Polizas] WITH NOCHECK 
		ADD CONSTRAINT FK_CentroLavado_Polizas_CedulaJuridica
		FOREIGN KEY (CedulaJuridica)
		REFERENCES [Sch_General].[T_Centro_de_lavado_Octopus] (CedulaJuridica)
GO
		ALTER TABLE [Sch_Administrativo].[T_Polizas] 
		CHECK CONSTRAINT FK_CentroLavado_Polizas_CedulaJuridica
GO

---T_TipoPolizas
		ALTER TABLE [Sch_Administrativo].[T_Tipo_Polizas]  WITH NOCHECK 
		ADD CONSTRAINT FK_Tipo_Polizas_IdProveedor 
		FOREIGN KEY(IdProveedor)
		REFERENCES [Sch_Administrativo].[T_Proveedores] (IdProveedor)
GO
		ALTER TABLE [Sch_Administrativo].[T_Tipo_Polizas] 
		CHECK CONSTRAINT FK_Tipo_Polizas_IdProveedor 
GO

---T_Articulos
		ALTER TABLE [Sch_Administrativo].[T_Articulos]  WITH NOCHECK 
		ADD CONSTRAINT FK_IdFamilia_Articulos_IdFamilia 
		FOREIGN KEY(IdFamilia)
		REFERENCES [Sch_Administrativo].[T_FamiliaArticulos] (IdFamilia)
GO
		ALTER TABLE [Sch_Administrativo].[T_Articulos]
		CHECK CONSTRAINT FK_IdFamilia_Articulos_IdFamilia 
GO
--
		ALTER TABLE [Sch_Administrativo].[T_Articulos]  WITH NOCHECK 
		ADD CONSTRAINT FK_IdTipoArticulo_Articulos_IdTipoArticulo
		FOREIGN KEY(IdTipoArticulo)
		REFERENCES [Sch_Administrativo].[T_TipoArticulo] (IdTipoArticulo)
GO
		ALTER TABLE [Sch_Administrativo].[T_Articulos] 
		CHECK CONSTRAINT FK_IdTipoArticulo_Articulos_IdTipoArticulo
GO
--
		ALTER TABLE [Sch_Administrativo].[T_Articulos]  WITH NOCHECK 
		ADD CONSTRAINT FK_Estados_Articulos_IdEstado 
		FOREIGN KEY(IdEstado)
		REFERENCES [Sch_General].[T_Estados] (IdEstado)
GO
		ALTER TABLE [Sch_Administrativo].[T_Articulos]
		CHECK CONSTRAINT FK_Estados_Articulos_IdEstado 
GO

---T_TipoArticulo
		ALTER TABLE [Sch_Administrativo].[T_TipoArticulo] WITH NOCHECK 
		ADD CONSTRAINT FK_Estados_TipoArticulo_IdEstado 
		FOREIGN KEY(IdEstado)
		REFERENCES [Sch_General].[T_Estados] (IdEstado)
GO
		ALTER TABLE [Sch_Administrativo].[T_TipoArticulo]
		CHECK CONSTRAINT FK_Estados_TipoArticulo_IdEstado 
GO

--T_OrdenCompra
		ALTER TABLE [Sch_Administrativo].[T_OrdenesCompra]  WITH NOCHECK 
		ADD CONSTRAINT FK_Proveedores_OrdenesCompra_IdProveedor
		FOREIGN KEY(IdProveedor)
		REFERENCES [Sch_Administrativo].[T_Proveedores] (IdProveedor)
GO
		ALTER TABLE [Sch_Administrativo].[T_OrdenesCompra] 
		CHECK CONSTRAINT FK_Proveedores_OrdenesCompra_IdProveedor
GO
--
		ALTER TABLE [Sch_Administrativo].[T_OrdenesCompra]  WITH NOCHECK 
		ADD CONSTRAINT FK_Articulos_OrdenCompra_IdArticulo
		FOREIGN KEY (IdArticulo)
		REFERENCES [Sch_Administrativo].[T_Articulos] (IdArticulo)
GO
		ALTER TABLE [Sch_Administrativo].[T_OrdenesCompra]
		CHECK CONSTRAINT FK_Articulos_OrdenCompra_IdArticulo
GO
--
		ALTER TABLE [Sch_Administrativo].[T_OrdenesCompra]  WITH NOCHECK 
		ADD CONSTRAINT FK_Estados_OrdenCompra_IdEstado 
		FOREIGN KEY(IdEstado)
		REFERENCES [Sch_General].[T_Estados] (IdEstado)
GO
		ALTER TABLE [Sch_Administrativo].[T_OrdenesCompra]
		CHECK CONSTRAINT FK_Estados_OrdenCompra_IdEstado 
GO

---T_FamiliaArticulo
		ALTER TABLE  [Sch_Administrativo].[T_FamiliaArticulos]  WITH NOCHECK 
		ADD CONSTRAINT FK_Estados_FamiliaArticulos_IdEstado 
		FOREIGN KEY(IdEstado)
		REFERENCES [Sch_General].[T_Estados] (IdEstado)
GO
		ALTER TABLE  [Sch_Administrativo].[T_FamiliaArticulos]
		CHECK CONSTRAINT FK_Estados_FamiliaArticulos_IdEstado 
GO

---T_Horarios
		ALTER TABLE  [Sch_Administrativo].[T_Horarios]  WITH NOCHECK 
		ADD CONSTRAINT FK_Estados_Horarios_IdEstado 
		FOREIGN KEY(IdEstado)
		REFERENCES [Sch_General].[T_Estados] (IdEstado)
GO
		ALTER TABLE  [Sch_Administrativo].[T_Horarios]
		CHECK CONSTRAINT FK_Estados_Horarios_IdEstado 
GO


-----------------------------------------------------Jorge
--T_Factura
		ALTER TABLE [Sch_General].[T_Factura] WITH NOCHECK  
		ADD CONSTRAINT FK_TipoCambio_Factura_IdTipoCambio  
		FOREIGN KEY(IdTipoCambio)  
		REFERENCES [Sch_General].[T_TipoCambio] (IdTipoCambio)  
GO  
		ALTER TABLE [Sch_General].[T_Factura]  
		CHECK CONSTRAINT FK_TipoCambio_Factura_IdTipoCambio  
GO    

		ALTER TABLE [Sch_General].[T_Factura] WITH NOCHECK  
		ADD CONSTRAINT FK_Factura_T_Clientes_NumPlaca  
		FOREIGN KEY(NumPlaca)  
		REFERENCES [Sch_Administrativo].[T_Clientes] (NumPlaca)  
GO   
		ALTER TABLE [Sch_General].[T_Factura]  
		CHECK CONSTRAINT FK_Factura_T_Clientes_NumPlaca  
GO   

		ALTER TABLE [Sch_General].[T_Factura] WITH NOCHECK  
		ADD CONSTRAINT FK_Factura_T_TipoServicio_CodServicio  
		FOREIGN KEY(CodServicio)  
		REFERENCES [Sch_General].[T_TipoServicio] (CodServicio)  
GO   
		ALTER TABLE [Sch_General].[T_Factura]  
		CHECK CONSTRAINT FK_Factura_T_TipoServicio_CodServicio  
GO    

		ALTER TABLE [Sch_General].[T_Factura] WITH NOCHECK  
		ADD CONSTRAINT FK_Factura_T_Centro_de_lavado_Octopus_CedulaJuridica  
		FOREIGN KEY(CedulaJuridica) 
		REFERENCES [Sch_General].[T_Centro_de_lavado_Octopus] (CedulaJuridica)  
GO   
		ALTER TABLE [Sch_General].[T_Factura]  
		CHECK CONSTRAINT FK_Factura_T_Centro_de_lavado_Octopus_CedulaJuridica  
GO  

		ALTER TABLE [Sch_General].[T_Factura] WITH NOCHECK  
		ADD CONSTRAINT FK_Promociones_Factura_IdPromocion  
		FOREIGN KEY(IdPromocion) 
		REFERENCES [Sch_Administrativo].[T_Promociones] (IdPromocion) 
GO   
		ALTER TABLE [Sch_General].[T_Factura]  
		CHECK CONSTRAINT FK_Promociones_Factura_IdPromocion 
GO  
		ALTER TABLE [Sch_General].[T_Factura] WITH NOCHECK  
		ADD CONSTRAINT FK_TipoFactura_Factura_IdTipoFactura  
		FOREIGN KEY(IdTipoFactura) 
		REFERENCES [Sch_Administrativo].[T_TipoFactura] (IdTipoFactura) 
GO   
		ALTER TABLE [Sch_General].[T_Factura]  
		CHECK CONSTRAINT FK_TipoFactura_Factura_IdTipoFactura 
GO 

--T_Clientes
		ALTER TABLE [Sch_Administrativo].[T_Clientes] WITH NOCHECK  
		ADD CONSTRAINT FK_T_Clientes_T_T_TipoPlaca_IdTipoPlaca  
		FOREIGN KEY(IdTipoPlaca) 
		REFERENCES [Sch_General].[T_TipoPlaca] (IdTipoPlaca)  
GO  
		ALTER TABLE [Sch_Administrativo].[T_Clientes]  
		CHECK CONSTRAINT FK_T_Clientes_T_T_TipoPlaca_IdTipoPlaca  
GO   

		ALTER TABLE [Sch_Administrativo].[T_Clientes] WITH NOCHECK  
		ADD CONSTRAINT FK_T_Clientes_T_T_TipoVehiculo_IdTipoVehiculo  
		FOREIGN KEY(IdTipoVehiculo)  
		REFERENCES [Sch_General].[T_TipoVehiculo] (IdTipoVehiculo) 
GO   
		ALTER TABLE [Sch_Administrativo].[T_Clientes]  
		CHECK CONSTRAINT FK_T_Clientes_T_T_TipoVehiculo_IdTipoVehiculo  
GO
----------------------------------------------------Rafa
 --TABLA CITAS--

 	 ALTER TABLE [Sch_General].[T_Citas] WITH NOCHECK
	 ADD CONSTRAINT FK_Estados_Citas_IdEstado
	 FOREIGN KEY (IdEstado)
	 REFERENCES [Sch_General].[T_Estados] (IdEstado)
GO
	 ALTER TABLE [Sch_General].[T_Citas]
	 CHECK CONSTRAINT FK_Estados_Citas_IdEstado
GO

 	 ALTER TABLE [Sch_General].[T_Citas] WITH NOCHECK
	 ADD CONSTRAINT FK_Estados_TipoServicio_CodServicio
	 FOREIGN KEY (CodServicio)
	 REFERENCES [Sch_General].[T_TipoServicio] (CodServicio)
GO
	 ALTER TABLE [Sch_General].[T_Citas]
	 CHECK CONSTRAINT FK_Estados_TipoServicio_CodServicio
GO

 	 ALTER TABLE [Sch_General].[T_Citas] WITH NOCHECK
	 ADD CONSTRAINT FK_Estados_Clientes_NumPlaca
	 FOREIGN KEY (NumPlaca)
	 REFERENCES [Sch_Administrativo].[T_Clientes] (NumPlaca)
GO
	 ALTER TABLE [Sch_General].[T_Citas]
	 CHECK CONSTRAINT FK_Estados_Clientes_NumPlaca
GO

	ALTER TABLE [Sch_General].[T_Citas] WITH NOCHECK
	ADD CONSTRAINT FK_Empleados_Citas_IdEmpleado 
	FOREIGN KEY (IdEmpleado)
	REFERENCES [Sch_Administrativo].[T_Empleados](IdEmpleado)
GO
	ALTER TABLE [Sch_General].[T_Citas]
	CHECK CONSTRAINT FK_Empleados_Citas_IdEmpleado 
GO

--T Roles

 	 ALTER TABLE [Sch_Administrativo].[T_Roles] WITH NOCHECK
	 ADD CONSTRAINT FK_Estados_Roles_IdEstado
	 FOREIGN KEY (IdEstado)
	 REFERENCES [Sch_General].[T_Estados] (IdEstado)
GO
	 ALTER TABLE [Sch_Administrativo].[T_Roles]
	 CHECK CONSTRAINT FK_Estados_Roles_IdEstado
GO
 	
	---------------------------------------------------------------------------- Pablo

	--T_Proveedores
ALTER TABLE[Sch_Administrativo].[T_Proveedores] WITH NOCHECK 
ADD CONSTRAINT FK_Estado_Proveedores_IdEstado 
FOREIGN KEY(IdEstado) 
REFERENCES  [Sch_General].[T_Estados] (IdEstado) 
GO
 
ALTER TABLE [Sch_Administrativo].[T_Proveedores] 
CHECK CONSTRAINT FK_Estado_Proveedores_IdEstado
GO

  --T_Planilla
ALTER TABLE  [Sch_Administrativo].[T_Planillas] WITH NOCHECK 
ADD CONSTRAINT FK_Planillas_Empleados_IdEmpleado 
FOREIGN KEY(IdEmpleado) 
REFERENCES  [Sch_Administrativo].[T_Empleados] 
GO
 
ALTER TABLE  [Sch_Administrativo].[T_Planillas] 
CHECK CONSTRAINT  FK_Planillas_Empleados_IdEmpleado 
GO 

ALTER TABLE  [Sch_Administrativo].[T_Planillas] WITH NOCHECK 
ADD CONSTRAINT FK_Horario_Planillas_IdHorario
FOREIGN KEY(IdHorario) 
REFERENCES  [Sch_Administrativo].[T_Horarios] 
GO
 
ALTER TABLE  [Sch_Administrativo].[T_Planillas] 
CHECK CONSTRAINT FK_Horario_Planillas_IdHorario
GO 

ALTER TABLE  [Sch_Administrativo].[T_Planillas] WITH NOCHECK 
ADD CONSTRAINT FK_Estados_Planilla_IdEstado
FOREIGN KEY(IdEstado) 
REFERENCES  [Sch_General].[T_Estados]
GO
 
ALTER TABLE  [Sch_Administrativo].[T_Planillas] 
CHECK CONSTRAINT FK_Estados_Planilla_IdEstado
GO 
--T_Empleado
ALTER TABLE  [Sch_Administrativo].[T_Empleados] WITH NOCHECK 
ADD CONSTRAINT FK_Estado_Empleados_IdEstado 
FOREIGN KEY (IdEstado)
REFERENCES  [Sch_General].[T_Estados] (IdEstado) 
GO
 
ALTER TABLE [Sch_Administrativo].[T_Empleados] 
CHECK CONSTRAINT FK_Estado_Empleados_IdEstado 
GO
--
ALTER TABLE  [Sch_Administrativo].[T_Empleados] WITH NOCHECK  
ADD CONSTRAINT FK_Usuarios_Empleados_IdUsuario  
FOREIGN KEY (IdUsuario)  
REFERENCES [Sch_Administrativo].[T_Usuarios] (IdUsuario)  
GO

ALTER TABLE [Sch_Administrativo].[T_Empleados]  
CHECK CONSTRAINT FK_Usuarios_Empleados_IdUsuario  
GO
--
ALTER TABLE  [Sch_Administrativo].[T_Empleados] WITH NOCHECK  
ADD CONSTRAINT FK_Polizas_Empleados_IdPoliza  
FOREIGN KEY (IdPoliza )  
REFERENCES [Sch_Administrativo].[T_Polizas](IdPoliza )  
GO

ALTER TABLE [Sch_Administrativo].[T_Empleados]  
CHECK CONSTRAINT FK_Polizas_Empleados_IdPoliza
GO

--T_Usuarios
ALTER TABLE  [Sch_Administrativo].[T_Usuarios]  WITH NOCHECK  
ADD CONSTRAINT FK_Roles_Usuarios_IdRole  
FOREIGN KEY (IdRole)  
REFERENCES  [Sch_Administrativo].[T_Roles] (IdRole)  
GO

ALTER TABLE [Sch_Administrativo].[T_Usuarios]  
CHECK CONSTRAINT FK_Roles_Usuarios_IdRole  
GO

ALTER TABLE  [Sch_Administrativo].[T_Usuarios] WITH NOCHECK 
ADD CONSTRAINT FK_Estados_Usuarios_IdEstado
FOREIGN KEY(IdEstado) 
REFERENCES  [Sch_General].[T_Estados]
GO
 
ALTER TABLE  [Sch_Administrativo].[T_Usuarios]
CHECK CONSTRAINT FK_Estados_Usuarios_IdEstado
GO 
 ----------------------------------------------------------Kevin

 ---T_TransaccionesCompra
ALTER TABLE [Sch_General].[T_TransaccionesCompra] WITH NOCHECK
ADD CONSTRAINT FK_OrdenesCompra_TransaccionesCompra_IdNumOrden
FOREIGN KEY (IdNumOrden)
REFERENCES  [Sch_Administrativo].[T_OrdenesCompra]
GO

ALTER TABLE [Sch_General].[T_TransaccionesCompra]
CHECK CONSTRAINT FK_OrdenesCompra_TransaccionesCompra_IdNumOrden
GO

ALTER TABLE [Sch_General].[T_TransaccionesCompra] WITH NOCHECK
ADD CONSTRAINT Fk_Articulos_TransaccionesCompra_IdArticulo
FOREIGN KEY (IdArticulo)
REFERENCES  [Sch_Administrativo].[T_Articulos]
GO

ALTER TABLE [Sch_General].[T_TransaccionesCompra]
CHECK CONSTRAINT Fk_Articulos_TransaccionesCompra_IdArticulo
GO

ALTER TABLE [Sch_General].[T_TransaccionesCompra] WITH NOCHECK
ADD CONSTRAINT Fk_Proveedores_TransaccionesCompra_IdProveedor
FOREIGN KEY (IdProveedor)
REFERENCES  [Sch_Administrativo].[T_Proveedores]
GO

ALTER TABLE [Sch_General].[T_TransaccionesCompra]
CHECK CONSTRAINT Fk_Proveedores_TransaccionesCompra_IdProveedor
GO

---T_AjustesInventario
ALTER TABLE [Sch_General].[T_AjustesInventario] WITH NOCHECK
ADD CONSTRAINT Fk_Articulos_AjustesInventario_IdArticulo
FOREIGN KEY (IdArticulo)
REFERENCES  [Sch_Administrativo].[T_Articulos]
GO

ALTER TABLE [Sch_General].[T_AjustesInventario]
CHECK CONSTRAINT Fk_Articulos_AjustesInventario_IdArticulo
GO

---T_TransaccionesVenta
ALTER TABLE [Sch_General].[T_TransaccionesVenta] WITH NOCHECK
ADD CONSTRAINT Fk_Articulos_TransaccionesVenta_IdArticulo
FOREIGN KEY (IdArticulo)
REFERENCES  [Sch_Administrativo].[T_Articulos]
GO

ALTER TABLE [Sch_General].[T_TransaccionesVenta]
CHECK CONSTRAINT Fk_Articulos_TransaccionesVenta_IdArticulo
GO

ALTER TABLE [Sch_General].[T_TransaccionesVenta] WITH NOCHECK
ADD CONSTRAINT Fk_Factura_TransaccionesVenta_NumFactura
FOREIGN KEY (NumFactura)
REFERENCES  [Sch_General].[T_Factura]
GO

ALTER TABLE [Sch_General].[T_TransaccionesVenta]
CHECK CONSTRAINT Fk_Factura_TransaccionesVenta_NumFactura

GO

ALTER TABLE [Sch_General].[T_TransaccionesVenta] WITH NOCHECK
ADD CONSTRAINT FK_Estado_TransaccionesVenta_IdEstado
FOREIGN KEY (IdEstado)
REFERENCES [Sch_General].[T_Estados]
GO

ALTER TABLE [Sch_General].[T_TransaccionesVenta]
CHECK CONSTRAINT FK_Estado_TransaccionesVenta_IdEstado
GO

-------------Creacion de SP´s----------------------

----------------------------------Jeff

--Listar 

CREATE PROCEDURE dbo.SP_LISTAR_PROMOCIONES
AS
BEGIN
SELECT [IdPromocion] AS Promocion,
		[TipoPromocion] AS Tipo_Promocion,
		[Descripcion] AS Descripcion
	FROM [Sch_Administrativo].[T_Promociones]
END
GO

CREATE PROCEDURE dbo.SP_LISTAR_PROVEEDORES
AS
BEGIN
SELECT P.IdProveedor AS Proveedor,
		P.NombreProveedor AS Nombre_Proveedor,
		P.Email AS Email,
		P.Telefono AS Telefono,
		P.PlazoPago AS Plazo_Pago,
		E.Nombre AS Estado
	FROM [Sch_Administrativo].[T_Proveedores] P
		INNER JOIN [Sch_General].[T_Estados] E
			ON P.IdEstado = E.IdEstado
END
GO

CREATE PROCEDURE dbo.SP_LISTAR_ROLES
AS
BEGIN
SELECT R.IdRole AS Role,
		R.Nivel AS Nivel,
		R.Descripcion AS Descripcion,
		E.Nombre AS Estado
	FROM [Sch_Administrativo].[T_Roles] R
		INNER JOIN [Sch_General].[T_Estados] E
			ON R.IdEstado = E.IdEstado
END
GO

CREATE PROCEDURE dbo.SP_LISTAR_TIPO_POLIZAS
AS
BEGIN
SELECT TP.IdTipoPoliza AS Tipo_Polizas,
		TP.NombrePoliza AS Nombre_Poliza,
		TP.Compañia AS Compañia,
		P.[NombreProveedor] AS Proveedor
	FROM [Sch_Administrativo].[T_Tipo_Polizas] TP
		INNER JOIN [Sch_Administrativo].[T_Proveedores] P
			ON TP.IdProveedor = P.IdProveedor
END
GO

CREATE PROCEDURE dbo.SP_LISTAR_TIPO_ARTICULO
AS
BEGIN
SELECT TA.IdTipoArticulo AS Tipo_Articulo,
		TA.Descripcion AS Descripcion,
		E.Nombre AS Estado
	FROM [Sch_Administrativo].[T_TipoArticulo] TA
		INNER JOIN [Sch_General].[T_Estados] E
			ON TA.IdEstado = E.IdEstado
END
GO

CREATE PROCEDURE dbo.SP_LISTAR_TIPO_FACTURA
AS
BEGIN
SELECT [IdTipoFactura] AS Factura,
		[TipoFactura] AS Tipo_Factura,
		[Descripcion] AS Descripcion
	FROM [Sch_Administrativo].[T_TipoFactura]
END
GO

CREATE PROCEDURE dbo.SP_LISTAR_USUARIOS
AS
BEGIN
SELECT U.[IdUsuario] AS Usurio,
		U.[Contraseña] AS Contraseña,
		R.Nivel AS Role,
		E.Nombre AS Estado
	FROM[Sch_Administrativo].[T_Usuarios] U
		INNER JOIN [Sch_Administrativo].[T_Roles] R
			ON U.IdRole = R.IdRole
		INNER JOIN [Sch_General].[T_Estados] E
			ON U.IdEstado = E.IdEstado
END
GO

--Insertar
CREATE PROCEDURE dbo.SP_INSERTAR_PROMOCIONES
(
	@IdPromocion char,
	@TipoPromocion varchar (20),
	@Descripcion varchar (70)
)
AS 
BEGIN
INSERT INTO [Sch_Administrativo].[T_Promociones]
(
	[IdPromocion],
	[TipoPromocion],
	[Descripcion]
)
VALUES
(
	@IdPromocion,
	@TipoPromocion,
	@Descripcion
)
END
GO

CREATE PROCEDURE dbo.SP_INSERTAR_PROVEEDORES
(
	@NombreProveedor varchar (60),
	@Email varchar (40),
	@Telefono int,
	@PlazoPago tinyint,
	@IdEstado char
)
AS
BEGIN
INSERT INTO [Sch_Administrativo].[T_Proveedores]
(
	[NombreProveedor],
	[Email],
	[Telefono],
	[PlazoPago],
	[IdEstado]
)
VALUES
(
	@NombreProveedor,
	@Email,
	@Telefono,
	@PlazoPago,
	@IdEstado
)
SELECT MAX ([IdProveedor])
FROM [Sch_Administrativo].[T_Proveedores]
END
GO

CREATE PROCEDURE dbo.SP_INSERTAR_ROLES
(
	@IdRole tinyint,
	@Nivel tinyint,
	@Descripcion varchar (25),
	@IdEstado char
)
AS 
BEGIN
INSERT INTO [Sch_Administrativo].[T_Roles]
(
	[IdRole],
	[Nivel],
	[Descripcion],
	[IdEstado]
)
VALUES
(
	@IdRole,
	@Nivel,
	@Descripcion,
	@IdEstado
)
END
GO

CREATE PROCEDURE dbo.SP_INSERTAR_TIPO_POLIZAS
(
	@IdTipoPoliza char,
	@NombrePoliza varchar (20),
	@Compañia varchar (25),
	@IdProveedor tinyint
)
AS
BEGIN
INSERT INTO [Sch_Administrativo].[T_Tipo_Polizas]
(
	[IdTipoPoliza],
	[NombrePoliza],
	[Compañia],
	[IdProveedor]
)
VALUES
(
	@IdTipoPoliza,
	@NombrePoliza,
	@Compañia,
	@IdProveedor
)
END
GO

CREATE PROCEDURE dbo.SP_INSERTAR_TIPO_ARTICULO
(
	@IdTipoArticulo char,
	@Descripcion varchar (20),
	@IdEstado char

)
AS
BEGIN
INSERT INTO [Sch_Administrativo].[T_TipoArticulo]
(
	[IdTipoArticulo],
	[Descripcion],
	[IdEstado]
)
VALUES
(
	@IdTipoArticulo,
	@Descripcion,
	@IdEstado
)
END
GO

CREATE PROCEDURE dbo.SP_INSERTAR_TIPO_FACTURA
(
	@IdTipoFactura char,
	@TipoFactura varchar (20),
	@Descripcion varchar (70)

)
AS
BEGIN
INSERT INTO [Sch_Administrativo].[T_TipoFactura]
(
	[IdTipoFactura],
	[TipoFactura],
	[Descripcion]
)
VALUES 
(
	@IdTipoFactura,
	@TipoFactura,
	@Descripcion
)
END
GO

CREATE PROCEDURE dbo.SP_INSERTAR_USUARIOS
(
	@IdUsuario varchar (20),
	@Contraseña varchar (50),
	@IdRole tinyint,
	@IdEstado char
)
AS
BEGIN
INSERT INTO [Sch_Administrativo].[T_Usuarios]
(
	[IdUsuario],
	[Contraseña],
	[IdRole],
	[IdEstado]
)
VALUES 
(
	@IdUsuario,
	@Contraseña,
	@IdRole,
	@IdEstado 
)
END
GO

--MODIFICAR

CREATE PROCEDURE dbo.SP_MODIFICAR_PROMOCIONES
(
	@IdPromocion char,
	@TipoPromocion varchar (20),
	@Descripcion varchar (70)
)
AS
BEGIN
UPDATE  [Sch_Administrativo].[T_Promociones]
	SET	[TipoPromocion] = @TipoPromocion,
		[Descripcion] = @Descripcion
	WHERE [IdPromocion] = @IdPromocion
END
GO

CREATE PROCEDURE dbo.SP_MODIFICAR_PROVEEDORES
(
	@IdProveedor tinyint,
	@NombreProveedor varchar (60),
	@Email varchar (40),
	@Telefono int,
	@PlazoPago tinyint,
	@IdEstado char
)
AS
BEGIN
UPDATE [Sch_Administrativo].[T_Proveedores]
	SET [NombreProveedor] = @NombreProveedor,
		[Email] = @Email,
		[Telefono] = @Telefono,
		[PlazoPago] = @PlazoPago,
		[IdEstado] = @IdEstado
	WHERE [IdProveedor] = @IdProveedor 
END
GO



CREATE PROCEDURE dbo.SP_MODIFICAR_ROLES
(
	@IdRole tinyint,
	@Nivel tinyint,
	@Descripcion varchar (25),
    @IdEstado char 
)
AS
BEGIN
UPDATE [Sch_Administrativo].[T_Roles]
	SET [Nivel] = @Nivel,
		[Descripcion] = @Descripcion,
		[IdEstado] = @IdEstado
	WHERE [IdRole] = @IdRole
END
GO

CREATE PROCEDURE dbo.SP_MODIFICAR_TIPO_POLIZAS
(
	@IdTipoPoliza char,
	@NombrePoliza varchar (20),
	@Compañia varchar (25),
	@IdProveedor tinyint

)
AS
BEGIN
UPDATE [Sch_Administrativo].[T_Tipo_Polizas]
	SET [NombrePoliza] = @NombrePoliza,
		[Compañia] = @Compañia,
		[IdProveedor] = @IdProveedor
	WHERE [IdTipoPoliza] = @IdTipoPoliza
END
GO

CREATE PROCEDURE dbo.SP_MODIFICAR_TIPO_ARTICULO
(
	@IdTipoArticulo char,
	@Descripcion varchar (20),
	@IdEstado char

)
AS
BEGIN
UPDATE [Sch_Administrativo].[T_TipoArticulo]
	SET [Descripcion] = @Descripcion,
		[IdEstado] = @IdEstado
	WHERE [IdTipoArticulo] = @IdTipoArticulo
END
GO

CREATE PROCEDURE dbo.SP_MODIFICAR_TIPO_FACTURA
(
	@IdTipoFactura char,
	@TipoFactura varchar (20),
	@Descripcion varchar (70)

)
AS
BEGIN
UPDATE [Sch_Administrativo].[T_TipoFactura]
	SET [TipoFactura] = @TipoFactura,
		[Descripcion] = @Descripcion
	WHERE [IdTipoFactura] = @IdTipoFactura
END
GO

CREATE PROCEDURE dbo.SP_MODIFICAR_USUARIOS
(
	@IdUsuario varchar (20),
	@Contraseña varchar (50),
	@IdRole tinyint,
	@IdEstado char
)
AS
BEGIN
UPDATE [Sch_Administrativo].[T_Usuarios]
	SET [Contraseña] = @Contraseña,
		[IdRole] = @IdRole,
		[IdEstado] = @IdEstado
	WHERE [IdUsuario] = @IdUsuario
END
GO

--FILTRAR

CREATE PROCEDURE dbo.SP_FILTRAR_PROMOCIONES
(
	@TipoPromocion varchar (20)
)
AS
BEGIN
SELECT [IdPromocion] AS Promocion,
		[TipoPromocion] AS Tipo_Promocion,
		[Descripcion] AS Descripcion
	FROM [Sch_Administrativo].[T_Promociones]
	WHERE [TipoPromocion] LIKE '%' + @TipoPromocion + '%'
END
GO

CREATE PROCEDURE dbo.SP_FILTRAR_PROVEEDORES
(
	@NombreProveedor varchar (60)
)
AS
BEGIN
SELECT P.IdProveedor AS Proveedor,
		P.NombreProveedor AS Nombre_Proveedor,
		P.Email AS Email,
		P.Telefono AS Telefono,
		P.PlazoPago AS Plazo_Pago,
		E.Nombre AS Estado
	FROM [Sch_Administrativo].[T_Proveedores] P
		INNER JOIN [Sch_General].[T_Estados] E
			ON P.IdEstado = E.IdEstado
	WHERE P.NombreProveedor LIKE '%' + @NombreProveedor + '%'
END
GO

CREATE PROCEDURE dbo.SP_FILTRAR_ROLES
(
	@Descripcion varchar(25)
)
AS
BEGIN
SELECT R.IdRole AS Role,
		R.Nivel AS Nivel,
		R.Descripcion AS Descripcion,
		E.Nombre AS Estado
	FROM [Sch_Administrativo].[T_Roles] R
		INNER JOIN [Sch_General].[T_Estados] E
			ON R.IdEstado = E.IdEstado
	WHERE R.Descripcion LIKE '%' + @Descripcion + '%'
END
GO

CREATE PROCEDURE dbo.SP_FILTRAR_TIPO_POLIZAS
(
	@NombrePoliza varchar(25)
)
AS
BEGIN
SELECT TP.IdTipoPoliza AS Tipo_Polizas,
		TP.NombrePoliza AS Nombre_Poliza,
		TP.Compañia AS Compañia,
		P.NombreProveedor AS Proveedor
	FROM [Sch_Administrativo].[T_Tipo_Polizas] TP
		INNER JOIN [Sch_Administrativo].[T_Proveedores] P
			ON TP.IdProveedor = P.IdProveedor
	WHERE TP.NombrePoliza LIKE '%' + @NombrePoliza + '%'
END
GO

CREATE PROCEDURE dbo.SP_FILTRAR_TIPO_ARTICULO
(
	@Descripcion varchar (20)
)
AS
BEGIN
SELECT TA.IdTipoArticulo AS Tipo_Articulo,
		TA.Descripcion AS Descripcion,
		E.Nombre AS Estado
	FROM [Sch_Administrativo].[T_TipoArticulo] TA
		INNER JOIN [Sch_General].[T_Estados] E
			ON TA.IdEstado = E.IdEstado
	WHERE TA.Descripcion LIKE '%' + @Descripcion + '%'
END
GO

CREATE PROCEDURE dbo.SP_FILTRAR_TIPO_FACTURA
(
	@TipoFactura varchar (20)
)
AS
BEGIN
SELECT [IdTipoFactura] AS Factura,
		[TipoFactura] AS Tipo_Factura,
		[Descripcion] AS Descripcion
	FROM [Sch_Administrativo].[T_TipoFactura]
	WHERE [TipoFactura] LIKE '%' + @TipoFactura + '%'
END
GO

CREATE PROCEDURE dbo.SP_FILTRAR_USUARIOS
(
	@IdUsuario varchar (20)
)
AS
BEGIN
SELECT U.IdUsuario AS Usurio,
		U.Contraseña AS Contraseña,
		R.Nivel AS Role,
		E.Nombre AS Estado
	FROM[Sch_Administrativo].[T_Usuarios] U
		INNER JOIN [Sch_Administrativo].[T_Roles] R
			ON U.IdRole = R.IdRole
		INNER JOIN [Sch_General].[T_Estados] E
			ON U.IdEstado = E.IdEstado
	WHERE U.IdUsuario LIKE '%' + @IdUsuario + '%'
END
GO
---------------------------------------RAFA
--LISTAR--

Create Procedure dbo.SP_LISTAR_ARTICULOS
AS
BEGIN
SELECT
	A.IdArticulo as Articulo,
	A.NombreArticulo as Nombre_Articulo,
	A.Cantidad as Cantidad,
	FA.Descripcion as Familia_Articulo,
	TA.Descripcion as Tipo_Articulo,
	A.InventarioMinimo as Inventario,
	A.PrecioVenta as Precio_venta,
	E.Nombre as  Estado

FROM [Sch_Administrativo].[T_Articulos] A
INNER JOIN [Sch_Administrativo].[T_FamiliaArticulos] FA
ON A.IdFamilia = FA.IdFamilia
INNER JOIN [Sch_Administrativo].[T_TipoArticulo] TA
ON A.IdTipoArticulo = TA.IdTipoArticulo
INNER JOIN [Sch_General].[T_Estados] E
ON A.IdEstado = E.IdEstado
END
GO


Create Procedure dbo.SP_LISTAR_CLIENTES
AS
BEGIN
SELECT
	C.NumPlaca as Placa,
	TP.Descripcion as Tipo_Placa,
	TV.Descripcion as Tipo_Vehiculo,
	C.NumVisitas as Visitas

FROM[Sch_Administrativo].[T_Clientes] C
INNER JOIN [Sch_General].[T_TipoPlaca] TP
ON C.IdTipoPlaca = TP.IdTipoPlaca
INNER JOIN [Sch_General].[T_TipoVehiculo] TV
ON C.IdTipoVehiculo = TV.IdTipoVehiculo
END
GO


Create Procedure dbo.SP_LISTAR_EMPLEADOS
AS
BEGIN
SELECT
	Em.IdEmpleado as Numero_Empleado,
	Em.Identificacion as identificacion,
	Em.Nombre as Nombre,
	Em.Apellidos as Apellidos,
	Em.Telefono as Telefono,
	Em.Direccion as Direccion,
	Em.Email as Email,
	Em.Puesto as Puesto,
	E.Nombre as  Estado,
	Em.IdPoliza as Poliza,
	Em.IdUsuario as Usuario

FROM [Sch_Administrativo].[T_Empleados] Em
INNER JOIN [Sch_General].[T_Estados] E
ON Em.IdEstado = E.IdEstado

END
GO

Create Procedure dbo.SP_LISTAR_FAMILIA_ARTICULOS
AS
BEGIN
SELECT
	FA.IdFamilia as Familia_Articulo,
	FA.Descripcion as Descripcion,
	E.Nombre as  Estado

FROM [Sch_Administrativo].[T_FamiliaArticulos] FA
INNER JOIN [Sch_General].[T_Estados] E
ON FA.IdEstado = E.IdEstado
END
GO

Create Procedure dbo.SP_LISTAR_HORARIOS
AS
BEGIN
SELECT
	H.IdHorario as Horario,
	H.Descripcion as Descripcion,
	H.CantHoras as Cantidad_Horas,
	H.Entrada as Entrada,
	H.Salida as Salida,
	E.Nombre as  Estado

FROM [Sch_Administrativo].[T_Horarios] H
INNER JOIN [Sch_General].[T_Estados] E
ON H.IdEstado = E.IdEstado
END
GO

Create Procedure dbo.SP_LISTAR_ORDENES_COMPRA
AS
BEGIN
SELECT
	OC.IdNumOrden as Numero_Orden,
	P.NombreProveedor as Proveedor,
	A.NombreArticulo as Articulo,
	OC.Cantidad as Cantidad,
	OC.Precio as Precio,
	E.Nombre as  Estado

FROM[Sch_Administrativo].[T_OrdenesCompra] OC
INNER JOIN [Sch_Administrativo].[T_Proveedores] P
ON OC.IdProveedor = P.IdProveedor
INNER JOIN [Sch_Administrativo].[T_Articulos] A
ON OC.IdArticulo = A.IdArticulo
INNER JOIN [Sch_General].[T_Estados] E
ON OC.IdEstado = E.IdEstado
END
GO

Create Procedure dbo.SP_LISTAR_PLANILLAS
AS
BEGIN
SELECT
	P.IdPlanilla as Planilla,
	E.Nombre + E.Apellidos as  Empleado,
	H.Descripcion as Horario,
	Es.Nombre as  Estado

FROM[Sch_Administrativo].[T_Planillas] P
INNER JOIN [Sch_Administrativo].[T_Empleados] E
ON P.IdEmpleado = E.IdEmpleado
INNER JOIN [Sch_Administrativo].[T_Horarios] H
ON P.IdHorario = H.IdHorario
INNER JOIN [Sch_General].[T_Estados] Es
ON P.IdEstado = Es.IdEstado
END
GO

Create Procedure dbo.SP_LISTAR_POLIZAS
AS
BEGIN
SELECT
	P.IdPoliza as Poliza,
	TP.NombrePoliza as Tipo_Poliza,
	P.FechaVencimiento as Fecha_vencimiento,
	E.Nombre as  Estado,
	P.CedulaJuridica as Cedula_Jurica

FROM[Sch_Administrativo].[T_Polizas] P
INNER JOIN [Sch_Administrativo].[T_Tipo_Polizas] TP
ON P.IdTipoPoliza = TP.IdTipoPoliza
INNER JOIN [Sch_General].[T_Estados] E
ON P.IdEstado = E.IdEstado
END
GO

--INSERTAR--
Create Procedure dbo.SP_INSERTAR_ARTICULOS
(
	@IdArticulo varchar(25),
	@NombreArticulo varchar(50),
	@Cantidad smallint,
	@IdFamilia varchar(4),
	@IdTipoArticulo char(1),
	@InventarioMinimo smallint,
	@PrecioVenta money,
	@IdEstado char
)
AS
BEGIN
INSERT INTO [Sch_Administrativo].[T_Articulos]
(		[IdArticulo],
		[NombreArticulo],
		[Cantidad],
		[IdFamilia],
		[IdTipoArticulo],
		[InventarioMinimo],
		[PrecioVenta],
		[IdEstado]
		)
VALUES
(
	@IdArticulo,
	@NombreArticulo,
	@Cantidad,
	@IdFamilia ,
	@IdTipoArticulo,
	@InventarioMinimo,
	@PrecioVenta,
	@IdEstado 
	)
END
GO

Create Procedure dbo.SP_INSERTAR_CLIENTES
(
	@NumPlaca varchar(10),
	@IdTipoPlaca tinyint,
	@IdTipoVehiculo tinyint	
)
AS
BEGIN
DECLARE @NumVisitas tinyint
SET @NumVisitas = 1
INSERT INTO [Sch_Administrativo].[T_Clientes]
(
		[NumPlaca],
		[IdTipoPlaca],
		[IdTipoVehiculo],
		[NumVisitas]
		)
VALUES
(	@NumPlaca,
	@IdTipoPlaca,
	@IdTipoVehiculo,
	@NumVisitas
)
END
GO

Create Procedure dbo.SP_INSERTAR_EMPLEADOS
(	
	@Identificacion varchar(50),
	@Nombre varchar(45),
	@Apellidos varchar(120),
	@Telefono int,
	@Direccion varchar(50),
	@Email varchar(30),
	@Puesto varchar(15),
	@IdEstado char,
	@IdPoliza varchar(20),
	@IdUsuario varchar(20)
	)
AS
BEGIN
INSERT INTO [Sch_Administrativo].[T_Empleados]
(
		
		[Identificacion],
		[Nombre],
		[Apellidos],
		[Telefono],
		[Direccion],
		[Email],
		[Puesto],
		[IdEstado],
		[IdPoliza],
		[IdUsuario]
	)
VALUES
(	
	@Identificacion,
	@Nombre,
	@Apellidos,
	@Telefono,
	@Direccion,
	@Email,
	@Puesto,
	@IdEstado,
	@IdPoliza,
	@IdUsuario
	)
SELECT MAX([IdEmpleado])
FROM [Sch_Administrativo].[T_Empleados]
END

GO

Create Procedure dbo.SP_INSERTAR_FAMILIA_ARTICULOS
(
	@IdFamilia varchar(4),
	@Descripcion varchar(20),
	@IdEstado char
)
AS
BEGIN
INSERT INTO[Sch_Administrativo].[T_FamiliaArticulos]
(		[IdFamilia],
		[Descripcion],
		[IdEstado]
		)
VALUES
(	@IdFamilia,
	@Descripcion,
	@IdEstado
)
END
GO

Create Procedure dbo.SP_INSERTAR_HORARIOS
(
	@Descripcion varchar(20),
	@CantHoras float,
	@Entrada datetime,
	@Salida datetime,
	@IdEstado char
)
AS
BEGIN
INSERT INTO [Sch_Administrativo].[T_Horarios]
(		[Descripcion],
		[CantHoras],
		[Entrada],
		[Salida],
		[IdEstado]
		)
VALUES
(	
	@Descripcion,
	@CantHoras,
	@Entrada,
	@Salida,
	@IdEstado 
)

SELECT MAX([IdHorario])
FROM [Sch_Administrativo].[T_Horarios]
END
GO

Create Procedure dbo.SP_INSERTAR_ORDENES_COMPRA
(
	
	@IdProveedor tinyint,
	@IdArticulo varchar(25),
	@Cantidad smallint,
	@Precio money,
	@IdEstado char
)
AS
BEGIN 
INSERT INTO [Sch_Administrativo].[T_OrdenesCompra]
(		
		[IdProveedor],
		[IdArticulo],
		[Cantidad],
		[Precio],
		[IdEstado]
		)
VALUES
(
	@IdProveedor,
	@IdArticulo,
	@Cantidad,
	@Precio,
	@IdEstado
)
SELECT MAX (IdNumOrden)
FROM [Sch_Administrativo].[T_OrdenesCompra]

END
GO

Create Procedure dbo.SP_INSERTAR_PLANILLAS
(
	@IdPlanilla int,
	@IdEmpleado tinyint,
	@IdHorario tinyint,
	@IdEstado char
	)
AS
BEGIN
INSERT INTO [Sch_Administrativo].[T_Planillas]
(
		[IdPlanilla],
		[IdEmpleado],
		[IdHorario],
		[IdEstado]
)
VALUES
(
	@IdPlanilla,
	@IdEmpleado,
	@IdHorario,
	@IdEstado
	)
END
GO

Create Procedure dbo.SP_INSERTAR_POLIZAS
(
	@IdPoliza varchar(20),
	@IdTipoPoliza char(1),
	@FechaVencimiento date,
	@IdEstado char,
	@CedulaJuridica int
)
AS
BEGIN
INSERT INTO[Sch_Administrativo].[T_Polizas]
(
		[IdPoliza],
		[IdTipoPoliza],
		[FechaVencimiento],
		[IdEstado],
		[CedulaJuridica]
)
VALUES
(
	@IdPoliza,
	@IdTipoPoliza,
	@FechaVencimiento,
	@IdEstado,
	@CedulaJuridica
)
END
GO

--MODIFICAR--
Create Procedure dbo.SP_MODIFICAR_ARTICULOS
(
	@IdArticulo varchar(25),
	@NombreArticulo varchar(50),
	@Cantidad smallint,
	@IdFamilia varchar(4),
	@IdTipoArticulo char(1),
	@InventarioMinimo smallint,
	@PrecioVenta money,
	@IdEstado char
)
AS
BEGIN
UPDATE[Sch_Administrativo].[T_Articulos]
SET		
		[NombreArticulo] = @NombreArticulo,
		[Cantidad] = @Cantidad,
		[IdFamilia] = @IdFamilia,
		[IdTipoArticulo] = @IdTipoArticulo,
		[InventarioMinimo] = @InventarioMinimo,
		[PrecioVenta] = @PrecioVenta,
		[IdEstado] = @IdEstado
WHERE [IdArticulo] = @IdArticulo
END
GO

Create Procedure dbo.SP_MODIFICAR_CLIENTES
(
	@NumPlaca varchar(10),
	@IdTipoPlaca tinyint,
	@IdTipoVehiculo tinyint	
)
AS
BEGIN
UPDATE [Sch_Administrativo].[T_Clientes]
SET
	[IdTipoPlaca] = @IdTipoPlaca,
	[IdTipoVehiculo] = @IdTipoVehiculo
WHERE [NumPlaca] = @NumPlaca
END
GO

Create Procedure dbo.SP_MODIFICAR_EMPLEADOS
(	@IdEmpleado tinyint,
	@Identificacion varchar(50),
	@Nombre varchar(45),
	@Apellidos varchar(120),
	@Telefono int,
	@Direccion varchar(50),
	@Email varchar(30),
	@Puesto varchar(15),
	@IdEstado char,
	@IdPoliza varchar(20),
	@IdUsuario varchar(20)
	)
AS
BEGIN
UPDATE[Sch_Administrativo].[T_Empleados]
SET
		[Identificacion]= @Identificacion,
		[Nombre] = @Nombre,
		[Apellidos]= @Apellidos,
		[Telefono] = @Telefono,
		[Direccion] = @Direccion,
		[Email] = @Email,
		[Puesto] = @Email,
		[IdEstado]= @IdEstado,
		[IdPoliza] = @IdPoliza,
		[IdUsuario] = @IdUsuario
WHERE [IdEmpleado] = @IdEmpleado
END
GO

Create Procedure dbo.SP_MODIFICAR_FAMILIA_ARTICULOS
(
	@IdFamilia varchar(4),
	@Descripcion varchar(20),
	@IdEstado char
)
AS
BEGIN
UPDATE[Sch_Administrativo].[T_FamiliaArticulos]
SET
		[Descripcion] = @Descripcion,
		[IdEstado] = @IdEstado
WHERE [IdFamilia] = @IdFamilia
END
GO
		
Create Procedure dbo.SP_MODIFICAR_HORARIOS
(
	@IdHorario tinyint,
	@Descripcion varchar(20),
	@CantHoras float,
	@Entrada datetime,
	@Salida datetime,
	@IdEstado char
)
AS
BEGIN
UPDATE [Sch_Administrativo].[T_Horarios]
SET
		[Descripcion] = @Descripcion,
		[CantHoras] = @CantHoras,
		[Entrada] = @Entrada,
		[Salida] = @Salida,
		[IdEstado] = @IdEstado
WHERE [IdHorario]= @IdHorario
END
GO

Create Procedure dbo.SP_MODIFICAR_ORDENES_COMPRA
(
	@IdNumOrden int,
	@IdProveedor tinyint,
	@IdArticulo varchar(25),
	@Cantidad smallint,
	@Precio money,
	@IdEstado char
)
AS
BEGIN 
UPDATE [Sch_Administrativo].[T_OrdenesCompra]
SET
		[IdProveedor] = @IdProveedor,
		[IdArticulo]=@IdArticulo,
		[Cantidad] = @Cantidad,
		[Precio] = @Precio,
		[IdEstado] = @IdEstado
WHERE  [IdNumOrden] = @IdNumOrden
END
GO
		
Create Procedure dbo.SP_MODIFICAR_PLANILLAS
(
	@IdPlanilla int,
	@IdEmpleado tinyint,
	@IdHorario tinyint,
	@IdEstado char
	)
AS
BEGIN
UPDATE [Sch_Administrativo].[T_Planillas]
SET
		[IdEmpleado] = @IdEmpleado,
		[IdHorario] = @IdHorario,
		[IdEstado] = @IdEstado
WHERE [IdPlanilla] = @IdPlanilla
END
GO

Create Procedure dbo.SP_MODIFICAR_POLIZAS
(
	@IdPoliza varchar(20),
	@IdTipoPoliza char(1),
	@FechaVencimiento date,
	@IdEstado char,
	@CedulaJuridica int
)
AS
BEGIN
UPDATE[Sch_Administrativo].[T_Polizas]
SET
		[IdTipoPoliza] = @IdTipoPoliza,
		[FechaVencimiento]= @FechaVencimiento,
		[IdEstado]=@IdEstado,
		[CedulaJuridica] = @CedulaJuridica
WHERE [IdPoliza] = @IdPoliza
END 
GO

--FILTRAR--
Create Procedure dbo.SP_FILTRAR_ARTICULOS
(
	@NombreArticulo varchar(50)
)
AS
BEGIN

SELECT
	A.IdArticulo as Articulo,
	A.NombreArticulo as Nombre_Articulo,
	A.Cantidad as Cantidad,
	FA.Descripcion as Familia_Articulo,
	TA.Descripcion as Tipo_Articulo,
	A.InventarioMinimo as Inventario,
	A.PrecioVenta as Precio_venta,
	E.Nombre as  Estado

FROM [Sch_Administrativo].[T_Articulos] A
INNER JOIN [Sch_Administrativo].[T_FamiliaArticulos] FA
ON A.IdFamilia = FA.IdFamilia
INNER JOIN [Sch_Administrativo].[T_TipoArticulo] TA
ON A.IdTipoArticulo = TA.IdTipoArticulo
INNER JOIN [Sch_General].[T_Estados] E
ON A.IdEstado = E.IdEstado

WHERE A.NombreArticulo LIKE '%'+@NombreArticulo +'%'
END
GO


Create Procedure dbo.SP_FILTRAR_CLIENTES
(
	@NumPlaca varchar(10)
)
AS 
BEGIN
SELECT
	C.NumPlaca as Placa,
	TP.Descripcion as Tipo_Placa,
	TV.Descripcion as Tipo_Vehiculo,
	C.NumVisitas as Visitas

FROM[Sch_Administrativo].[T_Clientes] C
INNER JOIN [Sch_General].[T_TipoPlaca] TP
ON C.IdTipoPlaca = TP.IdTipoPlaca
INNER JOIN [Sch_General].[T_TipoVehiculo] TV
ON C.IdTipoVehiculo = TV.IdTipoVehiculo

WHERE C.NumPlaca LIKE '%'+ @NumPlaca + '%'
END
GO


Create Procedure dbo.SP_FILTRAR_EMPLEADOS
(
	@Identificacion varchar(50)
)
AS
BEGIN
SELECT
	Em.IdEmpleado as Numero_Empleado,
	Em.Identificacion as identificacion,
	Em.Nombre as Nombre,
	Em.Apellidos as Apellidos,
	Em.Telefono as Telefono,
	Em.Direccion as Direccion,
	Em.Email as Email,
	Em.Puesto as Puesto,
	E.Nombre as  Estado,
	Em.IdUsuario as Usuario

FROM [Sch_Administrativo].[T_Empleados] Em
INNER JOIN [Sch_General].[T_Estados] E
ON Em.IdEstado = E.IdEstado

WHERE Em.Identificacion LIKE '%' + @Identificacion + '%'
END
GO

Create Procedure dbo.SP_FILTRAR_FAMILIA_ARTICULOS
(
	@Descripcion varchar(20)
)
AS
BEGIN
SELECT
	FA.IdFamilia as Familia_Articulo,
	FA.Descripcion as Descripcion,
	E.Nombre as  Estado

FROM [Sch_Administrativo].[T_FamiliaArticulos] FA
INNER JOIN [Sch_General].[T_Estados] E
ON FA.IdEstado = E.IdEstado

WHERE FA.Descripcion LIKE '%'+ @Descripcion +'%'
END
GO

Create Procedure dbo.SP_FILTRAR_HORARIOS
(
	@Descripcion varchar(20)
)
AS
BEGIN
SELECT
	H.IdHorario as Horario,
	H.Descripcion as Descripcion,
	H.CantHoras as Cantidad_Horas,
	H.Entrada as Entrada,
	H.Salida as Salida,
	E.Nombre as  Estado

FROM [Sch_Administrativo].[T_Horarios] H
INNER JOIN [Sch_General].[T_Estados] E
ON H.IdEstado = E.IdEstado
WHERE H.Descripcion LIKE '%' + @Descripcion +'%'
END
GO

Create Procedure dbo.SP_FILTRAR_ORDENES_COMPRA
(
	@IdNumOrden int
)
AS
BEGIN
SELECT
	OC.IdNumOrden as Numero_Orden,
	P.NombreProveedor as Proveedor,
	A.NombreArticulo as Articulo,
	OC.Cantidad as Cantidad,
	OC.Precio as Precio,
	E.Nombre as  Estado

FROM[Sch_Administrativo].[T_OrdenesCompra] OC
INNER JOIN [Sch_Administrativo].[T_Proveedores] P
ON OC.IdProveedor = P.IdProveedor
INNER JOIN [Sch_Administrativo].[T_Articulos] A
ON OC.IdArticulo = A.IdArticulo
INNER JOIN [Sch_General].[T_Estados] E
ON OC.IdEstado = E.IdEstado

WHERE OC.IdNumOrden LIKE '%' + @IdNumOrden + '%'
END
GO

Create Procedure dbo.SP_FILTRAR_PLANILLAS
(
	@IdPlanilla int
)
AS
BEGIN
SELECT
	P.IdPlanilla as Planilla,
	E.Nombre + E.Apellidos as  Empleado,
	H.Descripcion as Horario,
	Es.Nombre as  Estado

FROM[Sch_Administrativo].[T_Planillas] P
INNER JOIN [Sch_Administrativo].[T_Empleados] E
ON P.IdEmpleado = E.IdEmpleado
INNER JOIN [Sch_Administrativo].[T_Horarios] H
ON P.IdHorario = H.IdHorario
INNER JOIN [Sch_General].[T_Estados] Es
ON P.IdEstado = Es.IdEstado

WHERE P.IdPlanilla LIKE '%' + @IdPlanilla+ '%'
END
GO

Create Procedure dbo.SP_FILTRAR_POLIZAS
(
	@IdPoliza varchar(20)
)
AS
BEGIN
SELECT
	P.IdPoliza as Poliza,
	TP.NombrePoliza as Tipo_Poliza,
	P.FechaVencimiento as Fecha_vencimiento,
	E.Nombre as  Estado,
	P.CedulaJuridica as Cedula_Jurica

FROM[Sch_Administrativo].[T_Polizas] P
INNER JOIN [Sch_Administrativo].[T_Tipo_Polizas] TP
ON P.IdTipoPoliza = TP.IdTipoPoliza
INNER JOIN [Sch_General].[T_Estados] E
ON P.IdEstado = E.IdEstado

WHERE P.IdPoliza LIKE '%'+@IdPoliza+'%'
END
GO


---------------------------------PABLO
--SP_LISTAR CITA
CREATE PROCEDURE dbo.SP_LISTAR_CITAS
AS
BEGIN
SELECT Ci.[NumeroCita] as Numero_Cita,
      Ci.[Nombre] as Nombre_Cliente,
	  Ci.[Telefono] as Telefono_Cliente,
	  Ci.[NumPlaca] as Placa,
	  TS.[NombreServicio] as Cod_Servicio,
	  Ci.[Email] as Email_Cliente,
	  Ci.[FechaCita] as Fecha_Cita,
	  Ci.[HoraCita] as Hora_Cita,
	  E.[Nombre] AS Estado,
	  Em.[Apellidos] as Empleado

  FROM [Sch_General].[T_Citas] Ci
	INNER JOIN [Sch_General].[T_TipoServicio] TS
		ON Ci.CodServicio = TS.CodServicio
	INNER JOIN [Sch_General].[T_Estados] E
		ON Ci.IdEstado = E.IdEstado
	INNER JOIN [Sch_Administrativo].[T_Empleados] Em
		ON Ci.IdEmpleado = Em.IdEmpleado
END
GO
--SP_LISTAR LAVADO_CNETRO DE LAVADO

CREATE PROCEDURE dbo.SP_LISTAR_C_Lavado_Octupus
AS
BEGIN
SELECT [CedulaJuridica] as Cedula_Juridica,
       [NombreComercial] as Nombre_Comercial,
	   [Telefono] as Telefono,
	   [Direccion] as Direccion,
	   [Email] as Email

FROM [Sch_General].[T_Centro_de_lavado_Octopus]
END
GO
--SP_LISTAR ESTADOS


CREATE PROCEDURE dbo.SP_LISTAR_ESTADOS
AS
BEGIN
SELECT [IdEstado] as Estado
      ,[Nombre] as Nombre
  FROM [Sch_General].[T_Estados] 
END
GO

--SP_LISTAR FACTURAS
CREATE PROCEDURE dbo.SP_LISTAR_FACTURAS
AS
BEGIN
SELECT F.NumFactura as Numero_Factura
      ,F.NumPlaca as Placa
	  ,TS.NombreServicio as Cod_Servicio
	  ,TC.Valor as Tipo_Cambio
	  ,F.CedulaJuridica as Cedula_Juridica
	  ,F.MontoNeto as Monto_Neto
	  ,F.Descuento as Descuento
	  ,F.MontoTotal as Monto_Total
	  ,P.Descripcion as Id_Produccion
	  ,TF.TipoFactura as Tipo_Factura

  FROM [Sch_General].[T_Factura] F
	INNER JOIN [Sch_General].[T_TipoServicio] TS
		ON F.CodServicio = TS.CodServicio
	INNER JOIN [Sch_General].[T_TipoCambio] TC
		ON F.IdTipoCambio = TC.IdTipoCambio
	INNER JOIN [Sch_Administrativo].[T_Promociones] P
		ON F.IdPromocion = P.IdPromocion
	INNER JOIN [Sch_Administrativo].[T_TipoFactura] TF
		ON F.IdTipoFactura = TF.IdTipoFactura
END
GO


--SP-LISTAR TIPO DE CAMBIO
CREATE PROCEDURE dbo.SP_LISTAR_TIPO_CAMBIO
AS
BEGIN
SELECT [IdTipoCambio] as Tipo_Cambio
      ,[Valor] as Valor
	  ,[Fecha] as Fecha

  FROM  [Sch_General].[T_TipoCambio]
END
GO

--SP_LISTAR TIPO_PLACA
CREATE PROCEDURE dbo.SP_LISTAR_TIPO_PLACA
AS
BEGIN
SELECT [IdTipoPlaca] as Placa
      ,[Descripcion] as Descripcion

  FROM  [Sch_General].[T_TipoPlaca]
END
GO
--SP LISTAR TIPO VEHICULO
CREATE PROCEDURE dbo.SP_LISTAR_TIPO_VEHICULO
AS
BEGIN
SELECT [IdTipoVehiculo] as Tipo_Vehiculo
      ,[Descripcion] as Descripcion

  FROM  [Sch_General].[T_TipoVehiculo]
END
GO
--SP LISTAR TIPO SERVICIO

CREATE PROCEDURE dbo.SP_LISTAR_TIPO_SERVICIO
AS
BEGIN
SELECT TS.CodServicio as Codigo_Servicio
      ,TS.NombreServicio as Nombre_Servicio
	  ,TS.Precio as Precio
	  ,TS.Duracion as Duracion
	  ,TV.Descripcion as Tipo_Vehiculo

  FROM  [Sch_General].[T_TipoServicio] TS
  INNER JOIN [Sch_General].[T_TipoVehiculo] TV
  ON TS.IdTipoVehiculo = TV.IdTipoVehiculo

END
GO
---------------------------------------------------------------------------
               -------------------INSERTAR----------------
			   
CREATE PROCEDURE dbo.SP_INSERTAR_TIPO_CAMBIO
(
    @IdTipoCambio CHAR,
	@Valor money,
   	@Fecha DATE
 
)
AS
BEGIN
INSERT INTO [Sch_General].[T_TipoCambio]
(
	[IdTipoCambio],
	[Valor],
	[Fecha]
)
VALUES
(
	@IdTipoCambio,
	@Valor,
   	@Fecha
)
END
GO

--
CREATE PROCEDURE dbo.SP_INSERTAR_TIPO_VEHICULO
(
	@IdTipoVehiculo tinyint,
	@Descripcion varchar (25)
)
AS
BEGIN
INSERT INTO [Sch_General].[T_TipoVehiculo]
           ([IdTipoVehiculo]
           ,[Descripcion])
     VALUES
           (@IdTipoVehiculo, @Descripcion)
END
GO


CREATE PROCEDURE dbo.SP_INSERTAR_TIPO_SERVICIO
(
	@CodServicio char,
	@NombreServicio varchar (25),
	@Precio money,
	@Duracion time,
	@IdTipoVehiculo tinyint

)
AS
BEGIN
INSERT INTO [Sch_General].[T_TipoServicio]
           ([CodServicio]
           ,[NombreServicio]
		   ,[Precio]
		   ,[Duracion]
		   ,[IdTipoVehiculo])
     VALUES
           (@CodServicio, @NombreServicio,@Precio
		    ,@Duracion,@IdTipoVehiculo)
END
GO

CREATE PROCEDURE dbo.SP_INSERTAR_TIPO_PLACA
(
	@IdTipoPlaca tinyint,
	@Descripcion varchar (25)
	
)
AS
BEGIN
INSERT INTO [Sch_General].[T_TipoPlaca]
         (
		  [IdTipoPlaca],
		  [Descripcion]
		 )
     VALUES
          (
		    @IdTipoPlaca, @Descripcion
		  )
END
GO


CREATE PROCEDURE dbo.SP_INSERTAR_CITAS
(
	@Nombre varchar (30),
	@Telefono int,
	@NumPlaca varchar (10),
	@CodServicio char,
	@Email varchar (50),
	@FechaCita datetime,
	@HoraCita time,
	@IdEstado char,
	@IdEmpleado tinyint
	
)
AS
BEGIN
INSERT INTO [Sch_General].[T_Citas]
         (
			
	      	[Nombre],
			[Telefono],
			[NumPlaca],
			[CodServicio],
			[Email],
			[FechaCita],
			[HoraCita],
			[IdEstado],
			[IdEmpleado]
		 )
     VALUES
          (
			
		   	@Nombre,
			@Telefono,
			@NumPlaca,
			@CodServicio,
			@Email,
			@FechaCita,
			@HoraCita,
			@IdEstado,
			@IdEmpleado
		  )
SELECT MAX (NumeroCita)
FROM [Sch_General].[T_Citas]
END
GO


CREATE PROCEDURE dbo.SP_INSERTAR_ESTADOS
(
    @IdEstado char,
	@Nombre varchar (25)	
)
AS
BEGIN
INSERT INTO [Sch_General].[T_Estados]
         (
	    	 [IdEstado],
		     [Nombre]
		 )
     VALUES
          (
	
			 @IdEstado,
		     @Nombre
		  )
END
GO


CREATE PROCEDURE dbo.SP_INSERTAR_FACTURA
(
	@NumPlaca varchar (10),
	@CodServicio char,
   	@IdTipoCambio CHAR,
   	@CedulaJuridica int ,
 	@MontoNeto money,
  	@Descuento money ,
  	@MontoTotal money ,
	@IdPromocion char ,
	@IdTipoFactura char
)
AS
BEGIN
INSERT INTO [Sch_General].[T_Factura]
         (
	    		[NumPlaca],
				[CodServicio],
   				[IdTipoCambio],
   			    [CedulaJuridica],
 				[MontoNeto],
  				[Descuento],
  				[MontoTotal],
				[IdPromocion],
				[IdTipoFactura]
		 )
     VALUES
          (
		@NumPlaca ,
		@CodServicio ,
   		@IdTipoCambio,
   		@CedulaJuridica ,
 		@MontoNeto ,
  		@Descuento  ,
  		@MontoTotal ,
		@IdPromocion ,
		@IdTipoFactura)
SELECT MAX ([NumFactura])
FROM  [Sch_General].[T_Factura]
END
GO

-----------------------------------------------------------------
------------------------MODIFICAR--------------------------------

CREATE PROCEDURE dbo.SP_MODIFICAR_FACTURA
(
    @NumPlaca varchar (10),
	@CodServicio char,
   	@IdTipoCambio CHAR,
   	@CedulaJuridica int,
 	@MontoNeto money,
  	@Descuento money ,
  	@MontoTotal money ,
	@IdPromocion char ,
	@IdTipoFactura char
)
AS
BEGIN
UPDATE [Sch_General].[T_Factura]
   SET 
                [NumPlaca] =  @NumPlaca,
				[CodServicio] = @CodServicio ,
   				[IdTipoCambio] = @IdTipoCambio,
   			    [CedulaJuridica] = @CedulaJuridica ,
 				[MontoNeto] = 	@MontoNeto ,
  				[Descuento]=    @Descuento,
  				[MontoTotal]=  @MontoTotal ,
				[IdPromocion]= 	@IdPromocion ,
				[IdTipoFactura]= @IdTipoFactura
 WHERE  [NumPlaca] = @NumPlaca

END
GO

CREATE PROCEDURE dbo.SP_MODIFICAR_TIPO_PLACA
(
    @IdTipoPlaca tinyint,
	@Descripcion varchar (25)
 
)
AS
BEGIN
UPDATE [Sch_General].[T_TipoPlaca]
   SET 
               [IdTipoPlaca] = @IdTipoPlaca,
	            [Descripcion]= @Descripcion 
   			
 WHERE      [IdTipoPlaca] = @IdTipoPlaca

END
GO


CREATE PROCEDURE dbo.SP_MODIFICAR_TIPO_CAMBIO
(
    @IdTipoCambio CHAR,
	@Valor money,
   	@Fecha DATE
 
)
AS
BEGIN
UPDATE [Sch_General].[T_TipoCambio]
   SET 
                [IdTipoCambio] =  @IdTipoCambio,
				[Valor] = @Valor,
   				[Fecha] = 	@Fecha
   			
 WHERE   [IdTipoCambio]=  @IdTipoCambio

END
GO

CREATE PROCEDURE dbo.SP_MODIFICAR_TIPO_SERVICIO
(
   	@CodServicio char,
	@NombreServicio varchar (25),
	@Precio money,
	@Duracion time,
	@IdTipoVehiculo tinyint
 
)
AS
BEGIN
UPDATE [Sch_General].[T_TipoServicio]
   SET 
                    [CodServicio]=@CodServicio,
					[NombreServicio]=@NombreServicio,
					[Precio]=@Precio,
					[Duracion]=@Duracion,
					[IdTipoVehiculo]=@IdTipoVehiculo
   			
 WHERE  [CodServicio]=@CodServicio

END
GO


CREATE PROCEDURE dbo.SP_MODIFICAR_TIPO_VEHICULO
(
    @IdTipoVehiculo tinyint,
	@Descripcion varchar (25)
 
)
AS
BEGIN
UPDATE [Sch_General].[T_TipoVehiculo]
   SET 
               [IdTipoVehiculo] = @IdTipoVehiculo,
	            [Descripcion]= @Descripcion 
   			
 WHERE      [IdTipoVehiculo] = @IdTipoVehiculo

END
GO


CREATE PROCEDURE dbo.SP_MODIFICAR_CITA
(
  
	@Nombre varchar (30),
	@Telefono int,
	@NumPlaca varchar (10),
	@CodServicio char,
	@Email varchar (50),
	@FechaCita datetime,
	@HoraCita time,
	@IdEstado char,
	@IdEmpleado tinyint
)
AS
BEGIN
UPDATE [Sch_General].[T_Citas]
   SET 
	[Nombre]=@Nombre,
	[Telefono]=@Telefono,
	[NumPlaca]=@NumPlaca,
	[CodServicio]=@CodServicio,
	[Email]=@Email,
	[FechaCita]=@FechaCita,
	[HoraCita]=@HoraCita,
	[IdEstado]=@IdEstado
	
 WHERE      [Nombre] =  @Nombre

END
GO


CREATE PROCEDURE dbo.SP_MODIFICAR_ESTADOS
(
    @IdEstado char ,
	@Nombre varchar (25) 
)
AS
BEGIN
UPDATE [Sch_General].[T_Estados]
   SET 
      [IdEstado] =  @IdEstado,
	  [Nombre]=     @Nombre

 WHERE      [IdEstado] =  @IdEstado

END
GO
-----------------------------------------------
--------------------- FILTRAR-----------------------

CREATE PROCEDURE dbo.SP_FILTRAR_ESTADOS
(
	@Nombre varchar (25)
)
AS
BEGIN
SELECT [IdEstado] as Estado
	  ,[Nombre] as Nombre

  FROM [Sch_General].[T_Estados]
  WHERE [Nombre] LIKE '%' + @Nombre + '%'
END
GO


CREATE PROCEDURE dbo.SP_FILTRAR_CITAS
(  
	 @NumeroCita int
)
AS
BEGIN
SELECT Ci.[NumeroCita] as Numero_Cita,
      Ci.[Nombre] as Nombre_Cliente,
	  Ci.[Telefono] as Telefono_Cliente,
	  Ci.[NumPlaca] as Placa,
	  TS.[NombreServicio] as Cod_Servicio,
	  Ci.[Email] as Email_Cliente,
	  Ci.[FechaCita] as Fecha_Cita,
	  Ci.[HoraCita] as Hora_Cita,
	  E.[Nombre] AS Estado,
	  Em.[Apellidos] as Empleado

  FROM [Sch_General].[T_Citas] Ci
	INNER JOIN [Sch_General].[T_TipoServicio] TS
		ON Ci.CodServicio = TS.CodServicio
	INNER JOIN [Sch_General].[T_Estados] E
		ON Ci.IdEstado = E.IdEstado
	INNER JOIN [Sch_Administrativo].[T_Empleados] Em
		ON Ci.IdEmpleado = Em.IdEmpleado
  WHERE Ci.NumeroCita LIKE '%' + @NumeroCita + '%'
END
GO


CREATE PROCEDURE dbo.SP_FILTRAR_FACTURAS
(
      @NumFactura int
)

AS
BEGIN
SELECT F.NumFactura as Numero_Factura
      ,F.NumPlaca as Placa
	  ,TS.NombreServicio as Cod_Servicio
	  ,TC.Valor as Tipo_Cambio
	  ,F.CedulaJuridica as Cedula_Juridica
	  ,F.MontoNeto as Monto_Neto
	  ,F.Descuento as Descuento
	  ,F.MontoTotal as Monto_Total
	  ,P.Descripcion as Id_Produccion
	  ,TF.TipoFactura as Tipo_Factura

  FROM [Sch_General].[T_Factura] F
	INNER JOIN [Sch_General].[T_TipoServicio] TS
		ON F.CodServicio = TS.CodServicio
	INNER JOIN [Sch_General].[T_TipoCambio] TC
		ON F.IdTipoCambio = TC.IdTipoCambio
	INNER JOIN [Sch_Administrativo].[T_Promociones] P
		ON F.IdPromocion = P.IdPromocion
	INNER JOIN [Sch_Administrativo].[T_TipoFactura] TF
		ON F.IdTipoFactura = TF.IdTipoFactura
  WHERE F.NumFactura LIKE '%' + @NumFactura + '%'
END
GO

CREATE PROCEDURE dbo.SP_FILTRAR_TIPO_CAMBIO
(
      @IdTipoCambio char      
)

AS
BEGIN
SELECT [IdTipoCambio]
      ,[Valor]
	  ,[Fecha]

  FROM  [Sch_General].[T_TipoCambio]
  WHERE [IdTipoCambio] LIKE '%' + @IdTipoCambio + '%'
END
GO


CREATE PROCEDURE dbo.SP_FILTRAR_TIPO_PLACA
(
       @IdTipoPlaca tinyint
)
AS
BEGIN
SELECT  [IdTipoPlaca] as Tipo_Placa,
        [Descripcion] as Descripcion

  FROM  [Sch_General].[T_TipoPlaca]
  WHERE [IdTipoPlaca] LIKE '%' + @IdTipoPlaca + '%'
END
GO

CREATE PROCEDURE dbo.SP_FILTRAR_TIPO_VEHICULO
(
      @IdTipoVehiculo tinyint

)AS
BEGIN
SELECT [IdTipoVehiculo] as Tipo_Vehiculo
      ,[Descripcion] as Descripcion

  FROM  [Sch_General].[T_TipoVehiculo]
  WHERE [IdTipoVehiculo] LIKE '%' + IdTipoVehiculo + '%'
END
GO


CREATE PROCEDURE dbo.SP_FILTRAR_TIPO_SERVICIO
(
	   @CodServicio char

)AS
BEGIN
SELECT TS.CodServicio as Codigo_Servicio
      ,TS.NombreServicio as Nombre_Servicio
	  ,TS.Precio as Precio
	  ,TS.Duracion as Duracion
	  ,TV.Descripcion as Tipo_Vehiculo

  FROM  [Sch_General].[T_TipoServicio] TS
  INNER JOIN [Sch_General].[T_TipoVehiculo] TV
  ON TS.IdTipoVehiculo = TV.IdTipoVehiculo

  WHERE TS.CodServicio LIKE '%' + @CodServicio + '%'
END
GO


----------------------------------KEVIN
--[Sch_General].[T_TransaccionesCompra] Procedures

CREATE PROCEDURE dbo.SP_LISTAR_TRANSACCIONES_COMPRA
AS
BEGIN
SELECT	TC.IdTransaccionCompra as Numero_Transaccion ,
		TC.IdNumOrden AS Número_Orden,
		A.NombreArticulo AS Articulo,
		P.NombreProveedor AS Proveedor,
		TC.Documento as Documento,
		TC.Fecha as Fecha,
		TC.Cantidad as Cantidad,
		TC.Monto as Monto

FROM	[Sch_General].[T_TransaccionesCompra] TC
INNER JOIN[Sch_Administrativo].[T_Articulos] A
ON TC.IdArticulo = A.IdArticulo
INNER JOIN[Sch_Administrativo].[T_Proveedores] P
ON TC.IdProveedor = P.IdProveedor
END
GO

CREATE PROCEDURE dbo.SP_INSERTAR_TRANSACCIONES_COMPRA
(	@IdNumOrden int,
	@IdArticulo varchar (25),
	@IdProveedor tinyint,
    @Documento varchar(30),
    @Fecha datetime,
    @Cantidad smallint,
	@Monto money
)
AS
BEGIN
INSERT INTO [Sch_General].[T_TransaccionesCompra] 
	([IdNumOrden],[IdArticulo],[IdProveedor],[Documento],[Fecha],[Cantidad],[Monto])
VALUES(@IdNumOrden,	@IdArticulo,@IdProveedor,@Documento,@Fecha,@Cantidad,@Monto)

SELECT	MAX([IdTransaccionCompra])
FROM	[Sch_General].[T_TransaccionesCompra]
END
GO

CREATE PROCEDURE dbo.SP_FILTRAR_TRANSACCIONES_COMPRA
(
@Orden int
)
AS
BEGIN
SELECT	TC.IdTransaccionCompra as Numero_Transaccion ,
		TC.IdNumOrden AS Número_Orden,
		A.NombreArticulo AS Articulo,
		P.NombreProveedor AS Proveedor,
		TC.Documento as Documento,
		TC.Fecha as Fecha,
		TC.Cantidad as Cantidad,
		TC.Monto as Monto

FROM	[Sch_General].[T_TransaccionesCompra] TC
INNER JOIN[Sch_Administrativo].[T_Articulos] A
ON TC.IdArticulo = A.IdArticulo
INNER JOIN[Sch_Administrativo].[T_Proveedores] P
ON TC.IdProveedor = P.IdProveedor
WHERE	IdNumOrden LIKE '%'+@Orden + '%'
END
GO

CREATE PROCEDURE dbo.SP_MODIFICAR_TRANSACCIONES_COMPRA
(
	@IdTransaccionCompra int,
	@IdNumOrden int,
	@IdArticulo varchar (25),
	@IdProveedor tinyint,
    @Documento varchar(30),
    @Fecha datetime,
    @Cantidad smallint,
	@Monto money
)
AS
BEGIN
UPDATE Sch_General.T_TransaccionesCompra
	SET IdNumOrden = @IdNumOrden,
		IdArticulo = @IdArticulo,
		IdProveedor = @IdProveedor,
		Documento = @Documento,
		Fecha = @Fecha,
		Cantidad = @Cantidad,
		Monto = @Monto
	WHERE	IdTransaccionCompra = @IdTransaccionCompra
END
GO


--[Sch_General].[T_TransaccionesVenta] Procedures
CREATE PROCEDURE dbo.SP_LISTAR_TRANSACCIONES_VENTA
AS
BEGIN
SELECT	TV.IdTransaccionVenta as Numero_Venta,
		A.NombreArticulo as Articulo,
		TV.NumFactura as Factura,
		TV.Fecha as Fecha,
		TV.Cantidad as Cantidad,
		TV.Monto as Monto,
		E.Nombre as Estado
FROM	[Sch_General].[T_TransaccionesVenta] TV
INNER JOIN [Sch_General].[T_Estados] E
ON TV.IdEstado = E.IdEstado
INNER JOIN[Sch_Administrativo].[T_Articulos] A
ON TV.IdArticulo = A.IdArticulo
END
GO

CREATE PROCEDURE dbo.SP_INSERTAR_TRANSACCIONES_VENTA
(
	@IdTransaccionVenta int,
	@IdArticulo varchar(25),
	@NumFactura int,
	@Fecha datetime,
	@Cantidad smallint,
	@Monto money,
	@Estado tinyint
)
AS
BEGIN
INSERT INTO	[Sch_General].[T_TransaccionesVenta] ([IdArticulo],[NumFactura],[Fecha],[Cantidad],[Monto],[IdEstado])
VALUES	(@IdArticulo,@NumFactura,@Fecha,@Cantidad,@Monto,@Estado)

SELECT	MAX([IdTransaccionVenta])
FROM	[Sch_General].[T_TransaccionesVenta]
END
GO

CREATE PROCEDURE dbo.SP_FILTRAR_TRANSACCIONES_VENTA
(
	@NumFactura int
)
AS
BEGIN
SELECT	TV.IdTransaccionVenta as Numero_Venta,
		A.NombreArticulo as Articulo,
		TV.NumFactura as Factura,
		TV.Fecha as Fecha,
		TV.Cantidad as Cantidad,
		TV.Monto as Monto,
		E.Nombre as Estado
FROM	[Sch_General].[T_TransaccionesVenta] TV
INNER JOIN [Sch_General].[T_Estados] E
ON TV.IdEstado = E.IdEstado
INNER JOIN[Sch_Administrativo].[T_Articulos] A
ON TV.IdArticulo = A.IdArticulo
WHERE	[NumFactura] LIKE '%'+@NumFactura+'%'
END
GO

CREATE PROCEDURE dbo.SP_MODICAR_TRANSACCIONES_VENTA
(
	@IdTransaccionVenta int,
	@IdArticulo varchar(25),
	@NumFactura int,
	@Fecha datetime,
	@Cantidad smallint,
	@Monto money,
	@Estado tinyint
)
AS
BEGIN
UPDATE	[Sch_General].[T_TransaccionesVenta]
SET		[IdArticulo] = @IdArticulo,
		[NumFactura] = @NumFactura,
		[Fecha] = @Fecha,
		[Cantidad] = @Cantidad,
		[Monto] = @Monto,
		[IdEstado] = @Estado
WHERE	[IdTransaccionVenta] = @IdTransaccionVenta
END
GO

--[Sch_General].[T_AjustesInventario] Procedures
CREATE PROCEDURE dbo.SP_LISTAR_AJUSTES_INVENTARIO
AS
BEGIN
SELECT	AI.IdTransaccionAjusteInventario as Ajuste_Inventario,
		A.NombreArticulo as Articulo,
		AI.Descripcion as Descripcion,
		AI.Fecha as Fecha,
		AI.Cantidad as Cantidad,
		AI.Monto as Monto

FROM	[Sch_General].[T_AjustesInventario] AI
INNER JOIN [Sch_Administrativo].[T_Articulos] A
ON AI.IdArticulo = A.IdArticulo
END
GO

CREATE PROCEDURE dbo.SP_INSERTAR_AJUSTES_INVENTARIO
(
	@IdArticulo varchar(25),
	@Descripcion varchar(70),
	@Fecha datetime,
	@Cantidad smallint,
	@Monto money
)
AS
BEGIN
INSERT INTO [Sch_General].[T_AjustesInventario] ([IdArticulo],[Descripcion],[Fecha],[Cantidad],[Monto])
VALUES (@IdArticulo,@Descripcion,@Fecha,@Cantidad,@Monto)

SELECT	MAX([IdTransaccionAjusteInventario])
FROM	[Sch_General].[T_AjustesInventario]
END
GO

CREATE PROCEDURE dbo.SP_FILTRAR_AJUSTE_INVENTARIO
(
	@Descripcion varchar(70)	
)
AS
BEGIN
SELECT	AI.IdTransaccionAjusteInventario as Ajuste_Inventario,
		A.NombreArticulo as Articulo,
		AI.Descripcion as Descripcion,
		AI.Fecha as Fecha,
		AI.Cantidad as Cantidad,
		AI.Monto as Monto

FROM	[Sch_General].[T_AjustesInventario] AI
INNER JOIN [Sch_Administrativo].[T_Articulos] A
ON AI.IdArticulo = A.IdArticulo
WHERE	[Descripcion] = @Descripcion
END
GO

CREATE PROCEDURE dbo.SP_MODIFICAR_AJUSTES_INVENTARIO
(
	@IdTransaccionAjusteInventario int,
	@IdArticulo varchar(25),
	@Descripcion varchar(70),
	@Fecha datetime,
	@Cantidad smallint,
	@Monto money
)
AS
BEGIN
UPDATE	[Sch_General].[T_AjustesInventario]
SET		[IdArticulo] = @IdArticulo,
		[Descripcion] = @Descripcion,
		[Fecha] = @Fecha,
		[Cantidad] = @Cantidad,
		[Monto] = @Monto
WHERE	[IdTransaccionAjusteInventario] = @IdTransaccionAjusteInventario
END
GO
--INSERTS
-- ESTADOS
EXEC SP_INSERTAR_ESTADOS 'A', 'Activo'
GO
EXEC SP_INSERTAR_ESTADOS 'B', 'Inactivo'
GO
EXEC SP_INSERTAR_ESTADOS 'C', 'En_Stock'
GO
EXEC SP_INSERTAR_ESTADOS 'D', 'Limite_de_Stock'
GO
EXEC SP_INSERTAR_ESTADOS 'E', 'Finalizado'
GO
EXEC SP_INSERTAR_ESTADOS 'F', 'Pendiente'
GO
EXEC SP_INSERTAR_ESTADOS 'G', 'Agotado'
GO
--ROLES
EXEC SP_INSERTAR_ROLES 1, 1, 'Nivel 1', 'A'
GO
EXEC SP_INSERTAR_ROLES 2, 2, 'Nivel 2', 'A'
GO
EXEC SP_INSERTAR_ROLES 3, 3, 'Nivel 3', 'A'
GO
--TIPO VEHICULO
EXEC SP_INSERTAR_TIPO_VEHICULO 1, 'Automoviles_Pequeños'
GO
EXEC SP_INSERTAR_TIPO_VEHICULO 2, 'Automoviles_Grandes'
GO
EXEC SP_INSERTAR_TIPO_VEHICULO 3, 'Automoviles_Extragrandes'
GO
EXEC SP_INSERTAR_TIPO_VEHICULO 4, 'Motocicletas'
--TIPO SERVICIO
EXEC SP_INSERTAR_TIPO_SERVICIO  'A', 'Bike Wash', 3000, '00:20:00', 4
GO
--VEHICULOS PEQUEÑOS
EXEC SP_INSERTAR_TIPO_SERVICIO  'B', 'Exterior-Pequeño', 4500, '00:20:00', 1
GO
EXEC SP_INSERTAR_TIPO_SERVICIO  'C', 'Completo-Pequeño', 7000, '00:30:00', 1
GO
EXEC SP_INSERTAR_TIPO_SERVICIO  'D', 'Plus-Pequeño', 10000, '00:45:00', 1
GO
EXEC SP_INSERTAR_TIPO_SERVICIO  'E', 'Full-Pequeño', 40000, '03:00:00', 1
GO
EXEC SP_INSERTAR_TIPO_SERVICIO  'F', 'Premium-Pequeño', 55000, '06:00:00', 1
GO
--VEHICULOS GRANDES
EXEC SP_INSERTAR_TIPO_SERVICIO  'G', 'Exterior-Grande', 5500, '00:20:00', 2
GO
EXEC SP_INSERTAR_TIPO_SERVICIO  'H', 'Completo-Grande', 8000, '00:30:00', 2
GO
EXEC SP_INSERTAR_TIPO_SERVICIO  'I', 'Plus-Grande', 12000, '00:45:00', 2
GO
EXEC SP_INSERTAR_TIPO_SERVICIO  'J', 'Full-Grande', 45000, '03:00:00', 2
GO
EXEC SP_INSERTAR_TIPO_SERVICIO  'K', 'Premium-Grande', 65000, '06:00:00', 2
GO
--VEHICULOS GRANDES
EXEC SP_INSERTAR_TIPO_SERVICIO  'L', 'Exterior-ExtraGrande', 6500, '00:20:00', 3
GO
EXEC SP_INSERTAR_TIPO_SERVICIO  'M', 'Completo-ExtraGrande', 9000, '00:30:00', 3
GO
EXEC SP_INSERTAR_TIPO_SERVICIO  'N', 'Plus-ExtraGrande', 14000, '00:45:00', 3
GO
EXEC SP_INSERTAR_TIPO_SERVICIO  'O', 'Full-ExtraGrande', 50000, '03:00:00', 3
GO
EXEC SP_INSERTAR_TIPO_SERVICIO  'P', 'Premium-ExtraGrande', 75000, '06:00:00', 3
GO
--TIPO CAMBIO
EXEC SP_INSERTAR_TIPO_CAMBIO 'A', 610, '4/11/2019'
GO
--USUARIO
EXEC SP_INSERTAR_USUARIOS 'ADMIN','admin', 3, 'A'
GO
EXEC SP_INSERTAR_USUARIOS 'YISUS','diosteama', 3, 'A'
GO
--TIPO PLACA
EXEC SP_INSERTAR_TIPO_PLACA 1,'Motocicleta'
GO
EXEC SP_INSERTAR_TIPO_PLACA 2,'Taxi'
GO
EXEC SP_INSERTAR_TIPO_PLACA 3,'Vehículo Particular'
GO
--PROMOS
EXEC SP_INSERTAR_PROMOCIONES A,'Taxi','40% sobre el monto final de la factura'
GO
EXEC SP_INSERTAR_PROMOCIONES B,'Regalía','Servicio completo gratis luego de la décima visita'
GO 
EXEC SP_INSERTAR_PROMOCIONES C,'Sin Promoción','No tiene promoción'
GO 
--CENTRO DE LAVADO
INSERT INTO [Sch_General].[T_Centro_de_lavado_Octopus] (CedulaJuridica,NombreComercial,Direccion,Telefono,Email)
VALUES(310125947,'Centro de Lavado Octopus', 
'San Pedro de Montes de Oca, Local número 2 de Centro Comercial Plaza San Pedro', 22447777, 'info@octopus.com')
GO
--TIPO FACTURA
EXEC SP_INSERTAR_TIPO_FACTURA 'A', 'Normal', 'Facturación normal'
GO
EXEC SP_INSERTAR_TIPO_FACTURA 'B', 'Regalía', 'Descuento del 100% del valor total del Servicio Completo'
GO
EXEC SP_INSERTAR_TIPO_FACTURA 'C', 'Descuento', 'Facturación con descuento'
GO
EXEC SP_INSERTAR_TIPO_FACTURA 'D', 'Anulación', 'Anulación de la Factura'
GO