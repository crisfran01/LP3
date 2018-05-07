-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 19-Jun-2017 às 03:59
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
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=24 ;

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
(16, '2016-12-01', 80, '0 - ', 'Valor em caixa do dia anterior ', NULL),
(17, '2017-06-18', 80, 'Sistema', 'Valor em caixa do dia anterior ', NULL),
(18, '2017-06-18', 100, '2 - Cris', 'Pagamento da sessão 9 do Cliente Luana. Psicologo: código 2', 3),
(19, '2017-06-18', 100, '2 - Cris', 'Pagamento da sessão 7 do Cliente Luana. Psicologo: código 2', 3),
(20, '2017-06-18', 100, '2 - Cris', 'Pagamento da sessão 15 do Cliente Luana. Psicologo: código 2', 3),
(21, '2017-06-18', 100, '2 - Cris', 'Pagamento da sessão 1 do Cliente Cristiane ff. Psicologo: código 2', 6),
(22, '2017-06-18', 100, '2 - Cris', 'Pagamento da sessão 7 do Cliente Luana. Psicologo: código 2', 3),
(23, '2017-06-18', 100, '2 - Cris', 'Pagamento da sessão 9 do Cliente Luana. Psicologo: código 2', 3);

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
(2, 'Marcia Almeida', '1982-09-21', 34, NULL, 'aa', '666', NULL, NULL, NULL, NULL, NULL, NULL, NULL, '21546867987', '879746313', NULL, NULL, NULL, NULL, NULL, 2),
(3, 'Luana', '1990-04-22', 11, NULL, NULL, NULL, NULL, NULL, NULL, '', '', '', NULL, '', '', NULL, NULL, NULL, NULL, '', 2),
(4, 'Fatima', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'aaa', NULL, 2),
(5, 'Renato Gonzaga', '1996-02-10', 20, 'M', 'av 123', '12', 'Vila Faria', 'Porto ', 'SP', '12345678', '19892739729', '12083908204', NULL, '12343545678', '21324346x', 'Ensino Medio', 'Universitario', 'Solteiro', NULL, '', 1),
(6, 'Cristiane ff', '1992-09-23', 23, 'F', 'Av 6 de agosto ', '212', 'Vila nova', 'Pirassununga', 'SP', '13632300', '19996086192', '19 35625607', 'crisfr01@gmail.com', '31544643235', '49510257X', 'Superior', 'Comerciante', 'Solteiro', NULL, '', 2),
(7, 'Tadeu Teodoro', '2010-10-10', 6, 'M', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '312312321', NULL, NULL, NULL, 'Laura ', '15489798463', 2),
(8, 'Laura Li', '1990-09-23', 26, 'F', 'Av 123', '12', 'Centro', 'Pira', 'SP', '13632300', '1935623456', '1999876275', 'laura.123@hotmail.com', '31457890173', '232435447', 'Superior', 'Gerente', 'Solteiro', 'ninguem', '2331', 1),
(9, 'Ruan Duarte', '1992-10-25', 24, NULL, NULL, NULL, NULL, NULL, NULL, '', '', '', NULL, '12134867979', '548779864', 'Es medio', 'estudante', NULL, NULL, '', 2),
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
(6, 'dsada', 12, 'fsfx'),
(6, 'Andre', 20, '');

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
  `conta` int(11) DEFAULT NULL,
  `pront` int(11) NOT NULL,
  `dat` date DEFAULT NULL,
  `descr` varchar(300) DEFAULT NULL,
  `resumo` varchar(1000) DEFAULT NULL,
  `valor` double DEFAULT NULL,
  `pg` char(2) DEFAULT NULL,
  PRIMARY KEY (`numS`),
  KEY `pront_fk` (`pront`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=18 ;

--
-- Extraindo dados da tabela `sessoes`
--

INSERT INTO `sessoes` (`numS`, `conta`, `pront`, `dat`, `descr`, `resumo`, `valor`, `pg`) VALUES
(1, NULL, 6, '2016-08-22', 'dsad', 'dasa', 100, 'Pg'),
(2, NULL, 4, NULL, 'wqewq', 'weqwe', 80, 'n'),
(3, NULL, 6, '2017-05-23', NULL, NULL, 100, 'Pg'),
(4, NULL, 1, NULL, NULL, NULL, NULL, 'N'),
(5, NULL, 1, NULL, 'ff', NULL, NULL, 'N'),
(6, NULL, 1, NULL, NULL, NULL, NULL, NULL),
(7, NULL, 3, NULL, 's', 'ff', 100, 'Pg'),
(8, NULL, 3, NULL, '33', NULL, 100, 'A'),
(9, NULL, 3, '2017-05-25', NULL, NULL, 100, 'Pg'),
(15, NULL, 3, '2017-06-13', NULL, NULL, 100, 'n'),
(16, NULL, 3, '2017-06-13', NULL, NULL, 100, 'A'),
(17, NULL, 3, NULL, NULL, NULL, 100, 'A');

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
(4, 'a1', '11', '1', 1, '1', NULL, '1', '1', '1', 1, '1', '1', '1', NULL, '12', NULL, NULL, NULL, NULL, NULL, NULL, '1', '1', NULL, '1', '1', NULL, NULL, 'Não', '11111111111111111111111111111111111111111111111111111111111111111111111', '111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111'),
(5, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(6, 'testea', 't', NULL, NULL, '', '', NULL, NULL, 't', NULL, '', '', '1', 0x89504e470d0a1a0a0000000d49484452000000cb0000008008020000002a060acb0000000467414d410000b18f0bfc61050000000970485973000012740000127401de661f780000055549444154785eedd3d192a4380c44d1f9ff9f9e25666f46980057090a61b0f23c4a2ecb2db2fffc35cbe484592e27cc72396196cb09b35c4e98e572c22c971356cb9f3e4e5ccd099b1f093a881fffecfc453c64101e617d6cea37dcf503276c42ece83adc7b8a13361b1674356e3fce099b07abf988a37b38f111478f70c226c15e3a3814c6cff67022ecb284514dc318a16affb0940dda6771cb06ed1827ecf5d8c806eddf70d706ed0027ecf5d84883c675b8778dde374ed8bbb18e068dab717b83c6374ed88bb18b068d1ccc68d0f8c8097b31762154333149a87ee484bd158b68d0c8c4a4068d3e27ecad588450cdc73ca1dae784bd158b10aaf9982754fb9cb057620b42f52e4c15aa1d6f4d986db1a97ccc13aa1d4ed8545856328609d50e276c2a2c2b19c3846a8713361596958c6142b5c3099b079bcac73ca1daf1d68451bd0b5385ea38bc43a8de85a942b5e3fce3b85ea8a6618c50bd0b5385ea503c45a8e6635e8346c7f99771bd504dc318a17a17a60ad5a1788a50cdc73ca1da77fe654c10aa69182354efc254a13a144f69d0c8c4a4068dbef3cf6282504dc318a17a17a60ad5d1788d50cdc424a1fad1f9673144a8a6618c50bd0b5385ea68bca6412307331a343e3aff268608d5348c11aa7761aa507d001ed4a071356e6fd0f8e6fc839833088fb80b5385ea03f0a0357ad7e1de357adf3861214c15aacfc09b3668ff86bb3668073861214c15aa8fc1b336689fc52d1bb4639cb010a60ad527e1657b387104bfdcc38930272c84a942f56178dc471cddc3898f387ac44397f5342c58a83e124f4cc080839cb010762c549f8a575e877b4f71c242d8b4507d36defa1beefa811316c2be85ea1bf0e2e3f8fdcf9cb010b62e54df86d7f771ee524e58085f40a85a80971542b284aa05785921244ba85a80971542b284aa05785921244ba85a80971542b284aa05785921244ba85a80971542b284aa05785921244ba85a80971542b284aa05785921244ba85a80971542b284aa05785921244ba85a80971542b284aa05785921244ba85a80971542b284aa05785921244ba85a80971542b284aa05785921244ba85a80971542b284aa05785921244ba85a80971542b284aa05785921244ba85a80971542b284aa05785921244ba85a80971542b284aa05785921244ba85a8097f51db1eae39cedf176f6919de3f8bd8937b2424caec08de57911201757e3f6c2bc82ac6cb5985452ed3f3e86d37d9cfb86d3c5d44d189fbd8343c7f1fb0e0e5552f51fab8f13bfe1ae3d9c28a3e47f5507edeb70ef06ed1aeafd4b75d04ec080357a0514fb7fda432f1393d6e8cdaed23fd31e7af998b7466f6a65fe93f6d0bb0b53d7e8cdab6ec268dc8bd90d1af32a91303e6683c608bca04163524ed8003c42a84e6afe84f1191b34c6e11d0d1a332a9730aaa3f11aa13a23276c0c5e235467e4848dc16b1a34a63379c2f87a42f5197893509d8e13360c6f12aad371c286e14d42753a4ed830bc49a84ec7091b863709d5e93861c3f026a13a1d276c18de2454a7532b610b1aa3f19a068de94c9eb0051f50a88ec66b84ea8c9cb031788d509d51b9842d688cc33b1a3466347fc2167c46a13a0eef10aa93aa98b0058d11784183c6a44a246cc1c76cd0b817b31b34e65537610b7a7761ea1abd795549d8824fba462f1ff3d6e84dad50c2167cd8357a9998b4466f76b512b6e0f3aed1cbc18c357a05944bd8828fbc41fb3adcbb41bb868a095bf0a9f770e237dcb5871365144dd8820fdec1a1e3f87d07872aa99bb0059ffd1b4ef771ee1b4e17533a61ffe3fb676252494e18c8c2d5b8bd30af60855c5c811bcbf322f61193e3f8bd8937f21dd9e9e39cedf1762c971366b99c30cbe584592e27cc72396196cb09b35c4e9865fafbf73fc571b83735f06f6b0000000049454e44ae426082, '12', '', '10', 'Não', 'asdwsh g', NULL, NULL, NULL, 'obs', NULL, NULL, 'ds', NULL, NULL, 'Não', 'oioio', '7856a'),
(1, 'a', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'ddfsd'),
(3, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '', '100', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
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
(2, 'teste', '1234', 2, 2),
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
