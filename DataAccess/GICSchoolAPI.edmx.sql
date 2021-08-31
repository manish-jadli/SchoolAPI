
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/19/2018 23:24:41
-- Generated from EDMX file: E:\school\schoolManagementAPI\DataAccess\GICSchoolAPI.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [schoolManagement];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[classes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[classes];
GO
IF OBJECT_ID(N'[dbo].[family_members]', 'U') IS NOT NULL
    DROP TABLE [dbo].[family_members];
GO
IF OBJECT_ID(N'[dbo].[homework]', 'U') IS NOT NULL
    DROP TABLE [dbo].[homework];
GO
IF OBJECT_ID(N'[dbo].[parent_addresses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[parent_addresses];
GO
IF OBJECT_ID(N'[dbo].[parents]', 'U') IS NOT NULL
    DROP TABLE [dbo].[parents];
GO
IF OBJECT_ID(N'[dbo].[reports]', 'U') IS NOT NULL
    DROP TABLE [dbo].[reports];
GO
IF OBJECT_ID(N'[dbo].[school_addresses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[school_addresses];
GO
IF OBJECT_ID(N'[dbo].[schools]', 'U') IS NOT NULL
    DROP TABLE [dbo].[schools];
GO
IF OBJECT_ID(N'[dbo].[stdent_families]', 'U') IS NOT NULL
    DROP TABLE [dbo].[stdent_families];
GO
IF OBJECT_ID(N'[dbo].[student_addresses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[student_addresses];
GO
IF OBJECT_ID(N'[dbo].[student_classes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[student_classes];
GO
IF OBJECT_ID(N'[dbo].[student_parents]', 'U') IS NOT NULL
    DROP TABLE [dbo].[student_parents];
GO
IF OBJECT_ID(N'[dbo].[students]', 'U') IS NOT NULL
    DROP TABLE [dbo].[students];
GO
IF OBJECT_ID(N'[dbo].[subjects]', 'U') IS NOT NULL
    DROP TABLE [dbo].[subjects];
GO
IF OBJECT_ID(N'[dbo].[teachers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[teachers];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'addresses'
CREATE TABLE [dbo].[addresses] (
    [address_id] nvarchar(100)  NOT NULL,
    [address_detail] nvarchar(100)  NULL
);
GO

-- Creating table 'classes'
CREATE TABLE [dbo].[classes] (
    [class_id] nvarchar(20)  NOT NULL,
    [subject_id] nvarchar(20)  NULL,
    [teacher_id] nvarchar(20)  NULL,
    [class_code] nvarchar(20)  NULL,
    [class_name] nvarchar(50)  NULL,
    [date_from] nvarchar(20)  NULL,
    [date_to] nvarchar(20)  NULL,
    [IsActive] bit  NULL
);
GO

-- Creating table 'family_members'
CREATE TABLE [dbo].[family_members] (
    [family_member_id] nvarchar(20)  NOT NULL,
    [family_id] nvarchar(20)  NULL,
    [parent_or_student_member] nvarchar(100)  NULL,
    [parent_id] nvarchar(20)  NULL,
    [student_id] nvarchar(100)  NULL
);
GO

-- Creating table 'homework'
CREATE TABLE [dbo].[homework] (
    [homework_id] nvarchar(20)  NOT NULL,
    [student_id] nvarchar(100)  NULL,
    [date_created] nvarchar(20)  NULL,
    [homework_content] nvarchar(100)  NULL,
    [grade] nvarchar(10)  NULL,
    [other_homework_details] nvarchar(100)  NULL
);
GO

-- Creating table 'parent_addresses'
CREATE TABLE [dbo].[parent_addresses] (
    [parent_id] nvarchar(100)  NOT NULL,
    [gender] nvarchar(20)  NULL,
    [first_name] nvarchar(50)  NULL,
    [middle_name] nvarchar(50)  NULL,
    [last_name] nvarchar(50)  NULL,
    [other_parent_details] nvarchar(100)  NULL
);
GO

-- Creating table 'parents'
CREATE TABLE [dbo].[parents] (
    [parent_id] nvarchar(20)  NOT NULL,
    [gender] nvarchar(20)  NULL,
    [first_name] nvarchar(50)  NULL,
    [middle_name] nvarchar(50)  NULL,
    [last_name] nvarchar(50)  NULL,
    [other_parent_details] nvarchar(100)  NULL,
    [IsActive] bit  NULL
);
GO

-- Creating table 'reports'
CREATE TABLE [dbo].[reports] (
    [report_id] nvarchar(20)  NOT NULL,
    [student_id] nvarchar(100)  NULL,
    [date_created] nvarchar(50)  NULL,
    [report_content] nvarchar(100)  NULL,
    [teacher_comments] nvarchar(150)  NULL,
    [other_report_details] nvarchar(200)  NULL,
    [IsActive] bit  NULL
);
GO

-- Creating table 'schools'
CREATE TABLE [dbo].[schools] (
    [school_id] nvarchar(50)  NOT NULL,
    [address_id] nvarchar(100)  NULL,
    [school_name] nvarchar(100)  NULL,
    [school_principal] nvarchar(50)  NULL,
    [other_school_details] nvarchar(100)  NULL,
    [IsActive] bit  NULL
);
GO

-- Creating table 'stdent_families'
CREATE TABLE [dbo].[stdent_families] (
    [family_id] nvarchar(20)  NOT NULL,
    [head_of_family_parent_id] nvarchar(20)  NULL,
    [family_name] nvarchar(100)  NULL
);
GO

-- Creating table 'student_addresses'
CREATE TABLE [dbo].[student_addresses] (
    [student_id] nvarchar(100)  NOT NULL,
    [address_id] nvarchar(100)  NULL,
    [date_from] nvarchar(50)  NULL,
    [address_details] nvarchar(100)  NULL,
    [IsActive] bit  NULL
);
GO

-- Creating table 'student_classes'
CREATE TABLE [dbo].[student_classes] (
    [student_id] nvarchar(100)  NOT NULL,
    [class_id] nvarchar(20)  NULL,
    [date_from] nvarchar(20)  NULL,
    [date_to] nvarchar(20)  NULL,
    [IsActive] bit  NULL
);
GO

-- Creating table 'student_parents'
CREATE TABLE [dbo].[student_parents] (
    [student_id] nvarchar(100)  NOT NULL,
    [parent_id] nvarchar(20)  NULL
);
GO

-- Creating table 'students'
CREATE TABLE [dbo].[students] (
    [student_id] nvarchar(100)  NOT NULL,
    [gender] nvarchar(20)  NULL,
    [first_name] nvarchar(50)  NULL,
    [middle_name] nvarchar(50)  NULL,
    [last_name] nvarchar(50)  NULL,
    [date_of_birth] nvarchar(20)  NULL,
    [other_student_details] nvarchar(100)  NULL,
    [IsActive] bit  NULL,
    [class_code] varchar(50)  NULL,
    [address] varchar(100)  NULL,
    [father_name] varchar(100)  NULL,
    [mother_name] varchar(100)  NULL,
    [admission_on] varchar(100)  NULL,
    [school_name] varchar(200)  NULL,
    [mobile_no] varchar(10)  NULL
);
GO

-- Creating table 'subjects'
CREATE TABLE [dbo].[subjects] (
    [subject_id] nvarchar(20)  NOT NULL,
    [subject_name] nvarchar(150)  NULL,
    [IsActive] bit  NULL
);
GO

-- Creating table 'teachers'
CREATE TABLE [dbo].[teachers] (
    [teacher_id] nvarchar(20)  NOT NULL,
    [school_id] nvarchar(50)  NULL,
    [gender] nvarchar(20)  NULL,
    [first_name] nvarchar(50)  NULL,
    [middle_name] nvarchar(50)  NULL,
    [last_name] nvarchar(50)  NULL,
    [other_teacher_details] nvarchar(100)  NULL,
    [IsActive] bit  NULL
);
GO

-- Creating table 'school_addresses'
CREATE TABLE [dbo].[school_addresses] (
    [address_id] nvarchar(100)  NOT NULL,
    [address_detail] nvarchar(100)  NULL,
    [IsActive] bit  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [address_id] in table 'addresses'
ALTER TABLE [dbo].[addresses]
ADD CONSTRAINT [PK_addresses]
    PRIMARY KEY CLUSTERED ([address_id] ASC);
GO

-- Creating primary key on [class_id] in table 'classes'
ALTER TABLE [dbo].[classes]
ADD CONSTRAINT [PK_classes]
    PRIMARY KEY CLUSTERED ([class_id] ASC);
GO

-- Creating primary key on [family_member_id] in table 'family_members'
ALTER TABLE [dbo].[family_members]
ADD CONSTRAINT [PK_family_members]
    PRIMARY KEY CLUSTERED ([family_member_id] ASC);
GO

-- Creating primary key on [homework_id] in table 'homework'
ALTER TABLE [dbo].[homework]
ADD CONSTRAINT [PK_homework]
    PRIMARY KEY CLUSTERED ([homework_id] ASC);
GO

-- Creating primary key on [parent_id] in table 'parent_addresses'
ALTER TABLE [dbo].[parent_addresses]
ADD CONSTRAINT [PK_parent_addresses]
    PRIMARY KEY CLUSTERED ([parent_id] ASC);
GO

-- Creating primary key on [parent_id] in table 'parents'
ALTER TABLE [dbo].[parents]
ADD CONSTRAINT [PK_parents]
    PRIMARY KEY CLUSTERED ([parent_id] ASC);
GO

-- Creating primary key on [report_id] in table 'reports'
ALTER TABLE [dbo].[reports]
ADD CONSTRAINT [PK_reports]
    PRIMARY KEY CLUSTERED ([report_id] ASC);
GO

-- Creating primary key on [school_id] in table 'schools'
ALTER TABLE [dbo].[schools]
ADD CONSTRAINT [PK_schools]
    PRIMARY KEY CLUSTERED ([school_id] ASC);
GO

-- Creating primary key on [family_id] in table 'stdent_families'
ALTER TABLE [dbo].[stdent_families]
ADD CONSTRAINT [PK_stdent_families]
    PRIMARY KEY CLUSTERED ([family_id] ASC);
GO

-- Creating primary key on [student_id] in table 'student_addresses'
ALTER TABLE [dbo].[student_addresses]
ADD CONSTRAINT [PK_student_addresses]
    PRIMARY KEY CLUSTERED ([student_id] ASC);
GO

-- Creating primary key on [student_id] in table 'student_classes'
ALTER TABLE [dbo].[student_classes]
ADD CONSTRAINT [PK_student_classes]
    PRIMARY KEY CLUSTERED ([student_id] ASC);
GO

-- Creating primary key on [student_id] in table 'student_parents'
ALTER TABLE [dbo].[student_parents]
ADD CONSTRAINT [PK_student_parents]
    PRIMARY KEY CLUSTERED ([student_id] ASC);
GO

-- Creating primary key on [student_id] in table 'students'
ALTER TABLE [dbo].[students]
ADD CONSTRAINT [PK_students]
    PRIMARY KEY CLUSTERED ([student_id] ASC);
GO

-- Creating primary key on [subject_id] in table 'subjects'
ALTER TABLE [dbo].[subjects]
ADD CONSTRAINT [PK_subjects]
    PRIMARY KEY CLUSTERED ([subject_id] ASC);
GO

-- Creating primary key on [teacher_id] in table 'teachers'
ALTER TABLE [dbo].[teachers]
ADD CONSTRAINT [PK_teachers]
    PRIMARY KEY CLUSTERED ([teacher_id] ASC);
GO

-- Creating primary key on [address_id] in table 'school_addresses'
ALTER TABLE [dbo].[school_addresses]
ADD CONSTRAINT [PK_school_addresses]
    PRIMARY KEY CLUSTERED ([address_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------