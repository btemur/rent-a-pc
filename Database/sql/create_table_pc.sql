CREATE TABLE pc (
    pcid int NOT NULL AUTO_INCREMENT,
    pc varchar(255) NOT NULL,
	leasedto int,
    PRIMARY KEY (pcid),
    FOREIGN KEY (leasedto) REFERENCES user(userid)
);