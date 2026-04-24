-- ====================================================================
-- SCRIPT PARA REORGANIZAR IDs SEQUENCIALMENTE NA TABELA dbo.Alunos
-- ====================================================================
-- Este script remove lacunas nos IDs (ex: 1,2,4,6 vira 1,2,3,4)
-- ATENÇÃO: Use com cuidado! Isso altera os IDs existentes.
-- ====================================================================

-- Iniciar transação para garantir rollback em caso de erro
BEGIN TRANSACTION;

BEGIN TRY
	-- PASSO 1: Criar tabela temporária com IDs sequenciais
-- ROW_NUMBER() gera uma sequência contínua (1,2,3...) baseada na ordem dos IDs originais
SELECT ROW_NUMBER() OVER(ORDER BY Id) AS NovoId, Nome, RA, Curso 
INTO #TempAlunos 
FROM dbo.Alunos;

-- Limpar tabela original
-- PASSO 2: Limpar completamente a tabela original
-- TRUNCATE remove todos os registros e reseta o contador de identidade
TRUNCATE TABLE dbo.Alunos;

-- Resetar identity
-- PASSO 3: Resetar o contador de identidade para começar do zero
-- RESEED 0 faz com que o próximo valor auto-gerado seja 1
DBCC CHECKIDENT ('dbo.Alunos', RESEED, 0);

-- Reinserir com IDs sequenciais
-- PASSO 4: Reinserir os dados com IDs reorganizados
-- SET IDENTITY_INSERT ON permite inserir valores explícitos na coluna de identidade (Id)
SET IDENTITY_INSERT dbo.Alunos ON;

-- Insere os dados da tabela temporária com os novos IDs sequenciais
INSERT INTO dbo.Alunos (Id, Nome, RA, Curso)
SELECT NovoId, Nome, RA, Curso FROM #TempAlunos;

-- SET IDENTITY_INSERT OFF retorna ao comportamento padrão (auto-incremento)
SET IDENTITY_INSERT dbo.Alunos OFF;

-- Remover temporária
-- PASSO 5: Remover a tabela temporária
-- Limpa os recursos utilizados
DROP TABLE #TempAlunos;

-- ====================================================================
-- RESULTADO: Tabela dbo.Alunos agora possui IDs sequenciais sem lacunas
-- ====================================================================