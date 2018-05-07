﻿CREATE TABLE [dbo].[Cliente] (
    [Pront]        INT        NOT NULL IDENTITY,
    [Nome]         NCHAR (30) NULL,
    [dtNac]        DATE       NULL,
    [Idade]        INT        NULL,
    [Sexo]         CHAR (1)   NULL,
    [end]          NCHAR (40) NULL,
    [num]          NCHAR (5)  NULL,
    [bairro]       NCHAR (15) NULL,
    [cidade]       NCHAR (20) NULL,
    [estado]       NCHAR (2)  NULL,
    [cep]          INT        NULL,
    [tel]          NCHAR (14) NULL,
    [cel]          NCHAR (14) NULL,
    [email]        NCHAR (30) NULL,
    [cpf]          NCHAR (11) NULL,
    [rg]           NCHAR (9)  NULL,
    [escolaridade] NCHAR (15) NULL,
    [trabalho]     NCHAR (20) NULL,
    [estCivil]     NCHAR (15) NULL,
    [Responsavel]  NCHAR (30) NULL,
    [TelResp]      NCHAR (14) NULL,
    [Psicologo]    INT        NULL,
    PRIMARY KEY CLUSTERED ([Pront] ASC),
    CONSTRAINT [FK_psi] FOREIGN KEY ([Psicologo]) REFERENCES [dbo].[psicologos] ([Cod])
);

