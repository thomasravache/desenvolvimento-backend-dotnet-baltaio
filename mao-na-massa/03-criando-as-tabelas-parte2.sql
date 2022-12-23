USE [balta]
GO

CREATE TABLE [CareerItem]
(
  [CareerId] UNIQUEIDENTIFIER NOT NULL,
  [CourseId] UNIQUEIDENTIFIER NOT NULL,
  [Title] NVARCHAR(160) NOT NULL,
  [Description] TEXT NOT NULL,
  [Order] TINYINT NOT NULL,

  CONSTRAINT [PK_CareerItem] PRIMARY KEY ([CourseId], [CareerId]),
  CONSTRAINT [FK_CareerItem_Career_CareerId] FOREIGN KEY ([CareerId]) REFERENCES [Career] ([Id]) ON DELETE NO ACTION,
  CONSTRAINT [FK_CareerItem_Course_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [Course] ([Id]) ON DELETE NO ACTION
)
GO

CREATE TABLE [StudentCourse]
(
  [CourseId] UNIQUEIDENTIFIER NOT NULL,
  [StudentId] UNIQUEIDENTIFIER NOT NULL,
  [Progress] TINYINT NOT NULL,
  [Favorite] BIT NOT NULL,
  [StartDate] DATETIME NOT NULL,
  [LastUpdateDate] DATETIME NULL,

  CONSTRAINT [PK_StudentCourse] PRIMARY KEY ([CourseId], [StudentId]),
  CONSTRAINT [FK_StudentCourse_Course_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [Course] ([Id]) ON DELETE NO ACTION,
  CONSTRAINT [FK_StudentCourse_Student_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [Student] ([Id]) ON DELETE NO ACTION
)
GO
