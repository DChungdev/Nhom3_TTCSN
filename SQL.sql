create database QLDiem
create table TAIKHOAN(
	userName varchar(30) primary key not null,
	passwords varchar(16) not null 
)
create table KHOA(
	maKhoa varchar(30) primary key not null,
	tenKhoa varchar(16) not null 
)
create table SINHVIEN(
	maSV varchar(10) primary key not null,
	tenSV varchar(32) not null,
	ngaySinh Date not null,
	gioiTinh nvarchar(5) not null,
	diaChi nvarchar(50) not null,
	soDT varchar(10) not null,
	email varchar(30) not null,
	userName varchar(30) not null
	foreign key (userName) references TAIKHOAN(userName)
)
create table GIAOVIEN(
	maGV varchar(30) primary key not null,
	hoTen varchar(32) not null,
	queQuan nvarchar(50) not null,
	soDT varchar(10) not null,
	trinhDoHocVan nvarchar(20) not null,
	userName varchar(30) not null
	foreign key (userName) references TAIKHOAN(userName),
	maKhoa varchar(30) not null
	foreign key (maKhoa) references KHOA(maKhoa)
)
create table 