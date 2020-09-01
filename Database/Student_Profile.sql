create database Student_Profile

use Student_Profile

create table Student_Profile(
Name varchar(50),
Fathers_Name varchar(50),
Class varchar(50),
P_Address varchar(50),
Contact varchar(50),
Images image);

select *from Student_Profile

delete from Student_Profile WHERE Name='Galib Hossain';