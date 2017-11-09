CREATE TABLE [dbo].[Doctor]
(
	[DoctorID] INT NOT NULL PRIMARY KEY, 
    [DoctorFirstName] VARCHAR(30) NOT NULL, 
    [DoctorLastName] VARCHAR(30) NOT NULL, 
    [DoctorPhone] VARCHAR(10) NOT NULL, 
    [DoctorEmail] VARCHAR(50) NOT NULL
)
