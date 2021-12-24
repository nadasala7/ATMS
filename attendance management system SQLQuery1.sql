CREATE DATABASE Attendance_Management_System;

CREATE TABLE User_Table
(
User_ID INT IDENTITY(1,1),
User_Name VARCHAR(150) UNIQUE,
User_Pass VARCHAR(150), 
User_Pho VARCHAR(15),
User_CNIC VARCHAR(15) UNIQUE,
User_DOB VARCHAR(10),
User_Gender VARCHAR(6),
User_Email VARCHAR(30),UNIQUE,
User_Role VARCHAR(5),
User_Add VARCHAR(150),
CONSTRAINT User_Table_PK PRIMARY KEY (User_ID)
);

INSERT INTO User_Table VALUES
('user','12345','+11 111 1111111','11111-1111111-1','12/1/2021','female','user@gmail.com','user','united state');
('admin','12345678','+22 222 2222222','22222-2222222-2','12/1/2021','female','admin@gmail.com','admin','canada');