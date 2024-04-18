# Group3_Student_Management_Application

Recorded Application Functionality URL: https://drive.google.com/file/d/1XUC2GhTTDu85z1PatF8W5Mw_zUeIKEpP/view?usp=drive_link

A. Application Description Summary
    This is the Group 3 Student Management Application and it has the following functionalities.
1. User SignUp - User could be Student or Professor
2. User Login - User could be Student or Professor
3. Student View having the following pages/abilities;
    a. Dashboard: Student can view their dashboard with their name on it and a summary details of the application.
    b. Courses: Student can view a summary of their courses.
    c. Grades: Student can view the grades for their courses.
    d. Notification: Student can view latest notification sent by Professor.
    e. Logout: Student can Logout of the application.
4. Professor View having the following pages/abilities;
    a. Dashboard: Professor can view their dashboard with their name on it and a summary details of the application.
    b. Courses: Professor can view a summary of the courses.
    c. Grades: Professor can enter the grades for students on each course.
    d. Notification: Professor can enter notification message for all Students to see.
    e. Logout: Professor can Logout of the application.

B. Group Members and Contributions
    1. Adeoluwatomiwa Adegbesan- 8965771: Implementation
    2. Ogechi Angela Ikediashi- 8913831: Implementation
    3. Prasanna chinnu- 8869349: Designing and Compilation
    4. Yamini Alugubelli -8991450: Database
    5. Pratyusha Jayavarapu-8973016: Designing
    6. Pooja Talaniya -8904569: Testing

C. Database Setup
    1. Database Creation: The application needs a Database to run and it it contain four (4) tables and Data seeded into one (1) of the tables.
        The tables are:
            UserCredentials
            Notification
            Courses (Data will be seeded into this table to create 2 records)
            Grades
        Kindly find below Instructions, and create statementes for the tables listed able and the insertion statement for the Courses table.

        a. Create a Database called "Group3StudentManagement" manually in your local Microsoft SQL Database.
        b. Run the following scripts after one another to create the different tables and insert the necessary records.
--------UserCredentials:
USE [Group3StudentManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserCredentials](
    [UserID] [int] IDENTITY(1,1) NOT NULL,
    [FirstName] [varchar](100) NOT NULL,
    [LastName] [varchar](100) NOT NULL,
    [Role] [varchar](50) NOT NULL,
    [Email] [varchar](150) NOT NULL,
    [Password] [varchar](50) NOT NULL,
    [Phone] [varchar](10) NOT NULL,
    [DateCreated] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
    [UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
--------Notification:
USE [Group3StudentManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notification](
    [NotificationMessage] [nvarchar](max) NOT NULL,
    [Date] [datetime] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
--------Courses:
USE [Group3StudentManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
    [CourseID] [int] NOT NULL,
    [CourseName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
    [CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Courses] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Courses] ([CourseID])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Courses]
GO

USE [Group3StudentManagement]
GO
INSERT INTO [dbo].[Courses]
           ([CourseID]
           ,[CourseName])
     VALUES
           ('1', 'MATH101'),
           ('2', 'STAT101')
GO
--------Grades:
USE [Group3StudentManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grades](
    [UserID] [int] NOT NULL,
    [CourseID] [int] NOT NULL,
    [Grade] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Grades]  WITH CHECK ADD  CONSTRAINT [FK_Grades_Courses] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Courses] ([CourseID])
GO
ALTER TABLE [dbo].[Grades] CHECK CONSTRAINT [FK_Grades_Courses]
GO
ALTER TABLE [dbo].[Grades]  WITH CHECK ADD  CONSTRAINT [FK_Grades_UserCredentials] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserCredentials] ([UserID])
GO
ALTER TABLE [dbo].[Grades] CHECK CONSTRAINT [FK_Grades_UserCredentials]
GO

D. Application Setup
    1. Clone the Application Repository from your Visual Studio "https://github.com/Ade0luwa/Group3_Student_Management_Application_Project"

E. Application and Database Connection Setup
    In your Visual Studio, when the cloned application is open, the the following;
        1. Goto View
        2. Select Server Explorer
        3. Click on Connect to Database
        4. Select Microsoft SQL Server
        5. Enter your Server name
        6. Select your Database
        7. Test Connection (Should be successful) if not reconfirm the details
        8. Then Click on Ok
        9. Confirm that you can see your tables from the Data Connections in the Server Explorer
        10. Click on the Database connection and copy the Connection string from the Properties
        11. Kindly replace the connection string in each class throughout the application (This line of code will be found in each class between line 20 and 30)

F. Run Application
    Application is now ready to run.

G. Recorded Application Functionality URL: https://drive.google.com/file/d/1XUC2GhTTDu85z1PatF8W5Mw_zUeIKEpP/view?usp=drive_link