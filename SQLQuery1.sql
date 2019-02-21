use SampleDB;

create table JOB(JOB_ID int primary key,JOB_TITLE varchar(500) not null,MIN_SALARY int,MAX_SALARY int);

create table EMP(EMP_NUM int primary key check(EMP_NUM<=1000 and EMP_NUM>0),EMP_LNAME varchar(500),EMP_FNAME varchar(500),EMP_INITIAL char(5) check(EMP_INITIAL between 'A' and 'z'),EMP_HIREDATE date not null,JOB_CODE int,Foreign key(JOB_CODE) references  JOB(JOB_ID));

insert into JOB values (5,'Sales',8000,10000);
select * from EMP
select * from JOB
insert into EMP values(5,'N','Manoj','M','2015-05-25',5);

Alter table Job Add STARS VARCHAR(5) DEFAULT '1 *';

ALTER TABLE Job
DROP COLUMN MAX_SALARY;

Drop table EMP;
Drop table JOB;