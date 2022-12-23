USE [Cursos]
GO

CREATE OR ALTER PROCEDURE [spListCourse]
  @CategoryName NVARCHAR(60),
  -- é possível utilizar parâmetros também
  @Parametro2 NVARCHAR(10)
-- é possível colocar mais de um parâmetro
AS
DECLARE @CategoryId INT
-- declaração de variável

-- SET @CategoryId = 9 -- atribuição de variável

-- atribuição utilizando uma query
SET @CategoryId = (SELECT TOP 1
  [Id]
FROM [Categoria]
WHERE [Nome] = @CategoryName)
-- Colocar query entre parênteses senão não funciona

SELECT *
FROM [Curso]
WHERE [CategoriaId] = @CategoryId

GO

-- Executando a procedure
EXEC [spListCourse] 'Backend', 'parametro2'