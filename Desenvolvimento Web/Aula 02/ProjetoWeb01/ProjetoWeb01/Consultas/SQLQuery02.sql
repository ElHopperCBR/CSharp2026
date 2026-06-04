/*
-- Cria o banco (opcional, se ainda não existir)
IF DB_ID('Aluno') IS NULL
BEGIN
	CREATE DATABASE Aluno;
END
GO

USE Aluno;
GO
*/
-- Tabela base
IF OBJECT_ID('dbo.Usuario', 'U') IS NOT NULL DROP TABLE dbo.Usuario;
GO
CREATE TABLE dbo.Usuario
(
	Id      INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Nome    NVARCHAR(150) NOT NULL,
	Email   NVARCHAR(150) NOT NULL,
	Senha   NVARCHAR(255) NOT NULL,
	Regra   INT NOT NULL, -- 0 = Usuario, 1 = Admin
	CONSTRAINT CK_Usuario_Regra CHECK (Regra IN (0, 1))
);
GO

-- Tabela filha Alunos (1:1 com Usuario via Id)
IF OBJECT_ID('dbo.Alunos', 'U') IS NOT NULL DROP TABLE dbo.Alunos;
GO
CREATE TABLE dbo.Alunos
(
	Id           INT NOT NULL PRIMARY KEY,
	RA           INT NOT NULL,
	StatusWIFI   NVARCHAR(50)  NOT NULL CONSTRAINT DF_Alunos_StatusWIFI  DEFAULT ('Inativo'),
	StatusAction NVARCHAR(100) NOT NULL CONSTRAINT DF_Alunos_StatusAction DEFAULT ('Aguardando aprovação'),
	CursoID      INT NOT NULL,

	CONSTRAINT FK_Alunos_Usuario
		FOREIGN KEY (Id) REFERENCES dbo.Usuario(Id)
		ON DELETE CASCADE
);
GO

-- Tabela filha Admin (1:1 com Usuario via Id)
IF OBJECT_ID('dbo.Admin', 'U') IS NOT NULL DROP TABLE dbo.Admin;
GO
CREATE TABLE dbo.Admin
(
	Id INT NOT NULL PRIMARY KEY,

	CONSTRAINT FK_Admin_Usuario
		FOREIGN KEY (Id) REFERENCES dbo.Usuario(Id)
		ON DELETE CASCADE
);
GO