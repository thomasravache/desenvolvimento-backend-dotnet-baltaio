CREATE OR ALTER VIEW vwCareers
AS
  SELECT
    [Career].[Id],
    [Career].[Title],
    [Career].[Url],
    COUNT([Career].[Id]) AS [Courses]
  FROM
    [Career]
    INNER JOIN [CareerItem] ON [Career].[Id] = [CareerItem].[CareerId]
  GROUP BY
        [Career].[Id],
        [Career].[Title],
        [Career].[Url]
GO

SELECT *
FROM vwCareers