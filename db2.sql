-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           8.0.31 - MySQL Community Server - GPL
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para corretorainvestimentos2
DROP DATABASE IF EXISTS `corretorainvestimentos2`;
CREATE DATABASE IF NOT EXISTS `corretorainvestimentos2` /*!40100 DEFAULT CHARACTER SET utf8mb3 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `corretorainvestimentos2`;

-- Copiando estrutura para procedure corretorainvestimentos2.alteraCategoria
DROP PROCEDURE IF EXISTS `alteraCategoria`;
DELIMITER //
CREATE PROCEDURE `alteraCategoria`(
	idCATEGORIA int, 
	nome varchar(100),
	imposto tinyint(1),
	fgc tinyint(1)
)
BEGIN
	UPDATE `corretorainvestimentos2`.`categoria`
	SET
	categoria.`nome` = nome,
	categoria.`imposto` = imposto,
	categoria.`fgc` = fgc
	WHERE categoria.`idCATEGORIA` = idCATEGORIA;
END//
DELIMITER ;

-- Copiando estrutura para procedure corretorainvestimentos2.alteraEmissor
DROP PROCEDURE IF EXISTS `alteraEmissor`;
DELIMITER //
CREATE PROCEDURE `alteraEmissor`(
	idEMISSOR int,
	nome varchar(250),
	rating varchar(10),
	cnpj varchar(30)
)
BEGIN
	UPDATE `corretorainvestimentos2`.`emissor`
	SET
	emissor.`nome` = nome,
	emissor.`rating` = rating,
	emissor.`cnpj` = cnpj
	WHERE emissor.`idEMISSOR` = idEMISSOR;

END//
DELIMITER ;

-- Copiando estrutura para procedure corretorainvestimentos2.alteraInvestidor
DROP PROCEDURE IF EXISTS `alteraInvestidor`;
DELIMITER //
CREATE PROCEDURE `alteraInvestidor`(
	idINVESTIDOR int,
	nome varchar(250),
	cpf varchar(20),
	saldoEmConta decimal(10,5),
	email varchar(250),
	senha varchar(70)
)
BEGIN
	UPDATE `corretorainvestimentos2`.`investidor`
	SET
	investidor.`idINVESTIDOR` = idINVESTIDOR,
	investidor.`nome` = nome,
	investidor.`cpf` = cpf,
	investidor.`saldoEmConta` = saldoEmConta,
	investidor.`email` = email,
	investidor.`senha` = senha
	WHERE investidor.`idINVESTIDOR` = idINVESTIDOR;

END//
DELIMITER ;

-- Copiando estrutura para procedure corretorainvestimentos2.alteraInvestimento
DROP PROCEDURE IF EXISTS `alteraInvestimento`;
DELIMITER //
CREATE PROCEDURE `alteraInvestimento`(
	idINVESTIMENTO int,
	dataDeInvestimento date,
	quantidade int,
	INVESTIDOR_idINVESTIDOR int,
	OFERTA_idOFERTA int
)
BEGIN
	UPDATE `corretorainvestimentos2`.`investimento`
	SET
	investimento.`dataDeInvestimento` = dataDeInvestimento,
	investimento.`quantidade` = quantidade,
	investimento.`INVESTIDOR_idINVESTIDOR` = INVESTIDOR_idINVESTIDOR,
	investimento.`OFERTA_idOFERTA` = OFERTA_idOFERTA
	WHERE investimento.`idINVESTIMENTO` = idINVESTIMENTO;

END//
DELIMITER ;

-- Copiando estrutura para procedure corretorainvestimentos2.alteraOferta
DROP PROCEDURE IF EXISTS `alteraOferta`;
DELIMITER //
CREATE PROCEDURE `alteraOferta`(
	idOFERTA int,
	valida tinyint(1),
	liquidez int,
	aplicacaoMinima decimal(10,5),
	quantidadeDisponivel int,
	rentabilidade varchar(100),
	CATEGORIA_idCATEGORIA int,
	EMISSOR_idEMISSOR int
)
BEGIN
	UPDATE `corretorainvestimentos2`.`oferta`
	SET
	`valida` = valida,
	`liquidez` = liquidez,
	`aplicacaoMinima` = aplicacaoMinima,
	`quantidadeDisponivel` = quantidadeDisponivel,
	`rentabilidade` = rentabilidade,
	`CATEGORIA_idCATEGORIA` = CATEGORIA_idCATEGORIA,
	`EMISSOR_idEMISSOR` = EMISSOR_idEMISSOR
	WHERE `idOFERTA` = idOFERTA;

END//
DELIMITER ;

-- Copiando estrutura para procedure corretorainvestimentos2.apagaCategoria
DROP PROCEDURE IF EXISTS `apagaCategoria`;
DELIMITER //
CREATE PROCEDURE `apagaCategoria`(
idCATEGORIA int
)
BEGIN
	DELETE FROM `corretorainvestimentos2`.`categoria`
	WHERE categoria.`idCATEGORIA` = idCATEGORIA;

END//
DELIMITER ;

-- Copiando estrutura para procedure corretorainvestimentos2.apagaEmissor
DROP PROCEDURE IF EXISTS `apagaEmissor`;
DELIMITER //
CREATE PROCEDURE `apagaEmissor`(
	idEMISSOR int
)
BEGIN
	DELETE FROM `corretorainvestimentos2`.`emissor`
	WHERE emissor.idEMISSOR = idEMISSOR;

END//
DELIMITER ;

-- Copiando estrutura para procedure corretorainvestimentos2.apagaInvestidor
DROP PROCEDURE IF EXISTS `apagaInvestidor`;
DELIMITER //
CREATE PROCEDURE `apagaInvestidor`(
idINVESTIDOR int
)
BEGIN
	DELETE FROM `corretorainvestimentos2`.`investidor`
	WHERE investidor.idINVESTIDOR = idINVESTIDOR;

END//
DELIMITER ;

-- Copiando estrutura para procedure corretorainvestimentos2.apagaInvestimento
DROP PROCEDURE IF EXISTS `apagaInvestimento`;
DELIMITER //
CREATE PROCEDURE `apagaInvestimento`(
idINVESTIMENTO int
)
BEGIN
	DELETE FROM `corretorainvestimentos2`.`investimento`
	WHERE investimento.idINVESTIMENTO = idINVESTIMENTO;

END//
DELIMITER ;

-- Copiando estrutura para procedure corretorainvestimentos2.apagaOferta
DROP PROCEDURE IF EXISTS `apagaOferta`;
DELIMITER //
CREATE PROCEDURE `apagaOferta`(
	idOFERTA int
)
BEGIN
	DELETE FROM `corretorainvestimentos2`.`oferta`
	WHERE oferta.idOFERTA = idOFERTA;

END//
DELIMITER ;

-- Copiando estrutura para tabela corretorainvestimentos2.categoria
DROP TABLE IF EXISTS `categoria`;
CREATE TABLE IF NOT EXISTS `categoria` (
  `idCATEGORIA` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `imposto` tinyint(1) NOT NULL,
  `fgc` tinyint(1) NOT NULL,
  PRIMARY KEY (`idCATEGORIA`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela corretorainvestimentos2.emissor
DROP TABLE IF EXISTS `emissor`;
CREATE TABLE IF NOT EXISTS `emissor` (
  `idEMISSOR` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(250) NOT NULL,
  `rating` varchar(10) NOT NULL,
  `cnpj` varchar(30) NOT NULL,
  PRIMARY KEY (`idEMISSOR`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para procedure corretorainvestimentos2.insereCategoria
DROP PROCEDURE IF EXISTS `insereCategoria`;
DELIMITER //
CREATE PROCEDURE `insereCategoria`(
	nome varchar(100),
	imposto tinyint(1),
	fgc tinyint(1)

)
BEGIN
	INSERT INTO `corretorainvestimentos2`.`categoria`
	(categoria.`idCATEGORIA`,
	categoria.`nome`,
	categoria.`imposto`,
	categoria.`fgc`)
	VALUES
	(NULL,
	nome,
	imposto,
	fgc);

END//
DELIMITER ;

-- Copiando estrutura para procedure corretorainvestimentos2.insereEmissor
DROP PROCEDURE IF EXISTS `insereEmissor`;
DELIMITER //
CREATE PROCEDURE `insereEmissor`(
	nome varchar(250),
	rating varchar(10),
	cnpj varchar(30)
)
BEGIN
	INSERT INTO `corretorainvestimentos2`.`emissor`
	(emissor.`idEMISSOR`,
	emissor.`nome`,
	emissor.`rating`,
	emissor.`cnpj`)
	VALUES
	(NULL,
	nome,
	rating,
	cnpj);

END//
DELIMITER ;

-- Copiando estrutura para procedure corretorainvestimentos2.insereInvestidor
DROP PROCEDURE IF EXISTS `insereInvestidor`;
DELIMITER //
CREATE PROCEDURE `insereInvestidor`(
	nome varchar(250),
	cpf varchar(20),
	saldoEmConta decimal(10,5),
	email varchar(250) ,
	senha varchar(70)
)
BEGIN
	 INSERT INTO `corretorainvestimentos2`.`investidor`
	(investidor.`idINVESTIDOR`, investidor.`nome`,
	investidor.`cpf`, investidor.`saldoEmConta`,
	investidor.`email`, investidor.`senha`)
	VALUES
	(NULL,
	nome,
	cpf,
	saldoEmConta,
	email,
	senha);

END//
DELIMITER ;

-- Copiando estrutura para procedure corretorainvestimentos2.insereInvestimento
DROP PROCEDURE IF EXISTS `insereInvestimento`;
DELIMITER //
CREATE PROCEDURE `insereInvestimento`(
	dataDeInvestimento date,
	quantidade int,
	INVESTIDOR_idINVESTIDOR int,
	OFERTA_idOFERTA int
)
BEGIN
	INSERT INTO `corretorainvestimentos2`.`investimento`
	(investimento.`idINVESTIMENTO`,
	investimento.`dataDeInvestimento`,
	investimento.`quantidade`,
	investimento.`INVESTIDOR_idINVESTIDOR`,
	investimento.`OFERTA_idOFERTA`)
	VALUES
	(NULL,
	dataDeInvestimento,
	quantidade,
	INVESTIDOR_idINVESTIDOR,
	OFERTA_idOFERTA);

END//
DELIMITER ;

-- Copiando estrutura para procedure corretorainvestimentos2.insereOferta
DROP PROCEDURE IF EXISTS `insereOferta`;
DELIMITER //
CREATE PROCEDURE `insereOferta`(
	valida tinyint(1),
	liquidez int,
	aplicacaoMinima decimal(10,5),
	quantidadeDisponivel int,
	rentabilidade varchar(100),
	CATEGORIA_idCATEGORIA int,
	EMISSOR_idEMISSOR int
)
BEGIN

	INSERT INTO `corretorainvestimentos2`.`oferta`
	(`idOFERTA`,
	oferta.`valida`,
	oferta.`liquidez`,
	oferta.`aplicacaoMinima`,
	oferta.`quantidadeDisponivel`,
	oferta.`rentabilidade`,
	oferta.`CATEGORIA_idCATEGORIA`,
	oferta.`EMISSOR_idEMISSOR`)
	VALUES
	(NULL,
	valida,
	liquidez,
	aplicacaoMinima,
	quantidadeDisponivel,
	rentabilidade,
	CATEGORIA_idCATEGORIA,
	EMISSOR_idEMISSOR);
END//
DELIMITER ;

-- Copiando estrutura para tabela corretorainvestimentos2.investidor
DROP TABLE IF EXISTS `investidor`;
CREATE TABLE IF NOT EXISTS `investidor` (
  `idINVESTIDOR` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(250) NOT NULL,
  `cpf` varchar(20) NOT NULL,
  `saldoEmConta` decimal(10,5) NOT NULL,
  `email` varchar(250) NOT NULL,
  `senha` varchar(70) NOT NULL,
  PRIMARY KEY (`idINVESTIDOR`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela corretorainvestimentos2.investimento
DROP TABLE IF EXISTS `investimento`;
CREATE TABLE IF NOT EXISTS `investimento` (
  `idINVESTIMENTO` int NOT NULL AUTO_INCREMENT,
  `dataDeInvestimento` date NOT NULL,
  `quantidade` int NOT NULL,
  `INVESTIDOR_idINVESTIDOR` int NOT NULL,
  `OFERTA_idOFERTA` int NOT NULL,
  PRIMARY KEY (`idINVESTIMENTO`,`INVESTIDOR_idINVESTIDOR`,`OFERTA_idOFERTA`),
  KEY `fk_INVESTIMENTOS_INVESTIDOR_idx` (`INVESTIDOR_idINVESTIDOR`),
  KEY `fk_INVESTIMENTO_OFERTA1_idx` (`OFERTA_idOFERTA`),
  CONSTRAINT `fk_INVESTIMENTO_OFERTA1` FOREIGN KEY (`OFERTA_idOFERTA`) REFERENCES `oferta` (`idOFERTA`),
  CONSTRAINT `fk_INVESTIMENTOS_INVESTIDOR` FOREIGN KEY (`INVESTIDOR_idINVESTIDOR`) REFERENCES `investidor` (`idINVESTIDOR`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela corretorainvestimentos2.oferta
DROP TABLE IF EXISTS `oferta`;
CREATE TABLE IF NOT EXISTS `oferta` (
  `idOFERTA` int NOT NULL AUTO_INCREMENT,
  `valida` tinyint(1) NOT NULL,
  `liquidez` int NOT NULL,
  `aplicacaoMinima` decimal(10,5) NOT NULL,
  `quantidadeDisponivel` int NOT NULL,
  `rentabilidade` varchar(100) NOT NULL,
  `CATEGORIA_idCATEGORIA` int NOT NULL,
  `EMISSOR_idEMISSOR` int NOT NULL,
  PRIMARY KEY (`idOFERTA`,`CATEGORIA_idCATEGORIA`,`EMISSOR_idEMISSOR`),
  KEY `fk_OFERTAS_CATEGORIA1_idx` (`CATEGORIA_idCATEGORIA`),
  KEY `fk_OFERTAS_EMISSOR1_idx` (`EMISSOR_idEMISSOR`),
  CONSTRAINT `fk_OFERTAS_CATEGORIA1` FOREIGN KEY (`CATEGORIA_idCATEGORIA`) REFERENCES `categoria` (`idCATEGORIA`),
  CONSTRAINT `fk_OFERTAS_EMISSOR1` FOREIGN KEY (`EMISSOR_idEMISSOR`) REFERENCES `emissor` (`idEMISSOR`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para procedure corretorainvestimentos2.projecaoInvestidor
DROP PROCEDURE IF EXISTS `projecaoInvestidor`;
DELIMITER //
CREATE PROCEDURE `projecaoInvestidor`()
BEGIN
	SELECT
	nome AS "Nome",
	saldoEmConta AS "Saldo em Conta"
	FROM investidor
	WHERE saldoEmConta > 1000;
END//
DELIMITER ;

-- Copiando estrutura para procedure corretorainvestimentos2.selecaoOferta
DROP PROCEDURE IF EXISTS `selecaoOferta`;
DELIMITER //
CREATE PROCEDURE `selecaoOferta`()
BEGIN
	SELECT
	CASE WHEN oferta.valida = 0 THEN "Inativa"
	ELSE "Ativa"
	END AS "Situação",
	oferta.liquidez AS "Liquidez",
	oferta.aplicacaoMinima AS "Aplicação Minima", oferta.quantidadeDisponivel AS "Quantidade Disponível", oferta.rentabilidade AS "Rentabilidade",
	categoria.nome AS "Categoria",
	emissor.nome AS "Emissor"

	FROM oferta

	INNER JOIN categoria
	ON oferta.CATEGORIA_idCATEGORIA = categoria.idCATEGORIA
	INNER JOIN emissor

	ON oferta. EMISSOR_idEMISSOR
	=
	emissor.idEMISSOR;

END//
DELIMITER ;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
