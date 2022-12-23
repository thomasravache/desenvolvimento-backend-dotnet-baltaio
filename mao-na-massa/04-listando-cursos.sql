CREATE OR ALTER VIEW vwCourses
AS
  SELECT
    [Course].[Id],
    [Course].[Tag],
    [Course].[Title],
    [Course].[url],
    [Course].[Summary],
    [Course].[CreateDate],
    [Category].[Title] AS [CategoryTitle],
    [Author].[Name] AS [AuthorName]
  FROM
    [Course]
    INNER JOIN [Category] ON [Course].[CategoryId] = [Category].[Id]
    INNER JOIN [Author] ON [Course].[AuthorId] = [Author].[Id]
  WHERE
        [Active] = 1
GO

SELECT *
FROM vwCourses
ORDER BY [CreateDate] DESC
GO
