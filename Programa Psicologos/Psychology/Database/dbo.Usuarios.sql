CREATE TABLE [dbo].[Usuarios] (
    [cod]   INT        NOT NULL IDENTITY,
    [Nome]  NCHAR (20) NULL,
    [senha] NCHAR (10) NULL,
    [nivel] INT        NULL,
    PRIMARY KEY CLUSTERED ([cod] ASC)
);

