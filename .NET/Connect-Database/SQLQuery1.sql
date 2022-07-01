use demo 
go 
create table LopSH (
	ID_Lop int not null,
	NameLop nvarchar(MAX),
	constraint pk_LopSH primary key(ID_Lop)
)
go

create table SV (
	MSSV nvarchar(10) not null,
	NameSV nvarchar(MAX),
	DTB float,
	ID_Lop int not null,
	constraint fk_SV foreign key(ID_Lop) references LopSH(ID_Lop),
	constraint pk_SV primary key(MSSV)
)

