-- OP READ - LER

SELECT * FROM Contas;
GO

SELECT Titular,Numero_da_conta,Saldo FROM Contas
WHERE Saldo > 1000;
GO

SELECT * FROM Contas
WHERE Titular LIKE '%Maria%';
GO

SELECT * FROM Contas
WHERE Numero_da_conta = 1002
GO

-- Ordenas por saldo do maior p/ menor
SELECT * FROM Contas
ORDER BY Saldo DESC
GO

-- Contar quantas contas existe na tabela
SELECT COUNT(*) AS TotalContas FROM Contas
GO

-- Ordenas por saldo do MENOR p/ MAIOR
SELECT * FROM Contas
ORDER BY Saldo ASC
GO

-- Soma todos Saldos das contas na tabela
SELECT SUM(Saldo) AS SaldoTotal FROM Contas
GO
-- Média de saldo nas contas
SELECT AVG(Saldo) AS MediaSaldos FROM Contas
GO