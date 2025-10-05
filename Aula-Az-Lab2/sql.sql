CREATE SCHEMA demo AUTHORIZATION dbo;
GO

CREATE TABLE demo.Clientes (
  Id INT IDENTITY PRIMARY KEY,
  Nome NVARCHAR(120) NOT NULL,
  Email NVARCHAR(200) UNIQUE,
  CriadoEm DATETIME2 DEFAULT SYSUTCDATETIME()
);
GO

INSERT INTO demo.Clientes (Nome, Email)
VALUES ('Ana Lima', 'ana@example.com'),
       ('João Souza', 'joao@example.com');

SELECT * FROM demo.Clientes;
