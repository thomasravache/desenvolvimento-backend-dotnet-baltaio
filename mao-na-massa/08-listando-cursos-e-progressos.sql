SELECT
  [Course].[Title] AS [Course],
  [StudentCourse].[Progress],
  [StudentCourse].[LastUpdateDate],
  [Student].[Name] AS [Student]
FROM
  [Course]
  LEFT JOIN [StudentCourse] ON [Course].[Id] = [StudentCourse].[CourseId]
  LEFT JOIN [Student] ON [StudentCourse].[StudentId] = [Student].[Id]