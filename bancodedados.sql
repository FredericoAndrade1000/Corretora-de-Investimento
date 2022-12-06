-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.4.27-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              12.2.0.6576
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para corretorainvestimentos
DROP DATABASE IF EXISTS `corretorainvestimentos`;
CREATE DATABASE IF NOT EXISTS `corretorainvestimentos` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci */;
USE `corretorainvestimentos`;

-- Copiando estrutura para tabela corretorainvestimentos.administrador
DROP TABLE IF EXISTS `administrador`;
CREATE TABLE IF NOT EXISTS `administrador` (
  `idADMINISTRADOR` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(250) NOT NULL,
  `senha` varchar(100) NOT NULL,
  PRIMARY KEY (`idADMINISTRADOR`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para procedure corretorainvestimentos.alteraAdministrador
DROP PROCEDURE IF EXISTS `alteraAdministrador`;
DELIMITER //
CREATE PROCEDURE `alteraAdministrador`(
	idADMINISTRADOR int,
	nome varchar(250),
	senha varchar(100)
)
BEGIN
	UPDATE `corretorainvestimentos`.`administrador`
	SET
	administrador.`nome` = nome,
	administrador.`senha` = senha
	WHERE administrador.`idADMINISTRADOR` = idADMINISTRADOR;

END//
DELIMITER ;

-- Copiando estrutura para procedure corretorainvestimentos.alteraCategoria
DROP PROCEDURE IF EXISTS `alteraCategoria`;
DELIMITER //
CREATE PROCEDURE `alteraCategoria`(
	idCATEGORIA int, 
	nome varchar(100),
	imposto tinyint(1),
	fgc tinyint(1)
)
BEGIN
	UPDATE `corretorainvestimentos`.`categoria`
	SET
	categoria.`nome` = nome,
	categoria.`imposto` = imposto,
	categoria.`fgc` = fgc
	WHERE categoria.`idCATEGORIA` = idCATEGORIA;
END//
DELIMITER ;

-- Copiando estrutura para procedure corretorainvestimentos.alteraEmissor
DROP PROCEDURE IF EXISTS `alteraEmissor`;
DELIMITER //
CREATE PROCEDURE `alteraEmissor`(
	idEMISSOR int,
	nome varchar(250),
	rating varchar(10),
	cnpj varchar(30)
)
BEGIN
	UPDATE `corretorainvestimentos`.`emissor`
	SET
	emissor.`nome` = nome,
	emissor.`rating` = rating,
	emissor.`cnpj` = cnpj
	WHERE emissor.`idEMISSOR` = idEMISSOR;

END//
DELIMITER ;

-- Copiando estrutura para procedure corretorainvestimentos.alteraInvestidor
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
	UPDATE `corretorainvestimentos`.`investidor`
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

-- Copiando estrutura para procedure corretorainvestimentos.alteraInvestimento
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
	UPDATE `corretorainvestimentos`.`investimento`
	SET
	investimento.`dataDeInvestimento` = dataDeInvestimento,
	investimento.`quantidade` = quantidade,
	investimento.`INVESTIDOR_idINVESTIDOR` = INVESTIDOR_idINVESTIDOR,
	investimento.`OFERTA_idOFERTA` = OFERTA_idOFERTA
	WHERE investimento.`idINVESTIMENTO` = idINVESTIMENTO;

END//
DELIMITER ;

-- Copiando estrutura para procedure corretorainvestimentos.alteraOferta
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
	UPDATE `corretorainvestimentos`.`oferta`
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

-- Copiando estrutura para procedure corretorainvestimentos.apaga
DROP PROCEDURE IF EXISTS `apaga`;
DELIMITER //
CREATE PROCEDURE `apaga`(in nome varchar(50), in chave int)
BEGIN
set @qry:= concat('DELETE FROM ',nome, " WHERE id", UPPER(nome), "=", chave);
prepare stmt from @qry;
execute stmt;


END//
DELIMITER ;

-- Copiando estrutura para tabela corretorainvestimentos.categoria
DROP TABLE IF EXISTS `categoria`;
CREATE TABLE IF NOT EXISTS `categoria` (
  `idCATEGORIA` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `imposto` tinyint(1) NOT NULL,
  `fgc` tinyint(1) NOT NULL,
  PRIMARY KEY (`idCATEGORIA`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela corretorainvestimentos.emissor
DROP TABLE IF EXISTS `emissor`;
CREATE TABLE IF NOT EXISTS `emissor` (
  `idEMISSOR` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(250) NOT NULL,
  `rating` varchar(10) NOT NULL,
  `cnpj` varchar(30) NOT NULL,
  PRIMARY KEY (`idEMISSOR`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para procedure corretorainvestimentos.insereAdministrador
DROP PROCEDURE IF EXISTS `insereAdministrador`;
DELIMITER //
CREATE PROCEDURE `insereAdministrador`(
	nome varchar(250),
	senha varchar(100)
)
BEGIN
	INSERT INTO `corretorainvestimentos`.`administrador`
	(`corretorainvestimentos`.`administrador`.`nome`,
	`corretorainvestimentos`.`administrador`.`senha`)
	VALUES
	(nome,
	senha);
END//
DELIMITER ;

-- Copiando estrutura para procedure corretorainvestimentos.insereCategoria
DROP PROCEDURE IF EXISTS `insereCategoria`;
DELIMITER //
CREATE PROCEDURE `insereCategoria`(
	nome varchar(100),
	imposto tinyint(1),
	fgc tinyint(1)

)
BEGIN
	INSERT INTO `corretorainvestimentos`.`categoria`
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

-- Copiando estrutura para procedure corretorainvestimentos.insereEmissor
DROP PROCEDURE IF EXISTS `insereEmissor`;
DELIMITER //
CREATE PROCEDURE `insereEmissor`(
	nome varchar(250),
	rating varchar(10),
	cnpj varchar(30)
)
BEGIN
	INSERT INTO `corretorainvestimentos`.`emissor`
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

-- Copiando estrutura para procedure corretorainvestimentos.insereInvestidor
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
	INSERT INTO `corretorainvestimentos`.`investidor`
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

-- Copiando estrutura para procedure corretorainvestimentos.insereInvestimento
DROP PROCEDURE IF EXISTS `insereInvestimento`;
DELIMITER //
CREATE PROCEDURE `insereInvestimento`(
	dataDeInvestimento date,
	quantidade int,
	INVESTIDOR_idINVESTIDOR int,
	OFERTA_idOFERTA int
)
BEGIN
	INSERT INTO `corretorainvestimentos`.`investimento`
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

-- Copiando estrutura para procedure corretorainvestimentos.insereOferta
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

	INSERT INTO `corretorainvestimentos`.`oferta`
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

-- Copiando estrutura para tabela corretorainvestimentos.investidor
DROP TABLE IF EXISTS `investidor`;
CREATE TABLE IF NOT EXISTS `investidor` (
  `idINVESTIDOR` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(250) NOT NULL,
  `cpf` varchar(20) NOT NULL,
  `saldoEmConta` decimal(10,5) NOT NULL,
  `email` varchar(250) NOT NULL,
  `senha` varchar(70) NOT NULL,
  PRIMARY KEY (`idINVESTIDOR`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela corretorainvestimentos.investimento
DROP TABLE IF EXISTS `investimento`;
CREATE TABLE IF NOT EXISTS `investimento` (
  `idINVESTIMENTO` int(11) NOT NULL AUTO_INCREMENT,
  `dataDeInvestimento` date NOT NULL,
  `quantidade` int(11) NOT NULL,
  `INVESTIDOR_idINVESTIDOR` int(11) NOT NULL,
  `OFERTA_idOFERTA` int(11) NOT NULL,
  PRIMARY KEY (`idINVESTIMENTO`,`INVESTIDOR_idINVESTIDOR`,`OFERTA_idOFERTA`),
  KEY `fk_INVESTIMENTOS_INVESTIDOR_idx` (`INVESTIDOR_idINVESTIDOR`),
  KEY `fk_INVESTIMENTO_OFERTA1_idx` (`OFERTA_idOFERTA`),
  CONSTRAINT `fk_INVESTIMENTOS_INVESTIDOR` FOREIGN KEY (`INVESTIDOR_idINVESTIDOR`) REFERENCES `investidor` (`idINVESTIDOR`),
  CONSTRAINT `fk_INVESTIMENTO_OFERTA1` FOREIGN KEY (`OFERTA_idOFERTA`) REFERENCES `oferta` (`idOFERTA`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para procedure corretorainvestimentos.obtemLogin
DROP PROCEDURE IF EXISTS `obtemLogin`;
DELIMITER //
CREATE PROCEDURE `obtemLogin`(in nome varchar(250), in senha varchar(100))
BEGIN
		SELECT * FROM administrador WHERE `corretorainvestimentos`.`administrador`.`nome` = nome AND `corretorainvestimentos`.`administrador`.`senha` = senha;
END//
DELIMITER ;

-- Copiando estrutura para procedure corretorainvestimentos.obtemNomeColunas
DROP PROCEDURE IF EXISTS `obtemNomeColunas`;
DELIMITER //
CREATE PROCEDURE `obtemNomeColunas`(in nome varchar(50))
BEGIN
	set @qry:= concat("SELECT COLUMN_NAME 
	FROM INFORMATION_SCHEMA.COLUMNS 
	WHERE TABLE_SCHEMA = 'corretorainvestimentos' 
    AND TABLE_NAME = '", nome, "'");
	prepare stmt from @qry;
	execute stmt;
    
END//
DELIMITER ;

-- Copiando estrutura para tabela corretorainvestimentos.oferta
DROP TABLE IF EXISTS `oferta`;
CREATE TABLE IF NOT EXISTS `oferta` (
  `idOFERTA` int(11) NOT NULL AUTO_INCREMENT,
  `valida` tinyint(1) NOT NULL,
  `liquidez` int(11) NOT NULL,
  `aplicacaoMinima` decimal(10,5) NOT NULL,
  `quantidadeDisponivel` int(11) NOT NULL,
  `rentabilidade` varchar(100) NOT NULL,
  `CATEGORIA_idCATEGORIA` int(11) NOT NULL,
  `EMISSOR_idEMISSOR` int(11) NOT NULL,
  PRIMARY KEY (`idOFERTA`,`CATEGORIA_idCATEGORIA`,`EMISSOR_idEMISSOR`),
  KEY `fk_OFERTAS_CATEGORIA1_idx` (`CATEGORIA_idCATEGORIA`),
  KEY `fk_OFERTAS_EMISSOR1_idx` (`EMISSOR_idEMISSOR`),
  CONSTRAINT `fk_OFERTAS_CATEGORIA1` FOREIGN KEY (`CATEGORIA_idCATEGORIA`) REFERENCES `categoria` (`idCATEGORIA`),
  CONSTRAINT `fk_OFERTAS_EMISSOR1` FOREIGN KEY (`EMISSOR_idEMISSOR`) REFERENCES `emissor` (`idEMISSOR`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para procedure corretorainvestimentos.procuraNomeUsuario
DROP PROCEDURE IF EXISTS `procuraNomeUsuario`;
DELIMITER //
CREATE PROCEDURE `procuraNomeUsuario`(in nome varchar(250))
BEGIN
	SELECT * FROM administrador WHERE `corretorainvestimentos`.`administrador`.`nome` = nome;
END//
DELIMITER ;

-- Copiando estrutura para procedure corretorainvestimentos.selectTable
DROP PROCEDURE IF EXISTS `selectTable`;
DELIMITER //
CREATE PROCEDURE `selectTable`(in nome varchar(50))
BEGIN
	set @qry:= concat('SELECT * FROM ',nome);
	prepare stmt from @qry;
	execute stmt;
END//
DELIMITER ;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
