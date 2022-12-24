SELECT *
FROM [Student]

DECLARE @studentId UNIQUEIDENTIFIER = '2d4c3303-b8a2-4e87-83b3-93b613de317e'

SELECT
  [Student].[Name] AS [Student],
  [Course].[Title] AS [Course],
  [StudentCourse].[Progress],
  [StudentCourse].[LastUpdateDate]
FROM
  [StudentCourse]
  INNER JOIN [Student] ON [StudentCourse].[StudentId] = [Student].[Id]
  INNER JOIN [Course] ON [StudentCourse].[CourseId] = [Course].[Id]
WHERE
    [StudentCourse].[StudentId] = @studentId
  AND [StudentCourse].[Progress] < 100
  AND [StudentCourse].[Progress] > 0
ORDER BY
    [StudentCourse].[LastUpdateDate] DESC