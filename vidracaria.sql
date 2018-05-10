-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 10-Maio-2018 às 01:30
-- Versão do servidor: 5.6.15-log
-- PHP Version: 5.5.8

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
  `CodFun` int(11) NOT NULL,
  `Titulo` varchar(128) NOT NULL,
  `Descricao` text,
  `Data` date DEFAULT NULL,
  `Hora` time DEFAULT NULL,
  `Status` varchar(24) DEFAULT 'Incompleto',
  PRIMARY KEY (`Cod_registro`),
  KEY `CodFun` (`CodFun`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

CREATE TABLE IF NOT EXISTS `clientes` (
  `cod` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(30) DEFAULT NULL,
  `data-nasc` date DEFAULT NULL,
  `sexo` char(20) DEFAULT NULL,
  `apelido` varchar(20) DEFAULT NULL,
  `CPF` varchar(14) DEFAULT NULL,
  `RG` varchar(12) DEFAULT NULL,
  `end` varchar(50) DEFAULT NULL,
  `bairro` varchar(15) DEFAULT NULL,
  `cidade` varchar(20) DEFAULT NULL,
  `UF` varchar(2) NOT NULL,
  `CEP` varchar(9) NOT NULL,
  `tel` varchar(13) DEFAULT NULL,
  `cel` varchar(13) DEFAULT NULL,
  `email` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`cod`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `fornecedores`
--

CREATE TABLE IF NOT EXISTS `fornecedores` (
  `cod` int(11) NOT NULL AUTO_INCREMENT,
  `razao_social` varchar(30) DEFAULT NULL,
  `nome_fantasia` varchar(30) DEFAULT NULL,
  `cnpj` varchar(14) DEFAULT NULL,
  `ie` varchar(14) DEFAULT NULL,
  `end` varchar(30) DEFAULT NULL,
  `num` varchar(5) DEFAULT NULL,
  `bairro` varchar(15) NOT NULL,
  `Cidade` varchar(15) DEFAULT NULL,
  `UF` varchar(2) NOT NULL,
  `CEP` varchar(9) NOT NULL,
  `tel` varchar(13) DEFAULT NULL,
  `cel` varchar(13) DEFAULT NULL,
  `funcao` varchar(20) NOT NULL,
  `email` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`cod`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionarios`
--

CREATE TABLE IF NOT EXISTS `funcionarios` (
  `codigo` int(6) NOT NULL AUTO_INCREMENT,
  `nome` varchar(30) NOT NULL,
  `cpf` varchar(11) NOT NULL,
  `RG` varchar(9) NOT NULL,
  `end` varchar(50) NOT NULL,
  `num` int(5) NOT NULL,
  `bairro` varchar(30) NOT NULL,
  `cidade` varchar(30) NOT NULL,
  `uf` varchar(2) NOT NULL,
  `cep` varchar(9) NOT NULL,
  `tel` varchar(13) DEFAULT NULL,
  `cell` varchar(13) DEFAULT NULL,
  `funcao` varchar(20) DEFAULT NULL,
  `fgts` varchar(11) NOT NULL,
  `email` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`codigo`),
  UNIQUE KEY `cpf` (`cpf`,`RG`,`fgts`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

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
(1, 1, 1, 1, 1, 1, 1),
(1, 2, 2, 2, 2, 2, 2),
(2, 2, 2, 2, 2, 2, 2),
(2, 2, 23, 34, 34, 34, 3);

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtos`
--

CREATE TABLE IF NOT EXISTS `produtos` (
  `cod` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(30) DEFAULT NULL,
  `pr_custo` int(11) DEFAULT NULL,
  `pr_venda` int(11) DEFAULT NULL,
  `qntd` int(11) DEFAULT NULL,
  `unid_med` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`cod`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Extraindo dados da tabela `produtos`
--

INSERT INTO `produtos` (`cod`, `descricao`, `pr_custo`, `pr_venda`, `qntd`, `unid_med`) VALUES
(1, 'Vidro Pontilhado', 100, 80, NULL, NULL);

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
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Extraindo dados da tabela `vendas`
--

INSERT INTO `vendas` (`cod`, `codCli`, `data`, `Obs`, `codFun`, `codPG`, `Valor`) VALUES
(1, 1, '2016-02-22', 'ds', 2, 1, 2),
(2, 2, '2222-02-22', 'dfsf', 1, 2, 232),
(3, 3, NULL, 'dsfwea', 2, 1, 111),
(4, 2, NULL, 'fdvd', 2, 1, 23);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
