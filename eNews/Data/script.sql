USE eNews

INSERT INTO News(Title, ContentType, Description, Keywords, CreationTime)
VALUES  ('China defends detention of Uighur model in Xinjiang', 'World', 'Merdan Ghappar sent video of himself, and a series of accompanying text messages, to his family in February.Relatives say the 31-year-old was forcibly transported back to the far-western region of Xinjiang in January after completing a 16-month sentence for a drugs offence in the southern Chinese city of Foshan, where hed been living and working.','asia|china|xinjiang', '20120618 10:34:09 AM'),
		('Portugal president helps rescue two women in trouble at sea', 'Europe', 'As there is a very large west current, they were dragged out, turned around, swallowed a lot of water and were not even able to turn [the kayak], nor to climb [on it], or swim, such is the strength of the current, he told local media.','europa|portugal|sea', '20120618 10:34:09 AM'),
		('Two men charged with 2002 murder of Run-DMC DJ Jam Master Jay', 'World', 'Merdan Ghappar sent video of himself, and a series of accompanying text messages, to his family in February.Relatives say the 31-year-old was forcibly transported back to the far-western region of Xinjiang in January after completing a 16-month sentence for a drugs offence in the southern Chinese city of Foshan, where hed been living and working.','canada|us|', '20120618 10:34:09 AM'),
		('Bill Morneau: Canada finance minister quits amid charity probe', 'World', 'Merdan Ghappar sent video of himself, and a series of accompanying text messages, to his family in February.Relatives say the 31-year-old was forcibly transported back to the far-western region of Xinjiang in January after completing a 16-month sentence for a drugs offence in the southern Chinese city of Foshan, where hed been living and working.','asia|china|xinjiang', '20120618 10:34:09 AM'),
		('Belarus: Two rivals, two very different messages', 'World', 'Merdan Ghappar sent video of himself, and a series of accompanying text messages, to his family in February.Relatives say the 31-year-old was forcibly transported back to the far-western region of Xinjiang in January after completing a 16-month sentence for a drugs offence in the southern Chinese city of Foshan, where hed been living and working.','asia|china|xinjiang', '20120618 10:34:09 AM'),
		('China defends detention of Uighur model in Xinjiang', 'World', 'Merdan Ghappar sent video of himself, and a series of accompanying text messages, to his family in February.Relatives say the 31-year-old was forcibly transported back to the far-western region of Xinjiang in January after completing a 16-month sentence for a drugs offence in the southern Chinese city of Foshan, where hed been living and working.','asia|china|xinjiang', '20120618 10:34:09 AM');

INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], 
[Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], 
[NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], 
[SecurityStamp], [TwoFactorEnabled], [UserName]) 
VALUES
	(N'0633e088-30a6-444f-8562-70d7c26748ef', 0, 
	N'd2feada1-c7db-4f5a-801c-4ae5c990a49d', N'admin@gmail.com', 1, 1, NULL, 
	N'USER@DOMAIN.COM', N'USER@DOMAIN.COM', 
	N'AQAAAAEAACcQAAAAEBqhdvkH3O3glua9IFU+LDamc3mj03dPQ/8brAW34GTN6kxMOqs5je90FNn7fuNleQ==', 
	N'+10001234567', 1, N'6123adf0-fc53-4abb-b6a4-52d164da4e4f', 0, N'user@domain.com')

INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) 
VALUES
	(N'0633e088-30a6-444f-8562-70d7c26748ef', 'Admin', N'd2feada1-c7db-4f5a-801c-4ae5c990a49d', N'd2feada1-fv85-4f5a-801c-4ae5c990a49d'),
	(N'0633e088-30a6-9685-8562-70d7c26748ef', 'Public', N'd2feada1-c7db-8596-801c-4ae5c990a49d', N'd2feada1-ik96-4f5a-801c-4ae5c990a49d');

INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) 
VALUES
	(N'0633e088-30a6-444f-8562-70d7c26748ef', N'0633e088-30a6-444f-8562-70d7c26748ef');
GO