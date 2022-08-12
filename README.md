# Sample Blazor CRUD


#RUN the script below to create a database before run the app


/****** Object:  Database [School]******/
CREATE DATABASE [School]
/****** Object:  Table [dbo].[Students]******/
CREATE TABLE [dbo].[Students](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NULL,
	[Email] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

INSERT [dbo].[Students] ([Name], [Email]) VALUES (N'Rachel', N'ra@gmail.c')
INSERT [dbo].[Students] ([Name], [Email]) VALUES (N'teste2', N'tdrf@dscg')
INSERT [dbo].[Students] ([Name], [Email]) VALUES (N'Ygor Raphael', N'ygoraphael@gmail.com')

