-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 14-Maio-2018 às 12:43
-- Versão do servidor: 5.6.15-log
-- PHP Version: 5.4.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `vidracaria`
--

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
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

CREATE TABLE IF NOT EXISTS `clientes` (
  `cod` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(30) DEFAULT NULL,
  `apelido` varchar(20) DEFAULT NULL,
  `data_nasc` date DEFAULT NULL,
  `sexo` char(1) DEFAULT NULL,
  `CPF` varchar(14) DEFAULT NULL,
  `RG` varchar(12) DEFAULT NULL,
  `end` varchar(50) DEFAULT NULL,
  `num` int(11) DEFAULT NULL,
  `bairro` varchar(15) DEFAULT NULL,
  `cidade` varchar(20) DEFAULT NULL,
  `UF` varchar(2) NOT NULL,
  `CEP` varchar(9) NOT NULL,
  `tel` varchar(13) DEFAULT NULL,
  `cel` varchar(13) DEFAULT NULL,
  `email` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`cod`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Extraindo dados da tabela `clientes`
--

INSERT INTO `clientes` (`cod`, `nome`, `apelido`, `data_nasc`, `sexo`, `CPF`, `RG`, `end`, `num`, `bairro`, `cidade`, `UF`, `CEP`, `tel`, `cel`, `email`) VALUES
(1, 'Cristiane Franchini', 'Cris', NULL, 'F', '31544632835', '49510257x', 'Av. 6 de agosto 212', NULL, 'Vila nova', 'Pirassununga', '', '', '1930552353', '19996086192', 'crisfr01@gmail.com'),
(2, 'Cristiane Franchini', NULL, NULL, NULL, '31544632825', '49510257x', 'Av. 6 de agosto 212', NULL, 'Vila nova ', 'Pirassununga', '', '', '1930552353', '19996086192', 'crisfr01@gmail.com'),
(3, 'Transportadora Amente', NULL, NULL, NULL, '30', '0', 'R. Pereira Bueno 1137', NULL, 'Rosario', 'Pirassununga', 'SP', '13634310', '3561-5387', '97160878', NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `condpg`
--

CREATE TABLE IF NOT EXISTS `condpg` (
  `cod` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`cod`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Extraindo dados da tabela `condpg`
--

INSERT INTO `condpg` (`cod`, `descricao`) VALUES
(1, 'A vista'),
(2, '3 X');

-- --------------------------------------------------------

--
-- Estrutura da tabela `fornecedores`
--

CREATE TABLE IF NOT EXISTS `fornecedores` (
  `cod` int(11) NOT NULL AUTO_INCREMENT,
  `nome_fantasia` varchar(150) DEFAULT NULL,
  `razao_social` varchar(20) DEFAULT NULL,
  `cnpj` varchar(14) DEFAULT NULL,
  `ie` varchar(15) DEFAULT NULL,
  `end` varchar(30) DEFAULT NULL,
  `UF` varchar(2) DEFAULT NULL,
  `CEP` varchar(9) DEFAULT NULL,
  `bairro` varchar(15) DEFAULT NULL,
  `Cidade` varchar(15) DEFAULT NULL,
  `tel` varchar(13) DEFAULT NULL,
  `cel` varchar(13) DEFAULT NULL,
  `email` varchar(25) DEFAULT NULL,
  `servico` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`cod`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Extraindo dados da tabela `fornecedores`
--

INSERT INTO `fornecedores` (`cod`, `nome_fantasia`, `razao_social`, `cnpj`, `ie`, `end`, `UF`, `CEP`, `bairro`, `Cidade`, `tel`, `cel`, `email`, `servico`) VALUES
(1, NULL, 'AlGlas', '35273126389380', '', 'R. 13 de maio 2230', 'SP', '136863293', 'Vl industrial', 'São Paulo', '1376136892173', '1378947896589', 'Al.glas@123.com', 'Aluminio'),
(2, NULL, 'StarTemper', '46872648917203', '', 'rua oliveiras 422', 'SP', '739472984', 'Santa rita', 'Campinas', '7489372894720', '3092748972389', 'Startemper@gmail.com', 'Vidro temperado');

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
  `email` int(11) DEFAULT NULL,
  `funcao` varchar(20) DEFAULT NULL,
  `FGTS` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`cod`),
  UNIQUE KEY `cpf` (`cpf`,`rg`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Extraindo dados da tabela `funcionarios`
--

INSERT INTO `funcionarios` (`cod`, `nome`, `cpf`, `rg`, `endereco`, `num`, `bairro`, `cidade`, `uf`, `cep`, `telefone`, `cel`, `email`, `funcao`, `FGTS`) VALUES
(1, 'teste', '12131313131', '', NULL, NULL, NULL, NULL, NULL, '', '', '', NULL, NULL, '');

-- --------------------------------------------------------

--
-- Estrutura da tabela `itens`
--

CREATE TABLE IF NOT EXISTS `itens` (
  `codVend` int(11) NOT NULL,
  `codProd` int(11) NOT NULL,
  `altura` int(11) DEFAULT NULL,
  `largura` int(11) DEFAULT NULL,
  `qtde` int(11) DEFAULT NULL,
  `metragem` int(11) DEFAULT NULL,
  `Preco` int(11) DEFAULT NULL,
  KEY `codVend_fk` (`codVend`),
  KEY `codProd_fk` (`codProd`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `itens`
--

INSERT INTO `itens` (`codVend`, `codProd`, `altura`, `largura`, `qtde`, `metragem`, `Preco`) VALUES
(1, 1, 1, 1, 1, 1, 100),
(2, 3, 1, 1, 1, 1, 20),
(2, 2, 2, 2, 2, 8, 80),
(3, 1, 1, 1, 1, 1, 100);

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtos`
--

CREATE TABLE IF NOT EXISTS `produtos` (
  `cod` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `descricao` varchar(30) DEFAULT NULL,
  `pr_custo` int(11) DEFAULT NULL,
  `pr_venda` int(11) DEFAULT NULL,
  `qntd` int(11) DEFAULT NULL,
  `unid_med` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`cod`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Extraindo dados da tabela `produtos`
--

INSERT INTO `produtos` (`cod`, `nome`, `descricao`, `pr_custo`, `pr_venda`, `qntd`, `unid_med`) VALUES
(1, '', 'Vidro Pontilhado', 100, 200, 100, 'm2'),
(2, '', 'Vidro Cane', 10, 20, 200, 'm2'),
(3, '', 'Tucano grande', 20, 30, 10, 'un');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

CREATE TABLE IF NOT EXISTS `usuarios` (
  `cod` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(10) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `senha` varchar(10) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `nivel` char(1) DEFAULT NULL,
  PRIMARY KEY (`cod`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Extraindo dados da tabela `usuarios`
--

INSERT INTO `usuarios` (`cod`, `nome`, `senha`, `nivel`) VALUES
(1, 'admin', '123', '1'),
(2, 'Cristiane', '1992', '1'),
(3, 'cris', '1992', '1'),
(4, 'Fabio', 'Fabio', '2'),
(5, 'Fatima', 'j0198556', '1');

-- --------------------------------------------------------

--
-- Estrutura da tabela `vendas`
--

CREATE TABLE IF NOT EXISTS `vendas` (
  `cod` int(11) NOT NULL AUTO_INCREMENT,
  `codCli` int(11) NOT NULL,
  `data` date DEFAULT NULL,
  `Obs` varchar(300) DEFAULT NULL,
  `codFun` int(11) DEFAULT NULL,
  `codPG` int(11) DEFAULT NULL,
  `Valor` int(11) NOT NULL,
  PRIMARY KEY (`cod`),
  KEY `codPg_fk` (`codPG`),
  KEY `codFun_fk` (`codFun`),
  KEY `codCli_fk` (`codCli`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Extraindo dados da tabela `vendas`
--

INSERT INTO `vendas` (`cod`, `codCli`, `data`, `Obs`, `codFun`, `codPG`, `Valor`) VALUES
(1, 2, NULL, '1', 1, 1, 100),
(2, 3, NULL, NULL, NULL, NULL, 100),
(3, 1, '2018-05-13', '1', 1, 1, 100);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
