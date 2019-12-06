DROP DATABASE IF EXISTS rent_a_pc;
CREATE DATABASE rent_a_pc;

USE rent_a_pc;

DROP TABLE IF EXISTS user;
CREATE TABLE user (
    userid int NOT NULL AUTO_INCREMENT,
    user varchar(255) NOT NULL,
    PRIMARY KEY (userid)
);

DROP TABLE IF EXISTS pc;
CREATE TABLE pc (
    pcid int NOT NULL AUTO_INCREMENT,
    pc varchar(255) NOT NULL,
	leasedto int,
    PRIMARY KEY (pcid),
    FOREIGN KEY (leasedto) REFERENCES user(userid)
);

insert into user(user)
values
("Kadie Lovell"),
("Jan Feeney"),
("Jonah Ingram"),
("Alan Crowther"),
("Keaton Clarke"),
("Aleisha Kouma"),
("Nabil Bradshaw"),
("Elias Cobb"),
("Harvey-Lee Davila"),
("Sammy-Jo Mullins");

insert into pc(pc, leasedto)
values
("Office PC", null),
("Gaming 1", 2),
("Gaming 2", null),
("Laptop 007", null),
("Laptop 44", null),
("Budget PC", 6)
