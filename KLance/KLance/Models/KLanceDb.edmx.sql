
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/06/2015 15:39:50
-- Generated from EDMX file: C:\Users\Luzmaria\Documents\Visual Studio 2013\Projects\KalAcademy\KLance\KLance\Models\KLanceDb.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [KLance2139_db];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PersonEmployer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employers] DROP CONSTRAINT [FK_PersonEmployer];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonJobSeeker]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[JobSeekers] DROP CONSTRAINT [FK_PersonJobSeeker];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[People]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People];
GO
IF OBJECT_ID(N'[dbo].[Employers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employers];
GO
IF OBJECT_ID(N'[dbo].[JobSeekers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[JobSeekers];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [SSN] int  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [City] nvarchar(max)  NOT NULL,
    [State] nchar(2)  NOT NULL,
    [Zip] smallint  NOT NULL,
    [Phone] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Employers'
CREATE TABLE [dbo].[Employers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SSN] int  NOT NULL,
    [Person_SSN] int  NOT NULL
);
GO

-- Creating table 'JobSeekers'
CREATE TABLE [dbo].[JobSeekers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SSN] int  NOT NULL,
    [Person_SSN] int  NOT NULL
);
GO

-- Creating table 'Jobs'
CREATE TABLE [dbo].[Jobs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [StartDate] datetime  NOT NULL,
    [DurationOfProject] int  NOT NULL,
    [FixedPrice] decimal(18,0)  NOT NULL,
    [PostedDate] datetime  NOT NULL,
    [Status] bit  NOT NULL,
    [BidStartDate] datetime  NOT NULL,
    [BidEndDate] datetime  NOT NULL,
    [EmployerID] int  NOT NULL,
    [Employer_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [SSN] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([SSN] ASC);
GO

-- Creating primary key on [Id] in table 'Employers'
ALTER TABLE [dbo].[Employers]
ADD CONSTRAINT [PK_Employers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'JobSeekers'
ALTER TABLE [dbo].[JobSeekers]
ADD CONSTRAINT [PK_JobSeekers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Jobs'
ALTER TABLE [dbo].[Jobs]
ADD CONSTRAINT [PK_Jobs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Person_SSN] in table 'Employers'
ALTER TABLE [dbo].[Employers]
ADD CONSTRAINT [FK_PersonEmployer]
    FOREIGN KEY ([Person_SSN])
    REFERENCES [dbo].[People]
        ([SSN])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonEmployer'
CREATE INDEX [IX_FK_PersonEmployer]
ON [dbo].[Employers]
    ([Person_SSN]);
GO

-- Creating foreign key on [Person_SSN] in table 'JobSeekers'
ALTER TABLE [dbo].[JobSeekers]
ADD CONSTRAINT [FK_PersonJobSeeker]
    FOREIGN KEY ([Person_SSN])
    REFERENCES [dbo].[People]
        ([SSN])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonJobSeeker'
CREATE INDEX [IX_FK_PersonJobSeeker]
ON [dbo].[JobSeekers]
    ([Person_SSN]);
GO

-- Creating foreign key on [Employer_Id] in table 'Jobs'
ALTER TABLE [dbo].[Jobs]
ADD CONSTRAINT [FK_EmployerJob]
    FOREIGN KEY ([Employer_Id])
    REFERENCES [dbo].[Employers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployerJob'
CREATE INDEX [IX_FK_EmployerJob]
ON [dbo].[Jobs]
    ([Employer_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------