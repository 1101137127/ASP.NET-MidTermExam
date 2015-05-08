
CREATE DATABASE [Course]
GO

USE [Course]
GO

CREATE TABLE [dbo].[Course](
	[CourseId]   [nvarchar](20) NOT NULL,
	[CourseName] [nvarchar](200) NOT NULL,
	[CourseDescription]  [nvarchar](1000) NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT [dbo].[Course] ([CourseId], [CourseName], [CourseDescription]) VALUES (N'Csharp'  , N'Csharp程式設計', '程式設計課程');
INSERT [dbo].[Course] ([CourseId], [CourseName], [CourseDescription]) VALUES (N'Wei', N'微積分', '微積分應用');
INSERT [dbo].[Course] ([CourseId], [CourseName], [CourseDescription]) VALUES (N'TK'  , N'通識課程', '藝術創造力導論');
GO
