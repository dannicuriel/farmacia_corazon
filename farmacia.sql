-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 15-04-2021 a las 15:28:02
-- Versión del servidor: 10.4.11-MariaDB
-- Versión de PHP: 7.4.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `farmacia`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `alergias_paciente`
--

CREATE TABLE `alergias_paciente` (
  `idAlergia` int(6) NOT NULL,
  `A_nomAlergia` varchar(45) DEFAULT NULL,
  `A_IdPaciente` varchar(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `areas_labo`
--

CREATE TABLE `areas_labo` (
  `idLaboArea` int(6) NOT NULL,
  `Lab_nomArea` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `catalergias`
--

CREATE TABLE `catalergias` (
  `Cat_idAlergia` int(6) NOT NULL,
  `Cat_nomAlergia` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_ventas`
--

CREATE TABLE `detalle_ventas` (
  `IdDetalleVenta` int(11) NOT NULL,
  `Venta_fechahora` datetime DEFAULT NULL,
  `codigobarrasProd` int(16) NOT NULL,
  `DetVen_prod` varchar(45) NOT NULL,
  `DetVen_idProducto` int(11) NOT NULL,
  `DetVen_idServicio` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `login`
--

CREATE TABLE `login` (
  `idLogin` int(11) NOT NULL,
  `L_Usuario` varchar(45) NOT NULL,
  `L_Pass` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `login`
--

INSERT INTO `login` (`idLogin`, `L_Usuario`, `L_Pass`) VALUES
(1, 'admin', 'admin'),
(2, 'user', 'user1'),
(3, 'e', 'e');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `monedero`
--

CREATE TABLE `monedero` (
  `idMonedero` int(6) NOT NULL,
  `Mon_puntos` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paciente`
--

CREATE TABLE `paciente` (
  `idPaciente` varchar(13) NOT NULL,
  `Pnom` varchar(45) DEFAULT NULL,
  `P_apPat` varchar(45) NOT NULL,
  `P_apMat` varchar(45) NOT NULL,
  `P_fNac` date NOT NULL,
  `P_telefono` bigint(10) DEFAULT NULL,
  `P_sexo` bit(1) NOT NULL,
  `IdMonedero` int(20) DEFAULT NULL,
  `P_tipoSangre` varchar(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `servicios`
--

CREATE TABLE `servicios` (
  `IdServicio` int(11) NOT NULL,
  `Ser_nombre` varchar(60) NOT NULL,
  `Ser_diagnostico` varchar(60) NOT NULL,
  `Ser_resultado` tinyint(1) DEFAULT NULL,
  `Ser_fecResultado` date DEFAULT NULL,
  `Ser_Fecha` date NOT NULL,
  `Ser_costo` decimal(10,0) NOT NULL,
  `Ser_Precio` decimal(10,0) NOT NULL,
  `Ser_idLAboArea` int(11) DEFAULT NULL,
  `Ser_idPaciente` varchar(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `servicios_labo`
--

CREATE TABLE `servicios_labo` (
  `idServLabo` int(6) NOT NULL,
  `ServL_nom` varchar(45) DEFAULT NULL,
  `ServL_idLaboArea` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

CREATE TABLE `ventas` (
  `IdVenta` int(11) NOT NULL,
  `Venta_fechahora` datetime DEFAULT NULL,
  `Venta_NumArt` varchar(13) NOT NULL,
  `Venta_costo` decimal(10,0) NOT NULL,
  `Venta_idMonedero` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `alergias_paciente`
--
ALTER TABLE `alergias_paciente`
  ADD PRIMARY KEY (`idAlergia`);

--
-- Indices de la tabla `areas_labo`
--
ALTER TABLE `areas_labo`
  ADD PRIMARY KEY (`idLaboArea`);

--
-- Indices de la tabla `catalergias`
--
ALTER TABLE `catalergias`
  ADD PRIMARY KEY (`Cat_idAlergia`);

--
-- Indices de la tabla `detalle_ventas`
--
ALTER TABLE `detalle_ventas`
  ADD PRIMARY KEY (`IdDetalleVenta`);

--
-- Indices de la tabla `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`idLogin`);

--
-- Indices de la tabla `monedero`
--
ALTER TABLE `monedero`
  ADD PRIMARY KEY (`idMonedero`);

--
-- Indices de la tabla `paciente`
--
ALTER TABLE `paciente`
  ADD PRIMARY KEY (`idPaciente`);

--
-- Indices de la tabla `servicios`
--
ALTER TABLE `servicios`
  ADD PRIMARY KEY (`IdServicio`);

--
-- Indices de la tabla `servicios_labo`
--
ALTER TABLE `servicios_labo`
  ADD PRIMARY KEY (`idServLabo`);

--
-- Indices de la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD PRIMARY KEY (`IdVenta`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `detalle_ventas`
--
ALTER TABLE `detalle_ventas`
  MODIFY `IdDetalleVenta` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `servicios`
--
ALTER TABLE `servicios`
  MODIFY `IdServicio` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `ventas`
--
ALTER TABLE `ventas`
  MODIFY `IdVenta` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
