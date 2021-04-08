CREATE TABLE `farmacia`.`monedero` (
  `idMonedero` int(6) NOT NULL,
  `Mon_puntos` VARCHAR(45) NULL,
   PRIMARY KEY (`idMonedero`));
  
  CREATE TABLE `farmacia`.`Servicios_Labo` (
  `idServLabo` int(6) NOT NULL,
  `ServL_nom` VARCHAR(45) NULL,
  `ServL_idLaboArea` VARCHAR(45) NULL,
  PRIMARY KEY (`idServLabo`));
  
  CREATE TABLE `farmacia`.`detalle_ventas` (
  `IdDetalleVenta` INT NOT NULL AUTO_INCREMENT,
  `Venta_fechahora` DATETIME NULL,
  `codigobarrasProd` int(16) NOT NULL,
  `DetVen_prod` varchar(45) NOT NULL,
  `DetVen_idProducto` int(11) NOT NULL,
  `DetVen_idServicio` int(11) NOT NULL,

 
  PRIMARY KEY (`IdDetalleVenta`));
  
  
  