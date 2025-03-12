create database day3part2


create table instructor
(
	ID int identity primary key,
	Salary float check (Salary between 1000 and 5000) default 3000,
	hiredate date default getdate(),
	address varchar(20) check (address in ('Cairo', 'Alex')),
	overTime float unique,
	BD date,
	Firstname varchar(20),
	Lastname varchar(20),

	Netsalary as(salary+overtime) persisted,
	age AS (year(getdate()) - year(BD))
)


create table Course (
    CID int identity primary key,
    CName varchar(50),
    Duration int unique
)


create table Lab (
    LID int identity,
	CID int,
    Location varchar(50),
    Capacity int check (Capacity < 20),

	constraint PK primary key(LID,CID),
    constraint LabCourseFK foreign key (CID) references Course(CID) 
        on delete cascade on update cascade
);

create table Teach (
    InstructorID int,
    CID int,

    constraint TeachPK primary key(InstructorID, CID),

    constraint TeachInstructorFK foreign key (InstructorID) references Instructor(ID) 
        on delete cascade on update cascade,

    constraint TeachCourseFK foreign key (CID) references Course(CID) 
        on delete cascade on update cascade
);