USE [Movie_Comparison]
GO
/****** Object:  Table [dbo].[Movie]    Script Date: 23/12/2020 02:21:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie](
	[movie_name] [nvarchar](50) NULL,
	[IMDB_Url] [nvarchar](100) NULL,
	[rating] [int] NULL,
	[number_of_votes] [int] NULL,
	[movie_id] [int] IDENTITY(1,1) NOT NULL,
	[creation_date] [datetime] NULL,
 CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED 
(
	[movie_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Movie] ON 

INSERT [dbo].[Movie] ([movie_name], [IMDB_Url], [rating], [number_of_votes], [movie_id], [creation_date]) VALUES (N'A Christmas Journey', N'https://www.imdb.com/title/tt7736496/?ref_=hm_inth_2', 2, 2, 102, CAST(N'2020-11-24T10:09:55.183' AS DateTime))
INSERT [dbo].[Movie] ([movie_name], [IMDB_Url], [rating], [number_of_votes], [movie_id], [creation_date]) VALUES (N'Shomrey ha''agadot', N'https://www.imdb.com/title/tt1446192/?ref_=hm_inth_1', 4, 7, 103, CAST(N'2020-11-24T10:18:08.603' AS DateTime))
INSERT [dbo].[Movie] ([movie_name], [IMDB_Url], [rating], [number_of_votes], [movie_id], [creation_date]) VALUES (N'Fast and Furious', N'https://www.imdb.com/title/tt6806448/?ref_=nv_sr_srsg_0', 10, 2, 104, CAST(N'2020-12-12T21:34:21.600' AS DateTime))
INSERT [dbo].[Movie] ([movie_name], [IMDB_Url], [rating], [number_of_votes], [movie_id], [creation_date]) VALUES (N'The Lion King', N'https://www.imdb.com/video/vi3509369881?ref_=nv_sr_srsg_4', 3, 2, 105, CAST(N'2020-12-13T22:55:30.470' AS DateTime))
INSERT [dbo].[Movie] ([movie_name], [IMDB_Url], [rating], [number_of_votes], [movie_id], [creation_date]) VALUES (N'Prison break', N'https://www.imdb.com/title/tt0455275/?ref_=nv_sr_srsg_0', 10, 2, 106, CAST(N'2020-12-13T22:56:05.667' AS DateTime))
INSERT [dbo].[Movie] ([movie_name], [IMDB_Url], [rating], [number_of_votes], [movie_id], [creation_date]) VALUES (N'Fast anf Farious', N'https://www.imdb.com/title/tt6806448/?ref_=nv_sr_srsg_0', 2, 2, 107, CAST(N'2020-12-13T22:57:53.087' AS DateTime))
SET IDENTITY_INSERT [dbo].[Movie] OFF
/****** Object:  StoredProcedure [dbo].[Create_movie]    Script Date: 23/12/2020 02:21:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Create_movie] @Movie_name nvarchar(50),@IMDB_Url nvarchar(100) ,@rating int,@number_of_votes int,@creation_date datetime
AS
insert into Movie
values (@movie_name,@IMDB_Url,@rating,@number_of_votes,@creation_date)
GO
/****** Object:  StoredProcedure [dbo].[Delete_movie]    Script Date: 23/12/2020 02:21:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Delete_movie] @movie_id int
AS
delete Movie
where movie_id=@movie_id
GO
/****** Object:  StoredProcedure [dbo].[Get_All_movies]    Script Date: 23/12/2020 02:21:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Get_All_movies]
AS
begin
	SELECT *from Movie
	
end
GO
/****** Object:  StoredProcedure [dbo].[Get_movie]    Script Date: 23/12/2020 02:21:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_movie] @movie_name varchar(50)	
AS
begin
	SELECT *from Movie
	where movie_name=@movie_name
end
GO
/****** Object:  StoredProcedure [dbo].[Get_movie_by_rating]    Script Date: 23/12/2020 02:21:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Get_movie_by_rating] @rating int
AS
select * from Movie
where rating>=@rating
GO
/****** Object:  StoredProcedure [dbo].[getMovies]    Script Date: 23/12/2020 02:21:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[getMovies]
AS
begin
	SELECT *from Movie
	
end
GO
/****** Object:  StoredProcedure [dbo].[Update_movie]    Script Date: 23/12/2020 02:21:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_movie] @movie_name nvarchar(50),@IMDB_Url nvarchar(100) ,@rating int,@number_of_votes int,@creation_date datetime
AS
update Movie
SET	movie_name=@movie_name,IMDB_Url=@IMDB_Url,rating=@rating,number_of_votes=@number_of_votes,creation_date=@creation_date
where movie_name=@movie_name
GO
