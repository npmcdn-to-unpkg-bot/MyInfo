﻿CREATE TABLE [dbo].[tblI]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [iDate] DATETIME NULL DEFAULT getdate(), 
    [hid] hierarchyid(10) not null, 
    [Level] AS hid.GetLevel(), 
	[Name] VARCHAR(128) NULL, 
    [Key] VARCHAR(100) NULL, 
    [Value] NCHAR(1000) NULL, 
    [Url] VARCHAR(100) NULL
)
