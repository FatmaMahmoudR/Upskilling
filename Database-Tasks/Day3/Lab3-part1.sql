--1
select Dnum,Dname,SSN,Fname+Lname as 'full name'
from Departments as d, Employee as e
where d.MGRSSN = e.SSN

--2
select d.Dname,p.Pname
from Departments d, Project p
where d.Dnum = p.Dnum

--3
select  e.Fname+ e.Lname as 'employee name',d.*
from Employee e, Dependent d
where e.SSN = d.ESSN

--4
select p.Pnumber,p.Pname,p.Plocation
from Project p
where p.City = 'Cairo' or p.City ='Alex'

--5
select *
from Project p
where p.Pname like 'a%'

--6
select *
from Employee e
where e.Dno=30 and e.Salary>=1000 and e.Salary<=2000

--7
select e.Fname+ e.Lname as 'employee name'
from Employee e inner join Works_for w
on e.SSN = w.ESSn
inner join Project p
on w.Pno = p.Pnumber
where Pname='AL Rabwah' and w.Hours>=10 and e.Dno=10

--8
select x.Fname+ x.Lname as 'employee name'
from Employee x, Employee y
where y.ssn = x.Superssn and y.Fname='Kamel' and y.Lname='Mohamed'

--9
select e.Fname+ e.Lname as 'employee name',p.Pname 
from Employee e inner join Works_for w
on e.SSN = w.ESSn
inner join Project p
on w.Pno = p.Pnumber
order by p.Pname

--10
select p.Pnumber,d.Dname,e.Lname,e.Address,e.Bdate
from Project p , Departments d, Employee e 
where d.Dnum= p.Dnum and e.SSN=d.MGRSSN and p.City='Cairo'

--11
select distinct y.*
from Employee x , Employee y
where y.SSN = x.Superssn 

--12
select *
from Employee e left outer join Dependent d
on e.SSN = d.ESSN

--13
insert into Employee
values('fatma','mahmoud',102672,'07-21-2002','any address','F',3000,112233,30)

--14
insert into Employee
values('mariam','mahmoud',102660,'07-01-2002','any address','F',null,null,30)

--15
update Employee
set Salary*=1.2
where SSN=102672
