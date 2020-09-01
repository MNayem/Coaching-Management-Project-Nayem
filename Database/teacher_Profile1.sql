create database Teacher_Profile

use Teacher_Profile

create table teacher_Profile(
Name varchar(50),
Institute varchar(50),
Subjects varchar(50),
Contact varchar(50),
Images image);

select *from teacher_Profile

delete from teacher_Profile where Name='Saifuk Islam Mollik';