use QLSV
go
create table SV (
	MSSV nvarchar(10) not null,
	NameSV nvarchar(MAX),
	Class nvarchar(50),
	Gender BIT,
	DateOfBirth datetime,
	DTB float,
	Photo BIT,
	SchoolProfile BIT,
	CitizenID BIT,
	constraint pk_SV primary key(MSSV)
)

