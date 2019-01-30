USE [Lokisaur-TKD-Theory-App]

CREATE TABLE [dbo].[Theory_languages](
	[CountryCode] [char](3) NOT NULL,
	[Name] [text] NULL,
 CONSTRAINT [PK_Theory_languages] PRIMARY KEY CLUSTERED 
(
	[CountryCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[KOR_theory_items](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MainCategory] [text] NOT NULL,
	[SubCategory] [text] NOT NULL,
	[SubToSubCategory] [text] NULL,
	[Name_latin] [text] NOT NULL,
	[Name_hangul] [nvarchar](100) NULL,
	[Name_phonetic] [nvarchar](100) NULL,
	[Name_audio] [varchar](100) NULL
 CONSTRAINT [PK_KOR_theory_items] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[DAN_theory_items](
	[id] [int] NOT NULL,
	[korean_theory_item_id] [int] NOT NULL,
	[MainCategory] [text] NOT NULL,
	[SubCategory] [text] NOT NULL,
	[SubToSubCategory] [text] NULL,
	[Name_latin] [nvarchar](100) NOT NULL,
	[Name_phonetic] [nvarchar](100) NULL,
	[Name_audio] [nvarchar](100) NULL
 CONSTRAINT [PK_DAN_theory_items] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[ENG_theory_items](
	[id] [int] NOT NULL,
	[korean_theory_item_id] [int] NOT NULL,
	[MainCategory] [text] NOT NULL,
	[SubCategory] [text] NOT NULL,
	[SubToSubCategory] [text] NULL,
	[Name_latin] [nvarchar](100) NOT NULL,
	[Name_phonetic] [nvarchar](100) NULL,
	[Name_audio] [nvarchar](100) NULL
 CONSTRAINT [PK_ENG_theory_items] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](128) NOT NULL,
	[LastName] [varchar](128) NOT NULL,
	[UserName] [varchar](128) NOT NULL,
	[EmailAdress] [varchar](128) NOT NULL,
	[PasswordSalt] [nvarchar](128) NOT NULL,
	[PasswordHash] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
