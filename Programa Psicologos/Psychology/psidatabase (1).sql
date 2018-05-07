-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 01-Dez-2016 às 23:44
-- Versão do servidor: 5.6.15-log
-- PHP Version: 5.4.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `psidatabase`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `acesp`
--

CREATE TABLE IF NOT EXISTS `acesp` (
  `cod` int(11) NOT NULL,
  `senha` varchar(10) NOT NULL,
  PRIMARY KEY (`cod`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `agenda`
--

CREATE TABLE IF NOT EXISTS `agenda` (
  `Cod_registro` int(11) NOT NULL AUTO_INCREMENT,
  `CodP` int(11) NOT NULL,
  `Titulo` varchar(128) NOT NULL,
  `Descricao` text,
  `Data` date DEFAULT NULL,
  `Hora` time DEFAULT NULL,
  `Status` varchar(24) DEFAULT 'Incompleto',
  PRIMARY KEY (`Cod_registro`),
  KEY `CodP` (`CodP`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Extraindo dados da tabela `agenda`
--

INSERT INTO `agenda` (`Cod_registro`, `CodP`, `Titulo`, `Descricao`, `Data`, `Hora`, `Status`) VALUES
(1, 2, 'novo envento', 'esse é novo', '2016-10-16', '03:00:00', 'Completo'),
(2, 2, 'asdsad', NULL, '2016-10-16', '10:30:00', 'Incompleto'),
(3, 1, 'Agora', 'NOW!!', '2016-10-10', '16:00:00', 'Incompleto'),
(4, 2, 'asdsdas', NULL, NULL, NULL, 'Incompleto');

-- --------------------------------------------------------

--
-- Estrutura da tabela `caixa`
--

CREATE TABLE IF NOT EXISTS `caixa` (
  `nregistro` int(11) NOT NULL AUTO_INCREMENT,
  `data` date NOT NULL,
  `valor` double NOT NULL,
  `responsavel` varchar(50) NOT NULL,
  `detalhes` varchar(100) DEFAULT NULL,
  `pront` int(30) DEFAULT NULL,
  PRIMARY KEY (`nregistro`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=17 ;

--
-- Extraindo dados da tabela `caixa`
--

INSERT INTO `caixa` (`nregistro`, `data`, `valor`, `responsavel`, `detalhes`, `pront`) VALUES
(3, '2016-11-01', 100, '1 - cris', 'Pagamento da sessão 1 do ClienteCristiane. Psicologo: código1', 6),
(4, '2016-10-31', 200, '2', '111', 6),
(5, '2016-10-31', 200, '1', NULL, 0),
(6, '2016-11-01', -90, '1', NULL, 0),
(7, '2016-11-01', -5.5, '1 - cris', '', 0),
(9, '2016-11-01', 80, '1 - cris', 'Pagamento da sessão 2 do Cliente Fatima. Psicologo: código 1', 4),
(10, '2016-11-01', -10, '1 - cris', '', NULL),
(11, '2016-11-01', -10, '1 - cris', '', NULL),
(12, '2016-11-01', -10, '1 - cris', '', NULL),
(13, '2016-11-14', 100, '', NULL, NULL),
(14, '2016-11-30', 100, 'x', 'x', NULL),
(15, '2016-11-30', -20, '', NULL, NULL),
(16, '2016-12-01', 80, '0 - ', 'Valor em caixa do dia anterior ', NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE IF NOT EXISTS `cliente` (
  `Pront` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(30) DEFAULT NULL,
  `dtNac` date DEFAULT NULL,
  `Idade` int(11) DEFAULT NULL,
  `Sexo` char(1) DEFAULT NULL,
  `ende` varchar(40) DEFAULT NULL,
  `num` varchar(5) DEFAULT NULL,
  `bairro` varchar(15) DEFAULT NULL,
  `cidade` varchar(20) DEFAULT NULL,
  `estado` varchar(2) DEFAULT NULL,
  `cep` varchar(12) DEFAULT NULL,
  `tel` varchar(14) DEFAULT NULL,
  `cel` varchar(14) DEFAULT NULL,
  `email` varchar(30) DEFAULT NULL,
  `cpf` varchar(11) DEFAULT NULL,
  `rg` varchar(9) DEFAULT NULL,
  `escolaridade` varchar(30) DEFAULT NULL,
  `trabalho` varchar(20) DEFAULT NULL,
  `estCivil` varchar(15) DEFAULT NULL,
  `Responsavel` varchar(30) DEFAULT NULL,
  `TelResp` varchar(14) DEFAULT NULL,
  `Psicologo` int(11) DEFAULT NULL,
  PRIMARY KEY (`Pront`),
  KEY `fk_codP` (`Psicologo`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`Pront`, `Nome`, `dtNac`, `Idade`, `Sexo`, `ende`, `num`, `bairro`, `cidade`, `estado`, `cep`, `tel`, `cel`, `email`, `cpf`, `rg`, `escolaridade`, `trabalho`, `estCivil`, `Responsavel`, `TelResp`, `Psicologo`) VALUES
(1, 'teste25', '2011-05-22', 1, 'M', 'av', NULL, 'as', 'pi', NULL, '21312331', '', '', NULL, '11111111111', '', NULL, 'asd', NULL, 'dsa', '19232326735', 1),
(2, 'teste 1', '1992-09-21', NULL, NULL, 'aa', '666', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2),
(3, 'Luana', '1990-04-22', 11, NULL, NULL, NULL, NULL, NULL, NULL, '', '', '', NULL, '', '', NULL, NULL, NULL, NULL, '', 2),
(4, 'Fatima', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'aaa', NULL, 2),
(5, 'Renato Gonzaga', '1996-02-10', 20, 'M', 'av 123', '12', 'Vila Faria', 'Porto ', 'SP', '12345678', '19892739729', '12083908204', NULL, '12343545678', '21324346x', 'Ensino Medio', 'Universitario', 'Solteiro', NULL, '', 1),
(6, 'Cristiane', '1992-09-23', 23, 'F', 'Av 6 de agosto ', '212', 'Vila nova', 'Pirassununga', 'SP', '13.632-300', '(19)996086192', '(19) 3562-5607', 'crisfr01@gmail.com', '31544643235', '49510257X', 'Superior', 'Comerciante', 'Solteiro', NULL, NULL, 2),
(7, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2),
(8, 'Laura Li', '1990-09-23', 26, 'F', 'Av 123', '12', 'Centro', 'Pira', 'SP', '13632300', '1935623456', '1999876275', 'laura.123@hotmail.com', '31457890173', '232435447', 'Superior', 'Gerente', 'Solteiro', 'ninguem', '2331', 1),
(9, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2),
(10, 'Leonardo Santana', '1996-05-22', 17, 'M', 'rua 1', '212', 'centro', 'analandia', 'SP', '', '', '', NULL, '12345689900', '', NULL, NULL, 'Solteiro', NULL, '', 1),
(11, 'Catarina Portiola', '2006-11-09', 10, 'F', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '23783672863', '382793721', 'Fundamental', 'estudante', 'Separados', 'Lucia', '23433456778', 1),
(12, 'Teste Cadastro', NULL, 10, NULL, NULL, NULL, NULL, NULL, NULL, '', '', '', NULL, '24356782709', '712073740', 'Medio', NULL, NULL, NULL, '', 1),
(13, 'Camila Duarte', '1987-09-22', 22, 'F', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '25671892008', '268369498', NULL, NULL, NULL, 'rr', NULL, 2),
(14, 'kleverson Marinho', '1999-10-16', 15, NULL, 'AV. null point', '666', 'Unknow', 'No where', 'AC', '13632140', '84938728368', '99321123123', 'kleverson.marinho@outlook.com', '45667567215', '125345672', 'Médio', 'Null', 'Solteiro', 'NULL', '19978463274', 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionarios`
--

CREATE TABLE IF NOT EXISTS `funcionarios` (
  `cod` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(200) NOT NULL,
  `cpf` varchar(12) NOT NULL,
  `rg` varchar(12) DEFAULT NULL,
  `endereco` varchar(200) DEFAULT NULL,
  `num` int(11) DEFAULT NULL,
  `bairro` varchar(40) DEFAULT NULL,
  `cidade` varchar(50) DEFAULT NULL,
  `uf` varchar(2) DEFAULT NULL,
  `cep` varchar(10) DEFAULT NULL,
  `telefone` varchar(12) DEFAULT NULL,
  `cel` varchar(12) DEFAULT NULL,
  `funcao` varchar(20) DEFAULT NULL,
  `FGTS` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`cod`),
  UNIQUE KEY `cpf` (`cpf`,`rg`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Extraindo dados da tabela `funcionarios`
--

INSERT INTO `funcionarios` (`cod`, `nome`, `cpf`, `rg`, `endereco`, `num`, `bairro`, `cidade`, `uf`, `cep`, `telefone`, `cel`, `funcao`, `FGTS`) VALUES
(1, 'Ricardo Trinidade', '12345678909', '123456789', 'rua duas lagoas', 121, 'Vila Marta', 'Pirassununga', 'SP', '12232345', '1234567896', '23456789655', 'secretario', '12345671234'),
(2, 'Wellington de Souza', '35697971029', '32313213Z', 'Av. Newton Prado', 352, 'Centro', 'Pirassununga', NULL, '13630000', '19929392168', '12342173218', 'Faxineiro', '14706338799');

-- --------------------------------------------------------

--
-- Estrutura da tabela `irmao`
--

CREATE TABLE IF NOT EXISTS `irmao` (
  `Pront` int(11) NOT NULL,
  `Nome` varchar(30) DEFAULT NULL,
  `Idade` int(11) DEFAULT NULL,
  `Escolari` varchar(15) DEFAULT NULL,
  KEY `pront_FK` (`Pront`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `irmao`
--

INSERT INTO `irmao` (`Pront`, `Nome`, `Idade`, `Escolari`) VALUES
(4, 'a', 1, '1'),
(4, 'q', 1, '1'),
(6, 'dsada', 12, 'fsfx');

-- --------------------------------------------------------

--
-- Estrutura da tabela `medicamentos`
--

CREATE TABLE IF NOT EXISTS `medicamentos` (
  `Pront` int(11) NOT NULL,
  `Nome` varchar(40) DEFAULT NULL,
  `Dosagem` varchar(20) DEFAULT NULL,
  `dose` varchar(20) DEFAULT NULL,
  KEY `pront_pk` (`Pront`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `medicamentos`
--

INSERT INTO `medicamentos` (`Pront`, `Nome`, `Dosagem`, `dose`) VALUES
(6, 'xx', '1', ''),
(6, 'dd', '1', '1'),
(6, 'f', '1', '1'),
(6, 'd', '1', '1'),
(8, 'xx', '1', '1'),
(6, 'ttt', 'ttt', 'ttt'),
(3, 'aas', '1', '1');

-- --------------------------------------------------------

--
-- Estrutura da tabela `psicologos`
--

CREATE TABLE IF NOT EXISTS `psicologos` (
  `CodP` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(128) DEFAULT NULL,
  `End` varchar(150) DEFAULT NULL,
  `num` int(5) DEFAULT NULL,
  `cidade` varchar(30) DEFAULT NULL,
  `estado` varchar(2) DEFAULT NULL,
  `bairro` varchar(30) DEFAULT NULL,
  `cep` varchar(10) NOT NULL,
  `tel` varchar(14) DEFAULT NULL,
  `cel` varchar(14) DEFAULT NULL,
  `CRP` varchar(10) DEFAULT NULL,
  `abordagem` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`CodP`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Extraindo dados da tabela `psicologos`
--

INSERT INTO `psicologos` (`CodP`, `Nome`, `End`, `num`, `cidade`, `estado`, `bairro`, `cep`, `tel`, `cel`, `CRP`, `abordagem`) VALUES
(1, 'Cris', 'awerwesrerfsaer', 12312, 'dasdsadas', 'RS', 'asfsdafsdfsad', '21.312-412', '(12)41124-4214', '(12)42141-2421', NULL, NULL),
(2, 'admin', NULL, NULL, NULL, NULL, NULL, '', NULL, NULL, NULL, NULL),
(3, 'Julia ', 'dsda', 232, NULL, NULL, 'sf', '', NULL, NULL, '213246567', 'Compor'),
(4, 'JKL', 'AV. IDE', 123, 'C sharp', 'AC', 'Java', '19.236-823', '(12)32132-1312', '(12)32131-2321', '1232132', 'Nenhuma');

-- --------------------------------------------------------

--
-- Estrutura da tabela `sessoes`
--

CREATE TABLE IF NOT EXISTS `sessoes` (
  `numS` int(11) NOT NULL AUTO_INCREMENT,
  `pront` int(11) NOT NULL,
  `dat` date DEFAULT NULL,
  `descr` varchar(300) DEFAULT NULL,
  `resumo` varchar(1000) DEFAULT NULL,
  `valor` double DEFAULT NULL,
  `pg` char(2) DEFAULT NULL,
  PRIMARY KEY (`numS`),
  KEY `pront_fk` (`pront`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Extraindo dados da tabela `sessoes`
--

INSERT INTO `sessoes` (`numS`, `pront`, `dat`, `descr`, `resumo`, `valor`, `pg`) VALUES
(1, 6, '2016-08-22', 'dsad', 'dasa', 100, 'Pg'),
(2, 4, NULL, 'wqewq', 'weqwe', 80, 'Pg'),
(3, 6, NULL, NULL, NULL, 100, 'Pg');

-- --------------------------------------------------------

--
-- Stand-in structure for view `sessoes_cli`
--
CREATE TABLE IF NOT EXISTS `sessoes_cli` (
`pront` int(11)
,`nome` varchar(30)
,`codP` int(11)
,`cpf` varchar(11)
,`dat` date
,`numS` int(11)
,`resumo` varchar(1000)
,`pg` char(2)
,`valor` double
);
-- --------------------------------------------------------

--
-- Estrutura da tabela `triagem`
--

CREATE TABLE IF NOT EXISTS `triagem` (
  `Pront` int(11) NOT NULL,
  `NomeM` varchar(30) DEFAULT NULL,
  `Profissao` varchar(20) DEFAULT NULL,
  `escoM` varchar(15) DEFAULT NULL,
  `idadeM` int(11) DEFAULT NULL,
  `celM` varchar(14) DEFAULT NULL,
  `telM` varchar(14) DEFAULT NULL,
  `NomeP` varchar(30) DEFAULT NULL,
  `ProfP` varchar(20) DEFAULT NULL,
  `escoP` varchar(15) DEFAULT NULL,
  `idadeP` int(11) DEFAULT NULL,
  `celP` varchar(14) DEFAULT NULL,
  `TelP` varchar(14) DEFAULT NULL,
  `Irmaos` varchar(10) DEFAULT NULL,
  `Geneto` longblob,
  `ContatEmer` varchar(25) DEFAULT NULL,
  `telEmer` varchar(14) DEFAULT NULL,
  `Vlse` decimal(10,0) DEFAULT NULL,
  `tratPsi` char(3) DEFAULT NULL,
  `queixaA` varchar(100) DEFAULT NULL,
  `qndoPs` varchar(20) DEFAULT NULL,
  `dura` varchar(20) DEFAULT NULL,
  `Onde` varchar(30) DEFAULT NULL,
  `obsT` varchar(100) DEFAULT NULL,
  `trtM` varchar(3) DEFAULT NULL,
  `doenca` varchar(50) DEFAULT NULL,
  `medico` varchar(30) DEFAULT NULL,
  `qndoDo` varchar(20) DEFAULT NULL,
  `obsD` varchar(100) DEFAULT NULL,
  `Medica` varchar(3) DEFAULT NULL,
  `Obs` varchar(150) DEFAULT NULL,
  `queixa` varchar(300) DEFAULT NULL,
  PRIMARY KEY (`Pront`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `triagem`
--

INSERT INTO `triagem` (`Pront`, `NomeM`, `Profissao`, `escoM`, `idadeM`, `celM`, `telM`, `NomeP`, `ProfP`, `escoP`, `idadeP`, `celP`, `TelP`, `Irmaos`, `Geneto`, `ContatEmer`, `telEmer`, `Vlse`, `tratPsi`, `queixaA`, `qndoPs`, `dura`, `Onde`, `obsT`, `trtM`, `doenca`, `medico`, `qndoDo`, `obsD`, `Medica`, `Obs`, `queixa`) VALUES
(4, 'a1', '11', '1', 1, '1', NULL, '1', '1', '1', 1, '1', '1', '1', NULL, '1', NULL, NULL, NULL, NULL, NULL, NULL, '1', '1', NULL, '1', '1', NULL, NULL, 'Não', '11111111111111111111111111111111111111111111111111111111111111111111111', '111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111'),
(5, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(6, 'teste', 't', NULL, NULL, NULL, NULL, NULL, NULL, 't', NULL, NULL, NULL, '1', NULL, NULL, NULL, '10', 'abc', 'asd', NULL, NULL, NULL, 'obs', NULL, NULL, 'ds', NULL, NULL, NULL, 'oioio', '7856'),
(1, 'a', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'ddfsd'),
(3, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(8, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(12, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

CREATE TABLE IF NOT EXISTS `usuarios` (
  `cod` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(20) DEFAULT NULL,
  `senha` varchar(10) DEFAULT NULL,
  `nivel` int(11) DEFAULT NULL,
  `codPsi` int(11) NOT NULL,
  PRIMARY KEY (`cod`),
  KEY `fk_codPsi` (`codPsi`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Extraindo dados da tabela `usuarios`
--

INSERT INTO `usuarios` (`cod`, `nome`, `senha`, `nivel`, `codPsi`) VALUES
(1, 'admin', '1234', 1, 1),
(2, 'Cris', '1992', 2, 2),
(3, 'Roberta', '2016', 3, 0);

-- --------------------------------------------------------

--
-- Structure for view `sessoes_cli`
--
DROP TABLE IF EXISTS `sessoes_cli`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `sessoes_cli` AS select `s`.`pront` AS `pront`,`c`.`Nome` AS `nome`,`c`.`Psicologo` AS `codP`,`c`.`cpf` AS `cpf`,`s`.`dat` AS `dat`,`s`.`numS` AS `numS`,`s`.`resumo` AS `resumo`,`s`.`pg` AS `pg`,`s`.`valor` AS `valor` from (`sessoes` `s` join `cliente` `c` on((`s`.`pront` = `c`.`Pront`)));

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
