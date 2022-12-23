CREATE OR ALTER PROCEDURE [spListCourse]
AS
SELECT *
FROM [Curso]
GO

-- EXECUTAR lista de cursos

EXEC [spListCourse]

-- DROPAR procedure

DROP PROCEDURE [spListCourse]

-- CREATE OR ALTER tenta criar, se já existir sobrescreve
